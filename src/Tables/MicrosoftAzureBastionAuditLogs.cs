
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class MicrosoftAzureBastionAuditLogs : TableBase<MicrosoftAzureBastionAuditLogs>
    {

            /// 
            public string TenantId {get; set;}
            
            /// 
            public DateTime TimeGenerated {get; set;}
            
            /// The timestamp (UTC) of the log
            public DateTime Time {get; set;}
            
            /// The name of the operation represented by this event
            public string OperationName {get; set;}
            
            /// The location of the server that processed the request (e.g., South Central US).
            public string Location {get; set;}
            
            /// Browser User Agent that the request was sent
            public string UserAgent {get; set;}
            
            /// UserName that was used to log into the VirtualMachine from Bastion
            public string UserName {get; set;}
            
            /// Browser IP Address that was used to log into the VirtualMachine from Bastion
            public string ClientIpAddress {get; set;}
            
            /// Browser Port Number that was used to log into the VirtualMachine from Bastion
            public int ClientPort {get; set;}
            
            /// Protocol (could be ssh or rdp) that was used to log into the VirtualMachine from Bastion
            public string Protocol {get; set;}
            
            /// ResourceID of the VirtualMachine where the Bastion was connected to
            public string TargetResourceId {get; set;}
            
            /// Additonal text that's assoicated of this event
            public string Message {get; set;}
            
            /// IP Address of VirtualMachine where the Bastion was connected to
            public string TargetVMIPAddress {get; set;}
            
            /// Internal Bastion Connection GUID
            public string TunnelId {get; set;}
            
            /// Timestamp (UTC) of when the Bastion Session was started
            public DateTime SessionStartTime {get; set;}
            
            /// Timestamp (UTC) of when the Bastion Session was ended
            public string SessionEndTime {get; set;}
            
            /// Duration in milliseconds where the Bastion Session lasted (available only when the Bastion Session ended)
            public int Duration {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
