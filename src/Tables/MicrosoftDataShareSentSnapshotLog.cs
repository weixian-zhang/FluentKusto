
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class MicrosoftDataShareSentSnapshotLog : TableBase<MicrosoftDataShareSentSnapshotLog>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The time (UTC) when the event is generated
            public DateTime TimeGenerated {get; set;}
            
            /// The name of the operation represented by this event
            public string OperationName {get; set;}
            
            /// The name of the log that belongs to
            public string Category {get; set;}
            
            /// CorrelationId of the event, this can be use as a reference to join with other tables
            public string CorrelationId {get; set;}
            
            /// This shows the event details. Can be empty if synchronization is not finished
            public string DetailMessage {get; set;}
            
            /// Datashare synchronization start time
            public string StartTime {get; set;}
            
            /// Datashare synchronization end time, can be empty if job not finished
            public string EndTime {get; set;}
            
            /// Synchronization status, can be inprogress/succeed/failed
            public string Status {get; set;}
            
            /// Indicating whether the trigger is on-demand trigger or manual trigger
            public string TriggerType {get; set;}
            
            /// Indicating the dataSetMapping type, this can be Blob/container/bolbfolder,etc
            public string DataSetMappingType {get; set;}
            
            /// Indicating the dataSet type, this can be Blob/container/bolbfolder,etc
            public string DataSetType {get; set;}
            
            /// Name of provider source dataset
            public string DataSetName {get; set;}
            
            /// Number of files written into sink 
            public string FilesWritten {get; set;}
            
            /// Number of files read from source
            public string FilesRead {get; set;}
            
            /// Size of files into sink in bytes
            public string SizeWritten {get; set;}
            
            /// Size of files read from source
            public string SizeRead {get; set;}
            
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
