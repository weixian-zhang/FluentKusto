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
            _parsers.Add("BinaryExpression", new BinaryExpressionParser());

             _parsers.Add("SimpleBinaryExpression", new BinaryExpressionParser());

            _parsers.Add("MethodCallExpression", new MethodCallExpressionParser());

            _parsers.Add("MethodExpression", new BinaryExpressionParser());

            _parsers.Add("MemberExpression", new MemberExpressionParser());

            _parsers.Add("ConstantExpression", new ConstantExpressionParser());
        }

        public static string Parse(Expression node)
        {
            string typeName = "";

            Type subType = node.GetType();

            //-multiple methodcallexpressions result in Type name with appended with number
            // e.g MethodBinaryExpression1 -> MethodBinaryExpression1
            //-BaseType name guarantee type name with number behind
            //-Like ConstantExpression BaseType is Expression, this case to get subType name
            if(!(subType.BaseType == typeof(Expression)))
                typeName = subType.BaseType.Name;
            else
                typeName = subType.Name;

            var parser = _parsers[typeName];

            string query = parser.Parse(node);

            return query;
        }

    }
}