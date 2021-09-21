using System.Linq.Expressions;

namespace FluentKusto
{
    public class BinaryExpressionParser : IExpressionParser
    {
        public string Parse(Expression node)
        {
            var binary = (BinaryExpression)node;

            return "";
        }
    }
}