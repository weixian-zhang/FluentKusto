
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FluentKusto
{
    public class ExtendVisitor : IOperatorExpressionVisitor
    {
        public string ParseQuery(Expression node)
        {
            return "";
            //CSharpSyntaxTree.Create(new CSharpSyntaxNode())
        }
    }
}