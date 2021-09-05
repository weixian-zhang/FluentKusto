

namespace FluentKusto
{
    public class AppPerformanceCounters
    {

        ///
        public string TenantId {get; set;}
        
        ///Date and time when performance counter was recorded.
        public datetime TimeGenerated {get; set;}
        
        ///Performance counter name.
        public string Name {get; set;}
        
        ///Performance counter category.
        public string Category {get; set;}
        
        ///Performance counter name.
        public string Counter {get; set;}
        
        ///Instance identifier, to which the counter is related.
        public string Instance {get; set;}
        
        ///Performance counter value.
        public real Value {get; set;}
        
        ///Application-defined properties.
        public dynamic Properties {get; set;}
        
        ///Application-defined name of the overall operation. The OperationName values typically match the Name values for AppRequests.
        public string OperationName {get; set;}
        
        ///Application-defined operation ID.
        public string OperationId {get; set;}
        
        ///ID of the parent operation.
        public string ParentId {get; set;}
        
        ///Synthetic source of the operation.
        public string SyntheticSource {get; set;}
        
        ///Application-defined session ID.
        public string SessionId {get; set;}
        
        ///Anonymous ID of a user accessing the application.
        public string UserId {get; set;}
        
        ///Persistent string that uniquely represents each authenticated user in the application.
        public string UserAuthenticatedId {get; set;}
        
        ///Application-defined account associated with the user.
        public string UserAccountId {get; set;}
        
        ///Version of the application.
        public string AppVersion {get; set;}
        
        ///Role name of the application.
        public string AppRoleName {get; set;}
        
        ///Role instance of the application.
        public string AppRoleInstance {get; set;}
        
        ///Type of the client device.
        public string ClientType {get; set;}
        
        ///Model of the client device.
        public string ClientModel {get; set;}
        
        ///Operating system of the client device.
        public string ClientOS {get; set;}
        
        ///IP address of the client device.
        public string ClientIP {get; set;}
        
        ///City where the client device is located.
        public string ClientCity {get; set;}
        
        ///State or province where the client device is located.
        public string ClientStateOrProvince {get; set;}
        
        ///Country or region where the client device is located.
        public string ClientCountryOrRegion {get; set;}
        
        ///Browser running on the client device.
        public string ClientBrowser {get; set;}
        
        ///Unique, persistent identifier of an Azure resource.
        public string ResourceGUID {get; set;}
        
        ///Instrumentation key of the Azure resource.
        public string IKey {get; set;}
        
        ///Version of the SDK used by the application to generate this telemetry item.
        public string SDKVersion {get; set;}
        
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
