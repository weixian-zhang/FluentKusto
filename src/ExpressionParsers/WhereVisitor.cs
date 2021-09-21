using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ExpressionElement
    {
        public ExpressionElement(ExpressionType conditionType)
        {
            ConditionType = conditionType;
        }

        public ExpressionElement(Expression node)
        {
            ConditionType = ExpressionType.Lambda;
            Node = node;
        }

        public ExpressionType ConditionType { get; set; } = ExpressionType.Lambda;
        public Expression Node { get; set; }
    }

    public class WhereVisitor<T> : ExpressionVisitor
    {
        private IExpressionParser _MethodCallParser;
         private IExpressionParser _MemberVisitor;

        List<ExpressionElement> _dissectedElements = new List<ExpressionElement>();


        //https://stackoverflow.com/questions/15709044/how-to-determine-the-depth-of-a-c-sharp-expression-tree-iterativly

        public WhereVisitor()
        {
            _MethodCallParser =  new MethodCallExpressionParser();
            _MemberVisitor = new MemberExpressionParser();
        }

        public string ParseQuery(Expression node)
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

            return "";
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
            if(!_dissectedElements.Exists(x => x.Node == node))
                _dissectedElements.Add(new ExpressionElement(node));
        }

        private void AddExpressionElement(ExpressionType cType)
        {
           _dissectedElements.Add(new ExpressionElement(cType));
        }



        private string ParseQueryInternal(List<ExpressionElement> nodes)
        {
            string wherekql = "";

            foreach(var node in nodes)
            {
                //if(KustoHelper.IsMethodCall(node))
            }

            return "";
        }

        private bool IsNodeStringAndAlso(string node)
        {
            if(node == ExpressionType.AndAlso.ToString())
                return true;
            else
                return false;
        }

        private bool IsNodeStringOrElse(string node)
        {
            if(node == ExpressionType.OrElse.ToString())
                return true;
            else
                return false;
        }
    }
}