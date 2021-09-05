

namespace FluentKusto
{
    public class SqlAtpStatus
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated
        public datetime TimeGenerated {get; set;}
        
        ///ID of the source monitoring agent
        public string AgentId {get; set;}
        
        ///Client IP address of the source computer
        public string ClientIP {get; set;}
        
        ///Resource ID of the machine hosting the SQL Instance, if exists
        public string HostResourceId {get; set;}
        
        ///Name of the computer that hosts the SQL Server
        public string Computer {get; set;}
        
        ///SQL Server instance name
        public string SqlInstanceName {get; set;}
        
        ///SQL Advanced Threat Protection status for the SQL instance
        public string Status {get; set;}
        
        ///The last error from SQL Advanced Threat Protection (if exists). The error refer to the time passed from the previous status entry and can help diagnose transient or persistent issues with SQL ATP protection
        public string LastError {get; set;}
        
        ///The IP version of SQL Advanced Threat Protection running on the machine
        public string IntelligencePackVersion {get; set;}
        
        ///SQL Server instance version
        public string SqlInstanceVersion {get; set;}
        
        ///The start time of the SQL Server instance
        public datetime SqlInstanceStartTime {get; set;}
        
        ///The start time of the Microsoft Monitoring Agent process running SQL ATP solution. This can help find agents who restart frequently or not at all and can indicate a problem or machine with out-of-date configuration
        public datetime AgentStartTime {get; set;}
        
        ///The unique identifier of the machine running the Microsoft Monitoring Agent
        public string MachineUUID {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
            }
}
