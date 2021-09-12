
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class IntuneDevices : TableBase<IntuneDevices>
    {

            /// 
            public string TenantId {get; set;}
            
            /// Date and time when the report was generated (UTC)
            public DateTime TimeGenerated {get; set;}
            
            /// The name of the operation
            public string OperationName {get; set;}
            
            /// The result of the operation
            public string Result {get; set;}
            
            /// Details of source system of the object being provisioned
            public string SourceSystem {get; set;}
            
            /// The ID of the device
            public string DeviceId {get; set;}
            
            /// The name of the device
            public string DeviceName {get; set;}
            
            /// The user principal name
            public string UPN {get; set;}
            
            /// The date and time of last contact
            public string LastContact {get; set;}
            
            /// The version of the operating system
            public string OSVersion {get; set;}
            
            /// The operating system of the device
            public string OS {get; set;}
            
            /// The compliant state of the device
            public string CompliantState {get; set;}
            
            /// The ownership of the device
            public string Ownership {get; set;}
            
            /// The authority that the device is managed by
            public string ManagedBy {get; set;}
            
            /// The model of the device
            public string Model {get; set;}
            
            /// The serial number of the device
            public string SerialNumber {get; set;}
            
            /// The manufacturer of the device
            public string Manufacturer {get; set;}
            
            /// The date and time of the device entry was created
            public string CreatedDate {get; set;}
            
            /// The state of the device
            public string DeviceState {get; set;}
            
            /// The user email address
            public string UserEmail {get; set;}
            
            /// The user name
            public string UserName {get; set;}
            
            /// The international mobile equipment identifier of the device
            public string IMEI {get; set;}
            
            /// The phone number
            public string PhoneNumber {get; set;}
            
            /// The registration state of the device
            public string DeviceRegistrationState {get; set;}
            
            /// The AAD Device ID
            public string ReferenceId {get; set;}
            
            /// The managed device name
            public string ManagedDeviceName {get; set;}
            
            /// Boolean describing whether the graph device is managed
            public bool GraphDeviceIsManaged {get; set;}
            
            /// The category name of the device
            public string CategoryName {get; set;}
            
            /// String describing whether the device is encrypted
            public string EncryptionStatusString {get; set;}
            
            /// The subscriber carrier network
            public string SubscriberCarrierNetwork {get; set;}
            
            /// The device join type
            public string JoinType {get; set;}
            
            /// String describing whether the device is supervised
            public string SupervisedStatusString {get; set;}
            
            /// The WiFi MAC address of the device
            public string WifiMacAddress {get; set;}
            
            /// The total storage size of the device
            public long StorageTotal {get; set;}
            
            /// The free storage size of the device
            public long StorageFree {get; set;}
            
            /// The Android patch level of the device
            public string AndroidPatchLevel {get; set;}
            
            /// The mobile equipment identifier of the device
            public string MEID {get; set;}
            
            /// The device grace period end time
            public string InGracePeriodUntil {get; set;}
            
            /// String describing whether the device is jail broken
            public string JailBroken {get; set;}
            
            /// The stock-keeping unit family of the device
            public string SkuFamily {get; set;}
            
            /// The Emergency Alert System Identification of the device
            public string EasID {get; set;}
            
            /// The ID of the primary user
            public string PrimaryUser {get; set;}
            
            /// The unique ID for the exported report
            public string BatchId {get; set;}
            
            /// The Intune Account ID
            public string IntuneAccountId {get; set;}
            
            /// The AAD Tenant ID
            public string AADTenantId {get; set;}
            
            /// Statistics about the export, including the number of records exported per export
            public dynamic Stats {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
                }
}
