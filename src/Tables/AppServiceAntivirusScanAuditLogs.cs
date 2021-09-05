

namespace FluentKusto
{
    public class AppServiceAntivirusScanAuditLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///Time when event is generated
        public datetime TimeGenerated {get; set;}
        
        ///Status of the scan
        public string ScanStatus {get; set;}
        
        ///Total number of scanned files
        public int TotalFilesScanned {get; set;}
        
        ///Total number of files infected with virus
        public int NumberOfInfectedFiles {get; set;}
        
        ///List of each virus file path
        public string ListOfInfectedFiles {get; set;}
        
        ///Error Message
        public string ErrorMessage {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
