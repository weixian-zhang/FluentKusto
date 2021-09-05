

namespace FluentKusto
{
    public class CDBQueryRuntimeStatistics
    {

        ///
        public string TenantId {get; set;}
        
        ///Timestamp (in UTC) when this query operation was executed.
        public datetime TimeGenerated {get; set;}
        
        ///The name of the Cosmos DB account against which the query operation was issued.
        public string AccountName {get; set;}
        
        ///The name of the Cosmos DB database containing the Cosmos DB container against which this query was�issued.
        public string DatabaseName {get; set;}
        
        ///The name of the Cosmos DB container against which this query was�issued.
        public string CollectionName {get; set;}
        
        ///The physical partition to which this query was�issued.
        public string PartitionKeyRangeId {get; set;}
        
        ///The query text (obfuscated by default, full query string provided upon request) for the operation.
        public string QueryText {get; set;}
        
        ///The unique identifier (GUID) for this query operation, which can be correlating with the CDBDataPlaneRequests table for additional debugging.
        public string ActivityId {get; set;}
        
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
