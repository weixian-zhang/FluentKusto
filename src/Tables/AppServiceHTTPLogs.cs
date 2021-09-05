

namespace FluentKusto
{
    public class AppServiceHTTPLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///Time when event is generated
        public datetime TimeGenerated {get; set;}
        
        ///Log category name
        public string Category {get; set;}
        
        ///HTTP verb on request
        public string CsMethod {get; set;}
        
        ///HTTP target on request
        public string CsUriStem {get; set;}
        
        ///Server port number
        public string SPort {get; set;}
        
        ///IP address of the client
        public string CIp {get; set;}
        
        ///User agent on HTTP request
        public string UserAgent {get; set;}
        
        ///Host name header on HTTP request
        public string CsHost {get; set;}
        
        ///HTTP status code
        public int ScStatus {get; set;}
        
        ///Substatus error code on HTTP request
        public string ScSubStatus {get; set;}
        
        ///Windows status code on HTTP request
        public string ScWin32Status {get; set;}
        
        ///Number of bytes sent by server
        public int ScBytes {get; set;}
        
        ///Number of bytes received by server
        public int CsBytes {get; set;}
        
        ///Time taken by HTTP request in milliseconds
        public int TimeTaken {get; set;}
        
        ///Success / Failure of HTTP request
        public string Result {get; set;}
        
        ///Cookie on HTTP request
        public string Cookie {get; set;}
        
        ///URI query on HTTP request
        public string CsUriQuery {get; set;}
        
        ///The name of the authenticated user on HTTP request
        public string CsUsername {get; set;}
        
        ///The site that the user last visited. This site provided a link to the current site
        public string Referer {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
