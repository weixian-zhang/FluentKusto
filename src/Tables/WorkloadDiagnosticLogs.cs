

namespace FluentKusto
{
    public class WorkloadDiagnosticLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///Name of the Computer generating the log.
        public string Computer {get; set;}
        
        ///The category of the log.
        public string Category {get; set;}
        
        ///The status of the record. Example: Error, Warning, etc.
        public string Status {get; set;}
        
        ///The message of the log entry.
        public string Message {get; set;}
        
        ///Dimensions or other metatata about the record. For example may contain the Monitoring profile ID the log entry is about.
        public dynamic Tags {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
            }
}
