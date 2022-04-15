using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Schema.v3;

/// <summary>
/// The Schema Apis.
/// </summary>
public interface ISchemaV3 : IApiObject
{
    /// <summary>
    /// Gets the loan schema for the specified <paramref name="entities"/> and optionally includes field extensions.
    /// </summary>
    /// <param name="includeFieldExtensions">Include field extensions.</param>
    /// <param name="entities">Entities to include.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    /// <returns></returns>
    Task<EntitySchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<string>? entities, CancellationToken cancellationToken = default);
    /// <summary>
    /// Gets the loan schema as raw json.
    /// </summary>
    /// <param name="queryString">The query string to include in the request.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    /// <returns></returns>
    Task<string> GetLoanSchemaRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Returns the standard field definitions in a loan.
    /// </summary>
    /// <param name="options">The standard field retrieval options.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    /// <returns></returns>
    Task<List<StandardFieldSchema>> GetStandardFieldSchemaAsync(StandardFieldRetrievalOptions options, CancellationToken cancellationToken = default);
    /// <summary>
    /// Returns the standard field definitions in a loan as raw json.
    /// </summary>
    /// <param name="queryString">The query string to include in the request.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    /// <returns></returns>
    Task<string> GetStandardFieldSchemaRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Returns the virtual field definitions in a loan.
    /// </summary>
    /// <param name="options">The virtual field retrieval options.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    /// <returns></returns>
    Task<List<VirtualFieldSchema>> GetVirtualFieldSchemaAsync(VirtualFieldRetrievalOptions? options = null, CancellationToken cancellationToken = default);
    /// <summary>
    /// Returns the virtual field definitions in a loan as raw json.
    /// </summary>
    /// <param name="queryString">The query string to include in the request.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    Task<string> GetVirtualFieldSchemaRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
}

internal sealed class SchemaV3 : ApiObject, ISchemaV3
{
    internal SchemaV3(EncompassRestClient client)
        : base(client, "encompass/v3/schemas/loan")
    {
    }

    public Task<EntitySchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<string>? entities, CancellationToken cancellationToken = default)
    {
        var queryParameters = new QueryParameters();
        if (entities?.Any() == true)
        {
            queryParameters.Add("entities", string.Join(",", entities));
        }
        queryParameters.Add("includeFieldExtensions", includeFieldExtensions.ToString().ToLower());

        return GetAsync<EntitySchema>(null, queryParameters.ToString(), nameof(GetLoanSchemaAsync), null, cancellationToken);
    }

    public Task<string> GetLoanSchemaRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetLoanSchemaRawAsync), null, cancellationToken);

    public Task<List<StandardFieldSchema>> GetStandardFieldSchemaAsync(StandardFieldRetrievalOptions options, CancellationToken cancellationToken = default)
    {
        Preconditions.NotNull(options, nameof(options));

        return GetListAsync<StandardFieldSchema>("standardFields", options.ToString(), nameof(GetStandardFieldSchemaAsync), null, cancellationToken);
    }

    public Task<string> GetStandardFieldSchemaRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("standardFields", queryString, nameof(GetStandardFieldSchemaRawAsync), null, cancellationToken);

    public Task<List<VirtualFieldSchema>> GetVirtualFieldSchemaAsync(VirtualFieldRetrievalOptions? options = null, CancellationToken cancellationToken = default) => GetListAsync<VirtualFieldSchema>("virtualFields", options?.ToString(), nameof(GetVirtualFieldSchemaAsync), null, cancellationToken);

    public Task<string> GetVirtualFieldSchemaRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("virtualFields", queryString, nameof(GetVirtualFieldSchemaRawAsync), null, cancellationToken);
}