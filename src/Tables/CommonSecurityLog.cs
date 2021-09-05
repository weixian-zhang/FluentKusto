

namespace FluentKusto
{
    public class CommonSecurityLog
    {

        ///
        public string TenantId {get; set;}
        
        ///Hard coded- 'OpsManager'.
        public string SourceSystem {get; set;}
        
        ///Event collection time in UTC.
        public datetime TimeGenerated {get; set;}
        
        ///The time at which the event related to the activity was received. Different then the 'Timegenerated' field, which is when the event was recieved in the log collector machine.
        public string ReceiptTime {get; set;}
        
        ///String that together with device product and version definitions, uniquely identifies the type of sending device.
        public string DeviceVendor {get; set;}
        
        ///String that together with device product and version definitions, uniquely identifies the type of sending device.
        public string DeviceProduct {get; set;}
        
        ///String or integer that serves as a unique identifier per event type.
        public string DeviceEventClassID {get; set;}
        
        ///A string or integer that describes the importance of the event. Valid string values:Unknown,Low,Medium,High,Very-High Valid integer values are:0-3= Low,4-6= Medium,7-8= High,9-10= Very-High.
        public string LogSeverity {get; set;}
        
        ///A non-mapped version of LogSeverity. For example: Warning/Critical/Info insted of the normilized Low/Medium/High in the LogSeverity Field
        public string OriginalLogSeverity {get; set;}
        
        ///The action mentioned in the event.
        public string DeviceAction {get; set;}
        
        ///A mapped version ofDeviceAction, such asDenied>Deny.
        public string SimplifiedDeviceAction {get; set;}
        
        ///Host, from Syslog.
        public string Computer {get; set;}
        
        ///Any information about the direction the observed communication has taken. Valid values:0= Inbound, 1= Outbound.
        public string CommunicationDirection {get; set;}
        
        ///The facility generating the event. For example: auth or local1.
        public string DeviceFacility {get; set;}
        
        ///Destination port. Valid values:0-65535.
        public int DestinationPort {get; set;}
        
        ///The destination IpV4 address that the event refers to in an IP network.
        public string DestinationIP {get; set;}
        
        ///The IPv4 address of the device generating the event.
        public string DeviceAddress {get; set;}
        
        ///The FQDN associated with the device node, when a node is available. For example:host.domain.comorhost.
        public string DeviceName {get; set;}
        
        ///A message that gives more details about the event.
        public string Message {get; set;}
        
        ///Transport protocol that identifies the Layer-4 protocol used. Possible values include protocol names, such asTCPorUDP.
        public string Protocol {get; set;}
        
        ///The source port number. Valid port numbers are0-65535.
        public int SourcePort {get; set;}
        
        ///The source that an event refers to in an IP network, as an IPv4 address.
        public string SourceIP {get; set;}
        
        ///The remote IP address, derived from the event's direction value, if possible.
        public string RemoteIP {get; set;}
        
        ///The remote port, derived from the event's direction value, if possible.
        public string RemotePort {get; set;}
        
        ///If one of the IP in the message was correlate with the current TI feed we have it will show up here.
        public string MaliciousIP {get; set;}
        
        ///The threat severity of the MaliciousIP according to our TI feed at the time of the record ingestion.
        public int ThreatSeverity {get; set;}
        
        ///The threat type of the MaliciousIP according to our TI feed.
        public string IndicatorThreatType {get; set;}
        
        ///The threat description of the MaliciousIP according to our TI feed.
        public string ThreatDescription {get; set;}
        
        ///The threat confidence of the MaliciousIP according to our TI feed.
        public string ThreatConfidence {get; set;}
        
        ///Link to the report of the TI feed.
        public string ReportReferenceLink {get; set;}
        
        ///The Longitude of the MaliciousIP according to the GEO information at the time of the record ingestion.
        public real MaliciousIPLongitude {get; set;}
        
        ///The Latitude of the MaliciousIP according to the GEO information at the time of the record ingestion.
        public real MaliciousIPLatitude {get; set;}
        
        ///The country of the MaliciousIP according to the GEO information at the time of the record ingestion.
        public string MaliciousIPCountry {get; set;}
        
        ///String that together with device product and version definitions, uniquely identifies the type of sending device.
        public string DeviceVersion {get; set;}
        
        ///A string that represents a human-readable and understandable description of the event.
        public string Activity {get; set;}
        
