
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class HDInsightSparkEnvironmentEvents : TableBase<HDInsightSparkEnvironmentEvents>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The application ID of the application producing the record.
            public string ApplicationId {get; set;}
            
            /// The spark deployment mode of the application.
            public string SparkDeployMode {get; set;}
            
            /// The master mode of the Spark Application
            public string SparkMaster {get; set;}
            
            /// The max number of attempts Yarn will make for the application.
            public int YarnMaxAttempts {get; set;}
            
            /// The number of Spark Executor instances.
            public int SparkExecutorInstances {get; set;}
            
            /// The memory usage of the Spark Executor
            public string SparkExecutorMemory {get; set;}
            
            /// The number of Executor cores.
            public int SparkExecutorCores {get; set;}
            
            /// The YARN tag of the application.
            public string YarnTags {get; set;}
            
            /// The type of YARN queue for the application.
            public string YarnQueue {get; set;}
            
            /// The tenant ID of the cluster running the application.
            public string ClusterTenantId {get; set;}
            
            /// The type of node running the application.
            public string Role {get; set;}
            
            /// The FQDN of the host.
            public string Host {get; set;}
            
            /// The DNS name of the cluster running the application.
            public string ClusterDnsName {get; set;}
            
            /// The region of the cluster running the application.
            public string Region {get; set;}
            
            /// The IP Address of the node running the application.
            public string IpAddress {get; set;}
            
            /// The subscription ID of the cluster running the application
            public string UserSubscriptionId {get; set;}
            
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
