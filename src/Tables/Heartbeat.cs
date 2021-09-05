

namespace FluentKusto
{
    public class Heartbeat
    {

        ///Type of agent the data was collected from. Possible values are OpsManager (Windows agent) or Linux.
        public string SourceSystem {get; set;}
        
        ///Date and time the record was created.
        public datetime TimeGenerated {get; set;}
        
        ///Name of Operations Manager management group.
        public string ManagementGroupName {get; set;}
        
        ///IP address of the computer. Note that public IP is used
        public string ComputerIP {get; set;}
        
        ///Computer name
        public string Computer {get; set;}
        
        ///Value is Direct Agent SCOM Agent or SCOM Management Server.
        public string Category {get; set;}
        
        ///Type of OS. Possible values are Windows or Linux .
        public string OSType {get; set;}
        
        ///Name of OS.
        public string OSName {get; set;}
        
        ///Operating system major version.
        public string OSMajorVersion {get; set;}
        
        ///Operating system minor version.
        public string OSMinorVersion {get; set;}
        
        ///Version of the agent.
        public string Version {get; set;}
        
        ///Specfies how agent is connected to workspace. Possible values are Direct or SCManagementServer.
        public string SCAgentChannel {get; set;}
        
        ///If Log Analytics gateway is installed value is true otherwise value is false.
        public bool IsGatewayInstalled {get; set;}
        
        ///Longitude of computer's geographic location.
        public real RemoteIPLongitude {get; set;}
        
        ///Latitude of computer's geographic location.
        public real RemoteIPLatitude {get; set;}
        
        ///Geographic location where computer is deployed.
        public string RemoteIPCountry {get; set;}
        
        ///Subscription ID of the Azure resource running the agent
        public string SubscriptionId {get; set;}
        
        ///Resource name of the Azure resource running the agent.
        public string ResourceGroup {get; set;}
        
        ///Resource provider of the Azure resource running the agent
        public string ResourceProvider {get; set;}
        
        ///Resource group name of the Azure resource running the agent.
        public string Resource {get; set;}
        
        ///Resource ID of the Azure resource running the agent. Retained for for backward compatibility. _ResourceId should be used.
        public string ResourceId {get; set;}
        
        ///Type of the Azure resource running the agent. Examples include virtualmachines or managedclusters.
        public string ResourceType {get; set;}
        
        ///Environment that hosts the computer: Azure or Non-Azure
        public string ComputerEnvironment {get; set;}
        
        ///List of solutions deployed on the agent at the moment when Heartbeat was issued.
        public string Solutions {get; set;}
        
        ///
        public string VMUUID {get; set;}
        
        ///
        public dynamic ComputerPrivateIPs {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
