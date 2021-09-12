
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class MicrosoftDynamicsTelemetryPerformanceLogs : TableBase<MicrosoftDynamicsTelemetryPerformanceLogs>
    {

            /// 
            public string TenantId {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// The timestamp (UTC) of the log.
            public DateTime TimeGenerated {get; set;}
            
            /// Log category
            public string Category {get; set;}
            
            /// Unique identifier for an environment as shown in Lifecycle Services
            public string EnvironmentId {get; set;}
            
            /// Type of the machine (AOS/BI) emitting the events
            public string Role {get; set;}
            
            /// Name of the machine emitting the events
            public string RoleInstance {get; set;}
            
            /// Name of the event
            public string EventName {get; set;}
            
            /// Unique identifier for an activity
            public string ActivityId {get; set;}
            
            /// Additional information about the event
            public string EventMessage {get; set;}
            
            /// Process id
            public int Pid {get; set;}
            
            /// SqlCpu Utilization
            public float SqlCpu {get; set;}
            
            /// Collection of SQL performance metrics
            public dynamic Parameters {get; set;}
            
            /// Type of the executed SQL query
            public string QueryType {get; set;}
            
            /// Execution Status of the query
            public int ExecutionStatus {get; set;}
            
            /// Returned rowCount from the executed SQL query
            public int ExecutionResultRowCount {get; set;}
            
            /// Execution time in seconds for the AosDatabaseSlowQuery event
            public float ExecutionTimeSeconds {get; set;}
            
            /// SQL query statement
            public string SqlStatement {get; set;}
            
            /// Execution call stack
            public string CallStack {get; set;}
            
            /// Type of the connection
            public string ConnectionType {get; set;}
            
            /// Process id for the SQL statement (SqlSpid)
            public int SqlSpid {get; set;}
            
            /// Name of the class
            public string ClassName {get; set;}
            
            /// Legal entity
            public long LegalEntity {get; set;}
            
            /// Id of the batch job
            public long BatchJobId {get; set;}
            
            /// Task Id of the batch job
            public long BatchJobTaskId {get; set;}
            
            /// Duration (in milliseconds) of the form execution time
            public int Duration {get; set;}
            
            /// Duration in milliseconds of the batch jobs
            public int DurationInMilliSeconds {get; set;}
            
            /// Name of the environment as deployed in Lifecycle Services
            public string Environment {get; set;}
            
            /// Name of the form in Finance and Operations
            public string formName {get; set;}
            
            /// Is it valid
            public bool IsValid {get; set;}
            
            /// Is this a warm event
            public bool IsWarmEvent {get; set;}
            
            /// Error message logged in the application 
            public string ErrorMessage {get; set;}
            
            /// Count of update requests
            public int CountOfUpdate {get; set;}
            
            /// Count of delete requests
            public int CountOfDelete {get; set;}
            
            /// Count of insert requests
            public int CountOfInsert {get; set;}
            
            /// Count of select requests
            public int CountOfSelect {get; set;}
            
            /// Count of data definition requests
            public int CountOfDdl {get; set;}
            
            /// Count of procedure requests
            public int CountOfProc {get; set;}
            
            /// Count of other requests
            public int CountOfOther {get; set;}
            
            /// Transaction duration in seconds for Aos Large Active Transactions
            public float TransactionDurationSeconds {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
