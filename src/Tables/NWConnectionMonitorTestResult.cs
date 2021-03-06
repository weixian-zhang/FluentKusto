
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class NWConnectionMonitorTestResult : TableBase<NWConnectionMonitorTestResult>
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
            
            /// The type of the source machine configured for the test
            public string SourceType {get; set;}
            
            /// The resource id of the source machine
            public string SourceResourceId {get; set;}
            
            /// The address of the source configured for the test
            public string SourceAddress {get; set;}
            
            /// The subnet of the source
            public string SourceSubnet {get; set;}
            
            /// The IP address of the source
            public string SourceIP {get; set;}
            
            /// The source end point name
            public string SourceName {get; set;}
            
            /// The source agent id
            public string SourceAgentId {get; set;}
            
            /// The destination port configured for the test
            public int DestinationPort {get; set;}
            
            /// The type of the destination machine configured for the test
            public string DestinationType {get; set;}
            
            /// The resource id of the Destination machine
            public string DestinationResourceId {get; set;}
            
            /// The address of the destination configured for the test
            public string DestinationAddress {get; set;}
            
            /// If applicable, the subnet of the destination
            public string DestinationSubnet {get; set;}
            
            /// The IP address of the destination
            public string DestinationIP {get; set;}
            
            /// The destination end point name
            public string DestinationName {get; set;}
            
            /// The destination agent id
            public string DestinationAgentId {get; set;}
            
            /// The protocol of the test
            public string Protocol {get; set;}
            
            /// The total number of checks done under the test
            public int ChecksTotal {get; set;}
            
            /// The total number of checks failed under the test
            public int ChecksFailed {get; set;}
            
            /// The result of the test
            public string TestResult {get; set;}
            
            /// The result criterion of the test
            public string TestResultCriterion {get; set;}
            
            /// The checks failed percent threshold set for the test
            public int ChecksFailedPercentThreshold {get; set;}
            
            /// The round trip threshold (ms) set for the test
            public float RoundTripTimeMsThreshold {get; set;}
            
            /// The minimum round trip time (ms) for the test
            public float MinRoundTripTimeMs {get; set;}
            
            /// The maximum round trip time for the test
            public float MaxRoundTripTimeMs {get; set;}
            
            /// The average round trip time for the test
            public float AvgRoundTripTimeMs {get; set;}
            
            /// The mean deviation round trip time for the test
            public float JitterMs {get; set;}
            
            /// The additional data for the test
            public string AdditionalData {get; set;}
            
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
