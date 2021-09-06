

namespace FluentKusto
{
    public class ServiceFabricOperationalEvent
    {

        ///
        public string SourceSystem {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string Computer {get; set;}
        
        ///
        public string Level {get; set;}
        
        ///
        public string ProviderGuid {get; set;}
        
        ///
        public string EventSourceName {get; set;}
        
        ///
        public int EventId {get; set;}
        
        ///
        public int Pid {get; set;}
        
        ///
        public int Tid {get; set;}
        
        ///
        public string OpcodeName {get; set;}
        
        ///
        public string KeywordName {get; set;}
        
        ///
        public string TaskName {get; set;}
        
        ///
        public string ChannelName {get; set;}
        
        ///
        public string AzureDeploymentID {get; set;}
        
        ///
        public string Role {get; set;}
        
        ///
        public string EventMessage {get; set;}
        
        ///
        public string ApplicationName {get; set;}
        
        ///
        public string ApplicationTypeName {get; set;}
        
        ///
        public string ApplicationTypeVersion {get; set;}
        
        ///
        public string UpgradeDomains {get; set;}
        
        ///
        public string ServiceName {get; set;}
        
        ///
        public string ServiceTypeName {get; set;}
        
        ///
        public string PartitionId {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
            }
}
