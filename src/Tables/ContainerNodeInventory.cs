

namespace FluentKusto
{
    public class ContainerNodeInventory
    {

        ///Type of agent the data was collected from. 
        public string SourceSystem {get; set;}
        
        ///Date and time the record was created.
        public datetime TimeGenerated {get; set;}
        
        ///Computer/node name in the cluster for which the event applies. If not, computer/node name of sourcing computer
        public string Computer {get; set;}
        
        ///Nodes host OS Image
        public string OperatingSystem {get; set;}
        
        ///Container runtime version
        public string DockerVersion {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
