using System.Net;
using System.Threading.Tasks;
using EncompassRest.Settings.Templates;
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
            await GetTemplateFoldersAndFiles(client.Settings.Templates.LoanTemplateSet, "Public\\\\");
            await GetTemplateFoldersAndFiles(client.Settings.Templates.LoanTemplateSet, "Personal\\\\");
        }

        private async Task GetTemplateFoldersAndFiles(TemplateApiObject templateApiObject, string path)
        {
            var files = await templateApiObject.GetTemplateFilesAsync(path);
            var folders = await templateApiObject.GetTemplateFoldersAsync(path);
            foreach (var folder in folders)
            {
                await GetTemplateFoldersAndFiles(templateApiObject, WebUtility.UrlDecode(folder.EntityUri));
            }
        }
    }
}