
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AmlPipelineEvent : TableBase<AmlPipelineEvent>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The status of the event. Typical values include Started, In Progress, Succeeded, Failed, Active, and Resolved.
            public string ResultType {get; set;}
            
            /// A GUID used to group together a set of related events.
            public string CorrelationId {get; set;}
            
            /// The identity of the user or application that performed the operation.
            public dynamic Identity {get; set;}
            
            /// The timestamp (UTC) of the event.
            public DateTime TimeGenerated {get; set;}
            
            /// The name of the operation associated with the log entry.
            public string OperationName {get; set;}
            
            /// The unique ID of the module.
            public string AmlModuleId {get; set;}
            
            /// The AAD tenant ID the operation was submitted for.
            public string AadTenantId {get; set;}
            
            /// The name of the AML Module.
            public string AmlModuleName {get; set;}
            
            /// The unique ID of the AML workspace.
            public string AmlWorkspaceId {get; set;}
            
            /// The name of the AML workspace.
            public string AmlWorkspaceName {get; set;}
            
            /// The ID of the AML pipeline.
            public string AmlPipelineId {get; set;}
            
            /// The ID of the parent AML pipeline (in the case of cloning).
            public string AmlParentPipelineId {get; set;}
            
            /// The ID of the AML pipeline draft.
            public string AmlPipelineDraftId {get; set;}
            
            /// The name of the AML pipeline draft.
            public string AmlPipelineDraftName {get; set;}
            
            /// The ID of the AML pipeline endpoint.
            public string AmlPipelineEndpointId {get; set;}
            
            /// The name of the AML pipeline endpoint.
            public string AmlPipelineEndpointName {get; set;}
            
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
