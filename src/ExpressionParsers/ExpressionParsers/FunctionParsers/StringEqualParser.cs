using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class StringEqualParser : IFuncParser
    {
        public string Parse(Expression node)
        {
            var method = (MethodCallExpression)node;

            object arg = method.Arguments[0];

            string value = arg.ToString();

            return $"== \"{value}\"";
        }
    }
}