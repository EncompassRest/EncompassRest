using System.Collections.Generic;
using System.Threading.Tasks;
using EncompassRest.Schema.v3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class SchemaV3Tests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task Schema_GetLoanSchema()
        {
            var client = await GetTestClientAsync();
            var loanSchema = await client.Schema.GetLoanSchemaAsync(true);

            AssertNoExtensionData(loanSchema, "LoanSchema", "LoanSchema", true);
        }

        [TestMethod]
        [ApiTest]
        public async Task Schema_GetStandardFieldSchema()
        {
            var client = await GetTestClientAsync();
            var standardFields = new List<StandardFieldSchema>();
            int start;
            const int limit = 5000;
            do
            {
                start = standardFields.Count;
                var newFields = await client.Schema.GetStandardFieldSchemaAsync(null, start, limit);
                standardFields.AddRange(newFields);
            } while (standardFields.Count > start);

            AssertNoExtensionData(standardFields, "StandardFields", null, true);
        }

        [TestMethod]
        [ApiTest]
        public async Task Schema_GetVirtualFieldSchema()
        {
            var client = await GetTestClientAsync();
            var virtualFields = await client.Schema.GetVirtualFieldSchemaAsync();

            AssertNoExtensionData(virtualFields, "VirtualFields", null, true);
        }
    }
}