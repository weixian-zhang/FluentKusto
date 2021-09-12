
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AutoscaleScaleActionsLog : TableBase<AutoscaleScaleActionsLog>
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
            public string TargetResourceId {get; set;}
            
            /// 
            public bool CreatedAsyncScaleActionJob {get; set;}
            
            /// 
            public string CreatedAsyncScaleActionJobId {get; set;}
            
            /// 
            public int CurrentInstanceCount {get; set;}
            
            /// 
            public int NewInstanceCount {get; set;}
            
            /// 
            public string ScaleActionMessage {get; set;}
            
            /// 
            public string ScaleActionOperationId {get; set;}
            
            /// 
            public string ScaleActionOperationStatus {get; set;}
            
            /// 
            public string ScaleDirection {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
                }
}
