using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public interface ITabularOperator<T>
    {
        public ITabularOperator<T> Where(Expression<Func<T,object>> where);

        public ITabularOperator<T> Project(Expression<Func<T,object>> project);

        public QueryResult Run();

        public string QueryAsString();
    }
}
