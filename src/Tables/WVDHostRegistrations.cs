
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class WVDHostRegistrations : TableBase<WVDHostRegistrations>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of the event.
            public DateTime TimeGenerated {get; set;}
            
            /// The activity Id.
            public string CorrelationId {get; set;}
            
            /// The name of the session host that was registered with the WVD service.
            public string SessionHostName {get; set;}
            
            /// The IP address of the session host that was registered with the WVD service.
            public string SessionHostIPAddress {get; set;}
            
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
