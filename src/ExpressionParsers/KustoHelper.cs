using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FluentKusto
{
    public static class KustoHelper
    {

        public static bool IsMemberAccess(Expression node)
        {
            if(node == null)
                return false;

            if(node.NodeType == ExpressionType.MemberAccess)
                return true;
            else
                return false;
        }

        public static bool IsMethodCall(Expression node)
        {
            if(node == null)
                return false;

            if(node.NodeType == ExpressionType.Call)
                return true;
            else
                return false;
        }

        public static bool IsBinary(Expression node)
        {
            if(node is BinaryExpression)
                return true;
            else
                return false;
        }

        public static bool IsAndOr(Expression node)
        {
            if(node == null)
                return false;

            if(node.NodeType == ExpressionType.OrElse ||
                node.NodeType == ExpressionType.AndAlso)
            {
                return true;
            }

            return false;
        }

        public static bool IsAndOr(ExpressionType nodeType)
        {
            if(nodeType == ExpressionType.OrElse || nodeType == ExpressionType.AndAlso)
                return true;
            else
                return false;
        }
    }
}