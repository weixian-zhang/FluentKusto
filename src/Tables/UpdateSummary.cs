
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class UpdateSummary : TableBase<UpdateSummary>
    {

            /// 
            public string SourceSystem {get; set;}
            
            /// 
            public DateTime TimeGenerated {get; set;}
            
            /// 
            public string ManagementGroupName {get; set;}
            
            /// 
            public string SourceComputerId {get; set;}
            
            /// 
            public int OldestMissingSecurityUpdateInDays {get; set;}
            
            /// 
            public string OldestMissingSecurityUpdateBucket {get; set;}
            
            /// 
            public string WindowsUpdateSetting {get; set;}
            
            /// 
            public string WindowsUpdateAgentVersion {get; set;}
            
            /// 
            public string WSUSServer {get; set;}
            
            /// 
            public string Computer {get; set;}
            
            /// 
            public string OsVersion {get; set;}
            
            /// 
            public string NETRuntimeVersion {get; set;}
            
            /// 
            public int CriticalUpdatesMissing {get; set;}
            
            /// 
            public int SecurityUpdatesMissing {get; set;}
            
            /// 
            public int OtherUpdatesMissing {get; set;}
            
            /// 
            public int TotalUpdatesMissing {get; set;}
            
            /// 
            public bool RestartPending {get; set;}
            
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
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
