using System.Threading.Tasks;
using EncompassRest.Loans;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class LoanAssociateMilestoneTests : TestBaseClass
    {
        [TestMethod]
        public async Task LoanAssociatesMilestones()
        {
            var client = await GetTestClientAsync();

            var loanId = await client.Loans.CreateLoanAsync(new Loan());
            var loanApis = client.Loans.GetLoanApis(loanId);
            var associates = await loanApis.Associates.GetAssociatesAsync();
            foreach (var associate in associates)
            {
                Assert.AreEqual(0, associate.ExtensionData.Count);
            }
            var milestones = await loanApis.Milestones.GetMilestonesAsync();
            foreach (var milestone in milestones)
            {
                Assert.AreEqual(0, milestone.ExtensionData.Count);
                Assert.AreEqual(0, milestone.LoanAssociate.ExtensionData.Count);
                var retrievedMilestone = await loanApis.Milestones.GetMilestoneAsync(milestone.Id);
                Assert.AreEqual(milestone.ToString(), retrievedMilestone.ToString());
            }
            var milestoneFreeRoles = await loanApis.MilestoneFreeRoles.GetMilestoneFreeRolesAsync();
            foreach (var milestoneFreeRole in milestoneFreeRoles)
            {
                Assert.AreEqual(0, milestoneFreeRole.ExtensionData.Count);
                Assert.AreEqual(0, milestoneFreeRole.LoanAssociate.ExtensionData.Count);
                var retrievedMilestoneFreeRole = await loanApis.MilestoneFreeRoles.GetMilestoneFreeRoleAsync(milestoneFreeRole.Id);
                Assert.AreEqual(milestoneFreeRole.ToString(), retrievedMilestoneFreeRole.ToString());
            }

            await Task.Delay(5000);
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
        }
    }
}