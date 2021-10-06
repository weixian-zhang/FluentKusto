using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public interface IJoinOn<TLeft, TRight>
    {
        public ITabularOperator<TLeft> On(Expression<Func<TLeft, TRight, object>> node);
    }
}