using System.Linq.Expressions;

namespace FluentKusto
{
    public class QueryParser
    {
        private QueryBuilder _queryBuilder;

        private WhereVisitor _WhereVisitor;

        public QueryParser( QueryBuilder queryBuilder)
        {
             _queryBuilder = queryBuilder;

            _WhereVisitor = new WhereVisitor();
        }

        public void ParseWhere(Expression expression)
        {
            string where = _WhereVisitor.ParseQuery(expression);

            _queryBuilder.Append(where);
        }
    }
}