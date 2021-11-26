Feature: Where operator
![Where](https://docs.microsoft.com/en-us/azure/data-explorer/kusto/query/whereoperator)
Filters a table to the subset of rows that satisfy a predicate

Scenario: Where operator used alone
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

Scenario: Where operator used with Extend
    Given a Log Analytics or Application Insights table object
    When user uses Where operator with Extend operator in query:
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