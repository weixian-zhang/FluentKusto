
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class BaiClusterNodeEvent : TableBase<BaiClusterNodeEvent>
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
            public string ClusterName {get; set;}
            
            /// 
            public string NodeId {get; set;}
            
            /// 
            public string VmSize {get; set;}
            
            /// 
            public string VmFamilyName {get; set;}
            
            /// 
            public string VmPriority {get; set;}
            
            /// 
            public string Publisher {get; set;}
            
            /// 
            public string Offer {get; set;}
            
            /// 
            public string Sku {get; set;}
            
            /// 
            public string Version {get; set;}
            
            /// 
            public string ClusterCreationTime {get; set;}
            
            /// 
            public DateTime ResizeStartTime {get; set;}
            
            /// 
            public DateTime ResizeEndTime {get; set;}
            
            /// 
            public DateTime NodeAllocationTime {get; set;}
            
            /// 
            public DateTime NodeBootTime {get; set;}
            
            /// 
            public DateTime StartTaskStartTime {get; set;}
            
            /// 
            public DateTime StartTaskEndTime {get; set;}
            
            /// 
            public string TotalE2ETimeInSeconds {get; set;}
            
            /// 
            public string InternalOperationName {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
                }
}
