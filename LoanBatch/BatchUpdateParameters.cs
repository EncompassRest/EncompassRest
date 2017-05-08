using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EncompassRest.Data;
using EncompassRest.Filters;
using EncompassRest.Utilities;

namespace EncompassRest.LoanBatch
{
    public sealed class BatchUpdateParameters
    {
        public Filter Filter { get; }

        public IEnumerable<string> LoanGuids { get; }

        public IEnumerable<FieldValuePair> LoanFields { get; }

        public Loan LoanData { get; }

        public BatchUpdateParameters(Filter filter, IEnumerable<FieldValuePair> loanFields)
        {
            Preconditions.NotNull(filter, nameof(filter));
            Preconditions.NotNullOrEmpty(loanFields, nameof(loanFields));

            Filter = filter;
            LoanFields = new ReadOnlyCollection<FieldValuePair>(loanFields.ToList());
        }

        public BatchUpdateParameters(Filter filter, Loan loanData)
        {
            Preconditions.NotNull(filter, nameof(filter));
            Preconditions.NotNull(loanData, nameof(loanData));

            Filter = filter;
            LoanData = loanData;
        }

        public BatchUpdateParameters(IEnumerable<string> loanGuids, IEnumerable<FieldValuePair> loanFields)
        {
            Preconditions.NotNullOrEmpty(loanGuids, nameof(loanGuids));
            Preconditions.NotNullOrEmpty(loanFields, nameof(loanFields));

            LoanGuids = new ReadOnlyCollection<string>(loanGuids.ToList());
            LoanFields = new ReadOnlyCollection<FieldValuePair>(loanFields.ToList());
        }

        public BatchUpdateParameters(IEnumerable<string> loanGuids, Loan loanData)
        {
            Preconditions.NotNullOrEmpty(loanGuids, nameof(loanGuids));
            Preconditions.NotNull(loanData, nameof(loanData));

            LoanGuids = new ReadOnlyCollection<string>(loanGuids.ToList());
            LoanData = loanData;
        }
    }
}