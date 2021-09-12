
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AppPlatformSystemLogs : TableBase<AppPlatformSystemLogs>
    {

            /// 
            public string TenantId {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// The timestamp (UTC) of the log
            public DateTime TimeGenerated {get; set;}
            
            /// The service name that emitted the log
            public string ServiceName {get; set;}
            
            /// The level of the log
            public string Level {get; set;}
            
            /// The thread of the log
            public string Thread {get; set;}
            
            /// The logger of the log
            public string Logger {get; set;}
            
            /// The log of the log
            public string Log {get; set;}
            
            /// The stack of the log
            public string Stack {get; set;}
            
            /// The type of the log
            public string LogType {get; set;}
            
            /// Log Category
            public string Category {get; set;}
            
            /// The name of the operation represented by this event
            public string OperationName {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
