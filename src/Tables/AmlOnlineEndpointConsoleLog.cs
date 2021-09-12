
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class AmlOnlineEndpointConsoleLog : TableBase<AmlOnlineEndpointConsoleLog>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The operation associated with log record.
            public string OperationName {get; set;}
            
            /// The ID of the instance that generated this log record.
            public string InstanceId {get; set;}
            
            /// The name of the deployment associated with the log record.
            public string DeploymentName {get; set;}
            
            /// The name of the container where the log was generated.
            public string ContainerName {get; set;}
            
            /// The content of the log.
            public string Message {get; set;}
            
            /// 
            public string SourceSystem {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
