using System.Linq.Expressions;

namespace FluentKusto
{
    /// Used mainly by MethodCallExpressionParser
    public interface IFuncParser
    {
        public string Parse(Expression node);
    }
}