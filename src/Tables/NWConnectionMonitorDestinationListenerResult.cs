
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class NWConnectionMonitorDestinationListenerResult : TableBase<NWConnectionMonitorDestinationListenerResult>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The record id for unique identification of test result record
            public string RecordId {get; set;}
            
            /// The connection monitor resource id of the test
            public string ConnectionMonitorResourceId {get; set;}
            
            /// The test group name to which the test belongs to
            public string TestGroupName {get; set;}
            
            /// The test configuration name to which the test belongs to
            public string TestConfigurationName {get; set;}
            
            /// The Destination port configured for the test
            public int DestinationPort {get; set;}
            
            /// The type of the destination machine configured for the test
            public string DestinationType {get; set;}
            
            /// The resource id of the Destination machine
            public string DestinationResourceId {get; set;}
            
            /// The address of the destination configured for the test
            public string DestinationAddress {get; set;}
            
            /// If applicable, the subnet of the destination configured for the test
            public string DestinationSubnet {get; set;}
            
            /// The IP address of the destination
            public string DestinationIP {get; set;}
            
            /// The destination end point name
            public string DestinationName {get; set;}
            
            /// The destination agent id
            public string DestinationAgentId {get; set;}
            
            /// The protocol of the test
            public string Protocol {get; set;}
            
            /// The listening outcome result
            public string ListeningOutcome {get; set;}
            
            /// The issues identfied by Destination Listener
            public string Issues {get; set;}
            
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
