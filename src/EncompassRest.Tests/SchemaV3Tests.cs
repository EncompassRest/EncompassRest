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
    }
}