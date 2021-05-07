using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.LoanPipeline.v1
{
    public static class PipelineExtensions
    {
        public static IPipelineV1? V1 { get; set; }

        private static IPipelineV1 GetV1(IPipeline pipeline)
        {
            var v1 = V1;
            if (pipeline is Pipeline p)
            {
                v1 = (IPipelineV1)p.ExtensionData.GetOrAdd("v1", k => new PipelineV1(p.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(pipeline, nameof(pipeline));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        public static Task<PipelineCanonicalNames> GetCanonicalNamesAsync(this IPipeline pipeline, CancellationToken cancellationToken = default) => GetV1(pipeline).GetCanonicalNamesAsync(cancellationToken);

        public static Task<string> GetCanonicalNamesRawAsync(this IPipeline pipeline, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(pipeline).GetCanonicalNamesRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Creates a cursor to paginate large data sets.
        /// </summary>
        /// <param name="parameters">The pipeline parameters used to specify the loans and fields to include.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<ILoanPipelineCursor> CreateCursorAsync(this IPipeline pipeline, PipelineParameters parameters, CancellationToken cancellationToken = default) => CreateCursorAsync(pipeline, parameters, null, cancellationToken);

        /// <summary>
        /// Creates a cursor to paginate large data sets.
        /// </summary>
        /// <param name="parameters">The pipeline parameters used to specify the loans and fields to include.</param>
        /// <param name="ignoreInvalidFields">Ignores the invalid fields specified in the request body if set to <c>true</c>, else will return an error with list of invalid fields.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<ILoanPipelineCursor> CreateCursorAsync(this IPipeline pipeline, PipelineParameters parameters, bool? ignoreInvalidFields, CancellationToken cancellationToken = default) => GetV1(pipeline).CreateCursorAsync(parameters, ignoreInvalidFields, cancellationToken);

        public static Task<List<LoanPipelineData>> ViewPipelineAsync(this IPipeline pipeline, PipelineParameters parameters, CancellationToken cancellationToken = default) => ViewPipelineAsync(pipeline, parameters, null, null, cancellationToken);

        public static Task<List<LoanPipelineData>> ViewPipelineAsync(this IPipeline pipeline, PipelineParameters parameters, int? limit, CancellationToken cancellationToken = default) => ViewPipelineAsync(pipeline, parameters, limit, null, cancellationToken);

        public static Task<List<LoanPipelineData>> ViewPipelineAsync(this IPipeline pipeline, PipelineParameters parameters, bool? ignoreInvalidFields, CancellationToken cancellationToken = default) => ViewPipelineAsync(pipeline, parameters, null, ignoreInvalidFields, cancellationToken);

        public static Task<List<LoanPipelineData>> ViewPipelineAsync(this IPipeline pipeline, PipelineParameters parameters, int? limit, bool? ignoreInvalidFields, CancellationToken cancellationToken = default) => GetV1(pipeline).ViewPipelineAsync(parameters, limit, ignoreInvalidFields, cancellationToken);

        public static Task<string> ViewPipelineRawAsync(this IPipeline pipeline, string parameters, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(pipeline).ViewPipelineRawAsync(parameters, queryString, cancellationToken);
    }
}