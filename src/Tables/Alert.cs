

namespace FluentKusto
{
    public class Alert
    {

        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string AlertPriority {get; set;}
        
        ///
        public string AlertSeverity {get; set;}
        
        ///
        public string SourceDisplayName {get; set;}
        
        ///
        public string SourceFullName {get; set;}
        
        ///
        public string AlertId {get; set;}
        
        ///
        public string AlertName {get; set;}
        
        ///
        public string AlertDescription {get; set;}
        
        ///
        public int RepeatCount {get; set;}
        
        ///
        public string AlertState {get; set;}
        
        ///
        public string ResolvedBy {get; set;}
        
        ///
        public string LastModifiedBy {get; set;}
        
        ///
        public datetime TimeRaised {get; set;}
        
        ///
        public datetime TimeResolved {get; set;}
        
        ///
        public datetime TimeLastModified {get; set;}
        
        ///
        public string AlertContext {get; set;}
        
        ///
        public string TicketId {get; set;}
        
        ///
        public string Custom1 {get; set;}
        
        ///
        public string Custom2 {get; set;}
        
        ///
        public string Custom3 {get; set;}
        
        ///
        public string Custom4 {get; set;}
        
        ///
        public string Custom5 {get; set;}
        
        ///
        public string Custom6 {get; set;}
        
        ///
        public string Custom7 {get; set;}
        
        ///
        public string Custom8 {get; set;}
        
        ///
        public string Custom9 {get; set;}
        
        ///
        public string Custom10 {get; set;}
        
        ///
        public string ManagementGroupName {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///
        public int PriorityNumber {get; set;}
        
        ///
        public string HostName {get; set;}
        
        ///
        public string StateType {get; set;}
        
        ///
        public datetime QueryExecutionStartTime {get; set;}
        
        ///
        public datetime QueryExecutionEndTime {get; set;}
        
        ///
        public string Query {get; set;}
        
        ///
        public string RemediationJobId {get; set;}
        
        ///
        public string RemediationRunbookName {get; set;}
        
        ///
        public string AlertRuleId {get; set;}
        
        ///
        public string AlertRuleInstanceId {get; set;}
        
        ///
        public string ThresholdOperator {get; set;}
        
        ///
        public int ThresholdValue {get; set;}
        
        ///
        public string LinkToSearchResults {get; set;}
        
        ///
        public string ServiceDeskConnectionName {get; set;}
        
        ///
        public string ServiceDeskId {get; set;}
        
        ///
        public string ServiceDeskWorkItemLink {get; set;}
        
        ///
        public string ServiceDeskWorkItemType {get; set;}
        
        ///
        public string ResourceId {get; set;}
        
        ///
        public string ResourceType {get; set;}
        
        ///
        public string ResourceValue {get; set;}
        
        ///
        public string RootObjectName {get; set;}
        
        ///
        public string ObjectDisplayName {get; set;}
        
        ///
        public string Computer {get; set;}
        
        ///
        public string AlertTypeDescription {get; set;}
        
        ///
        public int AlertTypeNumber {get; set;}
        
        ///
        public string AlertError {get; set;}
        
        ///
        public string StatusDescription {get; set;}
        
        ///
        public int AlertStatus {get; set;}
        
        ///
        public string TriggerId {get; set;}
        
        ///
        public string Url {get; set;}
        
        ///
        public string ValueDescription {get; set;}
        
        ///
        public int AlertValue {get; set;}
        
        ///
        public string Comments {get; set;}
        
        ///
        public string TemplateId {get; set;}
        
        ///
        public string FlagsDescription {get; set;}
        
        ///
        public int Flags {get; set;}
        
        ///
        public string ValueFlagsDescription {get; set;}
        
        ///
        public int ValueFlags {get; set;}
        
        ///
        public string Expression {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
