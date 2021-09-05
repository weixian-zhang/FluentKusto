

namespace FluentKusto
{
    public class MicrosoftDataShareShareLog
    {

        ///
        public string TenantId {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///The timestamp (UTC) of the log
        public datetime TimeGenerated {get; set;}
        
        ///The name of the operation represented by this event
        public string OperationName {get; set;}
        
        ///The name of the log that belongs to
        public string Category {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
