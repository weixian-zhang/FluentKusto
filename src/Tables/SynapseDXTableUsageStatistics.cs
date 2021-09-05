

namespace FluentKusto
{
    public class SynapseDXTableUsageStatistics
    {

        ///
        public string TenantId {get; set;}
        
        ///The time (UTC) this event was generated
        public datetime TimeGenerated {get; set;}
        
        ///The client request ID
        public string CorrelationId {get; set;}
        
        ///The root activity ID
        public string RootActivityId {get; set;}
        
        ///The time (UTC) the table usage statistics operation started
        public datetime StartedOn {get; set;}
        
        ///Name of the database
        public string DatabaseName {get; set;}
        
        ///Name of the table
        public string TableName {get; set;}
        
        ///Earliest extent time of the table
        public datetime MinCreatedOn {get; set;}
        
        ///Lastest extent time of the table
        public datetime MaxCreatedOn {get; set;}
        
        ///The name of the application that invoked the command
        public string ApplicationName {get; set;}
        
        ///User that invoked the query
        public string User {get; set;}
        
        ///Principal that invoked the query like 'aaduser=USER_ID;TENANT'
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
