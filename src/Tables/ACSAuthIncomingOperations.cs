

namespace FluentKusto
{
    public class ACSAuthIncomingOperations
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The operation associated with log record.
        public string OperationName {get; set;}
        
        ///The ID for correlated events. Can be used to identify correlated events between multiple tables.
        public string CorrelationId {get; set;}
        
        ///The API-version associated with the operation or version of the operation (if there is no API version).
        public string OperationVersion {get; set;}
        
        ///The log category of the event. Logs with the same log category and resource type will have the same properties fields.
        public string Category {get; set;}
        
        ///The status of the operation.
        public string ResultType {get; set;}
        
        ///The sub status of the operation. If this operation corresponds to a REST API call, this field is the HTTP status code of the corresponding REST call.
        public string ResultSignature {get; set;}
        
        ///The static text description of this operation.
        public string ResultDescription {get; set;}
        
        ///The duration of the operation in milliseconds.
        public int DurationMs {get; set;}
        
        ///The caller IP address, if the operation corresponds to an API call that would come from an entity with a publicly available IP address.
        public string CallerIpAddress {get; set;}
        
        ///The severity level of the operation.
        public string Level {get; set;}
        
        ///The URI of the request
        public string URI {get; set;}
        
        ///The request sender's identity
        public string Identity {get; set;}
        
        ///Scopes for the auth request (e.g. Chat, SMS, etc.)
        public dynamic Scopes {get; set;}
        
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
