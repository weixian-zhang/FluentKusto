

namespace FluentKusto
{
    public class ADPAudit
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log record was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The operation associated with the log record.
        public string OperationName {get; set;}
        
        ///The API version against which the operation was performed.
        public string OperationVersion {get; set;}
        
        ///The result of the audit operation.
        public string ResultType {get; set;}
        
        ///Active Directory identity claims
        public dynamic Identity {get; set;}
        
        ///IP address of the user who has performed the operation.
        public string CallerIpAddress {get; set;}
        
        ///W3C Trace Context information used for event correlation.
        public dynamic TraceContext {get; set;}
        
        ///Internal ADP correlation ID needed for support scenarios.
        public string CorrelationId {get; set;}
        
        ///The location (region) of the resource.
        public string Location {get; set;}
        
        ///Additional properties related to the audit event.
        public dynamic Properties {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
