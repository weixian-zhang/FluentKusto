using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentKusto
{
    public abstract class TableBase<T> : ITabularOperator<T>, IKqlExecutor
    {
        private QueryBuilder _queryBuilder;

        private ExpressionParser<T> _queryParser;

        private List<OperatorExpression<T>> _opsExpression;

        public TableBase()
        {
            _queryBuilder = new QueryBuilder();

            InitQueryBuilderWithTable();

            _opsExpression = new List<FluentKusto.OperatorExpression<T>>();

            _queryParser = new ExpressionParser<T>(_queryBuilder);
        }

        #region Non Operator methods

        public QueryResult Run()
        {
            throw new NotImplementedException();
        }

        public string GetQuery()
        {
            return _queryBuilder.ToString();
        }

        public void InitQueryBuilderWithTable()
        {
            string table = CurrentTableName();

            _queryBuilder.Append($"{table} |");
        }

        private string CurrentTableName()
        {
            Type thisTableType = this.GetType();

            Type genericTableType = thisTableType.GetGenericTypeDefinition();

            return genericTableType.Name;
        }

        #endregion

        public ITabularOperator<T> Where(Expression<Func<T,object>> expression)
        {
            _queryParser.ParseWhere(new OperatorExpression<T>("Where", expression));

            return this;
        }

        public ITabularOperator<T> Project(Expression<Func<T, object>> opexpr)
        {
           return this;
        }
    }
}
