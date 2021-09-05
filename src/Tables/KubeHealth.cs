

namespace FluentKusto
{
    public class KubeHealth
    {

        ///Type of agent the data was collected from. 
        public string SourceSystem {get; set;}
        
        ///Type of the monitor. Ex;- node or cluster
        public string MonitorTypeId {get; set;}
        
        ///Instance ID of the monitor generating the health state
        public string MonitorInstanceId {get; set;}
        
        ///For future [Not used]
        public string ParentMonitorInstanceId {get; set;}
        
        ///ID of the kubernetes cluster from which the event was sourced
        public string ClusterId {get; set;}
        
        ///Old state for the monitor
        public string OldState {get; set;}
        
        ///New state for the monitor
        public string NewState {get; set;}
        
        ///Date and time the record was created.
        public datetime TimeGenerated {get; set;}
        
        ///Time the state change first was observed for this monitor
        public datetime TimeFirstObserved {get; set;}
        
        ///Monitor Labels. This may be a combination of kubernetes labels and azure monitor specific labels
        public dynamic MonitorLabels {get; set;}
        
        ///Health state details
        public dynamic Details {get; set;}
        
        ///Monitor configuration. This will be empty for aggregate monitors. Populated for Unit Monitors
        public dynamic MonitorConfig {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
