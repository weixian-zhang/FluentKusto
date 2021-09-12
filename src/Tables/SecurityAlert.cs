
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class SecurityAlert : TableBase<SecurityAlert>
    {

            /// 
            public DateTime TimeGenerated {get; set;}
            
            /// 
            public string DisplayName {get; set;}
            
            /// 
            public string AlertName {get; set;}
            
            /// 
            public string AlertSeverity {get; set;}
            
            /// 
            public string Description {get; set;}
            
            /// 
            public string ProviderName {get; set;}
            
            /// 
            public string VendorName {get; set;}
            
            /// 
            public string VendorOriginalId {get; set;}
            
            /// 
            public string SystemAlertId {get; set;}
            
            /// 
            public string ResourceId {get; set;}
            
            /// 
            public string SourceComputerId {get; set;}
            
            /// 
            public string ConfidenceLevel {get; set;}
            
            /// 
            public float ConfidenceScore {get; set;}
            
            /// 
            public bool IsIncident {get; set;}
            
            /// 
            public DateTime StartTime {get; set;}
            
            /// 
            public DateTime EndTime {get; set;}
            
            /// 
            public DateTime ProcessingEndTime {get; set;}
            
            /// 
            public string RemediationSteps {get; set;}
            
            /// 
            public string ExtendedProperties {get; set;}
            
            /// 
            public string Entities {get; set;}
            
            /// 
            public string WorkspaceSubscriptionId {get; set;}
            
            /// 
            public string WorkspaceResourceGroup {get; set;}
            
            /// 
            public string ExtendedLinks {get; set;}
            
            /// 
            public string ProductName {get; set;}
            
            /// 
            public string ProductComponentName {get; set;}
            
            /// 
            public string AlertLink {get; set;}
            
            /// 
            public string Status {get; set;}
            
            /// 
            public string CompromisedEntity {get; set;}
            
            /// 
            public string Tactics {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
                }
}
