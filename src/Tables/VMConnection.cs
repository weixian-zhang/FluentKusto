

namespace FluentKusto
{
    public class VMConnection
    {

        ///Date and time the record was created.
        public datetime TimeGenerated {get; set;}
        
        ///Name of the server from the ServiceMapComputer_CL table.
        public string Computer {get; set;}
        
        ///Direction of the connection value is inbound or outbound
        public string Direction {get; set;}
        
        ///Unique identifier for the process in the ServiceMapProcess_CL table.
        public string ProcessName {get; set;}
        
        ///IP address of the source.
        public string SourceIp {get; set;}
        
        ///IP address of the destination.
        public string DestinationIp {get; set;}
        
        ///Port number of the destination.
        public int DestinationPort {get; set;}
        
        ///Protocol used for the connection. Only possible value is tcp.
        public string Protocol {get; set;}
        
        ///The IP address of the remote end of a connection is included in the RemoteIp property. For inbound connections RemoteIp is the same as SourceIp while for outbound connections it is the same as DestinationIp.
        public string RemoteIp {get; set;}
        
        ///A JSON array of DNS questions (lookups) that were performed on the machine and resolved to the RemoteIp listed in the record.
        public string RemoteDnsQuestions {get; set;}
        
        ///A JSON array of canonical names that came back from the DNS server. For example when using traffic manager you issue a question to foo.trafficmanage.net and get a canonical name as something.myservice.com together with an ip address.
        public string RemoteDnsCanonicalNames {get; set;}
        
        ///A classification of the remote endpoint based on its ip and dns names and the corresponding Azure service.
        public string RemoteClassification {get; set;}
        
        ///Geolocation longitude. An example would be -122.12.
        public real RemoteLongitude {get; set;}
        
        ///Geolocation latitude. An example would be 47.68.
        public real RemoteLatitude {get; set;}
        
        ///Name of the country or region hosting RemoteIp.
        public string RemoteCountry {get; set;}
        
        ///Total number of bytes that have been sent during the reporting time window.
        public long BytesSent {get; set;}
        
        ///Total number of bytes that have been received during the reporting time window.
        public long BytesReceived {get; set;}
        
        ///Number of physical network connections that were open at the end of the reporting time window.
        public long LinksLive {get; set;}
        
        ///Number of physical network connections that have been terminated during the reporting time window.
        public long LinksTerminated {get; set;}
        
        ///Number of physical network connections that have been established during the reporting time window.
        public long LinksEstablished {get; set;}
        
        ///Number of physical network connections that have failed during the reporting time window. This information is currently available only for outbound connections.
        public long LinksFailed {get; set;}
        
        ///Number of responses observed during the reporting time window.
        public long Responses {get; set;}
        
        ///Sum of all response times observed during the reporting time window in milliseconds. If no value the property is blank.
        public long ResponseTimeSum {get; set;}
        
        ///Smallest response time observed during the reporting time windowin milliseconds. If no value the property is blank.
        public long ResponseTimeMin {get; set;}
        
        ///Largest response time observed during the reporting time window in milliseconds. If no value the property is blank.
        public long ResponseTimeMax {get; set;}
        
        ///Remote IP address.
        public string MaliciousIp {get; set;}
        
        ///Threat indicator detected. Possible values are Botnet C2 CryptoMining Darknet DDos MaliciousUrl Malware Phishing Proxy PUA Watchlist.
        public string IndicatorThreatType {get; set;}
        
        ///Description of the observed threat.
        public string Description {get; set;}
        
        ///Traffic Light Protocol (TLP) Level. Possible values are White Green Amber Red.
        public string TLPLevel {get; set;}
        
        ///Values are 0 - 100.
        public string Confidence {get; set;}
        
        ///Possible values are 0 - 5 where 5 is the most severe and 0 is not severe at all. Default value is 3.
        public int Severity {get; set;}
        
        ///The first time the provider reported the indicator.
        public string FirstReportedDateTime {get; set;}
        
        ///Indicates indicators are deactivated with True or False value.
        public string LastReportedDateTime {get; set;}
        
        ///The last time the indicator was seen by Interflow.
        public string IsActive {get; set;}
        
        ///Unique Id for the connection record.
        public string ConnectionId {get; set;}
        
        ///FQDN of the computer.
        public string Machine {get; set;}
        
        ///Identity of process or groups of processes initiating or accepting the connection.
        public string Process {get; set;}
        
        ///Unique agent GUID for the agent reporting data on the server.
        public string AgentId {get; set;}
        
        ///Value is OpsManager for all records.
        public string SourceSystem {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
