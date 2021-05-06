using System.Threading.Tasks;
using EncompassRest.Organizations.v1;
using EnumsNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class OrganizationTests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task Organization_NoExtensionData()
        {
            var client = await GetTestClientAsync();
            foreach (var view in Enums.GetValues<OrganizationView>())
            {
                var orgs = await client.Organizations.GetOrganizationsAsync(new OrganizationsRetrievalOptions { View = view });
                Assert.IsTrue(orgs.Count > 0);
                foreach (var org in orgs)
                {
                    AssertNoExtensionData(org, "Organization", $"{org.Id} {view}", true);

                    var retrievedOrg = await client.Organizations.GetOrganizationAsync(org.Id, view);
                    AssertNoExtensionData(retrievedOrg, "Organization", $"{org.Id} {view}", true);
                }
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task RootOrganization_NoExtensionData()
        {
            var client = await GetTestClientAsync();
            foreach (var view in Enums.GetValues<OrganizationView>())
            {
                var org = await client.Organizations.GetRootOrganizationAsync(view);
                AssertNoExtensionData(org, "Organization", $"{org.Id} {view}", true);
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task OrganizationChildren_NoExtensionData()
        {
            var client = await GetTestClientAsync();
            var orgs = await client.Organizations.GetOrganizationsAsync();
            Assert.IsTrue(orgs.Count > 0);
            foreach (var org in orgs)
            {
                var children = await client.Organizations.GetOrganizationChildrenAsync(org.Id, new OrganizationChildrenRetrievalOptions { Recursive = true });
                AssertNoExtensionData(children, "OrganizationChildren", org.Id, true);

                children = await client.Organizations.GetOrganizationChildrenAsync(org.Id, new OrganizationChildrenRetrievalOptions { Recursive = false });
                AssertNoExtensionData(children, "OrganizationChildren", org.Id, true);
            }
        }
    }
}