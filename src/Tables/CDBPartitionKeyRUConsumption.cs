

namespace FluentKusto
{
    public class CDBPartitionKeyRUConsumption
    {

        ///
        public string TenantId {get; set;}
        
        ///Timestamp (in UTC) when the�request against the physical partition was issued.
        public datetime TimeGenerated {get; set;}
        
        ///The name of the Cosmos DB account�containing�the�physical partition.
        public string AccountName {get; set;}
        
        ///The logical partition key for which RU (Request Unit) consumption statistics were�retrieved.
        public string PartitionKey {get; set;}
        
        ///The physical partition containing the logical partition key against which the RU (Request Unit) consuming operation was issued.
        public string PartitionKeyRangeId {get; set;}
        
        ///The data plane operation that consumed RUs (Request Units) for this logical partition key.
        public string OperationName {get; set;}
        
        ///The Azure region from which statistics for this partition were�retrieved.
        public string RegionName {get; set;}
        
        ///The name of the Cosmos DB database,�which contains�the partition.
        public string DatabaseName {get; set;}
        
        ///The name of the Cosmos DB collection,�which contains�the partition.
        public string CollectionName {get; set;}
        
        ///The RUs (Request Units) consumed�by�this request.
        public real RequestCharge {get; set;}
        
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
