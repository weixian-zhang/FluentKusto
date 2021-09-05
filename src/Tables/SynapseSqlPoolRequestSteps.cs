

namespace FluentKusto
{
    public class SynapseSqlPoolRequestSteps
    {

        ///
        public string TenantId {get; set;}
        
        ///The logical server name of the SQL DW.
        public string LogicalServerName {get; set;}
        
        ///The azure resourceGroup of the SQL DW.
        public string ResourceGroup {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The operation associated with log record.
        public string OperationName {get; set;}
        
        ///The category of the log.
        public string Category {get; set;}
        
        ///The requestId of the execution requests.
        public string RequestId {get; set;}
        
        ///The step index of the execution requests.
        public int StepIndex {get; set;}
        
        ///The operation type of the execution requests.
        public string OperationType {get; set;}
        
        ///The distribution type of the execution requests.
        public string DistributionType {get; set;}
        
        ///The location type of the execution requests.
        public string LocationType {get; set;}
        
        ///The status of the execution requests.
        public string Status {get; set;}
        
        ///The errorId of the execution requests.
        public string ErrorId {get; set;}
        
        ///The startTime (UTC) of the execution requests.
        public datetime StartTime {get; set;}
        
        ///The end compile time (UTC) of the execution requests.
        public datetime EndCompileTime {get; set;}
        
        ///The end time (UTC) for the execution requests.
        public datetime EndTime {get; set;}
        
        ///The row count of the execution requests.
        public int RowCount {get; set;}
        
        ///The SQL command of the execution requests.
        public string Command {get; set;}
        
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
