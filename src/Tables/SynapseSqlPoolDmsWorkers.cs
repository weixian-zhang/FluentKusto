
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class SynapseSqlPoolDmsWorkers : TableBase<SynapseSqlPoolDmsWorkers>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The logical server name of the SQL DW.
            public string LogicalServerName {get; set;}
            
            /// The azure resourceGroup of the SQL DW.
            public string ResourceGroup {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The operation associated with log record.
            public string OperationName {get; set;}
            
            /// The category of the log.
            public string Category {get; set;}
            
            /// The requestId of the DMS workers.
            public string RequestId {get; set;}
            
            /// The step index of the DMS workers.
            public int StepIndex {get; set;}
            
            /// The DMS step index of the DMS workers.
            public int DmsStepIndex {get; set;}
            
            /// The pdw node id of the DMS workers.
            public int PdwNodeId {get; set;}
            
            /// The distribution id of the DMS workers.
            public int DistributionId {get; set;}
            
            /// The type of the DMS workers.
            public string Type {get; set;}
            
            /// The status of the DMS workers.
            public string Status {get; set;}
            
            /// The bytes processed of the DMS workers.
            public int BytesProcessed {get; set;}
            
            /// The rows processed of the DMS workers.
            public int RowsProcessed {get; set;}
            
            /// The startTime (UTC) of the DMS workers.
            public DateTime StartTime {get; set;}
            
            /// The end time (UTC) for the DMS workers.
            public DateTime EndTime {get; set;}
            
            /// The cpu time for the DMS workers.
            public int CpuTime {get; set;}
            
            /// The SQL  Sp Id for the DMS workers.
            public int SqlSpId {get; set;}
            
            /// The DMS cpu Id for the DMS workers.
            public int DmsCpuId {get; set;}
            
            /// The errorId of the DMS workers.
            public string ErrorId {get; set;}
            
            /// The row count of the DMS workers.
            public string SourceInfo {get; set;}
            
            /// The row count of the DMS workers.
            public string DestinationInfo {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
