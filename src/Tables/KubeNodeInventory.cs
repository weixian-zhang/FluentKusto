
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class KubeNodeInventory : TableBase<KubeNodeInventory>
    {

            /// Type of agent the data was collected from. 
            public string SourceSystem {get; set;}
            
            /// Date and time the record was created.
            public DateTime TimeGenerated {get; set;}
            
            /// Computer/node name in the cluster for which the event applies. If not, computer/node name of sourcing computer
            public string Computer {get; set;}
            
            /// ID of the kubernetes cluster from which the event was sourced
            public string ClusterName {get; set;}
            
            /// ID of the kubernetes cluster from which the event was sourced
            public string ClusterId {get; set;}
            
            /// Last transition to/from ready condition for the node (no matter ready is true/false)
            public DateTime LastTransitionTimeReady {get; set;}
            
            /// Kubernetes Node Labels
            public string Labels {get; set;}
            
            /// Comma seperated list of node's status.conditions.type for conditions.status that are true
            public string Status {get; set;}
            
            /// Version of Kubelet in the node
            public string KubeletVersion {get; set;}
            
            /// Version of KubePxoxy in the node
            public string KubeProxyVersion {get; set;}
            
            /// Node created time
            public DateTime CreationTimeStamp {get; set;}
            
            /// Provider ID for Kubernetes
            public string KubernetesProviderID {get; set;}
            
            /// Nodes host OS Image
            public string OperatingSystem {get; set;}
            
            /// Container runtime version
            public string DockerVersion {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
