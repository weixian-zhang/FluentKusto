using System;
using System.Linq;
using FluentKusto;

namespace FluentKusto.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var kql = Kusto.New();

            kql.AACAudit
                .Where(x =>
                    x._SubscriptionId.equalsnoncase("DasdasdsaDASDASdasdas") &&
                    x.TimeGenerated > Kql.ago("3h"))
                .Project(x => x.RequestId + x.CallerIPAddress + x.Category);
                //.Where(x => x.TimeGenerated > )
        }
    }
}
