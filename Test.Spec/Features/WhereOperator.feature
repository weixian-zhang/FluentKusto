Feature: Where operator
![Where](https://docs.microsoft.com/en-us/azure/data-explorer/kusto/query/whereoperator)
Filters a table to the subset of rows that satisfy a predicate

Scenario: Supports Where filter
    Given a Log Analytics or Application Insights table object
    When user uses Where operator in query:
    """
    Kusto.New().AzureActivity
            .Where(tbl => tbl.SourceSystem.In(Sys A, Sys B, Sys X))
            .QueryAsString()
    """
    Then the kql query syntax should be:
    """
    AzureActivity
    | where SourceSystem in ("Sys A", "Sys B", "Sys X")
    """