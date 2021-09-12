
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ContainerLog : TableBase<ContainerLog>
    {

            /// Deprecated.
            public string SourceSystem {get; set;}
            
            /// Date and time the record was created.
            public DateTime TimeGenerated {get; set;}
            
            /// Computer/node that's generating the log.
            public string Computer {get; set;}
            
            /// Time that the agent processed the log. This is an optional field mainly useful for troubleshooting latency issues on the agent.
            public DateTime TimeOfCommand {get; set;}
            
            /// Container ID for log source as seen by Docker engine.
            public string ContainerID {get; set;}
            
            /// Container Image for log source as seen by Docker engine.
            public string Image {get; set;}
            
            /// Used by Container solution only. Not populated by Azure Monitor for Containers.
            public string ImageTag {get; set;}
            
            /// Used by Container solution only. Not populated by Azure Monitor for Containers.
            public string Repository {get; set;}
            
            /// Unique name of the container the form  PODUid/ContainerName.
            public string Name {get; set;}
            
            /// Actual log line.
            public string LogEntry {get; set;}
            
            /// Source of the log line. Possible values are stdout or stderr.
            public string LogEntrySource {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
