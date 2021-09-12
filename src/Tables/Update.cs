
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class Update : TableBase<Update>
    {

            /// 
            public string SourceSystem {get; set;}
            
            /// 
            public DateTime TimeGenerated {get; set;}
            
            /// 
            public string SourceComputerId {get; set;}
            
            /// 
            public string Title {get; set;}
            
            /// 
            public string Classification {get; set;}
            
            /// 
            public DateTime PublishedDate {get; set;}
            
            /// 
            public string Computer {get; set;}
            
            /// 
            public string UpdateState {get; set;}
            
            /// 
            public string Product {get; set;}
            
            /// 
            public string OSType {get; set;}
            
            /// 
            public string ProductVersion {get; set;}
            
            /// 
            public string ProductArch {get; set;}
            
            /// 
            public string CVENumbers {get; set;}
            
            /// 
            public string BulletinUrl {get; set;}
            
            /// 
            public string BulletinID {get; set;}
            
            /// 
            public string PackageRepository {get; set;}
            
            /// 
            public string PackageSeverity {get; set;}
            
            /// 
            public string OSName {get; set;}
            
            /// 
            public string OSVersion {get; set;}
            
            /// 
            public string OSFullName {get; set;}
            
            /// 
            public string SubscriptionId {get; set;}
            
            /// 
            public string ResourceGroup {get; set;}
            
            /// 
            public string ResourceProvider {get; set;}
            
            /// 
            public string Resource {get; set;}
            
            /// 
            public string ResourceId {get; set;}
            
            /// 
            public string ResourceType {get; set;}
            
            /// 
            public string ComputerEnvironment {get; set;}
            
            /// 
            public string VMUUID {get; set;}
            
            /// 
            public string ManagementGroupName {get; set;}
            
            /// 
            public string MSRCSeverity {get; set;}
            
            /// 
            public string KBID {get; set;}
            
            /// 
            public string UpdateID {get; set;}
            
            /// 
            public string RevisionNumber {get; set;}
            
            /// 
            public bool Optional {get; set;}
            
            /// 
            public string RebootBehavior {get; set;}
            
            /// 
            public string MSRCBulletinID {get; set;}
            
            /// 
            public bool Approved {get; set;}
            
            /// 
            public string ApprovalSource {get; set;}
            
            /// 
            public float InstallTimePredictionSeconds {get; set;}
            
            /// 
            public float InstallTimeDeviationRangeSeconds {get; set;}
            
            /// 
            public bool InstallTimeAvailable {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
