using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class PredicateDissectVisitor : ExpressionVisitor
    {
        private List<Expression> exprs = new List<Expression>();

        // public override Expression Visit(Expression node)
        // {
        //     return base.Visit()
        // }



        // protected override Expression Visit(Expression node)
        // {
        //     if(IsAndOr(node))
        //     {
        //         var binary = (BinaryExpression)node;

        //         exprs.Add(TraverseLeft(binary.Left));

        //         exprs.Add(TraverseRight(binary.Right));
        //     }

        //     return node;
        // }

        private Expression TraverseLeft(Expression node)
        {
            if(!IsAndOr(node))
            {
                return node;
            }

            return TraverseLeft(((BinaryExpression)node).Left);
        }

        private Expression TraverseRight(Expression node)
        {
            if(!IsAndOr(node))
            {
                return node;
            }

            return TraverseLeft(((BinaryExpression)node).Left);
        }

        private bool IsAndOr(Expression node)
        {
            if(node.NodeType == ExpressionType.OrElse ||
                node.NodeType == ExpressionType.AndAlso)
            {
                return true;
            }

            return false;
        }
    }
}