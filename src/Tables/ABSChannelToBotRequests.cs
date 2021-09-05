

namespace FluentKusto
{
    public class ABSChannelToBotRequests
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The operation associated with log record.
        public string OperationName {get; set;}
        
        ///The ID for correlated events. Can be used to identify correlated events between multiple tables.
        public string CorrelationId {get; set;}
        
        ///Classification of the log.
        public string Category {get; set;}
        
        ///Location of the service sending the log (Azure region name e.g. West US).
        public string Location {get; set;}
        
        ///log level of message (Information, Warning, Error, etc.).
        public string Level {get; set;}
        
        ///Name of the bot or the bot handle.
        public string BotId {get; set;}
        
        ///HTTP request response code.
        public int ResultCode {get; set;}
        
        ///Name of the Channel making generating the log (e.g. DirectLine, Facebook, etc.).
        public string Channel {get; set;}
        
        ///Duration of a request.
        public real DurationMs {get; set;}
        
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
