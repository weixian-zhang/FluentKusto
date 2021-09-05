

namespace FluentKusto
{
    public class HDInsightSparkTaskEvents
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The application ID of the application producing the record.
        public string ApplicationId {get; set;}
        
        ///The ID of the stage associated with the task.
        public string StageId {get; set;}
        
        ///The ID of the task.
        public string TaskId {get; set;}
        
        ///The ID of task attempt.
        public string AttemptId {get; set;}
        
        ///The ID executor.
        public string ExecutorId {get; set;}
        
        ///The time (UTC) the task was launched.
        public datetime LaunchTime {get; set;}
        
        ///The time (UTC) the task finished.
        public datetime FinishTime {get; set;}
        
        ///Boolean describing whether the task failed.
        public bool Failed {get; set;}
        
        ///Boolean describing whether the task was killed.
        public bool Killed {get; set;}
        
        ///Reason why the task ended.
        public string EndReason {get; set;}
        
        ///The task type.
        public string TaskType {get; set;}
        
        ///The number of disk bytes spilled.
        public long DiskBytesSpilled {get; set;}
        
        ///The CPU time consumed by the task executor.
        public long ExecutorCPUTime {get; set;}
        
        ///The CPU time the task executor spent deserializing.
        public long ExecutorDeserializeCPUTime {get; set;}
        
        ///The time the task executor spent deserializing.
        public long ExecutorDeserializeTime {get; set;}
        
        ///The time task executor spent running.
        public long ExecutorRunTime {get; set;}
        
        ///The time the JVM spent garbage collecting.
        public long JvmGcTime {get; set;}
        
        ///The bytes of memory spilled.
        public long MemoryBytesSpilled {get; set;}
        
        ///The serialization time spent while getting the result.
        public long ResultSerializationTime {get; set;}
        
        ///Size of the result.
        public long ResultSize {get; set;}
        
        ///The metrics associated with shuffle reads.
        public long ShuffleReadMetrics {get; set;}
        
        ///The metrics associated with shuffle writes.
        public long ShuffleWriteMetrics {get; set;}
        
        ///The metrics associated with the task input.
        public long InputMetrics {get; set;}
        
        ///The metrics associated with the task output.
        public long OutputMetrics {get; set;}
        
        ///The number of updated blocks.
        public long UpdatedBlocks {get; set;}
        
        ///The peak amount of memory used during execution.
        public long PeakExecutionMemory {get; set;}
        
        ///The amount of delay the scheduler experienced.
        public long SchedulerDelay {get; set;}
        
        ///The number of records read during the task.
        public long RecordsRead {get; set;}
        
        ///The number bytes read during the task.
        public long BytesRead {get; set;}
        
        ///The number of records written by the task.
        public long RecordsWritten {get; set;}
        
        ///The number of bytes written by the task.
        public long BytesWritten {get; set;}
        
        ///The time spent waitng for fetching.
        public long ShuffleFetchWaitTime {get; set;}
        
        ///The number bytes read during the shuffle task.
        public long ShuffleTotalBytesRead {get; set;}
        
        ///The number of blocks fethced during the shuffle task.
        public long ShuffleTotalBlocksFetched {get; set;}
        
        ///The number of local blocks fethced during the shuffle task.
        public long ShuffleLocalBlocksFetched {get; set;}
        
        ///The number of remote blocks fethced during the shuffle task.
        public long ShuffleRemoteBlocksFetched {get; set;}
        
        ///The time spent writing during the shuffle task.
        public long ShuffleWriteTime {get; set;}
        
        ///The bytes written during the shuffle task.
        public long ShuffleBytesWritten {get; set;}
        
        ///The number of records written during the shuffle task.
        public long ShuffleRecordsWritten {get; set;}
        
        ///The number updated block statuses during the task.
        public long NumUpdatedBlockStatuses {get; set;}
        
        ///The tenant ID of the cluster running the task.
        public string ClusterTenantId {get; set;}
        
        ///The type of node running the task.
        public string Role {get; set;}
        
        ///The FQDN of the host running the task.
        public string Host {get; set;}
        
        ///The DNS name of the cluster running the task.
        public string ClusterDnsName {get; set;}
        
        ///The region of the cluster running the task.
        public string Region {get; set;}
        
        ///The IP Address of the node running the task.
        public string IpAddress {get; set;}
        
        ///The subscription ID of the cluster running the task
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
