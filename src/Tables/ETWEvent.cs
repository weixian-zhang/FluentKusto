
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class ETWEvent : TableBase<ETWEvent>
    {

            /// 
            public string SourceSystem {get; set;}
            
            /// 
            public DateTime TimeGenerated {get; set;}
            
            /// 
            public string Computer {get; set;}
            
            /// 
            public string Level {get; set;}
            
            /// 
            public string ProviderGuid {get; set;}
            
            /// 
            public string EventSourceName {get; set;}
            
            /// 
            public int EventId {get; set;}
            
            /// 
            public int Pid {get; set;}
            
            /// 
            public int Tid {get; set;}
            
            /// 
            public string OpcodeName {get; set;}
            
            /// 
            public string KeywordName {get; set;}
            
            /// 
            public string TaskName {get; set;}
            
            /// 
            public string ChannelName {get; set;}
            
            /// 
            public string AzureDeploymentID {get; set;}
            
            /// 
            public string Role {get; set;}
            
            /// 
            public string EventMessage {get; set;}
            
            /// 
            public string Message {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
                }
}
