using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace FluentKusto
{
    public static class StringFuncMaps
    {
        private static Dictionary<string, string> _StringFuncToKustoOperands = new Dictionary<string, string>();

        static StringFuncMaps()
        {
            InitStringFunctions();
        }

        private static void InitStringFunctions()
        {
            _StringFuncToKustoOperands.Add("equal", "==");

            _StringFuncToKustoOperands.Add("notequal", "!=");

            _StringFuncToKustoOperands.Add("equalnoncase", "=~");

            _StringFuncToKustoOperands.Add("notequalnoncase", "!~");

            _StringFuncToKustoOperands.Add("has", "has");

            _StringFuncToKustoOperands.Add("hasnot", "!has");

            _StringFuncToKustoOperands.Add("hasall", "has_all");

            _StringFuncToKustoOperands.Add("hasany", "has_any");

            _StringFuncToKustoOperands.Add("hascs", "has_cs");

            _StringFuncToKustoOperands.Add("hascsnot", "!has_cs");

            _StringFuncToKustoOperands.Add("hasprefix", "!has_cs");

            _StringFuncToKustoOperands.Add("hasprefixnot", "!hasprefix");

            _StringFuncToKustoOperands.Add("hasprefixcs", "hasprefix_cs");

            _StringFuncToKustoOperands.Add("hasprefixcsnot", "!hasprefix_cs");

            _StringFuncToKustoOperands.Add("hassuffix", "hassuffix");

            _StringFuncToKustoOperands.Add("hassuffixnot", "!hassuffix");

            _StringFuncToKustoOperands.Add("hassuffixcs", "hassuffix_cs");

            _StringFuncToKustoOperands.Add("hassuffixcsnot", "!hassuffix_cs");

            _StringFuncToKustoOperands.Add("contains", "contains");

            _StringFuncToKustoOperands.Add("containsnot", "!contains");

            _StringFuncToKustoOperands.Add("containscs", "contains_cs");

            _StringFuncToKustoOperands.Add("containscsnot", "!contains_cs");

            _StringFuncToKustoOperands.Add("startswith", "startswith");

            _StringFuncToKustoOperands.Add("startswithnot", "!startswith");

            _StringFuncToKustoOperands.Add("startswithcs", "startswith_cs");

            _StringFuncToKustoOperands.Add("startswithcsnot", "!startswith_cs");

            _StringFuncToKustoOperands.Add("endswith", "endswith");

            _StringFuncToKustoOperands.Add("endswithnot", "!endswith");

            _StringFuncToKustoOperands.Add("endswithcs", "endswith_cs");

            _StringFuncToKustoOperands.Add("endswithcsnot", "!endswith_cs");

            _StringFuncToKustoOperands.Add("matchregex", "matches regex");

            _StringFuncToKustoOperands.Add("In", "in");

            _StringFuncToKustoOperands.Add("notin", "!in");

            _StringFuncToKustoOperands.Add("innoncase", "in~");

            _StringFuncToKustoOperands.Add("notinnoncase", "!in~");
        }

        public static string ParseStringMethod(Expression node)
        {
            var methodCallExpr = (MethodCallExpression)node;

            MethodInfo method = methodCallExpr.Method;

            //member
            var member = (MemberExpression)methodCallExpr.Arguments[0];
            string memberName = ExpressionParser.Parse(member);

            //constant string value
            var constant = (ConstantExpression)methodCallExpr.Arguments[1];
            string constVal = ExpressionParser.Parse(constant);

            //logicla operand
            string stringOperand = GetStringOperand(method.Name);

            return $"{memberName} {stringOperand} \"{constVal}\"";
        }

        private static string GetStringOperand(string methodName)
        {
            var kv =_StringFuncToKustoOperands.FirstOrDefault(x => x.Key == methodName);

            if(kv.Key == null)
                throw new Exception($"String func {methodName} not found in StringFuncMaps");

            return  kv.Value;
        }
    }
}