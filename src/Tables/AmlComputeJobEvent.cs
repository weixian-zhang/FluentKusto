
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AmlComputeJobEvent : TableBase<AmlComputeJobEvent>
    {

            /// 
            public string TenantId {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// 
            public string ResultSignature {get; set;}
            
            /// 
            public DateTime TimeGenerated {get; set;}
            
            /// 
            public string OperationName {get; set;}
            
            /// 
            public string JobId {get; set;}
            
            /// 
            public string ExperimentId {get; set;}
            
            /// 
            public string ExperimentName {get; set;}
            
            /// 
            public string CustomerSubscriptionId {get; set;}
            
            /// 
            public string WorkspaceName {get; set;}
            
            /// 
            public string ClusterName {get; set;}
            
            /// 
            public string ProvisioningState {get; set;}
            
            /// 
            public string ResourceGroupName {get; set;}
            
            /// 
            public string JobName {get; set;}
            
            /// 
            public string ClusterId {get; set;}
            
            /// 
            public string EventType {get; set;}
            
            /// 
            public string ExecutionState {get; set;}
            
            /// 
            public string ErrorDetails {get; set;}
            
            /// 
            public string CreationApiVersion {get; set;}
            
            /// 
            public string ClusterResourceGroupName {get; set;}
            
            /// 
            public string TFWorkerCount {get; set;}
            
            /// 
            public string TFParameterServerCount {get; set;}
            
            /// 
            public string ToolType {get; set;}
            
            /// 
            public string RunInContainer {get; set;}
            
            /// 
            public string JobErrorMessage {get; set;}
            
            /// 
            public string NodeId {get; set;}
            
            /// 
            public string InternalOperationName {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
