

namespace FluentKusto
{
    public class AADProvisioningLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///Unique Azure AD tenant ID
        public string AADTenantId {get; set;}
        
        ///The date and time of the event in UTC
        public datetime TimeGenerated {get; set;}
        
        ///Name of the operation
        public string OperationName {get; set;}
        
        ///The REST API version that's requested by the client
        public string OperationVersion {get; set;}
        
        ///Category of the event
        public string Category {get; set;}
        
        ///The result of the provisioning operation can be Success, Failure, or Skipped
        public string ResultType {get; set;}
        
        ///Contains the error code, if any, for the provisioning operation
        public string ResultSignature {get; set;}
        
        ///When available, provides the error description for the provisioning operation
        public string ResultDescription {get; set;}
        
        ///Indicates how long this provisioning action took to finish
        public long DurationMs {get; set;}
        
        ///ID to provide provisioning trail
        public string CorrelationId {get; set;}
        
        ///Indicates the activity name or the operation name. For a list of activities logged, refer to Azure AD activity list
        public string Action {get; set;}
        
        ///Unique ID of this change in this cycle
        public string ChangeId {get; set;}
        
        ///Unique ID per job iteration
        public string CycleId {get; set;}
        
        ///Indicates the unique ID for the activity
        public string Id {get; set;}
        
        ///Details of who initiated this provisioning
        public string InitiatedBy {get; set;}
        
        ///The unique ID for the whole provisioning job
        public string JobId {get; set;}
        
        ///Details of each property that was modified in this provisioning action on this object
        public string ModifiedProperties {get; set;}
        
        ///Details of each step in provisioning
        public string ProvisioningSteps {get; set;}
        
        ///Represents the service principal used for provisioning
        public string ServicePrincipal {get; set;}
        
        ///Details of source object being provisioned
        public string SourceIdentity {get; set;}
        
        ///Details of source system of the object being provisioned
        public string SourceSystem {get; set;}
        
        ///Details of provisioning status
        public string StatusInfo {get; set;}
        
        ///Details of target object being provisioned
        public string TargetIdentity {get; set;}
        
        ///Details of target system of the object being provisioned
        public string TargetSystem {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
            }
}
