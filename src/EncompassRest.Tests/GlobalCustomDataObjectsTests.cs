using System;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.CustomDataObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class GlobalCustomDataObjectsTests : TestBaseClass
    {
        [TestMethod]
        public async Task CreateGetAppendAndDeleteCustomDataObject()
        {
            var client = await GetTestClientAsync();
            var existingCdos = await client.GlobalCustomDataObjects.GetCustomDataObjectsAsync();
            const string firstText = "Hello World!";
            var cdo = new CustomDataObject(Guid.NewGuid().ToString().Substring(0, 8) + ".txt", Encoding.UTF8.GetBytes(firstText));
            await client.GlobalCustomDataObjects.CreateOrReplaceCustomDataObjectAsync(cdo);
            await Task.Delay(10000);
            var cdo2 = await client.GlobalCustomDataObjects.GetCustomDataObjectAsync(cdo.Name);
            Assert.AreEqual(firstText, Encoding.UTF8.GetString(cdo.DataObject));
            await Task.Delay(10000);
            const string secondText = "Goodbye World!";
            cdo2.DataObject = Encoding.UTF8.GetBytes(secondText);
            await client.GlobalCustomDataObjects.AppendToCustomDataObjectAsync(cdo2, true);
            Assert.AreEqual($"{firstText}{secondText}", Encoding.UTF8.GetString(cdo2.DataObject));
            Assert.IsTrue(await client.GlobalCustomDataObjects.DeleteCustomDataObjectAsync(cdo.Name));
        }
    }
}