
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class IntuneAuditLogs : TableBase<IntuneAuditLogs>
    {

            /// 
            public string SourceSystem {get; set;}
            
            /// 
            public DateTime TimeGenerated {get; set;}
            
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
            public string Identity {get; set;}
            
            /// 
            public string Properties {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
                }
}
