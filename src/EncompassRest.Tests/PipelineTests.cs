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
        [ApiTest]
        public async Task Pipeline_GetCanonicalNames()
        {
            var client = await GetTestClientAsync();
            var canonicalNames = await client.Pipeline.GetCanonicalNamesAsync();

            AssertNoExtensionData(canonicalNames, "CanonicalNames", "CanonicalNames", true);
        }

        [TestMethod]
        public void ViewPipelineParameters_Serialization()
        {
            var parameters = new PipelineParameters(new StringFieldFilter(CanonicalLoanField.LoanFolder, StringFieldMatchType.Exact, "Active Loans"), new[] { "Fields.364", "Fields.4002" }, new[] { new FieldSort("Fields.4002", SortOrder.Ascending) });
            Assert.AreEqual(@"{""filter"":{""matchType"":""exact"",""value"":""Active Loans"",""canonicalName"":""Loan.LoanFolder""},""fields"":[""Fields.364"",""Fields.4002""],""sortOrder"":[{""canonicalName"":""Fields.4002"",""order"":""asc""}]}", parameters.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        [ApiTest]
        public async Task Pipeline_ViewPipeline()
        {
            var client = await GetTestClientAsync();
            var pipelineData = await client.Pipeline.ViewPipelineAsync(new PipelineParameters(new NumericFieldFilter(CanonicalLoanField.LoanAmount, OrdinalFieldMatchType.GreaterThanOrEquals, 0M)));
            Assert.IsNotNull(pipelineData);
            Assert.IsTrue(pipelineData.Count > 0);
            foreach (var item in pipelineData)
            {
                ValidateItem(item, null);
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Pipeline_ViewPipeline_NotEmptyFieldFilter_Numeric()
        {
            var client = await GetTestClientAsync();
            var field = CanonicalLoanField.LoanAmount.GetCanonicalName();
            var fields = new[] { field };
            var pipelineData = await client.Pipeline.ViewPipelineAsync(new PipelineParameters(new NotEmptyFieldFilter(field), fields));
            Assert.IsNotNull(pipelineData);
            Assert.IsTrue(pipelineData.Count > 0);
            foreach (var item in pipelineData)
            {
                ValidateItem(item, fields);
                Assert.IsFalse(string.IsNullOrEmpty(item.Fields[field]));
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Pipeline_ViewPipeline_EmptyFieldFilter_Numeric()
        {
            var client = await GetTestClientAsync();
            var field = CanonicalLoanField.LoanAmount.GetCanonicalName();
            var fields = new[] { field };
            var pipelineData = await client.Pipeline.ViewPipelineAsync(new PipelineParameters(new EmptyFieldFilter(field), fields));
            Assert.IsNotNull(pipelineData);
            Assert.IsTrue(pipelineData.Count > 0);
            foreach (var item in pipelineData)
            {
                ValidateItem(item, fields);
                Assert.IsTrue(string.IsNullOrEmpty(item.Fields[field]));
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Pipeline_ViewPipeline_NotEmptyFieldFilter_Date()
        {
            var client = await GetTestClientAsync();
            var field = "Fields.762";
            var fields = new[] { field };
            var pipelineData = await client.Pipeline.ViewPipelineAsync(new PipelineParameters(new NotEmptyFieldFilter(field), fields));
            Assert.IsNotNull(pipelineData);
            Assert.IsTrue(pipelineData.Count > 0);
            foreach (var item in pipelineData)
            {
                ValidateItem(item, fields);
                Assert.IsFalse(string.IsNullOrEmpty(item.Fields[field]));
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Pipeline_ViewPipeline_EmptyFieldFilter_Date()
        {
            var client = await GetTestClientAsync();
            var field = "Fields.762";
            var fields = new[] { field };
            var pipelineData = await client.Pipeline.ViewPipelineAsync(new PipelineParameters(new EmptyFieldFilter(field), fields));
            Assert.IsNotNull(pipelineData);
            Assert.IsTrue(pipelineData.Count > 0);
            foreach (var item in pipelineData)
            {
                ValidateItem(item, fields);
                Assert.IsTrue(string.IsNullOrEmpty(item.Fields[field]));
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Pipeline_CreateCursor_EmptyFieldFilter_Date()
        {
            var client = await GetTestClientAsync();
            var field = "Fields.762";
            var fields = new[] { field };
            var cursor = await client.Pipeline.CreateCursorAsync(new PipelineParameters(new EmptyFieldFilter(field), fields));
            var pipelineData = await cursor.GetItemsAsync(1, 10);
            Assert.IsNotNull(pipelineData);
            Assert.IsTrue(pipelineData.Count > 0);
            foreach (var item in pipelineData)
            {
                ValidateItem(item, fields);
                Assert.IsTrue(string.IsNullOrEmpty(item.Fields[field]));
            }
        }

        // Currently fails
        [TestMethod]
        [ApiTest]
        public async Task Pipeline_ViewPipeline_NotEmptyFieldFilter_String()
        {
            try
            {
                var client = await GetTestClientAsync();
                var field = CanonicalLoanField.CoBorrowerLastName.GetCanonicalName();
                var fields = new[] { field };
                var pipelineData = await client.Pipeline.ViewPipelineAsync(new PipelineParameters(new NotEmptyFieldFilter(field), fields));
                Assert.IsNotNull(pipelineData);
                Assert.IsTrue(pipelineData.Count > 0);
                foreach (var item in pipelineData)
                {
                    ValidateItem(item, fields);
                    Assert.IsFalse(string.IsNullOrEmpty(item.Fields[field]));
                }
                throw new Exception("NotEmptyFieldFilter now supports string fields");
            }
            catch (AssertFailedException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        // Currently fails
        [TestMethod]
        [ApiTest]
        public async Task Pipeline_ViewPipeline_EmptyFieldFilter_String()
        {
            try
            {
                var client = await GetTestClientAsync();
                var field = CanonicalLoanField.CoBorrowerLastName.GetCanonicalName();
                var fields = new[] { field };
                var pipelineData = await client.Pipeline.ViewPipelineAsync(new PipelineParameters(new EmptyFieldFilter(field), fields));
                Assert.IsNotNull(pipelineData);
                Assert.IsTrue(pipelineData.Count > 0);
                foreach (var item in pipelineData)
                {
                    ValidateItem(item, fields);
                    Assert.IsTrue(string.IsNullOrEmpty(item.Fields[field]));
                }
                throw new Exception("EmptyFieldFilter now supports string fields");
            }
            catch (AssertFailedException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Pipeline_CreateCursor_ReturnsNonNullForNoResults()
        {
            var client = await GetTestClientAsync();
            var cursor = await client.Pipeline.CreateCursorAsync(new PipelineParameters(new NumericFieldFilter(CanonicalLoanField.LoanAmount, OrdinalFieldMatchType.LessThan, 0M)));
            Assert.IsNotNull(cursor);
            Assert.AreEqual(0, cursor.Count);
            Assert.IsNull(cursor.CursorId);
        }

        [TestMethod]
        [ApiTest]
        public async Task Pipeline_Cursor_GetItem()
        {
            var client = await GetTestClientAsync();
            var cursor = await client.Pipeline.CreateCursorAsync(new PipelineParameters(new NumericFieldFilter(CanonicalLoanField.LoanAmount, OrdinalFieldMatchType.GreaterThanOrEquals, 0M)));
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
        [ApiTest]
        public async Task Pipeline_Cursor_GetItems()
        {
            var client = await GetTestClientAsync();
            var fields = new[] { "Fields.364", "Fields.4002" };
            var cursor = await client.Pipeline.CreateCursorAsync(new PipelineParameters(new NumericFieldFilter(CanonicalLoanField.LoanAmount, OrdinalFieldMatchType.GreaterThanOrEquals, 0M), fields));
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
            items = await cursor.GetItemsAsync(cursor.Count - 1, 1);
            ValidateItem(items[0], fields);
            items = await cursor.GetItemsAsync(cursor.Count - 1, int.MaxValue); // Does not throw ArgumentOutOfRangeException
            Assert.AreEqual(1, items.Count);
            ValidateItem(items[0], fields);
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

        [TestMethod]
        [ApiTest]
        public async Task Pipeline_Cursor_IgnoreInvalidFields()
        {
            var client = await GetTestClientAsync();
            var pipelineParameters = new PipelineParameters(new NumericFieldFilter(CanonicalLoanField.LoanAmount, OrdinalFieldMatchType.GreaterThanOrEquals, 0M), new[] { "InvalidFieldName" });
            await Assert.ThrowsExceptionAsync<EncompassRestException>(() => client.Pipeline.CreateCursorAsync(pipelineParameters, false));
            var cursor = await client.Pipeline.CreateCursorAsync(pipelineParameters, true);
            Assert.IsTrue(cursor.Count > 0);
            var item = await cursor.GetItemAsync(0);
        }

        [TestMethod]
        [ApiTest]
        public async Task Pipeline_ViewPipeline_IgnoreInvalidFields()
        {
            var client = await GetTestClientAsync();
            var pipelineParameters = new PipelineParameters(new NumericFieldFilter(CanonicalLoanField.LoanAmount, OrdinalFieldMatchType.GreaterThanOrEquals, 0M), new[] { "InvalidFieldName" });
            await Assert.ThrowsExceptionAsync<EncompassRestException>(() => client.Pipeline.ViewPipelineAsync(pipelineParameters, 1, false));
            var pipelineData = await client.Pipeline.ViewPipelineAsync(pipelineParameters, 1, true);
        }
    }
}