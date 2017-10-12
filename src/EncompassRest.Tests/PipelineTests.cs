using System;
using System.Linq;
using System.Threading.Tasks;
using EncompassRest.Filters;
using EncompassRest.LoanPipeline;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class PipelineTests : TestBaseClass
    {
        [TestMethod]
        public void ViewPipelineParameters_Serialization()
        {
            var parameters = new PipelineParameters(new StringFieldFilter(CanonicalField.LoanFolder, StringFieldMatchType.Exact, "Active Loans"), new[] { "Fields.364", "Fields.4002" }, new[] { new FieldSort("Fields.4002", SortOrder.Ascending) });
            Assert.AreEqual(@"{""filter"":{""matchType"":""exact"",""value"":""Active Loans"",""canonicalName"":""Loan.LoanFolder""},""fields"":[""Fields.364"",""Fields.4002""],""sortOrder"":[{""canonicalName"":""Fields.4002"",""order"":""asc""}]}", parameters.ToJson());
        }

        [TestMethod]
        public async Task Pipeline_ViewPipeline()
        {
            var client = await GetTestClientAsync();
            var pipelineData = await client.Pipeline.ViewPipelineAsync(new PipelineParameters(new NumericFieldFilter(CanonicalField.LoanAmount, OrdinalFieldMatchType.GreaterThanOrEquals, 0M)));
            Assert.IsNotNull(pipelineData);
            Assert.IsTrue(pipelineData.Count > 0);
            foreach (var item in pipelineData)
            {
                ValidateItem(item, null);
            }
        }

        [TestMethod]
        public async Task Pipeline_CreateCursor_ReturnsNullForNoResults()
        {
            var client = await GetTestClientAsync();
            var cursor = await client.Pipeline.CreateCursorAsync(new PipelineParameters(new NumericFieldFilter(CanonicalField.LoanAmount, OrdinalFieldMatchType.LessThan, 0M)));
            Assert.IsNull(cursor);
        }

        [TestMethod]
        public async Task Pipeline_Cursor_GetItem()
        {
            var client = await GetTestClientAsync();
            var cursor = await client.Pipeline.CreateCursorAsync(new PipelineParameters(new NumericFieldFilter(CanonicalField.LoanAmount, OrdinalFieldMatchType.GreaterThanOrEquals, 0M)));
            Assert.IsNotNull(cursor);
            CollectionAssert.AreEqual(new string[0], cursor.Fields.ToList());
            Assert.IsFalse(string.IsNullOrEmpty(cursor.CursorId));
            Assert.IsTrue(cursor.Count > 0);
            for (var i = 0; i < Math.Min(cursor.Count, 50); ++i)
            {
                var item = await cursor.GetItemAsync(i);
                ValidateItem(item, null);
            }
            await Assert.ThrowsExceptionAsync<ArgumentOutOfRangeException>(() => cursor.GetItemAsync(-1));
            await Assert.ThrowsExceptionAsync<ArgumentOutOfRangeException>(() => cursor.GetItemAsync(cursor.Count));
        }

        [TestMethod]
        public async Task Pipeline_Cursor_GetItems()
        {
            var client = await GetTestClientAsync();
            var fields = new[] { "Fields.364", "Fields.4002" };
            var cursor = await client.Pipeline.CreateCursorAsync(new PipelineParameters(new NumericFieldFilter(CanonicalField.LoanAmount, OrdinalFieldMatchType.GreaterThanOrEquals, 0M), fields));
            Assert.IsNotNull(cursor);
            CollectionAssert.AreEqual(fields, cursor.Fields.ToList());
            Assert.IsFalse(string.IsNullOrEmpty(cursor.CursorId));
            Assert.IsTrue(cursor.Count > 0);
            var items = await cursor.GetItemsAsync(0, Math.Min(cursor.Count, 50));
            foreach (var item in items)
            {
                ValidateItem(item, fields);
            }
            Assert.IsTrue(items.Count() <= 50);
            await Assert.ThrowsExceptionAsync<ArgumentOutOfRangeException>(() => cursor.GetItemsAsync(-1, 1));
            await Assert.ThrowsExceptionAsync<ArgumentOutOfRangeException>(() => cursor.GetItemsAsync(cursor.Count, 1));
            var lastItem = (await cursor.GetItemsAsync(cursor.Count - 1, 1))[0];
            ValidateItem(lastItem, fields);
            lastItem = (await cursor.GetItemsAsync(cursor.Count - 1, 2))[0]; // Does not throw ArgumentOutOfRangeException
            ValidateItem(lastItem, fields);
        }

        private void ValidateItem(LoanPipelineData item, string[] fields)
        {
            Assert.IsFalse(string.IsNullOrEmpty(item.LoanGuid));
            if (fields?.Length > 0)
            {
                Assert.IsNotNull(item.Fields);
                Assert.AreEqual(fields.Length, item.Fields.Count);
                foreach (var field in fields)
                {
                    Assert.IsTrue(item.Fields.ContainsKey(field));
                }
            }
            else
            {
                Assert.IsNull(item.Fields);
            }
        }
    }
}