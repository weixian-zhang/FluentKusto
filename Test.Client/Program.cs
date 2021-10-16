using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using FluentKusto;
using Microsoft.Azure.ApplicationInsights.Query.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace FluentKusto.TestClient
{
    class Program
    {
        private static IConfiguration _config;

        static void Main(string[] args)
        {
            ConfigInit();

            TestLogAnalytics();

            TestAppinsights();
        }

        private static void TestLogAnalytics()
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


            // simple join
            // string simpleJoin = Kusto.New().AzureActivity
            // .Where(t => t.SourceSystem.In("A", "B", "BC", "DE"))
            // .Join<AzureActivity>(JoinKind.rightanti, Kusto.New().AzureActivity)
            // .On<AzureActivity>((left, right) => left.OperationId)
            // .QueryAsString();

            // Debug.WriteLine(simpleJoin);

            // join with right table filter expression
            // string joinw_with_right_table_sub_query = Kusto.New().AzureActivity
            //     .Where(t => t.TenantId == "awer323")
            //     .Join<Update>(JoinKind.innerunique,
            //         Kusto.New().Update
            //             .Where(t => t.Title == "Some Title" && t.ApprovalSource == "System"
            //             && t.TimeGenerated > Kql.ago("5h"))
            //             .Extend((t, col) => new {NewColumn = t.TimeGenerated})
            //     )
            //     .On<Update>((activity, update) => activity.ResourceId == update.ResourceId)
            //     .QueryAsString();

            // Debug.WriteLine(joinw_with_right_table_sub_query);


            // string multi_conditions_string_operators = Kusto.New().Update.Where(tbl =>
            //     tbl._SubscriptionId.notequal("DasdasdsaDASDASdasdas") &&
            //     tbl.BulletinUrl.equalnoncase("http://somewebsite.com") &&
            //     tbl.Computer.equal("Com1") &&
            //     tbl.TimeGenerated > Kql.ago("3h") || tbl.ApprovalSource.equal("Admin")
            //     && tbl.CVENumbers.equal("S11345T") || tbl.Approved == true)
            //     .QueryAsString();

            // Debug.WriteLine(multi_conditions_string_operators);

            // Kusto.New().Update.Where(x =>
            //     x._SubscriptionId.equalnoncase("DasdasdsaDASDASdasdas") &&
            //     x.TimeGenerated > Kql.ago("3h") || x.ApprovalSource.equal("AAB")
            //     && x.CVENumbers.notequal("B") || x.Approved == true && x.Computer.equal("saasd") ||
            //     x.Classification.notequal("B") && x.BulletinUrl == "http://url.com" || x.BulletinID == "A"
            //     && x.Approved == true);
            // kql = Kusto.New();

            // var wr = Kusto.New().Update.Where(tbl =>
            //     tbl._SubscriptionId.notequal("DasdasdsaDASDASdasdas") &&
            //     tbl.BulletinUrl.equalnoncase("http://somewebsite.com") &&
            //     tbl.Computer.equal("Com1") &&
            //     tbl.TimeGenerated > Kql.ago("3h") || tbl.ApprovalSource.equal("Admin")
            //     && tbl.CVENumbers.equal("S11345T") || tbl.Approved == true)
            //     .Run()
            //         .OnLogAnalytics("4cecddb2-c069-488a-b3a1-d9bf129168bf").Result;
        }

        private static void TestAppinsights()
        {
            string tenantId = _config["TenantId"];
            string appId = _config["AppInsightsAppId"];
            string clientId = _config["ClientId"];
            string clientSecret = _config["ClientSecret"];

            QueryResults result;
            string query = string.Empty;

            var appinsights_simple1 = Kusto.New().requests
                .Run()
                    .OnAppInsightsWithQueryOutput(tenantId, appId, clientId, clientSecret)
                    .GetAwaiter().GetResult();

            result = appinsights_simple1.Item1;
            query = appinsights_simple1.Item2;

            var appinsights_simpleJoin = Kusto.New().requests
                .Join<exceptions>(JoinKind.innerunique,
                    Kusto.New().exceptions
                    .Where(t => t.severityLevel == 2)
                )
                .On<exceptions>((left, right) => left.operation_Id == right.operation_Id)
                .Run()
                    .OnAppInsightsWithQueryOutput(tenantId, appId, clientId, clientSecret)
                    .GetAwaiter().GetResult();

            result = appinsights_simpleJoin.Item1;
            query = appinsights_simpleJoin.Item2;
        }

        private static void ConfigInit()
        {
            _config = new ConfigurationBuilder()
                .AddUserSecrets("5073993a-eef1-44d2-b54d-c820484323e8",true)
                .Build();

        }
    }
}
