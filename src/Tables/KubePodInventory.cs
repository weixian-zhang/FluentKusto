

namespace FluentKusto
{
    public class KubePodInventory
    {

        ///Type of agent the data was collected from. 
        public string SourceSystem {get; set;}
        
        ///Date and time the record was created.
        public datetime TimeGenerated {get; set;}
        
        ///Computer/node name in the cluster that has this pod/container. Unscheduled pods will have this as empty.
        public string Computer {get; set;}
        
        ///ID of the kubernetes cluster from which the event was sourced
        public string ClusterId {get; set;}
        
        ///Container creation time
        public datetime ContainerCreationTimeStamp {get; set;}
        
        ///Unique ID of the pod
        public string PodUid {get; set;}
        
        ///Pod creation time
        public datetime PodCreationTimeStamp {get; set;}
        
        ///Not used currently[for future use]
        public string InstanceName {get; set;}
        
        ///Restart count for the container
        public int ContainerRestartCount {get; set;}
        
        ///Restart count for the pod. [Sum of all restarts of all containers in the pod]
        public int PodRestartCount {get; set;}
        
        ///Pod's start time (for started pods)
        public datetime PodStartTime {get; set;}
        
        ///Time container started.
        public datetime ContainerStartTime {get; set;}
        
        ///Kubernetes Service the pod belongs to (if any)
        public string ServiceName {get; set;}
        
        ///Container/Pod's controller kind. Ex;- ReplicaSet 
        public string ControllerKind {get; set;}
        
        ///Container/Pod's controller Name. Ex;- kubernetes-dashboard-9f5bf9974 
        public string ControllerName {get; set;}
        
        ///Container's last observered current state [container.state]
        public string ContainerStatus {get; set;}
        
        ///Container's ID
        public string ContainerID {get; set;}
        
        ///Container name. This is in poduid/containername format.
        public string ContainerName {get; set;}
        
        ///Kubernetes Pod Name
        public string Name {get; set;}
        
        ///Pod Labels
        public string PodLabel {get; set;}
        
        ///Kubernetes Namespace for the pod/container
        public string Namespace {get; set;}
        
        ///Last observed Pod Status [pod.status.phase]
        public string PodStatus {get; set;}
        
        ///ID of the kubernetes cluster from which the event was sourced
        public string ClusterName {get; set;}
        
        ///Pod's IP Address
        public string PodIp {get; set;}
        
        ///Reason if any for container's status.
        public string ContainerStatusReason {get; set;}
        
        ///Container's last observed last status
        public string ContainerLastStatus {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
