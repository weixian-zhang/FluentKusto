using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace FluentKusto
{

    public interface ITabularOperator<T>
    {
        public ITabularOperator<T> Count();

        public ITabularOperator<T> Where(Expression<Func<T,object>> where);

        /// Project returns an anonymous object where Member is the projected column name
        /// T is kusto table
        /// dynamic type represents dynamic Column that can reference any other extended columns or Kusto syntax
        public ITabularOperator<T> Project(Func<T, dynamic, object> nod);

        /// Extend returns an anonymous object where Member is the dynamically extended column name
        /// T is kusto table
        /// dynamic type represents dynamic Column that can reference any other extended columns or Kusto syntax
        public ITabularOperator<T> Extend(Func<T, dynamic, object> node);

        public IJoinOn<T> Join<TRight>
            (JoinKind kind, ITabularOperator<TRight> rightQueryNode);

        public QueryResult Run();

        public string QueryAsString();
    }
}
