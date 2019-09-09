using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EncompassRest.Loans;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class FieldReaderTests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task FieldReader_GetValues()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var fieldValues = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "1109", "250000.00" },
                { "4002", "Smith" },
                { "748", "1/1/2019" },
                { "CUST01FV", "" }
            };
            foreach (var pair in fieldValues)
            {
                loan.Fields[pair.Key].Value = pair.Value;
            }
            var loanId = await client.Loans.CreateLoanAsync(loan);
            try
            {
                var loanFieldValues = await loan.LoanApis.FieldReader.GetLoanFieldValuesAsync(fieldValues.Keys);
                Assert.AreEqual(fieldValues.Count, loanFieldValues.Count);
                foreach (var loanFieldValue in loanFieldValues)
                {
                    Assert.IsTrue(fieldValues.TryGetValue(loanFieldValue.FieldId, out var value));
                    Assert.AreEqual(value, loanFieldValue.Value);
                    AssertNoExtensionData(loanFieldValue, "LoanFieldValue", loanFieldValue.FieldId, true);
                }
            }
            finally
            {
                try
                {
                    await client.Loans.DeleteLoanAsync(loanId);
                }
                catch
                {
                }
            }
        }
    }
}