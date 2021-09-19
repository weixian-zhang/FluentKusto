using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FluentKusto
{
    public static class KustoHelper
    {
        private static Dictionary<string, string> _StringComparisionOperands = new Dictionary<string, string>();

        private static Dictionary<ExpressionType, string> _NumericComparisonOperands = new Dictionary<ExpressionType, string>();

        private static Dictionary<string, string> _DateTimeComparisionOperands = new Dictionary<string, string>();

        private static Dictionary<ExpressionType, string> _LogicalComparisonOperands = new Dictionary<ExpressionType, string>();

        static KustoHelper()
        {
            InitStringComparisonOperands();

            InitNumericComparisonOperands();

            InitLogicalComparisonOperands();
        }

        private static void InitNumericComparisonOperands()
        {
            _NumericComparisonOperands.Add(ExpressionType.Add, "+");
            _NumericComparisonOperands.Add(ExpressionType.Subtract, "-");
            _NumericComparisonOperands.Add(ExpressionType.Divide, "/");
            _NumericComparisonOperands.Add(ExpressionType.Multiply, "*");
            _NumericComparisonOperands.Add(ExpressionType.Modulo, "%");
            _NumericComparisonOperands.Add(ExpressionType.LessThan, "<");
            _NumericComparisonOperands.Add(ExpressionType.GreaterThan, ">");
            _NumericComparisonOperands.Add(ExpressionType.Equal, "==");
            _NumericComparisonOperands.Add(ExpressionType.NotEqual, "!=");
            _NumericComparisonOperands.Add(ExpressionType.LessThanOrEqual, "<=");
        }

        private static void InitStringComparisonOperands()
        {
            _StringComparisionOperands.Add("equal", "==");

            _StringComparisionOperands.Add("notequal", "!=");
        }

        private static void InitLogicalComparisonOperands()
        {
            _LogicalComparisonOperands.Add(ExpressionType.AndAlso, "and");

            _LogicalComparisonOperands.Add(ExpressionType.OrElse, "or");
        }

        #region 'Is' check helpers

        public static bool IsComparisonOperand(Expression node)
        {
            return _NumericComparisonOperands.Keys.ToList().Exists(x => x == node.NodeType);
        }

        public static bool IsMemberAccess(Expression node)
        {
            if(node.NodeType == ExpressionType.MemberAccess)
                return true;
            else
                return false;
        }

        public static bool IsBinary(Expression node)
        {
            if(node is BinaryExpression)
                return true;
            else
                return false;
        }

        public static bool IsAndOr(Expression node)
        {
            if(node.NodeType == ExpressionType.OrElse ||
                node.NodeType == ExpressionType.AndAlso)
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}