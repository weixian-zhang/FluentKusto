
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AACAudit : TableBase<AACAudit>
    {

            /// 
            public string TenantId {get; set;}
            
            /// Timestamp (UTC) when log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The log category of the event.
            public string Category {get; set;}
            
            /// GUID for correlated logs.
            public string CorrelationId {get; set;}
            
            /// Status of this audit event.
            public string Status {get; set;}
            
            /// Name of the audited operation.
            public string OperationName {get; set;}
            
            /// Audit category of this event.
            public string EventCategory {get; set;}
            
            /// Target resource that apply to the operation being audited.
            public dynamic TargetResource {get; set;}
            
            /// The result of the operation being audited.
            public string ResultType {get; set;}
            
            /// Caller identity of this event.
            public dynamic CallerIdentity {get; set;}
            
            /// IP Address of the caller that triggered this audit event.
            public string CallerIPAddress {get; set;}
            
            /// Unique request ID generated by server.
            public string RequestId {get; set;}
            
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
