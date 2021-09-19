using System.Linq.Expressions;

namespace FluentKusto
{
    public class MemberAccessVisitor : IQueryParser
    {
        public string Visit(Expression node)
        {
            var member = (MemberExpression)node;

            return "";
        }
    }
}