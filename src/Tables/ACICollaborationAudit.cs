

namespace FluentKusto
{
    public class ACICollaborationAudit
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the audit was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The operation associated with audit record.
        public string OperationName {get; set;}
        
        ///The ID for correlated pipeline run events. Can be used to identify audits that belong to the same pipeline run.
        public string CorrelationId {get; set;}
        
        ///The result of the entitlement evaluation. Options are: Granted = access granted; Denied = access was not granted; Revoked = accessed was revoked because the pipeline could not be fully approved; Actualized = the resource was accessed by the pipeline run.
        public string EntitlementResult {get; set;}
        
        ///The azure resource ID of the accessed resource.
        public string TargetResourceId {get; set;}
        
        ///The resource type of the accessed resource.
        public string TargetResourceType {get; set;}
        
        ///The participant friendly name as used in the contract negotiation.
        public string ParticipantName {get; set;}
        
        ///The participant tenant id. Enable query by the granted tenant invariant id. Example of retrieving this is for contoso: https://login.microsoftonline.com/contoso.com/.well-known/openid-configuration
        public string ParticipantTenantId {get; set;}
        
        ///Name of the user that initiated the pipeline. Available only if the audit relate to owned resource
        public string UserName {get; set;}
        
        ///The method used to grant access to the resource (Owned, Reference, Entitlement).
        public string GrantType {get; set;}
        
        ///The azure resource ID of the resource the grant is based on.
        public string GrantSource {get; set;}
        
        ///The type of the the resource the grant is based on.
        public string GrantSourceType {get; set;}
        
        ///The ID for the grant events. Can be used to correlate between different results of the same grant.
        public string GrantCorrelationId {get; set;}
        
        ///Textual summary of the granted access.
        public string EntitlementSummary {get; set;}
        
        ///The storage resource that the accessed CI resource points to, if applicable
        public string ReferencedResourceId {get; set;}
        
        ///The storage resource type that the accessed CI resource points to, if applicable.
        public string ReferencedResourceType {get; set;}
        
        ///The Location (Region) the resource was accessed in.
        public string Location {get; set;}
        
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
