
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class Operation : TableBase<Operation>
    {

            /// Value is OpsManager for all records in this table.
            public string SourceSystem {get; set;}
            
            /// Date and time that the record was created.
            public DateTime TimeGenerated {get; set;}
            
            /// Name of the Operations Manager management group for System Center Operations Manager agents.
            public string ManagementGroupName {get; set;}
            
            /// Unique GUID identifier for a computer.
            public string SourceComputerId {get; set;}
            
            /// Operation status description. Ccommon values include Warning Succeeded Failed Error.
            public string OperationStatus {get; set;}
            
            /// Name of a physical or virtual machine having membership with Log Analytics agent.
            public string Computer {get; set;}
            
            /// User friendly string that describes further details about the operation
            public string Detail {get; set;}
            
            /// Name of the area that produced the record.
            public string OperationCategory {get; set;}
            
            /// Name of the managed solution that produced the record. Can also include other sources such as RestAPI.
            public string Solution {get; set;}
            
            /// Reference URL for additional contextual information.
            public string HelpLink {get; set;}
            
            /// Operation ID. Can be a GUID or string.
            public string OperationKey {get; set;}
            
            /// Deprecated.
            public string ErrorId {get; set;}
            
            /// GUID that is shared with telemetry belonging to the same uber action.
            public string CorrelationId {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
