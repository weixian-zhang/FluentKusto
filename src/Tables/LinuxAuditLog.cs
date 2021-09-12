
using System;
using System.Linq.Expressions;

namespace FluentKusto
{
    public class LinuxAuditLog : TableBase<LinuxAuditLog>
    {

            /// 
            public DateTime TimeGenerated {get; set;}
            
            /// 
            public string SourceComputerId {get; set;}
            
            /// 
            public string ManagementGroup {get; set;}
            
            /// 
            public DateTime TimeUploaded {get; set;}
            
            /// 
            public string ManagementGroupName {get; set;}
            
            /// 
            public string ExternalAgentIp {get; set;}
            
            /// 
            public string ResourceId {get; set;}
            
            /// 
            public string Computer {get; set;}
            
            /// 
            public string RecordType {get; set;}
            
            /// 
            public string AuditID {get; set;}
            
            /// 
            public string SerialNumber {get; set;}
            
            /// 
            public long uid {get; set;}
            
            /// 
            public string user {get; set;}
            
            /// 
            public string node {get; set;}
            
            /// 
            public long argc {get; set;}
            
            /// 
            public string a0 {get; set;}
            
            /// 
            public string a1 {get; set;}
            
            /// 
            public string a2 {get; set;}
            
            /// 
            public string a3 {get; set;}
            
            /// 
            public string a4 {get; set;}
            
            /// 
            public string a5 {get; set;}
            
            /// 
            public string a6 {get; set;}
            
            /// 
            public string a7 {get; set;}
            
            /// 
            public string a8 {get; set;}
            
            /// 
            public string a9 {get; set;}
            
            /// 
            public long auid {get; set;}
            
            /// 
            public string audit_user {get; set;}
            
            /// 
            public long euid {get; set;}
            
            /// 
            public string op {get; set;}
            
            /// 
            public string effective_user {get; set;}
            
            /// 
            public string acct {get; set;}
            
            /// 
            public string addr {get; set;}
            
            /// 
            public string arch {get; set;}
            
            /// 
            public string cmd {get; set;}
            
            /// 
            public string comm {get; set;}
            
            /// 
            public string cwd {get; set;}
            
            /// 
            public string data {get; set;}
            
            /// 
            public string exe {get; set;}
            
            /// 
            public string exit {get; set;}
            
            /// 
            public string family {get; set;}
            
            /// 
            public string filetype {get; set;}
            
            /// 
            public long gid {get; set;}
            
            /// 
            public string group {get; set;}
            
            /// 
            public long egid {get; set;}
            
            /// 
            public string effective_group {get; set;}
            
            /// 
            public string hostname {get; set;}
            
            /// 
            public string icmptype {get; set;}
            
            /// 
            public string key {get; set;}
            
            /// 
            public string name {get; set;}
            
            /// 
            public string path {get; set;}
            
            /// 
            public long pid {get; set;}
            
            /// 
            public long ppid {get; set;}
            
            /// 
            public string res {get; set;}
            
            /// 
            public string result {get; set;}
            
            /// 
            public long ses {get; set;}
            
            /// 
            public string success {get; set;}
            
            /// 
            public string syscall {get; set;}
            
            /// 
            public string terminal {get; set;}
            
            /// 
            public string tty {get; set;}
            
            /// 
            public string vm {get; set;}
            
            /// 
            public string RawRecord {get; set;}
            
            /// 
            public string ComputerEnvironment {get; set;}
            
            /// The name of the table
            public string Type {get; set;}
            
            /// A unique identifier for the resource that the record is associated with
            public string _ResourceId {get; set;}
            
            /// A unique identifier for the subscription that the record is associated with
            public string _SubscriptionId {get; set;}
                }
}
