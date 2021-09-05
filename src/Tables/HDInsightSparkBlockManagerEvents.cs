

namespace FluentKusto
{
    public class HDInsightSparkBlockManagerEvents
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The application ID of the application producing the record.
        public string ApplicationId {get; set;}
        
        ///The ID of the executor running the application.
        public string ExecutorId {get; set;}
        
        ///The FQDN of the host.
        public string Host {get; set;}
        
        ///The time (UTC) the event was added.
        public datetime AddedTime {get; set;}
        
        ///The time (UTC) the application was removed.
        public datetime RemovedTime {get; set;}
        
        ///The max memory usage from the event.
        public long MaxMemory {get; set;}
        
        ///The max on heap memory usage from the event.
        public long MaxOnHeapMemory {get; set;}
        
        ///The max off heap memory usage from the event.
        public long MaxOffHeapMemory {get; set;}
        
        ///The tenant ID of the cluster the Block Manager is running on.
        public string ClusterTenantId {get; set;}
        
        ///The type of node the Block Manager is running on.
        public string Role {get; set;}
        
        ///The DNS name of the cluster the Block Manager is running on.
        public string ClusterDnsName {get; set;}
        
        ///The region of the cluster the Block Manager is running on.
        public string Region {get; set;}
        
        ///The IP Address of the node the Block Manager is running on.
        public string IpAddress {get; set;}
        
        ///The subscription ID of the cluster the Block Manager is running on.
        public string UserSubscriptionId {get; set;}
        
        ///The block host.
        public string BlockHost {get; set;}
        
        ///The host where the Block Manager is running.
        public string BlockManagerHost {get; set;}
        
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
