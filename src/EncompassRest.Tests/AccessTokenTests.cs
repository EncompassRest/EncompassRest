using System.Threading.Tasks;
using EncompassRest.Token;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class AccessTokenTests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task AccessToken_Introspection()
        {
            var client = await GetTestClientAsync();
            var accessToken = client.AccessToken;
            if (accessToken.Token != "Token")
            {
                var response = await accessToken.IntrospectAsync();
                Assert.IsTrue(response.Active);
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task AccessToken_RetrieveNewToken()
        {
            var client = await GetTestClientAsync();
            var accessToken = client.AccessToken;
            var token = accessToken.Token;
            if (token != "Token")
            {
                var response = await accessToken.IntrospectAsync();
                Assert.IsTrue(response.Active);
                Assert.IsTrue(await accessToken.RevokeAsync());
                response = await accessToken.IntrospectAsync();
                Assert.IsNull(response);
                var supportedEntities = await client.Loans.GetSupportedEntitiesAsync();
                Assert.IsTrue(supportedEntities.Count > 0);
                Assert.AreNotEqual(token, accessToken.Token);
                response = await accessToken.IntrospectAsync();
                Assert.IsTrue(response.Active);
            }
        }

#if NETCOREAPP3_0
        [TestMethod]
        [ApiTest]
        public async Task AccessToken_RevokeOnDisposeAsync()
        {
            ClientParameters clientParameters = null;
            var client = await GetTestClientAsync(cp => { clientParameters = cp; });
            var accessToken = client.AccessToken;
            var token = accessToken.Token;
            if (token != "Token")
            {
                TokenIntrospectionResponse response;
                await using (client)
                {
                    response = await accessToken.IntrospectAsync();
                    Assert.IsTrue(response.Active);
                }
                using (await EncompassRestClient.CreateFromAccessTokenAsync(clientParameters, token))
                {
                    response = await accessToken.IntrospectAsync();
                    Assert.IsNull(response);
                }
            }
        }
#endif
    }
}