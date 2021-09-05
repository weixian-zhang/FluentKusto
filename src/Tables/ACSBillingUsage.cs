

namespace FluentKusto
{
    public class ACSBillingUsage
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The operation associated with log record.
        public string OperationName {get; set;}
        
        ///The ID for correlated events. Can be used to identify correlated events between multiple tables.
        public string CorrelationId {get; set;}
        
        ///The API-version associated with the operation, if the operationName was performed using an API. If there is no API that corresponds to this operation, the version represents the version of that operation in case the properties associated with the operation change in the future.
        public string OperationVersion {get; set;}
        
        ///The log category of the event. Category is the granularity at which you can enable or disable logs on a particular resource. The properties that appear within the properties blob of an event are the same within a particular log category and resource type.
        public string Category {get; set;}
        
        ///The unique id for a given usage record.
        public string RecordId {get; set;}
        
        ///The type of resource being consumed.
        public string UsageType {get; set;}
        
        ///The unit in which the type of usage is measured
        public string UnitType {get; set;}
        
        ///The amount of usage in terms of the specified unit.
        public real Quantity {get; set;}
        
        ///Time when the resource consumption started.
        public datetime StartTime {get; set;}
        
        ///The time when resource consumption ended. Optional, as some events are instant by nature.
        public datetime EndTime {get; set;}
        
        ///User id consuming the resource.
        public string UserIdA {get; set;}
        
        ///User id consuming the resource for consumables involving two users.
        public string UserIdB {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
