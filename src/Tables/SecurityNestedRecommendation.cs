

namespace FluentKusto
{
    public class SecurityNestedRecommendation
    {

        ///
        public string TenantId {get; set;}
        
        ///The date and time the sub-assessment was generated
        public datetime TimeGenerated {get; set;}
        
        ///Recommendation's subscription Id
        public string RecommendationSubscriptionId {get; set;}
        
        ///Resource group name
        public string ResourceGroup {get; set;}
        
        ///Id of the assessed resource
        public string AssessedResourceId {get; set;}
        
        ///Id of the parent recommendation
        public string ParentRecommendationId {get; set;}
        
        ///Id of the assessed recommendation
        public string Id {get; set;}
        
        ///Display name of the sub-assessment
        public string RecommendationName {get; set;}
        
        ///Id of the nested-recommendation
        public string NestedRecommendationId {get; set;}
        
        ///Description of the assessment status
        public string Description {get; set;}
        
        ///The sub-assessment severity level
        public string RecommendationSeverity {get; set;}
        
        ///The sub-assessment state
        public string RecommendationState {get; set;}
        
        ///Information on how to remediate this sub-assessment
        public string RemediationDescription {get; set;}
        
        ///Additional details of the sub-assessment
        public dynamic AdditionalData {get; set;}
        
        ///Resource provider type of the assessed resource
        public string ResourceProviderType {get; set;}
        
        ///Category of the sub-assessment
        public string Category {get; set;}
        
        ///Details of the resource that was assessed
        public dynamic ResourceDetails {get; set;}
        
        ///Description of the impact of this sub-assessment
        public string Impact {get; set;}
        
        ///Cause of the assessment status
        public string Cause {get; set;}
        
        ///Vulnerability Id
        public string VulnerabilityId {get; set;}
        
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
