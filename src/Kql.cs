using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq.Expressions;
using Newtonsoft.Json.Linq;

namespace FluentKusto
{
    public class Kql
    {
      /// Use in Lambda expressions to mimic the behavior of referencing columns in other operators like Extend


        public Kql()
        {
           //ColRef = new ExpandoObject();
        }

        #region datetime funcs

        public static dynamic ago(string timespan)
        {
           return new object();
        }

        public static dynamic split(string str, char delimiter)
        {
           return new object();
        }

        public static dynamic parse_json(string json)
        {
           return new object();
        }

        public static dynamic array_length(object array)
        {
           return new object();
        }


        #endregion

        #region numeric funcs

      //   public static bool In(string[] elements)
      //   {
      //      return true;
      //   }

      //   public static bool NotIn(string[] elements)
      //   {
      //      return true;
      //   }

        #endregion

        #region general helpers


        /// Represents a n optional Column used by Extend, Project
      //   public static ColumnAssignment<TTable> Column<TTable>(Expression<Func<TTable, object>> assignment)
      //   {
      //      return new ColumnAssignment<TTable>(assignment);
      //   }

      //   /// Represents a mandatory Column used by Extend, Project
      //   public static ColumnAssignment<TTable> Column<TTable>(Expression<Func<TTable, object, object>> assignment)
      //   {
      //      return null;
      //      //return new ColumnAssignment<TTable>(assignment);

      //      //return new ColumnAssignment<TTable>(column, assignment);
      //   }

        #endregion

        #region Tables

        public ITabularOperator<requests> requests{ get; set; } = new requests();

        public ITabularOperator<availabilityResults> availabilityResults{ get; set; } = new availabilityResults();

        public ITabularOperator<browserTimings> browserTimings{ get; set; } = new browserTimings();

        public ITabularOperator<customEvents> customEvents{ get; set; } = new customEvents();

        public ITabularOperator<customMetrics> customMetrics{ get; set; } = new customMetrics();

        public ITabularOperator<dependencies> dependencies{ get; set; } = new dependencies();

        public ITabularOperator<exceptions> exceptions{ get; set; } = new exceptions();

        public ITabularOperator<pageViews> pageViews{ get; set; } = new pageViews();

        public ITabularOperator<performanceCounters> performanceCounters{ get; set; } = new performanceCounters();

        public ITabularOperator<traces> traces{ get; set; } = new traces();

        public ITabularOperator<AACAudit> AACAudit{ get; set; } = new AACAudit();

        public ITabularOperator<AACHttpRequest> AACHttpRequest{ get; set; } = new AACHttpRequest();

        public ITabularOperator<AADDomainServicesAccountLogon> AADDomainServicesAccountLogon{ get; set; } = new AADDomainServicesAccountLogon();

        public ITabularOperator<AADDomainServicesAccountManagement> AADDomainServicesAccountManagement{ get; set; } = new AADDomainServicesAccountManagement();

        public ITabularOperator<AADDomainServicesDirectoryServiceAccess> AADDomainServicesDirectoryServiceAccess{ get; set; } = new AADDomainServicesDirectoryServiceAccess();

        public ITabularOperator<AADDomainServicesLogonLogoff> AADDomainServicesLogonLogoff{ get; set; } = new AADDomainServicesLogonLogoff();

        public ITabularOperator<AADDomainServicesPolicyChange> AADDomainServicesPolicyChange{ get; set; } = new AADDomainServicesPolicyChange();

        public ITabularOperator<AADDomainServicesPrivilegeUse> AADDomainServicesPrivilegeUse{ get; set; } = new AADDomainServicesPrivilegeUse();

        public ITabularOperator<AADManagedIdentitySignInLogs> AADManagedIdentitySignInLogs{ get; set; } = new AADManagedIdentitySignInLogs();

        public ITabularOperator<AADNonInteractiveUserSignInLogs> AADNonInteractiveUserSignInLogs{ get; set; } = new AADNonInteractiveUserSignInLogs();

        public ITabularOperator<AADProvisioningLogs> AADProvisioningLogs{ get; set; } = new AADProvisioningLogs();

        public ITabularOperator<AADRiskyUsers> AADRiskyUsers{ get; set; } = new AADRiskyUsers();

        public ITabularOperator<AADServicePrincipalSignInLogs> AADServicePrincipalSignInLogs{ get; set; } = new AADServicePrincipalSignInLogs();

        public ITabularOperator<AADUserRiskEvents> AADUserRiskEvents{ get; set; } = new AADUserRiskEvents();

        public ITabularOperator<ABSBotRequests> ABSBotRequests{ get; set; } = new ABSBotRequests();

        public ITabularOperator<ABSChannelToBotRequests> ABSChannelToBotRequests{ get; set; } = new ABSChannelToBotRequests();

        public ITabularOperator<ABSDependenciesRequests> ABSDependenciesRequests{ get; set; } = new ABSDependenciesRequests();

        public ITabularOperator<ACICollaborationAudit> ACICollaborationAudit{ get; set; } = new ACICollaborationAudit();

