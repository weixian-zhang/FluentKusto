

namespace FluentKusto
{
    public class SignalRServiceDiagnosticLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///The timestamp (UTC) of the log
        public datetime TimeGenerated {get; set;}
        
        ///
        public string Collection {get; set;}
        
        ///
        public string OperationName {get; set;}
        
        ///Location of Azure SignalR Service
        public string Location {get; set;}
        
        ///Log level
        public string Level {get; set;}
        
        ///Caller Ip address
        public string CallerIpAddress {get; set;}
        
        ///Log message
        public string Message {get; set;}
        
        ///User ID for the connection
        public string UserId {get; set;}
        
        ///Connection ID
        public string ConnectionId {get; set;}
        
        ///Connection type
        public string ConnectionType {get; set;}
        
        ///Transport type
        public string TransportType {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
