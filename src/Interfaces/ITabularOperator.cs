using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class Column
    {
        private object _column;

        public object this[object col]
        {
            get { return _column; }
            set { _column = value; }
        }
    }

    public interface ITabularOperator<T>
    {
        public ITabularOperator<T> Count();

        public ITabularOperator<T> Where(Expression<Func<T,object>> where);

        public ITabularOperator<T> Project<TTable>(params Func<TTable, object>[] cols);

        public ITabularOperator<T> Extend(Func<T, dynamic, object> node);

        public QueryResult Run();

        public string QueryAsString();
    }
}
