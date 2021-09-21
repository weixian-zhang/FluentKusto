using System.Linq.Expressions;

namespace FluentKusto
{
    public class ConstantExpressionParser : IExpressionParser
    {
        public string Parse(Expression node)
        {
             var constant = (ConstantExpression)node;

            return "";
        }
    }
}