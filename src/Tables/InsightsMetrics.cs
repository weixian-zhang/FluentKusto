

namespace FluentKusto
{
    public class InsightsMetrics
    {

        ///
        public string SourceSystem {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string Computer {get; set;}
        
        ///
        public string Origin {get; set;}
        
        ///
        public string Namespace {get; set;}
        
        ///
        public string Name {get; set;}
        
        ///
        public real Val {get; set;}
        
        ///
        public string Tags {get; set;}
        
        ///
        public string AgentId {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
