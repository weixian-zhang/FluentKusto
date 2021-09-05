

namespace FluentKusto
{
    public class HDInsightRangerAuditLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The operation associated with log record.
        public string OperationName {get; set;}
        
        ///The ID for correlated events. Can be used to identify correlated events between multiple tables.
        public string CorrelationId {get; set;}
        
        ///Name of cluster.
        public string ClusterName {get; set;}
        
        ///Name of host where log was emitted.
        public string HostName {get; set;}
        
        ///Type of the cluster that emitted the record.
        public string ClusterType {get; set;}
        
        ///Integer representing the repo type.
        public int RepoType {get; set;}
        
        ///Name the repo.
        public string Repo {get; set;}
        
        ///Username associated with the event.
        public string RequestUser {get; set;}
        
        ///Name of the access method.
        public string AccessName {get; set;}
        
        ///Resource involved in request event.
        public string ClusterResource {get; set;}
        
        ///The type of resource accessed.
        public string ClusterResourceType {get; set;}
        
        ///Type of action made by the event.
        public string Action {get; set;}
        
        ///Status code of the event result.
        public int Result {get; set;}
        
        ///Code representing the policy.
        public int Policy {get; set;}
        
        ///Name of the policy enforcer.
        public string Enforcer {get; set;}
        
        ///Source that provides the request data.
        public string RequestData {get; set;}
        
        ///ID associated witht the user session.
        public string SessionId {get; set;}
        
        ///Type of CLI used to create request.
        public string CliType {get; set;}
        
        ///IP address of where CLI request was made.
        public string CliIpAddress {get; set;}
        
        ///Type of log the record came from.
        public string LogType {get; set;}
        
        ///ID of the event request.
        public string Id {get; set;}
        
        ///Sequence number of the event.
        public int SequenceNumber {get; set;}
        
        ///Number of events associated with the request.
        public int EventCount {get; set;}
        
        ///Duration of the event in milliseconds.
        public int EventDurationMs {get; set;}
        
        ///List of tags associated with the event.
        public string Tags {get; set;}
        
        ///Additional info about the request including the remote and forwarded IPs
        public string AdditionalInfo {get; set;}
        
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
