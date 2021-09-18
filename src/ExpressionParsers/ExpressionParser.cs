using System.Linq.Expressions;

namespace FluentKusto
{
    public class ExpressionParser<T>
    {
        private QueryBuilder _queryBuilder;

        private WhereVisitor<T> _WhereVisitor;

        public ExpressionParser( QueryBuilder _queryBuilder)
        {
             QueryBuilder queryBuilder = _queryBuilder;

            _WhereVisitor = new WhereVisitor<T>(_queryBuilder);
        }

        public void ParseWhere(Expression expression)
        {
            string where = _WhereVisitor.ParseQuery(expression);
        }
    }
}