

namespace FluentKusto
{
    public class AzureDevOpsAuditing
    {

        ///
        public string TenantId {get; set;}
        
        ///The identifier for the audit event, unique across services.
        public string Id {get; set;}
        
        ///CorrelationId allows two or more auditing events to be grouped together. This happens when a single action causes a cascade of auditing entries. An example being project creation.
        public string CorrelationId {get; set;}
        
        ///Unique identifier for the action that occurred.
        public string ActivityId {get; set;}
        
        ///A consistently unique identifier for the actor that caused the auditing event.
        public string ActorCUID {get; set;}
        
        ///The actor's user identifier.
        public string ActorUserId {get; set;}
        
        ///The actor's user principal name.
        public string ActorUPN {get; set;}
        
        ///Type of authentication used by the actor.
        public string AuthenticationMechanism {get; set;}
        
        ///The time the auditing event occurred in UTC.
        public datetime TimeGenerated {get; set;}
        
        ///The level (scope) that the event occurred.
        public string ScopeType {get; set;}
        
        ///User friendly name for the scope level that an auditing event occurred at.
        public string ScopeDisplayName {get; set;}
        
        ///The organization identifier.
        public string ScopeId {get; set;}
        
        ///Unique identifier of the project that an auditing event occurred in. If not provided then the event isn't scoped to a particular project.
        public string ProjectId {get; set;}
        
        ///Friendly name of the project that an auditing event occurred in. If not provided then the event isn't scoped to a particular project.
        public string ProjectName {get; set;}
        
        ///IP address where the event originated.
        public string IpAddress {get; set;}
        
        ///The user agent from the request.
        public string UserAgent {get; set;}
        
        ///The unique identifier for the type of auditing event that occurred. For example, Git.CreateRepo identifies the an auditing event for Git repository creation.
        public string OperationName {get; set;}
        
        ///Additional data that's unique to the type of auditing event.
        public dynamic Data {get; set;}
        
        ///Description of what happened.
        public string Details {get; set;}
        
        ///Part of the Azure DevOps product where the auditing event occurred.
        public string Area {get; set;}
        
        ///Type of action that occurred when the auditing event was logged.
        public string Category {get; set;}
        
        ///Type of action that occurred when the auditing event was logged.
        public string CategoryDisplayName {get; set;}
        
        ///Display name of the user who initiated the auditing event to be logged.
        public string ActorDisplayName {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
            }
}
