
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AADDomainServicesPolicyChange : TableBase<AADDomainServicesPolicyChange>
    {

            /// 
            public string SourceSystem {get; set;}
            
            /// 
            public DateTime TimeGenerated {get; set;}
            
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
            public int CrashOnAuditFailValue {get; set;}
            
            /// 
            public string ObjectServer {get; set;}
            
            /// 
            public string ObjectType {get; set;}
            
            /// 
            public string ObjectName {get; set;}
            
            /// 
            public string HandleId {get; set;}
            
            /// 
            public string OldSd {get; set;}
            
            /// 
            public string NewSd {get; set;}
            
            /// 
            public int TdoDirection {get; set;}
            
            /// 
            public int TdoAttributes {get; set;}
            
            /// 
            public int TdoType {get; set;}
            
            /// 
            public string EnabledPrivilegeList {get; set;}
            
            /// 
            public string DisabledPrivilegeList {get; set;}
            
            /// 
            public string DomainName {get; set;}
            
            /// 
            public string DomainSid {get; set;}
            
            /// 
            public string SidFilteringEnabled {get; set;}
            
            /// 
            public string KerberosPolicyChange {get; set;}
            
            /// 
            public string AccessGranted {get; set;}
            
            /// 
            public string AccessRemoved {get; set;}
            
            /// 
            public string CategoryId {get; set;}
            
            /// 
            public string SubcategoryId {get; set;}
            
            /// 
            public string SubcategoryGuid {get; set;}
            
            /// 
            public string AuditPolicyChanges {get; set;}
            
            /// 
            public string DomainPolicyChanged {get; set;}
            
            /// 
            public string MinPasswordAge {get; set;}
            
            /// 
            public string MaxPasswordAge {get; set;}
            
            /// 
            public string ForceLogoff {get; set;}
            
            /// 
            public string LockoutThreshold {get; set;}
            
            /// 
            public string LockoutObservationWindow {get; set;}
            
            /// 
            public string LockoutDuration {get; set;}
            
            /// 
            public string PasswordProperties {get; set;}
            
            /// 
            public string MinPasswordLength {get; set;}
            
            /// 
            public string PasswordHistoryLength {get; set;}
            
            /// 
            public string MachineAccountQuota {get; set;}
            
            /// 
            public string MixedDomainMode {get; set;}
            
            /// 
            public string DomainBehaviorVersion {get; set;}
            
            /// 
            public string OemInformation {get; set;}
            
            /// 
            public int CollisionTargetType {get; set;}
            
            /// 
            public string CollisionTargetName {get; set;}
            
            /// 
            public string ForestRoot {get; set;}
            
            /// 
            public string TopLevelName {get; set;}
            
            /// 
            public string DnsName {get; set;}
            
            /// 
            public string NetbiosName {get; set;}
            
            /// 
            public int Flags {get; set;}
            
            /// 
            public string ForestRootSid {get; set;}
            
            /// 
            public string OperationId {get; set;}
            
            /// 
            public int EntryType {get; set;}
            
            /// 
            public string AuditSourceName {get; set;}
            
            /// 
            public string EventSourceId {get; set;}
            
            /// 
            public string RecordId {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
