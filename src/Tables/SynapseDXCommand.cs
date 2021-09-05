

namespace FluentKusto
{
    public class SynapseDXCommand
    {

        ///
        public string TenantId {get; set;}
        
        ///The time (UTC) when this event was generated
        public datetime TimeGenerated {get; set;}
        
        ///The log category for these events will be 'Command'
        public string Category {get; set;}
        
        ///The client request ID
        public string CorrelationId {get; set;}
        
        ///The root activity ID
        public string RootActivityId {get; set;}
        
        ///The time (UTC) when this command started
        public datetime StartedOn {get; set;}
        
        ///The last time this command was updated
        public datetime LastUpdatedOn {get; set;}
        
        ///The name of the database the command ran on
        public string DatabaseName {get; set;}
        
        ///The state the command ended with, like 'Completed'
        public string State {get; set;}
        
        ///The reason for the failure
        public string FailureReason {get; set;}
        
        ///Total CPU runtime across cluster nodes
        public string TotalCPU {get; set;}
        
        ///Command type. like 'DatabasesShow'
        public string CommandType {get; set;}
        
        ///The name of the application that invoked the command
        public string ApplicationName {get; set;}
        
        ///Resurce consumption for the exuected command
        public dynamic ResourceUtilization {get; set;}
        
        ///Command duration as a string like '00:00:00.0156250'
        public string Duration {get; set;}
        
        ///User that invoked the query
        public string User {get; set;}
        
        ///Principal that invoked the query like 'aaduser=USER_ID;TENANT'
        public string Principal {get; set;}
        
        ///Workload are a means of resource governance for incoming requests to the cluster
        public string WorkloadGroup {get; set;}
        
        ///Text of the invoked command
        public string Text {get; set;}
        
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
