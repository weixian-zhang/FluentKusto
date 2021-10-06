namespace FluentKusto
{
    public enum JoinKind
    {
        /// matches records from both tables without removing duplicate records
        inner,

        /// match the first values of the matched column in the left (first) table that are found, and duplicate values are removed from the left table
        innerunique,

        /// matches both left and right table and if there are no matches on the right table,
        /// the records will be in the output as well
        leftouter,

        /// return all records from the left table that do not have matches from the right.
        /// This could be use to find content which does not exist in the other table
        leftanti,

        /// return all records from the left table that do not have matches from the right.
        /// This could be use to find content which does not exist in the other table
       leftsemi,

        /// The right outer-join flavor resembles the left outer-join, but the treatment of the tables is reversed
        rightouter,

        /// A full outer-join combines the effect of applying both left and right outer-joins.
        /// Whenever records in the joined tables don't match, the result set will have null values for every column of the table that lacks a matching row.
        /// For those records that do match, a single row will be produced in the result set, containing fields populated from both tables.
        fullouter,

        /// Right anti-join returns all records from the right side that don't match any record from the left side
        rightanti,

        /// Right semi-join returns all records from the right side that match a record from the left side.
        /// Only columns from the right side are returned
        rightsemi
    }
}