        ///A placeholder for additional fields. Fields are logged as key-value pairs.
        public string AdditionalExtensions {get; set;}
        
        ///The protocol used in the application, such as HTTP, HTTPS, SSHv2, Telnet, POP, IMPA, IMAPS, and so on.
        public string ApplicationProtocol {get; set;}
        
        ///A count associated with the event, showing how many times the same event was observed.
        public int EventCount {get; set;}
        
        ///The DNS part of the fully-qualified domain name (FQDN).
        public string DestinationDnsDomain {get; set;}
        
        ///The service that is targeted by the event. For example:sshd.
        public string DestinationServiceName {get; set;}
        
        ///Identifies the translated destination referred to by the event in an IP network, as an IPv4 IP address.
        public string DestinationTranslatedAddress {get; set;}
        
        ///Port after translation, such as a firewall Valid port numbers:0-65535.
        public int DestinationTranslatedPort {get; set;}
        
        ///The DNS domain part of the full qualified domain name (FQDN).
        public string DeviceDnsDomain {get; set;}
        
        ///A name that uniquely identifies the device generating the event.
        public string DeviceExternalID {get; set;}
        
        ///The interface on which the packet or data entered the device. For example: ethernet1/2.
        public string DeviceInboundInterface {get; set;}
        
        ///The Windows domain of the device address.
        public string DeviceNtDomain {get; set;}
        
        ///Interface on which the packet or data left the device.
        public string DeviceOutboundInterface {get; set;}
        
        ///Unique identifier for the payload associated with the event.
        public string DevicePayloadId {get; set;}
        
        ///Process name associated with the event. For example: in UNIX, the process generating the syslog entry.
        public string ProcessName {get; set;}
        
        ///Identifies the translated device address that the event refers to, in an IP network. The format is an Ipv4 address.
        public string DeviceTranslatedAddress {get; set;}
        
        ///The destination that the event refers to in an IP network. The format should be an FQDN associated with the destination node, when a node is available. For example:host.domain.comorhost.
        public string DestinationHostName {get; set;}
        
        ///The destination MAC address (FQDN).
        public string DestinationMACAddress {get; set;}
        
        ///The Windows domain name of the destination address.
        public string DestinationNTDomain {get; set;}
        
        ///The ID of the destination process associated with the event.
        public int DestinationProcessId {get; set;}
        
        ///Defines the destination use's privileges. Valid values:Admninistrator,User,Guest.
        public string DestinationUserPrivileges {get; set;}
        
        ///The name of the events destination process, such astelnetdorsshd.
        public string DestinationProcessName {get; set;}
        
        ///Timezone of the device generating the event.
        public string DeviceTimeZone {get; set;}
        
        ///Identifies the destination user by ID. For example: in Unix, the root user is generally associated with the user ID 0.
        public string DestinationUserID {get; set;}
        
        ///Identifies the destination user by name.
        public string DestinationUserName {get; set;}
        
        ///The MAC address of the device generating the event.
        public string DeviceMacAddress {get; set;}
        
        ///Defines the ID of the process on the device generating the event.
        public int ProcessID {get; set;}
        
        ///The time at which the activity related to the event ended.
        public datetime EndTime {get; set;}
        
        ///An ID used by the originating device. Typically, these values have increasing values that are each associated with an event.
        public int ExternalID {get; set;}
        
        ///Time when the file was created.
        public string FileCreateTime {get; set;}
        
        ///Hash of a file.
        public string FileHash {get; set;}
        
        ///An ID associated with a file, such as the inode.
        public string FileID {get; set;}
        
        ///Time when the file was last modified.
        public string FileModificationTime {get; set;}
        
        ///Full path to the file, including the filename. For example:C:\ProgramFiles\WindowsNT\Accessories\wordpad.exeor/usr/bin/zip.
        public string FilePath {get; set;}
        
        ///The file's permissions. For example: '2,1,1'.
        public string FilePermission {get; set;}
        
        ///File type, such as pipe, socket, and so on.
        public string FileType {get; set;}
        
        ///The file's name, without the path.
        public string FileName {get; set;}
        
        ///The size of the file in bytes.
        public int FileSize {get; set;}
        
        ///Number of bytes transferred inbound.
        public long ReceivedBytes {get; set;}
        
        ///Time when the old file was created.
        public string OldFileCreateTime {get; set;}
        
        ///Hash of the old file.
        public string OldFileHash {get; set;}
        
