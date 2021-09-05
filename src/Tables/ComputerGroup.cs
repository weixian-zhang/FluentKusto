

namespace FluentKusto
{
    public class ComputerGroup
    {

        ///OpsManager for all records of this type.
        public string SourceSystem {get; set;}
        
        ///Date and time the computer group was created or updated.
        public datetime TimeGenerated {get; set;}
        
        ///Name of the member computer.
        public string Computer {get; set;}
        
        ///Name of the group.
        public string Group {get; set;}
        
        ///ID of the group.
        public string GroupId {get; set;}
        
        ///Name of the source that the group was collected from. For Active Directory this is the domain name.
        public string GroupSourceName {get; set;}
        
        ///Source that group was collected from. Possible values are ActiveDirectory WSUSWSUSClientTargeting.
        public string GroupSource {get; set;}
        
        ///Full path to the group including the source and source name.
        public string GroupFullName {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