        public ITabularOperator<ACSAuthIncomingOperations> ACSAuthIncomingOperations{ get; set; } = new ACSAuthIncomingOperations();

        public ITabularOperator<ACSBillingUsage> ACSBillingUsage{ get; set; } = new ACSBillingUsage();

        public ITabularOperator<ACSChatIncomingOperations> ACSChatIncomingOperations{ get; set; } = new ACSChatIncomingOperations();

        public ITabularOperator<ACSSMSIncomingOperations> ACSSMSIncomingOperations{ get; set; } = new ACSSMSIncomingOperations();

        public ITabularOperator<AddonAzureBackupAlerts> AddonAzureBackupAlerts{ get; set; } = new AddonAzureBackupAlerts();

        public ITabularOperator<AddonAzureBackupJobs> AddonAzureBackupJobs{ get; set; } = new AddonAzureBackupJobs();

        public ITabularOperator<AddonAzureBackupPolicy> AddonAzureBackupPolicy{ get; set; } = new AddonAzureBackupPolicy();

        public ITabularOperator<AddonAzureBackupProtectedInstance> AddonAzureBackupProtectedInstance{ get; set; } = new AddonAzureBackupProtectedInstance();

        public ITabularOperator<AddonAzureBackupStorage> AddonAzureBackupStorage{ get; set; } = new AddonAzureBackupStorage();

        public ITabularOperator<ADFActivityRun> ADFActivityRun{ get; set; } = new ADFActivityRun();

        public ITabularOperator<ADFPipelineRun> ADFPipelineRun{ get; set; } = new ADFPipelineRun();

        public ITabularOperator<ADFSandboxPipelineRun> ADFSandboxPipelineRun{ get; set; } = new ADFSandboxPipelineRun();

        public ITabularOperator<ADFSSignInLogs> ADFSSignInLogs{ get; set; } = new ADFSSignInLogs();

        public ITabularOperator<ADFSSISIntegrationRuntimeLogs> ADFSSISIntegrationRuntimeLogs{ get; set; } = new ADFSSISIntegrationRuntimeLogs();

        public ITabularOperator<ADFSSISPackageEventMessageContext> ADFSSISPackageEventMessageContext{ get; set; } = new ADFSSISPackageEventMessageContext();

        public ITabularOperator<ADFSSISPackageEventMessages> ADFSSISPackageEventMessages{ get; set; } = new ADFSSISPackageEventMessages();

        public ITabularOperator<ADFSSISPackageExecutableStatistics> ADFSSISPackageExecutableStatistics{ get; set; } = new ADFSSISPackageExecutableStatistics();

        public ITabularOperator<ADFSSISPackageExecutionComponentPhases> ADFSSISPackageExecutionComponentPhases{ get; set; } = new ADFSSISPackageExecutionComponentPhases();

        public ITabularOperator<ADFSSISPackageExecutionDataStatistics> ADFSSISPackageExecutionDataStatistics{ get; set; } = new ADFSSISPackageExecutionDataStatistics();

        public ITabularOperator<ADFTriggerRun> ADFTriggerRun{ get; set; } = new ADFTriggerRun();

        public ITabularOperator<ADPAudit> ADPAudit{ get; set; } = new ADPAudit();

        public ITabularOperator<ADPDiagnostics> ADPDiagnostics{ get; set; } = new ADPDiagnostics();

        public ITabularOperator<ADPRequests> ADPRequests{ get; set; } = new ADPRequests();

        public ITabularOperator<ADTDigitalTwinsOperation> ADTDigitalTwinsOperation{ get; set; } = new ADTDigitalTwinsOperation();

        public ITabularOperator<ADTEventRoutesOperation> ADTEventRoutesOperation{ get; set; } = new ADTEventRoutesOperation();

        public ITabularOperator<ADTModelsOperation> ADTModelsOperation{ get; set; } = new ADTModelsOperation();

        public ITabularOperator<ADTQueryOperation> ADTQueryOperation{ get; set; } = new ADTQueryOperation();

        public ITabularOperator<ADXCommand> ADXCommand{ get; set; } = new ADXCommand();

        public ITabularOperator<ADXIngestionBatching> ADXIngestionBatching{ get; set; } = new ADXIngestionBatching();

        public ITabularOperator<ADXJournal> ADXJournal{ get; set; } = new ADXJournal();

        public ITabularOperator<ADXQuery> ADXQuery{ get; set; } = new ADXQuery();

        public ITabularOperator<ADXTableDetails> ADXTableDetails{ get; set; } = new ADXTableDetails();

        public ITabularOperator<ADXTableUsageStatistics> ADXTableUsageStatistics{ get; set; } = new ADXTableUsageStatistics();

        public ITabularOperator<AegDeliveryFailureLogs> AegDeliveryFailureLogs{ get; set; } = new AegDeliveryFailureLogs();

        public ITabularOperator<AegPublishFailureLogs> AegPublishFailureLogs{ get; set; } = new AegPublishFailureLogs();

        public ITabularOperator<AEWAuditLogs> AEWAuditLogs{ get; set; } = new AEWAuditLogs();

