
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ADXJournal : TableBase<ADXJournal>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The time (UTC) at which this log was sent to Log Analytics
            public DateTime TimeGenerated {get; set;}
            
            /// The client request ID
            public string CorrelationId {get; set;}
            
            /// The root activity ID of the operation which caused metadata change (for example: 2217ed0d-888f-4c3d-8776-973471be556e)
            public string RootActivityId {get; set;}
            
            /// The metadata change event name
            public string Event {get; set;}
            
            /// The timestamp (UTC) at which the metadata operation completed
            public DateTime OperationTimestamp {get; set;}
            
            /// The name of the database changed following the event
            public string DatabaseName {get; set;}
            
            /// The entity name that the operation was executed on, before the change
            public string EntityName {get; set;}
            
            /// The new entity name after the change
            public string UpdatedEntityName {get; set;}
            
            /// The version of the entity (entity properties) before the change
            public string OriginalEntityVersion {get; set;}
            
            /// The new metadata version (DB/cluster) following the change
            public string EntityVersion {get; set;}
            
            /// The entity container name (entity=column, container=table), or the database name
            public string EntityContainerName {get; set;}
            
            /// The state of the entity (entity properties) before the change
            public string OriginalEntityState {get; set;}
            
            /// The new state after the change
            public string UpdatedEntityState {get; set;}
            
            /// The executed control command that triggered the metadata change
            public string ChangeCommand {get; set;}
            
            /// The user that executed the control command
            public string User {get; set;}
            
            /// The principal (user/app) that executed the control command
            public string Principal {get; set;}
            
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
