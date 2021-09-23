using System.Linq.Expressions;

namespace FluentKusto
{
    public class BinaryExpressionParser : IExpressionParser
    {
        public string Parse(Expression node)
        {
            var binary = (BinaryExpression)node;

            string left = ExpressionParser.Parse(binary.Left);

            string operand = OperandMaps.ResolveNumericOperand(node.NodeType);

            string right = ExpressionParser.Parse(binary.Right);

            return (new QueryBuilder())
                .Append(left)
                .AppendWithSpace(operand)
                .AppendWithSpace(right).Query();
        }
    }
}