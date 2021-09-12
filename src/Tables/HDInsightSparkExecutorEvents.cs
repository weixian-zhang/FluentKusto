
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class HDInsightSparkExecutorEvents : TableBase<HDInsightSparkExecutorEvents>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The application ID of the application producing the record.
            public string ApplicationId {get; set;}
            
            /// The ID of the Spark Executor.
            public string ExecutorId {get; set;}
            
            /// The number of cores the Spark Executor has.
            public int ExecutorCores {get; set;}
            
            /// The time (UTC) the Executor was added.
            public DateTime AddedTime {get; set;}
            
            /// The time (UTC) the Executor was removed.
            public DateTime RemovedTime {get; set;}
            
            /// The reason the Executor was removed.
            public string RemovedReason {get; set;}
            
            /// The tenant ID of the cluster running the Executor.
            public string ClusterTenantId {get; set;}
            
            /// The type of node  running the Executor.
            public string Role {get; set;}
            
            /// The FQDN of the host.
            public string Host {get; set;}
            
            /// The DNS name of the cluster running the Executor.
            public string ClusterDnsName {get; set;}
            
            /// The region of the cluster running the Executor.
            public string Region {get; set;}
            
            /// The IP Address of the node running the Executor.
            public string IpAddress {get; set;}
            
            /// The subscription ID of the cluster running the Executor.
            public string UserSubscriptionId {get; set;}
            
            /// The host the Executor ran on
            public string ExecutorHost {get; set;}
            
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
