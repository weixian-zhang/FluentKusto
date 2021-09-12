
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ADTModelsOperation : TableBase<ADTModelsOperation>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The date and time that this event occurred, in UTC
            public DateTime TimeGenerated {get; set;}
            
            /// The type of resource being emitted
            public string Category {get; set;}
            
            /// The type of action being performed during the event
            public string OperationName {get; set;}
            
            /// The API Version utilized during the event
            public string OperationVersion {get; set;}
            
            /// Outcome of the event
            public string ResultType {get; set;}
            
            /// Http status code of the event (if applicable)
            public string ResultSignature {get; set;}
            
            /// Additional details about the event
            public string ResultDescription {get; set;}
            
            /// How long it took to perform the event in milliseconds
            public string DurationMs {get; set;}
            
            /// A masked source IP address for the event
            public string CallerIpAddress {get; set;}
            
            /// Customer provided unique identifier for the event
            public string CorrelationId {get; set;}
            
            /// Application ID used in bearer authorization
            public string ApplicationId {get; set;}
            
            /// The logging severity of the event
            public string Level {get; set;}
            
            /// Azure region in which the Digital Twins instance is located
            public string Location {get; set;}
            
            /// The endpoint utilized during the event
            public string RequestUri {get; set;}
            
            /// TraceId as part of W3C's Trace Context. The ID of the whole trace used to uniquely identify a distributed trace across systems
            public string TraceId {get; set;}
            
            /// SpanId as part of W3C's Trace Context. The ID of this request in the trace
            public string SpanId {get; set;}
            
            /// ParentId as part of W3C's Trace Context. A request without a parent id is the root of the trace
            public string ParentId {get; set;}
            
            /// TraceFlags as part of W3C's Trace Context. Controls tracing flags such as sampling, trace level, etc.
            public string TraceFlags {get; set;}
            
            /// TraceState as part of W3C's Trace Context. Additional vendor-specific trace identification information to span across different distributed tracing systems
            public string TraceState {get; set;}
            
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
