using System.Linq.Expressions;

namespace FluentKusto
{
    public interface IOperatorExpressionVisitor
    {
         public string ParseQuery(Expression node);
    }
}