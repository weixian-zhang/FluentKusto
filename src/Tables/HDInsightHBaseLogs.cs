
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class HDInsightHBaseLogs : TableBase<HDInsightHBaseLogs>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// log level of message (INFO, WARN, ERROR, etc.).
            public string LogLevel {get; set;}
            
            /// message from HBase log.
            public string Message {get; set;}
            
            /// Name of cluster.
            public string ClusterName {get; set;}
            
            /// Name of cluster.
            public string ClusterType {get; set;}
            
            /// Name of host where log was emitted.
            public string HostName {get; set;}
            
            /// The name of the log file that a record came from (e.g. RegionServer, HMaster).
            public string LogType {get; set;}
            
            /// The ID for correlated events. Can be used to identify correlated events between multiple tables.
            public string CorrelationId {get; set;}
            
            /// The operation associated with log record.
            public string OperationName {get; set;}
            
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
