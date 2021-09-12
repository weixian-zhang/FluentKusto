
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class FunctionAppLogs : TableBase<FunctionAppLogs>
    {

            /// 
            public string TenantId {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// The timestamp (UTC) of the log.
            public DateTime TimeGenerated {get; set;}
            
            /// The log category name.
            public string Category {get; set;}
            
            /// The location of the server that processed the request (e.g., South Central US).
            public string Location {get; set;}
            
            /// The log message.
            public string Message {get; set;}
            
            /// The Functions host version.
            public string HostVersion {get; set;}
            
            /// The invocation id that logged the message.
            public string FunctionInvocationId {get; set;}
            
            /// The name of the function that logged the message.
            public string FunctionName {get; set;}
            
            /// The host instance id.
            public string HostInstanceId {get; set;}
            
            /// The activity id that logged the message.
            public string ActivityId {get; set;}
            
            /// The log level.
            public string Level {get; set;}
            
            /// The exception details.
            public string ExceptionDetails {get; set;}
            
            /// The exception message.
            public string ExceptionMessage {get; set;}
            
            /// The exception type.
            public string ExceptionType {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
