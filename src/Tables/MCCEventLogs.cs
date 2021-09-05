

namespace FluentKusto
{
    public class MCCEventLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///Timestamp (UTC) when the log was created.
        public datetime TimeGenerated {get; set;}
        
        ///Ratio of Data volume (MB) per second that came directly from Microsoft Connected Cache(hitMbps) to The total data volume (MB) per second delivered(egressMbps).
        public real HitRatioMbps {get; set;}
        
        ///Unique CacheNode identifier.
        public string CacheNodeId {get; set;}
        
        ///Data volume (MB) per second that Microsoft Connected Cache had to download from CDN to see the cache.
        public real MissMbps {get; set;}
        
        ///Data volume (MB) per second that came directly from Microsoft Connected Cache.
        public real HitMbps {get; set;}
        
        ///The number of times data is found in the cache.
        public int Hits {get; set;}
        
        ///The number of times data is not found in the cache and had to download from CDN.
        public int Misses {get; set;}
        
        ///The total data volume (MB) per second delivered including: data volume (MB) that came directly from cache (hitMbps) and data volume (MB) that Microsoft Connected Cache had to download from CDN to see the cache (missMbps).
        public real EgressMbps {get; set;}
        
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
