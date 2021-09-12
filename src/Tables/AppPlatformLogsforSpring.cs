
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AppPlatformLogsforSpring : TableBase<AppPlatformLogsforSpring>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) when the log is collected by Azure Spring Cloud
            public DateTime TimeGenerated {get; set;}
            
            /// The service name that emitted the log
            public string ServiceName {get; set;}
            
            /// The application name that emitted the log
            public string AppName {get; set;}
            
            /// The instance name that emitted the log
            public string InstanceName {get; set;}
            
            /// The content of the log
            public string Log {get; set;}
            
            /// The log timestamp (UTC) from user application log
            public DateTime AppTimestamp {get; set;}
            
            /// The logger from user application log
            public string Logger {get; set;}
            
            /// Verbosity level of log
            public string CustomLevel {get; set;}
            
            /// The thread of the log
            public string Thread {get; set;}
            
            /// The message of the log
            public string Message {get; set;}
            
            /// The stackTrace of the log
            public string StackTrace {get; set;}
            
            /// Customized MDC field in the log
            public string MDC {get; set;}
            
            /// The exceptionClass of the log
            public string ExceptionClass {get; set;}
            
            /// TraceId for tracing
            public string TraceId {get; set;}
            
            /// SpanId for tracing
            public string SpanId {get; set;}
            
            /// The stream of the log
            public string Stream {get; set;}
            
            /// Log Category
            public string Category {get; set;}
            
            /// The name of the operation represented by this event
            public string OperationName {get; set;}
            
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