        public ITabularOperator<Alert> Alert{ get; set; } = new Alert();

        public ITabularOperator<AmlComputeClusterEvent> AmlComputeClusterEvent{ get; set; } = new AmlComputeClusterEvent();

        public ITabularOperator<AmlComputeClusterNodeEvent> AmlComputeClusterNodeEvent{ get; set; } = new AmlComputeClusterNodeEvent();

        public ITabularOperator<AmlComputeCpuGpuUtilization> AmlComputeCpuGpuUtilization{ get; set; } = new AmlComputeCpuGpuUtilization();

        public ITabularOperator<AmlComputeInstanceEvent> AmlComputeInstanceEvent{ get; set; } = new AmlComputeInstanceEvent();

        public ITabularOperator<AmlComputeJobEvent> AmlComputeJobEvent{ get; set; } = new AmlComputeJobEvent();

        public ITabularOperator<AmlDataLabelEvent> AmlDataLabelEvent{ get; set; } = new AmlDataLabelEvent();

        public ITabularOperator<AmlDataSetEvent> AmlDataSetEvent{ get; set; } = new AmlDataSetEvent();

        public ITabularOperator<AmlDataStoreEvent> AmlDataStoreEvent{ get; set; } = new AmlDataStoreEvent();

        public ITabularOperator<AmlDeploymentEvent> AmlDeploymentEvent{ get; set; } = new AmlDeploymentEvent();

        public ITabularOperator<AmlEnvironmentEvent> AmlEnvironmentEvent{ get; set; } = new AmlEnvironmentEvent();

        public ITabularOperator<AmlInferencingEvent> AmlInferencingEvent{ get; set; } = new AmlInferencingEvent();

        public ITabularOperator<AmlModelsEvent> AmlModelsEvent{ get; set; } = new AmlModelsEvent();

        public ITabularOperator<AmlOnlineEndpointConsoleLog> AmlOnlineEndpointConsoleLog{ get; set; } = new AmlOnlineEndpointConsoleLog();

        public ITabularOperator<AmlPipelineEvent> AmlPipelineEvent{ get; set; } = new AmlPipelineEvent();

        public ITabularOperator<AmlRunEvent> AmlRunEvent{ get; set; } = new AmlRunEvent();

        public ITabularOperator<AmlRunStatusChangedEvent> AmlRunStatusChangedEvent{ get; set; } = new AmlRunStatusChangedEvent();

        public ITabularOperator<ApiManagementGatewayLogs> ApiManagementGatewayLogs{ get; set; } = new ApiManagementGatewayLogs();

        public ITabularOperator<AppAvailabilityResults> AppAvailabilityResults{ get; set; } = new AppAvailabilityResults();

        public ITabularOperator<AppBrowserTimings> AppBrowserTimings{ get; set; } = new AppBrowserTimings();

        public ITabularOperator<AppDependencies> AppDependencies{ get; set; } = new AppDependencies();

        public ITabularOperator<AppEvents> AppEvents{ get; set; } = new AppEvents();

        public ITabularOperator<AppExceptions> AppExceptions{ get; set; } = new AppExceptions();

        public ITabularOperator<AppMetrics> AppMetrics{ get; set; } = new AppMetrics();

        public ITabularOperator<AppPageViews> AppPageViews{ get; set; } = new AppPageViews();

        public ITabularOperator<AppPerformanceCounters> AppPerformanceCounters{ get; set; } = new AppPerformanceCounters();

        public ITabularOperator<AppPlatformLogsforSpring> AppPlatformLogsforSpring{ get; set; } = new AppPlatformLogsforSpring();

        public ITabularOperator<AppPlatformSystemLogs> AppPlatformSystemLogs{ get; set; } = new AppPlatformSystemLogs();

        public ITabularOperator<AppRequests> AppRequests{ get; set; } = new AppRequests();

        public ITabularOperator<AppServiceAntivirusScanAuditLogs> AppServiceAntivirusScanAuditLogs{ get; set; } = new AppServiceAntivirusScanAuditLogs();

        public ITabularOperator<AppServiceAppLogs> AppServiceAppLogs{ get; set; } = new AppServiceAppLogs();

        public ITabularOperator<AppServiceAuditLogs> AppServiceAuditLogs{ get; set; } = new AppServiceAuditLogs();

        public ITabularOperator<AppServiceConsoleLogs> AppServiceConsoleLogs{ get; set; } = new AppServiceConsoleLogs();

        public ITabularOperator<AppServiceEnvironmentPlatformLogs> AppServiceEnvironmentPlatformLogs{ get; set; } = new AppServiceEnvironmentPlatformLogs();

        public ITabularOperator<AppServiceFileAuditLogs> AppServiceFileAuditLogs{ get; set; } = new AppServiceFileAuditLogs();

        public ITabularOperator<AppServiceHTTPLogs> AppServiceHTTPLogs{ get; set; } = new AppServiceHTTPLogs();

        public ITabularOperator<AppServiceIPSecAuditLogs> AppServiceIPSecAuditLogs{ get; set; } = new AppServiceIPSecAuditLogs();