        ///And ID associated with the old file, such as the inode.
        public string OldFileID {get; set;}
        
        ///Time when the old file was last modified.
        public string OldFileModificationTime {get; set;}
        
        ///Name of the old file.
        public string OldFileName {get; set;}
        
        ///Full path to the old file, including the filename. For example:C:\ProgramFiles\WindowsNT\Accessories\wordpad.exeor/usr/bin/zip.
        public string OldFilePath {get; set;}
        
        ///Permissions of the old file. For example: '2,1,1'.
        public string OldFilePermission {get; set;}
        
        ///The size of the old file in bytes.
        public int OldFileSize {get; set;}
        
        ///File type of the old file, such as a pipe, socket, and so on.
        public string OldFileType {get; set;}
        
        ///Number of bytes transferred outbound.
        public long SentBytes {get; set;}
        
        ///The URL accessed for an HTTP request, including the protocol. For example:http://www/secure.com.
        public string RequestURL {get; set;}
        
        ///The user agent associated with the request.
        public string RequestClientApplication {get; set;}
        
        ///Describes the content from which the request originated, such as the HTTP Referrer.
        public string RequestContext {get; set;}
        
        ///Cookies associated with the request.
        public string RequestCookies {get; set;}
        
        ///The method used to access a URL. Valid values include methods such asPOST,GET, and so on.
        public string RequestMethod {get; set;}
        
        ///Identifies the source that event refers to in an IP network. Format should be a fully qualified domain name (DQDN) associated with the source node, when a node is available. For example:hostorhost.domain.com.
        public string SourceHostName {get; set;}
        
        ///Source MAC address.
        public string SourceMACAddress {get; set;}
        
        ///The Windows domain name for the source address.
        public string SourceNTDomain {get; set;}
        
        ///The DNS domain part of the complete FQDN.
        public string SourceDnsDomain {get; set;}
        
        ///The service responsible for generating the event.
        public string SourceServiceName {get; set;}
        
        ///Identifies the translated source that the event refers to in an IP network.
        public string SourceTranslatedAddress {get; set;}
        
        ///Source port after translation, such as a firewall. Valid port numbers are0-65535.
        public int SourceTranslatedPort {get; set;}
        
        ///The ID of the source process associated with the event.
        public int SourceProcessId {get; set;}
        
        ///The source user's privileges. Valid values include:Administrator,User,Guest.
        public string SourceUserPrivileges {get; set;}
        
        ///The name of the event's source process.
        public string SourceProcessName {get; set;}
        
        ///The time when the activity that the event refers to started.
        public datetime StartTime {get; set;}
        
        ///Identifies the source user by ID.
        public string SourceUserID {get; set;}
        
        ///Identifies the source user by name. Email addresses are also mapped into the UserName fields. The sender is a candidate to put into this field.
        public string SourceUserName {get; set;}
        
        ///Event type. Value values include: 0: base event, 1: aggregated, 2: correlation event, 3: action event. Note: This event can be omitted for base events.
        public int EventType {get; set;}
        
        ///One of four IPv6 address fields available to map fields that do not apply to any other in this dictionary.
        public string DeviceCustomIPv6Address1 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomIPv6Address1Label {get; set;}
        
        ///One of four IPv6 address fields available to map fields that do not apply to any other in this dictionary.
        public string DeviceCustomIPv6Address2 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomIPv6Address2Label {get; set;}
        
        ///One of four IPv6 address fields available to map fields that do not apply to any other in this dictionary.
        public string DeviceCustomIPv6Address3 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomIPv6Address3Label {get; set;}
        
        ///One of four IPv6 address fields available to map fields that do not apply to any other in this dictionary.
        public string DeviceCustomIPv6Address4 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomIPv6Address4Label {get; set;}
        
        ///One of four floating point fields available to map fields that do not apply to any other in this dictionary.
        public real DeviceCustomFloatingPoint1 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomFloatingPoint1Label {get; set;}
        
        ///One of four floating point fields available to map fields that do not apply to any other in this dictionary.
        public real DeviceCustomFloatingPoint2 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomFloatingPoint2Label {get; set;}
        
        ///One of four floating point fields available to map fields that do not apply to any other in this dictionary.
        public real DeviceCustomFloatingPoint3 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomFloatingPoint3Label {get; set;}
        
        ///One of four floating point fields available to map fields that do not apply to any other in this dictionary.
        public real DeviceCustomFloatingPoint4 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomFloatingPoint4Label {get; set;}
        
