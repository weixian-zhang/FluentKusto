

namespace FluentKusto
{
    public class ConfigurationData
    {

        ///
        public string Computer {get; set;}
        
        ///Type of configuration item: Files Software WindowsServices Registry Daemons
        public string ConfigDataType {get; set;}
        
        ///
        public string SourceComputerId {get; set;}
        
        ///Type of the software: Application Package Update
        public string SoftwareType {get; set;}
        
        ///Name of the software
        public string SoftwareName {get; set;}
        
        ///Software publisher name
        public string Publisher {get; set;}
        
        ///Current software version
        public string CurrentVersion {get; set;}
        
        ///Instruction set architecture for the software being tracked
        public string Architecture {get; set;}
        
        ///
        public string Location {get; set;}
        
        ///Description of the software
        public string SoftwareDescription {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///
        public string ManagementGroupName {get; set;}
        
        ///Date and time the record was created.
        public datetime TimeGenerated {get; set;}
        
        ///
        public string VMUUID {get; set;}
        
        ///Human-frinedly name for the service
        public string SvcDisplayName {get; set;}
        
        ///Name of the service
        public string SvcName {get; set;}
        
        ///Current state of the service
        public string SvcState {get; set;}
        
        ///Startup behavior of the service
        public string SvcStartupType {get; set;}
        
        ///User account that is associated with the service executable explicitly to provide a security context for the service
        public string SvcAccount {get; set;}
        
        ///Modes used by the daemon for system operation
        public string SvcRunlevels {get; set;}
        
        ///Service property that was changed
        public string SvcController {get; set;}
        
        ///The file path to the executable for the service
        public string SvcPath {get; set;}
        
        ///Parent process for the daemon
        public string SvcDescription {get; set;}
        
        ///Registy key name
        public string RegistryKey {get; set;}
        
        ///Registry hive for the reporting registry key
        public string Hive {get; set;}
        
        ///Name of the value for the registry key being tracked
        public string ValueName {get; set;}
        
        ///Data contained in the value and registry key being tracked
        public string ValueData {get; set;}
        
        ///Type of the value for the registry key being tracked
        public string ValueType {get; set;}
        
        ///
        public string Name {get; set;}
        
        ///File system path for the reporting file
        public string FileSystemPath {get; set;}
        
        ///Size of the file
        public long Size {get; set;}
        
        ///Created date of the file
        public datetime DateCreated {get; set;}
        
        ///Last modified date of the file
        public datetime DateModified {get; set;}
        
        ///
        public string Attributes {get; set;}
        
        ///The Access-Control List specifies which users or system processes are granted access to objects
        public string Acls {get; set;}
        
        ///Checksum of the reporting file
        public string FileContentChecksum {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
