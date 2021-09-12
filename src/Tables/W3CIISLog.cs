
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class W3CIISLog : TableBase<W3CIISLog>
    {

            /// Type of agent the event was collected from. Possible values are OpsManager and AzureStorage.
            public string SourceSystem {get; set;}
            
            /// Date and time the record was created.
            public DateTime TimeGenerated {get; set;}
            
            /// Name of the IIS site.
            public string sSiteName {get; set;}
            
            /// IP address of the server on which the log file entry was generated.
            public string sIP {get; set;}
            
            /// Method of the request such as GET or POST.
            public string csMethod {get; set;}
            
            /// Target of the action such as a web page for example Default.htm.
            public string csUriStem {get; set;}
            
            /// The query if any that the client was trying to perform. A Universal Resource Identifier (URI) query is necessary only for dynamic pages.
            public string csUriQuery {get; set;}
            
            /// Server port number that is configured for the service.
            public int sPort {get; set;}
            
            /// Name of the authenticated user that accessed the server. Anonymous users are indicated by a hyphen.
            public string csUserName {get; set;}
            
            /// IP address of the client that accessed the web server.
            public string cIP {get; set;}
            
            /// Protocol version that the client used.
            public string csVersion {get; set;}
            
            /// Browser type of the client.
            public string csUserAgent {get; set;}
            
            /// Content of the cookie sent or received if any.
            public string csCookie {get; set;}
            
            /// Site that the user last visited. This site provided a link to the current site.
            public string csReferer {get; set;}
            
            /// Host header name if any.
            public string csHost {get; set;}
            
            /// HTTP status code.
            public string scStatus {get; set;}
            
            /// Substatus error code.
            public string scSubStatus {get; set;}
            
            /// Windows status code.
            public string scWin32Status {get; set;}
            
            /// Number of bytes that the server sent.
            public long scBytes {get; set;}
            
            /// Number of bytes that the server received.
            public long csBytes {get; set;}
            
            /// Length of time to process the request in milliseconds.
            public long TimeTaken {get; set;}
            
            /// Name of the computer that the event was collected from.
            public string Computer {get; set;}
            
            /// Name of the management group for Operations Manager agents. For other agents this is AOI-<workspace ID>.
            public string ManagementGroupName {get; set;}
            
            /// Only populated for IIS logs collected from Azure Cloud Services (through Azure Diagnostics Extension).
            public string MaliciousIP {get; set;}
            
            /// Only populated for IIS logs collected from Azure Cloud Services (through Azure Diagnostics Extension).
            public string IndicatorThreatType {get; set;}
            
            /// Only populated for IIS logs collected from Azure Cloud Services (through Azure Diagnostics Extension).
            public string Description {get; set;}
            
            /// Only populated for IIS logs collected from Azure Cloud Services through Azure Diagnostics Extension.
            public string TLPLevel {get; set;}
            
            /// Only populated for IIS logs collected from Azure Cloud Services through Azure Diagnostics Extension.
            public string Confidence {get; set;}
            
            /// Only populated for IIS logs collected from Azure Cloud Services through Azure Diagnostics Extension.
            public int Severity {get; set;}
            
            /// Only populated for IIS logs collected from Azure Cloud Services (through Azure Diagnostics Extension).
            public string FirstReportedDateTime {get; set;}
            
            /// Only populated for IIS logs collected from Azure Cloud Services (through Azure Diagnostics Extension).
            public string LastReportedDateTime {get; set;}
            
            /// Only populated for IIS logs collected from Azure Cloud Services (through Azure Diagnostics Extension).
            public string IsActive {get; set;}
            
            /// Longitude of the client IP address.
            public float RemoteIPLongitude {get; set;}
            
            /// Latitude of the client IP address.
            public float RemoteIPLatitude {get; set;}
            
            /// Country/region of the IP address of the client.
            public string RemoteIPCountry {get; set;}
            
            /// Only populated for IIS logs collected from Azure Cloud Services through Azure Diagnostics Extension.
            public string StorageAccount {get; set;}
            
            /// Azure deployment ID of the cloud service the log belongs to. Only populated when events are collected using Azure Diagnostics agent  when data is pulled from Azure storage.
            public string AzureDeploymentID {get; set;}
            
            /// Role instance of the cloud service the log belongs to. Only populated when events are collected using Azure Diagnostics agent and data is pulled from Azure storage.
            public string Role {get; set;}
            
            /// Role of the cloud service the log belongs to. Only populated when events are collected using Azure Diagnostics agent and data is pulled from Azure storage.
            public string RoleInstance {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
