
using System.Collections.Generic;
using System.Linq;

namespace FluentKusto
{
    public class OperatorExtensionManager
    {
        private static List<CSharpFuncNameKqlFuncNameMap> _funcNameMap = new List<CSharpFuncNameKqlFuncNameMap>();

        public static List<CSharpFuncNameKqlFuncNameMap> FuncNameMap { get {return _funcNameMap;} }

        static OperatorExtensionManager()
        {
            InitFunctionNames();
        }

        private static void InitFunctionNames()
        {
            //datetime funcs
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.between\b\b", " between "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.notbetween\b", " !between "));

            //numeric funcs
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.In\b", " in "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.NotIn\b", " notin "));

            //string funcs
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.equal\b", " == "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.equalnoncase\b", " =~ "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.notequal\b", " != "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.notequalnoncase\b", " !~ "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.has\b", " has "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.hasnot\b", " !has "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.hasall\b", " has_all "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.hasany\b", " has_any "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.hascs\b", " has_cs "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.hascsnot\b", " !hasprefix_cs "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.hasprefix\b", " hasprefix "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.hasprefixnot\b", " !hasprefix "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.hasprefixcs\b", " hasprefix_cs "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.hasprefixcsnot\b", " !hasprefix_cs "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.hassuffix\b", " hassuffix "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.hassuffixnot\b", " !hassuffix "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.hassuffixcs\b", " hassuffix_cs "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.hassuffixcsnot\b", " !hassuffix_cs "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.contains\b", " contains "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.containsnot\b", " !contains "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.containscs\b", " contains_cs "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.containscsnot\b", " !contains_cs "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.startswith\b", " startswith "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.startswithnot\b", " !startswith "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.startswithcs\b", " startswith_cs "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.startswithcsnot\b", " !startswith_cs "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.endswith\b", " endswith "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.endswithnot\b", " !endswith "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.endswithcs\b", " endswith_cs "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.endswithcsnot\b", " !endswith_cs "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.matchregex\b", " match regex "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.In\b", " in "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.notin\b", " !in "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.innoncase\b", " in~ "));
            _funcNameMap.Add(new CSharpFuncNameKqlFuncNameMap(@"\b\.notinnoncase\b", " !in~ "));

        }

        // public static bool IsAnExtensionFunction(string funcName)
        // {
        //     bool result = _functionNames.Exists(x => x.ToLower() == funcName.ToLower());
        //     return result;
        // }
    }
}