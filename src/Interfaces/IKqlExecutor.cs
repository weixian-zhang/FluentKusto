namespace FluentKusto
{
    public interface IKqlExecutor
    {
        public QueryResult Run();

        public string GetQuery();
    }
}