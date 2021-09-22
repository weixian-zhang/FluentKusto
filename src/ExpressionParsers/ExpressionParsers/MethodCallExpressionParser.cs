using System.Linq.Expressions;

namespace FluentKusto
{
    public class MethodCallExpressionParser : IExpressionParser
    {
        public string Parse(Expression node)
        {
            var method = (MethodCallExpression)node;

            string methodName = method.Method.Name;

            IFuncParser parser =  FunctionMappings.GetScalarFunctionParser(methodName);

            string query = parser.Parse(node);

            return query;
        }
    }
}