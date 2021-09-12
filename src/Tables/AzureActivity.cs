
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AzureActivity : TableBase<AzureActivity>
    {

            /// 
            public string OperationName {get; set;}
            
            /// Identifier of the operation e.g. Microsoft.Storage/storageAccounts/listAccountSas/action.
            public string OperationNameValue {get; set;}
            
            /// Level of the event. One of the following values: Critical, Error, Warning, Informational and Verbose.
            public string Level {get; set;}
            
            /// 
            public string ActivityStatus {get; set;}
            
            /// Status of the operation in display-friendly format. Common values include Started, In Progress, Succeeded, Failed, Active, Resolved.
            public string ActivityStatusValue {get; set;}
            
            /// 
            public string ActivitySubstatus {get; set;}
            
            /// Substatus of the operation  in display-friendly format. E.g. OK (HTTP Status Code: 200).
            public string ActivitySubstatusValue {get; set;}
            
            /// Resource group name of the impacted resource.
            public string ResourceGroup {get; set;}
            
            /// Subscription ID of the impacted resource.
            public string SubscriptionId {get; set;}
            
            /// Usually a GUID in the string format. Events that share a correlationId belong to the same uber action.
            public string CorrelationId {get; set;}
            
            /// GUID of the caller.
            public string Caller {get; set;}
            
            /// IP address of the user who has performed the operation UPN claim or SPN claim based on availability.
            public string CallerIpAddress {get; set;}
            
            /// 
            public string Category {get; set;}
            
            /// Category of the activity log e.g. Administrative, Policy, Security.
            public string CategoryValue {get; set;}
            
            /// Blob describing the Http Request. Usually includes the �clientRequestId�, �clientIpAddress� and �method� (HTTP method. For example, PUT).
            public string HTTPRequest {get; set;}
            
            /// Set of <Key Value> pairs (i.e. Dictionary) describing the details of the event. Stored as string. Usage of Properties_d is recommended instead.
            public string Properties {get; set;}
            
            /// Timestamp when the event became available for querying.
            public DateTime EventSubmissionTimestamp {get; set;}
            
            /// Blob of RBAC properties of the event. Usually includes the �action�, �role� and �scope� properties. Stored as string. The use of Authorization_d should be preferred going forward.
            public string Authorization {get; set;}
            
            /// 
            public string ResourceId {get; set;}
            
            /// GUID of the operation
            public string OperationId {get; set;}
            
            /// 
            public string ResourceProvider {get; set;}
            
            /// Id of the resource provider for the impacted resource - e.g. Microsoft.Storage.
            public string ResourceProviderValue {get; set;}
            
            /// 
            public string Resource {get; set;}
            
            /// Unique identifier of an event.
            public string EventDataId {get; set;}
            
            /// ID of the worksapce that stores this record
            public string TenantId {get; set;}
            
            /// Timestamp when the event was generated by the Azure service processing the request corresponding the event.
            public DateTime TimeGenerated {get; set;}
            
            /// Azure is used always for AzureActivity
            public string SourceSystem {get; set;}
            
            /// Blob of RBAC properties of the event. Usually includes the �action�, �role� and �scope� properties. Stored as dynamic column.
            public dynamic Authorization_d {get; set;}
            
            /// The JWT token used by Active Directory to authenticate the user or application to perform this operation in Resource Manager. The use of claims_d should be preferred going forward.
            public string Claims {get; set;}
            
            /// The JWT token used by Active Directory to authenticate the user or application to perform this operation in Resource Manager.
            public dynamic Claims_d {get; set;}
            
            /// Set of <Key Value> pairs (i.e. Dictionary) describing the details of the event. Stored as dynamic column.
            public dynamic Properties_d {get; set;}
            
            /// Management group hierarchy of the management group or subscription that event belongs to.
            public string Hierarchy {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
