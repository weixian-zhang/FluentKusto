
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class pageViews : TableBase<pageViews>
    {

            /// Timestamp (UTC) when log was generated.
            public DateTime timestamp {get; set;}

             public DateTime id {get; set;}


            /// GUID for correlated logs.
            public string name {get; set;}

            public string url { get; set; }

            public double duration { get; set; }

            public double performanceBucket { get; set; }

            public string itemType { get; set; }

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
