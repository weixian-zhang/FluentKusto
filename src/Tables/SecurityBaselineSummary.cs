

namespace FluentKusto
{
    public class SecurityBaselineSummary
    {

        ///
        public string SourceSystem {get; set;}
        
        ///
        public string ManagementGroupName {get; set;}
        
        ///
        public string SourceComputerId {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
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
        public int TotalAssessedRules {get; set;}
        
        ///
        public int PercentageOfPassedRules {get; set;}
        
        ///
        public int CriticalFailedRules {get; set;}
        
        ///
        public int WarningFailedRules {get; set;}
        
        ///
        public int InformationalFailedRules {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
