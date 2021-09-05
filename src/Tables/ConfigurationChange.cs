

namespace FluentKusto
{
    public class ConfigurationChange
    {

        ///
        public string Computer {get; set;}
        
        ///Type of configuration item that changed: Files Software WindowsServices Registry Daemons
        public string ConfigChangeType {get; set;}
        
        ///The type of change that occurred: Added Removed Modified
        public string ChangeCategory {get; set;}
        
        ///
        public string SourceComputerId {get; set;}
        
        ///Type of the software: Application Package Update
        public string SoftwareType {get; set;}
        
        ///Name of the software
        public string SoftwareName {get; set;}
        
        ///Previous value
        public string Previous {get; set;}
        
        ///Current value
        public string Current {get; set;}
        
        ///Software publisher name
        public string Publisher {get; set;}
        
        ///
        public string Location {get; set;}
        
        ///Description of the software
        public string SoftwareDescription {get; set;}
        
        ///Service property that was changed
        public string SvcChangeType {get; set;}
        
        ///Human-frinedly name for the service
        public string SvcDisplayName {get; set;}
        
        ///Name of the service
        public string SvcName {get; set;}
        
        ///Current state of the service
        public string SvcState {get; set;}
        
        ///Previous state of the service
        public string SvcPreviousState {get; set;}
        
        ///Startup behavior of the service
        public string SvcStartupType {get; set;}
        
        ///Previous startup behavior of the service
        public string SvcPreviousStartupType {get; set;}
        
        ///User account that is associated with the service executable explicitly to provide a security context for the service
        public string SvcAccount {get; set;}
        
        ///Previous user account that was associated with the sevice executable
        public string SvcPreviousAccount {get; set;}
        
        ///Modes used by the daemon for system operation
        public string SvcRunlevels {get; set;}
        
        ///Previous modes used by the daemon for system operation
        public string SvcPreviousRunlevels {get; set;}
        
        ///Parent process for the daemon
        public string SvcController {get; set;}
        
        ///Previous parent process for the daemon
        public string SvcPreviousController {get; set;}
        
        ///The file path to the executable for the service
        public string SvcPath {get; set;}
        
        ///Previous file path to the executable for the service
        public string SvcPreviousPath {get; set;}
        
        ///Registry key name
        public string RegistryKey {get; set;}
        
        ///Registry hive for the changed registry key
        public string Hive {get; set;}
        
        ///Name of the value for the registry key being tracked
        public string ValueName {get; set;}
        
        ///Data contained in the value and registry key being tracked
        public string ValueData {get; set;}
        
        ///Previous registry value data
        public string PreviousValueData {get; set;}
        
        ///Type of the value for the registry key being tracked
        public string ValueType {get; set;}
        
        ///Previous registry value type
        public string PreviousValueType {get; set;}
        
        ///
        public string Name {get; set;}
        
        ///File system path for the changed file
        public string FileSystemPath {get; set;}
        
        ///Current size of the changed file
        public long Size {get; set;}
        
        ///Previous file size
        public long PreviousSize {get; set;}
        
        ///Date that the item was created
        public datetime DateCreated {get; set;}
        
        ///Previous date created time
        public datetime PreviousDateCreated {get; set;}
        
        ///Date that the item was last modified
        public datetime DateModified {get; set;}
        
        ///Previous date modified time
        public datetime PreviousDateModified {get; set;}
        
        ///
        public string Attributes {get; set;}
        
        ///Previous attributes value
        public string PreviousAttributes {get; set;}
        
        ///The Access-Control List specifies which users or system processes are granted access to objects
        public string Acls {get; set;}
        
        ///Previous Acl value
        public string PreviousAcls {get; set;}
        
        ///Fields that were changed as part of the change record
        public string FieldsChanged {get; set;}
        
        ///Checksum of the file content
        public string FileContentChecksum {get; set;}
        
        ///Previous file content checksum value
        public string PreviousFileContentChecksum {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///Name of a resource's assigned management group
        public string ManagementGroupName {get; set;}
        
        ///Date and time the record was created.
        public datetime TimeGenerated {get; set;}
        
        ///
        public string VMUUID {get; set;}
        
        ///Age of the last snapshot
        public long LastSnapshotAge {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
