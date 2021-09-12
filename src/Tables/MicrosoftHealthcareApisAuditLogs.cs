
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class MicrosoftHealthcareApisAuditLogs : TableBase<MicrosoftHealthcareApisAuditLogs>
    {

            /// 
            public string TenantId {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// The timestamp (UTC) of the log.
            public DateTime TimeGenerated {get; set;}
            
            /// The name of the operation represented by this event.
            public string OperationName {get; set;}
            
            /// The correlation id of the request.
            public string CorrelationId {get; set;}
            
            /// The URI of the request.
            public string RequestUri {get; set;}
            
            /// The resource type the operation was executed for.
            public string FhirResourceType {get; set;}
            
            /// The HTTP status code.
            public int StatusCode {get; set;}
            
            /// The result type.
            public string ResultType {get; set;}
            
            /// The duration of the operation in ms.
            public int OperationDuration {get; set;}
            
            /// The audit event category.
            public string LogCategory {get; set;}
            
            /// The IP address of the caller.
            public string CallerIPAddress {get; set;}
            
            /// The JWD token Issuer.
            public string CallerIdentityIssuer {get; set;}
            
            /// The AAD object ID.
            public string CallerIdentityObjectId {get; set;}
            
            /// The caller's identity.
            public dynamic CallerIdentity {get; set;}
            
            /// The location of the server that processed the request (e.g., South Central US).
            public string Location {get; set;}
            
            /// Additional properties.
            public dynamic Properties {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
