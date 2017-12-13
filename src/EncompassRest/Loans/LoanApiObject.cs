using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    public abstract class LoanApiObject : ApiObject
    {
        public string LoanId { get; }

        internal LoanApiObject(EncompassRestClient client, string loanId, string baseApiPath)
            : base(client, $"encompass/v1/loans/{loanId}{baseApiPath?.PrecedeWith("/")}")
        {
            LoanId = loanId;
        }

        internal override string CreateErrorMessage(string methodName, string resourceId = null) => base.CreateErrorMessage(methodName, $"{LoanId}{resourceId?.PrecedeWith("/")}");
    }

    public abstract class LoanApiObject<T> : LoanApiObject
        where T : class
    {
        private readonly LoanObjectBoundApis _loanObjectBoundApis;

        internal LoanApiObject(EncompassRestClient client, LoanObjectBoundApis loanObjectBoundApis, string baseApiPath)
            : this(client, loanObjectBoundApis.LoanId, baseApiPath)
        {
            _loanObjectBoundApis = loanObjectBoundApis;
        }

        internal LoanApiObject(EncompassRestClient client, string loanId, string baseApiPath)
            : base(client, loanId, baseApiPath)
        {
        }

        internal abstract IList<T> GetInLoan(Loan loan);

        internal async Task<List<TClass>> GetAllAsync<TClass>(string methodName, CancellationToken cancellationToken)
            where TClass : class, T, IDirty, IIdentifiable
        {
            var list = await GetDirtyListAsync<TClass>(null, null, methodName, null, cancellationToken).ConfigureAwait(false);
            if (_loanObjectBoundApis?.ReflectToLoanObject == true)
            {
                var existing = GetInLoan(_loanObjectBoundApis.Loan);
                existing.Clear();
                foreach (var item in list)
                {
                    existing.Add(item);
                }
            }
            return list;
        }

        internal async Task<TClass> GetAsync<TClass>(string id, string methodName, CancellationToken cancellationToken)
            where TClass : class, T, IDirty, IIdentifiable
        {
            var value = await GetDirtyAsync<TClass>(id, null, methodName, id, cancellationToken).ConfigureAwait(false);
            if (_loanObjectBoundApis?.ReflectToLoanObject == true)
            {
                AddToOrUpdateLoan(value);
            }
            return value;
        }

        internal async Task<string> CreateAsync<TClass>(TClass value, string methodName, bool populate, CancellationToken cancellationToken)
            where TClass : class, T, IDirty, IIdentifiable
        {
            var id = await PostPopulateDirtyAsync(null, populate ? ViewEntityQueryString : null, value, methodName, populate, cancellationToken).ConfigureAwait(false);
            if (_loanObjectBoundApis?.ReflectToLoanObject == true)
            {
                GetInLoan(_loanObjectBoundApis.Loan).Add(value);
            }
            return id;
        }

        internal async Task UpdateAsync<TClass>(TClass value, string methodName, bool populate, CancellationToken cancellationToken)
            where TClass : class, T, IDirty, IIdentifiable
        {
            await PatchPopulateDirtyAsync(value.Id, populate ? ViewEntityQueryString : null, JsonStreamContent.Create(value), methodName, value.Id, cancellationToken, value, populate).ConfigureAwait(false);
            if (_loanObjectBoundApis?.ReflectToLoanObject == true)
            {
                AddToOrUpdateLoan(value);
            }
        }

        internal async Task<bool> DeleteAsync<TClass>(string id, CancellationToken cancellationToken)
            where TClass : class, T, IDirty, IIdentifiable
        {
            var success = await DeleteAsync(id, cancellationToken).ConfigureAwait(false);
            if (success && _loanObjectBoundApis?.ReflectToLoanObject == true)
            {
                var list = GetInLoan(_loanObjectBoundApis.Loan);
                for (var i = 0; i < list.Count; ++i)
                {
                    if (string.Equals(((IIdentifiable)list[i]).Id, id, StringComparison.OrdinalIgnoreCase))
                    {
                        list.RemoveAt(i);
                        break;
                    }
                }
            }
            return success;
        }

        private void AddToOrUpdateLoan<TClass>(TClass item)
            where TClass : class, T, IDirty, IIdentifiable
        {
            var list = GetInLoan(_loanObjectBoundApis.Loan);
            var found = false;
            for (var i = 0; i < list.Count; ++i)
            {
                if (string.Equals(((IIdentifiable)list[i]).Id, item.Id, StringComparison.OrdinalIgnoreCase))
                {
                    list[i] = item;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                list.Add(item);
            }
        }
    }
}
