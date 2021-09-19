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

            //kql.AACAudit.Where(x => x._SubscriptionId.equal("wdwa"));

            kql.AACAudit.Where(x => x._SubscriptionId.equal("231312-2312-13123") || x.EventCategory.equal("Event"));

            // kql.Update.Where(x =>
            //     x._SubscriptionId.equalnoncase("DasdasdsaDASDASdasdas") &&
            //     x.TimeGenerated > Kql.ago("3h") || x.ApprovalSource.equal("AAB")
            //     && x.CVENumbers.notequal("B"));

            // kql.Update.Where(x =>
            //     x._SubscriptionId.equalnoncase("DasdasdsaDASDASdasdas") &&
            //     x.TimeGenerated > Kql.ago("3h") || x.ApprovalSource.equal("AAB")
            //     && x.CVENumbers.notequal("B") || x.Approved == true && x.Computer.equal("saasd"));
        }
    }
}
