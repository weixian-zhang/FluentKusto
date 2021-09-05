

namespace FluentKusto
{
    public class SynapseIntegrationActivityRuns
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
        
        ///The Status of the sql requests.
        public string Status {get; set;}
        
        ///The user properties of the log record.
        public dynamic UserProperties {get; set;}
        
        ///The annotation details of the log record.
        public dynamic Annotations {get; set;}
        
        ///The start time (UTC) of the activity run.
        public datetime Start {get; set;}
        
        ///The end time (UTC) for the activity run.
        public datetime End {get; set;}
        
        ///The name of the activity run.
        public string ActivityName {get; set;}
        
        ///The run id of the activity run.
        public string ActivityRunId {get; set;}
        
        ///The pipeline runId of the activity flow.
        public string PipelineRunId {get; set;}
        
        ///The effective integration runtime the activity run job.
        public string EffectiveIntegrationRuntime {get; set;}
        
        ///The type of the activity run.
        public string ActivityType {get; set;}
        
        ///The pipeline name of the activity flow.
        public string PipelineName {get; set;}
        
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
