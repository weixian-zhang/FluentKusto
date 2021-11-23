using System;
using Xunit;

using FluentKusto;
using System.Diagnostics;

namespace FluentKusto.Tests
{
    public class LAW_KqlQueryResultTests
    {
        [Theory]
        [InlineData(50)]
        [InlineData(100)]
        [InlineData(200)]
        public void Simple_Limit(int value)
        {
            string q = Kusto.New()
                .Update
                    .Limit(value)
                    .QueryAsString();

            Debug.WriteLine(q);

            string actualQuery =
@"Update
| limit " + value.ToString();

            Assert.Equal(q, actualQuery);

        }

        [Theory]
        [InlineData(50)]
        [InlineData(100)]
        [InlineData(200)]
        public void Complex_Limit(int value)
        {
            string q = Kusto.New()
                .Update
                    .Where((t) => t.SubscriptionId == "xxxx-xxx-xxx-xxxx" && t.Approved == true)
                    .Limit(value)
                    .Project((t, col) => new {RG = t.ResourceGroup, SubscriptionId = t.SubscriptionId, Approved = t.Approved})
                    .QueryAsString();

            Debug.WriteLine(q);

            string actualQuery =
@$"Update
| where SubscriptionId == ""xxxx-xxx-xxx-xxxx"" and Approved == true
| limit {value.ToString()}
| project RG = ResourceGroup, SubscriptionId = SubscriptionId, Approved = Approved";

            Assert.Equal(q, actualQuery);

        }

        [Fact]
        public void Simple_Where()
        {
            string q = Kusto.New()
                .Update
                    .Where((t) => t.TimeGenerated > Kql.ago("5h"))
                    .QueryAsString();

            Debug.WriteLine(q);

            string actualQuery =
@"Update
| where TimeGenerated > ago(5h)";

            Assert.Equal(q, actualQuery);

        }

        [Fact]
        public void Sinple_Join()
        {
            string q = Kusto.New().AzureActivity
                .Where(t => t.SourceSystem.In("A", "B", "BC", "DE"))
                .Join<AzureActivity>(JoinKind.rightanti, Kusto.New().AzureActivity)
                    .On<AzureActivity>((left, right) => left.OperationId)
                .QueryAsString();

            Debug.WriteLine(q);

            string kql =
@"AzureActivity
| where SourceSystem in (""A"", ""B"", ""BC"", ""DE"") | join kind=rightanti (
AzureActivity
)
on OperationId";

            Assert.Equal(q, kql);
        }

        [Fact]
        public void Multi_Condition_Where()
        {
            string q = Kusto.New().Update.Where(tbl =>
                tbl._SubscriptionId.notequal("DasdasdsaDASDASdasdas") &&
                tbl.BulletinUrl.equalnoncase("http://somewebsite.com") &&
                tbl.Computer.equal("Com1") &&
                tbl.TimeGenerated > Kql.ago("3h") || tbl.ApprovalSource.equal("Admin")
                && tbl.CVENumbers.equal("S11345T") || tbl.Approved == true)
                .QueryAsString();

            Debug.WriteLine(q);

            string kql =
@"Update
| where _SubscriptionId != ""DasdasdsaDASDASdasdas"" and BulletinUrl !~ ""http://somewebsite.com"" and Computer == ""Com1"" and TimeGenerated > ago(3h) or ApprovalSource == ""Admin"" and CVENumbers == ""S11345T"" or Approved == true";

            Assert.Equal(q, kql);
        }

        [Fact]
        public void Simple_Extend_and_Project()
        {
            string q = Kusto.New().Update
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

            Debug.WriteLine(q);

            string kql =
@"Update
| extend ResourceArray = split(id_s, '/'), SecondLastResourceElement = ResourceArray[array_length(ResourceArray) - 2]
| extend ResourceJson = parse_json(Product).resourceProviderValue
| where TimeGenerated > ago(12h)
| project RG = ResourceGroup, TriggeredTime = TimeGenerated, ResourceJson = ResourceJson, Title = Title";

            Assert.Equal(q,kql);
        }

        [Fact]
        public void Simple_Distinct()
        {
            string q = Kusto.New().Update
                .Distinct((t, col) =>  new {t.InstallTimeAvailable, t.InstallTimePredictionSeconds, t.CVENumbers})
                .QueryAsString();

            Debug.WriteLine(q);

            string kql =
@"Update
| distinct InstallTimeAvailable, InstallTimePredictionSeconds, CVENumbers";

            Assert.Equal(q,kql);
        }

        [Fact]
        public void Distinct_With_Extend_Dynamic_Column()
        {
            string q = Kusto.New().Update
            .Extend((t, col) => new {ANewColumn = t.SubscriptionId})
                .Distinct((t, col) =>  new {t.InstallTimeAvailable, t.InstallTimePredictionSeconds, t.CVENumbers, col.ANewColumn})
                .QueryAsString();

            Debug.WriteLine(q);

            string kql =
@"Update
| extend ANewColumn = SubscriptionId
| distinct InstallTimeAvailable, InstallTimePredictionSeconds, CVENumbers, ANewColumn";

            Assert.Equal(q,kql);
        }

        [Fact]
        public void Distinct_With_Where_Extend_Dynamic_Column()
        {
            string q = Kusto.New().Update
                .Where((t) => t.TimeGenerated > Kql.ago("24h"))
                .Extend((t, col) => new {ANewColumn = t.SubscriptionId})
                .Distinct((t, col) =>  new {t.InstallTimeAvailable, t.InstallTimePredictionSeconds, t.CVENumbers, col.ANewColumn})
                .QueryAsString();

            Debug.WriteLine(q);

            string kql =
@"Update
| where TimeGenerated > ago(24h)
| extend ANewColumn = SubscriptionId
| distinct InstallTimeAvailable, InstallTimePredictionSeconds, CVENumbers, ANewColumn";

            Assert.Equal(q,kql);
        }

                [Fact]
        public void Simple_Distinct_All()
        {
            string q = Kusto.New().Update
                .DistinctAll()
                .QueryAsString();

            Debug.WriteLine(q);

            string kql =
@"Update
| distinct *";

            Assert.Equal(q,kql);
        }
    }
}
