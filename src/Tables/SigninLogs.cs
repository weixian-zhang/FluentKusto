

namespace FluentKusto
{
    public class SigninLogs
    {

        ///
        public string SourceSystem {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string ResourceId {get; set;}
        
        ///
        public string OperationName {get; set;}
        
        ///
        public string OperationVersion {get; set;}
        
        ///
        public string Category {get; set;}
        
        ///
        public string ResultType {get; set;}
        
        ///
        public string ResultSignature {get; set;}
        
        ///
        public string ResultDescription {get; set;}
        
        ///
        public long DurationMs {get; set;}
        
        ///
        public string CorrelationId {get; set;}
        
        ///
        public string Resource {get; set;}
        
        ///
        public string ResourceGroup {get; set;}
        
        ///
        public string ResourceProvider {get; set;}
        
        ///
        public string Identity {get; set;}
        
        ///
        public string Level {get; set;}
        
        ///
        public string Location {get; set;}
        
        ///
        public string AlternateSignInName {get; set;}
        
        ///
        public string AppDisplayName {get; set;}
        
        ///
        public string AppId {get; set;}
        
        ///
        public string AuthenticationDetails {get; set;}
        
        ///
        public string AuthenticationMethodsUsed {get; set;}
        
        ///
        public string AuthenticationProcessingDetails {get; set;}
        
        ///
        public string AuthenticationRequirement {get; set;}
        
        ///
        public string AuthenticationRequirementPolicies {get; set;}
        
        ///
        public string ClientAppUsed {get; set;}
        
        ///
        public dynamic ConditionalAccessPolicies {get; set;}
        
        ///
        public string ConditionalAccessStatus {get; set;}
        
        ///
        public datetime CreatedDateTime {get; set;}
        
        ///
        public dynamic DeviceDetail {get; set;}
        
        ///
        public bool IsInteractive {get; set;}
        
        ///
        public string Id {get; set;}
        
        ///
        public string IPAddress {get; set;}
        
        ///
        public bool IsRisky {get; set;}
        
        ///
        public dynamic LocationDetails {get; set;}
        
        ///
        public dynamic MfaDetail {get; set;}
        
        ///
        public string NetworkLocationDetails {get; set;}
        
        ///
        public string OriginalRequestId {get; set;}
        
        ///
        public string ProcessingTimeInMilliseconds {get; set;}
        
        ///
        public string RiskDetail {get; set;}
        
        ///
        public string RiskEventTypes {get; set;}
        
        ///
        public string RiskEventTypes_V2 {get; set;}
        
        ///
        public string RiskLevelAggregated {get; set;}
        
        ///
        public string RiskLevelDuringSignIn {get; set;}
        
        ///
        public string RiskState {get; set;}
        
        ///
        public string ResourceDisplayName {get; set;}
        
        ///
        public string ResourceIdentity {get; set;}
        
        ///
        public string ServicePrincipalId {get; set;}
        
        ///
        public string ServicePrincipalName {get; set;}
        
        ///
        public dynamic Status {get; set;}
        
        ///
        public string TokenIssuerName {get; set;}
        
        ///
        public string TokenIssuerType {get; set;}
        
        ///
        public string UserAgent {get; set;}
        
        ///
        public string UserDisplayName {get; set;}
        
        ///
        public string UserId {get; set;}
        
        ///
        public string UserPrincipalName {get; set;}
        
        ///
        public string AADTenantId {get; set;}
        
        ///
        public string UserType {get; set;}
        
        ///
        public bool FlaggedForReview {get; set;}
        
        ///
        public string IPAddressFromResourceProvider {get; set;}
        
        ///
        public string SignInIdentifier {get; set;}
        
        ///
        public string SignInIdentifierType {get; set;}
        
        ///
        public string ResourceTenantId {get; set;}
        
        ///
        public string HomeTenantId {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
            }
}
