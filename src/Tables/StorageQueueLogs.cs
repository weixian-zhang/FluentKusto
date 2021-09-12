
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class StorageQueueLogs : TableBase<StorageQueueLogs>
    {

            /// 
            public string TenantId {get; set;}
            
            /// The Universal Time Coordinated (UTC) time when the request was received by storage.
            public DateTime TimeGenerated {get; set;}
            
            /// The name of the storage account.
            public string AccountName {get; set;}
            
            /// The location of storage account.
            public string Location {get; set;}
            
            /// The protocol that is used in the operation.
            public string Protocol {get; set;}
            
            /// The type of REST operation that was performed.
            public string OperationName {get; set;}
            
            /// The type of authentication that was used to make the request.
            public string AuthenticationType {get; set;}
            
            /// The HTTP status code for the request. If the request is interrupted, this value might be set to Unknown.
            public string StatusCode {get; set;}
            
            /// The status of the requested operation.
            public string StatusText {get; set;}
            
            /// The total time, expressed in milliseconds, to perform the requested operation. This includes the time to read the incoming request, and to send the response to the requester.
            public float DurationMs {get; set;}
            
            /// The total time expressed in milliseconds to perform the requested operation. This value doesn't include network latency (the time to read the incoming request and send the response to the requester).
            public float ServerLatencyMs {get; set;}
            
            /// Uniform resource identifier that is requested.
            public string Uri {get; set;}
            
            /// The IP address of the requester, including the port number.
            public string CallerIpAddress {get; set;}
            
            /// The ID that is used to correlate logs across resources.
            public string CorrelationId {get; set;}
            
            /// The schema version of the log.
            public string SchemaVersion {get; set;}
            
            /// The storage service version that was specified when the request was made. This is equivalent to the value of the x-ms-version header.
            public string OperationVersion {get; set;}
            
            /// The hash of authentication token.
            public string AuthenticationHash {get; set;}
            
            /// The OAuth object ID of the requester.
            public string RequesterObjectId {get; set;}
            
            /// The OAuth tenant ID of identity.
            public string RequesterTenantId {get; set;}
            
            /// The Open Authorization (OAuth) application ID that is used as the requester.
            public string RequesterAppId {get; set;}
            
            /// The OAuth audience of the request.
            public string RequesterAudience {get; set;}
            
            /// The OAuth token issuer.
            public string RequesterTokenIssuer {get; set;}
            
            /// The User Principal Names of requestor.
            public string RequesterUpn {get; set;}
            
            /// Detailed policy information used to authorize the request.
            public dynamic AuthorizationDetails {get; set;}
            
            /// The User-Agent header value, in quotes.
            public string UserAgentHeader {get; set;}
            
            /// The Referer header value.
            public string ReferrerHeader {get; set;}
            
            /// The x-ms-client-request-id header value of the request.
            public string ClientRequestId {get; set;}
            
            /// The ETag identifier for the returned object, in quotes.
            public string Etag {get; set;}
            
            /// The service associated with this request.
            public string ServiceType {get; set;}
            
            /// The number of each logged operation that is involved in the request. This count starts with an index of 0. Some requests require more than one operation, such as a request to copy a blob. Most requests perform only one operation.
            public int OperationCount {get; set;}
            
            /// The size of the request header expressed in bytes. If a request is unsuccessful, this value might be empty.
            public long RequestHeaderSize {get; set;}
            
            /// The size of the request packets, expressed in bytes, that are read by the storage service. If a request is unsuccessful, this value might be empty.
            public long RequestBodySize {get; set;}
            
            /// The size of the response header expressed in bytes. If a request is unsuccessful, this value might be empty.
            public long ResponseHeaderSize {get; set;}
            
            /// The size of the response packets written by the storage service, in bytes. If a request is unsuccessful, this value may be empty.
            public long ResponseBodySize {get; set;}
            
            /// The value of either the Content-MD5 header or the x-ms-content-md5 header in the request. The MD5 hash value specified in this field represents the content in the request.
            public string RequestMd5 {get; set;}
            
            /// The value of the MD5 hash calculated by the storage service.
            public string ResponseMd5 {get; set;}
            
            /// The Last Modified Time (LMT) for the returned object. This field is empty for operations that can return multiple objects.
            public DateTime LastModifiedTime {get; set;}
            
            /// A semicolon-separated list of key-value pairs that represent a condition.
            public string ConditionsUsed {get; set;}
            
            /// The value of the Content-Length header for the request sent to the storage service.
            public long ContentLengthHeader {get; set;}
            
            /// The category of requested operation.
            public string Category {get; set;}
            
            /// The TLS version used in the connection of request.
            public string TlsVersion {get; set;}
            
            /// Records any violations in the request SAS token as per the SAS policy set in the storage account. Ex: longer SAS token duration specified than allowed per SAS policy
            public string SasExpiryStatus {get; set;}
            
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
