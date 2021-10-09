using System.Linq.Expressions;

namespace FluentKusto
{
    public class MethodCallExpressionParser : IExpressionParser
    {
        public string Parse(Expression node)
        {
            var method = (MethodCallExpression)node;

            string methodName = method.Method.Name;

            string query;

            if(method.Method.DeclaringType == typeof(StringOperatorExtensions))
            {
                //return query if StringExtensionMethod
                var strParser = StringFuncMaps.GetParser(methodName);

                query = strParser.Parse(node);
            }
            else
            {
                var parser = FuncMaps.GetParser(methodName);

                query = parser.Parse(node);
            }

            return query;
        }
    }
}