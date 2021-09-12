
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AADDomainServicesPrivilegeUse : TableBase<AADDomainServicesPrivilegeUse>
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
            
            /// 
            public string CorrelationId {get; set;}
            
            /// 
            public string ProcessId {get; set;}
            
            /// 
            public string ProcessName {get; set;}
            
            /// 
            public string TransactionId {get; set;}
            
            /// 
            public int NewState {get; set;}
            
            /// 
            public string ResourceManager {get; set;}
            
            /// 
            public string RecordId {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
