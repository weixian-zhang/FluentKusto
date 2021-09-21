using System.Linq.Expressions;

namespace FluentKusto
{
    public class MemberExpressionParser : IExpressionParser
    {
        public string Parse(Expression node)
        {
            var member = (MemberExpression)node;

            return "";
        }
    }
}