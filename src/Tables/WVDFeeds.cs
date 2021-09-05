

namespace FluentKusto
{
    public class WVDFeeds
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of the event.
        public datetime TimeGenerated {get; set;}
        
        ///The activity Id.
        public string CorrelationId {get; set;}
        
        ///The user that initiated the feed request.
        public string UserName {get; set;}
        
        ///The OS of the client that is requesting the feed (if available).
        public string ClientOS {get; set;}
        
        ///The version of the client that is requesting the feed (if available).
        public string ClientVersion {get; set;}
        
        ///The type of the client that is requesting the feed (if available).
        public string ClientType {get; set;}
        
        ///The remote IP address from the client side.
        public string ClientSideIPAddress {get; set;}
        
        ///The total number of RDP files that the client attempted to retrieve.
        public int RDPTotal {get; set;}
        
        ///The number of RDP files that failed to be retrieved.
        public int RDPFail {get; set;}
        
        ///The total number of Icons (PNG, ICO) files that the client attempted to retrieve.
        public int IconTotal {get; set;}
        
        ///The number of Icons (PNG, ICO) files that failed to be retrieved.
        public int IconFail {get; set;}
        
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
