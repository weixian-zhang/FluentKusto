using System;
using Xunit;

using FluentKusto;
using System.Diagnostics;

namespace FluentKusto.Tests
{
    public class LAW_KqlQueryResultTests
    {
        [Fact]
        public void Simple_Where_Should_Return_Correct_Query()
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
    }
}