        public ITabularOperator<AppServicePlatformLogs> AppServicePlatformLogs{ get; set; } = new AppServicePlatformLogs();

        public ITabularOperator<AppSystemEvents> AppSystemEvents{ get; set; } = new AppSystemEvents();

        public ITabularOperator<AppTraces> AppTraces{ get; set; } = new AppTraces();

        public ITabularOperator<AuditLogs> AuditLogs{ get; set; } = new AuditLogs();

        public ITabularOperator<AutoscaleEvaluationsLog> AutoscaleEvaluationsLog{ get; set; } = new AutoscaleEvaluationsLog();

        public ITabularOperator<AutoscaleScaleActionsLog> AutoscaleScaleActionsLog{ get; set; } = new AutoscaleScaleActionsLog();

        public ITabularOperator<AzureActivity> AzureActivity{ get; set; } = new AzureActivity();

        public ITabularOperator<AzureDevOpsAuditing> AzureDevOpsAuditing{ get; set; } = new AzureDevOpsAuditing();

        public ITabularOperator<AzureDiagnostics> AzureDiagnostics{ get; set; } = new AzureDiagnostics();

        public ITabularOperator<AzureMetrics> AzureMetrics{ get; set; } = new AzureMetrics();

        public ITabularOperator<BaiClusterEvent> BaiClusterEvent{ get; set; } = new BaiClusterEvent();

        public ITabularOperator<BaiClusterNodeEvent> BaiClusterNodeEvent{ get; set; } = new BaiClusterNodeEvent();

        public ITabularOperator<BaiJobEvent> BaiJobEvent{ get; set; } = new BaiJobEvent();

        public ITabularOperator<BlockchainApplicationLog> BlockchainApplicationLog{ get; set; } = new BlockchainApplicationLog();

        public ITabularOperator<BlockchainProxyLog> BlockchainProxyLog{ get; set; } = new BlockchainProxyLog();

        public ITabularOperator<CDBCassandraRequests> CDBCassandraRequests{ get; set; } = new CDBCassandraRequests();

        public ITabularOperator<CDBControlPlaneRequests> CDBControlPlaneRequests{ get; set; } = new CDBControlPlaneRequests();

        public ITabularOperator<CDBDataPlaneRequests> CDBDataPlaneRequests{ get; set; } = new CDBDataPlaneRequests();

        public ITabularOperator<CDBGremlinRequests> CDBGremlinRequests{ get; set; } = new CDBGremlinRequests();

        public ITabularOperator<CDBMongoRequests> CDBMongoRequests{ get; set; } = new CDBMongoRequests();

        public ITabularOperator<CDBPartitionKeyRUConsumption> CDBPartitionKeyRUConsumption{ get; set; } = new CDBPartitionKeyRUConsumption();

        public ITabularOperator<CDBPartitionKeyStatistics> CDBPartitionKeyStatistics{ get; set; } = new CDBPartitionKeyStatistics();

        public ITabularOperator<CDBQueryRuntimeStatistics> CDBQueryRuntimeStatistics{ get; set; } = new CDBQueryRuntimeStatistics();

        public ITabularOperator<CommonSecurityLog> CommonSecurityLog{ get; set; } = new CommonSecurityLog();

        public ITabularOperator<ComputerGroup> ComputerGroup{ get; set; } = new ComputerGroup();

        public ITabularOperator<ConfigurationChange> ConfigurationChange{ get; set; } = new ConfigurationChange();

        public ITabularOperator<ConfigurationData> ConfigurationData{ get; set; } = new ConfigurationData();

        public ITabularOperator<ContainerImageInventory> ContainerImageInventory{ get; set; } = new ContainerImageInventory();

        public ITabularOperator<ContainerInventory> ContainerInventory{ get; set; } = new ContainerInventory();

        public ITabularOperator<ContainerLog> ContainerLog{ get; set; } = new ContainerLog();

        public ITabularOperator<ContainerLogV2> ContainerLogV2{ get; set; } = new ContainerLogV2();

        public ITabularOperator<ContainerNodeInventory> ContainerNodeInventory{ get; set; } = new ContainerNodeInventory();

        public ITabularOperator<ContainerRegistryLoginEvents> ContainerRegistryLoginEvents{ get; set; } = new ContainerRegistryLoginEvents();

        public ITabularOperator<ContainerRegistryRepositoryEvents> ContainerRegistryRepositoryEvents{ get; set; } = new ContainerRegistryRepositoryEvents();

        public ITabularOperator<ContainerServiceLog> ContainerServiceLog{ get; set; } = new ContainerServiceLog();

        public ITabularOperator<CoreAzureBackup> CoreAzureBackup{ get; set; } = new CoreAzureBackup();

        public ITabularOperator<DatabricksAccounts> DatabricksAccounts{ get; set; } = new DatabricksAccounts();

        public ITabularOperator<DatabricksClusters> DatabricksClusters{ get; set; } = new DatabricksClusters();

