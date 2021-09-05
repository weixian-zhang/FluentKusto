

namespace FluentKusto
{
    public class AADManagedIdentitySignInLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///Details of source system of the object being provisioned
        public string SourceSystem {get; set;}
        
        ///The date and time of the event in UTC
        public datetime TimeGenerated {get; set;}
        
        ///For sign-ins, this value is always Sign-in activity
        public string OperationName {get; set;}
        
        ///The REST API version that's requested by the client
        public string OperationVersion {get; set;}
        
        ///Category of the sign-in event
        public string Category {get; set;}
        
        ///The result of the sign-in operation can be Success or Failure
        public string ResultType {get; set;}
        
        ///Contains the error code, if any, for the sign-in operation
        public string ResultSignature {get; set;}
        
        ///Provides the error description for the sign-in operation
        public string ResultDescription {get; set;}
        
        ///The duration of the operation in milliseconds
        public long DurationMs {get; set;}
        
        ///ID to provide sign-in trail
        public string CorrelationId {get; set;}
        
        ///Resource group for the logs
        public string ResourceGroup {get; set;}
        
        ///The identity from the token that was presented when you made the request. It can be a user account, system account, or service principal
        public string Identity {get; set;}
        
        ///The severity level of the event
        public string Level {get; set;}
        
        ///The region of the resource emitting the event
        public string Location {get; set;}
        
        ///Unique GUID representing the app ID in the Azure Active Directory
        public string AppId {get; set;}
        
        ///Unique ID representing the sign-in activity
        public string Id {get; set;}
        
        ///IP address of the client used to sign in
        public string IPAddress {get; set;}
        
        ///Details of the sign-in location
        public string LocationDetails {get; set;}
        
        ///Name of the resource that the service principal signed into
        public string ResourceDisplayName {get; set;}
        
        ///ID of the resource that the service principal signed into
        public string ResourceIdentity {get; set;}
        
        ///ID of the service principal who initiated the sign-in
        public string ServicePrincipalId {get; set;}
        
        ///Service Principal Name of the service principal who initiated the sign-in
        public string ServicePrincipalName {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
            }
}
