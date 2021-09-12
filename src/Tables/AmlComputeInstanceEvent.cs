
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AmlComputeInstanceEvent : TableBase<AmlComputeInstanceEvent>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The status of the event. Typical values include Started, In Progress, Succeeded, Failed, Active, and Resolved.
            public string ResultType {get; set;}
            
            /// A GUID used to group together a set of related events, when applicable.
            public string CorrelationId {get; set;}
            
            /// The identity of the user or application that performed the operation.
            public dynamic Identity {get; set;}
            
            /// The severity level of the event. Must be one of Informational, Warning, Error, or Critical.
            public string Level {get; set;}
            
            /// The timestamp (UTC) of the event.
            public DateTime TimeGenerated {get; set;}
            
            /// The name of the operation associated with the log entry.
            public string OperationName {get; set;}
            
            /// The name of the compute instance.
            public string AmlComputeInstanceName {get; set;}
            
            /// The AAD tenant ID the operation was submitted for.
            public string AadTenantId {get; set;}
            
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
