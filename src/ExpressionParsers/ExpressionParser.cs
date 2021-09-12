namespace FluentKusto
{
    public class ExpressionParser<T>
    {
        private QueryBuilder _queryBuilder;

        private WhereVisitor<T> _whereVisitor;

        public ExpressionParser( QueryBuilder _queryBuilder)
        {
             QueryBuilder queryBuilder = _queryBuilder;

            _whereVisitor = new WhereVisitor<T>(_queryBuilder);
        }

        public void ParseWhere(OperatorExpression<T> expression)
        {
            _whereVisitor.ParseQuery(expression);
        }
    }
}