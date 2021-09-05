

namespace FluentKusto
{
    public class HDInsightHiveAndLLAPLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The ID for correlated events. Can be used to identify correlated events between multiple tables.
        public string CorrelationId {get; set;}
        
        ///log level of message (INFO, WARN, ERROR, etc.).
        public string LogLevel {get; set;}
        
        ///message from Hive or LLAP log.
        public string Message {get; set;}
        
        ///Name of cluster.
        public string ClusterName {get; set;}
        
        ///Type of the cluster.
        public string ClusterType {get; set;}
        
        ///Name of host where log was emitted.
        public string HostName {get; set;}
        
        ///The name of the log file that a record came from (e.g. HiveServerLog, WebHCatLog, etc.).
        public string LogType {get; set;}
        
        ///The operation associated with log record.
        public string OperationName {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
