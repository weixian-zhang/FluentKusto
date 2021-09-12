
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class HDInsightHiveTezAppStats : TableBase<HDInsightHiveTezAppStats>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
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
            
            /// The name of the application that the metrics describe.
            public string ApplicationName {get; set;}
            
            /// The ID of the Application that the metrics describe.
            public string ApplicationId {get; set;}
            
            /// The name of the user of the application.
            public string User {get; set;}
            
            /// The queue of the application.
            public string Queue {get; set;}
            
            /// The state of the application.
            public string State {get; set;}
            
            /// The final status of the application if it has reached a terminal state.
            public string FinalStatus {get; set;}
            
            /// ?.
            public string TrackingUI {get; set;}
            
            /// The final status of the application if it has reached a terminal state.
            public long ClusterId {get; set;}
            
            /// The type of application.
            public string ApplicationType {get; set;}
            
            /// The time the application started.
            public long StartedTime {get; set;}
            
            /// The time the application finished.
            public long FinishedTime {get; set;}
            
            /// The time elapsed while the application was running.
            public long ElapsedTime {get; set;}
            
            /// The Application Master? container logs.
            public string AMContainerLogs {get; set;}
            
            /// The log aggregation status.
            public string LogAggregationStatus {get; set;}
            
            /// True if application is unmanaged, false if otherwise.
            public bool UnmanagedApplication {get; set;}
            
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
