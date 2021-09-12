
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AegDeliveryFailureLogs : TableBase<AegDeliveryFailureLogs>
    {

            /// 
            public string TenantId {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// 
            public DateTime TimeGenerated {get; set;}
            
            /// Time when log was generated.
            public DateTime Time {get; set;}
            
            /// Name of the sub resource.
            public string SubResourceName {get; set;}
            
            /// Name of the event subscription.
            public string EventSubscriptionName {get; set;}
            
            /// Log category name.
            public string Category {get; set;}
            
            /// Name of the operation.
            public string OperationName {get; set;}
            
            /// Log message for the user.
            public string Message {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
