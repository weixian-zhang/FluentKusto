
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class WhereVisitor : ExpressionVisitor, IOperatorExpressionVisitor
    {
        List<ExpressionElement> _FlattenedElements;

        public WhereVisitor()
        {
            _FlattenedElements = new List<ExpressionElement>();
        }

        public string ParseQuery(Expression node)
        {
            FlattenExpression(node);

            string where = ParseQueryInternal();

            return where;
        }

        private string ParseQueryInternal()
        {
            var qb = new QueryBuilder();

            qb.AppendPipeNewLine("where");

            foreach(var ele in _FlattenedElements)
            {
                //"normal" conditional expression
                if(ele.ConditionType == ExpressionType.Lambda)
                {
                   string query = ExpressionParser.Parse(ele.Node);

                   qb.AppendWithSpace(query);
                }
                else
                    //appends and / or
                    qb.AppendWithSpace(OperandMaps.ResolveLogicalOperand(ele.ConditionType));
            }

            return qb.Query();
        }

        private void FlattenExpression(Expression node)
        {
            if(node.NodeType == ExpressionType.Convert)
                node = ((UnaryExpression)node).Operand;

            if(KustoHelper.IsAndOr(node))
            {
                var currentCondition = node.NodeType;

                var binary = (BinaryExpression)node;

                Visit(binary.Left);

                AddExpressionElement(currentCondition);

                Visit(binary.Right);
            }
            //not and/or, will be member or methodcall
            else
                    AddExpressionElement(node);
        }

        private Expression parentBinary = null;
        protected override Expression VisitBinary(BinaryExpression node) {

            var binary = node;

            if(KustoHelper.IsAndOr(binary))
            {
                //traverse to end of left without And/Or
                if(KustoHelper.IsAndOr(binary.Left))
                {
                    //store parent of previous traversed And/Or
                    parentBinary = binary.Left;

                    Visit(binary.Left);
                }
                else
                     AddExpressionElement(binary.Left);

                AddExpressionElement(binary.NodeType);

                //traverse to end of right without And/Or
                if(KustoHelper.IsAndOr(binary.Right))
                {
                    //store parent of previous traversed And/Or
                    parentBinary = binary.Right;

                    Visit(binary.Right);
                }
                else
                     AddExpressionElement(binary.Right);
            }
            //add node if this current node is not of And/Or
            else
                AddExpressionElement(node);

            return parentBinary != null ? parentBinary : node;
        }

        /// in case of binary tree traversal, whenever hitting any non-And/Or like MethodCall or Member
        /// Visit will call overriden Visitor-Methods like this to capture non-And/Or binary expressions
        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
           AddExpressionElement(node);

            return node;
        }

        /// in case of binary tree traversal, whenever hitting any non-And/Or like MethodCall or Member
        /// Visit will call overriden Visitor-Methods like this to capture non-And/Or binary expressions
        protected override Expression VisitMember(MemberExpression node)
        {
            AddExpressionElement(node);

            return node;
        }

        private void AddExpressionElement(Expression node)
        {
            if(!_FlattenedElements.Exists(x => x.Node == node))
                _FlattenedElements.Add(new ExpressionElement(node));
        }

        private void AddExpressionElement(ExpressionType cType)
        {
           _FlattenedElements.Add(new ExpressionElement(cType));
        }
    }
}