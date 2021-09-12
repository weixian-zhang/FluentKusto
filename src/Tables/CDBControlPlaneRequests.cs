
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class CDBControlPlaneRequests : TableBase<CDBControlPlaneRequests>
    {

            /// 
            public string TenantId {get; set;}
            
            /// Timestamp (in�UTC)�when�this�Control Plane operation was executed against the Cosmos DB account.
            public DateTime TimeGenerated {get; set;}
            
            /// The name of the Cosmos DB account.
            public string AccountName {get; set;}
            
            /// The Activity ID of the�operation.
            public string ActivityId {get; set;}
            
            /// The Control Plane Operation that was executed.
            public string OperationName {get; set;}
            
            /// The HTTP status code of the control plane operation.
            public int HttpStatusCode {get; set;}
            
            /// The result of the operation�indicating�either�success�or�failure.
            public string Result {get; set;}
            
            /// The region in which this control plan operation was�executed.
            public string RegionName {get; set;}
            
            /// The HTTP method issued for this control plane�operation.
            public string HttpMethod {get; set;}
            
            /// The current write region for this account (applies when a regional failover is triggered to�choose�a new write region).
            public string CurrentWriteRegion {get; set;}
            
            /// The new write region for the Cosmos DB account (after a�user-initiated�failover operation is executed).
            public string NewWriteRegion {get; set;}
            
            /// The IP range filter specified as part of the VNet rules for the Cosmos DB account.
            public string IpRangeFilter {get; set;}
            
            /// Boolean flag indicating if VNet filters were enabled for the account.
            public bool EnableVirtualNetworkFilter {get; set;}
            
            /// The list of IP addresses being included as part of the VNet rule for the account.
            public string VirtualNetworkResourceEntries {get; set;}
            
            /// Boolean flag to enable private endpoints for the Cosmos DB account.
            public bool EnablePrivateEndpointConnection {get; set;}
            
            /// The list of private endpoints for the Cosmos DB account (in each region).
            public string PrivateEndpointConnections {get; set;}
            
            /// The�ARM�URL�of the private endpoint�created�for�the account.
            public string PrivateEndpointArmUrl {get; set;}
            
            /// The default consistency level for the Cosmos DB account.
            public string DefaultConsistencyLevel {get; set;}
            
            /// Boolean flag to enable automatic failover for the Cosmos DB account.
            public bool EnableAutomaticFailover {get; set;}
            
            /// The maximum staleness value (in seconds) for the Cosmos DB account when using the Bounded Staleness consistency�setting.
            public float MaxStalenessIntervalInSeconds {get; set;}
            
            /// The max staleness prefix for the Cosmos DB account when using the Bounded Staleness consistency�setting.
            public string MaxStalenessPrefix {get; set;}
            
            /// Boolean flag�indicating�if the Cosmos DB account is a�multi-master�account.
            public bool MultipleWriteLocations {get; set;}
            
            /// Collection of account�s Cross Origin Resource Sharing Rules
            public string Cors {get; set;}
            
            /// The time (in minutes) between consecutive backup snapshots for the Cosmos DB account.
            public float BackupIntervalInMinutes {get; set;}
            
            /// The duration of time (in hours) for which backup snapshots are�retained�for the Cosmos DB account.
            public float BackupRetentionIntervalInHours {get; set;}
            
            /// The name of the resource group within which the VNet is�created.
            public string VnetResourceGroupName {get; set;}
            
            /// The name of the Vnet for the account.
            public string VirtualNetworkName {get; set;}
            
            /// The list of virtual networks�specified�for the�account.
            public string VnetDatabaseAccountEntries {get; set;}
            
            /// The�ACL�d�subnets for the account.
            public string AcledSubnets {get; set;}
            
            /// The Azure region in which the VNet for the account is�location.
            public string VnetLocation {get; set;}
            
            /// The ARM URL for the VNet for the account.
            public string VnetArmUrl {get; set;}
            
            /// Boolean flag�indicating�if full query text logging is�enabled.
            public bool SqlQueryTextTraceType {get; set;}
            
            /// Boolean flag�indicating�if diagnostic logs are�enabled for all Data Plane Operations.
            public bool EnableDataPlaneRequestsTrace {get; set;}
            
            /// Boolean flag indicting if diagnostic logs are�enabled for Control Plane operations.
            public bool EnableControlPlaneRequestsTrace {get; set;}
            
            /// Boolean flag�indicating�if diagnostic logs are�enabled for all Mongo API operations.
            public bool EnableMongoRequestsTrace {get; set;}
            
            /// Boolean flag�indicating�if diagnostic logs are�enabled for all Cassandra API operations.
            public bool EnableCassandraRequestsTrace {get; set;}
            
            /// Boolean flag�indicating�if diagnostic logs are�enabled for Gremlin operations.
            public bool EnableGremlinRequestsTrace {get; set;}
            
            /// The time taken (in milliseconds) for this control plane operation to�complete.
            public float DurationMs {get; set;}
            
            /// The Id of the�IAM�role�created�for the�account.
            public string RoleDefinitionId {get; set;}
            
            /// The name of the�IAM�role�created�for the�account.
            public string RoleDefinitionName {get; set;}
            
            /// The type of�IAM�role�created�for the�account.
            public string RoleDefinitionType {get; set;}
            
            /// The assignable scopes for the IAM role created for the�account.
            public string RoleDefinitionAssignableScopes {get; set;}
            
            /// The permissions associated with the IAM role�created for the�account.
            public string RoleDefinitionPermissions {get; set;}
            
            /// The role assignment Id for the IAM role created for the�account.
            public string RoleAssignmentId {get; set;}
            
            /// The ID of the�IAM�role definition for the IAM role�created�for the�account.
            public string AssociatedRoleDefinitionId {get; set;}
            
            /// The Principal ID associated with the IAM Role Assignment created for the account.
            public string RoleAssignmentPrincipalId {get; set;}
            
            /// The Principal type of the IAM role assignment created for the account.
            public string RoleAssignmentPrincipalType {get; set;}
            
            /// The scope of access for the IAM role�created�for the�account.
            public string RoleAssignmentScope {get; set;}
            
            /// The API kind for the account (SQL, Graph, Mongo, Cassanda, Table)�that is specified during account�creation.
            public string ApiKind {get; set;}
            
            /// The resource against which this Control Plane operation was executed (e.g. Database, Container etc.)
            public string ApiKindResourceType {get; set;}
            
            /// The type of control plane operation, which was�executed. Examples of operations included Add/Remove region, Indexing Policy updates, VNet and firewall rule creation, Backup Retention Policy changes etc.
            public string OperationType {get; set;}
            
            /// The URI of the Cosmos DB resource (e.g. Database, Container) against which the control plane operation was�execution.
            public string ResourceUri {get; set;}
            
            /// The specific resource within the account against which the Control Plane Operation was executed. For e.g. the index for the container for which the indexing policy was created or updated.
            public string ResourceDetails {get; set;}
            
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
