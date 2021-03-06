
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AACHttpRequest : TableBase<AACHttpRequest>
    {

            /// 
            public string TenantId {get; set;}
            
            /// Timestamp (UTC) when log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// HTTP Method.
            public string Method {get; set;}
            
            /// GUID for correlated logs.
            public string CorrelationId {get; set;}
            
            /// The log category of the event.
            public string Category {get; set;}
            
            /// Unique request ID generated by server.
            public string RequestId {get; set;}
            
            /// Request ID provided by client.
            public string ClientRequestId {get; set;}
            
            /// The duration of the operation in milliseconds.
            public int DurationMs {get; set;}
            
            /// URI of the request.
            public string RequestURI {get; set;}
            
            /// IP Address of the client that sent the request.
            public string ClientIPAddress {get; set;}
            
            /// User Agent provided by the client.
            public string UserAgent {get; set;}
            
            /// HTTP Status Code of the request.
            public int StatusCode {get; set;}
            
            /// Length in bytes of the HTTP request.
            public int RequestLength {get; set;}
            
            /// Length in bytes of the HTTP response.
            public int ResponseLength {get; set;}
            
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
