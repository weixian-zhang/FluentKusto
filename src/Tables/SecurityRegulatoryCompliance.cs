

namespace FluentKusto
{
    public class SecurityRegulatoryCompliance
    {

        ///
        public string TenantId {get; set;}
        
        ///The (UTC) date and time the assessment was generated
        public datetime TimeGenerated {get; set;}
        
        ///The subscription ID of the assessed resource
        public string RegulatoryComplianceSubscriptionId {get; set;}
        
        ///The ID of the assessed resource
        public string AssessedResourceId {get; set;}
        
        ///The ID of the assessed recommendation
        public string RecommendationId {get; set;}
        
        ///Recommendation display name
        public string RecommendationName {get; set;}
        
        ///The name of compliance standard
        public string ComplianceStandard {get; set;}
        
        ///The name of regulatory compliance control
        public string ComplianceControl {get; set;}
        
        ///The number of resources that passed this assessment
        public int SkippedResources {get; set;}
        
        ///The number of resources that passed this assessment
        public int PassedResources {get; set;}
        
        ///The number of resources that failed this assessment
        public int FailedResources {get; set;}
        
        ///The assessment state
        public string State {get; set;}
        
        ///Resource provider type of the assessed resource
        public string ResourceProviderType {get; set;}
        
        ///A link for more details on the assessment result
        public string RecommendationLink {get; set;}
        
        ///Indicates whether the data was exported as part of a snapshot when 'true', or streamed in real-time when 'false'.
        public bool IsSnapshot {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
