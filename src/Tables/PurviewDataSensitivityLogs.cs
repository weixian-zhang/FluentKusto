
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class PurviewDataSensitivityLogs : TableBase<PurviewDataSensitivityLogs>
    {

            /// 
            public string TenantId {get; set;}
            
            /// Time (UTC) when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// CorrelationId.
            public string CorrelationId {get; set;}
            
            /// Operation associated with the log record.
            public string OperationName {get; set;}
            
            /// Tenant ID associated with the Purview account.
            public string PurviewTenantId {get; set;}
            
            /// Subscription ID associated with the Purview account.
            public string PurviewSubscriptionId {get; set;}
            
            /// Name of the Purview account.
            public string PurviewAccountName {get; set;}
            
            /// Region of the Purview account.
            public string PurviewRegion {get; set;}
            
            /// Name of the data source scanned.
            public string SourceName {get; set;}
            
            /// Type of data source scanned.
            public string SourceType {get; set;}
            
            /// Resource Path of the data source. Ex: ARM path for Azure resources and ARN for AWS resources
            public string SourcePath {get; set;}
            
            /// Subscription ID associated with the data source.
            public string SourceSubscriptionId {get; set;}
            
            /// The location of the data source.
            public string SourceRegion {get; set;}
            
            /// Name of the data source collection name in Purview.
            public string SourceCollectionName {get; set;}
            
            /// Owner of the data source.
            public string SourceOwner {get; set;}
            
            /// Name of the asset scanned.
            public string AssetName {get; set;}
            
            /// Path of the asset scanned.
            public string AssetPath {get; set;}
            
            /// Type of asset that was scanned.
            public string AssetType {get; set;}
            
            /// Time at which the asset was created.
            public DateTime AssetCreationTime {get; set;}
            
            /// Time at which the asset was last modified.
            public DateTime AssetModifiedTime {get; set;}
            
            /// Owner of the asset.
            public string AssetOwner {get; set;}
            
            /// Time at which the asset was last scanned.
            public DateTime AssetLastScanTime {get; set;}
            
            /// File extension of the asset scanned.
            public string FileExtension {get; set;}
            
            /// File size of the asset scanned.
            public long FileSize {get; set;}
            
            /// The type of data sensitivity event.
            public string ActivityType {get; set;}
            
            /// The trigger for the data sensitivity event.
            public string ActivityTrigger {get; set;}
            
            /// List of classifications found.
            public dynamic Classification {get; set;}
            
            /// Total number of classifications found.
            public long ClassificationCount {get; set;}
            
            /// IDs for labels found.
            public string SensitivityLabelGuid {get; set;}
            
            /// Names for the labels found.
            public string SensitivityLabelName {get; set;}
            
            /// User who triggered the change.
            public string UserId {get; set;}
            
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
