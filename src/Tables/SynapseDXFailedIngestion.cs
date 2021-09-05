

namespace FluentKusto
{
    public class SynapseDXFailedIngestion
    {

        ///
        public string TenantId {get; set;}
        
        ///The time (UTC) when this event was generated
        public datetime TimeGenerated {get; set;}
        
        ///The time this ingest operation failed
        public datetime FailedOn {get; set;}
        
        ///The ingestion's operation ID
        public string OperationId {get; set;}
        
        ///The name of the database holding the target table
        public string Database {get; set;}
        
        ///The name of the target table the data is ingested into
        public string Table {get; set;}
        
        ///The ID of the ingestion source
        public string IngestionSourceId {get; set;}
        
        ///Azure blob storage URI
        public string IngestionSourcePath {get; set;}
        
        ///Final state of this data ingestion operation like 'Failed'
        public string ResultType {get; set;}
        
        ///The ingestion's activity ID Used for debugging issues
        public string RootActivityId {get; set;}
        
        ///Details of the failure
        public string Details {get; set;}
        
        ///Failure's error code like 'BadRequest_EmptyBlob'
        public string ErrorCode {get; set;}
        
        ///Failure's status like 'Permanent'
        public string FailureStatus {get; set;}
        
        ///Indicates if the failure originates from an Update Policy
        public bool OriginatesFromUpdatePolicy {get; set;}
        
        ///Indicates if the failure is temporary and the operation should be retried
        public bool ShouldRetry {get; set;}
        
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
