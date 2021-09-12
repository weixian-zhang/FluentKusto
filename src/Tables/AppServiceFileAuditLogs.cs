
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AppServiceFileAuditLogs : TableBase<AppServiceFileAuditLogs>
    {

            /// 
            public string TenantId {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// Time when event is generated
            public DateTime TimeGenerated {get; set;}
            
            /// Log category name
            public string Category {get; set;}
            
            /// Operation performed on a file
            public string OperationName {get; set;}
            
            /// Path to the file that was changed
            public string Path {get; set;}
            
            /// Type of the process that change the file
            public string Process {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
