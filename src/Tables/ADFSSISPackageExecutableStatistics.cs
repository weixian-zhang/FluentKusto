

namespace FluentKusto
{
    public class ADFSSISPackageExecutableStatistics
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
        
        ///Execution path
        public string ExecutionPath {get; set;}
        
        ///Executable start time
        public datetime StartTime {get; set;}
        
        ///Executable end time
        public datetime EndTime {get; set;}
        
        ///Executable execution duration
        public int ExecutionDuration {get; set;}
        
        ///Execution result
        public int ExecutionResult {get; set;}
        
        ///Execution value
        public dynamic ExecutionValue {get; set;}
        
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
