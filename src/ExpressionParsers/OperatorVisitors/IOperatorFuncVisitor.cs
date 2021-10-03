using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public interface IOperatorFuncVisitor
    {
         public string ParseQuery<T>(Func<TableBase<T>, dynamic, object> node) where T : new();
    }
}