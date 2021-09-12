using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public interface IScalarFunction
    {
        /// Timespan can be minute, hour or day. m = minute, h = hour, d = day
        public IScalarFunction ago(string timespan);
    }
}