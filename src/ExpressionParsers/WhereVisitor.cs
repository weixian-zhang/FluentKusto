using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class WhereVisitor<T> : ExpressionVisitor //, IExpressionVisitorQuery<T>
    {

        private QueryBuilder _queryBuilder;

         private List<Expression> _WhereExprs = new List<Expression>();


        //https://stackoverflow.com/questions/15709044/how-to-determine-the-depth-of-a-c-sharp-expression-tree-iterativly

        public WhereVisitor(QueryBuilder queryBuilder)
        {
            _queryBuilder = queryBuilder;
        }

        public string ParseQuery(Expression node)
        {
            if(node is UnaryExpression)
                ParseQuery(((UnaryExpression)node).Operand);

            if(IsAndOr(node) || node is BinaryExpression)
                Visit(node);

            if(_WhereExprs.Count == 0)
                return "";

            return "";
        }


        // public override Expression Visit(Expression node)
        // {
        //     if(node.NodeType == ExpressionType.Convert)
        //         Visit(((UnaryExpression)node).Operand);

        //     if(IsAndOr(node))
        //     {
        //         var binary = (BinaryExpression)node;

        //         Expression left = null;
        //         Expression right = null;

        //        TraverseLeft(binary.Left, ref left, ref right);

        //         //_WhereExprs.Add(TraverseRight(binary.Right));

        //     }
        //     else
        //         _WhereExprs.Add(node);

        //     return node;

        //     //return base.Visit(node);
        // }

        protected override Expression VisitBinary(BinaryExpression b) {

            Expression left = this.Visit(b.Left);

            if(!IsAndOr(left))
            {
                 _WhereExprs.Add(left);
            }

            Expression right = this.Visit(b.Right);


            if(!IsAndOr(right))
            {
                 _WhereExprs.Add(right);
            }
            //Expression left = this.Visit(b.Left);

            // if(!IsAndOr(left) && left is BinaryExpression)
            // {
            //     var binary = (BinaryExpression)left;
            //     _WhereExprs.Add(Expression.MakeBinary(binary.NodeType, binary.Left, binary.Right));
            // }
            // else
            //      _WhereExprs.Add(left);
            // else
            // {
            //     //only accept whole binary
            //     if(left.NodeType)
            //     {
            //         _WhereExprs.Add(left);
            //     }
            // }


            //Expression right = this.Visit(b.Right);

        //    if(!IsAndOr(right) && right is BinaryExpression)
        //     {
        //         var binary = (BinaryExpression)right;
        //         _WhereExprs.Add(Expression.MakeBinary(binary.NodeType, binary.Left, binary.Right));
        //     }
        //     else
        //         _WhereExprs.Add(right);

            // Expression conversion = this.Visit(b.Conversion);
            // if (left != b.Left || right != b.Right || conversion != b.Conversion) {
            //     if (b.NodeType == ExpressionType.Coalesce && b.Conversion != null)
            //         return Expression.Coalesce(left, right, conversion as LambdaExpression);
            //     else
            //         return Expression.MakeBinary(b.NodeType, left, right, b.IsLiftedToNull, b.Method);
            // }
            return b;
        }

        private bool IsMethodCall(Expression node)
        {
            if(node.NodeType == ExpressionType.Call)
                return true;
            else
                return false;
        }

        private bool IsMemberAccess(Expression node)
        {
            if(node.NodeType == ExpressionType.MemberAccess)
                return true;
            else
                return false;
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

        // private void TraverseLeft(Expression node, ref Expression? leftChild, ref Expression? rightChild)
        // {
        //     if(IsAndOr(node))
        //     {
        //         var binary = (BinaryExpression)node;

        //        leftChild = binary.Left;

        //        rightChild = binary.Right;

        //        TraverseLeft(binary.Left, ref leftChild, ref rightChild);
        //     }

        //     if(!(node is BinaryExpression))
        //     {
        //         //_WhereExprs.Add(node);

        //         node = leftChild;
        //     }
        // }

        // private Expression TraverseRight(Expression node)
        // {
        //     if(!IsAndOr(node))
        //     {
        //         return node;
        //     }

        //     var binary = (BinaryExpression)node;

        //     return TraverseRight(binary);
        // }



        // protected override Expression VisitConstant(ConstantExpression node)
        // {
        //    System.Diagnostics.Trace.WriteLine(node.Value);
        //    return base.VisitConstant(node);
        // }

        // protected override Expression VisitMember(MemberExpression node)
        // {
        //    System.Diagnostics.Trace.WriteLine(node.Member.Name);
        //    return base.VisitMember(node);
        // }

        // protected override MemberAssignment VisitMemberAssignment(MemberAssignment node)
        // {
        //     System.Diagnostics.Trace.WriteLine(node.Member.Name);
        //     return base.VisitMemberAssignment(node);
        // }

        // protected override Expression VisitMethodCall(MethodCallExpression node)
        // {
        //     //node.Arguments
        //     System.Diagnostics.Trace.WriteLine(node.Method.Name);
        //     return node;
        // }

        // protected override Expression VisitUnary(UnaryExpression node)
        // {
        //     System.Diagnostics.Trace.WriteLine("VisitUnary "+ node.NodeType);
        //     return base.VisitUnary(node);
        // }

        // protected override Expression VisitParameter(ParameterExpression node)
        // {
        //     System.Diagnostics.Trace.WriteLine("VisitParameter "+ node.NodeType);
        //     return base.VisitParameter(node);
        // }


        //https://www.codeproject.com/Articles/1241363/Expression-Tree-Traversal-Via-Visitor-Pattern-in-P

        //https://stackoverflow.com/questions/7731905/how-to-convert-an-expression-tree-to-a-partial-sql-query/7933938



        // protected override Expression VisitBinary(BinaryExpression node)
        // {

        // }



        // protected override Expression VisitBinary(BinaryExpression b) {
        //     Expression left = this.Visit(b.Left);
        //     Expression right = this.Visit(b.Right);
        //     Expression conversion = this.Visit(b.Conversion);
        //     if (left != b.Left || right != b.Right || conversion != b.Conversion) {
        //         if (b.NodeType == ExpressionType.Coalesce && b.Conversion != null)
        //             return Expression.Coalesce(left, right, conversion as LambdaExpression);
        //         else
        //             return Expression.MakeBinary(b.NodeType, left, right, b.IsLiftedToNull, b.Method);
        //     }
        //     return b;
        // }


    }
}