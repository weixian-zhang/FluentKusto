

namespace FluentKusto
{
    public class ApiManagementGatewayLogs
    {

        ///
        public string TenantId {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string OperationName {get; set;}
        
        ///
        public string CorrelationId {get; set;}
        
        ///
        public string Region {get; set;}
        
        ///
        public bool IsRequestSuccess {get; set;}
        
        ///
        public string Category {get; set;}
        
        ///
        public long TotalTime {get; set;}
        
        ///
        public string CallerIpAddress {get; set;}
        
        ///
        public string Method {get; set;}
        
        ///
        public string Url {get; set;}
        
        ///
        public string ClientProtocol {get; set;}
        
        ///
        public int ResponseCode {get; set;}
        
        ///
        public string BackendMethod {get; set;}
        
        ///
        public string BackendUrl {get; set;}
        
        ///
        public int BackendResponseCode {get; set;}
        
        ///
        public string BackendProtocol {get; set;}
        
        ///
        public int RequestSize {get; set;}
        
        ///
        public int ResponseSize {get; set;}
        
        ///
        public string Cache {get; set;}
        
        ///
        public long CacheTime {get; set;}
        
        ///
        public long BackendTime {get; set;}
        
        ///
        public long ClientTime {get; set;}
        
        ///
        public string ApiId {get; set;}
        
        ///
        public string OperationId {get; set;}
        
        ///
        public string ProductId {get; set;}
        
        ///
        public string UserId {get; set;}
        
        ///
        public string ApimSubscriptionId {get; set;}
        
        ///
        public string BackendId {get; set;}
        
        ///
        public long LastErrorElapsed {get; set;}
        
        ///
        public string LastErrorSource {get; set;}
        
        ///
        public string LastErrorScope {get; set;}
        
        ///
        public string LastErrorSection {get; set;}
        
        ///
        public string LastErrorReason {get; set;}
        
        ///
        public string LastErrorMessage {get; set;}
        
        ///
        public string ApiRevision {get; set;}
        
        ///
        public string ClientTlsVersion {get; set;}
        
        ///
        public dynamic RequestHeaders {get; set;}
        
        ///
        public dynamic ResponseHeaders {get; set;}
        
        ///
        public dynamic BackendRequestHeaders {get; set;}
        
        ///
        public dynamic BackendResponseHeaders {get; set;}
        
        ///Client request body
        public string RequestBody {get; set;}
        
        ///Gateway response body
        public string ResponseBody {get; set;}
        
        ///Backend request body
        public string BackendRequestBody {get; set;}
        
        ///Backend response body
        public string BackendResponseBody {get; set;}
        
        ///
        public dynamic Errors {get; set;}
        
        ///Records emitted by trace policies
        public dynamic TraceRecords {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
