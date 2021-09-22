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

        // public void AppendWithNewLine(string query)
        // {
        //     if(_queryBuilder.Length == 0)
        //         _queryBuilder.Append(query);

        //     _queryBuilder.Append(Environment.NewLine);

        //     _queryBuilder.Append(query);
        // }

        public QueryBuilder Append(string query)
        {
             _queryBuilder.Append(query);

             return this;
        }

        public QueryBuilder AppendWithSpace(string query)
        {
            if(_queryBuilder.Length == 0)
                _queryBuilder.Append(query);

            _queryBuilder.Append(" ");

            _queryBuilder.Append(query);

            return this;
        }

        public QueryBuilder AppendPipeNewLine()
        {
            _queryBuilder.Append(Environment.NewLine);

            _queryBuilder.Append("|");

            return this;
        }

        public string Query()
        {
            return _queryBuilder.ToString();
        }
    }
}