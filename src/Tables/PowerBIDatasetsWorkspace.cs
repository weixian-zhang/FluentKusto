
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class PowerBIDatasetsWorkspace : TableBase<PowerBIDatasetsWorkspace>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp(UTC) of when the log entry was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The operation associated with the log record.
            public string OperationName {get; set;}
            
            /// An event ID that can be used to correlated events between multiple tables.
            public string CorrelationId {get; set;}
            
            /// Unique identifier of the Power BI workspace that contains the artifact being operated on.
            public string WorkspaceId {get; set;}
            
            /// Unique identifier of the Premium capacity hosting the artifact being operated on.
            public string PremiumCapacityId {get; set;}
            
            /// Unique identifiers providing details about the context of the operation. E.g. Report ID, DatasetID.
            public dynamic ApplicationContext {get; set;}
            
            /// Contains the name of the client application that created the connection to the Power BI dataset. This is provided by the application and is optional.
            public string ApplicationName {get; set;}
            
            /// Unique ID of the resource logging the data.
            public string ArtifactId {get; set;}
            
            /// Type of artifact logging the operation e.g. Dataset.
            public string ArtifactKind {get; set;}
            
            /// Amount of CPU time (in milliseconds) used by the operation.
            public long CpuTimeMs {get; set;}
            
            /// The name of the Power BI artifact logging this operation.
            public string ArtifactName {get; set;}
            
            /// Unique category of the events like Audit/Security/Request.
            public string LogAnalyticsCategory {get; set;}
            
            /// The mode of the dataset. Import, DirectQuery or Composite.
            public string DatasetMode {get; set;}
            
            /// Amount of time (in milliseconds) taken by the operation.
            public long DurationMs {get; set;}
            
            /// The user on whose behalf the operation is running. Used when an end user identity must be impersonated on the server.
            public string User {get; set;}
            
            /// The user executing the operation.
            public string ExecutingUser {get; set;}
            
            /// Provides subcategories of OperationName.
            public string OperationDetailName {get; set;}
            
            /// A comma-separated list of parents, starting with the object's parent.
            public string XmlaObjectPath {get; set;}
            
            /// Name of the workspace containing the artifact.
            public string WorkspaceName {get; set;}
            
            /// Status code of the operation. It covers success and failure.
            public int StatusCode {get; set;}
            
            /// Progress Counter.
            public long ProgressCounter {get; set;}
            
            /// Properties of the XMLA request.
            public string XmlaProperties {get; set;}
            
            /// Analysis services session identifier.
            public string XmlaSessionId {get; set;}
            
            /// Contains the severity level of the operation being logged. Success, Informational, Warning, or Error.
            public string Level {get; set;}
            
            /// Information about user and claims.
            public dynamic Identity {get; set;}
            
            /// Status of the operation.
            public string Status {get; set;}
            
            /// Contains verbose information associated with operation e.g. DAX query.
            public string EventText {get; set;}
            
            /// Unique identifier of the Power BI tenant.
            public string CustomerTenantId {get; set;}
            
            /// Unique Identifier of request.
            public string XmlaRequestId {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
