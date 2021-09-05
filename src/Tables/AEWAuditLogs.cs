

namespace FluentKusto
{
    public class AEWAuditLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///Time (UTC) of the HTTP request.
        public datetime TimeGenerated {get; set;}
        
        ///The Exp component sending the log.
        public string ExpComponentName {get; set;}
        
        ///The message in the log.
        public string Message {get; set;}
        
        ///The event category. Typical log categories are Audit, Operational, Execution, and Request.
        public string Category {get; set;}
        
        ///The event name.
        public string ActionName {get; set;}
        
        ///The event URI.
        public string RequestUri {get; set;}
        
        ///The user identity triggering the event.
        public string Operator {get; set;}
        
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
