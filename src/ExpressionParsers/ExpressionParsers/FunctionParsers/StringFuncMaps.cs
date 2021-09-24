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