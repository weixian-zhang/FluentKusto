
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class VMProcess : TableBase<VMProcess>
    {

            /// Date and time the record was created.
            public DateTime TimeGenerated {get; set;}
            
            /// The name of the computer.
            public string Computer {get; set;}
            
            /// Unique ID for the dependency agent installed on the server.
            public string AgentId {get; set;}
            
            /// The machine name of the server.
            public string Machine {get; set;}
            
            /// The name of the process.
            public string Process {get; set;}
            
            /// The name of the process executable
            public string ExecutableName {get; set;}
            
            /// The friendly display name of the process
            public string DisplayName {get; set;}
            
            /// The role of the process.
            public string Role {get; set;}
            
            /// The process group name for the process
            public string Group {get; set;}
            
            /// The process pool start time
            public DateTime StartTime {get; set;}
            
            /// The first PID in the process pool
            public int FirstPid {get; set;}
            
            /// The process description
            public string Description {get; set;}
            
            /// The name of the company
            public string CompanyName {get; set;}
            
            /// The internal name
            public string InternalName {get; set;}
            
            /// The name of the product
            public string ProductName {get; set;}
            
            /// The product version
            public string ProductVersion {get; set;}
            
            /// The file version
            public string FileVersion {get; set;}
            
            /// The path to the executable file
            public string ExecutablePath {get; set;}
            
            /// The command line
            public string CommandLine {get; set;}
            
            /// The working directory
            public string WorkingDirectory {get; set;}
            
            /// A list of services associated with the process.
            public dynamic Services {get; set;}
            
            /// The account under which the process is executing
            public string UserName {get; set;}
            
            /// The domain under which the process is executing
            public string UserDomain {get; set;}
            
            /// The source of the data collected (OpsManager)
            public string SourceSystem {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
