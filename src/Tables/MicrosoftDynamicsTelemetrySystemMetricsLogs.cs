

namespace FluentKusto
{
    public class MicrosoftDynamicsTelemetrySystemMetricsLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///The timestamp (UTC) of the log.
        public datetime TimeGenerated {get; set;}
        
        ///Log category
        public string Category {get; set;}
        
        ///Unique identifier for an environment as shown in Lifecycle Services
        public string EnvironmentId {get; set;}
        
        ///Type of the machine (AOS/BI) emitting the events
        public string Role {get; set;}
        
        ///Name of the machine emitting the events
        public string RoleInstance {get; set;}
        
        ///Name of the event
        public string EventName {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
