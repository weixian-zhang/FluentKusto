using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentKusto
{
    public abstract class TableBase<T> : ITabularOperator<T>, IQueryAsString
    {
        private QueryBuilder _queryBuilder;

        private QueryParser _queryParser;

        private List<OperatorExpression<T>> _opsExpression;

        public TableBase()
        {
            _queryBuilder = new QueryBuilder();

            InitQueryBuilderWithTable();

            _opsExpression = new List<FluentKusto.OperatorExpression<T>>();

            _queryParser = new QueryParser(_queryBuilder);
        }

        #region Non Operator methods

        private string CurrentTableName()
        {
            Type thisTableType = this.GetType();

            return thisTableType.Name;
        }

        #endregion

        #region ITabularOperator

        public ITabularOperator<T> Where(Expression<Func<T,object>> expression)
        {
            string where = _queryParser.ParseWhere(expression.Body);

            _queryBuilder.Append(where);

            return this;
        }

        public ITabularOperator<T> Project(Expression<Func<T, object>> opexpr)
        {
           return this;
        }

        public IQueryAsString Run()
        {
            //TODO:
            // - call Azure Monitor Query library for DefaultAuth
            // - or call Log Analytics via Http to support Workspace key, assuming Az Monitor Query
            //does not support Woekspace key
            throw new NotImplementedException();
        }

        public string QueryAsString()
        {
            return _queryBuilder.ToString();
        }

        #endregion ITabularOperator


        public void InitQueryBuilderWithTable()
        {
            string table = CurrentTableName();

            _queryBuilder.Append($"{table}");
        }
    }
}
