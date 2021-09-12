using System;
using System.Text;

namespace FluentKusto
{
    public class QueryBuilder
    {
        private StringBuilder _queryBuilder;

        public QueryBuilder()
        {
            _queryBuilder = new StringBuilder();
        }

        public void Append(string query)
        {
            if(_queryBuilder.Length == 0)
                _queryBuilder.Append(query);

            _queryBuilder.Append(Environment.NewLine);

            _queryBuilder.Append(query);
        }

        public string GetQuery()
        {
            return _queryBuilder.ToString();
        }
    }
}