
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class CDBCassandraRequests : TableBase<CDBCassandraRequests>
    {

            /// 
            public string TenantId {get; set;}
            
            /// Timestamp (in UTC) of the Cassandra API data plane request.
            public DateTime TimeGenerated {get; set;}
            
            /// The name of the Cosmos DB account against which this request was issued.
            public string AccountName {get; set;}
            
            /// The Cassandra API operation that was executed.
            public string OperationName {get; set;}
            
            /// The user agent suffix of the client issuing the�request.
            public string UserAgent {get; set;}
            
            /// The unique identifier (GUID) for this Cassandra API request.
            public string ActivityId {get; set;}
            
            /// The error code (if applicable) for this request.
            public string ErrorCode {get; set;}
            
            /// The�server side�execution time (in�ms) for this request.
            public float DurationMs {get; set;}
            
            /// The RU (Request Unit) consumption for this request.
            public float RequestCharge {get; set;}
            
            /// The name of the Cosmos DB database against which this request was�issued.
            public string DatabaseName {get; set;}
            
            /// The name of the Cosmos DB table/container against which this request was�issued.
            public string CollectionName {get; set;}
            
            /// The authorization token used for this�request.
            public string AuthorizationTokenType {get; set;}
            
            /// The number of server side retries issued for this�request.
            public int RetryCount {get; set;}
            
            /// The IP address of the client that issued this�request.
            public string Address {get; set;}
            
            /// Full query text with parameters (if opted in) for this request.
            public string PIICommandText {get; set;}
            
            /// The estimated time (in�ms)�spent in�retrying due to rate limited operations.
            public float RateLimitingDelayMs {get; set;}
            
            /// Boolean flag indicating if this request�was retried server side due to�throttles.
            public bool RetriedDueToRateLimiting {get; set;}
            
            /// The region against which this request was�issued.
            public string RegionName {get; set;}
            
            /// The payload size (in bytes)�of�the request.
            public float RequestLength {get; set;}
            
            /// The payload size (in bytes) of the server response.
            public float ResponseLength {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
