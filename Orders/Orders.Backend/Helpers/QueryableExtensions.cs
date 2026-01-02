namespace Orders.Backend.Helpers;

public static class QueryableExtensions
{
    public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable, int pageNumber, int recordsNumber)
    {
        return queryable
            .Skip((pageNumber - 1) * recordsNumber)
            .Take(recordsNumber);
    }
}