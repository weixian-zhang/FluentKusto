
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class SynapseBigDataPoolApplicationsEnded : TableBase<SynapseBigDataPoolApplicationsEnded>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The operation associated with log record.
            public string OperationName {get; set;}
            
            /// The category of the log.
            public string Category {get; set;}
            
            /// A GUID used to group together a set of related events.
            public string CorrelationId {get; set;}
            
            /// A JSON blob that describes the identity of the user or application that performed the operation.
            public dynamic Identity {get; set;}
            
            /// extended properties related to this event.
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
