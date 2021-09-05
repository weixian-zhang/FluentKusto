

namespace FluentKusto
{
    public class SynapseDXIngestionBatching
    {

        ///
        public string TenantId {get; set;}
        
        ///The time (UTC) this event was generated
        public datetime TimeGenerated {get; set;}
        
        ///The name of the database holding the target table
        public string Database {get; set;}
        
        ///The name of the target table the data is ingested into
        public string Table {get; set;}
        
        ///Batching type: Whether the batch reached the limit of batching time, data size, or number of files set by the the batching policy
        public string BatchingType {get; set;}
        
        ///When the first blobs in this batch were created (UTC time)
        public datetime SourceCreationTime {get; set;}
        
        ///Total batching time of this batch (seconds)
        public real BatchTimeSeconds {get; set;}
        
        ///Total uncompressed size of data in this batch (bytes)
        public long BatchSizeBytes {get; set;}
        
        ///Number of data sources in this batch
        public int DataSourcesInBatch {get; set;}
        
        ///The operation's activity ID
        public string RootActivityId {get; set;}
        
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
