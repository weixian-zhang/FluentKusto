using System.Linq.Expressions;

namespace FluentKusto
{
    /// Used mainly by MethodCallExpressionParser
    public interface IStringFuncParser
    {
        public string Parse(Expression node);
    }
}