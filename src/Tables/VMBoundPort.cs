
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class VMBoundPort : TableBase<VMBoundPort>
    {

            /// Date and time the record was created.
            public DateTime TimeGenerated {get; set;}
            
            /// Name of the server
            public string Computer {get; set;}
            
            /// Unique identifier for the process in the ServiceMapProcess_CL table.
            public string ProcessName {get; set;}
            
            /// Port IP address. Can be wildcard IP 0.0.0.0.
            public string Ip {get; set;}
            
            /// Port number.
            public int Port {get; set;}
            
            /// The protocol. Example tcp or udp (only tcp is currently supported).
            public string Protocol {get; set;}
            
            /// Specifies whether connection made as a wildcard bind request.
            public bool IsWildcardBind {get; set;}
            
            /// Bytes sent on the port
            public long BytesSent {get; set;}
            
            /// Bytes received on the port
            public long BytesReceived {get; set;}
            
            /// Count of live links at the end of the time period recorded.
            public long LinksLive {get; set;}
            
            /// Count of terminated links over the time periof recorded.
            public long LinksTerminated {get; set;}
            
            /// Count of links established on the port.
            public long LinksEstablished {get; set;}
            
            /// Count of responses in the time period recorded.
            public long Responses {get; set;}
            
            /// Measurement of the total time between first and last byte received
            public long ResponseTimeSum {get; set;}
            
            /// Measurement of the minimum time between first and last byte received.
            public long ResponseTimeMin {get; set;}
            
            /// Measurement of the maximum time between first and last byte received.
            public long ResponseTimeMax {get; set;}
            
            /// Port ID.
            public string PortId {get; set;}
            
            /// Unique identifier to the machine in the ServiceMapComputer_CL table.
            public string Machine {get; set;}
            
            /// Identity of the process or group of processes that the port is associated with.
            public string Process {get; set;}
            
            /// Unique agent GUID for the agent reporting data on the server.
            public string AgentId {get; set;}
            
            /// Value is OpsManager for all records.
            public string SourceSystem {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
