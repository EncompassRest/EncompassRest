using System.Linq;
using System.Threading.Tasks;
using EncompassApi.Company.Users.Rights;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassApi.Tests
{
    [TestClass]
    public class UserTests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task User_NoExtensionData()
        {
            var client = await GetTestClientAsync();
            var users = await client.Company.Users.GetUsersAsync();
            Assert.IsTrue(users.Count > 0);
            foreach (var user in users)
            {
                Assert.IsNotNull(user.Client);
                Assert.IsNotNull(user.UserApis);
            }
            AssertNoExtensionData(users, "Users", null, true);
        }

        [TestMethod]
        [ApiTest]
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
                    AssertNoExtensionData(effectiveRights, "EffectiveRights", user.Id, true);

                    var assignedRights = await user.UserApis.Rights.GetRightsAsync(UserRightsType.Assigned);
                    AssertNoExtensionData(assignedRights, "AssignedRights", user.Id, true);
                }
            }
        }

        [TestMethod]
        [ApiTest]
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
                    AssertNoExtensionData(groups, "UserGroup", user.Id, true);
                }
            }
        }

        [TestMethod]
        [ApiTest]
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
                    AssertNoExtensionData(compensation, "Compensation", user.Id, true);
                }
            }
        }

        [TestMethod]
        [ApiTest]
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
                    AssertNoExtensionData(licenses, "License", user.Id, true);
                }
            }
        }
    }
}