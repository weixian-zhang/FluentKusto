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
            if(node.NodeType == ExpressionType.Convert)
                ParseQuery(((UnaryExpression)node).Operand);

            if(KustoHelper.IsAndOr(node) || node is BinaryExpression)
                Visit(node);
            else
                _WhereExprs.Add(node);

            if(_WhereExprs.Count == 0)
                return "";

            return "";
        }

        protected override Expression VisitBinary(BinaryExpression node) {

            if(KustoHelper.IsAndOr(node))
            {
                if(KustoHelper.IsBinary(node.Left))
                    VisitBinary((BinaryExpression)node.Left);
                else
                     _WhereExprs.Add(node.Left);

                if(KustoHelper.IsBinary(node.Right))
                    VisitBinary((BinaryExpression)node.Right);
                else
                     _WhereExprs.Add(node.Right);
            }

            if(!KustoHelper.IsAndOr(node))
                _WhereExprs.Add(node);

            return node;
        }
    }
}