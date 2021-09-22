using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FluentKusto
{
    public static class OperandMappings
    {
        private static Dictionary<string, string> _StringComparisionOperands = new Dictionary<string, string>();

        private static Dictionary<ExpressionType, string> _NumericComparisonOperands = new Dictionary<ExpressionType, string>();

        private static Dictionary<string, string> _DateTimeComparisionOperands = new Dictionary<string, string>();

        private static Dictionary<ExpressionType, string> _LogicalComparisonOperands = new Dictionary<ExpressionType, string>();

        static OperandMappings()
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

        /// string operands are "mostly" implemented using Extension methods.
        /// Key here is method name of Extension methods.
        private static void InitStringComparisonOperands()
        {
            _StringComparisionOperands.Add("equal", "==");

            _StringComparisionOperands.Add("notequal", "!=");
        }

        private static void InitLogicalComparisonOperands()
        {
            _LogicalComparisonOperands.Add(ExpressionType.Equal, "==");

            _LogicalComparisonOperands.Add(ExpressionType.NotEqual, "!=");

            _LogicalComparisonOperands.Add(ExpressionType.AndAlso, "and");

            _LogicalComparisonOperands.Add(ExpressionType.OrElse, "or");
        }

        public static string GetOperand(ExpressionType ntype)
        {
            if(_NumericComparisonOperands.Keys.ToList().Exists(x => x == ntype))
            {
                var kv = _NumericComparisonOperands.FirstOrDefault(x => x.Key == ntype);
                return kv.Value;
            }

            if(_LogicalComparisonOperands.Keys.ToList().Exists(x => x == ntype))
            {
                var kv = _NumericComparisonOperands.FirstOrDefault(x => x.Key == ntype);
                return kv.Value;
            }

            throw new Exception($"Operand not found for {ntype.ToString()}");
        }
    }
}