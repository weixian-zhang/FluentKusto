
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FluentKusto
{
    public class FuncRawCodeParser
    {
        public string Parse(string rawFuncCode)
        {
            return "";
        }

        public static string ParseRawCodeToKustoWithNewAnonymousObject(string code)
        {
            string codeWithFuncParamNames = RemoveFuncParamaterNames(code);

            string noBreaklineCode = RemoveBreakline(codeWithFuncParamNames);

            //use regex to get main code block
            //(?<=return new\s{)(.*)(?<=};)
            //sample: "using FluentKusto; internal object <Main>b__0_0(AzureActivity tbl, dynamic col) { return new { DynamicTimeColumn = tbl.TimeGenerated, SplittedRSC = (object)Kql.split(tbl._ResourceId, '/') }; } "

            string outMainCodeBlock = "";
            if(!GetMainCodeBlock(noBreaklineCode, out outMainCodeBlock))
                throw new Exception($"Not able to find parsable code block from decompiled Func: {code}");

            string removeObjectCasting = outMainCodeBlock.Replace("(object)", "");

            string kqlFuncRemoved = FuncRawCodeParser.RemoveKqlFuncs(removeObjectCasting);

            return kqlFuncRemoved.Trim();
        }

        private static bool GetMainCodeBlock(string rawCode, out string mainCodeBlock)
        {

            //regex lookaround, match any character until ";" is found without counting in ";"
            var match = Regex.Match(rawCode, @"(?<=return\snew\s{)(.*)(?=\s};)");

            if(!match.Success)
            {
                mainCodeBlock = rawCode;
                return false;
            }

            mainCodeBlock = match.Value;

            return true;
        }

        // e.g (Update t, dynamic c), delete "t." and "c."
        private static string RemoveCSharpCharsFromCode(string code, IEnumerable<string> typeNamesToRemove)
        {
            string codeNoTypes = code;

            foreach(string t in typeNamesToRemove)
            {
                codeNoTypes = codeNoTypes.Replace(t, "");
            }

            return codeNoTypes.Trim();
        }

        private static string RemoveFuncParamaterNames(string code)
        {
            Tuple<string, string> paramVars = GetFuncParameterNames(code);

            string param1 = paramVars.Item1 + ".";
            string param2 = paramVars.Item2 + ".";

            code = code.Replace(param1, "");
            code = code.Replace(param2, "");

            return code.Trim();
        }

        public static string RemoveBreakline(string rawCode)
        {

            string noBreaklineCode = Regex.Replace(Regex.Replace(rawCode, @"\n|\r", " "), @"\s+", " ");
            return noBreaklineCode;
        }

        // e.g (Update t, dynamic c), get "t" and "c" variable names to remove them later
        public static Tuple<string, string> GetFuncParameterNames(string code)
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

        public static string RemoveKqlFuncs(string rawCode)
        {
            string removeKql = Regex.Replace(rawCode, @"\bKql\.\b", "");
            return removeKql;
        }

        public static string RemoveDoubleQuotesFromKqlAgo(string rawCode)
        {
            string period = Regex.Escape(".");
            string backslash = Regex.Escape("\\");
            string plus = Regex.Escape("+");
            string regexPattern = $"Kql{period}ago{backslash}({backslash}({period + plus}){backslash}\")";

            var kqlAgoMatch =
                Regex.Match(rawCode, @"Kql\.ago\((.+)""\)");

            if(!kqlAgoMatch.Success)
                return rawCode;

            string kqlAgoMatchVal = kqlAgoMatch.Value;

            string kqlagoWithoutQuotes = kqlAgoMatchVal.Replace("\"", "");

            return rawCode.Replace(kqlAgoMatchVal, kqlagoWithoutQuotes);
        }

        public static string ParseExtensionFuncs(string rawCode)
        {
            string replaceResult = rawCode;

            foreach(var map in OperatorExtensionManager.FuncNameMap)
            {
                var match = Regex.Match(rawCode, $"{map.RegexFuncNamePattern}");

                if(match.Success)
                {
                    replaceResult = Regex.Replace(replaceResult, match.Value, map.KqlFuncName);
                }
            }

            return replaceResult;
        }
    }
}