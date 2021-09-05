

namespace FluentKusto
{
    public class ADFSSISIntegrationRuntimeLogs
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
        
        ///Status of the log
        public string ResultType {get; set;}
        
        ///Event message
        public string Message {get; set;}
        
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
