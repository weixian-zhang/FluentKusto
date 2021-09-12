
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class PurviewScanStatusLogs : TableBase<PurviewScanStatusLogs>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// Log type category.
            public string Category {get; set;}
            
            /// The operation associated with log record.
            public string OperationName {get; set;}
            
            /// The ID for correlated events. Can be used to identify correlated events between multiple tables.
            public string CorrelationId {get; set;}
            
            /// Log level of message (INFO, WARN, ERROR, etc.).
            public string LogLevel {get; set;}
            
            /// Name of the data source where the scan is run.
            public string DataSourceName {get; set;}
            
            /// Type of data source where the scan is run. For example: AzureDataExplorer, SQLServer etc.
            public string DataSourceType {get; set;}
            
            /// Name of the scan associated with the scan status log event.
            public string ScanName {get; set;}
            
            /// Number of assets discovered from the scan.
            public long AssetsDiscovered {get; set;}
            
            /// Number of assets classified from the scan.
            public long AssetsClassified {get; set;}
            
            /// Time spent by this scan waiting in the queue.
            public long ScanQueueTimeInSeconds {get; set;}
            
            /// Total time to complete the scan.
            public long ScanTotalRunTimeInSeconds {get; set;}
            
            /// Run Type of the scan. For example: Manual, Scheduled etc.
            public string RunType {get; set;}
            
            /// Error detail while running the scan.
            public string ErrorDetails {get; set;}
            
            /// Guid of the Scan Result.
            public string ScanResultId {get; set;}
            
            /// Result of the scan at the current state. For example: Throttled, Queued etc.
            public string ResultType {get; set;}
            
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
