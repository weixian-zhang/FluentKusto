using System.Linq.Expressions;

namespace FluentKusto
{
    public class MethodCallExpressionParser : IExpressionParser
    {
        public string Parse(Expression node)
        {
             var member = (MethodCallExpression)node;

            return "";
        }
    }
}