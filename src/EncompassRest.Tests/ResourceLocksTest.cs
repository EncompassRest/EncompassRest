using EncompassRest.Loans;
using EncompassRest.ResourceLocks;
using EnumsNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace EncompassRest.Tests
{
    [TestClass]
    public class ResourceLocksTest : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task Lock_LoanLockAndUnlock()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan, true);

            try
            {
                Assert.IsTrue((await loan.LoanApis.GetLocksAsync()).Count == 0);

                var lockId = await loan.LoanApis.LockAsync(ResourceLockType.Exclusive);
                Assert.IsFalse(string.IsNullOrEmpty(lockId));
                var loanLock = await loan.LoanApis.GetLockAsync(lockId);
                Assert.AreEqual(ResourceLockType.Exclusive.GetName(), loanLock.LockType.Value);
                Assert.AreEqual(EntityType.Loan.GetName(), loanLock.Resource.EntityType.Value);
                Assert.AreEqual(loanId, loanLock.Resource.EntityId);

                var locks = await loan.LoanApis.GetLocksAsync();
                var testLock = locks.Find(x => x.Id == lockId);
                Assert.IsNotNull(testLock);
                Assert.IsTrue(locks.Count == 1);

                await loan.LoanApis.UnlockAsync(lockId);

                Assert.IsTrue((await loan.LoanApis.GetLocksAsync()).Count == 0);
            }
            finally
            {
                try
                {
                    await Task.Delay(5000);
                    await client.Loans.DeleteLoanAsync(loanId);
                }
                catch
                {
                }
            }
        }
    }
}
