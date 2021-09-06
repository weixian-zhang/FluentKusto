

namespace FluentKusto
{
    public class ProtectionStatus
    {

        ///
        public string TenantId {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string SourceComputerId {get; set;}
        
        ///
        public string DeviceName {get; set;}
        
        ///
        public string DetectionId {get; set;}
        
        ///
        public string OSName {get; set;}
        
        ///
        public string Threat {get; set;}
        
        ///
        public int ThreatStatusRank {get; set;}
        
        ///
        public string ThreatStatus {get; set;}
        
        ///
        public string ThreatStatusDetails {get; set;}
        
        ///
        public int ProtectionStatusRank {get; set;}
        
        ///
        public string ProtectionStatus {get; set;}
        
        ///
        public string ProtectionStatusDetails {get; set;}
        
        ///
        public string SignatureVersion {get; set;}
        
        ///
        public string TypeofProtection {get; set;}
        
        ///
        public datetime ScanDate {get; set;}
        
        ///
        public string AMProductVersion {get; set;}
        
        ///
        public string ManagementGroupName {get; set;}
        
        ///
        public string Computer {get; set;}
        
        ///
        public string ComputerIP_Hidden {get; set;}
        
        ///
        public string ResourceId {get; set;}
        
        ///
        public string ComputerEnvironment {get; set;}
        
        ///
        public string Resource {get; set;}
        
        ///
        public string SubscriptionId {get; set;}
        
        ///
        public string ResourceGroup {get; set;}
        
        ///
        public string ResourceProvider {get; set;}
        
        ///
        public string ResourceType {get; set;}
        
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
