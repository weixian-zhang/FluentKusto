

namespace FluentKusto
{
    public class Usage
    {

        ///Deprecated
        public string Computer {get; set;}
        
        ///Date and time the record was created.
        public datetime TimeGenerated {get; set;}
        
        ///For Usage record SourceSystem is always OMS.
        public string SourceSystem {get; set;}
        
        ///Start time of the 1 hour aggregation window (same as TimeGenerated).
        public datetime StartTime {get; set;}
        
        ///End time of the one hour aggregation window.
        public datetime EndTime {get; set;}
        
        ///The URI of the workspace. This will be same for all records in this table in workspace.
        public string ResourceUri {get; set;}
        
        ///Deprecated
        public string LinkedResourceUri {get; set;}
        
        ///Table that usage is being reported about.
        public string DataType {get; set;}
        
        ///Solution about which usage is being reported.
        public string Solution {get; set;}
        
        ///Deprecated
        public long BatchesWithinSla {get; set;}
        
        ///Deprecated
        public long BatchesOutsideSla {get; set;}
        
        ///Deprecated
        public long BatchesCapped {get; set;}
        
        ///Deprecated
        public long TotalBatches {get; set;}
        
        ///Deprecated
        public real AvgLatencyInSeconds {get; set;}
        
        ///Size of data in Mbytes.
        public real Quantity {get; set;}
        
        ///Value is alwais Mbytes.
        public string QuantityUnit {get; set;}
        
        ///Logical flag to indicate whether we bill for this data record.
        public bool IsBillable {get; set;}
        
        ///GUID of the meter used for billing.
        public string MeterId {get; set;}
        
        ///Deprecated
        public string LinkedMeterId {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
            }
}
