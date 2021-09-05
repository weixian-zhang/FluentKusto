

namespace FluentKusto
{
    public class IntuneOperationalLogs
    {

        ///
        public string SourceSystem {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string OperationName {get; set;}
        
        ///
        public string Category {get; set;}
        
        ///
        public string Properties {get; set;}
        
        ///
        public string Result {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
            }
}
