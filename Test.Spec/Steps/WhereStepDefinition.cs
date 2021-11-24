using TechTalk.SpecFlow;
using Xunit;
using FluentKusto;

namespace FluentKusto.Test.Spec
{
    [Binding]
    public sealed class WhereStepDefinition
    {
        string _kqlResult = "";

        [Given("a Log Analytics or Application Insights table object")]
        public void GivenALogAnalyticsOrApplicationInsightsTableObject()
        {

        }

        [When(@"user uses Where operator in query:([^\""]*)")]
        public void UserUsesWhereOperatorInQuery(string multilineEmpty, string fluentKusto)
        {
            _kqlResult = Kusto.New().AzureActivity
            .Where(tbl => tbl.SourceSystem.In("Sys A", "Sys B", "Sys X"))
            .QueryAsString();
        }

        [Then(@"the kql query syntax should be:([^\""]*)")]
        public void  TheKqlQuerySyntaxShouldBe(string multilineEmpty, string kql)
        {
            Assert.Equal(_kqlResult, kql);
        }
    }
}