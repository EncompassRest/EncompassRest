using System;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.v1;

namespace EncompassRest.v1
{
    public static class ClientParametersExtensions
    {
        public static ClientParameters AddV1CacheInitialization(this ClientParameters parameters)
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
            if (parameters.StandardFieldsCacheInitialization != CacheInitialization.Never && !((DateTime.UtcNow - LoanFieldDescriptors.StandardFieldsLastRefreshedUtc)?.TotalMinutes < (int)parameters.StandardFieldsCacheInitialization))
            {
                await LoanFieldDescriptors.RefreshStandardFieldsAsync(client, cancellationToken).ConfigureAwait(false);
            }
        }
    }
}