using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ProjectColumn<T>
    {
        public string Name { get; set; }

        public Expression<Func<T, object>> TableExpression { get; set; }

        public ProjectColumn(string name, Expression<Func<T, object>> tableExpression)
        {

        }
    }
}