
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class Syslog : TableBase<Syslog>
    {

            /// Type of agent the data was collected from. For syslog the value is typically Linux.
            public string SourceSystem {get; set;}
            
            /// Date and time the record was created.
            public DateTime TimeGenerated {get; set;}
            
            /// Computer that the event was collected from.
            public string Computer {get; set;}
            
            /// Date and time that the event was generated.
            public DateTime EventTime {get; set;}
            
            /// The part of the system that generated the message.
            public string Facility {get; set;}
            
            /// Name of the system sending the message.
            public string HostName {get; set;}
            
            /// Severity level of the event.
            public string SeverityLevel {get; set;}
            
            /// Text of the message.
            public string SyslogMessage {get; set;}
            
            /// ID of the process that generated the message.
            public int ProcessID {get; set;}
            
            /// IP address of the system sending the message.
            public string HostIP {get; set;}
            
            /// Name of the process that generated the message.
            public string ProcessName {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
