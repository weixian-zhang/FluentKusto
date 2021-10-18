## FluentKusto
b
[![Build Status](https://dev.azure.com/weixzha/FluentKusto/_apis/build/status/FluentKusto%20-%20GitHub?branchName=main)](https://dev.azure.com/weixzha/FluentKusto/_build/latest?definitionId=2&branchName=main)

FluentKusto is a C# library that facilitates users to write [Kusto queries](https://docs.microsoft.com/en-us/azure/data-explorer/kusto/query/) in C# with fluent interface and strongly typed [Log Analytics tables](https://docs.microsoft.com/en-us/azure/azure-monitor/reference/tables/tables-category) and columns.
<br />
This project is in an early stage and more Kusto operators will be added overtime.
Nuget package to be made available in future.


* [Supported Scalar Operators](#supported-scalar-operators)
* [Supported String Operators](#supported-string-operators)
* [Supported Functions](#supported-functions)
* [Kusto Dynamic Column with .Net dynamic Type](#kusto-dynamic-column-with-net-dynamic-type)
* [Examples](https://github.com/weixian-zhang/FluentKusto/blob/main/Samples/Console/FluentInterface.Samples.Console/Program.cs)

#### Supported Scalar Operators
* Where
* Extend
* Project
* Join
* Count
* Limit
* Distinct, DistinctAll

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

#### Kusto Dynamic Column with .Net dynamic Type

To support the ability of Kusto able to define dynamic columns for e.g | Extend {dynamic column} = TimeGenerated,
and also the ability to reference dynamic columns in other operator expressions.
FluentKusto supply an additional **dynamic type paramater** into methods such as Extend(Table, **DynamicColumn**) and Project(Table, **DynamicColumn**).
Hence, users can fully avoid string expression and use dynamic Typed parameter for reference and other complex syntax like indexer **[]**

<img src="./docs/c%23-dynamic-type-for-kusto-dynamic-column.png" width="6500" height="300" />
