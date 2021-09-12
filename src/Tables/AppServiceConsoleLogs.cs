
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AppServiceConsoleLogs : TableBase<AppServiceConsoleLogs>
    {

            /// 
            public string TenantId {get; set;}
            
            /// Time when event is generated
            public DateTime TimeGenerated {get; set;}
            
            /// Verbosity level of log
            public string Level {get; set;}
            
            /// Log message description
            public string ResultDescription {get; set;}
            
            /// Application container id
            public string ContainerId {get; set;}
            
            /// Host where the application is running
            public string Host {get; set;}
            
            /// The name of the operation represented by this event.
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
