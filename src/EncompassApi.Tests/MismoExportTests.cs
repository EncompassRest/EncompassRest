using System.Threading.Tasks;
using EncompassApi.Loans;
using EncompassApi.Services;
using EnumsNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassApi.Tests
{
    [TestClass]
    public class MismoExportTests : TestBaseClass
    {
        [TestMethod]
        public async Task ExportMismo()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan, true);
            Assert.IsNotNull(loanId);

            try
            {
                foreach (var format in Enums.GetValues<MismoFormat>())
                {
                    var bytes = await loan.LoanApis.ExportToMismoAsync(format);
                    Assert.IsTrue(bytes.Length > 0);
                    using (var stream = await loan.LoanApis.ExportToMismoStreamAsync(format))
                    {
                        var streamBytes = new byte[bytes.Length];
                        var offset = 0;
                        do
                        {
                            offset += await stream.ReadAsync(streamBytes, offset, bytes.Length - offset);
                        } while (offset != bytes.Length);
                        Assert.AreEqual(-1, stream.ReadByte());
                    }
                }
            }
            finally
            {
                try
                {
                    await Task.Delay(5000);
                    await client.Loans.DeleteLoanAsync(loanId);
                }
                catch
                {
                }
            }
        }
    }
}
