

namespace FluentKusto
{
    public class SecurityDetection
    {

        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string Computer {get; set;}
        
        ///
        public string Provider {get; set;}
        
        ///
        public string AlertTitle {get; set;}
        
        ///
        public string AlertSeverity {get; set;}
        
        ///
        public string Description {get; set;}
        
        ///
        public string RemediationSteps {get; set;}
        
        ///
        public string OriginalSeverity {get; set;}
        
        ///
        public string DetectionID {get; set;}
        
        ///
        public string SubjectUserName {get; set;}
        
        ///
        public string SubjectDomainName {get; set;}
        
        ///
        public string ProcessName {get; set;}
        
        ///
        public string CommandLine {get; set;}
        
        ///
        public string LogChannel {get; set;}
        
        ///
        public string Duration {get; set;}
        
        ///
        public int InvalidAccountsSeen {get; set;}
        
        ///
        public int ValidAccountsSeen {get; set;}
        
        ///
        public int SuccessfulLogins {get; set;}
        
        ///
        public int FailedAttempts {get; set;}
        
        ///
        public int AccountsSeen {get; set;}
        
        ///
        public string SuspiciousProcess {get; set;}
        
        ///
        public string FullPath {get; set;}
        
        ///
        public string ChildProcess {get; set;}
        
        ///
        public string ParentProcess {get; set;}
        
        ///
        public string ExtendedProperties {get; set;}
        
        ///
        public string SubscriptionId {get; set;}
        
        ///
        public string ServiceId {get; set;}
        
        ///
        public bool IsFirstParty {get; set;}
        
        ///
        public string ReportingSystem {get; set;}
        
        ///
        public string OccuringDatacenter {get; set;}
        
        ///
        public string AssociatedResource {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
