
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AuditLogs : TableBase<AuditLogs>
    {

            /// 
            public string SourceSystem {get; set;}
            
            /// Date and time the record was created.
            public DateTime TimeGenerated {get; set;}
            
            /// 
            public string ResourceId {get; set;}
            
            /// Name of the operation.
            public string OperationName {get; set;}
            
            /// REST API version that's requested by the client.
            public string OperationVersion {get; set;}
            
            /// Currently Audit is the only supported value.
            public string Category {get; set;}
            
            /// Result of the operation. Possible values are Success and Failure.
            public string ResultType {get; set;}
            
            /// Property is not used and can be ignored.
            public string ResultSignature {get; set;}
            
            /// Additional description of the result.
            public string ResultDescription {get; set;}
            
            /// Property is not used and can be ignored.
            public long DurationMs {get; set;}
            
            /// Optional GUID that's passed by the client. Can help correlate client-side operations with server-side operations and is useful when tracking logs that span services.
            public string CorrelationId {get; set;}
            
            /// 
            public string Resource {get; set;}
            
            /// 
            public string ResourceGroup {get; set;}
            
            /// 
            public string ResourceProvider {get; set;}
            
            /// Identity from the token that was presented when the request was made. The identity can be a user account system account or service principal.
            public string Identity {get; set;}
            
            /// Message type. This is currently always Informational.
            public string Level {get; set;}
            
            /// Location of the datacenter.
            public string Location {get; set;}
            
            /// Indicates additional details on the activity.
            public dynamic AdditionalDetails {get; set;}
            
            /// GUID that uniquely identifies the activity.
            public string Id {get; set;}
            
            /// User or app initiated the activity.
            public dynamic InitiatedBy {get; set;}
            
            /// Service that initiated the activity (For example: Self-service Password Management Core Directory B2C Invited Users Microsoft Identity Manager Privileged Identity Management.
            public string LoggedByService {get; set;}
            
            /// Result of the activity. Possible values are: success failure timeout unknownFutureValue.
            public string Result {get; set;}
            
            /// Describes cause of failure or timeout results.
            public string ResultReason {get; set;}
            
            /// Indicates information on which resource was changed due to the activity. Target Resource Type can be User Device Directory App Role Group Policy or Other.
            public dynamic TargetResources {get; set;}
            
            /// ID of the ADD tenant
            public string AADTenantId {get; set;}
            
            /// Activity name or the operation name. Examples include Create User and Add member to group. For full list see Azure AD activity list.
            public string ActivityDisplayName {get; set;}
            
            /// Date and time the activity was performed in UTC.
            public DateTime ActivityDateTime {get; set;}
            
            /// Type of the operation. Possible values are�Add�Update�Delete and�Other.
            public string AADOperationType {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
                }
}
