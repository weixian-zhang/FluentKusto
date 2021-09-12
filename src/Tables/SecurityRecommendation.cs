
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class SecurityRecommendation : TableBase<SecurityRecommendation>
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
            public DateTime TimeGenerated {get; set;}
            
            /// 
            public DateTime DiscoveredTimeUTC {get; set;}
            
            /// 
            public DateTime ResolvedTimeUTC {get; set;}
            
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
            public DateTime FirstEvaluationDate {get; set;}
            
            /// 
            public DateTime StatusChangeDate {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
                }
}
