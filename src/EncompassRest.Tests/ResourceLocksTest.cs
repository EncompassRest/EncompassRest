using EncompassRest.Loans;
using EncompassRest.ResourceLocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace EncompassRest.Tests
{
    [TestClass]
    public class ResourceLocksTest : TestBaseClass
    {
        [TestMethod]
        public async Task Lock_LoanLockAndUnlock()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan();
            var loanId = await client.Loans.CreateLoanAsync(loan,true);
            var locks = await loan.LoanApis.GetLocksAsync();
            Assert.IsTrue(locks.Count == 0);

            var lockId = await loan.LoanApis.LockAsync(ResourceLockType.Exclusive);
            var loanLock = await loan.LoanApis.GetLockAsync(lockId);
            Assert.AreEqual(loanLock.LockType.ToString(), ResourceLockType.Exclusive.ToString());

            Assert.IsTrue(await loan.LoanApis.UnlockAsync(lockId));
            await Task.Delay(5000);
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId).ConfigureAwait(false));
        }
    }
}
