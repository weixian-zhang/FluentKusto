using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FluentKusto
{
    public static class FunctionMappings
    {
        private static Dictionary<string, string> _StringFunctions = new Dictionary<string, string>();

        private static Dictionary<string, IFuncParser> _ScalarFunctions = new Dictionary<string, IFuncParser>();

        static FunctionMappings()
        {
            InitStringFunctions();

            InitScalarFunctions();
        }

        private static void InitStringFunctions()
        {
            _StringFunctions.Add("", "");
        }

        private static void InitScalarFunctions()
        {
             _ScalarFunctions.Add("ago", new AgoParser());
        }

        public static IFuncParser GetScalarFunctionParser(string methodName)
        {
            var kv =_ScalarFunctions.FirstOrDefault(x => x.Key == methodName);

            if(kv.Key == null)
                throw new Exception($"Function {methodName} not found in FunctionMappings");

            return  kv.Value;
        }
    }
}