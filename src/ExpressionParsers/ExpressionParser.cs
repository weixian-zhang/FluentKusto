using System.Linq.Expressions;

namespace FluentKusto
{
    public class ExpressionParser<T>
    {
        private QueryBuilder _queryBuilder;

        private WhereVisitor<T> _WhereVisitor;

        public ExpressionParser( QueryBuilder queryBuilder)
        {
             _queryBuilder = queryBuilder;

            _WhereVisitor = new WhereVisitor<T>();
        }

        public void ParseWhere(Expression expression)
        {
            string where = _WhereVisitor.ParseQuery(expression);

            _queryBuilder.Append(where);
        }
    }
}