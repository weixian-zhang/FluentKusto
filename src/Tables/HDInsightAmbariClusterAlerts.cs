
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class HDInsightAmbariClusterAlerts : TableBase<HDInsightAmbariClusterAlerts>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The URI to the alert.
            public string ReferenceURI {get; set;}
            
            /// The name of the cluster the alert came from.
            public string ClusterName {get; set;}
            
            /// The component that generated the alert.
            public string ComponentName {get; set;}
            
            /// Id of the alert definition.
            public int DefinitionId {get; set;}
            
            /// Name of the alert definition
            public string DefinitionName {get; set;}
            
            /// The firmness of the alert.
            public string AlertFirmness {get; set;}
            
            /// The FQDN of the host where the alert was generated.
            public string HostFQDN {get; set;}
            
            /// The name of the host where the alert was generated.
            public string HostName {get; set;}
            
            /// The ID of the alert message.
            public int AlertID {get; set;}
            
            /// Instance number of the alert.
            public string AlertInstance {get; set;}
            
            /// The label of the alert.
            public string Label {get; set;}
            
            /// The latest time the alert occurred.
            public long LatestTimestamp {get; set;}
            
            /// The timestamp the alert first occurred.
            public long OriginalTimestamp {get; set;}
            
            /// The maintenance classifaction state of the alert.
            public string MaintenanceState {get; set;}
            
            /// The number of times an alert has occurred.
            public int Occurences {get; set;}
            
            /// The total number of occurences an alert can have before being escalated.
            public int RepeatTolerance {get; set;}
            
            /// The amount of occurences left before an alert gets escalted.
            public int RepeatToleranceRemaining {get; set;}
            
            /// The scope of the alert.
            public string Scope {get; set;}
            
            /// The name of the service that generated the alert.
            public string ServiceName {get; set;}
            
            /// The state of the alert.
            public string State {get; set;}
            
            /// The informational text of the alert.
            public string Text {get; set;}
            
            /// The type of cluster where the alert was generated.
            public string ClusterType {get; set;}
            
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
