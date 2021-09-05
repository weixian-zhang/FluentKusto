

namespace FluentKusto
{
    public class HDInsightStormMetrics
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///Category of metric(e.g. StormNimbusMetrics, StormSupervisorMetrics, etc). 
        public string MetricNamespace {get; set;}
        
        ///Name of the metric for the record (e.g. num-submitTopology-calls-Count).
        public string MetricName {get; set;}
        
        ///Value of metric in the record.
        public real MetricValue {get; set;}
        
        ///CollectD datatype of the metric (e.g. gauge, counter, etc.). Determines how metric is portrayed over time. Please reference CollectD documentation for more information: https://collectd.org/wiki/index.php/Data_source .
        public string MetricDataType {get; set;}
        
        ///Name of cluster.
        public string ClusterName {get; set;}
        
        ///Name of host where log was emitted.
        public string HostName {get; set;}
        
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
