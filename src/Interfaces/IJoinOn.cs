using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public interface IJoinOn<TLeft>
    {
        public ITabularOperator<TLeft> On<TRight>(Expression<Func<TLeft, TRight, object>> node);
    }
}