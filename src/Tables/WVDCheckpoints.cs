

namespace FluentKusto
{
    public class WVDCheckpoints
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of the event.
        public datetime TimeGenerated {get; set;}
        
        ///The type of activity for which this checkpoint was reported.
        public string ActivityType {get; set;}
        
        ///The correlation Id for the activity.
        public string CorrelationId {get; set;}
        
        ///The user name for the activity associated with the checkpoint.
        public string UserName {get; set;}
        
        ///The name of the checkpoint.
        public string Name {get; set;}
        
        ///The component that emitted the checkpoint.
        public string Source {get; set;}
        
        ///The parameters for the checkpoint.
        public dynamic Parameters {get; set;}
        
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
