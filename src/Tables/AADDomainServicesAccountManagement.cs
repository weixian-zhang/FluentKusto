
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AADDomainServicesAccountManagement : TableBase<AADDomainServicesAccountManagement>
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
            public string SubjectUserSid {get; set;}
            
            /// 
            public string SubjectUserName {get; set;}
            
            /// 
            public string SubjectDomainName {get; set;}
            
            /// 
            public string SubjectLogonId {get; set;}
            
            /// 
            public string Status {get; set;}
            
            /// 
            public string PrivilegeList {get; set;}
            
            /// 
            public string TargetSid {get; set;}
            
            /// 
            public string SamAccountName {get; set;}
            
            /// 
            public string DisplayName {get; set;}
            
            /// 
            public string UserPrincipalName {get; set;}
            
            /// 
            public string HomeDirectory {get; set;}
            
            /// 
            public string HomePath {get; set;}
            
            /// 
            public string ScriptPath {get; set;}
            
            /// 
            public string ProfilePath {get; set;}
            
            /// 
            public string UserWorkstations {get; set;}
            
            /// 
            public string PasswordLastSet {get; set;}
            
            /// 
            public string AccountExpires {get; set;}
            
            /// 
            public string PrimaryGroupId {get; set;}
            
            /// 
            public string AllowedToDelegateTo {get; set;}
            
            /// 
            public string OldUacValue {get; set;}
            
            /// 
            public string NewUacValue {get; set;}
            
            /// 
            public string UserAccountControl {get; set;}
            
            /// 
            public string UserParameters {get; set;}
            
            /// 
            public string SidHistory {get; set;}
            
            /// 
            public string LogonHours {get; set;}
            
            /// 
            public string MemberName {get; set;}
            
            /// 
            public string MemberSid {get; set;}
            
            /// 
            public DateTime MembershipExpirationTime {get; set;}
            
            /// 
            public string DnsHostName {get; set;}
            
            /// 
            public string ServicePrincipalNames {get; set;}
            
            /// 
            public string ComputerAccountChange {get; set;}
            
            /// 
            public string GroupTypeChange {get; set;}
            
            /// 
            public string SourceUserName {get; set;}
            
            /// 
            public string SourceSid {get; set;}
            
            /// 
            public string Workstation {get; set;}
            
            /// 
            public string OldTargetUserName {get; set;}
            
            /// 
            public string NewTargetUserName {get; set;}
            
            /// 
            public string CallerProcessId {get; set;}
            
            /// 
            public string CallerProcessName {get; set;}
            
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
