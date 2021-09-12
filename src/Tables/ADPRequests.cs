
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ADPRequests : TableBase<ADPRequests>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log record was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The operation associated with the log record.
            public string OperationName {get; set;}
            
            /// The API version against which the operation was performed.
            public string OperationVersion {get; set;}
            
            /// The URI of the request.
            public string Uri {get; set;}
            
            /// Whether the request was successful or not. Note that long-running asynchronous operations might fail even when the request is successful.
            public bool Success {get; set;}
            
            /// The HTTP response status code of the corresponding REST call.
            public int HttpStatusCode {get; set;}
            
            /// The duration of the operation in milliseconds.
            public int DurationMs {get; set;}
            
            /// IP address of the user who has performed the operation.
            public string CallerIpAddress {get; set;}
            
            /// W3C Trace Context information used for event correlation.
            public dynamic TraceContext {get; set;}
            
            /// Internal ADP correlation ID needed for support scenarios.
            public string CorrelationId {get; set;}
            
            /// The location (region) of the resource.
            public string Location {get; set;}
            
            /// Additional properties related to the request.
            public dynamic Properties {get; set;}
            
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
