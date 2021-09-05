

namespace FluentKusto
{
    public class ACSSMSIncomingOperations
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The operation associated with log record.
        public string OperationName {get; set;}
        
        ///The ID for correlated events. Can be used to identify correlated events between multiple tables.
        public string CorrelationId {get; set;}
        
        ///The API-version associated with the operation, if the operationName was performed using an API. If there is no API that corresponds to this operation, the version represents the version of that operation in case the properties associated with the operation change in the future.
        public string OperationVersion {get; set;}
        
        ///The log category of the event. Category is the granularity at which you can enable or disable logs on a particular resource. The properties that appear within the properties blob of an event are the same within a particular log category and resource type.
        public string Category {get; set;}
        
        ///The status of the operation.
        public string ResultType {get; set;}
        
        ///The sub status of the operation. If this operation corresponds to a REST API call, this field is the HTTP status code of the corresponding REST call.
        public string ResultSignature {get; set;}
        
        ///The status text response of the result of this operation.
        public string ResultDescription {get; set;}
        
        ///The duration of the operation in milliseconds.
        public int DurationMs {get; set;}
        
        ///The caller IP address, if the operation corresponds to an API call that would come from an entity with a publicly available IP address.
        public string CallerIpAddress {get; set;}
        
        ///The severity level of the operation.
        public string Level {get; set;}
        
        ///The URI of the request
        public string URI {get; set;}
        
        ///The number of characters in the outgoing message.
        public int OutgoingMessageLength {get; set;}
        
        ///The number of characters in the incoming message.
        public int IncomingMessageLength {get; set;}
        
        ///The number of attempts made to deliver this message.
        public int DeliveryAttempts {get; set;}
        
        ///The phone number the SMS message is being sent to.
        public string PhoneNumber {get; set;}
        
        ///The Sdk type being used in the request.
        public string SdkType {get; set;}
        
        ///The platform type being used in the request.
        public string PlatformType {get; set;}
        
        ///The method used in the request.
        public string Method {get; set;}
        
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
