
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class IntuneDeviceComplianceOrg : TableBase<IntuneDeviceComplianceOrg>
    {

            /// 
            public string TenantId {get; set;}
            
            /// Date and time when the report was generated.
            public DateTime TimeGenerated {get; set;}
            
            /// The result of the operation.
            public string Result {get; set;}
            
            /// The name of the device.
            public string DeviceName {get; set;}
            
            /// The user principal name.
            public string UPN {get; set;}
            
            /// The compliance state of the device.
            public string ComplianceState {get; set;}
            
            /// The operating system of the device.
            public string OSDescription {get; set;}
            
            /// The version of the operating system.
            public string OSVersion {get; set;}
            
            /// The operating system of the device.
            public string OS {get; set;}
            
            /// The type of owner.
            public string OwnerType {get; set;}
            
            /// The Id of the device.
            public string DeviceId {get; set;}
            
            /// The date and time of last contact.
            public string LastContact {get; set;}
            
            /// The Id of the user.
            public string UserId {get; set;}
            
            /// The international mobile equipment identifier of the device.
            public string IMEI {get; set;}
            
            /// The serial number of the device
            public string SerialNumber {get; set;}
            
            /// The retire after date time.
            public string RetireAfterDatetime {get; set;}
            
            /// The management agents.
            public string ManagementAgents {get; set;}
            
            /// The type of the device.
            public string DeviceType {get; set;}
            
            /// The user name.
            public string UserName {get; set;}
            
            /// The device grace period end time.
            public string InGracePeriodUntil {get; set;}
            
            /// The device health threat level.
            public string DeviceHealthThreatLevel {get; set;}
            
            /// The user email address.
            public string UserEmail {get; set;}
            
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
