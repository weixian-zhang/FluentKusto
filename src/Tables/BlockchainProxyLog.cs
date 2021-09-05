

namespace FluentKusto
{
    public class BlockchainProxyLog
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
        public string LogLevel {get; set;}
        
        ///
        public string NodeLocation {get; set;}
        
        ///
        public string BlockchainNodeName {get; set;}
        
        ///
        public string EthMethod {get; set;}
        
        ///
        public string Agent {get; set;}
        
        ///
        public string Code {get; set;}
        
        ///
        public string NodeHost {get; set;}
        
        ///
        public string RequestMethodName {get; set;}
        
        ///
        public string BlockchainMemberName {get; set;}
        
        ///
        public string Consortium {get; set;}
        
        ///
        public string Remote {get; set;}
        
        ///
        public int RequestSize {get; set;}
        
        ///
        public string Tenant {get; set;}
        
        ///
        public string PublicUser {get; set;}
        
        ///
        public real RequestTime {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
