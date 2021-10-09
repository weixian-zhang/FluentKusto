using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class notequal : IStringFuncParser
    {
        public string Parse(Expression node)
        {
            string member = StringFuncHelper.GetMemberName(node);

            string val = StringFuncHelper.GetStringValue(node);

            return $"{member} != {val}";
        }
    }
}