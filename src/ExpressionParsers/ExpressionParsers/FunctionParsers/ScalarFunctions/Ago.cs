using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class Ago : IFuncParser
    {
        public string Parse(Expression node)
        {
            var method = (MethodCallExpression)node;

            object arg = method.Arguments[0];

            string timespan = arg.ToString();

            //remove double quotes as kusto accepts e.g ago(4h) with no quotes
            timespan = timespan.Replace("\"", "");

            if(string.IsNullOrEmpty(timespan))
                throw new Exception("Missing argument in ago(), e.g 1d, 1m, 4h");

            return $"ago({timespan})";
        }
    }
}