

namespace FluentKusto
{
    public class AppServiceAppLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///Time when event is generated
        public datetime TimeGenerated {get; set;}
        
        ///Verbosity level of log mapped to standard levels (Informational, Warning, Error, or Critical)
        public string Level {get; set;}
        
        ///Host where the application is running
        public string Host {get; set;}
        
        ///Log message description
        public string ResultDescription {get; set;}
        
        ///Verbosity level of log
        public string CustomLevel {get; set;}
        
        ///Application source from where log message is emitted
        public string Source {get; set;}
        
        ///Application Method from where log message is emitted
        public string Method {get; set;}
        
        ///Application logger used to emit log message
        public string Logger {get; set;}
        
        ///Instance Id the application running
        public string WebSiteInstanceId {get; set;}
        
        ///Application class from where log message is emitted 
        public string ExceptionClass {get; set;}
        
        ///Log message
        public string Message {get; set;}
        
        ///Complete stack trace of the log message in case of exception
        public string StackTrace {get; set;}
        
        ///Application container id
        public string ContainerId {get; set;}
        
        ///The name of the operation represented by this event.
        public string OperationName {get; set;}
        
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
