using System.Linq.Expressions;

namespace FluentKusto
{
    public interface IExpressionParser
    {
        public string Parse(Expression node);
    }
}