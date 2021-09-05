

namespace FluentKusto
{
    public class AddonAzureBackupJobs
    {

        ///
        public string SourceSystem {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string ResourceId {get; set;}
        
        ///
        public string OperationName {get; set;}
        
        ///
        public string Category {get; set;}
        
        ///
        public string AdHocOrScheduledJob {get; set;}
        
        ///
        public string BackupItemUniqueId {get; set;}
        
        ///
        public string BackupManagementServerUniqueId {get; set;}
        
        ///
        public string BackupManagementType {get; set;}
        
        ///
        public real DataTransferredInMB {get; set;}
        
        ///
        public real JobDurationInSecs {get; set;}
        
        ///
        public string JobFailureCode {get; set;}
        
        ///
        public string JobOperation {get; set;}
        
        ///
        public string JobOperationSubType {get; set;}
        
        ///
        public datetime JobStartDateTime {get; set;}
        
        ///
        public string JobStatus {get; set;}
        
        ///
        public string JobUniqueId {get; set;}
        
        ///
        public string ProtectedContainerUniqueId {get; set;}
        
        ///
        public string RecoveryJobDestination {get; set;}
        
        ///
        public datetime RecoveryJobRPDateTime {get; set;}
        
        ///
        public string RecoveryJobRPLocation {get; set;}
        
        ///
        public string RecoveryLocationType {get; set;}
        
        ///
        public string SchemaVersion {get; set;}
        
        ///
        public string State {get; set;}
        
        ///
        public string VaultUniqueId {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
