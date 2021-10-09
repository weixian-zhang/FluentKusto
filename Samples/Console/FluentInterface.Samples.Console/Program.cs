using System;
using System.Diagnostics;
using FluentKusto;

namespace FluentInterface.Samples.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //simple where
            string simpleWhere = Kusto.New().AzureActivity
            .Where(tbl => tbl.SourceSystem.In("Sys A", "Sys B", "Sys X"))
            .QueryAsString();

            Debug.WriteLine(simpleWhere);

            // simple join
            string simpleJoin = Kusto.New().AzureActivity
            .Where(t => t.SourceSystem.In("A", "B", "BC", "DE"))
            .Join<AzureActivity>(JoinKind.rightanti, Kusto.New().AzureActivity)
            .On<AzureActivity>((left, right) => left.OperationId)
            .QueryAsString();

            Debug.WriteLine(simpleJoin);

            //multi where conditions
            string multiWhere = Kusto.New().Update.Where(x =>
                x._SubscriptionId.equalnoncase("DasdasdsaDASDASdasdas") &&
                x.TimeGenerated > Kql.ago("3h") || x.ApprovalSource.equal("AAB")
                && x.CVENumbers.notequal("B") || x.Approved == true && x.Computer.equal("saasd") ||
                x.Classification.notequal("B") && x.BulletinUrl == "http://somewebsite.com" ||
                 x.BulletinID == "AADSA31" && x.Approved == true)
                .QueryAsString();

            Debug.WriteLine(multiWhere);

            //multi where conditions with string operators
            string multi_conditions_string_operators = Kusto.New().Update.Where(tbl =>
                tbl._SubscriptionId.notequal("DasdasdsaDASDASdasdas") &&
                tbl.BulletinUrl.equalnoncase("http://somewebsite.com") &&
                tbl.Computer.equal("Com1") &&
                tbl.TimeGenerated > Kql.ago("3h") || tbl.ApprovalSource.equal("Admin")
                && tbl.CVENumbers.equal("S11345T") || tbl.Approved == true)
                .QueryAsString();

            Debug.WriteLine(multi_conditions_string_operators);

            // complex extension, where, project
            // with col = column of a Kusto table and is of "dynamic" type
            // allow flexble syntax like brackets for array indexer "["..."]"
            string complexExtensions = Kusto.New().Update
                .Extend((tbl, col) => new {
                        ResourceArray = Kql.split(col.id_s, '/'),
                        SecondLastResourceElement = col.ResourceArray[Kql.array_length(col.ResourceArray) - 2]
                })
                .Extend((tbl, col) => new {
                     ResourceJson = Kql.parse_json(tbl.Product).resourceProviderValue
                })
                .Where(tbl => tbl.TimeGenerated > Kql.ago("12h"))
                .Project((tbl, col) => new {
                    RG = tbl.ResourceGroup,
                    TriggeredTime = tbl.TimeGenerated,
                    ResourceJson = col.ResourceJson,
                    Title = tbl.Title
                })
                .QueryAsString();

            Debug.WriteLine(complexExtensions);
        }
    }
}
