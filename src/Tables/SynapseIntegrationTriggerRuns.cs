

namespace FluentKusto
{
    public class SynapseIntegrationTriggerRuns
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The operation associated with log record.
        public string OperationName {get; set;}
        
        ///The category of the log.
        public string Category {get; set;}
        
        ///The correlationId for the log record.
        public string CorrelationId {get; set;}
        
        ///The log type info level of the record.
        public string Level {get; set;}
        
        ///The location of the resource in the cloud where this log is originated.
        public string Location {get; set;}
        
        ///The associated tags of the log record.
        public dynamic Tags {get; set;}
        
        ///The Status of the SQL requests.
        public string Status {get; set;}
        
        ///The user properties of the log record.
        public dynamic UserProperties {get; set;}
        
        ///The annotation details of the log record.
        public dynamic Annotations {get; set;}
        
        ///The trigger id of the log record.
        public string TriggerId {get; set;}
        
        ///The trigger name of the log record.
        public string TriggerName {get; set;}
        
        ///The trigger type of the log record.
        public string TriggerType {get; set;}
        
        ///The trigger id of the log record.
        public string TriggerEvent {get; set;}
        
        ///The start time (UTC) of the trigger run.
        public datetime Start {get; set;}
        
        ///The parameter details of the pipeline run.
        public dynamic Parameters {get; set;}
        
        ///The system parameter details of the pipeline run.
        public dynamic SystemParameters {get; set;}
        
        ///The type of the pipeline run.
        public string Type {get; set;}
        
        ///The tenantId details of the pipeline run.
        public string PipelineTenantId {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
