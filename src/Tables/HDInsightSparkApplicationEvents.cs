

namespace FluentKusto
{
    public class HDInsightSparkApplicationEvents
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The application id of the application producing the record.
        public string ApplicationId {get; set;}
        
        ///The Spark User associated with the record.
        public string SparkUser {get; set;}
        
        ///The application attempt id.
        public string AppAttemptId {get; set;}
        
        ///The application name.
        public string AppName {get; set;}
        
        ///The time (UTC) the application was submitted.
        public datetime SubmissionTime {get; set;}
        
        ///The time (UTC) the application submission completed.
        public datetime CompletionTime {get; set;}
        
        ///The tenant ID of the cluster running the application.
        public string ClusterTenantId {get; set;}
        
        ///The type of node running the application.
        public string Role {get; set;}
        
        ///The fqdn the node was run on.
        public string Host {get; set;}
        
        ///The DNS name of the cluster running the application.
        public string ClusterDnsName {get; set;}
        
        ///The region of the cluster running the application.
        public string Region {get; set;}
        
        ///The IP Address of the node running the application.
        public string IpAddress {get; set;}
        
        ///The subscription ID of the cluster running the application
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
