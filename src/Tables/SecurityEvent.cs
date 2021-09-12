
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class SecurityEvent : TableBase<SecurityEvent>
    {

            /// 
            public DateTime TimeGenerated {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// 
            public string Account {get; set;}
            
            /// 
            public string AccountType {get; set;}
            
            /// 
            public string Computer {get; set;}
            
            /// 
            public string EventSourceName {get; set;}
            
            /// 
            public string Channel {get; set;}
            
            /// 
            public int Task {get; set;}
            
            /// 
            public string Level {get; set;}
            
            /// 
            public string EventData {get; set;}
            
            /// 
            public int EventID {get; set;}
            
            /// 
            public string Activity {get; set;}
            
            /// 
            public string StorageAccount {get; set;}
            
            /// 
            public string AzureDeploymentID {get; set;}
            
            /// 
            public string AccessMask {get; set;}
            
            /// 
            public string AccountDomain {get; set;}
            
            /// 
            public string AccountExpires {get; set;}
            
            /// 
            public string AccountName {get; set;}
            
            /// 
            public string AccountSessionIdentifier {get; set;}
            
            /// 
            public string AdditionalInfo {get; set;}
            
            /// 
            public string AdditionalInfo2 {get; set;}
            
            /// 
            public string AllowedToDelegateTo {get; set;}
            
            /// 
            public string Attributes {get; set;}
            
            /// 
            public string AuditPolicyChanges {get; set;}
            
            /// 
            public int AuditsDiscarded {get; set;}
            
            /// 
            public int AuthenticationLevel {get; set;}
            
            /// 
            public string AuthenticationPackageName {get; set;}
            
            /// 
            public string AuthenticationProvider {get; set;}
            
            /// 
            public string AuthenticationServer {get; set;}
            
            /// 
            public int AuthenticationService {get; set;}
            
            /// 
            public string AuthenticationType {get; set;}
            
            /// 
            public string CACertificateHash {get; set;}
            
            /// 
            public string CalledStationID {get; set;}
            
            /// 
            public string CallerProcessId {get; set;}
            
            /// 
            public string CallerProcessName {get; set;}
            
            /// 
            public string CallingStationID {get; set;}
            
            /// 
            public string CAPublicKeyHash {get; set;}
            
            /// 
            public string CategoryId {get; set;}
            
            /// 
            public string CertificateDatabaseHash {get; set;}
            
            /// 
            public string ClassId {get; set;}
            
            /// 
            public string ClassName {get; set;}
            
            /// 
            public string ClientAddress {get; set;}
            
            /// 
            public string ClientIPAddress {get; set;}
            
            /// 
            public string ClientName {get; set;}
            
            /// 
            public string CommandLine {get; set;}
            
            /// 
            public string CompatibleIds {get; set;}
            
            /// 
            public string DCDNSName {get; set;}
            
            /// 
            public string DeviceDescription {get; set;}
            
            /// 
            public string DeviceId {get; set;}
            
            /// 
            public string DisplayName {get; set;}
            
            /// 
            public string Disposition {get; set;}
            
            /// 
            public string DomainBehaviorVersion {get; set;}
            
            /// 
            public string DomainName {get; set;}
            
            /// 
            public string DomainPolicyChanged {get; set;}
            
            /// 
            public string DomainSid {get; set;}
            
            /// 
            public string EAPType {get; set;}
            
            /// 
            public string ElevatedToken {get; set;}
            
            /// 
            public int ErrorCode {get; set;}
            
            /// 
            public string ExtendedQuarantineState {get; set;}
            
            /// 
            public string FailureReason {get; set;}
            
            /// 
            public string FileHash {get; set;}
            
            /// 
            public string FilePath {get; set;}
            
            /// 
            public string FilePathNoUser {get; set;}
            
            /// 
            public string Filter {get; set;}
            
            /// 
            public string ForceLogoff {get; set;}
            
            /// 
            public string Fqbn {get; set;}
            
            /// 
            public string FullyQualifiedSubjectMachineName {get; set;}
            
            /// 
            public string FullyQualifiedSubjectUserName {get; set;}
            
            /// 
            public string GroupMembership {get; set;}
            
            /// 
            public string HandleId {get; set;}
            
            /// 
            public string HardwareIds {get; set;}
            
            /// 
            public string HomeDirectory {get; set;}
            
            /// 
            public string HomePath {get; set;}
            
            /// 
            public string InterfaceUuid {get; set;}
            
            /// 
            public string IpAddress {get; set;}
            
            /// 
            public string IpPort {get; set;}
            
            /// 
            public int KeyLength {get; set;}
            
            /// 
            public string LmPackageName {get; set;}
            
            /// 
            public string LocationInformation {get; set;}
            
            /// 
            public string LockoutDuration {get; set;}
            
            /// 
            public string LockoutObservationWindow {get; set;}
            
            /// 
            public string LockoutThreshold {get; set;}
            
            /// 
            public string LoggingResult {get; set;}
            
            /// 
            public string LogonGuid {get; set;}
            
            /// 
            public string LogonHours {get; set;}
            
            /// 
            public string LogonID {get; set;}
            
            /// 
            public string LogonProcessName {get; set;}
            
            /// 
            public int LogonType {get; set;}
            
            /// 
            public string LogonTypeName {get; set;}
            
            /// 
            public string MachineAccountQuota {get; set;}
            
            /// 
            public string MachineInventory {get; set;}
            
            /// 
            public string MachineLogon {get; set;}
            
            /// 
            public string MandatoryLabel {get; set;}
            
            /// 
            public string MaxPasswordAge {get; set;}
            
            /// 
            public string MemberName {get; set;}
            
            /// 
            public string MemberSid {get; set;}
            
            /// 
            public string MinPasswordAge {get; set;}
            
            /// 
            public string MinPasswordLength {get; set;}
            
            /// 
            public string MixedDomainMode {get; set;}
            
            /// 
            public string NASIdentifier {get; set;}
            
            /// 
            public string NASIPv4Address {get; set;}
            
            /// 
            public string NASIPv6Address {get; set;}
            
            /// 
            public string NASPort {get; set;}
            
            /// 
            public string NASPortType {get; set;}
            
            /// 
            public string NetworkPolicyName {get; set;}
            
            /// 
            public string NewDate {get; set;}
            
            /// 
            public string NewMaxUsers {get; set;}
            
            /// 
            public string NewProcessId {get; set;}
            
            /// 
            public string NewProcessName {get; set;}
            
            /// 
            public string NewRemark {get; set;}
            
            /// 
            public string NewShareFlags {get; set;}
            
            /// 
            public string NewTime {get; set;}
            
            /// 
            public string NewUacValue {get; set;}
            
            /// 
            public string NewValue {get; set;}
            
            /// 
            public string NewValueType {get; set;}
            
            /// 
            public string ObjectName {get; set;}
            
            /// 
            public string ObjectServer {get; set;}
            
            /// 
            public string ObjectType {get; set;}
            
            /// 
            public string ObjectValueName {get; set;}
            
            /// 
            public string OemInformation {get; set;}
            
            /// 
            public string OldMaxUsers {get; set;}
            
            /// 
            public string OldRemark {get; set;}
            
            /// 
            public string OldShareFlags {get; set;}
            
            /// 
            public string OldUacValue {get; set;}
            
            /// 
            public string OldValue {get; set;}
            
            /// 
            public string OldValueType {get; set;}
            
            /// 
            public string OperationType {get; set;}
            
            /// 
            public string PackageName {get; set;}
            
            /// 
            public string ParentProcessName {get; set;}
            
            /// 
            public string PasswordHistoryLength {get; set;}
            
            /// 
            public string PasswordLastSet {get; set;}
            
            /// 
            public string PasswordProperties {get; set;}
            
            /// 
            public string PreviousDate {get; set;}
            
            /// 
            public string PreviousTime {get; set;}
            
            /// 
            public string PrimaryGroupId {get; set;}
            
            /// 
            public string PrivateKeyUsageCount {get; set;}
            
            /// 
            public string PrivilegeList {get; set;}
            
            /// 
            public string Process {get; set;}
            
            /// 
            public string ProcessId {get; set;}
            
            /// 
            public string ProcessName {get; set;}
            
            /// 
            public string Properties {get; set;}
            
            /// 
            public string ProfilePath {get; set;}
            
            /// 
            public string ProtocolSequence {get; set;}
            
            /// 
            public string ProxyPolicyName {get; set;}
            
            /// 
            public string QuarantineHelpURL {get; set;}
            
            /// 
            public string QuarantineSessionID {get; set;}
            
            /// 
            public string QuarantineSessionIdentifier {get; set;}
            
            /// 
            public string QuarantineState {get; set;}
            
            /// 
            public string QuarantineSystemHealthResult {get; set;}
            
            /// 
            public string RelativeTargetName {get; set;}
            
            /// 
            public string RemoteIpAddress {get; set;}
            
            /// 
            public string RemotePort {get; set;}
            
            /// 
            public string Requester {get; set;}
            
            /// 
            public string RequestId {get; set;}
            
            /// 
            public string RestrictedAdminMode {get; set;}
            
            /// 
            public string RowsDeleted {get; set;}
            
            /// 
            public string SamAccountName {get; set;}
            
            /// 
            public string ScriptPath {get; set;}
            
            /// 
            public string SecurityDescriptor {get; set;}
            
            /// 
            public string ServiceAccount {get; set;}
            
            /// 
            public string ServiceFileName {get; set;}
            
            /// 
            public string ServiceName {get; set;}
            
            /// 
            public int ServiceStartType {get; set;}
            
            /// 
            public string ServiceType {get; set;}
            
            /// 
            public string SessionName {get; set;}
            
            /// 
            public string ShareLocalPath {get; set;}
            
            /// 
            public string ShareName {get; set;}
            
            /// 
            public string SidHistory {get; set;}
            
            /// 
            public string Status {get; set;}
            
            /// 
            public string SubjectAccount {get; set;}
            
            /// 
            public string SubcategoryGuid {get; set;}
            
            /// 
            public string SubcategoryId {get; set;}
            
            /// 
            public string Subject {get; set;}
            
            /// 
            public string SubjectDomainName {get; set;}
            
            /// 
            public string SubjectKeyIdentifier {get; set;}
            
            /// 
            public string SubjectLogonId {get; set;}
            
            /// 
            public string SubjectMachineName {get; set;}
            
            /// 
            public string SubjectMachineSID {get; set;}
            
            /// 
            public string SubjectUserName {get; set;}
            
            /// 
            public string SubjectUserSid {get; set;}
            
            /// 
            public string SubStatus {get; set;}
            
            /// 
            public string TableId {get; set;}
            
            /// 
            public string TargetAccount {get; set;}
            
            /// 
            public string TargetDomainName {get; set;}
            
            /// 
            public string TargetInfo {get; set;}
            
            /// 
            public string TargetLinkedLogonId {get; set;}
            
            /// 
            public string TargetLogonGuid {get; set;}
            
            /// 
            public string TargetLogonId {get; set;}
            
            /// 
            public string TargetOutboundDomainName {get; set;}
            
            /// 
            public string TargetOutboundUserName {get; set;}
            
            /// 
            public string TargetServerName {get; set;}
            
            /// 
            public string TargetSid {get; set;}
            
            /// 
            public string TargetUser {get; set;}
            
            /// 
            public string TargetUserName {get; set;}
            
            /// 
            public string TargetUserSid {get; set;}
            
            /// 
            public string TemplateContent {get; set;}
            
            /// 
            public string TemplateDSObjectFQDN {get; set;}
            
            /// 
            public string TemplateInternalName {get; set;}
            
            /// 
            public string TemplateOID {get; set;}
            
            /// 
            public string TemplateSchemaVersion {get; set;}
            
            /// 
            public string TemplateVersion {get; set;}
            
            /// 
            public string TokenElevationType {get; set;}
            
            /// 
            public string TransmittedServices {get; set;}
            
            /// 
            public string UserAccountControl {get; set;}
            
            /// 
            public string UserParameters {get; set;}
            
            /// 
            public string UserPrincipalName {get; set;}
            
            /// 
            public string UserWorkstations {get; set;}
            
            /// 
            public string VirtualAccount {get; set;}
            
            /// 
            public string VendorIds {get; set;}
            
            /// 
            public string Workstation {get; set;}
            
            /// 
            public string WorkstationName {get; set;}
            
            /// 
            public string SourceComputerId {get; set;}
            
            /// 
            public string ManagementGroupName {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
