
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AmlRunEvent : TableBase<AmlRunEvent>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The identity of the user or application that performed the operation.
            public dynamic Identity {get; set;}
            
            /// The timestamp (UTC) of the event.
            public DateTime TimeGenerated {get; set;}
            
            /// The name of the operation associated with the log entry.
            public string OperationName {get; set;}
            
            /// The unique ID of the workspace.
            public string AmlWorkspaceId {get; set;}
            
            /// The unique ID of the run.
            public string RunId {get; set;}
            
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
