
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class SynapseSqlPoolSqlRequests : TableBase<SynapseSqlPoolSqlRequests>
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
            
            /// The request Id of the SQL requests.
            public string RequestId {get; set;}
            
            /// The PdwNodeId of the SQL requests.
            public int PdwNodeId {get; set;}
            
            /// The distribution id of the SQL requests.
            public int DistributionId {get; set;}
            
            /// The Status of the SQL requests.
            public string Status {get; set;}
            
            /// The error id of the SQL requests.
            public string ErrorId {get; set;}
            
            /// The startTime (UTC) of the SQL requests.
            public DateTime StartTime {get; set;}
            
            /// The end time (UTC) for the SQL requests.
            public DateTime EndTime {get; set;}
            
            /// The row count of the SQL requests.
            public int RowCount {get; set;}
            
            /// The sp id of the SQL requests.
            public int SpId {get; set;}
            
            /// The command of the SQL requests.
            public string Command {get; set;}
            
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
