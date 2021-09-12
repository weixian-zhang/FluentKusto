
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class SecureScoreControls : TableBase<SecureScoreControls>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The (UTC) date and time the control score was generated
            public DateTime TimeGenerated {get; set;}
            
            /// The ID of the subscription
            public string SecureScoresSubscriptionId {get; set;}
            
            /// The ID of the assessed resource
            public string AssessedResourceId {get; set;}
            
            /// The ID of the assessed control
            public string ControlId {get; set;}
            
            /// The display name of the control
            public string ControlName {get; set;}
            
            /// The current secure score per control
            public float CurrentScore {get; set;}
            
            /// The maximum control score
            public int MaxScore {get; set;}
            
            /// The percentage of the score (current score divided by max score)
            public float PercentageScore {get; set;}
            
            /// The weight for calculation of an aggregated score for several scopes
            public long Weight {get; set;}
            
            /// The number of healthy resources
            public int HealthyResources {get; set;}
            
            /// The number of unhealthy resources
            public int UnhealthyResources {get; set;}
            
            /// The number of not applicable resources
            public int NotApplicableResources {get; set;}
            
            /// The description of the control
            public string Description {get; set;}
            
            /// The recommendation resource IDs for the recommendations assessed in the control
            public dynamic RecommendationResourceIds {get; set;}
            
            /// The type of security control (for example, BuiltIn)
            public string ControlType {get; set;}
            
            /// Resource provider type of the assessed resource
            public string ResourceProviderType {get; set;}
            
            /// Indicates whether the data was exported as part of a snapshot when 'true', or streamed in real-time when 'false'.
            public bool IsSnapshot {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
