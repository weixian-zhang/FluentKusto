
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class WVDManagement : TableBase<WVDManagement>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of the event.
            public DateTime TimeGenerated {get; set;}
            
            /// The activity Id.
            public string CorrelationId {get; set;}
            
            /// The user that initiated the management request.
            public string UserName {get; set;}
            
            /// The route for the management request.
            public string Route {get; set;}
            
            /// The ARM object scope for the management request - used for session hosts, applications.
            public string ArmObjectScope {get; set;}
            
            /// The remote IP address from the client side.
            public string ClientSideIPAddress {get; set;}
            
            /// The number of objects that were fetched.
            public int ObjectsFetched {get; set;}
            
            /// The number of objects that were created.
            public int ObjectsCreated {get; set;}
            
            /// The number of objects that were updated.
            public int ObjectsUpdated {get; set;}
            
            /// The number of objects that were deleted.
            public int ObjectsDeleted {get; set;}
            
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
