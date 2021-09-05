

namespace FluentKusto
{
    public class CDBPartitionKeyStatistics
    {

        ///
        public string TenantId {get; set;}
        
        ///Timestamp (in�UTC)�when�statistics for this logical partition key were generated.
        public datetime TimeGenerated {get; set;}
        
        ///The name of the Cosmos DB account�containing the dataset for which partition key stats were generated.
        public string AccountName {get; set;}
        
        ///The Azure region�from which statistics�for this partition�were�retrieved.
        public string RegionName {get; set;}
        
        ///The logical partition key for which�storage�statistics were�retrieved.
        public string PartitionKey {get; set;}
        
        ///The storage size (in KB) for the logical partition key within the physical partition.
        public int SizeKb {get; set;}
        
        ///The�name of the�Cosmos DB�database,�which�contains�the partition.
        public string DatabaseName {get; set;}
        
        ///The name of the Cosmos DB�collection,�which�contains�the partition.
        public string CollectionName {get; set;}
        
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