        public ITabularOperator<DatabricksDBFS> DatabricksDBFS{ get; set; } = new DatabricksDBFS();

        public ITabularOperator<DatabricksJobs> DatabricksJobs{ get; set; } = new DatabricksJobs();

        public ITabularOperator<DatabricksNotebook> DatabricksNotebook{ get; set; } = new DatabricksNotebook();

        public ITabularOperator<DatabricksSecrets> DatabricksSecrets{ get; set; } = new DatabricksSecrets();

        public ITabularOperator<DatabricksSQLPermissions> DatabricksSQLPermissions{ get; set; } = new DatabricksSQLPermissions();

        public ITabularOperator<DatabricksSSH> DatabricksSSH{ get; set; } = new DatabricksSSH();

        public ITabularOperator<DatabricksWorkspace> DatabricksWorkspace{ get; set; } = new DatabricksWorkspace();

        public ITabularOperator<ETWEvent> ETWEvent{ get; set; } = new ETWEvent();

        public ITabularOperator<Event> Event{ get; set; } = new Event();

        public ITabularOperator<FailedIngestion> FailedIngestion{ get; set; } = new FailedIngestion();

        public ITabularOperator<FunctionAppLogs> FunctionAppLogs{ get; set; } = new FunctionAppLogs();

        public ITabularOperator<HDInsightAmbariClusterAlerts> HDInsightAmbariClusterAlerts{ get; set; } = new HDInsightAmbariClusterAlerts();

        public ITabularOperator<HDInsightAmbariSystemMetrics> HDInsightAmbariSystemMetrics{ get; set; } = new HDInsightAmbariSystemMetrics();

        public ITabularOperator<HDInsightHadoopAndYarnLogs> HDInsightHadoopAndYarnLogs{ get; set; } = new HDInsightHadoopAndYarnLogs();

        public ITabularOperator<HDInsightHadoopAndYarnMetrics> HDInsightHadoopAndYarnMetrics{ get; set; } = new HDInsightHadoopAndYarnMetrics();

        public ITabularOperator<HDInsightHBaseLogs> HDInsightHBaseLogs{ get; set; } = new HDInsightHBaseLogs();

        public ITabularOperator<HDInsightHBaseMetrics> HDInsightHBaseMetrics{ get; set; } = new HDInsightHBaseMetrics();

        public ITabularOperator<HDInsightHiveAndLLAPLogs> HDInsightHiveAndLLAPLogs{ get; set; } = new HDInsightHiveAndLLAPLogs();

        public ITabularOperator<HDInsightHiveAndLLAPMetrics> HDInsightHiveAndLLAPMetrics{ get; set; } = new HDInsightHiveAndLLAPMetrics();

        public ITabularOperator<HDInsightHiveQueryAppStats> HDInsightHiveQueryAppStats{ get; set; } = new HDInsightHiveQueryAppStats();

        public ITabularOperator<HDInsightHiveTezAppStats> HDInsightHiveTezAppStats{ get; set; } = new HDInsightHiveTezAppStats();

        public ITabularOperator<HDInsightJupyterNotebookEvents> HDInsightJupyterNotebookEvents{ get; set; } = new HDInsightJupyterNotebookEvents();

        public ITabularOperator<HDInsightKafkaLogs> HDInsightKafkaLogs{ get; set; } = new HDInsightKafkaLogs();

        public ITabularOperator<HDInsightKafkaMetrics> HDInsightKafkaMetrics{ get; set; } = new HDInsightKafkaMetrics();

        public ITabularOperator<HDInsightOozieLogs> HDInsightOozieLogs{ get; set; } = new HDInsightOozieLogs();

        public ITabularOperator<HDInsightRangerAuditLogs> HDInsightRangerAuditLogs{ get; set; } = new HDInsightRangerAuditLogs();

        public ITabularOperator<HDInsightSecurityLogs> HDInsightSecurityLogs{ get; set; } = new HDInsightSecurityLogs();

        public ITabularOperator<HDInsightSparkApplicationEvents> HDInsightSparkApplicationEvents{ get; set; } = new HDInsightSparkApplicationEvents();

        public ITabularOperator<HDInsightSparkBlockManagerEvents> HDInsightSparkBlockManagerEvents{ get; set; } = new HDInsightSparkBlockManagerEvents();

        public ITabularOperator<HDInsightSparkEnvironmentEvents> HDInsightSparkEnvironmentEvents{ get; set; } = new HDInsightSparkEnvironmentEvents();

        public ITabularOperator<HDInsightSparkExecutorEvents> HDInsightSparkExecutorEvents{ get; set; } = new HDInsightSparkExecutorEvents();

        public ITabularOperator<HDInsightSparkJobEvents> HDInsightSparkJobEvents{ get; set; } = new HDInsightSparkJobEvents();

        public ITabularOperator<HDInsightSparkLogs> HDInsightSparkLogs{ get; set; } = new HDInsightSparkLogs();

        public ITabularOperator<HDInsightSparkSQLExecutionEvents> HDInsightSparkSQLExecutionEvents{ get; set; } = new HDInsightSparkSQLExecutionEvents();

