
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AddonAzureBackupProtectedInstance : TableBase<AddonAzureBackupProtectedInstance>
    {

            /// 
            public string SourceSystem {get; set;}
            
            /// 
            public DateTime TimeGenerated {get; set;}
            
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
            public string ProtectedContainerUniqueId {get; set;}
            
            /// 
            public int ProtectedInstanceCount {get; set;}
            
            /// 
            public string SchemaVersion {get; set;}
            
            /// 
            public string State {get; set;}
            
            /// 
            public string VaultUniqueId {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
