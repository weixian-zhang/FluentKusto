

namespace FluentKusto
{
    public class SynapseDXSucceededIngestion
    {

        ///
        public string TenantId {get; set;}
        
        ///The time (UTC) when this event was generated
        public datetime TimeGenerated {get; set;}
        
        ///The time this ingest operation ended successfully
        public datetime SucceededOn {get; set;}
        
        ///The ingestion's operation ID
        public string OperationId {get; set;}
        
        ///The name of the database holding the target table
        public string Database {get; set;}
        
        ///The name of the target table the data is ingested into
        public string Table {get; set;}
        
        ///The ingestion source ID
        public string IngestionSourceId {get; set;}
        
        ///Azure blob storage URI
        public string IngestionSourcePath {get; set;}
        
        ///Final state of this data ingestion operation like 'Succeeded'
        public string ResultType {get; set;}
        
        ///The ingestion's activity ID
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
