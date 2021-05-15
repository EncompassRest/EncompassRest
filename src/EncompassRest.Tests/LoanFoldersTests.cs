using System.Collections.Generic;
using System.Threading.Tasks;
using EncompassRest.LoanFolders.v3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class LoanFoldersTests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task LoanFolders_GetLoanFolders()
        {
            var client = await GetTestClientAsync();
            var loanFolders = await client.LoanFolders.GetLoanFoldersAsync();
            AssertNoExtensionData(loanFolders, "LoanFolders", null, true);
            var loanFoldersList = new List<LoanFolder>();
            foreach (var loanFolder in loanFolders)
            {
                var folder = await client.LoanFolders.GetLoanFolderAsync(loanFolder.FolderName);
                loanFoldersList.Add(folder);
            }
            AssertNoExtensionData(loanFoldersList, "LoanFoldersList", null, true);
        }
    }
}