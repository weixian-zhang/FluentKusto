
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AADDomainServicesAccountLogon : TableBase<AADDomainServicesAccountLogon>
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
            public string IpAddress {get; set;}
            
            /// 
            public string IpPort {get; set;}
            
            /// 
            public string ServiceName {get; set;}
            
            /// 
            public string TicketOptions {get; set;}
            
            /// 
            public string PreAuthType {get; set;}
            
            /// 
            public string CertIssuerName {get; set;}
            
            /// 
            public string CertSerialNumber {get; set;}
            
            /// 
            public string CertThumbprint {get; set;}
            
            /// 
            public string FailureCode {get; set;}
            
            /// 
            public string MappingBy {get; set;}
            
            /// 
            public string ClientUserName {get; set;}
            
            /// 
            public string MappedName {get; set;}
            
            /// 
            public string PackageName {get; set;}
            
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
