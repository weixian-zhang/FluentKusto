using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using Azure.Monitor.Query;
using Azure.Monitor.Query.Models;
using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using Microsoft.Azure.ApplicationInsights.Query;
using Microsoft.Azure.ApplicationInsights.Query.Models;
using Microsoft.Rest;
using Microsoft.Rest.Azure.Authentication;

namespace FluentKusto
{
    public abstract class TableBase<T> : ITabularOperator<T>, IJoinOn<T>, IKqlExecutor where T : new()
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

        public ITabularOperator<T> Count()
        {
            _QB.AppendPipeNewLine("count");

            return this;
        }

        public ITabularOperator<T> Where(Func<T, dynamic, object> func)
        {
            //using FluentKusto;\r\n\r\ninternal object <Main>b__0_1(AzureActivity tbl, dynamic col)\r\n{\r\n\treturn tbl.SourceSystem.In(\"Sys A\", \"Sys B\", \"Sys X\") && col.DynamicTimeColumn > Kql.ago(\"8h\");\r\n}\r\n

           var assemFile = Assembly.GetCallingAssembly().Location;

            var decompiler = new CSharpDecompiler(assemFile, new DecompilerSettings());

            var handle = (MethodDefinitionHandle)MetadataTokens.EntityHandle(func.Method.MetadataToken);

            var funcRawCode = decompiler.DecompileAsString(handle);

            string query = WhereOperatorFuncRawCodeParser
                .ParseRawCodeToKustoWithoutNewAnonymousObject(funcRawCode);

            _QB.AppendPipeNewLine("where");

            _QB.AppendWithSpace(query);

            return this;
        }

        // public ITabularOperator<T> Where(Expression<Func<T,object>> expression)
        // {
        //     var whereVisitor = new WhereVisitor();

        //     string query = whereVisitor.ParseQuery(expression.Body);

        //     _QB.Append(query);

        //     return this;
        // }

        // raw code e.g:
        // internal object <Main>b__0_0(Update t, dynamic c)\r\n{\r\n\treturn new\r\n\t{\r\n\t\tResourceArray = (object)Kql.split(c.id_s, '/'),\r\n\t\tSecondLastResourceElement = (object)c.ResourceArray[0]\r\n\t};\r\n}\r\n"
        public ITabularOperator<T> Extend(Func<T, dynamic, object> func)
        {
            var assemFile = Assembly.GetCallingAssembly().Location;

            var decompiler = new CSharpDecompiler(assemFile, new DecompilerSettings());

            var handle = (MethodDefinitionHandle)MetadataTokens.EntityHandle(func.Method.MetadataToken);

            var funcRawCode = decompiler.DecompileAsString(handle);

            string query = FuncRawCodeParser.ParseRawCodeToKustoWithNewAnonymousObject(funcRawCode);

            _QB.AppendPipeNewLine("extend");

            _QB.AppendWithSpace(query);

            return this;
        }

        public ITabularOperator<T> Project(Func<T, dynamic, object> func)
        {
            var assemFile = Assembly.GetCallingAssembly().Location;

            var decompiler = new CSharpDecompiler(assemFile, new DecompilerSettings());

            var handle = (MethodDefinitionHandle)MetadataTokens.EntityHandle(func.Method.MetadataToken);

            var funcRawCode = decompiler.DecompileAsString(handle);

            string query = FuncRawCodeParser.ParseRawCodeToKustoWithNewAnonymousObject(funcRawCode);

            _QB.AppendPipeNewLine("project");

            _QB.AppendWithSpace(query);

            return this;
        }

        public IJoinOn<T> Join<TRight>
            (JoinKind kind, ITabularOperator<TRight> rightQuery)
        {
            string joinKind = $"kind={kind.ToString()}";

            string rq = rightQuery.QueryAsString();

            string fullJoinQuery = $"| join {joinKind} ({Environment.NewLine}{rq}{Environment.NewLine})";

            _QB.AppendWithSpace(fullJoinQuery);

            return this;
        }

        public ITabularOperator<T> On<TRight>(Expression<Func<T, TRight, object>> node)
        {
            var joinonVisitor = new JoinOnVisitor();

            string query = joinonVisitor.ParseQuery(node.Body);

            string fullOnQuery = $"on {query}";

             _QB.AppendNewLine(fullOnQuery);

            return this;
        }

        public ITabularOperator<T> Limit(int rows)
        {
            _QB
                .AppendPipeNewLine("limit")
                .AppendWithSpace(rows.ToString());

            return this;
        }

        public IKqlExecutor Run()
        {
            return this;
        }

        public string QueryAsString()
        {
            return _QB.Query();
        }

        public async Task<LogsQueryResult> OnLogAnalytics(string workspaceId)
        {
            var result = await ExecuteQueryOnLAW(workspaceId);
            return result;
        }

        public async Task<Tuple<LogsQueryResult, string>> OnLogAnalyticsWithQueryOutput(string workspaceId)
        {
            var result = await ExecuteQueryOnLAW(workspaceId);
            return new Tuple<LogsQueryResult, string>(result, _QB.Query());
        }

        public async Task<QueryResults> OnAppInsights(string tenantId, string appId, string clientId, string clientSecret)
        {
            var result = await ExecuteQueryOnAppInsights(tenantId, appId, clientId, clientSecret);
            return result;
        }



