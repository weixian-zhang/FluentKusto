

namespace FluentKusto
{
    public class BaiClusterNodeEvent
    {

        ///
        public string TenantId {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///
        public string ResultSignature {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
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
        public datetime ResizeStartTime {get; set;}
        
        ///
        public datetime ResizeEndTime {get; set;}
        
        ///
        public datetime NodeAllocationTime {get; set;}
        
        ///
        public datetime NodeBootTime {get; set;}
        
        ///
        public datetime StartTaskStartTime {get; set;}
        
        ///
        public datetime StartTaskEndTime {get; set;}
        
        ///
        public string TotalE2ETimeInSeconds {get; set;}
        
        ///
        public string InternalOperationName {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
            }
}
