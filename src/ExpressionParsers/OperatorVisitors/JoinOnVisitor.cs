
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class JoinOnVisitor : ExpressionVisitor, IOperatorExpressionVisitor
    {
        List<ExpressionElement> _FlattenedElements;

        public JoinOnVisitor()
        {
             _FlattenedElements = new List<ExpressionElement>();
        }

        public string ParseQuery(Expression node)
        {
            FlattenExpression(node);

            string on = ParseQueryInternal();

            return on;
        }

        private string ParseQueryInternal()
        {
            var qb = new QueryBuilder();

            foreach(var ele in _FlattenedElements)
            {
                //"normal" conditional expression
                if(ele.ConditionType == ExpressionType.Lambda)
                {
                   //binary equals
                   if(ele.Node.NodeType == ExpressionType.Equal)
                   {
                       var binary = (BinaryExpression)ele.Node;

                        string left = ExpressionParser.Parse(binary.Left);

                        string right = ExpressionParser.Parse(binary.Right);

                        string query = $"$left.{left} == $right.{right}";

                        qb.AppendWithSpace(query);
                   }
                   //single member
                   else
                   {
                       string member = ExpressionParser.Parse(ele.Node);

                       qb.AppendWithSpace(member);
                   }
                }
                else
                    //comma(,) to chain multiple "on" conditions
                    qb.AppendWithSpace(", ");
            }

            return qb.Query();
        }

        /// Flattens multiple binary expressions to a new ExpressionElement
        /// E.g: // kql.Update.Where(x =>
            //     x._SubscriptionId.equalnoncase("DasdasdsaDASDASdasdas") &&
            //     x.TimeGenerated > Kql.ago("3h") || x.ApprovalSource.equal("AAB")
            //     && x.CVENumbers.notequal("B") || x.Approved == true && x.Computer.equal("saasd") ||
            //     x.Classification.notequal("B") && x.BulletinUrl == "http://url.com" || x.BulletinID == "A"
            //     && x.Approved == true);
        /// Each expression between And/Or is an ExpressionElement
        /// Each And or Or is also a separate ExpressionElement
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