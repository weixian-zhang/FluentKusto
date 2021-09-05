

namespace FluentKusto
{
    public class WVDAgentHealthStatus
    {

        ///
        public string TenantId {get; set;}
        
        ///Date and time when the report was generated (UTC)
        public datetime TimeGenerated {get; set;}
        
        ///The name of the operation
        public string OperationName {get; set;}
        
        ///Name of the Virtual Machine
        public string SessionHostName {get; set;}
        
        ///The ARM path of the session host
        public string SessionHostResourceId {get; set;}
        
        ///The version of the WVD Agent running on the Virtual Machine
        public string AgentVersion {get; set;}
        
        ///The version of the operating system
        public string OSVersion {get; set;}
        
        ///The version of the reverse connect listener running on the VM
        public string SxSStackVersion {get; set;}
        
        ///The time recorded when there was a change in the health status
        public datetime LastHeartBeat {get; set;}
        
        ///The current state of the VM, whether its available or offline
        public string EndpointState {get; set;}
        
        ///The last known state from a previous update
        public string UpgradeState {get; set;}
        
        ///The version of the reverse connect listener running on the VM
        public string UpgradeErrorMsg {get; set;}
        
        ///The time recorded when there was a change in the health status
        public datetime LastUpgradeTimeStamp {get; set;}
        
        ///The set of results on health checks
        public dynamic SessionHostHealthCheckResult {get; set;}
        
        ///The number of active sessions on the VM
        public string ActiveSessions {get; set;}
        
        ///The number of disconnected, or logged off sessions on the VM
        public string InactiveSessions {get; set;}
        
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
