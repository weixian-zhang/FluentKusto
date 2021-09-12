
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class KubeMonAgentEvents : TableBase<KubeMonAgentEvents>
    {

            /// Type of agent the data was collected from. 
            public string SourceSystem {get; set;}
            
            /// Computer/node name in the cluster for which the event applies. If not, computer/node name of sourcing computer
            public string Computer {get; set;}
            
            /// Date and time the record was created.
            public DateTime TimeGenerated {get; set;}
            
            /// Category of the event. Ex;- container.azm.ms/promscraping, container.azm.ms/configmap
            public string Category {get; set;}
            
            /// Event level for the event. [Error, Warning, Info]
            public string Level {get; set;}
            
            /// ID of the kubernetes cluster from which the event was sourced
            public string ClusterId {get; set;}
            
            /// ID of the kubernetes cluster from which the event was sourced
            public string ClusterName {get; set;}
            
            /// Event message.
            public string Message {get; set;}
            
            /// Dimensions/properties for the event
            public dynamic Tags {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
