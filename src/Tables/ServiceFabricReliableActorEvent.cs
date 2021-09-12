
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ServiceFabricReliableActorEvent : TableBase<ServiceFabricReliableActorEvent>
    {

            /// 
            public string SourceSystem {get; set;}
            
            /// 
            public DateTime TimeGenerated {get; set;}
            
            /// 
            public string Computer {get; set;}
            
            /// 
            public string Level {get; set;}
            
            /// 
            public string ProviderGuid {get; set;}
            
            /// 
            public string EventSourceName {get; set;}
            
            /// 
            public int EventId {get; set;}
            
            /// 
            public int Pid {get; set;}
            
            /// 
            public int Tid {get; set;}
            
            /// 
            public string OpcodeName {get; set;}
            
            /// 
            public string KeywordName {get; set;}
            
            /// 
            public string TaskName {get; set;}
            
            /// 
            public string ChannelName {get; set;}
            
            /// 
            public string AzureDeploymentID {get; set;}
            
            /// 
            public string Role {get; set;}
            
            /// 
            public string EventMessage {get; set;}
            
            /// 
            public string ActorType {get; set;}
            
            /// 
            public string ActorId {get; set;}
            
            /// 
            public int ActorIdKind {get; set;}
            
            /// 
            public bool IsStateful {get; set;}
            
            /// 
            public long ReplicaOrInstanceId {get; set;}
            
            /// 
            public string PartitionId {get; set;}
            
            /// 
            public string ServiceName {get; set;}
            
            /// 
            public string ApplicationName {get; set;}
            
            /// 
            public string ServiceTypeName {get; set;}
            
            /// 
            public string ApplicationTypeName {get; set;}
            
            /// 
            public string NodeName {get; set;}
            
            /// 
            public string NodeId {get; set;}
            
            /// 
            public long CountOfWaitingMethodCalls {get; set;}
            
            /// 
            public string MethodName {get; set;}
            
            /// 
            public string MethodSignature {get; set;}
            
            /// 
            public long MethodExecutionTimeTicks {get; set;}
            
            /// 
            public string Exception {get; set;}
            
            /// 
            public long SaveStateExecutionTimeTicks {get; set;}
            
            /// 
            public long ReplicaId {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
                }
}
