using System.Linq;
using System.Threading.Tasks;
using EncompassRest.Company.Users.Rights;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class UserTests : TestBaseClass
    {
        [TestMethod]
        public async Task User_NoExtensionData()
        {
            var client = await GetTestClientAsync();
            var users = await client.Company.Users.GetUsersAsync();
            Assert.IsTrue(users.Count > 0);
            foreach (var user in users)
            {
                Assert.IsNotNull(user.Client);
                Assert.IsNotNull(user.UserApis);
                AssertNoExtensionData(user, "User", user.Id);
            }
        }

        [TestMethod]
        public async Task UserRights_NoExtensionData()
        {
            var client = await GetTestClientAsync();
            var users = await client.Company.Users.GetUsersAsync();
            Assert.IsTrue(users.Count > 0);
            foreach (var user in users)
            {
                if (user.Id.All(c => char.IsLetter(c)))
                {
                    var effectiveRights = await user.UserApis.Rights.GetRightsAsync(UserRightsType.Effective);
                    AssertNoExtensionData(effectiveRights, "EffectiveRights", user.Id);

                    var assignedRights = await user.UserApis.Rights.GetRightsAsync(UserRightsType.Assigned);
                    AssertNoExtensionData(assignedRights, "AssignedRights", user.Id);
                }
            }
        }

        [TestMethod]
        public async Task UserGroups_NoExtensionData()
        {
            var client = await GetTestClientAsync();
            var users = await client.Company.Users.GetUsersAsync();
            Assert.IsTrue(users.Count > 0);
            foreach (var user in users)
            {
                if (user.Id.All(c => char.IsLetter(c)))
                {
                    var groups = await user.UserApis.Groups.GetGroupsAsync();
                    AssertNoExtensionData(groups, "UserGroup", user.Id);
                }
            }
        }

        [TestMethod]
        public async Task UserCompensation_NoExtensionData()
        {
            var client = await GetTestClientAsync();
            var users = await client.Company.Users.GetUsersAsync();
            Assert.IsTrue(users.Count > 0);
            foreach (var user in users)
            {
                if (user.Id.All(c => char.IsLetter(c)))
                {
                    var compensation = await user.UserApis.Compensation.GetCompensationPlansAsync();
                    AssertNoExtensionData(compensation, "Compensation", user.Id);
                }
            }
        }

        [TestMethod]
        public async Task UserLicenses_NoExtensionData()
        {
            var client = await GetTestClientAsync();
            var users = await client.Company.Users.GetUsersAsync();
            Assert.IsTrue(users.Count > 0);
            foreach (var user in users)
            {
                if (user.Id.All(c => char.IsLetter(c)))
                {
                    var licenses = await user.UserApis.Licenses.GetLicenseDetailsAsync();
                    AssertNoExtensionData(licenses, "License", user.Id);
                }
            }
        }
    }
}