

namespace FluentKusto
{
    public class AppServiceIPSecAuditLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///Time of the Http Request
        public datetime TimeGenerated {get; set;}
        
        ///The result whether the access is Allowed or Denied
        public string Result {get; set;}
        
        ///Host header of the HTTP request
        public string CsHost {get; set;}
        
        ///This indicates whether the access is via Virtual Network Service Endpoint communication
        public string ServiceEndpoint {get; set;}
        
        ///IP address of the client
        public string CIp {get; set;}
        
        ///X-Forwarded-For header of the HTTP request
        public string XForwardedFor {get; set;}
        
        ///X-Forwarded-Host header of the HTTP request
        public string XForwardedHost {get; set;}
        
        ///X-Azure-FDID header (Azure Frontdoor Id) of the HTTP request
        public string XAzureFDID {get; set;}
        
        ///X-FD-HealthProbe (Azure Frontdoor Health Probe) of the HTTP request
        public string XFDHealthProbe {get; set;}
        
        ///Additional information
        public string Details {get; set;}
        
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
