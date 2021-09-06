

namespace FluentKusto
{
    public class WindowsFirewall
    {

        ///
        public string SourceSystem {get; set;}
        
        ///
        public string Computer {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string CommunicationDirection {get; set;}
        
        ///
        public string FirewallAction {get; set;}
        
        ///
        public string Protocol {get; set;}
        
        ///
        public string SourceIP {get; set;}
        
        ///
        public string DestinationIP {get; set;}
        
        ///
        public string RemoteIP {get; set;}
        
        ///
        public int SourcePort {get; set;}
        
        ///
        public string FullDestinationAddress {get; set;}
        
        ///
        public int DestinationPort {get; set;}
        
        ///
        public long RequestSizeInBytes {get; set;}
        
        ///
        public string Info {get; set;}
        
        ///
        public string ManagementGroupName {get; set;}
        
        ///
        public string MaliciousIP {get; set;}
        
        ///
        public string IndicatorThreatType {get; set;}
        
        ///
        public string Description {get; set;}
        
        ///
        public string TLPLevel {get; set;}
        
        ///
        public string Confidence {get; set;}
        
        ///
        public int Severity {get; set;}
        
        ///
        public string FirstReportedDateTime {get; set;}
        
        ///
        public string LastReportedDateTime {get; set;}
        
        ///
        public string IsActive {get; set;}
        
        ///
        public real MaliciousIPLongitude {get; set;}
        
        ///
        public real MaliciousIPLatitude {get; set;}
        
        ///
        public string MaliciousIPCountry {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
