
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ADXCommand : TableBase<ADXCommand>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The time (UTC) at which this event was generated
            public DateTime TimeGenerated {get; set;}
            
            /// The name of this operation
            public string OperationName {get; set;}
            
            /// The category of this log for this events it will be Command
            public string Category {get; set;}
            
            /// The client request id
            public string CorrelationId {get; set;}
            
            /// The root activity id
            public string RootActivityId {get; set;}
            
            /// Time (UTC) at which this command started
            public DateTime StartedOn {get; set;}
            
            /// Time (UTC) at which this command ended
            public DateTime LastUpdatedOn {get; set;}
            
            /// The name of the database the command ran on
            public string DatabaseName {get; set;}
            
            /// The State the command ended with
            public string State {get; set;}
            
            /// The failure reason
            public string FailureReason {get; set;}
            
            /// Total CPU duration
            public string TotalCPU {get; set;}
            
            /// Command type
            public string CommandType {get; set;}
            
            /// application name invoked the command
            public string ApplicationName {get; set;}
            
            /// Command resource utilization
            public dynamic ResourceUtilization {get; set;}
            
            /// Command duration
            public string Duration {get; set;}
            
            /// The user that invoked the query
            public string User {get; set;}
            
            /// The principal that invoked the query
            public string Principal {get; set;}
            
            /// The workload group the command was classified to
            public string WorkloadGroup {get; set;}
            
            /// The text of the invoked command
            public string Text {get; set;}
            
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
