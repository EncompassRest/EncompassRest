using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EnumsNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class SchemaTests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task Schema_GetLoanSchema()
        {
            var client = await GetTestClientAsync();
            var loanSchema = await client.Schema.GetLoanSchemaAsync(true);

            var loanEntities = new HashSet<string>(loanSchema.EntityTypes.Keys);
            var ignoredLoanEntities = new HashSet<string>(new[] { "NonBorrowingOwnerContract", "AlertChangeCircumstanceContract", "OtherIncomeSourceContract" });
            loanEntities.ExceptWith(ignoredLoanEntities);
            var existingLoanEntities = new HashSet<string>(Enums.GetMembers<LoanEntity>().Select(m => m.AsString(EnumFormat.Name)));
            var newLoanEntities = loanEntities.Except(existingLoanEntities).ToList();
            Assert.AreEqual(0, newLoanEntities.Count, $"{nameof(LoanEntity)}: {string.Join(", ", newLoanEntities)}");

            AssertNoExtensionData(loanSchema, "LoanSchema", "LoanSchema", true, new Dictionary<Type, HashSet<string>> { { typeof(LoanEntity), new HashSet<string>(new[] { "EntityReference", "FileAttachmentReference", "EntityRefContract" }, StringComparer.OrdinalIgnoreCase) } });
        }

        [TestMethod]
        [ApiTest]
        public async Task Schema_GenerateContract()
        {
            var client = await GetTestClientAsync();

            var fieldValues = new Dictionary<string, object>
            {
                { "1393", "Loan Originated" },
                { "1109", 150000M },
                { "100", true }
            };
            var loan = await client.Schema.GenerateContractAsync(fieldValues);
            Assert.IsTrue(loan.Dirty);
            Assert.AreEqual((string)fieldValues["1393"], loan.Fields["1393"].ToString());
            Assert.AreEqual((decimal)fieldValues["1109"], loan.Fields["1109"].ToDecimal());
            Assert.AreEqual((bool)fieldValues["100"], loan.Fields["100"].ToBoolean());
        }

        [TestMethod]
        [ApiTest]
        public async Task Schema_GeneratePaths()
        {
            var client = await GetTestClientAsync();

            var paths = await client.Schema.GeneratePathsAsync(new[] { "1393", "4000", "211" });
            Assert.AreEqual(3, paths.Count);
            Assert.AreEqual("/hmda/actionTaken", paths["1393"]);
            Assert.AreEqual("/applications/*/borrower/firstName", paths["4000"]);
            Assert.AreEqual("/loanSubmission/loanSubmissionFees[?(@/loanSubmissionFeeType == \"UserDefined4\")]/description", paths["211"]);

            paths = await client.Schema.GeneratePathsAsync(new string[0]);
            Assert.IsTrue(paths.Count > 10000);

            paths = await client.Schema.GeneratePathsAsync("address");
            Assert.IsTrue(paths.Count > 0);
            foreach (var pair in paths)
            {
                Assert.IsTrue(pair.Value.IndexOf("address", StringComparison.OrdinalIgnoreCase) >= 0);
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task LoanFieldDescriptors_RefreshStandardFields_NoUpdates()
        {
            var client = await GetTestClientAsync();

            var count = LoanFieldDescriptors.StandardFields.Count;
            await LoanFieldDescriptors.RefreshStandardFieldsAsync(client);
            Assert.AreEqual(count, LoanFieldDescriptors.StandardFields.Count);
            foreach (var pair in LoanFieldDescriptors.StandardFields)
            {
                if (pair.Value.ValueType != LoanFieldValueType.Boolean)
                {
                    Assert.AreEqual(typeof(FieldDescriptor), pair.Value.GetType(), pair.Key);
                }
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task LoanFieldDescriptors_RefreshStandardFields_DoesNotAffectUserAddedFields()
        {
            var client = await GetTestClientAsync();

            const string newFieldId = "NEWFIELD";
            Assert.IsTrue(LoanFieldDescriptors.FieldMappings.TryAdd(newFieldId, "Loan.NewField", false));
            var count = LoanFieldDescriptors.StandardFields.Count;
            await LoanFieldDescriptors.RefreshStandardFieldsAsync(client);
            Assert.AreEqual(count, LoanFieldDescriptors.StandardFields.Count);
            foreach (var pair in LoanFieldDescriptors.StandardFields)
            {
                if (pair.Value.ValueType != LoanFieldValueType.Boolean)
                {
                    Assert.AreEqual(typeof(FieldDescriptor), pair.Value.GetType(), pair.Key);
                }
            }
            Assert.IsTrue(LoanFieldDescriptors.FieldMappings.ContainsKey(newFieldId));
        }
    }
}