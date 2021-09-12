
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class HDInsightSparkStageEvents : TableBase<HDInsightSparkStageEvents>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The application ID of the application producing the record.
            public string ApplicationId {get; set;}
            
            /// The ID of the stage.
            public string StageId {get; set;}
            
            /// The name of the stage.
            public string StageName {get; set;}
            
            /// The Id of the stage attempt.
            public string AttemptId {get; set;}
            
            /// The count of tasks associated with the stage.
            public int TaskCount {get; set;}
            
            /// The time (UTC) the stage was submitted.
            public DateTime SubmissionTime {get; set;}
            
            /// The time (UTC) the stage was completed.
            public DateTime CompletionTime {get; set;}
            
            /// The reason for failure if the stage failed.
            public string FailureReason {get; set;}
            
            /// The exception details for any stage failures.
            public string Details {get; set;}
            
            /// Json containing information about RDDs used in the stage.
            public string RDDInfo {get; set;}
            
            /// The tenant ID of the cluster running the stage.
            public string ClusterTenantId {get; set;}
            
            /// The type of node  running the stage.
            public string Role {get; set;}
            
            /// The FQDN of the host.
            public string Host {get; set;}
            
            /// The DNS name of the cluster running the stage.
            public string ClusterDnsName {get; set;}
            
            /// The region of the cluster running the stage.
            public string Region {get; set;}
            
            /// The IP Address of the node running the stage.
            public string IpAddress {get; set;}
            
            /// The subscription ID of the cluster running the stage.
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
