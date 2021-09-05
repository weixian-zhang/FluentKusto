

namespace FluentKusto
{
    public class KubeServices
    {

        ///Type of agent the data was collected from. 
        public string SourceSystem {get; set;}
        
        ///Date and time the record was created.
        public datetime TimeGenerated {get; set;}
        
        ///ID of the kubernetes cluster from which the event was sourced
        public string ClusterId {get; set;}
        
        ///Cluster IP address of the service
        public string ClusterIp {get; set;}
        
        ///ID of the kubernetes cluster from which the event was sourced
        public string ClusterName {get; set;}
        
        ///Kuberneets namespace for the service
        public string Namespace {get; set;}
        
        ///Selector labels for label based services
        public string SelectorLabels {get; set;}
        
        ///Kubernetes Service name
        public string ServiceName {get; set;}
        
        ///Kubernetes Service type [ClusterIP/NodePort/LoadBalancer/ExternalName]
        public string ServiceType {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
