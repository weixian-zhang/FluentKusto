
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AppDependencies : TableBase<AppDependencies>
    {

            /// 
            public string TenantId {get; set;}
            
            /// Date and time when dependency call was recorded.
            public DateTime TimeGenerated {get; set;}
            
            /// Application-generated, unique ID of the dependency call.
            public string Id {get; set;}
            
            /// Target of a dependency call, such as a Web or a SQL server name.
            public string Target {get; set;}
            
            /// Dependency type, such as HTTP or SQL.
            public string DependencyType {get; set;}
            
            /// Dependency name, such as an URI query without parameters or a SQL server table name.
            public string Name {get; set;}
            
            /// Detailed information about the dependency call, such as a full URI or a SQL statement.
            public string Data {get; set;}
            
            /// Indicates whether the dependency call completed successfully.
            public bool Success {get; set;}
            
            /// Result code returned to the application by the dependency call.
            public string ResultCode {get; set;}
            
            /// Number of milliseconds the dependency call took to complete.
            public float DurationMs {get; set;}
            
            /// Application-defined properties.
            public dynamic Properties {get; set;}
            
            /// Application-defined measurements.
            public dynamic Measurements {get; set;}
            
            /// Application-defined name of the overall operation. The OperationName values typically match the Name values for AppRequests.
            public string OperationName {get; set;}
            
            /// Application-defined operation ID.
            public string OperationId {get; set;}
            
            /// ID of the parent operation.
            public string ParentId {get; set;}
            
            /// Synthetic source of the operation.
            public string SyntheticSource {get; set;}
            
            /// Application-defined session ID.
            public string SessionId {get; set;}
            
            /// Anonymous ID of a user accessing the application.
            public string UserId {get; set;}
            
            /// Persistent string that uniquely represents each authenticated user in the application.
            public string UserAuthenticatedId {get; set;}
            
            /// Application-defined account associated with the user.
            public string UserAccountId {get; set;}
            
            /// Version of the application.
            public string AppVersion {get; set;}
            
            /// Role name of the application.
            public string AppRoleName {get; set;}
            
            /// Role instance of the application.
            public string AppRoleInstance {get; set;}
            
            /// Type of the client device.
            public string ClientType {get; set;}
            
            /// Model of the client device.
            public string ClientModel {get; set;}
            
            /// Operating system of the client device.
            public string ClientOS {get; set;}
            
            /// IP address of the client device.
            public string ClientIP {get; set;}
            
            /// City where the client device is located.
            public string ClientCity {get; set;}
            
            /// State or province where the client device is located.
            public string ClientStateOrProvince {get; set;}
            
            /// Country or region where the client device is located.
            public string ClientCountryOrRegion {get; set;}
            
            /// Browser running on the client device.
            public string ClientBrowser {get; set;}
            
            /// Unique, persistent identifier of an Azure resource.
            public string ResourceGUID {get; set;}
            
            /// Instrumentation key of the Azure resource.
            public string IKey {get; set;}
            
            /// Version of the SDK used by the application to generate this telemetry item.
            public string SDKVersion {get; set;}
            
            /// Number of telemetry items represented by a single sample item.
            public int ItemCount {get; set;}
            
            /// Id of the item with additional details about the dependency call.
            public string ReferencedItemId {get; set;}
            
            /// Name of the table with additional details about the dependency call.
            public string ReferencedType {get; set;}
            
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
