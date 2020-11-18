using System;
using System.Linq;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Loans.RateLocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class LoanRateLockTests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task LoanSubmitLockRequest()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);
            try
            {
                await Task.Delay(1000);
                var rateLockApi = loan.LoanApis.RateLocks;
                var rateLocks = await rateLockApi.GetRateLocksAsync();
                Assert.IsNotNull(rateLocks);
                Assert.AreEqual(0, rateLocks.Count);
                var rateLockRequest = new RateLockRequest()
                {
                    LockRequest = new LockRequest()
                    {
                        LockDate = DateTime.Today,
                        LockNumberOfDays = 15
                    }
                };
                await rateLockApi.SubmitRateLockRequestAsync(rateLockRequest, true);
                var requestId = rateLockRequest.Id;
                Assert.IsFalse(string.IsNullOrEmpty(requestId));
                Assert.AreEqual(LockStatus.Requested, rateLockRequest.LockStatus);
                await Task.Delay(1000);
                rateLocks = await rateLockApi.GetRateLocksAsync();
                Assert.IsNotNull(rateLocks);
                Assert.AreEqual(1, rateLocks.Count);
                Assert.AreEqual(rateLockRequest.LockRequest.LockNumberOfDays, rateLocks[0].LockRequest.LockNumberOfDays);
                Assert.AreEqual(rateLockRequest.LockRequest.LockExpirationDate, rateLocks[0].LockRequest.LockExpirationDate);
                Assert.AreEqual(rateLockRequest.RequestedBy.EntityId, rateLocks[0].RequestedBy.EntityId);
                
                var retrievedRateLock = await rateLockApi.GetRateLockAsync(requestId, LockView.Detailed);
                Assert.IsNotNull(retrievedRateLock);
                Assert.AreEqual(rateLockRequest.LockRequest.LockNumberOfDays, retrievedRateLock.LockRequest.LockNumberOfDays);
                Assert.AreEqual(rateLockRequest.LockRequest.LockExpirationDate, retrievedRateLock.LockRequest.LockExpirationDate);
                Assert.AreEqual(rateLockRequest.RequestedBy.EntityId, retrievedRateLock.RequestedBy.EntityId);

                //rateLockRequest.LockRequest.BaseRate = 4;
                //rateLockRequest.LockRequest.BasePrice = 101.85m;
                //await rateLockApi.UpdateRateLockRequestAsync(rateLockRequest);
                //await Task.Delay(1000);

                //retrievedRateLock = await rateLockApi.GetRateLockAsync(requestId, LockView.Detailed);
                //Assert.IsNotNull(retrievedRateLock);
                //Assert.AreEqual(4, rateLockRequest.LockRequest.BaseRate);
                //Assert.AreEqual(101.85m, rateLockRequest.LockRequest.BasePrice);
                //Assert.AreEqual(4, retrievedRateLock.LockRequest.BaseRate);
                //Assert.AreEqual(101.85m, retrievedRateLock.LockRequest.BasePrice);

                //var cancelledRateLock = await rateLockApi.CancelRateLockRequestAsync(requestId, true);
                //Assert.IsNotNull(cancelledRateLock);
                //Assert.AreEqual(LockStatus.Cancelled, cancelledRateLock.LockStatus);
                //await Task.Delay(1000);
                //retrievedRateLock = await rateLockApi.GetRateLockAsync(requestId, LockView.Detailed);
                //Assert.IsNotNull(retrievedRateLock);
                //Assert.AreEqual(LockStatus.Cancelled, retrievedRateLock.LockStatus);

                await rateLockApi.ConfirmRateLockRequestAsync(retrievedRateLock, true);
                Assert.IsNotNull(retrievedRateLock);
                Assert.AreEqual(LockStatus.Locked, retrievedRateLock.LockStatus);
                await Task.Delay(1000);
                retrievedRateLock = await rateLockApi.GetRateLockAsync(requestId, LockView.Detailed);
                Assert.IsNotNull(retrievedRateLock);
                Assert.AreEqual(LockStatus.Locked, retrievedRateLock.LockStatus);

                var deniedRateLock = await rateLockApi.DenyRateLockRequestAsync(requestId, true);
                Assert.IsNotNull(deniedRateLock);
                Assert.AreEqual(LockStatus.Denied, deniedRateLock.LockStatus);
                await Task.Delay(1000);
                retrievedRateLock = await rateLockApi.GetRateLockAsync(requestId, LockView.Detailed);
                Assert.IsNotNull(retrievedRateLock);
                Assert.AreEqual(LockStatus.Denied, retrievedRateLock.LockStatus);

            }
            finally
            {
                try
                {
                    await client.Loans.DeleteLoanAsync(loanId);
                }
                catch
                {
                }
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task LoanGetLockSnapshot()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);
            try
            {
                await Task.Delay(1000);
                var rateLockApi = loan.LoanApis.RateLocks;
                var rateLocks = await rateLockApi.GetRateLocksAsync();
                Assert.IsNotNull(rateLocks);
                Assert.AreEqual(0, rateLocks.Count);
                var rateLockRequest = new RateLockRequest()
                {
                    LockRequest = new LockRequest()
                    {
                        LockDate = DateTime.Today,
                        LockNumberOfDays = 15
                    }
                };
                await rateLockApi.SubmitRateLockRequestAsync(rateLockRequest, true);
                var requestId = rateLockRequest.Id;
                Assert.IsFalse(string.IsNullOrEmpty(requestId));

                var lockSnapshot = await rateLockApi.GetRateLockSnapshotAsync(requestId);
                Assert.IsNotNull(lockSnapshot);
                Assert.IsTrue(lockSnapshot.ContainsKey("4209"));
                Assert.AreEqual(RequestStatus.NotLocked, lockSnapshot["4209"]);
            }
            finally
            {
                try
                {
                    await client.Loans.DeleteLoanAsync(loanId);
                }
                catch
                {
                }
            }
        }

    }
}