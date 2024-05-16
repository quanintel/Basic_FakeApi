using System.Linq.Dynamic.Core;
using FakeApi.Data.Dtos.Custom;

namespace FakeApi.Common;

public static class QueryExtensions
{
    public static IQueryable<T> GetQueryByInput<T>(this IQueryable<T> query, ApiInput input)
    {
        var searchTerm = input.Keyword?.ToLower().Trim();
        if (!string.IsNullOrWhiteSpace(searchTerm))
        {
            query = query.Where(
                $"({string.Join(" || ", typeof(T).GetProperties()
                    .Where(property => property.PropertyType == typeof(string))
                    .Select(property => $"{property.Name}.ToLower().Contains(@0)"))})",
                searchTerm);
        }

        if (input.FromDate.HasValue && input.ToDate.HasValue)
        {
            query = query.Where($"(LuUpdated.Date >= @0 && LuUpdated.Date <= @1)", input.FromDate.Value.Date,
                input.ToDate.Value.Date);
        }

        return query.Skip((input.PageNumber - 1) * input.PageSize).Take(input.PageSize);
    }
}