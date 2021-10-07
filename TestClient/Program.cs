using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using FluentKusto;
using Newtonsoft.Json;

namespace FluentKusto.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // string q = Kusto.New().Update
            //     .Extend((t, c) => new {
            //             ResourceArray = Kql.split(c.id_s, '/'),
            //             SecondLastResourceElement = c.ResourceArray[Kql.array_length(c.ResourceArray) - 2]
            //     })
            //     .Extend((t, c) => new {
            //          ResourceJson = Kql.parse_json(t.Product).resourceProviderValue
            //     })
            //     .Where(t => t.TimeGenerated > Kql.ago("12h"))
            //     .Project((tbl, col) => new {
            //         RG = tbl.ResourceGroup,
            //         TriggeredTime = tbl.TimeGenerated,
            //         ResourceJson = col.ResourceJson,
            //         Title = tbl.Title
            //     })
            //     .QueryAsString();


            // join example

            Kusto.New().AzureActivity
                .Where(t => t.TenantId == "awer323")
                .Join<Update>(JoinKind.innerunique, Kusto.New().Update)
                .On<Update>((activity, update) => activity.ResourceId == update.ResourceId);


            // Kusto.New().Update.Where(x =>
            //     x._SubscriptionId.notequal("DasdasdsaDASDASdasdas") &&
            //     x.TimeGenerated > Kql.ago("3h") || x.ApprovalSource.equal("Dsaa")
            //     && x.CVENumbers.equal("sfaaa") || x.Approved == true && x.Computer.notequal("sda"));


            // Kusto.New().Update.Where(x =>
            //     x._SubscriptionId.equalnoncase("DasdasdsaDASDASdasdas") &&
            //     x.TimeGenerated > Kql.ago("3h") || x.ApprovalSource.equal("AAB")
            //     && x.CVENumbers.notequal("B") || x.Approved == true && x.Computer.equal("saasd") ||
            //     x.Classification.notequal("B") && x.BulletinUrl == "http://url.com" || x.BulletinID == "A"
            //     && x.Approved == true);
            // kql = Kusto.New();
        }
    }
}
