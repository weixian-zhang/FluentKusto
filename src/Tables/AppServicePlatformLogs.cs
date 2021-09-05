

namespace FluentKusto
{
    public class AppServicePlatformLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///Time when event is generated
        public datetime TimeGenerated {get; set;}
        
        ///The name of the operation represented by this event.
        public string OperationName {get; set;}
        
        ///Level of log verbosity
        public string Level {get; set;}
        
        ///Log message
        public string Message {get; set;}
        
        ///Application container id
        public string ContainerId {get; set;}
        
        ///Host where the application is running
        public string Host {get; set;}
        
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
