
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AutoscaleEvaluationsLog : TableBase<AutoscaleEvaluationsLog>
    {

            /// 
            public string SourceSystem {get; set;}
            
            /// 
            public DateTime TimeGenerated {get; set;}
            
            /// 
            public string ResourceId {get; set;}
            
            /// 
            public string OperationName {get; set;}
            
            /// 
            public string Category {get; set;}
            
            /// 
            public string ResultType {get; set;}
            
            /// 
            public string ResultDescription {get; set;}
            
            /// 
            public string CorrelationId {get; set;}
            
            /// 
            public string TargetResourceId {get; set;}
            
            /// 
            public string AvailabilitySet {get; set;}
            
            /// 
            public string CloudServiceName {get; set;}
            
            /// 
            public int CoolDown {get; set;}
            
            /// 
            public int CurrentInstanceCount {get; set;}
            
            /// 
            public string MetricData {get; set;}
            
            /// 
            public int DefaultInstanceCount {get; set;}
            
            /// 
            public string DeploymentSlot {get; set;}
            
            /// 
            public DateTime MetricEndTime {get; set;}
            
            /// 
            public string EstimateScaleResult {get; set;}
            
            /// 
            public string EvaluationResult {get; set;}
            
            /// 
            public DateTime EvaluationTime {get; set;}
            
            /// 
            public string LastScaleActionOperationId {get; set;}
            
            /// 
            public string LastScaleActionOperationStatus {get; set;}
            
            /// 
            public DateTime LastScaleActionTime {get; set;}
            
            /// 
            public int MaximumInstanceCount {get; set;}
            
            /// 
            public string AutoscaleMetricName {get; set;}
            
            /// 
            public string MetricNamespace {get; set;}
            
            /// 
            public int MinimumInstanceCount {get; set;}
            
            /// 
            public int NewInstanceCount {get; set;}
            
            /// 
            public float ObservedValue {get; set;}
            
            /// 
            public string Operator {get; set;}
            
            /// 
            public string Profile {get; set;}
            
            /// 
            public DateTime ProfileEvaluationTime {get; set;}
            
            /// 
            public bool ProfileSelected {get; set;}
            
            /// 
            public float Projection {get; set;}
            
            /// 
            public string InstanceUpdateReason {get; set;}
            
            /// 
            public string CloudServiceRole {get; set;}
            
            /// 
            public string SelectedAutoscaleProfile {get; set;}
            
            /// 
            public string ServerFarm {get; set;}
            
            /// 
            public bool ShouldUpdateInstance {get; set;}
            
            /// 
            public bool SkipCurrentAutoscaleEvaluation {get; set;}
            
            /// 
            public bool SkipRuleEvaluationForCooldown {get; set;}
            
            /// 
            public DateTime MetricStartTime {get; set;}
            
            /// 
            public float Threshold {get; set;}
            
            /// 
            public string TimeAggregationType {get; set;}
            
            /// 
            public string MetricTimeGrain {get; set;}
            
            /// 
            public string TimeGrainStatistic {get; set;}
            
            /// 
            public string TimeWindow {get; set;}
            
            /// 
            public string Webspace {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
                }
}
