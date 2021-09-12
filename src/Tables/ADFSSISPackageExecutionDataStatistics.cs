
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ADFSSISPackageExecutionDataStatistics : TableBase<ADFSSISPackageExecutionDataStatistics>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of the log
            public DateTime TimeGenerated {get; set;}
            
            /// The name of the operation represented by this event
            public string OperationName {get; set;}
            
            /// The name of the log that belongs to
            public string Category {get; set;}
            
            /// correlation id
            public string CorrelationId {get; set;}
            
            /// Data factory name
            public string DataFactoryName {get; set;}
            
            /// Integration runtime name
            public string IntegrationRuntimeName {get; set;}
            
            /// Verbosity level of log
            public string Level {get; set;}
            
            /// Execution id
            public long ExecutionId {get; set;}
            
            /// Package name
            public string PackageName {get; set;}
            
            /// Task name
            public string TaskName {get; set;}
            
            /// Dataflow path Id string
            public string DataflowPathIdString {get; set;}
            
            /// Dataflow path name
            public string DataflowPathName {get; set;}
            
            /// Source somponent name
            public string SourceComponentName {get; set;}
            
            /// Destination component name
            public string DestinationComponentName {get; set;}
            
            /// Rows sent
            public long RowsSent {get; set;}
            
            /// Created time
            public DateTime CreatedTime {get; set;}
            
            /// Execution path
            public string ExecutionPath {get; set;}
            
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
