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
using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace FluentKusto
{
    public abstract class TableBase<T> : ITabularOperator<T> where T : new()
    {
        private QueryBuilder _QB;

        private List<OperatorExpression<T>> _opsExpression;

        public TableBase()
        {
            _QB = new QueryBuilder();

            InitQueryBuilderWithTable();

            _opsExpression = new List<FluentKusto.OperatorExpression<T>>();
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
            var whereVisitor = new WhereVisitor();

            string query = whereVisitor.ParseQuery(expression.Body);

            _QB.Append(query);

            return this;
        }

        // raw code e.g:
        //"internal object <Main>b__0_0(Update t, dynamic c)\r\n{\r\n\treturn new\r\n\t{\r\n\t\tResourceArray = (object)Kql.split(c.id_s, '/'),\r\n\t\tSecondLastResourceElement = (object)c.ResourceArray[0]\r\n\t};\r\n}\r\n"
        public ITabularOperator<T> Extend(Func<T, dynamic, object> func)
        {
            var assemFile = Assembly.GetCallingAssembly().Location;

            var decompiler = new CSharpDecompiler(assemFile, new DecompilerSettings());

            var handle = (MethodDefinitionHandle)MetadataTokens.EntityHandle(func.Method.MetadataToken);

            var funcRawCode = decompiler.DecompileAsString(handle);

            string cleansedCode = CleanUpDecompiledCode(funcRawCode);

            _QB.AppendPipeNewLine("extend");

            _QB.AppendWithSpace(cleansedCode);

            return this;
        }

        public ITabularOperator<T> Project(Expression<Func<T, object>> node)
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

        #region private helpers

         private string CleanUpDecompiledCode(string code)
        {
            List<string> chsarpTypeNames = GetCSharpCharsToRemoveFromCode(code);

            string noBreaklineCode = Regex.Replace(Regex.Replace(code, @"\n|\r", " "), @"\s+", " ");

            string removeCodeTillCurlyBracket =
                noBreaklineCode.Substring(noBreaklineCode.IndexOf('{'), noBreaklineCode.Length - noBreaklineCode.IndexOf('{'));

            string removeObjectCasting = removeCodeTillCurlyBracket.Replace("(object)", "");

            int indexOfEndOfCurlyBrac = removeObjectCasting.IndexOf("new ") + "new ".Length;

            int lastIndexOfCurlyBrac = removeObjectCasting.LastIndexOf("}") -1;

            string removeUpToReturnStatement = removeObjectCasting.Substring(indexOfEndOfCurlyBrac);

            string codeWithoutCloseCurlyBracEnd =  removeUpToReturnStatement.Remove(removeUpToReturnStatement.LastIndexOf('}') - 1, 2);

            string codeWithoutCSharpChars = RemoveCSharpCharsFromCode(codeWithoutCloseCurlyBracEnd, chsarpTypeNames);

            return codeWithoutCSharpChars;
        }

        // e.g (Update t, dynamic c), delete "t." and "c."
        private string RemoveCSharpCharsFromCode(string code, IEnumerable<string> typeNamesToRemove)
        {
            string codeNoTypes = code;

            foreach(string t in typeNamesToRemove)
            {
                codeNoTypes = codeNoTypes.Replace(t, "");
            }

            return codeNoTypes.Trim();
        }

        private List<string> GetCSharpCharsToRemoveFromCode(string code)
        {
             var typeNames = new List<string>(new string[]{"Kql.", "{", "}", ";"});

            Tuple<string, string> paramVars = GetFuncParamerVariables(code);

            string param1 = paramVars.Item1 + ".";
            string param2 = paramVars.Item2 + ".";

            typeNames.Add(param1);
            typeNames.Add(param2);

            return typeNames;
        }

        // e.g (Update t, dynamic c), get "t" and "c" variable names to remove them later
        private Tuple<string, string> GetFuncParamerVariables(string code)
        {
            string param1 = "";
            string param2 = "";

            int indexFirstBracker = code.IndexOf('(') + 1;
            int index2ndBracker = code.IndexOf(')');

            string paramsBetweenBrackets = code.Substring(indexFirstBracker, index2ndBracker - indexFirstBracker);

            string[] firstSecondParams = paramsBetweenBrackets.Split(',');

            string[] firstParam = firstSecondParams[0].Trim().Split(' ');

            param1 = firstParam[1];

            string[] secondParam = firstSecondParams[1].Trim().Split(' ');

            param2 = secondParam[1];

            return new Tuple<string, string>(param1, param2);
        }

        #endregion
    }
}
