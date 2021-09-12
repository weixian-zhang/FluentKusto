
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class HDInsightAmbariSystemMetrics : TableBase<HDInsightAmbariSystemMetrics>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// Percent of CPU time spent in idle state in past cycle.
            public float CpuIdle {get; set;}
            
            /// Percent of CPU time spent running processes with positive nice values.
            public float CpuNice {get; set;}
            
            /// Number of CPU cores running on the node.
            public float NumberOfCpu {get; set;}
            
            /// Percent of CPU time spent running system level processes in past cycle.
            public float CpuSystem {get; set;}
            
            /// Percent of CPU time spent running user level processes in past cycle.
            public float CpuUser {get; set;}
            
            /// Percent of CPU time spent waiting for I/O requests in past cycle.
            public float CpuIOWait {get; set;}
            
            /// Amount of free disk space (in GB).
            public float DiskFree {get; set;}
            
            /// Total disk space (in GB).
            public float DiskTotal {get; set;}
            
            /// Number of bytes read.
            public float ReadBytes {get; set;}
            
            /// Number of read operations.
            public float ReadCount {get; set;}
            
            /// Time spent on read operations.
            public float ReadTime {get; set;}
            
            /// Number of bytes written.
            public float WriteBytes {get; set;}
            
            /// Number of write operations.
            public float WriteCount {get; set;}
            
            /// Time spent on write operations.
            public float WriteTime {get; set;}
            
            /// load over past 15 minutes.
            public float FifteenMinutLoad {get; set;}
            
            /// load over past five minutes.
            public float FiveMinuteLoad {get; set;}
            
            /// load over past one minute.
            public float OneMinuteLoad {get; set;}
            
            /// amount of cached memory in KB.
            public float CachedMemory {get; set;}
            
            /// amount of free memory in KB.
            public float FreeMemory {get; set;}
            
            /// amount of sharedmemory in KB.
            public float SharedMemory {get; set;}
            
            /// total amount of memory in KB.
            public float TotalMemory {get; set;}
            
            /// amount of free swap memory in KB.
            public float FreeSwapMemory {get; set;}
            
            /// Bytes ingested in last timeframe.
            public float BytesIn {get; set;}
            
            /// Bytes sent out.
            public float BytesOut {get; set;}
            
            /// Packets ingest in last timeframe.
            public float PacketsIn {get; set;}
            
            /// Packets sent out in last timeframe.
            public float PacketsOut {get; set;}
            
            /// Processes run in last timeframe.
            public float ProcessesRun {get; set;}
            
            /// Total amount of processes run on host.
            public float TotalProcesses {get; set;}
            
            /// Name of the cluster the host belongs to.
            public string ClusterName {get; set;}
            
            /// Name of the host the record came from.
            public string HostName {get; set;}
            
            /// Type of cluster the record came from.
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
