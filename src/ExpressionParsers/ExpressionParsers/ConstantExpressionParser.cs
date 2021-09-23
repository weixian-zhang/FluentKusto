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

             // return lower case boolean as Kusto boolean prefers lower case
             if(value is bool)
                return value.ToString().ToLower();

             //double quote string values
             if(value is string)
                return $"\"{value.ToString()}\"";

            return constant.Value.ToString();
        }
    }
}