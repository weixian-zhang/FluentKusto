

namespace FluentKusto
{
    public class AADNonInteractiveUserSignInLogs
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
        
        ///Provides the on-premises UPN of the user sign-ing into Azure AD.e.g. Phone number sign-in
        public string AlternateSignInName {get; set;}
        
        ///App name displayed in the Azure portal
        public string AppDisplayName {get; set;}
        
        ///Unique GUID representing the app ID in the Azure Active Directory
        public string AppId {get; set;}
        
        ///A record of each step of authentication undertaken in the sign-in
        public string AuthenticationDetails {get; set;}
        
        ///List of authentication methods used
        public string AuthenticationMethodsUsed {get; set;}
        
        ///Provides the details associated with authentication processor
        public string AuthenticationProcessingDetails {get; set;}
        
        ///Type of authentication required for the sign-in.  If set to multiFactorAuthentication, an MFA step was required.  If set to singleFactorAuthentication, no MFA was required
        public string AuthenticationRequirement {get; set;}
        
        ///Set of CA policies that apply to this sign-in, each as CA: policy name, and/or MFA: Per-user
        public string AuthenticationRequirementPolicies {get; set;}
        
        ///Details outlining app auth used (Legacy vs non Legacy) Eg: Modern Browser, Native App, Exchange Activty Sync and Older Clients
        public string ClientAppUsed {get; set;}
        
        ///Details of the conditional access policies being applied for the sign-in
        public string ConditionalAccessPolicies {get; set;}
        
        ///Status of all the conditionalAccess policies related to the sign-in
        public string ConditionalAccessStatus {get; set;}
        
        ///Datetime of the sign-in activity
        public datetime CreatedDateTime {get; set;}
        
        ///Details of the device used for the sign-in
        public string DeviceDetail {get; set;}
        
        ///Indicates if a sign-in is interactive or not
        public bool IsInteractive {get; set;}
        
        ///Unique ID representing the sign-in activity
        public string Id {get; set;}
        
        ///IP address of the client used to sign in
        public string IPAddress {get; set;}
        
        ///Indicates if a sign-in is considered risky or not
        public bool IsRisky {get; set;}
        
        ///Details of the sign-in location
        public string LocationDetails {get; set;}
        
        ///Details of the Multi-factor authentication
        public string MfaDetail {get; set;}
        
        ///Provides the details associated with authentication processor
        public string NetworkLocationDetails {get; set;}
        
        ///The request id of the first request in the authentication sequence
        public string OriginalRequestId {get; set;}
        
        ///Request processing time in milliseconds in AD STS
        public string ProcessingTimeInMs {get; set;}
        
        ///Name of the resource that the user signed into
        public string ResourceDisplayName {get; set;}
        
        ///ID of the resource that the user signed into
        public string ResourceIdentity {get; set;}
        
        ///The resource tenantId for B2B(business-to-business) scenarios
        public string ResourceTenantId {get; set;}
        
        ///Risky user state details
        public string RiskDetail {get; set;}
        
        ///The list of risk event types associated with the sign-in
        public string RiskEventTypes {get; set;}
        
        ///The list of risk event types associated with the sign-in. These are strings
        public string RiskEventTypes_V2 {get; set;}
        
        ///Aggregated risk level
        public string RiskLevelAggregated {get; set;}
        
        ///Risk level during sign-in
        public string RiskLevelDuringSignIn {get; set;}
        
        ///Risky user state
        public string RiskState {get; set;}
        
        ///The types that are associated with the sign-in.  Examples include "interactive", "refreshToken", "managedIdentity", "continuousAccessEvaluation" and many more
        public string SignInEventTypes {get; set;}
        
        ///Details of the sign-in status
        public string Status {get; set;}
        
        ///Name of the identity provider (e.g. sts.microsoft.com )
        public string TokenIssuerName {get; set;}
        
        ///Type of identityProvider (Azure AD, AD Federation Services)
        public string TokenIssuerType {get; set;}
        
        ///User Agent for the sign-in
        public string UserAgent {get; set;}
        
        ///Display name of the user that initiated the sign-in
        public string UserDisplayName {get; set;}
        
        ///ID of the user that initiated the sign-in
        public string UserId {get; set;}
        
        ///User principal name of the user that initiated the sign-in
        public string UserPrincipalName {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
            }
}
