
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class Perf : TableBase<Perf>
    {

            /// Computer that the event was collected from.
            public string Computer {get; set;}
            
            /// Name of the performance object.
            public string ObjectName {get; set;}
            
            /// Name of the performance counter.
            public string CounterName {get; set;}
            
            /// Name of the event instance. Empty if no instance.
            public string InstanceName {get; set;}
            
            /// 
            public float CounterValue {get; set;}
            
            /// Date and time the data was sampled.
            public DateTime TimeGenerated {get; set;}
            
            /// Type of agent the event was collected from. Possible values are OpsManager Linux and AzureStorage.
            public string SourceSystem {get; set;}
            
            /// Full path of the counter in the form \\<Computer>\object(instance)\counter.
            public string CounterPath {get; set;}
            
            /// 
            public float Min {get; set;}
            
            /// 
            public float Max {get; set;}
            
            /// 
            public int SampleCount {get; set;}
            
            /// 
            public DateTime BucketStartTime {get; set;}
            
            /// 
            public DateTime BucketEndTime {get; set;}
            
            /// 
            public float StandardDeviation {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
