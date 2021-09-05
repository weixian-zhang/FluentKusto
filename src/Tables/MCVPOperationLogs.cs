

namespace FluentKusto
{
    public class MCVPOperationLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///Timestamp (in UTC) when the log was created.
        public datetime TimeGenerated {get; set;}
        
        ///The operation name where the log was created.
        public string OperationName {get; set;}
        
        ///Unique vehicle identifier.
        public string VehicleId {get; set;}
        
        ///Device friendly name.
        public string DeviceName {get; set;}
        
        ///The general log message.
        public string Message {get; set;}
        
        ///An identifier for distributed tracing through a system (W3C TraceContext).
        public string TraceId {get; set;}
        
        ///An identifier of the request as known by the caller.
        public string SpanId {get; set;}
        
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
