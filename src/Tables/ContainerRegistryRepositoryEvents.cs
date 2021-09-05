

namespace FluentKusto
{
    public class ContainerRegistryRepositoryEvents
    {

        ///
        public string TenantId {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string OperationName {get; set;}
        
        ///
        public string LoginServer {get; set;}
        
        ///
        public string Identity {get; set;}
        
        ///
        public string Repository {get; set;}
        
        ///
        public string Tag {get; set;}
        
        ///
        public string Digest {get; set;}
        
        ///
        public string MediaType {get; set;}
        
        ///
        public int Size {get; set;}
        
        ///
        public string ArtifactType {get; set;}
        
        ///
        public string CorrelationId {get; set;}
        
        ///
        public string Region {get; set;}
        
        ///
        public string ResultType {get; set;}
        
        ///
        public string Category {get; set;}
        
        ///
        public string ResultDescription {get; set;}
        
        ///
        public string CallerIpAddress {get; set;}
        
        ///
        public string DurationMs {get; set;}
        
        ///
        public string UserTenantId {get; set;}
        
        ///
        public string UserAgent {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