        public ITabularOperator<HDInsightSparkStageEvents> HDInsightSparkStageEvents{ get; set; } = new HDInsightSparkStageEvents();

        public ITabularOperator<HDInsightSparkStageTaskAccumulables> HDInsightSparkStageTaskAccumulables{ get; set; } = new HDInsightSparkStageTaskAccumulables();

        public ITabularOperator<HDInsightSparkTaskEvents> HDInsightSparkTaskEvents{ get; set; } = new HDInsightSparkTaskEvents();

        public ITabularOperator<HDInsightStormLogs> HDInsightStormLogs{ get; set; } = new HDInsightStormLogs();

        public ITabularOperator<HDInsightStormMetrics> HDInsightStormMetrics{ get; set; } = new HDInsightStormMetrics();

        public ITabularOperator<HDInsightStormTopologyMetrics> HDInsightStormTopologyMetrics{ get; set; } = new HDInsightStormTopologyMetrics();

        public ITabularOperator<HealthStateChangeEvent> HealthStateChangeEvent{ get; set; } = new HealthStateChangeEvent();

        public ITabularOperator<Heartbeat> Heartbeat{ get; set; } = new Heartbeat();

        public ITabularOperator<InsightsMetrics> InsightsMetrics{ get; set; } = new InsightsMetrics();

        public ITabularOperator<IntuneAuditLogs> IntuneAuditLogs{ get; set; } = new IntuneAuditLogs();

        public ITabularOperator<IntuneDeviceComplianceOrg> IntuneDeviceComplianceOrg{ get; set; } = new IntuneDeviceComplianceOrg();

        public ITabularOperator<IntuneDevices> IntuneDevices{ get; set; } = new IntuneDevices();

        public ITabularOperator<IntuneOperationalLogs> IntuneOperationalLogs{ get; set; } = new IntuneOperationalLogs();

        public ITabularOperator<KubeEvents> KubeEvents{ get; set; } = new KubeEvents();

        public ITabularOperator<KubeHealth> KubeHealth{ get; set; } = new KubeHealth();

        public ITabularOperator<KubeMonAgentEvents> KubeMonAgentEvents{ get; set; } = new KubeMonAgentEvents();

        public ITabularOperator<KubeNodeInventory> KubeNodeInventory{ get; set; } = new KubeNodeInventory();

        public ITabularOperator<KubePodInventory> KubePodInventory{ get; set; } = new KubePodInventory();

        public ITabularOperator<KubePVInventory> KubePVInventory{ get; set; } = new KubePVInventory();

        public ITabularOperator<KubeServices> KubeServices{ get; set; } = new KubeServices();

        public ITabularOperator<LAQueryLogs> LAQueryLogs{ get; set; } = new LAQueryLogs();

        public ITabularOperator<LinuxAuditLog> LinuxAuditLog{ get; set; } = new LinuxAuditLog();

        public ITabularOperator<MCCEventLogs> MCCEventLogs{ get; set; } = new MCCEventLogs();

        public ITabularOperator<MCVPOperationLogs> MCVPOperationLogs{ get; set; } = new MCVPOperationLogs();

        public ITabularOperator<MicrosoftAzureBastionAuditLogs> MicrosoftAzureBastionAuditLogs{ get; set; } = new MicrosoftAzureBastionAuditLogs();

        public ITabularOperator<MicrosoftDataShareReceivedSnapshotLog> MicrosoftDataShareReceivedSnapshotLog{ get; set; } = new MicrosoftDataShareReceivedSnapshotLog();

        public ITabularOperator<MicrosoftDataShareSentSnapshotLog> MicrosoftDataShareSentSnapshotLog{ get; set; } = new MicrosoftDataShareSentSnapshotLog();

        public ITabularOperator<MicrosoftDataShareShareLog> MicrosoftDataShareShareLog{ get; set; } = new MicrosoftDataShareShareLog();

        public ITabularOperator<MicrosoftDynamicsTelemetryPerformanceLogs> MicrosoftDynamicsTelemetryPerformanceLogs{ get; set; } = new MicrosoftDynamicsTelemetryPerformanceLogs();

        public ITabularOperator<MicrosoftDynamicsTelemetrySystemMetricsLogs> MicrosoftDynamicsTelemetrySystemMetricsLogs{ get; set; } = new MicrosoftDynamicsTelemetrySystemMetricsLogs();

        public ITabularOperator<MicrosoftHealthcareApisAuditLogs> MicrosoftHealthcareApisAuditLogs{ get; set; } = new MicrosoftHealthcareApisAuditLogs();

        public ITabularOperator<NetworkMonitoring> NetworkMonitoring{ get; set; } = new NetworkMonitoring();

        public ITabularOperator<NWConnectionMonitorDestinationListenerResult> NWConnectionMonitorDestinationListenerResult{ get; set; } = new NWConnectionMonitorDestinationListenerResult();

        public ITabularOperator<NWConnectionMonitorPathResult> NWConnectionMonitorPathResult{ get; set; } = new NWConnectionMonitorPathResult();

