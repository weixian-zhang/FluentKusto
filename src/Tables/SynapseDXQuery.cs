

namespace FluentKusto
{
    public class SynapseDXQuery
    {

        ///
        public string TenantId {get; set;}
        
        ///The time (UTC) this event was generated
        public datetime TimeGenerated {get; set;}
        
        ///The log category for these events will be 'Query'
        public string Category {get; set;}
        
        ///The client request ID
        public string CorrelationId {get; set;}
        
        ///The root activity ID
        public string RootActivityId {get; set;}
        
        ///The time (UTC) this command started
        public datetime StartedOn {get; set;}
        
        ///The time (UTC) this command ended
        public datetime LastUpdatedOn {get; set;}
        
        ///The name of the database the command ran on
        public string DatabaseName {get; set;}
        
        ///The state the command ended with like 'Completed'
        public string State {get; set;}
        
        ///The reason for the failure
        public string FailureReason {get; set;}
        
        ///Total CPU runtime across cluster nodes
        public string TotalCPU {get; set;}
        
        ///The name of the application that invoked the query
        public string ApplicationName {get; set;}
        
        ///Memory peak
        public long MemoryPeak {get; set;}
        
        ///Query duration as a string like '00:00:00.0156250'
        public string Duration {get; set;}
        
        ///User that invoked the query
        public string User {get; set;}
        
        ///The principal that invoked the query like 'aaduser=USER_ID;TENANT'
        public string Principal {get; set;}
        
        ///Minimum data scan time
        public datetime ExtentsMinDataScannedTime {get; set;}
        
        ///Maximum data scan time
        public datetime ExtentsMaxDataScannedTime {get; set;}
        
        ///Total extents count
        public long TotalExtentsCount {get; set;}
        
        ///Scanned extents count
        public long ScannedExtentsCount {get; set;}
        
        ///Total rows count
        public long TotalRowsCount {get; set;}
        
        ///Scanned rows count
        public long ScannedRowsCount {get; set;}
        
        ///Memory cache hits
        public long CacheMemoryHits {get; set;}
        
        ///Memory cache misses
        public long CacheMemoryMisses {get; set;}
        
        ///Disk cache hits
        public long CacheDiskHits {get; set;}
        
        ///Disk cache misses
        public long CacheDiskMisses {get; set;}
        
        ///Shards hot cache hits
        public long CacheShardsHotHits {get; set;}
        
        ///Shards hot cache misses
        public long CacheShardsHotMisses {get; set;}
        
        ///Shards cold cache hits
        public long CacheShardsColdHits {get; set;}
        
        ///Shards cold cache misses
        public long CacheShardsColdMisses {get; set;}
        
        ///Shards cache bypass bytes
        public long CacheShardsBypassBytes {get; set;}
        
        ///Table count
        public int TableCount {get; set;}
        
        ///Tables statistics
        public dynamic TablesStatistics {get; set;}
        
        ///Workload are a means of resource governance for incoming requests to the cluster
        public string WorkloadGroup {get; set;}
        
        ///Text of the invoked query
        public string Text {get; set;}
        
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
