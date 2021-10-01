using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.Metadata;
using ICSharpCode.ILSpy;
using Mono.Cecil;

namespace FluentKusto
{
    class CustomAssemblyResolver : ICSharpCode.Decompiler.Metadata.IAssemblyResolver
    {
    private Dictionary<string, Assembly> _references;

    public CustomAssemblyResolver(Assembly asm)
    {
        _references = new Dictionary<string, Assembly>();
        var stack = new Stack<Assembly>();
        stack.Push(asm);

        while (stack.Count > 0)
        {
            var top = stack.Pop();
            if (_references.ContainsKey(top.FullName)) continue;

            _references[top.FullName] = top;

            var refs = top.GetReferencedAssemblies();
            if (refs != null && refs.Length > 0)
            {
                foreach (var r in refs)
                {
                    stack.Push(Assembly.Load(r));
                }
            }
        }

        ;
    }

        public PEFile Resolve(IAssemblyReference reference)
        {
            var asm = _references[reference.FullName];
            var file = asm.Location;
            return new PEFile(file, new FileStream(file, FileMode.Open, FileAccess.Read), PEStreamOptions.Default, MetadataReaderOptions.Default);
        }

        public async Task<PEFile> ResolveAsync(IAssemblyReference reference)
        {
            var asm = _references[reference.FullName];
            var file = asm.Location;
            var t = Task.Run (() => new PEFile(file, new FileStream(file, FileMode.Open, FileAccess.Read), PEStreamOptions.Default, MetadataReaderOptions.Default));

            return t.Result;
        }

        public PEFile ResolveModule(PEFile mainModule, string moduleName)
        {
            var baseDir = Path.GetDirectoryName(mainModule.FileName);
            var moduleFileName = Path.Combine(baseDir, moduleName);
            if (!File.Exists(moduleFileName))
            {
                throw new Exception($"Module {moduleName} could not be found");
            }

            return new PEFile(moduleFileName, new FileStream(moduleFileName, FileMode.Open, FileAccess.Read), PEStreamOptions.Default, MetadataReaderOptions.Default);
        }

        public async Task<PEFile> ResolveModuleAsync(PEFile mainModule, string moduleName)
        {
            var baseDir = Path.GetDirectoryName(mainModule.FileName);
            var moduleFileName = Path.Combine(baseDir, moduleName);
            if (!File.Exists(moduleFileName))
            {
                throw new Exception($"Module {moduleName} could not be found");
            }
            var t = Task.Run
                (() => new PEFile(moduleFileName, new FileStream(moduleFileName, FileMode.Open, FileAccess.Read), PEStreamOptions.Default, MetadataReaderOptions.Default));

            return t.Result;
        }
    }


    public abstract class TableBase<T> : ITabularOperator<T> where T : new()
    {
        private QueryBuilder _QB;

        private QueryParser _queryParser;

        private List<OperatorExpression<T>> _opsExpression;

        public TableBase()
        {
            _QB = new QueryBuilder();

            InitQueryBuilderWithTable();

            _opsExpression = new List<FluentKusto.OperatorExpression<T>>();

            _queryParser = new QueryParser(_QB);
        }

        #region Non Operator methods

        private string CurrentTableName()
        {
            Type thisTableType = this.GetType();

            return thisTableType.Name;
        }

        #endregion

        #region ITabularOperator

        //where
        //count
        //project
        //extend
        //join

        public ITabularOperator<T> Count()
        {
            _QB.AppendPipeNewLine("count");

            return this;
        }

        public ITabularOperator<T> Where(Expression<Func<T,object>> expression)
        {
            string where = _queryParser.ParseWhere(expression.Body);

            _QB.Append(where);

            return this;
        }

        // private static Expression<Func<T, dynamic, object>> FuncToExpression(Expression<Func<T, dynamic, object>> func)
        // {
        //     return (t, c) => func(t, c);
        // }

