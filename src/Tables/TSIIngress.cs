

namespace FluentKusto
{
    public class TSIIngress
    {

        ///
        public string TenantId {get; set;}
        
        ///Time (UTC) at which this event is generated.
        public datetime TimeGenerated {get; set;}
        
        ///The location of the resource.
        public string Location {get; set;}
        
        ///Category of the log event.
        public string Category {get; set;}
        
        ///Operation name of the event.
        public string OperationName {get; set;}
        
        ///The correlation ID of the request.
        public string CorrelationId {get; set;}
        
        ///The severity level of the event.
        public string Level {get; set;}
        
        ///Description of the result of the operation, such as 'Received forbidden error'.
        public string ResultDescription {get; set;}
        
        ///The message associated with the error. Includes details on what went wrong and how to mitigate the error.
        public string Message {get; set;}
        
        ///The code associated with the error
        public string ErrorCode {get; set;}
        
        ///The type of event source. It could either be Event hub or IoT hub.
        public string EventSourceType {get; set;}
        
        ///A collection of properties specific to your event source. Contains details such as the consumer group and the access key name.
        public dynamic EventSourceProperties {get; set;}
        
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
