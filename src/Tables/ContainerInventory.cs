
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ContainerInventory : TableBase<ContainerInventory>
    {

            /// Type of agent the data was collected from. This will be 'Containers'
            public string SourceSystem {get; set;}
            
            /// Date and time the record was created.
            public DateTime TimeGenerated {get; set;}
            
            /// Computer name/Node name
            public string Computer {get; set;}
            
            /// Unique ContainerID
            public string ContainerID {get; set;}
            
            /// Name of the container
            public string Name {get; set;}
            
            /// 
            public string ContainerHostname {get; set;}
            
            /// Container Image ID
            public string ImageID {get; set;}
            
            /// Container's Remote repository
            public string Repository {get; set;}
            
            /// Container Image Name 
            public string Image {get; set;}
            
            /// Container Image Tag 
            public string ImageTag {get; set;}
            
            /// Last known state of the container
            public string ContainerState {get; set;}
            
            /// Container's port bindings
            public string Ports {get; set;}
            
            /// Container's legacy Hostconfig links
            public string Links {get; set;}
            
            /// Container exit code
            public int ExitCode {get; set;}
            
            /// Docker Compose Project name. Comes from container label : com.docker.compose.project
            public string ComposeGroup {get; set;}
            
            /// Container's environment variables
            public string EnvironmentVar {get; set;}
            
            /// entrypoint and the command executed for all running containers
            public string Command {get; set;}
            
            /// Container creation time
            public DateTime CreatedTime {get; set;}
            
            /// Container start time
            public DateTime StartedTime {get; set;}
            
            /// Container termination time
            public DateTime FinishedTime {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
