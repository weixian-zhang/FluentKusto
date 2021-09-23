using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FluentKusto
{
    public static class FuncMaps
    {
        private static Dictionary<string, IFuncParser> _StringFunctions = new Dictionary<string, IFuncParser>();

        private static Dictionary<string, IFuncParser> _ScalarFunctions = new Dictionary<string, IFuncParser>();

        static FuncMaps()
        {
            InitStringFunctions();

            InitScalarFunctions();
        }

        private static void InitStringFunctions()
        {
            _StringFunctions.Add("equal", new StringEqualParser());
        }

        private static void InitScalarFunctions()
        {
             _ScalarFunctions.Add("ago", new AgoParser());
        }

        public static IFuncParser ResolveScalarFuncParser(string methodName)
        {
            var kv =_ScalarFunctions.FirstOrDefault(x => x.Key == methodName);

            if(kv.Key == null)
                throw new Exception($"Function {methodName} not found in FunctionMappings");

            return  kv.Value;
        }

        public static IFuncParser ResolveStringFuncParser(string methodName)
        {
            var kv =_ScalarFunctions.FirstOrDefault(x => x.Key == methodName);

            if(kv.Key == null)
                throw new Exception($"Function {methodName} not found in FunctionMappings");

            return  kv.Value;
        }
    }
}