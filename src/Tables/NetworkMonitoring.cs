

namespace FluentKusto
{
    public class NetworkMonitoring
    {

        ///
        public string SourceSystem {get; set;}
        
        ///
        public string Computer {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string SubType {get; set;}
        
        ///
        public string SourceNetwork {get; set;}
        
        ///
        public string DestinationNetwork {get; set;}
        
        ///
        public string SourceSubNetwork {get; set;}
        
        ///
        public string DestinationSubNetwork {get; set;}
        
        ///
        public string SourceNetworkNodeLink {get; set;}
        
        ///
        public string DestinationNetworkNodeLink {get; set;}
        
        ///
        public string PathInformation {get; set;}
        
        ///
        public string AgentIP {get; set;}
        
        ///
        public string AgentFqdn {get; set;}
        
        ///
        public string SubnetId {get; set;}
        
        ///
        public real Loss {get; set;}
        
        ///
        public real HighLatency {get; set;}
        
        ///
        public real MedianLatency {get; set;}
        
        ///
        public real LowLatency {get; set;}
        
        ///
        public bool LossHealthIndicator {get; set;}
        
        ///
        public bool LatencyHealthIndicator {get; set;}
        
        ///
        public string RuleName {get; set;}
        
        ///
        public int TimeSinceActive {get; set;}
        
        ///
        public string LossFaultLinks {get; set;}
        
        ///
        public string LatencyFaultLinks {get; set;}
        
        ///
        public real LossBenchmark {get; set;}
        
        ///
        public real LatencyBenchmark {get; set;}
        
        ///
        public string LossMode {get; set;}
        
        ///
        public string LatencyMode {get; set;}
        
        ///
        public int SubnetLinkCount {get; set;}
        
        ///
        public int NodeLinkCount {get; set;}
        
        ///
        public int AlertsCount {get; set;}
        
        ///
        public string PrefixLength {get; set;}
        
        ///
        public string AddressType {get; set;}
        
        ///
        public datetime TimeProcessed {get; set;}
        
        ///
        public string SourceNetworkNodeInterface {get; set;}
        
        ///
        public string DestinationNetworkNodeInterface {get; set;}
        
        ///
        public string Path {get; set;}
        
        ///
        public real LossThreshold {get; set;}
        
        ///
        public real LatencyThreshold {get; set;}
        
        ///
        public string LossThresholdMode {get; set;}
        
        ///
        public string LatencyThresholdMode {get; set;}
        
        ///
        public string LossHealthState {get; set;}
        
        ///
        public string LatencyHealthState {get; set;}
        
        ///
        public string AgentId {get; set;}
        
        ///
        public int AgentCapability {get; set;}
        
        ///
        public string Protocol {get; set;}
        
        ///
        public string AzureHopListIPAddress {get; set;}
        
        ///
        public string AzureHopListType {get; set;}
        
        ///
        public string AzureHopListHealth {get; set;}
        
        ///
        public string AzureHopListDiagnosticCode {get; set;}
        
        ///
        public string AzureHopListResourceID {get; set;}
        
        ///
        public string OSType {get; set;}
        
        ///
        public string RouterName {get; set;}
        
        ///
        public string RouterIP {get; set;}
        
        ///
        public int MachineType {get; set;}
        
        ///
        public string NPMAgentEnvironment {get; set;}
        
        ///
        public string ConnectionMonitorResourceId {get; set;}
        
        ///
        public long BitsInPerSecond {get; set;}
        
        ///
        public long BitsOutPerSecond {get; set;}
        
        ///
        public int NotificationCode {get; set;}
        
        ///
        public string NotificationType {get; set;}
        
        ///
        public string MinHopLatencyList {get; set;}
        
        ///
        public string MaxHopLatencyList {get; set;}
        
        ///
        public string AvgHopLatencyList {get; set;}
        
        ///
        public datetime TraceRouteCompletionTime {get; set;}
        
        ///
        public string TestName {get; set;}
        
        ///
        public int ServiceTestId {get; set;}
        
        ///
        public int Port {get; set;}
        
        ///
        public int EndpointId {get; set;}
        
        ///
        public long ServiceResponseCode {get; set;}
        
        ///
        public string Target {get; set;}
        
        ///
        public real ServiceResponseTime {get; set;}
        
        ///
        public string ServiceResponseHealthState {get; set;}
        
        ///
        public real ServiceResponseThreshold {get; set;}
        
        ///
        public string ServiceResponseThresholdMode {get; set;}
        
        ///
        public real ServiceLossPercent {get; set;}
        
        ///
        public string ServiceLossHealthState {get; set;}
        
        ///
        public string ResponseCodeHealthState {get; set;}
        
        ///
        public string CircuitName {get; set;}
        
        ///
        public string PeeringName {get; set;}
        
        ///
        public string PeeringType {get; set;}
        
        ///
        public string VirtualNetwork {get; set;}
        
        ///
        public string CircuitRegion {get; set;}
        
        ///
        public string PeeringLocation {get; set;}
        
        ///
        public string ServiceProvider {get; set;}
        
        ///
        public string ProvisioningState {get; set;}
        
        ///
        public string CircuitSKUTier {get; set;}
        
        ///
        public string CircuitSKUFamily {get; set;}
        
        ///
        public string MicrosoftEdge {get; set;}
        
        ///
        public string ProviderEdge {get; set;}
        
        ///
        public string MicrosoftEdgeAlias {get; set;}
        
        ///
        public string ProviderEdgeAlias {get; set;}
        
        ///
        public string DiagnosticHop {get; set;}
        
        ///
        public string DiagnosticHopLatency {get; set;}
        
        ///
        public int TotalPeerings {get; set;}
        
        ///
        public int TotalSessions {get; set;}
        
        ///
        public int VLan {get; set;}
        
        ///
        public bool IsPrimary {get; set;}
        
        ///
        public string SubscriptionId {get; set;}
        
        ///
        public string ServiceKey {get; set;}
        
        ///
        public long PrimaryBytesInPerSecond {get; set;}
        
        ///
        public long PrimaryBytesOutPerSecond {get; set;}
        
        ///
        public long SecondaryBytesInPerSecond {get; set;}
        
        ///
        public long SecondaryBytesOutPerSecond {get; set;}
        
        ///
        public string UtilizationHealthState {get; set;}
        
        ///
        public string CircuitResourceGroup {get; set;}
        
        ///
        public string CircuitSubscriptionId {get; set;}
        
        ///
        public string CircuitResourceId {get; set;}
        
        ///
        public string ConnectionResourceId {get; set;}
        
        ///
        public string NodeUniqueName {get; set;}
        
        ///
        public string DeviceMonitoringChannel {get; set;}
        
        ///
        public string DeviceComponentType {get; set;}
        
        ///
        public string DeviceState {get; set;}
        
        ///
        public string FriendlyName {get; set;}
        
        ///
        public long Index {get; set;}
        
        ///
        public string Details {get; set;}
        
        ///
        public string Model {get; set;}
        
        ///
        public string Vendor {get; set;}
        
        ///
        public string sysName {get; set;}
        
        ///
        public string sysDescr {get; set;}
        
        ///
        public string sysLocation {get; set;}
        
        ///
        public string sysContact {get; set;}
        
        ///
        public string sysObjectID {get; set;}
        
        ///
        public string DeviceType {get; set;}
        
        ///
        public bool SupportsSnmp {get; set;}
        
        ///
        public string SnmpVersion {get; set;}
        
        ///
        public string SnmpManagementIpV4Address {get; set;}
        
        ///
        public string SnmpManagementIpV6Address {get; set;}
        
        ///
        public int InterfaceCount {get; set;}
        
        ///
        public int FanCount {get; set;}
        
        ///
        public int MemCount {get; set;}
        
        ///
        public int ProcessorCount {get; set;}
        
        ///
        public int DiskCount {get; set;}
        
        ///
        public string ifPhysAddress {get; set;}
        
        ///
        public string IpV4Subnets {get; set;}
        
        ///
        public string IpV6Subnets {get; set;}
        
        ///
        public string IpV4Addresses {get; set;}
        
        ///
        public string IpV6Addresses {get; set;}
        
        ///
        public string RouteTableIpV4NextHops {get; set;}
        
        ///
        public string RouteTableIpV6NextHops {get; set;}
        
        ///
        public string RouteTableNextHopNodes {get; set;}
        
        ///
        public string L2ConnectedPorts {get; set;}
        
        ///
        public string L2ConnectedNodes {get; set;}
        
        ///
        public string PortName {get; set;}
        
        ///
        public string ifType {get; set;}
        
        ///
        public long ifMtu {get; set;}
        
        ///
        public long ifHighSpeed {get; set;}
        
        ///
        public string RouteDestination {get; set;}
        
        ///
        public string RouteMetric {get; set;}
        
        ///
        public string RouteNextHop {get; set;}
        
        ///
        public string IcmpPingStatus {get; set;}
        
        ///
        public string SnmpPingStatus {get; set;}
        
        ///
        public real PingDelayInMsec {get; set;}
        
        ///
        public long sysUpTime {get; set;}
        
        ///
        public long InOctetsPerSec {get; set;}
        
        ///
        public long OutOctetsPerSec {get; set;}
        
        ///
        public long InDiscardsPerSec {get; set;}
        
        ///
        public int InDiscardsPercent {get; set;}
        
        ///
        public long OutDiscardsPerSec {get; set;}
        
        ///
        public int OutDiscardsPercent {get; set;}
        
        ///
        public long InErrorsPerSec {get; set;}
        
        ///
        public int InErrorsPercent {get; set;}
        
        ///
        public long OutErrorsPerSec {get; set;}
        
        ///
        public long OutErrorsPercent {get; set;}
        
        ///
        public long InUnicastPktsPerSec {get; set;}
        
        ///
        public long OutUnicastPktsPerSec {get; set;}
        
        ///
        public long InMultiCastPktsPerSec {get; set;}
        
        ///
        public long OutMultiCastPktsPerSec {get; set;}
        
        ///
        public long InBroadCastPktsPerSec {get; set;}
        
        ///
        public long OutBroadCastPktsPerSec {get; set;}
        
        ///
        public string ifAdminStatus {get; set;}
        
        ///
        public string ifOperStatus {get; set;}
        
        ///
        public long ifHCInOctets {get; set;}
        
        ///
        public long ifHCInUcastPkts {get; set;}
        
        ///
        public long ifHCInMulticastPkts {get; set;}
        
        ///
        public long ifHCInBroadcastPkts {get; set;}
        
        ///
        public long ifInDiscardsMib2 {get; set;}
        
        ///
        public long ifInErrors {get; set;}
        
        ///
        public int ifHCOutOctetsMib2 {get; set;}
        
        ///
        public long ifHCOutUcastPkts {get; set;}
        
        ///
        public long ifHCOutMulticastPkts {get; set;}
        
        ///
        public long ifHCOutBroadcastPkts {get; set;}
        
        ///
        public long ifOutDiscards {get; set;}
        
        ///
        public long ifOutErrors {get; set;}
        
        ///
        public long ifOutQLen {get; set;}
        
        ///
        public long MemTotalInMB {get; set;}
        
        ///
        public int MemAvailablePercent {get; set;}
        
        ///
        public int ProcessorTimePercent {get; set;}
        
        ///
        public string Enterprise {get; set;}
        
        ///
        public string GenTrapType {get; set;}
        
        ///
        public string SpecificTrapType {get; set;}
        
        ///
        public string TrapOid {get; set;}
        
        ///
        public string TrapData {get; set;}
        
        ///
        public int TrapCollectionIntervalInSeconds {get; set;}
        
        ///
        public int TrapCount {get; set;}
        
        ///
        public string CustomMonitoringData {get; set;}
        
        ///
        public string CustomFieldName {get; set;}
        
        ///
        public string CustomOid {get; set;}
        
        ///
        public string CustomOidResponseSuffix {get; set;}
        
        ///
        public string CustomFieldValueString {get; set;}
        
        ///
        public string CustomFieldValueHex {get; set;}
        
        ///
        public long CustomFieldValueInt {get; set;}
        
        ///
        public long CustomFieldValueFloat {get; set;}
        
        ///
        public string MessageCode {get; set;}
        
        ///
        public string MessageDetails {get; set;}
        
        ///
        public string MessageType {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
            }
}
