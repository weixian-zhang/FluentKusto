

namespace FluentKusto
{
    public class ADFSSISPackageExecutionComponentPhases
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of the log
        public datetime TimeGenerated {get; set;}
        
        ///The name of the operation represented by this event
        public string OperationName {get; set;}
        
        ///The name of the log that belongs to
        public string Category {get; set;}
        
        ///correlation id
        public string CorrelationId {get; set;}
        
        ///Data factory name
        public string DataFactoryName {get; set;}
        
        ///Integration runtime name
        public string IntegrationRuntimeName {get; set;}
        
        ///Verbosity level of log
        public string Level {get; set;}
        
        ///Execution id
        public long ExecutionId {get; set;}
        
        ///Package name
        public string PackageName {get; set;}
        
        ///Task name
        public string TaskName {get; set;}
        
        ///Subcomponent name
        public string SubcomponentName {get; set;}
        
        ///Phase
        public string Phase {get; set;}
        
        ///Start time
        public datetime StartTime {get; set;}
        
        ///End time
        public datetime EndTime {get; set;}
        
        ///Execution path
        public string ExecutionPath {get; set;}
        
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
