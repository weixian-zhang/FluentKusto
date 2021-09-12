
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class SecurityBaseline : TableBase<SecurityBaseline>
    {

            /// 
            public string SourceSystem {get; set;}
            
            /// 
            public string ManagementGroupName {get; set;}
            
            /// 
            public string SourceComputerId {get; set;}
            
            /// 
            public DateTime TimeGenerated {get; set;}
            
            /// 
            public string SubscriptionId {get; set;}
            
            /// 
            public string ResourceGroup {get; set;}
            
            /// 
            public string ResourceProvider {get; set;}
            
            /// 
            public string Resource {get; set;}
            
            /// 
            public string ResourceId {get; set;}
            
            /// 
            public string ResourceType {get; set;}
            
            /// 
            public string ComputerEnvironment {get; set;}
            
            /// 
            public string Computer {get; set;}
            
            /// 
            public string BaselineType {get; set;}
            
            /// 
            public string OSName {get; set;}
            
            /// 
            public string AssessmentId {get; set;}
            
            /// 
            public string CceId {get; set;}
            
            /// 
            public string AzId {get; set;}
            
            /// 
            public string RuleSeverity {get; set;}
            
            /// 
            public string BaselineRuleType {get; set;}
            
            /// 
            public string Description {get; set;}
            
            /// 
            public string RuleSetting {get; set;}
            
            /// 
            public string ExpectedResult {get; set;}
            
            /// 
            public string ActualResult {get; set;}
            
            /// 
            public string AnalyzeResult {get; set;}
            
            /// 
            public string SitePath {get; set;}
            
            /// 
            public string AnalyzeOperation {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
