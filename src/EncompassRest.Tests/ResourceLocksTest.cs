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
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan, true);
            Assert.IsTrue((await loan.LoanApis.GetLocksAsync()).Count == 0);

            var lockId = await loan.LoanApis.LockAsync(ResourceLockType.Exclusive);
            var loanLock = await loan.LoanApis.GetLockAsync(lockId);
            Assert.AreEqual(loanLock.LockType.ToString(), ResourceLockType.Exclusive.ToString());

            var locks = await loan.LoanApis.GetLocksAsync();
            var testLock = locks.Find(x => x.Id == lockId);
            Assert.IsNotNull(testLock);
            Assert.IsTrue(locks.Count == 1);

            Assert.IsTrue(await loan.LoanApis.UnlockAsync(lockId));

            Assert.IsTrue((await loan.LoanApis.GetLocksAsync()).Count == 0);

            await Task.Delay(5000);
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId).ConfigureAwait(false));
        }
    }
}
