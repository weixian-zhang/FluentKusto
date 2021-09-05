

namespace FluentKusto
{
    public class HDInsightHiveQueryAppStats
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///Name of the query's entity.
        public string Entity {get; set;}
        
        ///The type of the query's entity.
        public string EntityType {get; set;}
        
        ///Name of the metric for the record (e.g. AppsCompleted, AppsKilled, AppsFailed , etc).
        public string MetricName {get; set;}
        
        ///Value of metric in the record.
        public real MetricValue {get; set;}
        
        ///Information about the record. For example a record may be tagged with 'yarn' if it is in the yarn context.
        public dynamic Tags {get; set;}
        
        ///Name of cluster.
        public string ClusterName {get; set;}
        
        ///Type of cluster (e.g. LLAP or Hadoop).
        public string ClusterType {get; set;}
        
        ///Name of host where log was emitted.
        public string HostName {get; set;}
        
        ///Time that query was submitted.
        public long QuerySubmissionTime {get; set;}
        
        ///Time that query was completed.
        public long QueryCompletionTime {get; set;}
        
        ///The domain associated with the query.
        public string Domain {get; set;}
        
        ///The client user that submitted the request.
        public string RequestUser {get; set;}
        
        ///The execution mode of the query.
        public string ExecutionMode {get; set;}
        
        ///The user of the Hive instance executing the query.
        public string User {get; set;}
        
        ///The queue the query was served from.
        public string Queue {get; set;}
        
        ///The tables read by the query.
        public string TablesRead {get; set;}
        
        ///The query client's IP address.
        public string ClientIpAddress {get; set;}
        
        ///True if the query is a Tez query.
        public bool IsTez {get; set;}
        
        ///True if the query is a MapReduce query.
        public bool IsMapReduce {get; set;}
        
        ///The name of the thread running the query.
        public string ThreadName {get; set;}
        
        ///The type of hive instance running the query.
        public string HiveInstanceType {get; set;}
        
        ///The session ID of the query.
        public string SessionId {get; set;}
        
        ///The operation associated with log record.
        public string OperationName {get; set;}
        
        ///The ID for correlated events. Can be used to identify correlated events between multiple tables.
        public string CorrelationId {get; set;}
        
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
