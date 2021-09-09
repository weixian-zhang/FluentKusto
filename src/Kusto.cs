using System;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class Kusto
    {
        /// <summary>Create a new instance of Kql client</summary>
        ///
        public static Kql New()
        {
            return new Kql();
        }
    }


}
