

namespace FluentKusto
{
    public class ADFSSISPackageEventMessages
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
        
        ///Operation id
        public long OperationId {get; set;}
        
        ///Message time
        public datetime MessageTime {get; set;}
        
        ///Message type
        public int MessageType {get; set;}
        
        ///Message source type
        public int MessageSourceType {get; set;}
        
        ///Event message
        public string Message {get; set;}
        
        ///Extended info id
        public long ExtendedInfoId {get; set;}
        
        ///Package name
        public string PackageName {get; set;}
        
        ///Event name
        public string EventName {get; set;}
        
        ///Message source name
        public string MessageSourceName {get; set;}
        
        ///Message source id
        public string MessageSourceId {get; set;}
        
        ///Subcomponent name
        public string SubcomponentName {get; set;}
        
        ///Package path
        public string PackagePath {get; set;}
        
        ///Execution path
        public string ExecutionPath {get; set;}
        
        ///Thread id
        public int ThreadId {get; set;}
        
        ///Message code
        public int MessageCode {get; set;}
        
        ///Event message guid
        public string EventMessageGuid {get; set;}
        
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
