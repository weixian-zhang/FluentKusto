

namespace FluentKusto
{
    public class ContainerServiceLog
    {

        ///
        public string SourceSystem {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string Computer {get; set;}
        
        ///
        public datetime TimeOfCommand {get; set;}
        
        ///
        public string ContainerID {get; set;}
        
        ///
        public string Image {get; set;}
        
        ///
        public string ImageTag {get; set;}
        
        ///
        public string Repository {get; set;}
        
        ///
        public string Command {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
