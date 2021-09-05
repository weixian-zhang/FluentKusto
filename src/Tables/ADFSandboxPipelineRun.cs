

namespace FluentKusto
{
    public class ADFSandboxPipelineRun
    {

        ///
        public string TenantId {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string ResourceId {get; set;}
        
        ///
        public string OperationName {get; set;}
        
        ///
        public string Category {get; set;}
        
        ///
        public string CorrelationId {get; set;}
        
        ///
        public string Level {get; set;}
        
        ///
        public string Location {get; set;}
        
        ///
        public string Tags {get; set;}
        
        ///
        public string Status {get; set;}
        
        ///
        public string UserProperties {get; set;}
        
        ///
        public string Annotations {get; set;}
        
        ///
        public string EventMessage {get; set;}
        
        ///
        public datetime Start {get; set;}
        
        ///
        public datetime End {get; set;}
        
        ///
        public string FailureType {get; set;}
        
        ///
        public string PipelineName {get; set;}
        
        ///
        public string RunId {get; set;}
        
        ///
        public string Predecessors {get; set;}
        
        ///
        public string Parameters {get; set;}
        
        ///
        public string SystemParameters {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
