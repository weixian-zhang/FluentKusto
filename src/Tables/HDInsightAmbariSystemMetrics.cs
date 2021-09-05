

namespace FluentKusto
{
    public class HDInsightAmbariSystemMetrics
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///Percent of CPU time spent in idle state in past cycle.
        public real CpuIdle {get; set;}
        
        ///Percent of CPU time spent running processes with positive nice values.
        public real CpuNice {get; set;}
        
        ///Number of CPU cores running on the node.
        public real NumberOfCpu {get; set;}
        
        ///Percent of CPU time spent running system level processes in past cycle.
        public real CpuSystem {get; set;}
        
        ///Percent of CPU time spent running user level processes in past cycle.
        public real CpuUser {get; set;}
        
        ///Percent of CPU time spent waiting for I/O requests in past cycle.
        public real CpuIOWait {get; set;}
        
        ///Amount of free disk space (in GB).
        public real DiskFree {get; set;}
        
        ///Total disk space (in GB).
        public real DiskTotal {get; set;}
        
        ///Number of bytes read.
        public real ReadBytes {get; set;}
        
        ///Number of read operations.
        public real ReadCount {get; set;}
        
        ///Time spent on read operations.
        public real ReadTime {get; set;}
        
        ///Number of bytes written.
        public real WriteBytes {get; set;}
        
        ///Number of write operations.
        public real WriteCount {get; set;}
        
        ///Time spent on write operations.
        public real WriteTime {get; set;}
        
        ///load over past 15 minutes.
        public real FifteenMinutLoad {get; set;}
        
        ///load over past five minutes.
        public real FiveMinuteLoad {get; set;}
        
        ///load over past one minute.
        public real OneMinuteLoad {get; set;}
        
        ///amount of cached memory in KB.
        public real CachedMemory {get; set;}
        
        ///amount of free memory in KB.
        public real FreeMemory {get; set;}
        
        ///amount of sharedmemory in KB.
        public real SharedMemory {get; set;}
        
        ///total amount of memory in KB.
        public real TotalMemory {get; set;}
        
        ///amount of free swap memory in KB.
        public real FreeSwapMemory {get; set;}
        
        ///Bytes ingested in last timeframe.
        public real BytesIn {get; set;}
        
        ///Bytes sent out.
        public real BytesOut {get; set;}
        
        ///Packets ingest in last timeframe.
        public real PacketsIn {get; set;}
        
        ///Packets sent out in last timeframe.
        public real PacketsOut {get; set;}
        
        ///Processes run in last timeframe.
        public real ProcessesRun {get; set;}
        
        ///Total amount of processes run on host.
        public real TotalProcesses {get; set;}
        
        ///Name of the cluster the host belongs to.
        public string ClusterName {get; set;}
        
        ///Name of the host the record came from.
        public string HostName {get; set;}
        
        ///Type of cluster the record came from.
        public string ClusterType {get; set;}
        
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
