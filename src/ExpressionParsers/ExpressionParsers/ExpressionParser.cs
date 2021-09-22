using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentKusto
{
    public static class ExpressionParser
    {
        private static Dictionary<string,IExpressionParser> _parsers = new Dictionary<string,IExpressionParser>();

        static ExpressionParser()
        {
            _parsers.Add("LogicalBinaryExpression", new BinaryExpressionParser());

            _parsers.Add("MethodCallExpression", new MethodCallExpressionParser());

            _parsers.Add("MethodBinaryExpression", new BinaryExpressionParser());

            _parsers.Add("PropertyExpression", new MemberExpressionParser());

            _parsers.Add("ConstantExpression", new ConstantExpressionParser());
        }

        public static string Parse(Expression node)
        {
            var exprTypeName = node.GetType().Name;

            //TODO: fix method name inconsistency "MethodCallExpression1"

            var parser = _parsers[exprTypeName];

            string query = parser.Parse(node);

            return query;
        }

    }
}