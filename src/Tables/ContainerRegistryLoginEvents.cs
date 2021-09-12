
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ContainerRegistryLoginEvents : TableBase<ContainerRegistryLoginEvents>
    {

            /// 
            public string TenantId {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// 
            public DateTime TimeGenerated {get; set;}
            
            /// 
            public string OperationName {get; set;}
            
            /// 
            public string LoginServer {get; set;}
            
            /// 
            public string Identity {get; set;}
            
            /// 
            public string JwtId {get; set;}
            
            /// 
            public string Region {get; set;}
            
            /// 
            public string CorrelationId {get; set;}
            
            /// 
            public string ResultType {get; set;}
            
            /// 
            public string ResultDescription {get; set;}
            
            /// 
            public string CallerIpAddress {get; set;}
            
            /// 
            public string DurationMs {get; set;}
            
            /// 
            public string UserAgent {get; set;}
            
            /// 
            public string Category {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
