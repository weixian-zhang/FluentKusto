
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class KubeEvents : TableBase<KubeEvents>
    {

            /// Type of agent the data was collected from. 
            public string SourceSystem {get; set;}
            
            /// Date and time the record was created.
            public DateTime TimeGenerated {get; set;}
            
            /// Computer/node name in the cluster for which the event applies. If not, computer/node name of sourcing computer
            public string Computer {get; set;}
            
            /// Kind of kubernetes object applicable for the event [event.InvolvedObject.kind] . Ex;- pod
            public string ObjectKind {get; set;}
            
            /// Involved kubernetes object's namespace [event.InvolvedObject.namespace]. Ex;- 'kube-system'
            public string Namespace {get; set;}
            
            /// Involved kubernetes object's name [event.InvolvedObject.name]. Ex;- 'autoschedulejob-158393400-gkv4g'
            public string Name {get; set;}
            
            /// Reason as seen in kubernetes event [event.reason]
            public string Reason {get; set;}
            
            /// Event message [event.message]
            public string Message {get; set;}
            
            /// Type of kubernetes event [event.type]. Ex;- 'Normal' 
            public string KubeEventType {get; set;}
            
            /// Source component that generated the event [event.source.component] . Ex;- default-scheduler
            public string SourceComponent {get; set;}
            
            /// 
            public DateTime FirstSeen {get; set;}
            
            /// Time event was last observed [event.lastTimestamp]
            public DateTime LastSeen {get; set;}
            
            /// Cumulative count of the number of occurences of a specific event [event.count] .
            public float Count {get; set;}
            
            /// ID of the kubernetes cluster from which the event was sourced
            public string ClusterName {get; set;}
            
            /// ID of the kubernetes cluster from which the event was sourced
            public string ClusterId {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
