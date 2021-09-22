namespace FluentKusto
{
    public static class NumericOperatorExtensions
    {
        /// String operator ==
        public static bool In(this int str, int value) {
             return true;
        }

        /// String operator !=
        public static bool NotIn(this int str, int value) {
             return true;
        }
    }
}