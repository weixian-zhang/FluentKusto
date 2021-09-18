using System.Collections.Generic;

namespace FluentKusto
{
    public static class KustoOperands
    {
        private static Dictionary<string, string> _StringOperands = new Dictionary<string, string>();

        private static Dictionary<string, string> _NumericOperands = new Dictionary<string, string>();

        private static Dictionary<string, string> _DateTimeOperands = new Dictionary<string, string>();

        private static Dictionary<string, string> _LogicalOperands = new Dictionary<string, string>();

        static KustoOperands()
        {
            InitStringOperands();

            InitNumericOperands();
        }

        private static void InitNumericOperands()
        {
            _NumericOperands.Add("+", "+");
            _NumericOperands.Add("-", "-");
            _NumericOperands.Add("/", "/");
            _NumericOperands.Add("%", "%");
            _NumericOperands.Add("<", "<");
            _NumericOperands.Add(">", ">");
            _NumericOperands.Add("==", "==");
            _NumericOperands.Add("!=", "!=");
            _NumericOperands.Add("<=", "<=");
            _NumericOperands.Add(">=", ">=");
            _NumericOperands.Add(">=", ">=");
            _NumericOperands.Add("in", "in");
            _NumericOperands.Add("notin", "!in");
        }


        private static void InitStringOperands()
        {
            _StringOperands.Add("equal", "==");

            _StringOperands.Add("notequal", "!=");
        }
    }
}