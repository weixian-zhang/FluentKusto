
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ContainerImageInventory : TableBase<ContainerImageInventory>
    {

            /// Type of agent the data was collected from. This will be 'Containers'
            public string SourceSystem {get; set;}
            
            /// Date and time the record was created.
            public DateTime TimeGenerated {get; set;}
            
            /// Computer name/Node name
            public string Computer {get; set;}
            
            /// Image ID of the container image
            public string ImageID {get; set;}
            
            /// 
            public string Repository {get; set;}
            
            /// Name of Container Image
            public string Image {get; set;}
            
            /// Tag of the container image
            public string ImageTag {get; set;}
            
            /// Size of the container image [amount of data (on disk) that is used for the writable layer]
            public string ImageSize {get; set;}
            
            /// Virtual Size of the Container Image [Total amount of disk-space used for the read-only image data]
            public string VirtualSize {get; set;}
            
            /// Count of containers with this image that are in running state
            public int Running {get; set;}
            
            /// Count of containers with this image that are in stopped state
            public int Stopped {get; set;}
            
            /// Count of containers with this image that are in failed state
            public int Failed {get; set;}
            
            /// Count of containers with this image that are in paused state
            public int Paused {get; set;}
            
            /// Count of containers with this ContainerImage
            public long TotalContainer {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
