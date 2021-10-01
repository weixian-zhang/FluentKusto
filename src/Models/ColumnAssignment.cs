using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    /// USe for Extend, Project to handle new column name and expression assignment
    public class ColumnAssignment<T>
    {
        public ColumnAssignment(Expression<Func<T, object>> assignment)
        {
            Assignment = assignment;
        }

        public ColumnAssignment(string col, Expression<Func<T, object>> assignment )
        {
            Column = col;
            Assignment = assignment;
        }

        public string Column { get; set; }

        public Expression<Func<T, object>> Assignment { get; set; }

        public bool HasColumn {
            get
            {
                if(string.IsNullOrEmpty(Column))
                    return false;
                else
                    return true;
            }
        }
    }
}