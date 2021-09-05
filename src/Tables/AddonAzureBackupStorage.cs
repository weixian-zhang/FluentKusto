

namespace FluentKusto
{
    public class AddonAzureBackupStorage
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
        public string BackupItemUniqueId {get; set;}
        
        ///
        public string BackupManagementServerUniqueId {get; set;}
        
        ///
        public string BackupManagementType {get; set;}
        
        ///
        public string PreferredWorkloadOnVolume {get; set;}
        
        ///
        public string ProtectedContainerUniqueId {get; set;}
        
        ///
        public string SchemaVersion {get; set;}
        
        ///
        public string State {get; set;}
        
        ///
        public real StorageAllocatedInMBs {get; set;}
        
        ///
        public real StorageConsumedInMBs {get; set;}
        
        ///
        public string StorageName {get; set;}
        
        ///
        public real StorageTotalSizeInGBs {get; set;}
        
        ///
        public string StorageType {get; set;}
        
        ///
        public string StorageUniqueId {get; set;}
        
        ///
        public string VaultUniqueId {get; set;}
        
        ///
        public string VolumeFriendlyName {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
