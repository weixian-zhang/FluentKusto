
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class availabilityResults : TableBase<availabilityResults>
    {

            /// Timestamp (UTC) when log was generated.
            public DateTime timestamp {get; set;}

            /// The log category of the event.
            public string id {get; set;}

            /// GUID for correlated logs.
            public string name {get; set;}

            /// Status of this audit event.
            public string location {get; set;}


            /// Target resource that apply to the operation being audited.
            public string success {get; set;}

            /// The result of the operation being audited.
            public string message {get; set;}

            /// Caller identity of this event.
            public double size {get; set;}

            /// IP Address of the caller that triggered this audit event.
            public double duration  {get; set;}

            public string performanceBucket  {get; set;}

            /// Unique request ID generated by server.
            public string itemType {get; set;}

            ///
            public string customDimensions {get; set;}

            /// The name of the table
            public string customMeasurements {get; set;}

            /// A unique identifier for the resource that the record is associated with
            public string operation_Name {get; set;}

            /// A unique identifier for the subscription that the record is associated with
            public string operation_Id {get; set;}

            public string operation_ParentId {get; set;}

            public string operation_SyntheticSource {get; set;}

             public string session_Id {get; set;}

             public string user_Id {get; set;}

             public string user_AuthenticatedId {get; set;}

             public string user_AccountId {get; set;}

             public string application_Version {get; set;}

             public string client_Type {get; set;}

             public string client_Model {get; set;}

             public string client_OS {get; set;}

             public string client_IP { get; set; }

             public string client_City {get; set;}

             public string client_StateOrProvince {get; set;}

             public string client_CountryOrRegion {get; set;}

             public string client_Browser {get; set;}

             public string cloud_RoleName {get; set;}
             public string cloud_RoleInstance {get; set;}

             public string appId {get; set;}
             public string appName {get; set;}

             public string iKey {get; set;}
             public string sdkVersion {get; set;}

             public string itemId {get; set;}
             public string itemCount {get; set;}
    }
}
