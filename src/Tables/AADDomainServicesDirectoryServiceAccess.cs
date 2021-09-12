
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AADDomainServicesDirectoryServiceAccess : TableBase<AADDomainServicesDirectoryServiceAccess>
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
            public string OpCorrelationID {get; set;}
            
            /// 
            public string AppCorrelationID {get; set;}
            
            /// 
            public string DSName {get; set;}
            
            /// 
            public string DSType {get; set;}
            
            /// 
            public string ObjectDN {get; set;}
            
            /// 
            public string ObjectGUID {get; set;}
            
            /// 
            public string ObjectClass {get; set;}
            
            /// 
            public string AttributeLDAPDisplayName {get; set;}
            
            /// 
            public string AttributeSyntaxOID {get; set;}
            
            /// 
            public string AttributeValue {get; set;}
            
            /// 
            public string OperationType {get; set;}
            
            /// 
            public string OldObjectDN {get; set;}
            
            /// 
            public string NewObjectDN {get; set;}
            
            /// 
            public string TreeDelete {get; set;}
            
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