        //https://stackoverflow.com/questions/29944137/expression-trees-with-dynamic-parameter



        public ITabularOperator<T> Extend(Func<T, dynamic, object> action)
        {
            // https://stackoverflow.com/questions/29567489/can-roslyn-generate-source-code-from-an-object-instance
            // https://stackoverflow.com/questions/57231579/decompiling-anonymous-method-il-in-net-core

            // * https://csharp.hotexamples.com/examples/-/ICSharpCode.Decompiler.PlainTextOutput/-/php-icsharpcode.decompiler.plaintextoutput-class-examples.html

            var asm = Assembly.GetCallingAssembly();
            var file = asm.Location;

            var decompiler = new CSharpDecompiler(file, new DecompilerSettings());

            var handle = (MethodDefinitionHandle)MetadataTokens.EntityHandle(action.Method.MetadataToken);

            var funcRawCode = decompiler.DecompileAsString(handle);//(new List<EntityHandle>() { method.Value });

            string noBreaklineCode = Regex.Replace(Regex.Replace(funcRawCode, @"\n|\r", " "), @"\s+", " ");

            string removeCodeTillCurlyBracket =
                noBreaklineCode.Substring(noBreaklineCode.IndexOf('{'), noBreaklineCode.Length - noBreaklineCode.IndexOf('{'));

            string removeObjectCasting = removeCodeTillCurlyBracket.Replace("(object)", "");

            return this;
        }


        public ITabularOperator<T> Project<TTable>(params Func<TTable, object>[] cols)
        {
           //_QB.AppendPipeNewLine("project " + string.Join(", ", args));

           return this;
        }

        public QueryResult Run()
        {
            //TODO:
            // - call Azure Monitor Query library for DefaultAuth
            // - or call Log Analytics via Http to support Workspace key, assuming Az Monitor Query
            //does not support Woekspace key
            throw new NotImplementedException();
        }

        public string QueryAsString()
        {
            return _QB.Query();
        }

        #endregion ITabularOperator


        public void InitQueryBuilderWithTable()
        {
            string table = CurrentTableName();

            _QB.Append($"{table}");
        }

        // private Expression<Func<T, dynamic, object>> FuncToExpression(Func<T, dynamic, object> f)
        // {
        //     var mInfo = f.Method.ReturnType.GetMethods().First();

        //     var anonyObj = mInfo.GetType();

        //     bool isAnonym = anonyObj.Name.Contains("AnonymousType");



        //     //var member = anonyObj.GetType().GetMember("MinusTime");


        //     dynamic c = new ExpandoObject();
        //     c.PublishedDate = DateTime.Now;

        //     return f(new T(), c);
        // }

        // private Expression<Func<T, dynamic, object>>
        //     ConvertExpression<TTable, TDynamic, TAnonymousObjectOutput>
        //         (Expression<Func<TTable, TDynamic, TAnonymousObjectOutput>> expression)
        // {
        //     Expression<Func<object, TTable>> convertToTableInput = table => (TTable)table;

        //     Expression<Func<object, TDynamic>> convertToDynamicInput = dyna => (TDynamic)dyna;

        //     Expression<Func<TAnonymousObjectOutput, object>> convertToAnonyObjectOutput = anonymObj => (object)anonymObj;

        //     // The following doesn't compile: var input = Expression.Parameter(typeof(dynamic), "input");

        //     // var tableExpr = Expression.Parameter(typeof(object), "table");

        //     // var dynamicExpr = Expression.Parameter(typeof(object), "dynamicVal");

        //     // Expression<Func<TOutput, dynamic>> convertToOutput = value => (dynamic)value;

        //     var body = Expression.Invoke(convertToAnonyObjectOutput, Expression.Invoke(expression, Expression.Invoke(convertToInput, input)));
        //     var lambda = Expression.Lambda<Func<dynamic, dynamic>>(body, input);

        //     return lambda;
        // }
    }
}
