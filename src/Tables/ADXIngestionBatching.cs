
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ADXIngestionBatching : TableBase<ADXIngestionBatching>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The time (UTC) at which this event was generated
            public DateTime TimeGenerated {get; set;}
            
            /// Name of the database holding the target table
            public string Database {get; set;}
            
            /// Name of the target table into which the data is ingested
            public string Table {get; set;}
            
            /// Type of batching: whether the batch reached batching time, data size or number of files limit set by batching policy
            public string BatchingType {get; set;}
            
            /// Minimal time (UTC) at which blobs in this batch were created
            public DateTime SourceCreationTime {get; set;}
            
            /// Total batching time of this batch (seconds)
            public float BatchTimeSeconds {get; set;}
            
            /// Total uncompressed size of data in this batch (bytes)
            public long BatchSizeBytes {get; set;}
            
            /// Number of data sources in this batch
            public int DataSourcesInBatch {get; set;}
            
            /// The operation's activity Id
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
