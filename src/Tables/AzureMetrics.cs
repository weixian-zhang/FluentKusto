
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AzureMetrics : TableBase<AzureMetrics>
    {

            /// OpsManagerfor all records in this table.
            public string SourceSystem {get; set;}
            
            /// Date and time the record was created.
            public DateTime TimeGenerated {get; set;}
            
            /// Resource ID of the Azure resource reporting the metric. Same as _ResourceId present for backward compatibility reasons. _ResourceId should be used
            public string ResourceId {get; set;}
            
            /// Deprecated
            public string OperationName {get; set;}
            
            /// Deprecated
            public string OperationVersion {get; set;}
            
            /// Deprecated
            public string Category {get; set;}
            
            /// Reduces the set of data collected. The syntax allowed depends on the operation. See the operation's description for details.
            public string ResultType {get; set;}
            
            /// Deprecated
            public string ResultSignature {get; set;}
            
            /// Deprecated
            public string ResultDescription {get; set;}
            
            /// Deprecated
            public long DurationMs {get; set;}
            
            /// Deprecated
            public string CallerIpAddress {get; set;}
            
            /// Deprecated
            public string CorrelationId {get; set;}
            
            /// Resource name of the Azure resource reporting the metric.
            public string Resource {get; set;}
            
            /// Resource group name of the Azure resource reporting the metric.
            public string ResourceGroup {get; set;}
            
            /// Resource provider of the Azure resource reporting the metric.
            public string ResourceProvider {get; set;}
            
            /// Subscription id of the Azure resource reporting the metric.
            public string SubscriptionId {get; set;}
            
            /// Display name of the metric.
            public string MetricName {get; set;}
            
            /// Sum of all of the values in the time range.
            public float Total {get; set;}
            
            /// Number of samples collected during the time range. Can be used to determine the number of values that contributed to the average value.
            public float Count {get; set;}
            
            /// Maximum value collected during in the time range.
            public float Maximum {get; set;}
            
            /// Minimum value collected during in the time range.
            public float Minimum {get; set;}
            
            /// 
            public float Average {get; set;}
            
            /// Time grain of the metric e.g. PT1M
            public string TimeGrain {get; set;}
            
            /// Unit of the metric. Examples include Seconds Percent Bytes.
            public string UnitName {get; set;}
            
            /// Deprecated
            public string RemoteIPCountry {get; set;}
            
            /// Deprecated
            public float RemoteIPLatitude {get; set;}
            
            /// Deprecated
            public float RemoteIPLongitude {get; set;}
            
            /// Deprecated
            public string MaliciousIP {get; set;}
            
            /// Deprecated
            public string IndicatorThreatType {get; set;}
            
            /// Deprecated
            public string Description {get; set;}
            
            /// Deprecated
            public string TLPLevel {get; set;}
            
            /// Deprecated
            public string Confidence {get; set;}
            
            /// Deprecated
            public int Severity {get; set;}
            
            /// Deprecated
            public string FirstReportedDateTime {get; set;}
            
            /// Deprecated
            public string LastReportedDateTime {get; set;}
            
            /// Deprecated
            public string IsActive {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
