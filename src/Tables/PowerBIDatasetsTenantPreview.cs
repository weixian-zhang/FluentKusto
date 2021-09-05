

namespace FluentKusto
{
    public class PowerBIDatasetsTenantPreview
    {

        ///
        public string TenantId {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The operation associated with log record.
        public string OperationName {get; set;}
        
        ///Unique identifier of the Power BI tenant.
        public string CustomerTenantId {get; set;}
        
        ///Unique identifier of the workspace being operated on.
        public string WorkspaceId {get; set;}
        
        ///Unique identifier of the Premium capacity being operated on.
        public string PremiumCapacityId {get; set;}
        
        ///Property bag of unique identifiers providing details about the application executing the request. E.g. report ID.
        public string ApplicationContext {get; set;}
        
        ///Contains the name of the client application that created the connection to the server. This column is populated with the values passed by the application rather than the displayed name of the program.
        public string ApplicationName {get; set;}
        
        ///The name of the computer on which the client application is running. This column is populated with the values passed by the client application.
        public string ClientHostName {get; set;}
        
        ///Contains the process ID of the client application.
        public string ClientProcessId {get; set;}
        
        ///Unique identifier of the connection.
        public string ConnectionId {get; set;}
        
        ///Amount of CPU time (in milliseconds) used by the event.
        public long CPUTime {get; set;}
        
        ///Contains the name of the database in which the query is running.
        public string DatabaseName {get; set;}
        
        ///Amount of time (in milliseconds) taken by the event.
        public long Duration {get; set;}
        
        ///The user on whose behalf the operation is running. Used when an end user identity must be impersonated on the server.
        public string EffectiveUsername {get; set;}
        
        ///Contains the error number of any error associated with the event.
        public string Error {get; set;}
        
        ///Event Class is used to categorize events.
        public string EventClass {get; set;}
        
        ///Event Subclass provides additional information about each event class.
        public string EventSubclass {get; set;}
        
        ///Contains the integer data associated with the reported event, such as the current count of the number of rows processed for a processing event.
        public long IntegerData {get; set;}
        
        ///Contains the object ID associated with the reported event.
        public string ObjectId {get; set;}
        
        ///The name of the object for which the event occurred.
        public string ObjectName {get; set;}
        
        ///Object path. A comma-separated list of parents, starting with the object's parent.
        public string ObjectPath {get; set;}
        
        ///Object reference. Encoded as XML for all parents, using tags to describe the object.
        public string ObjectReference {get; set;}
        
        ///Identifies the type of object associated with a particular lock. For example, a lock timeout on a database will indicate the object type 100002, which is the Database object type.
        public int ObjectType {get; set;}
        
        ///An integer representing how many rows have been processed in the current operation at a point in time.
        public long ProgressTotal {get; set;}
        
        ///Contains the parameters for parameterized queries and commands associated with the event.
        public string RequestParameters {get; set;}
        
        ///Contains the properties of the XMLA request.
        public string RequestProperties {get; set;}
        
        ///Unique identifier of a session which represents multiple transactions occurring within the same scope e.g. Sharing calculated members.
        public string SessionId {get; set;}
        
        ///Contains the severity level of an exception associated with the command event. Values are: 0 = Success, 1 = Informational, 2 = Warning, 3 = Error.
        public string Severity {get; set;}
        
        ///Server process ID. This uniquely identifies a user session. This directly corresponds to the session GUID used by XML/A.
        public int SpId {get; set;}
        
        ///Contains the time at which the event started, when available.
        public datetime StartTime {get; set;}
        
        ///Indicates if the operation was successful. 1 = success. 0 = failure.
        public string Success {get; set;}
        
        ///Contains verbose information associated with the event
        public string TextData {get; set;}
        
        ///Unique Identifier of request
        public string RootActivityId {get; set;}
        
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