        public ITabularOperator<NWConnectionMonitorTestResult> NWConnectionMonitorTestResult{ get; set; } = new NWConnectionMonitorTestResult();

        public ITabularOperator<Operation> Operation{ get; set; } = new Operation();

        public ITabularOperator<Perf> Perf{ get; set; } = new Perf();

        public ITabularOperator<PowerBIDatasetsTenant> PowerBIDatasetsTenant{ get; set; } = new PowerBIDatasetsTenant();

        public ITabularOperator<PowerBIDatasetsTenantPreview> PowerBIDatasetsTenantPreview{ get; set; } = new PowerBIDatasetsTenantPreview();

        public ITabularOperator<PowerBIDatasetsWorkspace> PowerBIDatasetsWorkspace{ get; set; } = new PowerBIDatasetsWorkspace();

        public ITabularOperator<PowerBIDatasetsWorkspacePreview> PowerBIDatasetsWorkspacePreview{ get; set; } = new PowerBIDatasetsWorkspacePreview();

        public ITabularOperator<PurviewDataSensitivityLogs> PurviewDataSensitivityLogs{ get; set; } = new PurviewDataSensitivityLogs();

        public ITabularOperator<PurviewScanStatusLogs> PurviewScanStatusLogs{ get; set; } = new PurviewScanStatusLogs();

        public ITabularOperator<SecureScoreControls> SecureScoreControls{ get; set; } = new SecureScoreControls();

        public ITabularOperator<SecureScores> SecureScores{ get; set; } = new SecureScores();

        public ITabularOperator<SecurityAlert> SecurityAlert{ get; set; } = new SecurityAlert();

        public ITabularOperator<SecurityBaseline> SecurityBaseline{ get; set; } = new SecurityBaseline();

        public ITabularOperator<SecurityBaselineSummary> SecurityBaselineSummary{ get; set; } = new SecurityBaselineSummary();

        public ITabularOperator<SecurityDetection> SecurityDetection{ get; set; } = new SecurityDetection();

        public ITabularOperator<SecurityEvent> SecurityEvent{ get; set; } = new SecurityEvent();

        public ITabularOperator<SecurityNestedRecommendation> SecurityNestedRecommendation{ get; set; } = new SecurityNestedRecommendation();

        public ITabularOperator<SecurityRecommendation> SecurityRecommendation{ get; set; } = new SecurityRecommendation();

        public ITabularOperator<SecurityRegulatoryCompliance> SecurityRegulatoryCompliance{ get; set; } = new SecurityRegulatoryCompliance();

        public ITabularOperator<ServiceFabricOperationalEvent> ServiceFabricOperationalEvent{ get; set; } = new ServiceFabricOperationalEvent();

        public ITabularOperator<ServiceFabricReliableActorEvent> ServiceFabricReliableActorEvent{ get; set; } = new ServiceFabricReliableActorEvent();

        public ITabularOperator<ServiceFabricReliableServiceEvent> ServiceFabricReliableServiceEvent{ get; set; } = new ServiceFabricReliableServiceEvent();

        public ITabularOperator<SignalRServiceDiagnosticLogs> SignalRServiceDiagnosticLogs{ get; set; } = new SignalRServiceDiagnosticLogs();

        public ITabularOperator<SigninLogs> SigninLogs{ get; set; } = new SigninLogs();

        public ITabularOperator<SqlAtpStatus> SqlAtpStatus{ get; set; } = new SqlAtpStatus();

        public ITabularOperator<SQLSecurityAuditEvents> SQLSecurityAuditEvents{ get; set; } = new SQLSecurityAuditEvents();

        public ITabularOperator<SqlVulnerabilityAssessmentResult> SqlVulnerabilityAssessmentResult{ get; set; } = new SqlVulnerabilityAssessmentResult();

        public ITabularOperator<SqlVulnerabilityAssessmentScanStatus> SqlVulnerabilityAssessmentScanStatus{ get; set; } = new SqlVulnerabilityAssessmentScanStatus();

        public ITabularOperator<StorageBlobLogs> StorageBlobLogs{ get; set; } = new StorageBlobLogs();

        public ITabularOperator<StorageFileLogs> StorageFileLogs{ get; set; } = new StorageFileLogs();

        public ITabularOperator<StorageQueueLogs> StorageQueueLogs{ get; set; } = new StorageQueueLogs();

        public ITabularOperator<StorageTableLogs> StorageTableLogs{ get; set; } = new StorageTableLogs();

        public ITabularOperator<SucceededIngestion> SucceededIngestion{ get; set; } = new SucceededIngestion();

        public ITabularOperator<SynapseBigDataPoolApplicationsEnded> SynapseBigDataPoolApplicationsEnded{ get; set; } = new SynapseBigDataPoolApplicationsEnded();

        public ITabularOperator<SynapseBuiltinSqlPoolRequestsEnded> SynapseBuiltinSqlPoolRequestsEnded{ get; set; } = new SynapseBuiltinSqlPoolRequestsEnded();

        public ITabularOperator<SynapseDXCommand> SynapseDXCommand{ get; set; } = new SynapseDXCommand();

