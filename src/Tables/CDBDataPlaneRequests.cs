
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class CDBDataPlaneRequests : TableBase<CDBDataPlaneRequests>
    {

            /// 
            public string TenantId {get; set;}
            
            /// Timestamp (in UTC) when the data plane request was issued.
            public DateTime TimeGenerated {get; set;}
            
            /// The name of the Cosmos DB account.
            public string AccountName {get; set;}
            
            /// The specific data plane operation�executed�against the�account.
            public string OperationName {get; set;}
            
            /// The connection mode used by the client issuing the request � (Direct or Gateway mode).
            public string ConnectionMode {get; set;}
            
            /// The unique identifier (GUID) for this data plane operation
            public string ActivityId {get; set;}
            
            /// The name of the user specified user agent suffix (as specified when initializing the Cosmos DB client) when running in Direct mode.
            public string UserAgent {get; set;}
            
            /// The Cosmos DB resource type within the account against which the data plane request was executed, can be one of Database, Collection, Document, Attachment, User, Permission,�StoredProcedure, Trigger,�UserDefinedFunction, Offer.
            public string RequestResourceType {get; set;}
            
            /// The ID of the specific Cosmos DB resource within the account against which the data plane request was executed.
            public string RequestResourceId {get; set;}
            
            /// The�HTTP�status code�response�for the data plane request, highlighting details of the success/failure of the request.
            public int StatusCode {get; set;}
            
            /// The IP address of the client VM issuing the�request.
            public string ClientIpAddress {get; set;}
            
            /// The RUs (Request Units) consumed by this operation.
            public float RequestCharge {get; set;}
            
            /// The�server-side�execution time (in milliseconds) for this request.
            public float DurationMs {get; set;}
            
            /// The payload size�(in bytes)�for the request.
            public float RequestLength {get; set;}
            
            /// The payload size (in bytes)�of�the�server�response.
            public float ResponseLength {get; set;}
            
            /// The Azure region�to�which this request was�issued.
            public string RegionName {get; set;}
            
            /// The physical partition ID for the Cosmos DB container against which the request was�issued.
            public string PartitionId {get; set;}
            
            /// The ID of the applied role assignment for the caller issuing the data plane�request.
            public string AadAppliedRoleAssignmentId {get; set;}
            
            /// The�AAD�Principal ID of the caller issuing the data plane�request.
            public string AadPrincipalId {get; set;}
            
            /// The Cosmos DB database against which the request was�issued.
            public string DatabaseName {get; set;}
            
            /// The Cosmos DB container against which the request was�issued.
            public string CollectionName {get; set;}
            
            /// The ID of the resource token associated with the resource accessed�by�this�request.
            public string ResourceTokenPermissionId {get; set;}
            
            /// The permission mode of the resource token associated with the resource accessed�by�this�request.
            public string ResourceTokenPermissionMode {get; set;}
            
            /// The user ID associated with the resource token for the resource accessed by this�request.
            public string ResourceTokenUserRid {get; set;}
            
            /// The authorization type (Primary/Secondary Read/Write key)�for this request when running in Direct mode.
            public string KeyType {get; set;}
            
            /// The authorization type (System Read/Write key)�for this request by the Cosmos DB Gateway service when running in Gateway mode or using the REST API.
            public string AuthTokenType {get; set;}
            
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
