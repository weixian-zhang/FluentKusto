

namespace FluentKusto
{
    public class AADUserRiskEvents
    {

        ///
        public string TenantId {get; set;}
        
        ///Indicates the activity type the detected risk is linked to. Possible values are: signin, user, unknownFutureValue.
        public string Activity {get; set;}
        
        ///Date and time when the risky activity occurred.
        public datetime ActivityDateTime {get; set;}
        
        ///Additional information associated with the user risk event in JSON format.
        public dynamic AdditionalInfo {get; set;}
        
        ///Correlation ID of the sign-in associated with the risk detection. This property is null if the risk detection is not associated with a sign-in.
        public string CorrelationId {get; set;}
        
        ///Date and time that the risk was detected.
        public datetime DetectedDateTime {get; set;}
        
        ///Timing of the detected risk (real-time/offline). Possible values are: notDefined, realtime, nearRealtime, offline, unknownFutureValue.
        public string DetectionTimingType {get; set;}
        
        ///Unique ID of the risk event.
        public string Id {get; set;}
        
        ///The IP address of the client from where the risk occurred.
        public string IpAddress {get; set;}
        
        ///Date and time when the risk detection was last updated.
        public datetime LastUpdatedDateTime {get; set;}
        
        ///Location of the sign-in.
        public dynamic Location {get; set;}
        
        ///Request ID of the sign-in associated with the risk detection. This property is null if the risk detection is not associated with a sign-in.
        public string RequestId {get; set;}
        
        ///Details of the detected risk. Possible values are: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, hidden, adminConfirmedUserCompromised, unknownFutureValue.
        public string RiskDetail {get; set;}
        
        ///The type of risk event detected.
        public string RiskEventType {get; set;}
        
        ///Level of the detected risk. Possible values are: low, medium, high, hidden, none, unknownFutureValue.
        public string RiskLevel {get; set;}
        
        ///The state of a detected risky user or sign-in. Possible values are: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, unknownFutureValue.
        public string RiskState {get; set;}
        
        ///Source of the risk detection. For example, activeDirectory.
        public string Source {get; set;}
        
        ///Indicates the type of token issuer for the detected sign-in risk. Possible values are: AzureAD, ADFederationServices, UnknownFutureValue.
        public string TokenIssuerType {get; set;}
        
        ///The user principal name (UPN) of the user.
        public string UserDisplayName {get; set;}
        
        ///Unique ID of the user.
        public string UserId {get; set;}
        
        ///The user principal name (UPN) of the user.
        public string UserPrincipalName {get; set;}
        
        ///The date and time of the event in UTC.
        public datetime TimeGenerated {get; set;}
        
        ///Name of the operation.
        public string OperationName {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
            }
}
