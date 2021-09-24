using System.Linq.Expressions;

namespace FluentKusto
{
    public class MethodCallExpressionParser : IExpressionParser
    {
        public string Parse(Expression node)
        {
            var method = (MethodCallExpression)node;

            string methodName = method.Method.Name;

            IFuncParser parser;

            if(method.Method.DeclaringType == typeof(StringOperatorExtensions))
                //return query if StringExtensionMethod
                return StringFuncMaps.ParseStringMethod(node);
            else
                parser = FuncMaps.ResolveScalarFuncParser(methodName);

            string query = parser.Parse(node);

            return query;
        }
    }
}