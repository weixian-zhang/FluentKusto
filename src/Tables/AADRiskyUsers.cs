
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AADRiskyUsers : TableBase<AADRiskyUsers>
    {

            /// 
            public string TenantId {get; set;}
            
            /// Unique ID of the user at risk.
            public string Id {get; set;}
            
            /// Indicates whether the user is deleted.
            public bool IsDeleted {get; set;}
            
            /// Indicates whether a user's risky state is being processed by the backend.
            public bool IsProcessing {get; set;}
            
            /// Details of the detected risk. Possible values are: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, hidden, adminConfirmedUserCompromised, unknownFutureValue.
            public string RiskDetail {get; set;}
            
            /// The date and time that the risky user was last updated.
            public DateTime RiskLastUpdatedDateTime {get; set;}
            
            /// Level of the detected risky user. Possible values are: low, medium, high, hidden, none, unknownFutureValue.
            public string RiskLevel {get; set;}
            
            /// State of the user's risk. Possible values are: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, unknownFutureValue.
            public string RiskState {get; set;}
            
            /// Risky user display name.
            public string UserDisplayName {get; set;}
            
            /// Risky user principal name.
            public string UserPrincipalName {get; set;}
            
            /// The date and time of the event in UTC.
            public DateTime TimeGenerated {get; set;}
            
            /// Name of the operation.
            public string OperationName {get; set;}
            
            /// The ID for correlated log analytics events. Can be used to identify correlated events between multiple tables.
            public string CorrelationId {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
                }
}
