using System.Linq.Expressions;

namespace FluentKusto
{
    public class MethodCallVisitor : IQueryParser
    {
        public string Visit(Expression node)
        {
             var member = (MethodCallExpression)node;

            return "";
        }
    }
}