

namespace FluentKusto
{
    public class ADXTableUsageStatistics
    {

        ///
        public string TenantId {get; set;}
        
        ///The time (UTC) at which this event was generated
        public datetime TimeGenerated {get; set;}
        
        ///The name of this operation
        public string OperationName {get; set;}
        
        ///The client request id
        public string CorrelationId {get; set;}
        
        ///The root activity id
        public string RootActivityId {get; set;}
        
        ///Time (UTC) at which table usage statistics operation started
        public datetime StartedOn {get; set;}
        
        ///The name of the database
        public string DatabaseName {get; set;}
        
        ///The name of the table
        public string TableName {get; set;}
        
        ///Oldest extent time of the table
        public datetime MinCreatedOn {get; set;}
        
        ///Lastest extent time of the table
        public datetime MaxCreatedOn {get; set;}
        
        ///application name invoked the command
        public string ApplicationName {get; set;}
        
        ///The user that invoked the query
        public string User {get; set;}
        
        ///The principal that invoked the query
        public string Principal {get; set;}
        
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
