using System;
using System.Threading.Tasks;
using Azure.Monitor.Query.Models;
using Microsoft.Azure.ApplicationInsights.Query.Models;

namespace FluentKusto
{
    public interface IKqlExecutor
    {
        public Task<LogsQueryResult> OnLogAnalytics(string workspaceId);

        public Task<Tuple<LogsQueryResult, string>> OnLogAnalyticsWithQueryOutput(string workspaceId);

        public Task<QueryResults> OnAppInsights
            (string tenantId, string appId, string clientId, string clientSecret);

        public Task<Tuple<QueryResults, string>> OnAppInsightsWithQueryOutput
            (string tenantId, string appId, string clientId, string clientSecret);
    }
}