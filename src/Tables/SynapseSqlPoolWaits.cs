
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class SynapseSqlPoolWaits : TableBase<SynapseSqlPoolWaits>
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
            
            /// The State of the waits.
            public string State {get; set;}
            
            /// The priority of the waits.
            public int Priority {get; set;}
            
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
