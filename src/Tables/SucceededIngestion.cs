
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class SucceededIngestion : TableBase<SucceededIngestion>
    {

            /// 
            public string TenantId {get; set;}
            
            /// 
            public DateTime TimeGenerated {get; set;}
            
            /// Time at which this ingest operation successfully ended
            public DateTime SucceededOn {get; set;}
            
            /// The ingestion's operation Id
            public string OperationId {get; set;}
            
            /// The name of the database holding the target table
            public string Database {get; set;}
            
            /// The name of the target table into which the data is ingested
            public string Table {get; set;}
            
            /// A unique identifier representing the ingested source
            public string IngestionSourceId {get; set;}
            
            /// The Azure blob storage URI
            public string IngestionSourcePath {get; set;}
            
            /// The final state of this data ingestion operation
            public string ResultType {get; set;}
            
            /// The ingestion's activity Id
            public string RootActivityId {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
