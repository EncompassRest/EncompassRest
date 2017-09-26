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
            var parameters = new PipelineParameters(new StringFieldFilter(CanonicalField.LoanFolder, StringFieldMatchType.Exact, "Active Loans"), new[] { "Fields.364", "Fields.4002" });
            Assert.AreEqual(@"{""filter"":{""matchType"":""exact"",""value"":""Active Loans"",""canonicalName"":""Loan.LoanFolder""},""fields"":[""Fields.364"",""Fields.4002""]}", parameters.ToJson());
        }

        [TestMethod]
        public async Task Pipeline_ViewPipeline()
        {
            using (var client = GetTestClient())
            {
                var pipelineData = await client.Pipeline.ViewPipelineAsync(new PipelineParameters(new NumericFieldFilter(CanonicalField.LoanAmount, OrdinalFieldMatchType.GreaterThanOrEquals, 0M)));
                Assert.IsNotNull(pipelineData);
                Assert.IsTrue(pipelineData.Count > 0);
                foreach (var item in pipelineData)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(item.LoanGuid));
                    Assert.IsNull(item.Fields);
                }
            }
        }

        [TestMethod]
        public async Task Pipeline_CreateCursor_ReturnsNullForNoResults()
        {
            using (var client = GetTestClient())
            {
                var cursor = await client.Pipeline.CreateCursorAsync(new PipelineParameters(new NumericFieldFilter(CanonicalField.LoanAmount, OrdinalFieldMatchType.LessThan, 0M)));
                Assert.IsNull(cursor);
            }
        }

        [TestMethod]
        public async Task Pipeline_Cursor_GetItem()
        {
            using (var client = GetTestClient())
            {
                var cursor = await client.Pipeline.CreateCursorAsync(new PipelineParameters(new NumericFieldFilter(CanonicalField.LoanAmount, OrdinalFieldMatchType.GreaterThanOrEquals, 0M)));
                Assert.IsNotNull(cursor);
                CollectionAssert.AreEqual(new string[0], cursor.Fields.ToList());
                Assert.IsFalse(string.IsNullOrEmpty(cursor.CursorId));
                Assert.IsTrue(cursor.Count > 0);
                for (var i = 0; i < cursor.Count; ++i)
                {
                    var item = await cursor.GetItemAsync(i);
                    Assert.IsFalse(string.IsNullOrEmpty(item.LoanGuid));
                    Assert.IsNull(item.Fields);
                }
                await Assert.ThrowsExceptionAsync<ArgumentOutOfRangeException>(() => cursor.GetItemAsync(-1));
                await Assert.ThrowsExceptionAsync<ArgumentOutOfRangeException>(() => cursor.GetItemAsync(cursor.Count));
            }
        }

        [TestMethod]
        public async Task Pipeline_Cursor_GetItems()
        {
            using (var client = GetTestClient())
            {
                var fields = new[] { "Fields.364", "Fields.4002" };
                var cursor = await client.Pipeline.CreateCursorAsync(new PipelineParameters(new NumericFieldFilter(CanonicalField.LoanAmount, OrdinalFieldMatchType.GreaterThanOrEquals, 0M), fields));
                Assert.IsNotNull(cursor);
                CollectionAssert.AreEqual(fields, cursor.Fields.ToList());
                Assert.IsFalse(string.IsNullOrEmpty(cursor.CursorId));
                Assert.IsTrue(cursor.Count > 0);
                var items = await cursor.GetItemsAsync(0, cursor.Count);
                foreach (var item in items)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(item.LoanGuid));
                    Assert.IsNotNull(item.Fields);
                    Assert.AreEqual(2, item.Fields.Count);
                    Assert.IsTrue(item.Fields.ContainsKey(fields[0]));
                    Assert.IsTrue(item.Fields.ContainsKey(fields[1]));
                }
                Assert.AreEqual(cursor.Count, items.Count());
                await Assert.ThrowsExceptionAsync<ArgumentOutOfRangeException>(() => cursor.GetItemsAsync(-1, 1));
                await Assert.ThrowsExceptionAsync<ArgumentOutOfRangeException>(() => cursor.GetItemsAsync(cursor.Count, 1));
                await Assert.ThrowsExceptionAsync<ArgumentOutOfRangeException>(() => cursor.GetItemsAsync(0, cursor.Count + 1));
            }
        }
    }
}