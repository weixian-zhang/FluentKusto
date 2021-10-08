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

        public QueryBuilder Append(string query)
        {
             _queryBuilder.Append(query);

             return this;
        }

        public QueryBuilder AppendWithTab(string query)
        {
            _queryBuilder.Append("\t");

            _queryBuilder.Append(query);

            return this;
        }

        public QueryBuilder AppendNewLine(string query)
        {
            _queryBuilder.Append(Environment.NewLine);

            _queryBuilder.Append(query);

            return this;
        }

        public QueryBuilder AppendWithSpace(string query)
        {
            if(_queryBuilder.Length == 0)
            {
                _queryBuilder.Append(query);
                return this;
            }

            _queryBuilder.Append(" ");

            _queryBuilder.Append(query);

            return this;
        }

        public QueryBuilder AppendPipeNewLine(string opr)
        {
            _queryBuilder.Append(Environment.NewLine);

            _queryBuilder.Append($"| {opr}");

            return this;
        }

        public string Query()
        {
            return _queryBuilder.ToString();
        }
    }
}