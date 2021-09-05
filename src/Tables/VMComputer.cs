

namespace FluentKusto
{
    public class VMComputer
    {

        ///Date and time the record was created.
        public datetime TimeGenerated {get; set;}
        
        ///The name of the computer.
        public string Computer {get; set;}
        
        ///Unique ID for the microsoft monitoring agent installed on the server.
        public string AgentId {get; set;}
        
        ///AgentId with m- prepended.
        public string Machine {get; set;}
        
        ///The display name of the server.
        public string DisplayName {get; set;}
        
        ///The full display name of the server.
        public string FullDisplayName {get; set;}
        
        ///The host name of the server without domain.
        public string HostName {get; set;}
        
        ///The boot time in UTC
        public datetime BootTime {get; set;}
        
        ///The UTC timezone offset of the server.
        public string TimeZone {get; set;}
        
        ///Values will be Unknown Physical Virtual or Hypervisor
        public string VirtualizationState {get; set;}
        
        ///A list of the server's IPv4 addresses
        public dynamic Ipv4Addresses {get; set;}
        
        ///A list of the server's IPv4 subnet masks.
        public dynamic Ipv4SubnetMasks {get; set;}
        
        ///A list of the server's IPv4 default gateways.
        public dynamic Ipv4DefaultGateways {get; set;}
        
        ///A list of the server's IPv6 addresses
        public dynamic Ipv6Addresses {get; set;}
        
        ///A list of the server's MAC addresses
        public dynamic MacAddresses {get; set;}
        
        ///An array of DNS names
        public dynamic DnsNames {get; set;}
        
        ///The version number of the dependency agent on the server.
        public string DependencyAgentVersion {get; set;}
        
        ///Value will be windows or linux
        public string OperatingSystemFamily {get; set;}
        
        ///The full name of the operating system
        public string OperatingSystemFullName {get; set;}
        
        ///The physical memory in MB
        public long PhysicalMemoryMB {get; set;}
        
        ///The number of CPUs
        public int Cpus {get; set;}
        
        ///The CPU speed in MHz
        public int CpuSpeed {get; set;}
        
        ///hyperv vmware xen and so on
        public string VirtualMachineType {get; set;}
        
        ///The native id of the server.
        public string VirtualMachineNativeId {get; set;}
        
        ///The name of the VM
        public string VirtualMachineNativeName {get; set;}
        
        ///The hypervisor id of the server.
        public string VirtualMachineHypervisorId {get; set;}
        
        ///The hypervisor type of the server.
        public string HypervisorType {get; set;}
        
        ///The hypervisor id of the server.
        public string HypervisorId {get; set;}
        
        ///The hosting provider for the server
        public string HostingProvider {get; set;}
        
        ///The subscription ID of the server. Only available for Azure VMs and VMSS instances.
        public string AzureSubscriptionId {get; set;}
        
        ///The resource group for the server. Only available for Azure VMs and VMSS instances.
        public string AzureResourceGroup {get; set;}
        
        ///The Azure name for the resource.
        public string AzureResourceName {get; set;}
        
        ///The location of the server. Only available for Azure VMs and VMSS instances.
        public string AzureLocation {get; set;}
        
        ///The update domain of the server. Only available for Azure VMs and VMSS instances.
        public string AzureUpdateDomain {get; set;}
        
        ///The fault domain for the server. Only available for Azure VMs and VMSS instances.
        public string AzureFaultDomain {get; set;}
        
        ///The Azure ID of the server. Only available for Azure VMs and VMSS instances.
        public string AzureVmId {get; set;}
        
        ///The size of the Azure VM.�Only available for Azure VMs and VMSS instances.
        public string AzureSize {get; set;}
        
        ///The publisher of the VM image used on the server. Only available for Azure VMs and VMSS instances.
        public string AzureImagePublisher {get; set;}
        
        ///The description of the image used on the server. Only available for Azure VMs and VMSS instances.
        public string AzureImageOffering {get; set;}
        
        ///The sku for the VM image used on the server. Only available for Azure VMs and VMSS instances.
        public string AzureImageSku {get; set;}
        
        ///The image version used on the server. Only available for Azure VMs and VMSS instances.
        public string AzureImageVersion {get; set;}
        
        ///For cloud services the service name of the server.
        public string AzureCloudServiceName {get; set;}
        
        ///For cloud services the deployment id of the server.
        public string AzureCloudServiceDeployment {get; set;}
        
        ///For cloud services the role name of the server.
        public string AzureCloudServiceRoleName {get; set;}
        
        ///For cloud services the role type of the server.
        public string AzureCloudServiceRoleType {get; set;}
        
        ///For cloud services the instance name of the server.
        public string AzureCloudServiceInstanceId {get; set;}
        
        ///For scale sets the name of the scale set.
        public string AzureVmScaleSetName {get; set;}
        
        ///For scale sets the deployment id of the server.
        public string AzureVmScaleSetDeployment {get; set;}
        
        ///For scale sets the resource id of the scale set.
        public string AzureVmScaleSetResourceId {get; set;}
        
        ///For scale sets the instance id of the server.
        public string AzureVmScaleSetInstanceId {get; set;}
        
        ///For service fabric clusters the cluster id of the server.
        public string AzureServiceFabricClusterId {get; set;}
        
        ///For service fabric clusters the cluster name.
        public string AzureServiceFabricClusterName {get; set;}
        
        ///The source of the data collected (Insights)
        public string SourceSystem {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
