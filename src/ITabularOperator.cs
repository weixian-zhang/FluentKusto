using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public interface ITabularOperator<T>
    {
        public ITabularOperator<T> Where(Expression<Action<T>> expr);
    }
}
