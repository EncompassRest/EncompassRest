using System.Net;
using System.Threading.Tasks;
using EncompassRest.Settings.Templates;
using EncompassRest.Settings.Templates.v1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class TemplatesTests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task LoanTemplateSet_GetTemplateFoldersAndFiles()
        {
            var client = await GetTestClientAsync();
            await GetTemplateFoldersAndFiles(client.Settings.Templates.LoanTemplateSet, "Public\\\\");
            await GetTemplateFoldersAndFiles(client.Settings.Templates.LoanTemplateSet, "Personal\\\\");
        }

        private async Task GetTemplateFoldersAndFiles(ILoanTemplateSet loanTemplateSet, string path)
        {
            var files = await loanTemplateSet.GetTemplateFilesAsync(path);
            var folders = await loanTemplateSet.GetTemplateFoldersAsync(path);
            foreach (var folder in folders)
            {
                await GetTemplateFoldersAndFiles(loanTemplateSet, WebUtility.UrlDecode(folder.EntityUri));
            }
        }
    }
}