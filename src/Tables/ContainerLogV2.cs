

namespace FluentKusto
{
    public class ContainerLogV2
    {

        ///
        public string TenantId {get; set;}
        
        ///Name of the Computer/Node generating the log.
        public string Computer {get; set;}
        
        ///Container ID of the log source as seen by the Container engine.
        public string ContainerId {get; set;}
        
        ///Name of the Container generating the log.
        public string ContainerName {get; set;}
        
        ///Kubernetes Pod name for the Container generating the log.
        public string PodName {get; set;}
        
        ///Kubernetes Namespace for the container's pod.
        public string PodNamespace {get; set;}
        
        ///Log message from stdout or stderr. Being a dynmic field, json log messages can be queried without parse_json.
        public dynamic LogMessage {get; set;}
        
        ///Source of the Log message. Possible vlaues are stdout or stderr.
        public string LogSource {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
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
