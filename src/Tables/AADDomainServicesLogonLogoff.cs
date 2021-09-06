

namespace FluentKusto
{
    public class AADDomainServicesLogonLogoff
    {

        ///
        public string SourceSystem {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string ResourceId {get; set;}
        
        ///
        public string OperationName {get; set;}
        
        ///
        public string Category {get; set;}
        
        ///
        public string ResultType {get; set;}
        
        ///
        public string ResultDescription {get; set;}
        
        ///
        public string CorrelationId {get; set;}
        
        ///
        public string TargetUserSid {get; set;}
        
        ///
        public string TargetUserName {get; set;}
        
        ///
        public string TargetDomainName {get; set;}
        
        ///
        public string TargetLogonId {get; set;}
        
        ///
        public int LogonType {get; set;}
        
        ///
        public string LogonProcessName {get; set;}
        
        ///
        public string AuthenticationPackageName {get; set;}
        
        ///
        public string WorkstationName {get; set;}
        
        ///
        public string LogonGuid {get; set;}
        
        ///
        public string TransmittedServices {get; set;}
        
        ///
        public string LmPackageName {get; set;}
        
        ///
        public int KeyLength {get; set;}
        
        ///
        public string ImpersonationLevel {get; set;}
        
        ///
        public string RestrictedAdminMode {get; set;}
        
        ///
        public string TargetOutboundUserName {get; set;}
        
        ///
        public string TargetOutboundDomainName {get; set;}
        
        ///
        public string VirtualAccount {get; set;}
        
        ///
        public string TargetLinkedLogonId {get; set;}
        
        ///
        public string ElevatedToken {get; set;}
        
        ///
        public string FailureReason {get; set;}
        
        ///
        public string SubStatus {get; set;}
        
        ///
        public string TargetLogonGuid {get; set;}
        
        ///
        public string TargetServerName {get; set;}
        
        ///
        public string TargetInfo {get; set;}
        
        ///
        public string TdoSid {get; set;}
        
        ///
        public string SidList {get; set;}
        
        ///
        public string RecordId {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
