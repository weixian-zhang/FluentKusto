

namespace FluentKusto
{
    public class HDInsightSparkJobEvents
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The application ID of the application producing the record.
        public string ApplicationId {get; set;}
        
        ///The ID of the job.
        public string JobId {get; set;}
        
        ///The time (UTC) the job was submitted.
        public datetime SubmissionTime {get; set;}
        
        ///The time (UTC) the job was completed.
        public datetime CompletionTime {get; set;}
        
        ///The result of the job.
        public string JobResult {get; set;}
        
        ///The stages included in the job.
        public string StageIds {get; set;}
        
        ///The tenant  ID of the cluster running the job.
        public string ClusterTenantId {get; set;}
        
        ///The type of node  running the job.
        public string Role {get; set;}
        
        ///The FQDN of the host.
        public string Host {get; set;}
        
        ///The DNS name of the cluster running the job.
        public string ClusterDnsName {get; set;}
        
        ///The region of the cluster running the job.
        public string Region {get; set;}
        
        ///The IP Address of the node running the job.
        public string IpAddress {get; set;}
        
        ///The subscription ID of the cluster running the job.
        public string UserSubscriptionId {get; set;}
        
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
