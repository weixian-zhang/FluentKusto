using System.Linq.Expressions;

namespace FluentKusto
{
    public interface IQueryParser
    {
        public string Visit(Expression node);
    }
}