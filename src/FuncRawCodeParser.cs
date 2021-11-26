
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
            List<string> chsarpTypeNames = GetCSharpCharsToRemoveFromCode(code);

            string noBreaklineCode = RemoveBreakline(code);

            //use regex to get main code block
            //(?<=return new\s{)(.*)(?<=};)

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
        private static string RemoveCSharpCharsFromCode(string code, IEnumerable<string> typeNamesToRemove)
        {
            string codeNoTypes = code;

            foreach(string t in typeNamesToRemove)
            {
                codeNoTypes = codeNoTypes.Replace(t, "");
            }

            return codeNoTypes.Trim();
        }

        private static List<string> GetCSharpCharsToRemoveFromCode(string code)
        {
             var typeNames = new List<string>(new string[]{"{", "}", ";"});

            Tuple<string, string> paramVars = GetFuncParameterNames(code);

            string param1 = paramVars.Item1 + ".";
            string param2 = paramVars.Item2 + ".";

            typeNames.Add(param1);
            typeNames.Add(param2);

            return typeNames;
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