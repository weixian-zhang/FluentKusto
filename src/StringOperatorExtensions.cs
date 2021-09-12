namespace FluentKusto
{
    public static class StringOperatorExtensions
    {
        /// String operator ==
        public static bool equals(this string str, string value) {
             return true;
        }

        /// String operator !=
        public static bool notequals(this string str, string value) {
             return true;
        }

        /// Non case sensitive
        public static bool equalsnoncase(this string str, string value) {
            return true;
        }
    }
}