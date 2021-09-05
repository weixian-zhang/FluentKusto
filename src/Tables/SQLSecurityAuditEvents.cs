

namespace FluentKusto
{
    public class SQLSecurityAuditEvents
    {

        ///
        public string TenantId {get; set;}
        
        ///Logical server name.
        public string LogicalServerName {get; set;}
        
        ///Resource group of the SQL resoruce.
        public string ResourceGroup {get; set;}
        
        ///The timestamp (UTC) of when the log was generated.
        public datetime TimeGenerated {get; set;}
        
        ///The category of the log.
        public string Category {get; set;}
        
        ///The audit logs schema version.
        public int AuditSchemaVersion {get; set;}
        
        ///The time (UTC) the event was fired at.
        public datetime EventTime {get; set;}
        
        ///Tracks the sequence of records within a single audit record that was too large to fit in the write buffer for audits.
        public int SequenceNumber {get; set;}
        
        ///ID of the audit action.
        public string ActionId {get; set;}
        
        ///The name of the audit action.
        public string ActionName {get; set;}
        
        ///Indicates whether the action that triggered the event succeeded. Is not nullable. For all events other than login events, this only reports whether the permission check succeeded or failed, not the operation.
        public bool Succeeded {get; set;}
        
        ///Flag indicating if this is a column level permission.
        public bool IsColumnPermission {get; set;}
        
        ///ID of the session on which the event occurred.
        public int SessionId {get; set;}
        
        ///ID of the login context that the action is performed in.
        public int ServerPrincipalId {get; set;}
        
        ///ID of the database user context that the action is performed in.
        public int DatabasePrincipalId {get; set;}
        
        ///Server principal that the GRANT/DENY/REVOKE operation is performed on.
        public int TargetServerPrincipalId {get; set;}
        
        ///The database principal the GRANT/DENY/REVOKE operation is performed on.
        public int TargetDatabasePrincipalId {get; set;}
        
        ///The ID of the entity on which the audit occurred.
        public int ObjectId {get; set;}
        
        ///User defined event id passed as an argument to sp_audit_write.
        public int UserDefinedEventId {get; set;}
        
        ///Unique identifier to identify multiple audit events in one transaction.
        public long TransactionId {get; set;}
        
        ///The type of auditable entity that the audit occurs on.
        public string ClassType {get; set;}
        
        ///The description of the class type.
        public string ClassTypeDescription {get; set;}
        
        ///The type of auditable entity that the audit occurs on.
        public string SecurableClassType {get; set;}
        
        ///Query execution duration in milliseconds.
        public long DurationMs {get; set;}
        
        ///Number of rows returned in the result set.
        public long ResponseRows {get; set;}
        
        ///Number of rows affected by the executed statement.
        public long AffectedRows {get; set;}
        
        ///Client TLS version
        public int ClientTlsVersion {get; set;}
        
        ///Source IP of the client application
        public string ClientIp {get; set;}
        
        ///In some actions, this is the permissions that were grant, denied, or revoked.
        public string PermissionBitmask {get; set;}
        
        ///Unique identifier.
        public string SequenceGroupId {get; set;}
        
        ///Server principal for session. Is nullable. Returns the identity of the original login which was connected to the instance of SQL Server in case there were explicit or implicit context switches.
        public string SessionServerPrincipalName {get; set;}
        
        ///Current login. Is nullable.
        public string ServerPrincipalName {get; set;}
        
        ///Current login SID.
        public string ServerPrincipalSid {get; set;}
        
        ///Current user.
        public string DatabasePrincipalName {get; set;}
        
        ///Target login of action.
        public string TargetServerPrincipalName {get; set;}
        
        ///SID of target login.
        public string TargetServerPrincipalSid {get; set;}
        
        ///Target user of action.
        public string TargetDatabasePrincipalName {get; set;}
        
        ///The database context in which the action occurred.
        public string DatabaseName {get; set;}
        
        ///The schema context in which the action occurred.
        public string SchemaName {get; set;}
        
        ///The name of the entity on which the audit occurred.
        public string ObjectName {get; set;}
        
        ///TSQL statement if it exists.
        public string Statement {get; set;}
        
        ///Unique information that only applies to a single event is returned as XML.
        public string AdditionalInformation {get; set;}
        
        ///Used to record any extra information the user wants to record in audit log by using the sp_audit_write stored procedure.
        public string UserDefinedInformation {get; set;}
        
        ///Name of client application which executed the statement that caused the audit event.
        public string ApplicationName {get; set;}
        
        ///ID of the connection in the server.
        public string ConnectionId {get; set;}
        
        ///Information types and sensitivity labels returned by the audited query, based on the classified columns in the database.
        public string DataSensitivityInformation {get; set;}
        
        ///The host name.
        public string HostName {get; set;}
        
        ///The Session context key value content. provided as an XML.
        public string SessionContext {get; set;}
        
        ///Boolean indicating whether this was generated from a server level audit or database level audit.
        public bool IsServerLevelAudit {get; set;}
        
        ///unique Guid identifying each audit event.
        public string EventId {get; set;}
        
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
