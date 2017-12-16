using System.Net;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class TemplatesTests : TestBaseClass
    {
        [TestMethod]
        public async Task LoanFolders_GetTemplateFoldersAndFiles()
        {
            var client = await GetTestClientAsync();
            await GetTemplateFoldersAndFiles(client, "Public\\\\");
            await GetTemplateFoldersAndFiles(client, "Personal\\\\");
        }

        private async Task GetTemplateFoldersAndFiles(EncompassRestClient client, string path)
        {
            var files = await client.Settings.Templates.LoanTemplates.GetTemplateFilesAsync(path);
            var folders = await client.Settings.Templates.LoanTemplates.GetTemplateFoldersAsync(path);
            foreach (var folder in folders)
            {
                await GetTemplateFoldersAndFiles(client, WebUtility.UrlDecode(folder.EntityUri));
            }
        }
    }
}