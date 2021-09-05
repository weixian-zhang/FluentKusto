

namespace FluentKusto
{
    public class HDInsightSparkStageTaskAccumulables
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The application ID of the application producing the record.
        public string ApplicationId {get; set;}
        
        ///The name of the entity being described.
        public string Entity {get; set;}
        
        ///The ID of the entity.
        public string EntityId {get; set;}
        
        ///The ID of the parent entity.
        public string ParentId {get; set;}
        
        ///The ID of the metric.
        public string MetricId {get; set;}
        
        ///The name of the metric.
        public string MetricName {get; set;}
        
        ///The value of the metric.
        public long MetricValue {get; set;}
        
        ///The tenant ID of the cluster where the metric was collected.
        public string ClusterTenantId {get; set;}
        
        ///The type of node where the metric was collected.
        public string Role {get; set;}
        
        ///The FQDN of the host where the metric was collected.
        public string Host {get; set;}
        
        ///The DNS name of the cluster where the metric was collected.
        public string ClusterDnsName {get; set;}
        
        ///The region of the cluster where the metric was collected.
        public string Region {get; set;}
        
        ///The IP Address of the node where the metric was collected.
        public string IpAddress {get; set;}
        
        ///The subscription ID of the cluster where the metric was collected.
        public string UserSubscriptionId {get; set;}
        
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
