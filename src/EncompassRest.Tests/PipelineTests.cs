using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncompassRest.Filters;
using EncompassRest.LoanPipeline;
using EncompassRest.Schema;
using EncompassRest.Utilities;
using EnumsNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class PipelineTests : TestBaseClass
    {
        [TestMethod]
        public async Task Pipeline_GetCanonicalNames()
        {
            var client = await GetTestClientAsync();
            var canonicalNames = await client.Pipeline.GetCanonicalNamesAsync();

            var categories = new HashSet<string>(canonicalNames.PipelineLoanReportFieldDefs.Select(p => p.Category.Value));
            categories.Remove(null);
            var existingCategories = new HashSet<string>(Enums.GetMembers<PipelineFieldDefinitionCategory>().Select((EnumMember<PipelineFieldDefinitionCategory> m) => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)));
            var newCategories = categories.Except(existingCategories).ToList();
            Assert.AreEqual(0, newCategories.Count);

            var fieldFormats = new HashSet<LoanFieldFormat>(canonicalNames.PipelineLoanReportFieldDefs.Select(p => p.FieldDefinition.Format));
            var existingFieldFormats = new HashSet<LoanFieldFormat>(Enums.GetValues<LoanFieldFormat>());
            var newFieldFormats = fieldFormats.Except(existingFieldFormats).ToList();
            Assert.AreEqual(0, newFieldFormats.Count);

            var canonicalFieldNames = new HashSet<string>(canonicalNames.PipelineLoanReportFieldDefs.Select(p => p.CriterionFieldName).Where(n => n?.StartsWith("Loan.") == true));
            var existingCanonicalFieldNames = new HashSet<string>(Enums.GetValues<CanonicalLoanField>().Select(v => v.GetCanonicalName()));
            var newCanonicalFieldNames = canonicalFieldNames.Except(existingCanonicalFieldNames, StringComparer.OrdinalIgnoreCase).ToList();
            Assert.AreEqual(0, newCanonicalFieldNames.Count);

            Assert.AreEqual(0, canonicalNames.ExtensionData.Count);

            foreach (var pipelineFieldDef in canonicalNames.PipelineLoanReportFieldDefs)
            {
                Assert.AreEqual(0, pipelineFieldDef.ExtensionData.Count);
                
                ValidateNoExtensionData(pipelineFieldDef.FieldDefinition);
            }
        }

        private void ValidateNoExtensionData(FieldDefinition fieldDefinition)
        {
            Assert.AreEqual(0, fieldDefinition.ExtensionData.Count);

            var fieldOptions = fieldDefinition.FieldOptions;
            if (fieldOptions != null)
            {
                Assert.AreEqual(0, fieldOptions.ExtensionData.Count);

                foreach (var option in fieldOptions.Options)
                {
                    Assert.AreEqual(0, option.ExtensionData.Count);
                }
            }

            var parentField = fieldDefinition.ParentField;
            if (parentField != null)
            {
                ValidateNoExtensionData(parentField);
            }
        }

        [TestMethod]
        public void ViewPipelineParameters_Serialization()
        {
            var parameters = new PipelineParameters(new StringFieldFilter(CanonicalLoanField.LoanFolder, StringFieldMatchType.Exact, "Active Loans"), new[] { "Fields.364", "Fields.4002" }, new[] { new FieldSort("Fields.4002", SortOrder.Ascending) });
            Assert.AreEqual(@"{""filter"":{""matchType"":""exact"",""value"":""Active Loans"",""canonicalName"":""Loan.LoanFolder""},""fields"":[""Fields.364"",""Fields.4002""],""sortOrder"":[{""canonicalName"":""Fields.4002"",""order"":""asc""}]}", parameters.ToJson());
        }

        [TestMethod]
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
        public async Task Pipeline_ViewPipeline_NotEmptyFieldFilter()
        {
            var client = await GetTestClientAsync();
            var fields = new[] { CanonicalLoanField.LoanAmount.GetCanonicalName() };
            var pipelineData = await client.Pipeline.ViewPipelineAsync(new PipelineParameters(new NotEmptyFieldFilter(CanonicalLoanField.LoanAmount), fields));
            Assert.IsNotNull(pipelineData);
            Assert.IsTrue(pipelineData.Count > 0);
            foreach (var item in pipelineData)
            {
                ValidateItem(item, fields);
                Assert.IsFalse(string.IsNullOrEmpty(item.Fields["Loan.LoanAmount"]));
            }
        }

        [TestMethod]
        public async Task Pipeline_ViewPipeline_EmptyFieldFilter()
        {
            var client = await GetTestClientAsync();
            var fields = new[] { CanonicalLoanField.LoanAmount.GetCanonicalName() };
            var pipelineData = await client.Pipeline.ViewPipelineAsync(new PipelineParameters(new EmptyFieldFilter(CanonicalLoanField.LoanAmount), fields));
            Assert.IsNotNull(pipelineData);
            Assert.IsTrue(pipelineData.Count > 0);
            foreach (var item in pipelineData)
            {
                ValidateItem(item, fields);
                Assert.IsTrue(string.IsNullOrEmpty(item.Fields["Loan.LoanAmount"]));
            }
        }

        [TestMethod]
        public async Task Pipeline_CreateCursor_ReturnsNullForNoResults()
        {
            var client = await GetTestClientAsync();
            var cursor = await client.Pipeline.CreateCursorAsync(new PipelineParameters(new NumericFieldFilter(CanonicalLoanField.LoanAmount, OrdinalFieldMatchType.LessThan, 0M)));
            Assert.IsNull(cursor);
        }

        [TestMethod]
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
    }
}