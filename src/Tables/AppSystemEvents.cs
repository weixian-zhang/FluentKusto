

namespace FluentKusto
{
    public class AppSystemEvents
    {

        ///
        public string TenantId {get; set;}
        
        ///Date and time when the system event was recorded.
        public datetime TimeGenerated {get; set;}
        
        ///Event type
        public string EventType {get; set;}
        
        ///Event name
        public string Name {get; set;}
        
        ///Event properties.
        public dynamic Properties {get; set;}
        
        ///Event measurements.
        public dynamic Measurements {get; set;}
        
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
