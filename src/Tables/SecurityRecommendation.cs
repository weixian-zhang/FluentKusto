

namespace FluentKusto
{
    public class SecurityRecommendation
    {

        ///
        public string RecommendationId {get; set;}
        
        ///
        public string RecommendationName {get; set;}
        
        ///
        public string RecommendationDisplayName {get; set;}
        
        ///
        public string ProviderName {get; set;}
        
        ///
        public string Description {get; set;}
        
        ///
        public string RecommendationState {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public datetime DiscoveredTimeUTC {get; set;}
        
        ///
        public datetime ResolvedTimeUTC {get; set;}
        
        ///
        public string PolicyDefinitionId {get; set;}
        
        ///
        public string RecommendationSeverity {get; set;}
        
        ///
        public string AssessedResourceId {get; set;}
        
        ///
        public string DeviceId {get; set;}
        
        ///
        public string ResourceRegion {get; set;}
        
        ///
        public bool IsSnapshot {get; set;}
        
        ///
        public dynamic RecommendationAdditionalData {get; set;}
        
        ///
        public datetime FirstEvaluationDate {get; set;}
        
        ///
        public datetime StatusChangeDate {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
            }
}
