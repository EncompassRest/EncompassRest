using System.Linq;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Loans.Enums;
using EncompassRest.Loans.Milestones;
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

            var loanId = await client.Loans.CreateLoanAsync(new Loan(client));
            try
            {
                var loanApis = client.Loans.GetLoanApis(loanId);
                var associates = await loanApis.Associates.GetAssociatesAsync();
                foreach (var associate in associates)
                {
                    AssertNoExtensionData(associate, "Associate", associate.Id, true);
                }
                var milestones = await loanApis.Milestones.GetMilestonesAsync();
                foreach (var milestone in milestones)
                {
                    AssertNoExtensionData(milestone, "Milestone", milestone.MilestoneName, true);
                    var retrievedMilestone = await loanApis.Milestones.GetMilestoneAsync(milestone.Id);
                    Assert.AreEqual(milestone.ToString(), retrievedMilestone.ToString());
                }
                var milestoneFreeRoles = await loanApis.MilestoneFreeRoles.GetMilestoneFreeRolesAsync();
                foreach (var milestoneFreeRole in milestoneFreeRoles)
                {
                    AssertNoExtensionData(milestoneFreeRole, "MilestoneFreeRole", milestoneFreeRole.Id, true);
                    var retrievedMilestoneFreeRole = await loanApis.MilestoneFreeRoles.GetMilestoneFreeRoleAsync(milestoneFreeRole.Id);
                    Assert.AreEqual(milestoneFreeRole.ToString(), retrievedMilestoneFreeRole.ToString());
                }
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

        [TestMethod]
        public async Task LoanMilestonesFinish()
        {
            var client = await GetTestClientAsync();

            if (client.AccessToken.Token == "Token")
            {
                var loanId = await client.Loans.CreateLoanAsync(new Loan(client));
                try
                {
                    var loanApis = client.Loans.GetLoanApis(loanId);
                    var milestonesApi = loanApis.Milestones;
                    var milestones = await milestonesApi.GetMilestonesAsync();
                    var milestone = milestones.First(ms => ms.DoneIndicator != true);

                    // Assign user to milestones
                    var userId = "officer";
                    await loanApis.Associates.AssignAssociateAsync(milestone.Id, new LoanAssociate(userId, LoanAssociateType.User));
                    milestones = await milestonesApi.GetMilestonesAsync();
                    milestone = milestones.First(ms => ms.Id == milestone.Id);
                    Assert.AreEqual(milestone.LoanAssociate.Id, userId);

                    userId = "opener";
                    var nextMilestone = milestones.Where(ms => ms.DoneIndicator != true).Skip(1).First();
                    await loanApis.Associates.AssignAssociateAsync(nextMilestone.Id, new LoanAssociate(userId, LoanAssociateType.User));
                    milestones = await milestonesApi.GetMilestonesAsync();
                    nextMilestone = milestones.First(ms => ms.Id == nextMilestone.Id);
                    Assert.AreEqual(nextMilestone.LoanAssociate.Id, userId);

                    await milestonesApi.UpdateMilestoneAsync(milestone, MilestoneAction.Finish);
                    milestones = await milestonesApi.GetMilestonesAsync();
                    milestone = milestones.First(ms => ms.Id == milestone.Id);
                    Assert.IsTrue(milestone.DoneIndicator == true);

                    await milestonesApi.UpdateMilestoneAsync(milestone, MilestoneAction.Unfinish);
                    milestones = await milestonesApi.GetMilestonesAsync();
                    milestone = milestones.First(ms => ms.Id == milestone.Id);
                    Assert.IsFalse(milestone.DoneIndicator == true);

                    // Test unassigning user
#pragma warning disable CS0618 // Type or member is obsolete
                    await loanApis.Associates.UnassignAssociateAsync(nextMilestone.Id);
#pragma warning restore CS0618 // Type or member is obsolete
                    milestones = await milestonesApi.GetMilestonesAsync();
                    nextMilestone = milestones.First(ms => ms.Id == nextMilestone.Id);
                    Assert.IsNull(nextMilestone.LoanAssociate.Id);
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

        [TestMethod]
        public async Task LoanMilestoneComments()
        {
            var client = await GetTestClientAsync();

            var loanId = await client.Loans.CreateLoanAsync(new Loan(client));

            try
            {
                var loanApis = client.Loans.GetLoanApis(loanId);

                var milestone = (await loanApis.Milestones.GetMilestonesAsync()).ElementAt(1);

                const string comments = "This is a test comment";
                milestone.Comments = comments;
                await loanApis.Milestones.UpdateMilestoneAsync(milestone);
                var retrievedMilestone = await loanApis.Milestones.GetMilestoneAsync(milestone.Id);
                Assert.AreEqual(comments, retrievedMilestone.Comments);
                Assert.AreEqual(milestone.ToString(), retrievedMilestone.ToString());
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