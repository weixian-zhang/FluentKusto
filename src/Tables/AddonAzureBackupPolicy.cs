

namespace FluentKusto
{
    public class AddonAzureBackupPolicy
    {

        ///
        public string SourceSystem {get; set;}
        
        ///
        public datetime TimeGenerated {get; set;}
        
        ///
        public string ResourceId {get; set;}
        
        ///
        public string OperationName {get; set;}
        
        ///
        public string Category {get; set;}
        
        ///
        public string BackupDaysOfTheWeek {get; set;}
        
        ///
        public string BackupFrequency {get; set;}
        
        ///
        public string BackupManagementType {get; set;}
        
        ///
        public string BackupManagementServerUniqueId {get; set;}
        
        ///
        public string BackupTimes {get; set;}
        
        ///
        public int DailyRetentionDuration {get; set;}
        
        ///
        public string DailyRetentionTimes {get; set;}
        
        ///
        public string DiffBackupDaysofTheWeek {get; set;}
        
        ///
        public string DiffBackupFormat {get; set;}
        
        ///
        public int DiffBackupRetentionDuration {get; set;}
        
        ///
        public string DiffBackupTime {get; set;}
        
        ///
        public int LogBackupFrequency {get; set;}
        
        ///
        public int LogBackupRetentionDuration {get; set;}
        
        ///
        public string MonthlyRetentionDaysOfTheMonth {get; set;}
        
        ///
        public string MonthlyRetentionDaysOfTheWeek {get; set;}
        
        ///
        public int MonthlyRetentionDuration {get; set;}
        
        ///
        public string MonthlyRetentionFormat {get; set;}
        
        ///
        public string MonthlyRetentionTimes {get; set;}
        
        ///
        public string MonthlyRetentionWeeksOfTheMonth {get; set;}
        
        ///
        public string PolicyName {get; set;}
        
        ///
        public string PolicyUniqueId {get; set;}
        
        ///
        public string PolicyTimeZone {get; set;}
        
        ///
        public int RetentionDuration {get; set;}
        
        ///
        public string RetentionType {get; set;}
        
        ///
        public string SchemaVersion {get; set;}
        
        ///
        public string State {get; set;}
        
        ///
        public string SynchronisationFrequencyPerDay {get; set;}
        
        ///
        public string VaultUniqueId {get; set;}
        
        ///
        public string WeeklyRetentionDaysOfTheWeek {get; set;}
        
        ///
        public int WeeklyRetentionDuration {get; set;}
        
        ///
        public string WeeklyRetentionTimes {get; set;}
        
        ///
        public string YearlyRetentionDaysOfTheMonth {get; set;}
        
        ///
        public string YearlyRetentionDaysOfTheWeek {get; set;}
        
        ///
        public int YearlyRetentionDuration {get; set;}
        
        ///
        public string YearlyRetentionFormat {get; set;}
        
        ///
        public string YearlyRetentionMonthsOfTheYear {get; set;}
        
        ///
        public string YearlyRetentionTimes {get; set;}
        
        ///
        public string YearlyRetentionWeeksOfTheMonth {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
