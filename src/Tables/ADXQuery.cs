

namespace FluentKusto
{
    public class ADXQuery
    {

        ///
        public string TenantId {get; set;}
        
        ///The time (UTC) at which this event was generated
        public datetime TimeGenerated {get; set;}
        
        ///The name of this operation
        public string OperationName {get; set;}
        
        ///The category of this log for this events it will be Query
        public string Category {get; set;}
        
        ///The client request id
        public string CorrelationId {get; set;}
        
        ///The root activity id
        public string RootActivityId {get; set;}
        
        ///Time (UTC) at which this command started
        public datetime StartedOn {get; set;}
        
        ///Time (UTC) at which this command ended
        public datetime LastUpdatedOn {get; set;}
        
        ///The name of the database the command ran on
        public string DatabaseName {get; set;}
        
        ///The State the command ended with
        public string State {get; set;}
        
        ///The failure reason
        public string FailureReason {get; set;}
        
        ///Total CPU duration
        public string TotalCPU {get; set;}
        
        ///application name invoked the query
        public string ApplicationName {get; set;}
        
        ///Memory peak
        public long MemoryPeak {get; set;}
        
        ///Command duration
        public string Duration {get; set;}
        
        ///The user that invoked the query
        public string User {get; set;}
        
        ///The principal that invoked the query
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
        
        ///The workload group the query was classified to
        public string WorkloadGroup {get; set;}
        
        ///The text of the invoked query
        public string Text {get; set;}
        
        ///The entity that caused the query to fail. For example, if the query result is too large, the ComponentFault will be 'Client'. If an internal error occured, it will be 'Server'
        public string ComponentFault {get; set;}
        
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
