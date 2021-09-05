

namespace FluentKusto
{
    public class AmlRunStatusChangedEvent
    {

        ///
        public string TenantId {get; set;}
        
        ///The api-version associated with the operation, if the operationName was performed using an API.
        public string OperationVersion {get; set;}
        
        ///The status of the event. Typical values include Started, In Progress, Succeeded, Failed, Active, and Resolved.
        public string ResultType {get; set;}
        
        ///The sub status of the event. If this operation corresponds to a REST API call, this is the HTTP status code of the corresponding REST call.
        public string ResultSignature {get; set;}
        
        ///The static text description of this operation.
        public string ResultDescription {get; set;}
        
        ///The duration of the operation in milliseconds.
        public string DurationMs {get; set;}
        
        ///The caller IP address.
        public string CallerIpAddress {get; set;}
        
        ///A GUID used to group together a set of related events.
        public string CorrelationId {get; set;}
        
        ///Identity of the user or application that performed the operation
        public string Identity {get; set;}
        
        ///The severity level of the event. Must be one of Informational, Warning, Error, or Critical.
        public string Level {get; set;}
        
        ///The region of the resource emitting the event.
        public string Location {get; set;}
        
        ///The timestamp (UTC) of the event.
        public datetime TimeGenerated {get; set;}
        
        ///The name of the operation associated with the log entry.
        public string OperationName {get; set;}
        
        ///User friendly workspace identifier.
        public string WorkspaceName {get; set;}
        
        ///Unique workspace identifer.
        public string WorkspaceId {get; set;}
        
        ///Unique run identifier.
        public string RunId {get; set;}
        
        ///Updated run status.
        public string Status {get; set;}
        
        ///Message associated with run status change.
        public string Message {get; set;}
        
        ///Friendly name of run status change initiator.
        public string TriggeringUserName {get; set;}
        
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
