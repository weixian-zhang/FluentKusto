
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ADFPipelineRun : TableBase<ADFPipelineRun>
    {

            /// 
            public string TenantId {get; set;}
            
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
            public string CorrelationId {get; set;}
            
            /// 
            public string Level {get; set;}
            
            /// 
            public string Location {get; set;}
            
            /// 
            public string Tags {get; set;}
            
            /// 
            public string Status {get; set;}
            
            /// 
            public string UserProperties {get; set;}
            
            /// 
            public string Annotations {get; set;}
            
            /// 
            public string EventMessage {get; set;}
            
            /// 
            public DateTime Start {get; set;}
            
            /// 
            public DateTime End {get; set;}
            
            /// 
            public string FailureType {get; set;}
            
            /// 
            public string PipelineName {get; set;}
            
            /// 
            public string RunId {get; set;}
            
            /// 
            public string Predecessors {get; set;}
            
            /// 
            public string Parameters {get; set;}
            
            /// 
            public string SystemParameters {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
