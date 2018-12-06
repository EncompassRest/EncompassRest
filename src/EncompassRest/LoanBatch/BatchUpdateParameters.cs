using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EncompassRest.Loans;
using EncompassRest.Filters;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.LoanBatch
{
    /// <summary>
    /// The batch update parameters.
    /// </summary>
    public sealed class BatchUpdateParameters : SerializableObject
    {
        /// <summary>
        /// Batch update filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Filter Filter { get; }

        /// <summary>
        /// Guids of loans to batch update.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> LoanGuids { get; }

        /// <summary>
        /// Field values to update.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<FieldValuePair> LoanFields { get; }

        /// <summary>
        /// Loan data to update.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Loan LoanData { get; }

        /// <summary>
        /// BatchUpdateParameters constructor.
        /// </summary>
        /// <param name="filter">Batch update filter.</param>
        /// <param name="loanFields">Field values to update.</param>
        public BatchUpdateParameters(Filter filter, IEnumerable<FieldValuePair> loanFields)
        {
            Preconditions.NotNull(filter, nameof(filter));
            Preconditions.NotNullOrEmpty(loanFields, nameof(loanFields));

            Filter = filter;
            LoanFields = new ReadOnlyCollection<FieldValuePair>(loanFields.ToList());
        }

        /// <summary>
        /// BatchUpdateParameters constructor.
        /// </summary>
        /// <param name="filter">Batch update filter.</param>
        /// <param name="loanData">Loan data to update.</param>
        public BatchUpdateParameters(Filter filter, Loan loanData)
        {
            Preconditions.NotNull(filter, nameof(filter));
            Preconditions.NotNull(loanData, nameof(loanData));

            Filter = filter;
            LoanData = loanData;
        }

        /// <summary>
        /// BatchUpdateParameters constructor.
        /// </summary>
        /// <param name="loanGuids">Guids of loans to batch update.</param>
        /// <param name="loanFields">Field values to update.</param>
        public BatchUpdateParameters(IEnumerable<string> loanGuids, IEnumerable<FieldValuePair> loanFields)
        {
            Preconditions.NotNullOrEmpty(loanGuids, nameof(loanGuids));
            Preconditions.NotNullOrEmpty(loanFields, nameof(loanFields));

            LoanGuids = new ReadOnlyCollection<string>(loanGuids.ToList());
            LoanFields = new ReadOnlyCollection<FieldValuePair>(loanFields.ToList());
        }

        /// <summary>
        /// BatchUpdateParameters constructor.
        /// </summary>
        /// <param name="loanGuids">Guids of loans to batch update.</param>
        /// <param name="loanData">Loan data to update.</param>
        public BatchUpdateParameters(IEnumerable<string> loanGuids, Loan loanData)
        {
            Preconditions.NotNullOrEmpty(loanGuids, nameof(loanGuids));
            Preconditions.NotNull(loanData, nameof(loanData));

            LoanGuids = new ReadOnlyCollection<string>(loanGuids.ToList());
            LoanData = loanData;
        }
    }
}