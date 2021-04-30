using System.Threading.Tasks;
using EncompassRest.Loans.v1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class ClientTests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task Client_ApiResponse()
        {
            var client = await GetTestClientAsync();
            string correlationId = null;
            client.ApiResponse += Client_ApiResponse;
            var supportedEntities = await client.Loans.GetSupportedEntitiesAsync();
            Assert.IsNotNull(correlationId);
            Assert.IsTrue(supportedEntities.Count > 0);
            client.ApiResponse -= Client_ApiResponse;
            correlationId = null;
            supportedEntities = await client.Loans.GetSupportedEntitiesAsync();
            Assert.IsNull(correlationId);
            Assert.IsTrue(supportedEntities.Count > 0);

            void Client_ApiResponse(object sender, IApiResponseEventArgs e)
            {
                correlationId = e.CorrelationId;
            }
        }
    }
}