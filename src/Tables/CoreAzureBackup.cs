

namespace FluentKusto
{
    public class CoreAzureBackup
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
        public string AgentVersion {get; set;}
        
        ///
        public string AzureBackupAgentVersion {get; set;}
        
        ///
        public string AzureDataCenter {get; set;}
        
        ///
        public string BackupItemAppVersion {get; set;}
        
        ///
        public string BackupItemFriendlyName {get; set;}
        
        ///
        public string BackupItemName {get; set;}
        
        ///
        public string BackupItemProtectionState {get; set;}
        
        ///
        public real BackupItemFrontEndSize {get; set;}
        
        ///
        public string BackupItemType {get; set;}
        
        ///
        public string BackupItemUniqueId {get; set;}
        
        ///
        public string BackupManagementServerType {get; set;}
        
        ///
        public string BackupManagementServerUniqueId {get; set;}
        
        ///
        public string BackupManagementType {get; set;}
        
        ///
        public string BackupManagementServerName {get; set;}
        
        ///
        public string BackupManagementServerOSVersion {get; set;}
        
        ///
        public string BackupManagementServerVersion {get; set;}
        
        ///
        public string LatestRecoveryPointLocation {get; set;}
        
        ///
        public datetime LatestRecoveryPointTime {get; set;}
        
        ///
        public string OldestRecoveryPointLocation {get; set;}
        
        ///
        public datetime OldestRecoveryPointTime {get; set;}
        
        ///
        public string PolicyUniqueId {get; set;}
        
        ///
        public string ProtectedContainerFriendlyName {get; set;}
        
        ///
        public string ProtectedContainerLocation {get; set;}
        
        ///
        public string ProtectedContainerName {get; set;}
        
        ///
        public string ProtectedContainerOSType {get; set;}
        
        ///
        public string ProtectedContainerOSVersion {get; set;}
        
        ///
        public string ProtectedContainerProtectionState {get; set;}
        
        ///
        public string ProtectedContainerType {get; set;}
        
        ///
        public string ProtectedContainerUniqueId {get; set;}
        
        ///
        public string ProtectedContainerWorkloadType {get; set;}
        
        ///
        public string ProtectionGroupName {get; set;}
        
        ///
        public string ResourceGroupName {get; set;}
        
        ///
        public string SchemaVersion {get; set;}
        
        ///
        public string SecondaryBackupProtectionState {get; set;}
        
        ///
        public string State {get; set;}
        
        ///
        public string StorageReplicationType {get; set;}
        
        ///
        public string SubscriptionId {get; set;}
        
        ///
        public string VaultName {get; set;}
        
        ///
        public string VaultTags {get; set;}
        
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
