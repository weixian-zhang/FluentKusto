using System.Collections.Generic;

namespace FluentKusto
{
     /// Azure Kusto doc reference
     /// https://docs.microsoft.com/en-us/azure/data-explorer/kusto/query/datatypes-string-operators#operators-on-strings
    public static class StringOperatorExtensions
    {
        private static Dictionary<string, string> _CSharpFuncToKustoFuncNames = new Dictionary<string, string>();

        public static bool equal(this string str, string value) {
             return true;
        }

        public static bool equalnoncase(this string str, string value) {
             return true;
        }


        public static bool notequal(this string str, string value) {
             return true;
        }

        public static bool notequalnoncase(this string str, string value) {
             return true;
        }

        /// String operator ==
        public static bool has(this string str, string value) {
             return true;
        }

        /// String operator !=
        public static bool hasnot(this string str, string value) {
             return true;
        }

        /// Non case sensitive =~
        public static bool hasall(this string str, string value) {
            return true;
        }

        public static bool hasany(this string str, string value) {
            return true;
        }

        public static bool hascs(this string str, string value) {
            return true;
        }

        public static bool hascsnot(this string str, string value) {
            return true;
        }

        public static bool hasprefix(this string str, string value) {
            return true;
        }

        public static bool hasprefixnot(this string str, string value) {
            return true;
        }

        public static bool hasprefixcs(this string str, string value) {
            return true;
        }

        public static bool hasprefixcsnot(this string str, string value) {
            return true;
        }

        public static bool hassuffix(this string str, string value) {
            return true;
        }

        public static bool hassuffixnot(this string str, string value) {
            return true;
        }

        public static bool hassuffixcs(this string str, string value) {
            return true;
        }

        public static bool hassuffixcsnot(this string str, string value) {
            return true;
        }


        public static bool contains(this string str, string value) {
            return true;
        }

        public static bool containsnot(this string str, string value) {
            return true;
        }

        public static bool containscs(this string str, string value) {
            return true;
        }

        public static bool containscsnot(this string str, string value) {
            return true;
        }

        public static bool startswith(this string str, string value) {
            return true;
        }

        public static bool startswithnot(this string str, string value) {
            return true;
        }

        public static bool startswithcs(this string str, string value) {
            return true;
        }

        public static bool startswithcsnot(this string str, string value) {
            return true;
        }

        public static bool endswith(this string str, string value) {
            return true;
        }

        public static bool endswithnot(this string str, string value) {
            return true;
        }

        public static bool endswithcs(this string str, string value) {
            return true;
        }

        public static bool endswithcsnot(this string str, string value) {
            return true;
        }

        public static bool matchregex(this string str, string value) {
            return true;
        }

        public static bool In(this string str, params string[] value) {
            return true;
        }

        public static bool notin(this string str, string value) {
            return true;
        }

        public static bool innoncase(this string str, string value) {
            return true;
        }

        public static bool notinnoncase(this string str, string value) {
            return true;
        }
    }
}