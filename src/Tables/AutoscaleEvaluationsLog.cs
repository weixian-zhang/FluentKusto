

namespace FluentKusto
{
    public class AutoscaleEvaluationsLog
    {

        ///
        public string SourceSystem {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
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
        public datetime MetricEndTime {get; set;}
        
        ///
        public string EstimateScaleResult {get; set;}
        
        ///
        public string EvaluationResult {get; set;}
        
        ///
        public datetime EvaluationTime {get; set;}
        
        ///
        public string LastScaleActionOperationId {get; set;}
        
        ///
        public string LastScaleActionOperationStatus {get; set;}
        
        ///
        public datetime LastScaleActionTime {get; set;}
        
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
        public real ObservedValue {get; set;}
        
        ///
        public string Operator {get; set;}
        
        ///
        public string Profile {get; set;}
        
        ///
        public datetime ProfileEvaluationTime {get; set;}
        
        ///
        public bool ProfileSelected {get; set;}
        
        ///
        public real Projection {get; set;}
        
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
        public datetime MetricStartTime {get; set;}
        
        ///
        public real Threshold {get; set;}
        
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
        
        ///The name of the table
        public string Type {get; set;}
            }
}
