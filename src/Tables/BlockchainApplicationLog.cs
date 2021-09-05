

namespace FluentKusto
{
    public class BlockchainApplicationLog
    {

        ///
        public string SourceSystem {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string ResourceId {get; set;}
        
        ///
        public string OperationName {get; set;}
        
        ///
        public string Category {get; set;}
        
        ///
        public string Level {get; set;}
        
        ///
        public string NodeLocation {get; set;}
        
        ///
        public string BlockchainNodeName {get; set;}
        
        ///
        public string BlockchainMessage {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