        ///One of three number fields available to map fields that do not apply to any other in this dictionary. Use sparingly and seek a more specific, dictionary supplied field when possible.
        public int DeviceCustomNumber1 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomNumber1Label {get; set;}
        
        ///One of three number fields available to map fields that do not apply to any other in this dictionary. Use sparingly and seek a more specific, dictionary supplied field when possible.
        public int DeviceCustomNumber2 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomNumber2Label {get; set;}
        
        ///One of three number fields available to map fields that do not apply to any other in this dictionary. Use sparingly and seek a more specific, dictionary supplied field when possible.
        public int DeviceCustomNumber3 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomNumber3Label {get; set;}
        
        ///One of six strings available to map fields that do not apply to any other in this dictionary. Use sparingly and seek a more specific, dictionary supplied field when possible.
        public string DeviceCustomString1 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomString1Label {get; set;}
        
        ///One of six strings available to map fields that do not apply to any other in this dictionary. Use sparingly and seek a more specific, dictionary supplied field when possible.
        public string DeviceCustomString2 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomString2Label {get; set;}
        
        ///One of six strings available to map fields that do not apply to any other in this dictionary. Use sparingly and seek a more specific, dictionary supplied field when possible.
        public string DeviceCustomString3 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomString3Label {get; set;}
        
        ///One of six strings available to map fields that do not apply to any other in this dictionary. Use sparingly and seek a more specific, dictionary supplied field when possible.
        public string DeviceCustomString4 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomString4Label {get; set;}
        
        ///One of six strings available to map fields that do not apply to any other in this dictionary. Use sparingly and seek a more specific, dictionary supplied field when possible.
        public string DeviceCustomString5 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomString5Label {get; set;}
        
        ///One of six strings available to map fields that do not apply to any other in this dictionary. Use sparingly and seek a more specific, dictionary supplied field when possible.
        public string DeviceCustomString6 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomString6Label {get; set;}
        
        ///One of two timestamp fields available to map fields that do not apply to any other in this dictionary. Use sparingly and seek a more specific, dictionary supplied field when possible.
        public string DeviceCustomDate1 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomDate1Label {get; set;}
        
        ///One of two timestamp fields available to map fields that do not apply to any other in this dictionary. Use sparingly and seek a more specific, dictionary supplied field when possible.
        public string DeviceCustomDate2 {get; set;}
        
        ///All custom fields have a corresponding label field. Each of these fields is a string and describes the purpose of the custom field.
        public string DeviceCustomDate2Label {get; set;}
        
        ///A timestamp field available to map a timestamp that does not apply to any other defined timestamp field in this dictionary. Use all flex fields sparingly and seek a more specific, dictionary supplied field when possible. These fields are typically reserved for customer use and should not be set by vendors unless necessary.
        public string FlexDate1 {get; set;}
        
        ///The label field is a string and describes the purpose of the flex field.
        public string FlexDate1Label {get; set;}
        
        ///Number fields available to map Int data that does not apply to any other field in this dictionary.
        public int FlexNumber1 {get; set;}
        
        ///The label that describes the value in FlexNumber1
        public string FlexNumber1Label {get; set;}
        
        ///Number fields available to map Int data that does not apply to any other field in this dictionary.
        public int FlexNumber2 {get; set;}
        
        ///The label that describes the value in FlexNumber2
        public string FlexNumber2Label {get; set;}
        
        ///One of four floating point fields available to map fields that do not apply to any other in this dictionary. Use sparingly and seek a more specific, dictionary supplied field when possible. These fields are typically reserved for customer use and should not be set by vendors unless necessary.
        public string FlexString1 {get; set;}
        
        ///The label field is a string and describes the purpose of the flex field.
        public string FlexString1Label {get; set;}
        
        ///One of four floating point fields available to map fields that do not apply to any other in this dictionary. Use sparingly and seek a more specific, dictionary supplied field when possible. These fields are typically reserved for customer use and should not be set by vendors unless necessary.
        public string FlexString2 {get; set;}
        
        ///The label field is a string and describes the purpose of the flex field.
        public string FlexString2Label {get; set;}
        
        ///The name of the table
        public string Type {get; set;}
        
        ///A unique identifier for the resource that the record is associated with
        public string _ResourceId {get; set;}
        
        ///A unique identifier for the subscription that the record is associated with
        public string _SubscriptionId {get; set;}
            }
}
