
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AppServiceEnvironmentPlatformLogs : TableBase<AppServiceEnvironmentPlatformLogs>
    {

            /// 
            public string SourceSystem {get; set;}
            
            /// 
            public DateTime TimeGenerated {get; set;}
            
            /// 
            public string ResourceId {get; set;}
            
            /// 
            public string OperationName {get; set;}
            
            /// 
            public string Category {get; set;}
            
            /// 
            public string ResultType {get; set;}
            
            /// 
            public string ResultDescription {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
