using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncompassApi.CustomDataObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassApi.Tests
{
    [TestClass]
    public class BaseApiClientTests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task BaseApiClient_GetLoanFolders()
        {
            var client = await GetTestClientAsync();
            var loanFolders = await client.BaseApiClient.GetAnonymousTypeAsync("https://api.elliemae.com/encompass/v1/loanFolders", new[] { new { Name = string.Empty } }.ToList());
            Assert.IsTrue(loanFolders.Count > 0);
        }

        [TestMethod]
        [ApiTest]
        public async Task BaseApiClient_CreateGetAppendAndDeleteCustomDataObject()
        {
            var client = await GetTestClientAsync();
            var baseApiClient = client.BaseApiClient;
            var existingCdos = await baseApiClient.GetAsync<List<string>>("https://api.elliemae.com/encompass/v1/company/customObjects");
            const string firstText = "Hello World!";
            var cdo = new CustomDataObject(Guid.NewGuid().ToString().Substring(0, 8) + ".txt", Encoding.UTF8.GetBytes(firstText));
            await baseApiClient.PutAsync($"https://api.elliemae.com/encompass/v1/company/customObjects/{cdo.Name}", cdo);
            await Task.Delay(10000);
            var cdo2 = await baseApiClient.GetAsync<CustomDataObject>($"https://api.elliemae.com/encompass/v1/company/customObjects/{cdo.Name}");
            Assert.AreEqual(firstText, Encoding.UTF8.GetString(cdo.DataObject));
            await Task.Delay(10000);
            const string secondText = "Goodbye World!";
            cdo2.DataObject = Encoding.UTF8.GetBytes(secondText);
            cdo2 = await baseApiClient.PatchAsync<CustomDataObject>($"https://api.elliemae.com/encompass/v1/company/customObjects/{cdo.Name}?view=entity", cdo2);
            Assert.AreEqual($"{firstText}{secondText}", Encoding.UTF8.GetString(cdo2.DataObject));
            await baseApiClient.DeleteAsync($"https://api.elliemae.com/encompass/v1/company/customObjects/{cdo.Name}");
        }
    }
}