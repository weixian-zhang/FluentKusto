
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class HDInsightSparkSQLExecutionEvents : TableBase<HDInsightSparkSQLExecutionEvents>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The application ID of the application producing the record.
            public string ApplicationId {get; set;}
            
            /// The ID of the Spark SQL execution.
            public string ExecutionId {get; set;}
            
            /// The time (UTC) the Spark SQL execution started.
            public DateTime StartTime {get; set;}
            
            /// The time (UTC) the Spark SQL execution ended.
            public DateTime EndTime {get; set;}
            
            /// The description of the Physical/Logical plan of the Spark SQL execution.
            public string PhysicalPlanDescription {get; set;}
            
            /// Json object containing information on the Spark SQL execution.
            public string SparkPlanInfo {get; set;}
            
            /// The tenant ID of the cluster running the Spark SQL execution.
            public string ClusterTenantId {get; set;}
            
            /// The type of node  running the Spark SQL execution.
            public string Role {get; set;}
            
            /// The FQDN of the host.
            public string Host {get; set;}
            
            /// The DNS name of the cluster running the Spark SQL execution.
            public string ClusterDnsName {get; set;}
            
            /// The region of the cluster running the Spark SQL execution.
            public string Region {get; set;}
            
            /// The IP Address of the node running the Spark SQL execution.
            public string IpAddress {get; set;}
            
            /// The subscription ID of the cluster running the Spark SQL execution.
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
