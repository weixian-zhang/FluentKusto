namespace FluentKusto
{
    public interface IExpressionVisitorQuery<T>
    {
        public void ParseQuery(OperatorExpression<T> expression);
    }
}