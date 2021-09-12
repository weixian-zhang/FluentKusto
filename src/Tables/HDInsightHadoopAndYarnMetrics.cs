
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class HDInsightHadoopAndYarnMetrics : TableBase<HDInsightHadoopAndYarnMetrics>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// Category of metric (value of jmx query URIs e.g. Hadoop:service=ResourceManager,name=QueueMetrics, etc).
            public string MetricNamespace {get; set;}
            
            /// Name of the metric for the record (e.g. AppsCompleted, AppsKilled, AppsFailed , etc).
            public string MetricName {get; set;}
            
            /// Value of metric in the record.
            public float MetricValue {get; set;}
            
            /// Information about the record. For example a record may be tagged with 'yarn' if it is in the yarn context.
            public dynamic Tags {get; set;}
            
            /// Name of cluster.
            public string ClusterName {get; set;}
            
            /// Name of cluster.
            public string ClusterType {get; set;}
            
            /// Name of host where log was emitted.
            public string HostName {get; set;}
            
            /// The operation associated with log record.
            public string OperationName {get; set;}
            
            /// The ID for correlated events. Can be used to identify correlated events between multiple tables.
            public string CorrelationId {get; set;}
            
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
