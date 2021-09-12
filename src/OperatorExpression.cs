using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class OperatorExpression<T>
    {
        private string _operatorName;
        private Expression<Func<T, object>> _expression;

        public Expression<Func<T, object>>  Operator
        {
            get
            {
                return _expression;
            }
            set
            {
                _expression = value;
            }
         }

        public OperatorExpression(string operatorName, Expression<Func<T, object>> expression)
        {
            _operatorName = operatorName;
            _expression = expression;
        }
    }
}