        public ITabularOperator<SynapseDXFailedIngestion> SynapseDXFailedIngestion{ get; set; } = new SynapseDXFailedIngestion();

        public ITabularOperator<SynapseDXIngestionBatching> SynapseDXIngestionBatching{ get; set; } = new SynapseDXIngestionBatching();

        public ITabularOperator<SynapseDXQuery> SynapseDXQuery{ get; set; } = new SynapseDXQuery();

        public ITabularOperator<SynapseDXSucceededIngestion> SynapseDXSucceededIngestion{ get; set; } = new SynapseDXSucceededIngestion();

        public ITabularOperator<SynapseDXTableDetails> SynapseDXTableDetails{ get; set; } = new SynapseDXTableDetails();

        public ITabularOperator<SynapseDXTableUsageStatistics> SynapseDXTableUsageStatistics{ get; set; } = new SynapseDXTableUsageStatistics();

        public ITabularOperator<SynapseGatewayApiRequests> SynapseGatewayApiRequests{ get; set; } = new SynapseGatewayApiRequests();

        public ITabularOperator<SynapseGatewayEvents> SynapseGatewayEvents{ get; set; } = new SynapseGatewayEvents();

        public ITabularOperator<SynapseIntegrationActivityRuns> SynapseIntegrationActivityRuns{ get; set; } = new SynapseIntegrationActivityRuns();

        public ITabularOperator<SynapseIntegrationPipelineRuns> SynapseIntegrationPipelineRuns{ get; set; } = new SynapseIntegrationPipelineRuns();

        public ITabularOperator<SynapseIntegrationTriggerRuns> SynapseIntegrationTriggerRuns{ get; set; } = new SynapseIntegrationTriggerRuns();

        public ITabularOperator<SynapseRBACEvents> SynapseRBACEvents{ get; set; } = new SynapseRBACEvents();

        public ITabularOperator<SynapseRbacOperations> SynapseRbacOperations{ get; set; } = new SynapseRbacOperations();

        public ITabularOperator<SynapseSqlPoolDmsWorkers> SynapseSqlPoolDmsWorkers{ get; set; } = new SynapseSqlPoolDmsWorkers();

        public ITabularOperator<SynapseSqlPoolExecRequests> SynapseSqlPoolExecRequests{ get; set; } = new SynapseSqlPoolExecRequests();

        public ITabularOperator<SynapseSqlPoolRequestSteps> SynapseSqlPoolRequestSteps{ get; set; } = new SynapseSqlPoolRequestSteps();

        public ITabularOperator<SynapseSqlPoolSqlRequests> SynapseSqlPoolSqlRequests{ get; set; } = new SynapseSqlPoolSqlRequests();

        public ITabularOperator<SynapseSqlPoolWaits> SynapseSqlPoolWaits{ get; set; } = new SynapseSqlPoolWaits();

        public ITabularOperator<Syslog> Syslog{ get; set; } = new Syslog();

        public ITabularOperator<TSIIngress> TSIIngress{ get; set; } = new TSIIngress();

        public ITabularOperator<Update> Update{ get; set; } = new Update();

        public ITabularOperator<UpdateRunProgress> UpdateRunProgress{ get; set; } = new UpdateRunProgress();

        public ITabularOperator<UpdateSummary> UpdateSummary{ get; set; } = new UpdateSummary();

        public ITabularOperator<Usage> Usage{ get; set; } = new Usage();

        public ITabularOperator<VMBoundPort> VMBoundPort{ get; set; } = new VMBoundPort();

        public ITabularOperator<VMComputer> VMComputer{ get; set; } = new VMComputer();

        public ITabularOperator<VMConnection> VMConnection{ get; set; } = new VMConnection();

        public ITabularOperator<VMProcess> VMProcess{ get; set; } = new VMProcess();

        public ITabularOperator<W3CIISLog> W3CIISLog{ get; set; } = new W3CIISLog();

        public ITabularOperator<WindowsFirewall> WindowsFirewall{ get; set; } = new WindowsFirewall();

        public ITabularOperator<WorkloadDiagnosticLogs> WorkloadDiagnosticLogs{ get; set; } = new WorkloadDiagnosticLogs();

        public ITabularOperator<WVDAgentHealthStatus> WVDAgentHealthStatus{ get; set; } = new WVDAgentHealthStatus();

        public ITabularOperator<WVDCheckpoints> WVDCheckpoints{ get; set; } = new WVDCheckpoints();

        public ITabularOperator<WVDConnections> WVDConnections{ get; set; } = new WVDConnections();

        public ITabularOperator<WVDErrors> WVDErrors{ get; set; } = new WVDErrors();

        public ITabularOperator<WVDFeeds> WVDFeeds{ get; set; } = new WVDFeeds();

        public ITabularOperator<WVDHostRegistrations> WVDHostRegistrations{ get; set; } = new WVDHostRegistrations();

        public ITabularOperator<WVDManagement> WVDManagement{ get; set; } = new WVDManagement();

        #endregion
    }
}