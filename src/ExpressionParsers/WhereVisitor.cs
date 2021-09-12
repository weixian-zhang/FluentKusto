using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class WhereVisitor<T> : ExpressionVisitor, IExpressionVisitorQuery<T>
    {

        private QueryBuilder _queryBuilder;
        private OperatorExpression<T> _expression;

        public WhereVisitor(QueryBuilder queryBuilder)
        {
            _queryBuilder = queryBuilder;
        }

        public void ParseQuery(OperatorExpression<T> expression)
        {
            _expression = expression;

            Visit(expression.Operator);

            //TODO
            //parse to kusto query
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
           var val = node.Value;
           return node;
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            var val = node.Name;
            return node;
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {

            return node;
        }


    }
}