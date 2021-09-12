
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class WVDErrors : TableBase<WVDErrors>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of the event.
            public DateTime TimeGenerated {get; set;}
            
            /// The activity Id.
            public string CorrelationId {get; set;}
            
            /// The user for which the error happened.
            public string UserName {get; set;}
            
            /// The activity type for which the error happened.
            public string ActivityType {get; set;}
            
            /// The source of the error.
            public string Source {get; set;}
            
            /// The error code for the error.
            public long Code {get; set;}
            
            /// The error code symbolic representation (if available).
            public string CodeSymbolic {get; set;}
            
            /// The error message.
            public string Message {get; set;}
            
            /// Indicator whether this is a service or customer error.
            public bool ServiceError {get; set;}
            
            /// The name of the operation that failed.
            public string Operation {get; set;}
            
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
