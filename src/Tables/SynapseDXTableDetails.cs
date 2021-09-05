

namespace FluentKusto
{
    public class SynapseDXTableDetails
    {

        ///
        public string TenantId {get; set;}
        
        ///The time (UTC) this event was generated
        public datetime TimeGenerated {get; set;}
        
        ///The client request ID
        public string CorrelationId {get; set;}
        
        ///Name of the database
        public string DatabaseName {get; set;}
        
        ///Name of the table
        public string TableName {get; set;}
        
        ///Total size of extents (compressed size + index size) in the table (in bytes)
        public real TotalExtentSize {get; set;}
        
        ///The total original data size in the table (in bytes)
        public real TotalOriginalSize {get; set;}
        
        ///Total size of extents (compressed size + index size) in the table, stored in the hot cache (in bytes)
        public real HotExtentSize {get; set;}
        
        ///Retention policy origin entity (Table/Database/Cluster)
        public string RetentionPolicyOrigin {get; set;}
        
        ///Table's effective entity retention policy, serialized as JSON
        public dynamic RetentionPolicy {get; set;}
        
        ///Caching policy origin entity (Table/Database/Cluster)
        public string CachingPolicyOrigin {get; set;}
        
        ///Table's effective entity caching policy, serialized as JSON
        public dynamic CachingPolicy {get; set;}
        
        ///Maximum creation time of an extent in the table (or null, if there are no extents)
        public datetime MaxExtentsCreationTime {get; set;}
        
        ///Minimum creation time of an extent in the table (or null, if there are no extents)
        public datetime MinExtentsCreationTime {get; set;}
        
        ///Total number of extents in the table
        public long TotalExtentCount {get; set;}
        
        ///Total number of rows in the table
        public long TotalRowCount {get; set;}
        
        ///Total number of extents in the table, stored in the hot cache
        public long HotExtentCount {get; set;}
        
        ///Total original size of data in the table, stored in the hot cache (in bytes)
        public long HotOriginalSize {get; set;}
        
        ///Total number of rows in the table, stored in the hot cache
        public long HotRowCount {get; set;}
        
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
