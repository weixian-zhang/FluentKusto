
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class BaiClusterEvent : TableBase<BaiClusterEvent>
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
            public string ProvisioningState {get; set;}
            
            /// 
            public string ClusterName {get; set;}
            
            /// 
            public string ClusterType {get; set;}
            
            /// 
            public string CreatedBy {get; set;}
            
            /// 
            public int CoreCount {get; set;}
            
            /// 
            public string VmSize {get; set;}
            
            /// 
            public string VmPriority {get; set;}
            
            /// 
            public string ScalingType {get; set;}
            
            /// 
            public int InitialNodeCount {get; set;}
            
            /// 
            public int MinimumNodeCount {get; set;}
            
            /// 
            public int MaximumNodeCount {get; set;}
            
            /// 
            public string NodeDeallocationOption {get; set;}
            
            /// 
            public string Publisher {get; set;}
            
            /// 
            public string Offer {get; set;}
            
            /// 
            public string Sku {get; set;}
            
            /// 
            public string Version {get; set;}
            
            /// 
            public string SubnetId {get; set;}
            
            /// 
            public string AllocationState {get; set;}
            
            /// 
            public int CurrentNodeCount {get; set;}
            
            /// 
            public int TargetNodeCount {get; set;}
            
            /// 
            public string EventType {get; set;}
            
            /// 
            public int NodeIdleTimeSecondsBeforeScaleDown {get; set;}
            
            /// 
            public string PreemptedNodeCount {get; set;}
            
            /// 
            public string IsResizeGrow {get; set;}
            
            /// 
            public string VmFamilyName {get; set;}
            
            /// 
            public int LeavingNodeCount {get; set;}
            
            /// 
            public int UnusableNodeCount {get; set;}
            
            /// 
            public int IdleNodeCount {get; set;}
            
            /// 
            public int RunningNodeCount {get; set;}
            
            /// 
            public int PreparingNodeCount {get; set;}
            
            /// 
            public string QuotaAllocated {get; set;}
            
            /// 
            public string QuotaUtilized {get; set;}
            
            /// 
            public DateTime AllocationStateTransitionTime {get; set;}
            
            /// 
            public string ClusterErrorCodes {get; set;}
            
            /// 
            public string CreationApiVersion {get; set;}
            
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
