

namespace FluentKusto
{
    public class SecureScores
    {

        ///
        public string TenantId {get; set;}
        
        ///The (UTC) date and time the control score was generated
        public datetime TimeGenerated {get; set;}
        
        ///The ID of the subscription
        public string SecureScoresSubscriptionId {get; set;}
        
        ///The ID of the assessed resource
        public string AssessedResourceId {get; set;}
        
        ///The initiatives name
        public string DisplayName {get; set;}
        
        ///The current secure score per control
        public real CurrentScore {get; set;}
        
        ///The maximum control score
        public int MaxScore {get; set;}
        
        ///The percentage of the score (current score divided by max score)
        public real PercentageScore {get; set;}
        
        ///The weight for calculation of an aggregated score for several scopes
        public long Weight {get; set;}
        
        ///Resource provider type of the assessed resource
        public string ResourceProviderType {get; set;}
        
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
