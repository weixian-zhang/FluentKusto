# FluentKusto  

FluentKusto is a C# library that facilitates users to write [Kusto queries](https://docs.microsoft.com/en-us/azure/data-explorer/kusto/query/) in C# with fluent interface and strongly typed [Log Analytics tables](https://docs.microsoft.com/en-us/azure/azure-monitor/reference/tables/tables-category) and columns.  
<br />
This project is in an early stage and more Kusto operator support will be are added overtime.  
Nuget package will be publish in future.  


* [Supported Scalar Operators](#supported-scalar-operators)
* [Supported String Operators](#supported-string-operators)
* [Supported Functions](#supported-functions)
* [Examples](https://github.com/weixian-zhang/FluentKusto/blob/main/Samples/Console/FluentInterface.Samples.Console/Program.cs)

#### Supported Scalar Operators  
* Where
* Extend
* Project
* Join
* Count  

#### Supported String Operators  
String operators are Extension methods
* in - As **in** is a reserved keyword in C# for pass by refrence, this operator is implemented with capital I as In.  
  E.g: <code>"SourceSystem".**In**("System A", "System B", "System C")</code>
* equal - <code>tbl.Computer.equal("Com1")</code>
* notequal - <code>tbl.Computer.notequal("Com1")</code>
* equalnoncase - <code>tbl.BulletinUrl.equalnoncase("http://somewebsite.com")</code>

#### Supported Functions
* ago - <code>Kql.ago("4h")</code>
* split - <code>Kql.split(string str, '/')</code>
* parse_json -<code> Kql.parse_json(string str)</code>
* array_length - <code>Kql.array_length(c.ResourceArray)</code>
