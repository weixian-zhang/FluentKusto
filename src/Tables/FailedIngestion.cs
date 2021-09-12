
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class FailedIngestion : TableBase<FailedIngestion>
    {

            /// 
            public string TenantId {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// Time at which this event is generated and logged
            public DateTime TimeGenerated {get; set;}
            
            /// The version of this event
            public string OperationVersion {get; set;}
            
            /// The name of this operation
            public string OperationName {get; set;}
            
            /// The category of this log
            public string Category {get; set;}
            
            /// The ingestion source id
            public string CorrelationId {get; set;}
            
            /// The final state of this data ingestion operation
            public string ResultType {get; set;}
            
            /// The name of the database holding the target table
            public string Database {get; set;}
            
            /// The name of the target table into which the data is ingested
            public string Table {get; set;}
            
            /// The Azure blob storage URI
            public string IngestionSourcePath {get; set;}
            
            /// The failure's details
            public string Details {get; set;}
            
            /// The failure's error code
            public string ErrorCode {get; set;}
            
            /// The failure's status
            public string FailureStatus {get; set;}
            
            /// Indicates whether or not the failure originate from an Update Policy
            public bool OriginatesFromUpdatePolicy {get; set;}
            
            /// Indicates whether or not the failure is transient and should be retried
            public bool ShouldRetry {get; set;}
            
            /// Time at which this ingest operation failed
            public DateTime FailedOn {get; set;}
            
            /// The ingestion's operation Id
            public string OperationId {get; set;}
            
            /// A unique identifier representing the ingested source
            public string IngestionSourceId {get; set;}
            
            /// The ingestion's activity Id
            public string RootActivityId {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
