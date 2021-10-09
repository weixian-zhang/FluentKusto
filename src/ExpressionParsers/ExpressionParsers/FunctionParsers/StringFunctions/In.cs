using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class In : IStringFuncParser
    {
        public string Parse(Expression node)
        {
            string result = string.Empty;

            var methodExpr = (MethodCallExpression)node;

            //get property
            var memberExpr = (MemberExpression)methodExpr.Arguments[0];
            string propertyName = memberExpr.Member.Name;

            //get array of strings in "in (...) " func
            var arrayExpr = (NewArrayExpression)methodExpr.Arguments[1];

            var arrList = new List<string>();
            foreach(var exp in arrayExpr.Expressions)
            {
                var constExpr = (ConstantExpression)exp;
                string doubleQuoteArg = $"\"{constExpr.Value.ToString()}\"";
                arrList.Add(doubleQuoteArg);
            }

            string arrArgs = string.Join(", ",arrList.ToArray());
            string query = $"{propertyName} in ({arrArgs})";

            return query;
        }
    }
}