

namespace FluentKusto
{
    public class AmlDataSetEvent
    {

        ///
        public string TenantId {get; set;}
        
        ///The status of the event. Typical values include Started, In Progress, Succeeded, Failed, Active, and Resolved.
        public string ResultType {get; set;}
        
        ///The identity of the user or application that performed the operation.
        public dynamic Identity {get; set;}
        
        ///The timestamp (UTC) of the event.
        public datetime TimeGenerated {get; set;}
        
        ///The name of the operation associated with the log entry.
        public string OperationName {get; set;}
        
        ///The unique ID of the workspace.
        public string AmlWorkspaceId {get; set;}
        
        ///The AAD tenant ID the operation was submitted for.
        public string AadTenantId {get; set;}
        
        ///The ID of the AML Data Set.
        public string AmlDatasetId {get; set;}
        
        ///The name of the AML Data Set.
        public string AmlDatasetName {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
