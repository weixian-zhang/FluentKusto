using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class StringFuncHelper
    {
        public static string GetMemberName(Expression node)
        {
            var methodExpr = (MethodCallExpression)node;

            var memberExpr = (MemberExpression)methodExpr.Arguments[0];

            return memberExpr.Member.Name;
        }

        public static string GetStringValue(Expression node)
        {
            var methodExpr = (MethodCallExpression)node;

            var constExpr = (ConstantExpression)methodExpr.Arguments[1];

            //kusto accepts double quotes for string value
            return $"\"{constExpr.Value.ToString()}\"";
        }
    }
}