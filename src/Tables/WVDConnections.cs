

namespace FluentKusto
{
    public class WVDConnections
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of the event.
        public datetime TimeGenerated {get; set;}
        
        ///The activity Id.
        public string CorrelationId {get; set;}
        
        ///The user who initiated the connection.
        public string UserName {get; set;}
        
        ///The state of the connection.
        public string State {get; set;}
        
        ///The OS of the client that is connecting (if available).
        public string ClientOS {get; set;}
        
        ///The version of the client that is connecting (if available).
        public string ClientVersion {get; set;}
        
        ///The type of the client that is connecting (if available).
        public string ClientType {get; set;}
        
        ///The remote IP address from the client side.
        public string ClientSideIPAddress {get; set;}
        
        ///The predecessor Correlation Id of the connection, if the current connection is an auto-reconnect.
        public string PredecessorConnectionId {get; set;}
        
        ///The type of connection - either RAIL (RemoteApp Integrated Locally) or Desktop.
        public string ConnectionType {get; set;}
        
        ///The alias of the app that the user attempted to connect to.
        public string ResourceAlias {get; set;}
        
        ///The FQDN of the machine where the user connection was orchestrated.
        public string SessionHostName {get; set;}
        
        ///The Azure VM Id of the machine where the user connection was orchestrated.
        public string SessionHostAzureVmId {get; set;}
        
        ///The IP address of the machine where the user connection was orchestrated.
        public string SessionHostIPAddress {get; set;}
        
        ///The OS version of the machine where the user connection was orchestrated.
        public string SessionHostOSVersion {get; set;}
        
        ///The OS SKU description of the machine where the user connection was orchestrated.
        public string SessionHostOSDescription {get; set;}
        
        ///The version of the WVD Agent running on the machine where the user connection was orchestrated.
        public string SessionHostAgentVersion {get; set;}
        
        ///The version of the WVD RDP Stack running on the machine where the user connection was orchestrated.
        public string SessionHostSxSStackVersion {get; set;}
        
        ///The Session Id of WVD RDP Stack running on the machine where the user connection was orchestrated.
        public string SessionHostSessionId {get; set;}
        
        ///The AAD tenenat Id of the user.
        public string AadTenantId {get; set;}
        
        ///The region of the WVD Gateway for the server side user connection.
        public string GatewayRegion {get; set;}
        
        ///Indicates whether WVD RDP Stack uses UDP protocol on current user connection.
        public string UdpUse {get; set;}
        
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
