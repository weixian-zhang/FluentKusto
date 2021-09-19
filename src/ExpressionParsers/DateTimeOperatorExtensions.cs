using System;

namespace FluentKusto
{
    public static class DateTimeOperatorExtensions
    {
        /// String operator ==
        public static bool between(this DateTime str, DateTime from, DateTime to) {
             return true;
        }

        /// String operator !=
        public static bool notbetween(this DateTime str, DateTime from, DateTime to) {
             return true;
        }
    }
}