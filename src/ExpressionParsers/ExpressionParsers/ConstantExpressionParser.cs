using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ConstantExpressionParser : IExpressionParser
    {
        public string Parse(Expression node)
        {
             var constant = (ConstantExpression)node;

             object value = constant.Value;

             // return lower case boolean as Kusto boolean is lower case
             if(value is bool)
                return value.ToString().ToLower();

            return constant.Value.ToString();
        }
    }
}