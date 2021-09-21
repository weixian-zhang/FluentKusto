using System.Linq.Expressions;

namespace FluentKusto
{
    public class ExpressionElement
    {
        public ExpressionElement(ExpressionType conditionType)
        {
            ConditionType = conditionType;
        }

        public ExpressionElement(Expression node)
        {
            ConditionType = ExpressionType.Lambda;
            Node = node;
        }

        public ExpressionType ConditionType { get; set; } = ExpressionType.Lambda;
        public Expression Node { get; set; }
    }
}