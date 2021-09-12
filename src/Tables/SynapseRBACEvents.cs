
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class SynapseRBACEvents : TableBase<SynapseRBACEvents>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The operation associated with log record.
            public string OperationName {get; set;}
            
            /// The API version of the operation.
            public string OperationVersion {get; set;}
            
            /// The category of the log.
            public string Category {get; set;}
            
            /// Status of the event.
            public string ResultType {get; set;}
            
            /// The sub status of the event.
            public string ResultSignature {get; set;}
            
            /// The static text description of this operation.
            public string ResultDescription {get; set;}
            
            /// A GUID used to group together a set of related events.
            public string CorrelationId {get; set;}
            
            /// A JSON blob that describes the identity of the user or application that performed the operation.
            public dynamic Identity {get; set;}
            
            /// The region of the resource emitting the event.
            public string Location {get; set;}
            
            /// extended properties related to this event.
            public dynamic Properties {get; set;}
            
            /// The Role Assignment Id for this event.
            public string RoleAssignmentId {get; set;}
            
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
