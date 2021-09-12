
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class KubePVInventory : TableBase<KubePVInventory>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The type of agent the data was collected from
            public string SourceSystem {get; set;}
            
            /// The ID of the Kubernetes cluster of the persistent volume
            public string ClusterId {get; set;}
            
            /// The name of the Kubernetes cluster of the persistent volume
            public string ClusterName {get; set;}
            
            /// A comma separated list of access modes of the persistent volume
            public string PVAccessModes {get; set;}
            
            /// The capacity of the persistent volume measured in bytes
            public long PVCapacityBytes {get; set;}
            
            /// The Kubernetes persistent volume creation time
            public DateTime PVCreationTimeStamp {get; set;}
            
            /// The Kubernetes persistent volume name
            public string PVName {get; set;}
            
            /// The Kubernetes persistent volume claim name
            public string PVCName {get; set;}
            
            /// The Kubernetes namespace of the persistent volume claim
            public string PVCNamespace {get; set;}
            
            /// The status of the persistent volume: Available, Bound, Released, or Failed
            public string PVStatus {get; set;}
            
            /// The name of the storage class of the persistent volume
            public string PVStorageClassName {get; set;}
            
            /// The type of persistent volume from the list of Kubernetes supported volume plugins
            public string PVType {get; set;}
            
            /// The specific dimensions relating to the type of the persistent volume
            public dynamic PVTypeInfo {get; set;}
            
            /// The date and time the record was created
            public DateTime TimeGenerated {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
