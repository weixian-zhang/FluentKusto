
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class HDInsightStormTopologyMetrics : TableBase<HDInsightStormTopologyMetrics>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The number of Tuple �trees� successfully processed. A value of 0 is expected if no acking is done.
            public float Acked {get; set;}
            
            /// Percent of CPU cores assigned to the topology.
            public float AssignedCPUPercent {get; set;}
            
            /// MB of off heap memory assigned to the topology.
            public float AssignedMemOffHeapMB {get; set;}
            
            /// MB of on heap memory assigned to the topology.
            public float AssignedMemOnHeapMB {get; set;}
            
            /// MB of total memory assigned to the topology.
            public float AssignedTotalMemMB {get; set;}
            
            /// The ID of the bolt.
            public string BoltId {get; set;}
            
            /// If this is around 1.0, the corresponding Bolt is running as fast as it can, so you may want to increase the Bolt�s parallelism. This is (number executed * average execute latency) / measurement time.
            public float Capacity {get; set;}
            
            /// The name of the cluster.
            public string ClusterName {get; set;}
            
            /// The type of the cluster.
            public string ClusterType {get; set;}
            
            /// The average time (millisecond) a Tuple �tree� takes to be completely processed by the Topology. A value of 0 is expected if no acking is done.
            public float CompleteLatencyMs {get; set;}
            
            /// The ID for correlated events. Can be used to identify correlated events between multiple tables.
            public string CorrelationId {get; set;}
            
            /// Boolean representing whether debug tracing is activated.
            public bool Debug {get; set;}
            
            /// The number of Tuples emitted.
            public float Emitted {get; set;}
            
            /// The encoded ID of the bolt.
            public string EncodedBoltId {get; set;}
            
            /// The enocded ID of the topology.
            public string EncodedId {get; set;}
            
            /// The encoded ID of the Spout.
            public string EncodedSpoutId {get; set;}
            
            /// Host where the error occurred.
            public string ErrorHost {get; set;}
            
            /// Port associated with the error.
            public string ErrorPort {get; set;}
            
            /// Link to the log of the worker where an error occurred.
            public string ErrorWorkerLogLink {get; set;}
            
            ///  The number of incoming Tuples processed.
            public float Executed {get; set;}
            
            /// The average time (millisecond) a Tuple spends in the execute method. The execute method may complete without sending an Ack for the tuple.
            public float ExecuteLatencyMs {get; set;}
            
            /// The number of threads being used to execute a task.
            public int Executors {get; set;}
            
            /// The total amount of executors currently used and already used to execute a task.
            public int ExecutorsTotal {get; set;}
            
            /// The number of Tuple �trees� that were explicitly failed or timed out before acking was completed. A value of 0 is expected if no acking is done.
            public float Failed {get; set;}
            
            /// Hostname of the host the record came from.
            public string HostName {get; set;}
            
            /// The name of the component the record is from (could be spout, bolt, or name of topology).
            public string Id {get; set;}
            
            /// Type of record shape (there are bolt, spout, topology, and topology_stats record shapes).
            public string InstanceName {get; set;}
            
            /// Last error to occur in the component.
            public string LastError {get; set;}
            
            /// The number of seconds until a message times out.
            public float MsgTimeout {get; set;}
            
            /// Name of the topology.
            public string TopologyName {get; set;}
            
            /// The operation associated with log record.
            public string OperationName {get; set;}
            
            /// Name of the user that owns the topology.
            public string Owner {get; set;}
            
            /// The average time (millisecond) it takes to Ack a Tuple after it is first received. Bolts that join, aggregate or batch may not Ack a tuple until a number of other Tuples have been received(.
            public float ProcessLatencyMs {get; set;}
            
            /// The amount of replicas kept by the topology.
            public int ReplicationCount {get; set;}
            
            /// The percent of CPU requested by the topology.
            public float RequestedCpuPercent {get; set;}
            
            /// MB of off heap memory requested by the topology.
            public float RequestMemOffHeapMB {get; set;}
            
            /// MB of on heap memory requested by the topology.
            public float RequestMemOnHeapMB {get; set;}
            
            /// Percentage of messages sampled to calculate metrics.
            public float SamplingPct {get; set;}
            
            /// Boolean describing the scheduler display setting.
            public bool SchedulerDisplayResource {get; set;}
            
            /// The ID of the spout.
            public string SpoutId {get; set;}
            
            /// The status of the topology.
            public string Status {get; set;}
            
            /// The number of tasks running.
            public int Tasks {get; set;}
            
            /// The total amount of tasks run.
            public int TasksTotal {get; set;}
            
            /// The ID of the topology.
            public string TopologyId {get; set;}
            
            /// The number of Tuples emitted that sent to one or more bolts.
            public float Transferred {get; set;}
            
            /// The length of time an Executor (thread) has been alive.
            public string Uptime {get; set;}
            
            /// The amount of time the topology has been running in seconds.
            public float UptimeSeconds {get; set;}
            
            /// The time window for the metrics in the record in seconds.
            public float Window {get; set;}
            
            /// The time window for the metrics in the record in hours, minutes, seconds format.
            public string WindowHint {get; set;}
            
            /// String description of the time window for the metrics in the record.
            public string WindowPretty {get; set;}
            
            /// JSON with worker specific metrics.
            public string Workers {get; set;}
            
            /// The total amount of workers.
            public int WorkersTotal {get; set;}
            
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
