using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.v1;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Schema.v3;

/// <summary>
/// The Schema Api extension methods.
/// </summary>
public static class SchemaExtensions
{
    /// <summary>
    /// The custom v1 Api implementation for unit testing.
    /// </summary>
    public static ISchemaV3? V3 { get; set; }

    private static ISchemaV3 GetV3(ISchema schema)
    {
        var v1 = V3;
        if (schema is Schema s)
        {
            v1 = s.ExtensionData.GetOrAdd(() => new SchemaV3(s.Client));
        }
        else if (v1 == null)
        {
            Preconditions.NotNull(schema, nameof(schema));
            throw new InvalidOperationException("Must set V1 property when not using the default implementation");
        }
        return v1;
    }

    /// <summary>
    /// Gets the loan schema for all entities.
    /// </summary>
    /// <param name="schema">The Schema Api Object.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    /// <returns></returns>
    public static Task<EntitySchema> GetLoanSchemaAsync(this ISchema schema, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(schema, false, (IEnumerable<string>?)null, cancellationToken);

    /// <summary>
    /// Gets the loan schema for all entities and optionally includes field extensions.
    /// </summary>
    /// <param name="schema">The Schema Api Object.</param>
    /// <param name="includeFieldExtensions">Include field extensions.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    /// <returns></returns>
    public static Task<EntitySchema> GetLoanSchemaAsync(this ISchema schema, bool includeFieldExtensions, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(schema, includeFieldExtensions, (IEnumerable<string>?)null, cancellationToken);

    /// <summary>
    /// Gets the loan schema for the specified <paramref name="entities"/>.
    /// </summary>
    /// <param name="schema">The Schema Api Object.</param>
    /// <param name="entities">Entities to include.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    /// <returns></returns>
    public static Task<EntitySchema> GetLoanSchemaAsync(this ISchema schema, IEnumerable<LoanEntity>? entities, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(schema, false, entities, cancellationToken);

    /// <summary>
    /// Gets the loan schema for the specified <paramref name="entities"/>.
    /// </summary>
    /// <param name="schema">The Schema Api Object.</param>
    /// <param name="entities">Entities to include.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    /// <returns></returns>
    public static Task<EntitySchema> GetLoanSchemaAsync(this ISchema schema, IEnumerable<string>? entities, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(schema, false, entities, cancellationToken);

    /// <summary>
    /// Gets the loan schema for the specified <paramref name="entities"/> and optionally includes field extensions.
    /// </summary>
    /// <param name="schema">The Schema Api Object.</param>
    /// <param name="includeFieldExtensions">Include field extensions.</param>
    /// <param name="entities">Entities to include.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    /// <returns></returns>
    public static Task<EntitySchema> GetLoanSchemaAsync(this ISchema schema, bool includeFieldExtensions, IEnumerable<LoanEntity>? entities, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(schema, includeFieldExtensions, entities?.Select(e => e.Validate(nameof(entities)).GetName()!), cancellationToken);

    /// <summary>
    /// Gets the loan schema for the specified <paramref name="entities"/> and optionally includes field extensions.
    /// </summary>
    /// <param name="schema">The Schema Api Object.</param>
    /// <param name="includeFieldExtensions">Include field extensions.</param>
    /// <param name="entities">Entities to include.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    /// <returns></returns>
    public static Task<EntitySchema> GetLoanSchemaAsync(this ISchema schema, bool includeFieldExtensions, IEnumerable<string>? entities, CancellationToken cancellationToken = default) => GetV3(schema).GetLoanSchemaAsync(includeFieldExtensions, entities, cancellationToken);

    /// <summary>
    /// Gets the loan schema as raw json.
    /// </summary>
    /// <param name="schema">The Schema Api Object.</param>
    /// <param name="queryString">The query string to include in the request.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    /// <returns></returns>
    public static Task<string> GetLoanSchemaRawAsync(this ISchema schema, string? queryString = null, CancellationToken cancellationToken = default) => GetV3(schema).GetLoanSchemaRawAsync(queryString, cancellationToken);

    /// <summary>
    /// Returns the standard field definitions in a loan.
    /// </summary>
    /// <param name="schema">The Schema Api Object.</param>
    /// <param name="ids">List of field IDs for which you want field definitions.</param>
    /// <param name="start">Starting number on the page. Zero-based starting index. The default is zero.</param>
    /// <param name="limit">The maximum number of items to return.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    /// <returns></returns>
    public static Task<List<StandardFieldSchema>> GetStandardFieldSchemaAsync(this ISchema schema, IEnumerable<string>? ids = null, int? start = null, int? limit = null, CancellationToken cancellationToken = default) => GetV3(schema).GetStandardFieldSchemaAsync(ids, start, limit, cancellationToken);

    /// <summary>
    /// Returns the standard field definitions in a loan as raw json.
    /// </summary>
    /// <param name="schema">The Schema Api Object.</param>
    /// <param name="queryString">The query string to include in the request.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    /// <returns></returns>
    public static Task<string> GetStandardFieldSchemaRawAsync(this ISchema schema, string? queryString = null, CancellationToken cancellationToken = default) => GetV3(schema).GetStandardFieldSchemaRawAsync(queryString, cancellationToken);

    /// <summary>
    /// Returns the virtual field definitions in a loan.
    /// </summary>
    /// <param name="schema">The Schema Api Object.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    /// <returns></returns>
    public static Task<List<VirtualFieldSchema>> GetVirtualFieldSchemaAsync(this ISchema schema, CancellationToken cancellationToken = default) => GetV3(schema).GetVirtualFieldSchemaAsync(cancellationToken);

    /// <summary>
    /// Returns the virtual field definitions in a loan as raw json.
    /// </summary>
    /// <param name="schema">The Schema Api Object.</param>
    /// <param name="queryString">The query string to include in the request.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
    public static Task<string> GetVirtualFieldSchemaRawAsync(this ISchema schema, string? queryString = null, CancellationToken cancellationToken = default) => GetV3(schema).GetVirtualFieldSchemaRawAsync(queryString, cancellationToken);
}