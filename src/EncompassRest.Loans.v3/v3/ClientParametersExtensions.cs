using System;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.v3;

namespace EncompassRest.v3
{
    /// <summary>
    /// Client Parameters extension methods.
    /// </summary>
    public static class ClientParametersExtensions
    {
        /// <summary>
        /// Adds v1 cache initialization logic.
        /// </summary>
        /// <param name="parameters">The client parameters to attach v1 cache initialization.</param>
        /// <returns>The client parameters passed in.</returns>
        public static ClientParameters AddV3CacheInitialization(this ClientParameters parameters)
        {
            parameters.Initialization -= Parameters_Initialization;
            parameters.Initialization += Parameters_Initialization;
            return parameters;
        }

        private static async Task Parameters_Initialization(ClientParameters parameters, EncompassRestClient client, CommonCache commonCache, CancellationToken cancellationToken)
        {
            if (parameters.CustomFieldsCacheInitialization != CacheInitialization.Never && !((DateTime.UtcNow - commonCache.GetCustomFieldsLastRefreshedUtc())?.TotalMinutes < (int)parameters.CustomFieldsCacheInitialization))
            {
                await commonCache.RefreshCustomFieldsAsync(client, cancellationToken).ConfigureAwait(false);
            }
            //if (parameters.StandardFieldsCacheInitialization != CacheInitialization.Never && !((DateTime.UtcNow - LoanFieldDescriptors.StandardFieldsLastRefreshedUtc)?.TotalMinutes < (int)parameters.StandardFieldsCacheInitialization))
            //{
            //    await LoanFieldDescriptors.RefreshStandardFieldsAsync(client, cancellationToken).ConfigureAwait(false);
            //}
        }
    }
}