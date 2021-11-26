using System;
using System.Text.RegularExpressions;

namespace FluentKusto
{
    public sealed class WhereOperatorFuncRawCodeParser
    {
        public static string ParseRawCodeToKustoWithoutNewAnonymousObject(string rawCode)
        {
            string mainCode = GetMainCodeBlock(rawCode);

            string ampersandToAnd = ReplaceAmpersandWithAnd(mainCode);

            string pipesToOr = ReplacePipesWithOr(ampersandToAnd);

            string removeKqlAgoQuotes = FuncRawCodeParser.RemoveDoubleQuotesFromKqlAgo(pipesToOr);

            string kqlFuncRemoved = FuncRawCodeParser.RemoveKqlFuncs(removeKqlAgoQuotes);

            string replaceCSharpExtFuncNameWithKqlFuncName =
                FuncRawCodeParser.ParseExtensionFuncs(kqlFuncRemoved);

            return replaceCSharpExtFuncNameWithKqlFuncName;
        }

        private static string GetMainCodeBlock(string rawCode)
        {
            var funcParamNames = FuncRawCodeParser.GetFuncParameterNames(rawCode);

            string miscCharFree = CleanMiscChars(rawCode, funcParamNames);

            //regex lookaround, match any character until ";" is found without counting in ";"
            string mainCodeBlock = Regex.Match(miscCharFree, @"(?<=return )(.*)(?=;)").Value;

            return mainCodeBlock;
        }

        private static string ReplaceAmpersandWithAnd(string rawCode)
        {
            return Regex.Replace(rawCode, "&&", "and");
        }

        private static string ReplacePipesWithOr(string rawCode)
        {
            return Regex.Replace(rawCode, @"\|\|", "or");
        }

        private static string CleanMiscChars(string rawCode, Tuple<string,string> funcParamNames)
        {
            string noNewLine = FuncRawCodeParser.RemoveBreakline(rawCode);

            string cleanTableParam = Regex.Replace(noNewLine, $@"{funcParamNames.Item1}\.", "");

            string cleanDynamicColParam = Regex.Replace(cleanTableParam, $@"{funcParamNames.Item2}\.", "");

            return cleanDynamicColParam;
        }
    }
}