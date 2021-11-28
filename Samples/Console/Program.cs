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
            // string simpleWhere = Kusto.New().AzureActivity
            // .Where((tbl, col) => tbl.SourceSystem.In("Sys A", "Sys B", "Sys X"))
            // .QueryAsString();

            // Debug.WriteLine(simpleWhere);

            //where with extend
            string whereWithExtendWithStringFuncs = Kusto.New().AzureActivity
            .Extend((tbl, col) => new {
                DynamicTimeColumn =  tbl.TimeGenerated,
                SplittedRSC = Kql.split(tbl._ResourceId, '/'),
                SubId = tbl.SubscriptionId
            })
            // .Where((tbl, col) =>
            //     tbl.SourceSystem.In("Sys A", "Sys B", "Sys X") &&
            //     col.DynamicTimeColumn > Kql.ago("8h"))
            // .Where((tbl, col) => tbl.SourceSystem.In("Sys A", "Sys B", "Sys X") &&
            //     tbl.OperationName.startswithcs("we") &&
            //     tbl.OperationName.endswithcs("ew") &&
            //     tbl.OperationName.contains("A") &&
            //     col.DynamicTimeColumn > Kql.ago("8h") ||
            //     Kql.array_length(col.SplittedRSC) > 6 )
            .QueryAsString();

            Debug.WriteLine(whereWithExtendWithStringFuncs);

            // simple join
            // string simpleJoin = Kusto.New().AzureActivity
            // .Where(t => t.SourceSystem.In("A", "B", "BC", "DE"))
            // .Join<AzureActivity>(JoinKind.rightanti, Kusto.New().AzureActivity)
            // .On<AzureActivity>((left, right) => left.OperationId)
            // .QueryAsString();

            // Debug.WriteLine(simpleJoin);

            // //multi where conditions with string operators
            // string multi_conditions_string_operators = Kusto.New().Update.Where(tbl =>
            //     tbl._SubscriptionId.notequal("DasdasdsaDASDASdasdas") &&
            //     tbl.BulletinUrl.equalnoncase("http://somewebsite.com") &&
            //     tbl.Computer.equal("Com1") &&
            //     tbl.TimeGenerated > Kql.ago("3h") || tbl.ApprovalSource.equal("Admin")
            //     && tbl.CVENumbers.equal("S11345T") || tbl.Approved == true)
            //     .QueryAsString();

            //Debug.WriteLine(multi_conditions_string_operators);

            // complex extension, where, project
            // with col = column of a Kusto table and is of "dynamic" type
            // allow flexble syntax like brackets for array indexer "["..."]"
            // string complexExtensions = Kusto.New().Update
            //     .Extend((tbl, col) => new {
            //             ResourceArray = Kql.split(col.id_s, '/'),
            //             SecondLastResourceElement = col.ResourceArray[Kql.array_length(col.ResourceArray) - 2]
            //     })
            //     .Extend((tbl, col) => new {
            //          ResourceJson = Kql.parse_json(tbl.Product).resourceProviderValue
            //     })
            //     .Where(tbl => tbl.TimeGenerated > Kql.ago("12h"))
            //     .Project((tbl, col) => new {
            //         RG = tbl.ResourceGroup,
            //         TriggeredTime = tbl.TimeGenerated,
            //         ResourceJson = col.ResourceJson,
            //         Title = tbl.Title
            //     })
            //     .QueryAsString();

            // Debug.WriteLine(complexExtensions);
        }
    }
}
