

namespace FluentKusto
{
    public class HealthStateChangeEvent
    {

        ///
        public string TenantId {get; set;}
        
        ///Timestamp (UTC) when the record was generated.
        public datetime TimeGenerated {get; set;}
        
        ///Timestamp (UTC) when the monitor health state change event was created.
        public datetime EvaluationTimestamp {get; set;}
        
        ///Previous state of the monitor (Critical, Warning, Healthy, Unknown, None).
        public string PreviousMonitorState {get; set;}
        
        ///Current state of the monitor (Critical, Warning, Healthy, Unknown, None).
        public string CurrentMonitorState {get; set;}
        
        ///ARM resource id of the monitor.
        public string MonitorResourceId {get; set;}
        
        ///Name of the monitor, e.g. logical-disks|C:|free-space-mb for Windows platform, filesystems|/var/lib|free-space-mb for Linux platform.
        public string MonitorName {get; set;}
        
        ///Parent monitor name, e.g. logical-disks|C: for Windows platform, filesystems for Linux platform.
        public string ParentMonitorName {get; set;}
        
        ///Timestamp (UTC) the monitor start change to non-healthy (Critical, Warning) state.
        public datetime ImpactStartTimestamp {get; set;}
        
        ///Timestamp (UTC) when the current state of the monitor was first observed.
        public datetime CurrentStateFirstObservedTimestamp {get; set;}
        
        ///Type of the monitor. Same as the monitor name for static monitors, replaces MonitoredObject with * for dynamic monitors.
        public string MonitorType {get; set;}
        
        ///Object the monitor is monitoring. Values only exist for dynamic monitors, e.g. D: for monitor logical-disks|D:|free-space-mb.
        public string MonitoredObject {get; set;}
        
        ///Snapshot of samples and reason the monitor changed state.
        public dynamic Evidence {get; set;}
        
        ///Configuration for the monitor. Aggregate monitor configuration is an empty string.
        public dynamic MonitorConfiguration {get; set;}
        
        ///Current state of the monitor (Critical, Warning, Healthy, Unknown, None).
        public dynamic InstrumentationData {get; set;}
        
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
