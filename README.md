# FluentKusto  

FluentKusto is a C# library that provides fluent interface and strongly typed Log Analytics tables and columns.  

* [Supported Scalar Operators](#supported-scalar-operators)
* [Supported String Operators](#supported-string-operators)
* [Supported Functions](#supported-functions)
* [Examples](#examples)

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
* equal - tbl.Computer.equal("Com1")
* notequal - tbl.Computer.notequal("Com1")
* equalnoncase - tbl.BulletinUrl.equalnoncase("http://somewebsite.com")

#### Supported Functions
* ago - <code>Kql.ago("4h")</code>
* split - <code>Kql.split(string str, '/')</code>
* parse_json -<code> Kql.parse_json(string str)</code>
* array_length - <code>Kql.array_length(c.ResourceArray)</code>

#### Examples 
* Simple Where with string operator "in"  
  <code>
  Kusto.New().AzureActivity
  </code>  
  <code>
  .Where(t => t.SourceSystem.In("A", "B", "BC", "DE"))
  </code>  
  
 * Where with Join  
 
 <code>Kusto.New().AzureActivity </code>  
    <code>.Where(t => t.SourceSystem.In("A", "B", "BC", "DE"))</code>  
    <code>.Join<AzureActivity>(JoinKind.rightanti,</code>  
      <code>Kusto.New().AzureActivity</code>  
      <code>)</code>  
   <code>.On<AzureActivity>((left, right) => left.OperationId)</code>