        public async Task<Tuple<QueryResults, string>> OnAppInsightsWithQueryOutput
            (string tenantId, string appId, string clientId, string clientSecret)
        {
            var result = await ExecuteQueryOnAppInsights(tenantId, appId, clientId, clientSecret);
            return new Tuple<QueryResults, string>(result, _QB.Query());
        }

        public ITabularOperator<T> Distinct(Func<T, dynamic, object> func)
        {
            var assemFile = Assembly.GetCallingAssembly().Location;

            var decompiler = new CSharpDecompiler(assemFile, new DecompilerSettings());

            var handle = (MethodDefinitionHandle)MetadataTokens.EntityHandle(func.Method.MetadataToken);

            var funcRawCode = decompiler.DecompileAsString(handle);

            string cleanedCode = FuncRawCodeParser.ParseRawCodeToKustoWithNewAnonymousObject(funcRawCode);

            string query = ToDistinctSyntax(cleanedCode);

            _QB.AppendPipeNewLine("distinct");

            _QB.AppendWithSpace(query);

            return this;
        }

        public ITabularOperator<T> DistinctAll()
        {
            _QB.AppendPipeNewLine("distinct *");

            return this;
        }


        #endregion ITabularOperator

        #region private helpers

        private async Task<LogsQueryResult> ExecuteQueryOnLAW(string workspaceId)
        {
            var azcred = new DefaultAzureCredential();

            var kqlClient = new LogsQueryClient(azcred);

            string query = _QB.Query();

            Response<LogsQueryResult> response =
                await kqlClient.QueryWorkspaceAsync(workspaceId, query, new QueryTimeRange());

            LogsQueryResult result =  response.Value;

            return result;
        }

        private async Task<QueryResults> ExecuteQueryOnAppInsights
            (string tenantId, string appId, string clientId, string clientSecret)
        {
            try
            {
                var authEndpoint = "https://login.microsoftonline.com";
                var tokenAudience = "https://api.applicationinsights.io/";

                var adSettings = new ActiveDirectoryServiceSettings
                {
                    AuthenticationEndpoint = new Uri(authEndpoint),
                    TokenAudience = new Uri(tokenAudience),
                    ValidateAuthority = true
                };

                var azcred = await ApplicationTokenProvider.LoginSilentAsync
                    (tenantId, clientId, clientSecret, adSettings);

                var appinsightsClient = new ApplicationInsightsDataClient(azcred);

                var result = await appinsightsClient.Query.ExecuteAsync(appId, _QB.Query());

                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void InitQueryBuilderWithTable()
        {
            string table = CurrentTableName();

            _QB.Append($"{table}");
        }

        private string ToRawCode(Func<T, dynamic, object> func)
        {
            var assemFile = Assembly.GetCallingAssembly().Location;

            var decompiler = new CSharpDecompiler(assemFile, new DecompilerSettings());

            var handle = (MethodDefinitionHandle)MetadataTokens.EntityHandle(func.Method.MetadataToken);

            var funcRawCode = decompiler.DecompileAsString(handle);

            string query = FuncRawCodeParser.ParseRawCodeToKustoWithNewAnonymousObject(funcRawCode);

            return query;
        }

        // private string ParseRawCodeToKustoWithNewAnonymousObject(string code)
        // {
        //     List<string> chsarpTypeNames = GetCSharpCharsToRemoveFromCode(code);

        //     string noBreaklineCode = Regex.Replace(Regex.Replace(code, @"\n|\r", " "), @"\s+", " ");

        //     string removeCodeTillCurlyBracket =
        //         noBreaklineCode.Substring(noBreaklineCode.IndexOf('{'), noBreaklineCode.Length - noBreaklineCode.IndexOf('{'));

        //     string removeObjectCasting = removeCodeTillCurlyBracket.Replace("(object)", "");

        //     int indexOfEndOfCurlyBrac = removeObjectCasting.IndexOf("new ") + "new ".Length;

        //     int lastIndexOfCurlyBrac = removeObjectCasting.LastIndexOf("}") -1;

        //     string removeUpToReturnStatement = removeObjectCasting.Substring(indexOfEndOfCurlyBrac);

        //     string codeWithoutCloseCurlyBracEnd =  removeUpToReturnStatement.Remove(removeUpToReturnStatement.LastIndexOf('}') - 1, 2);

        //     string codeWithoutCSharpChars = RemoveCSharpCharsFromCode(codeWithoutCloseCurlyBracEnd, chsarpTypeNames);

        //     return codeWithoutCSharpChars;
        // }

        // take only Property name. E.g = Approved = t.Approved,
        // take on property Approved and not "== t.Approved"
        private string ToDistinctSyntax(string cleansedRawCode)
        {
            var propNameOnly = new List<string>();

            string[] byComma = cleansedRawCode.Split(",");

            foreach(string c in byComma)
            {
                string[] byEqual = c.Split("=");

                propNameOnly.Add(byEqual[0].Trim());
            }

            return string.Join(", ", propNameOnly.ToArray());
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

            Tuple<string, string> paramVars = GetFuncParamerNames(code);

            string param1 = paramVars.Item1 + ".";
            string param2 = paramVars.Item2 + ".";

            typeNames.Add(param1);
            typeNames.Add(param2);

            return typeNames;
        }

        // e.g (Update t, dynamic c), get "t" and "c" variable names to remove them later
        private Tuple<string, string> GetFuncParamerNames(string code)
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
