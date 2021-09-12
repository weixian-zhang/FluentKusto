
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class HDInsightJupyterNotebookEvents : TableBase<HDInsightJupyterNotebookEvents>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The timestamp (UTC) of when the log was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The name of the event.
            public string EventName {get; set;}
            
            /// Varies based of of type of event.
            public string Dim0 {get; set;}
            
            /// Varies based of of type of event.
            public DateTime Dim1 {get; set;}
            
            /// Varies based of of type of event.
            public int Dim2 {get; set;}
            
            /// Varies based of of type of event.
            public int Dim3 {get; set;}
            
            /// Varies based of of type of event.
            public string Dim4 {get; set;}
            
            /// Varies based of of type of event.
            public int Dim5 {get; set;}
            
            /// Varies based of of type of event.
            public string Dim6 {get; set;}
            
            /// Varies based of of type of event.
            public string Dim7 {get; set;}
            
            /// Varies based of of type of event.
            public string Dim8 {get; set;}
            
            /// Varies based of of type of event.
            public string Dim9 {get; set;}
            
            /// Varies based of of type of event.
            public string Dim10 {get; set;}
            
            /// The tenant ID of the cluster running the application.
            public string ClusterTenantId {get; set;}
            
            /// The type of node the application running the application.
            public string Role {get; set;}
            
            /// The FQDN of the host.
            public string Host {get; set;}
            
            /// The DNS name of the cluster running the application.
            public string ClusterDnsName {get; set;}
            
            /// The region of the cluster running the application.
            public string Region {get; set;}
            
            /// The IP Address of the node running the application.
            public string IpAddress {get; set;}
            
            /// The subscription ID of the cluster running the application
            public string UserSubscriptionId {get; set;}
            
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
