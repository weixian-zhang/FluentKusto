
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class LAQueryLogs : TableBase<LAQueryLogs>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) at which the query was submitted.
            public DateTime TimeGenerated {get; set;}
            
            /// The ID for correlated events.
            public string CorrelationId {get; set;}
            
            /// AAD ObjectId of the caller.
            public string AADObjectId {get; set;}
            
            /// AAD TenantId of the caller.
            public string AADTenantId {get; set;}
            
            /// AAD Email of the caller.
            public string AADEmail {get; set;}
            
            /// AAD ClientId used by the caller.
            public string AADClientId {get; set;}
            
            /// The starting time (UTC) of the time range across which the query was was requested by the caller to be executed.
            public DateTime QueryTimeRangeStart {get; set;}
            
            /// The end time (UTC) of the time range across which the query was was requested by the caller to be executed.
            public DateTime QueryTimeRangeEnd {get; set;}
            
            /// The full body of the query as submitted by the user.
            public string QueryText {get; set;}
            
            /// ClientApp string in the request header (x-ms-app).
            public string RequestClientApp {get; set;}
            
            /// ResourceId of the request URL.
            public string RequestTarget {get; set;}
            
            /// ResourceId of all referenced workspaces, applications, and resources across which the query was requested by the caller to be executed.
            public dynamic RequestContext {get; set;}
            
            /// Filters applied to the request context.
            public dynamic RequestContextFilters {get; set;}
            
            /// The HTTP response code for the request.
            public int ResponseCode {get; set;}
            
            /// The number of rows that were returned.
            public int ResponseRowCount {get; set;}
            
            /// The duration (in ms) that the query took to execute.
            public float ResponseDurationMs {get; set;}
            
            /// The CPU (in ms) used in the execution of this query.
            public float StatsCPUTimeMs {get; set;}
            
            /// The total KB of data that was processed as part of the query.
            public float StatsDataProcessedKB {get; set;}
            
            /// The starting time (UTC) of the time range across which the data processed.
            public DateTime StatsDataProcessedStart {get; set;}
            
            /// The end time (UTC) of the time range across which the data processed.
            public DateTime StatsDataProcessedEnd {get; set;}
            
            /// The number of workspaces that the query accessed, either explicitly or otherwise.
            public int StatsWorkspaceCount {get; set;}
            
            /// The number of regions that the workspaces accessed are spread across.
            public int StatsRegionCount {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
                }
}
