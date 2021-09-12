
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class Event : TableBase<Event>
    {

            /// Type of agent the event was collected from. Possible values are OpsManager Linux and AzureStorage.
            public string SourceSystem {get; set;}
            
            /// Date and time the record was created.
            public DateTime TimeGenerated {get; set;}
            
            /// Source of the event.
            public string Source {get; set;}
            
            /// Name of the event log that the event was collected from.
            public string EventLog {get; set;}
            
            /// Name of the computer that the event was collected from.
            public string Computer {get; set;}
            
            /// Severity of the event in numeric form.
            public int EventLevel {get; set;}
            
            /// Severity of the event in text form.
            public string EventLevelName {get; set;}
            
            /// Event parameter values in XML format.
            public string ParameterXml {get; set;}
            
            /// All event data in raw format.
            public string EventData {get; set;}
            
            /// Number of the event.
            public int EventID {get; set;}
            
            /// Event description with parameter values.
            public string RenderedDescription {get; set;}
            
            /// Azure deployment ID of the cloud service the log belongs to. Only populated when events are collected using Azure Diagnostics agent and collected from Azure storage.
            public string AzureDeploymentID {get; set;}
            
            /// Role of the cloud service the log belongs to. Only populated when events are collected using Azure Diagnostics agent and collected from Azure storage.
            public string Role {get; set;}
            
            /// Category of the event.
            public int EventCategory {get; set;}
            
            /// User name of the account that logged the event.
            public string UserName {get; set;}
            
            /// Event message for the different Languages. The language is defined by the LCID attribute.
            public string Message {get; set;}
            
            /// Name of the management group for System Center Operations Manager agents. For other agents this value is AOI-<workspace ID>
            public string ManagementGroupName {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
