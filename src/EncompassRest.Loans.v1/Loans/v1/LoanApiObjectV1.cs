using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.v1
{
    internal abstract class LoanApiObjectV1<T> : LoanApiObjectV1
        where T : DirtyExtensibleObject
    {
        internal readonly ILoanObjectBoundApis? LoanObjectBoundApis;

        internal LoanApiObjectV1(EncompassRestClient client, ILoanApis loanApis, string loanId, string baseApiPath)
            : base(client, loanApis, loanId, baseApiPath)
        {
            LoanObjectBoundApis = loanApis as ILoanObjectBoundApis;
        }

        internal abstract IList<T> GetInLoan(Loan loan);

        internal async Task<IList<T>> GetAllAsync(string methodName, CancellationToken cancellationToken)
        {
            IList<T> list;
            if (LoanObjectBoundApis?.ReflectToLoanObject == true)
            {
                list = GetInLoan(LoanObjectBoundApis.Loan);
                await GetPopulateDirtyAsync(null, null, methodName, null, (IDirty)list, true, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                list = await GetDirtyListAsync<T>(null, null, methodName, null, cancellationToken).ConfigureAwait(false);
            }
            return list;
        }

        internal async Task<T> GetAsync(string id, string methodName, CancellationToken cancellationToken)
        {
            T value;
            if (LoanObjectBoundApis?.ReflectToLoanObject == true)
            {
                var list = GetInLoan(LoanObjectBoundApis.Loan);
                var index = list.IndexOf(id);
                if (index >= 0)
                {
                    value = list[index];
                    await GetPopulateDirtyAsync(id, null, methodName, id, value, true, cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    value = await GetDirtyAsync<T>(id, null, methodName, id, cancellationToken).ConfigureAwait(false);
                    list.Add(value);
                }
            }
            else
            {
                value = await GetDirtyAsync<T>(id, null, methodName, id, cancellationToken).ConfigureAwait(false);
            }
            return value;
        }

        internal async Task<string> CreateAsync(T value, string methodName, bool populate, CancellationToken cancellationToken)
        {
            var id = await PostPopulateDirtyAsync(null, methodName, value, populate, cancellationToken).ConfigureAwait(false);
            if (LoanObjectBoundApis?.ReflectToLoanObject == true)
            {
                GetInLoan(LoanObjectBoundApis.Loan).Add(value);
            }
            return id;
        }

        internal async Task UpdateAsync(T value, string methodName, bool populate, CancellationToken cancellationToken)
        {
            var id = ((IIdentifiable)value).Id;
            var content = JsonStreamContent.Create(value);
            if (LoanObjectBoundApis?.ReflectToLoanObject == true)
            {
                var list = GetInLoan(LoanObjectBoundApis.Loan);
                var index = list.IndexOf(id!);
                if (index >= 0)
                {
                    var existing = list[index];
                    await PatchPopulateDirtyAsync(id, content, methodName, id, existing, populate, cancellationToken).ConfigureAwait(false);
                    if (!populate)
                    {
                        content = JsonStreamContent.Create(value);
                        await content.PopulateAsync(existing).ConfigureAwait(false);
                        value.Dirty = false;
                        existing.Dirty = false;
                    }
                }
                else
                {
                    await PatchPopulateDirtyAsync(id, content, methodName, id, value, populate, cancellationToken).ConfigureAwait(false);
                    list.Add(value);
                }
            }
            else
            {
                await PatchPopulateDirtyAsync(id, content, methodName, id, value, populate, cancellationToken).ConfigureAwait(false);
            }
        }

        internal async Task<bool> TryDeleteAsync(string id, CancellationToken cancellationToken)
        {
            var success = await TryDeleteAsync(id, null, cancellationToken).ConfigureAwait(false);
            if (success && LoanObjectBoundApis?.ReflectToLoanObject == true)
            {
                DeleteFromLoanObject(id);
            }
            return success;
        }

        internal async Task DeleteAsync(string id, CancellationToken cancellationToken)
        {
            await DeleteAsync(id, null, cancellationToken).ConfigureAwait(false);
            if (LoanObjectBoundApis?.ReflectToLoanObject == true)
            {
                DeleteFromLoanObject(id);
            }
        }

        private void DeleteFromLoanObject(string id)
        {
            var list = GetInLoan(LoanObjectBoundApis!.Loan);
            var index = list.IndexOf(id);
            if (index >= 0)
            {
                list.RemoveAt(index);
            }
        }
    }
}