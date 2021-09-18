namespace FluentKusto
{
    public static class StringOperatorExtensions
    {
        /// String operator ==
        public static bool equal(this string str, string value) {
             return true;
        }

        /// String operator !=
        public static bool notequal(this string str, string value) {
             return true;
        }

        /// Non case sensitive =~
        public static bool equalnoncase(this string str, string value) {
            return true;
        }
    }
}