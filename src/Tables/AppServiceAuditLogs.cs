
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AppServiceAuditLogs : TableBase<AppServiceAuditLogs>
    {

            /// 
            public string TenantId {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// Time when event is generated
            public DateTime TimeGenerated {get; set;}
            
            /// Log category name
            public string Category {get; set;}
            
            /// Name of the operation
            public string OperationName {get; set;}
            
            /// Username used for publishing access
            public string User {get; set;}
            
            /// Email address of a user in case publishing was authorized via AAD authentication
            public string UserDisplayName {get; set;}
            
            /// Client IP addres of the publishing user
            public string UserAddress {get; set;}
            
            /// Authentication protocol
            public string Protocol {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
