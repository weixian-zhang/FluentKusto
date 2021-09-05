

namespace FluentKusto
{
    public class UpdateRunProgress
    {

        ///
        public string SourceSystem {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string ManagementGroupName {get; set;}
        
        ///
        public string SourceComputerId {get; set;}
        
        ///
        public string KBID {get; set;}
        
        ///
        public string UpdateId {get; set;}
        
        ///
        public bool SucceededOnRetry {get; set;}
        
        ///
        public string ErrorResult {get; set;}
        
        ///
        public string UpdateRunName {get; set;}
        
        ///
        public string InstallationStatus {get; set;}
        
        ///
        public string Computer {get; set;}
        
        ///
        public string Title {get; set;}
        
        ///
        public string Product {get; set;}
        
        ///
        public string OSType {get; set;}
        
        ///
        public datetime StartTime {get; set;}
        
        ///
        public datetime EndTime {get; set;}
        
        ///
        public string CorrelationId {get; set;}
        
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
        public string VMUUID {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
