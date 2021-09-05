

namespace FluentKusto
{
    public class AzureDiagnostics
    {

        ///
        public string TenantId {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string ResourceId {get; set;}
        
        ///
        public string Category {get; set;}
        
        ///
        public string ResourceGroup {get; set;}
        
        ///
        public string SubscriptionId {get; set;}
        
        ///
        public string ResourceProvider {get; set;}
        
        ///
        public string Resource {get; set;}
        
        ///
        public string ResourceType {get; set;}
        
        ///
        public string OperationName {get; set;}
        
        ///
        public string ResultType {get; set;}
        
        ///
        public string CorrelationId {get; set;}
        
        ///
        public string ResultDescription {get; set;}
        
        ///
        public string Tenant_g {get; set;}
        
        ///
        public string JobId_g {get; set;}
        
        ///
        public string RunbookName_s {get; set;}
        
        ///
        public string StreamType_s {get; set;}
        
        ///
        public string Caller_s {get; set;}
        
        ///
        public string requestUri_s {get; set;}
        
        ///
        public string Level {get; set;}
        
        ///
        public string CallerIPAddress {get; set;}
        
        ///
        public string status_s {get; set;}
        
        ///
        public string Message {get; set;}
        
        ///
        public string userAgent_s {get; set;}
        
        ///
        public string ruleName_s {get; set;}
        
        ///
        public string httpMethod_s {get; set;}
        
        ///
        public string instanceId_s {get; set;}
        
        ///
        public string httpVersion_s {get; set;}
        
        ///
        public datetime startTime_t {get; set;}
        
        ///
        public datetime endTime_t {get; set;}
        
        ///
        public string clientIP_s {get; set;}
        
        ///
        public string host_s {get; set;}
        
        ///
        public string requestQuery_s {get; set;}
        
        ///
        public string sslEnabled_s {get; set;}
        
        ///
        public real clientPort_d {get; set;}
        
        ///
        public real httpStatus_d {get; set;}
        
        ///
        public real receivedBytes_d {get; set;}
        
        ///
        public real sentBytes_d {get; set;}
        
        ///
        public real timeTaken_d {get; set;}
        
        ///
        public string workflowId_s {get; set;}
        
        ///
        public string resource_location_s {get; set;}
        
        ///
        public string resource_workflowId_g {get; set;}
        
        ///
        public string resource_resourceGroupName_s {get; set;}
        
        ///
        public string resource_subscriptionId_g {get; set;}
        
        ///
        public string resource_runId_s {get; set;}
        
        ///
        public string resource_workflowName_s {get; set;}
        
        ///
        public string _schema_s {get; set;}
        
        ///
        public string correlation_clientTrackingId_s {get; set;}
        
        ///
        public string code_s {get; set;}
        
        ///
        public string resource_triggerName_s {get; set;}
        
        ///
        public string resource_originRunId_s {get; set;}
        
        ///
        public string resource_actionName_s {get; set;}
        
        ///
        public string correlation_actionTrackingId_g {get; set;}
        
        ///
        public string RunOn_s {get; set;}
        
        ///
        public string SourceSystem {get; set;}
        
        ///
        public string ManagementGroupName {get; set;}
        
        ///
        public string Computer {get; set;}
        
        ///
        public string RawData {get; set;}
        
        ///
        public datetime timeStamp_t {get; set;}
        
        ///
        public string listenerName_s {get; set;}
        
        ///
        public string backendPoolName_s {get; set;}
        
        ///
        public string backendSettingName_s {get; set;}
        
        ///
        public string originalRequestUriWithArgs_s {get; set;}
        
        ///
        public string transactionId_g {get; set;}
        
        ///
        public string sslCipher_s {get; set;}
        
        ///
        public string sslProtocol_s {get; set;}
        
        ///
        public string sslClientVerify_s {get; set;}
        
        ///
        public string sslClientCertificateFingerprint_s {get; set;}
        
        ///
        public string sslClientCertificateIssuerName_s {get; set;}
        
        ///
        public string serverRouted_s {get; set;}
        
        ///
        public string serverStatus_s {get; set;}
        
        ///
        public string serverResponseLatency_s {get; set;}
        
        ///
        public string originalHost_s {get; set;}
        
        ///
        public string clientIp_s {get; set;}
        
        ///
        public string clientPort_s {get; set;}
        
        ///
        public string ruleSetType_s {get; set;}
        
        ///
        public string ruleSetVersion_s {get; set;}
        
        ///
        public string ruleId_s {get; set;}
        
        ///
        public string action_s {get; set;}
        
        ///
        public string site_s {get; set;}
        
        ///
        public string details_message_s {get; set;}
        
        ///
        public string details_data_s {get; set;}
        
        ///
        public string details_file_s {get; set;}
        
        ///
        public string details_line_s {get; set;}
        
        ///
        public string hostname_s {get; set;}
        
        ///
        public string policyId_s {get; set;}
        
        ///
        public string policyScope_s {get; set;}
        
        ///
        public string policyScopeName_s {get; set;}
        
        ///
        public string retryHistory_s {get; set;}
        
        ///
        public string error_code_s {get; set;}
        
        ///
        public string error_message_s {get; set;}
        
        ///
        public string responseBody_s {get; set;}
        
        ///
        public string identity_authorization_scope_s {get; set;}
        
        ///
        public string identity_authorization_action_s {get; set;}
        
        ///
        public string identity_authorization_evidence_role_s {get; set;}
        
        ///
        public string identity_authorization_evidence_roleAssignmentScope_s {get; set;}
        
        ///
        public string identity_authorization_evidence_roleAssignmentId_g {get; set;}
        
        ///
        public string identity_authorization_evidence_roleDefinitionId_g {get; set;}
        
        ///
        public string identity_authorization_evidence_principalId_g {get; set;}
        
        ///
        public string identity_authorization_evidence_principalType_s {get; set;}
        
        ///
        public string identity_claims_aud_s {get; set;}
        
        ///
        public string identity_claims_iss_s {get; set;}
        
        ///
        public string identity_claims_iat_s {get; set;}
        
        ///
        public string identity_claims_nbf_s {get; set;}
        
        ///
        public string identity_claims_exp_s {get; set;}
        
        ///
        public string identity_claims_aio_s {get; set;}
        
        ///
        public string identity_claims_appid_g {get; set;}
        
        ///
        public string identity_claims_appidacr_s {get; set;}
        
        ///
        public string identity_claims_http_schemas_microsoft_com_identity_claims_identityprovider_s {get; set;}
        
        ///
        public string identity_claims_http_schemas_microsoft_com_identity_claims_objectidentifier_g {get; set;}
        
        ///
        public string identity_claims_rh_s {get; set;}
        
        ///
        public string identity_claims_http_schemas_xmlsoap_org_ws_2005_05_identity_claims_nameidentifier_g {get; set;}
        
        ///
        public string identity_claims_http_schemas_microsoft_com_identity_claims_tenantid_g {get; set;}
        
        ///
        public string identity_claims_uti_s {get; set;}
        
        ///
        public string identity_claims_ver_s {get; set;}
        
        ///
        public string eventCategory_s {get; set;}
        
        ///
        public string caller_g {get; set;}
        
        ///
        public string eventDataId_g {get; set;}
        
        ///
        public datetime eventSubmissionTimestamp_t {get; set;}
        
        ///
        public string httpRequest_s {get; set;}
        
        ///
        public string resourceProviderValue_s {get; set;}
        
        ///
        public string activityStatusValue_s {get; set;}
        
        ///
        public string statusCode_s {get; set;}
        
        ///
        public string serviceRequestId_g {get; set;}
        
        ///
        public string activitySubstatusValue_s {get; set;}
        
        ///
        public string NodeId_g {get; set;}
        
        ///
        public string NodeName_s {get; set;}
        
        ///
        public string NodeComplianceStatus_s {get; set;}
        
        ///
        public string DscReportId_g {get; set;}
        
        ///
        public string DscReportStatus_s {get; set;}
        
        ///
        public datetime LastSeenTime_t {get; set;}
        
        ///
        public datetime ReportStartTime_t {get; set;}
        
        ///
        public datetime ReportEndTime_t {get; set;}
        
        ///
        public string ConfigurationMode_s {get; set;}
        
        ///
        public string HostName_s {get; set;}
        
        ///
        public real NumberOfResources_d {get; set;}
        
        ///
        public string IPAddress {get; set;}
        
        ///
        public string DscResourceId_s {get; set;}
        
        ///
        public string DscResourceName_s {get; set;}
        
        ///
        public string DscResourceStatus_s {get; set;}
        
        ///
        public string DscModuleName_s {get; set;}
        
        ///
        public string DscModuleVersion_s {get; set;}
        
        ///
        public string DscConfigurationName_s {get; set;}
        
        ///
        public real DscResourceDuration_d {get; set;}
        
        ///
        public string ErrorCode_s {get; set;}
        
        ///
        public string ErrorMessage_s {get; set;}
        
        ///
        public string msg_s {get; set;}
        
        ///
        public dynamic AdditionalFields {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
