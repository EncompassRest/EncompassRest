using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class PersonasTests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task Personas_GetPersonas()
        {
            var client = await GetTestClientAsync();
            var personasApis = client.Settings.Personas;
            var personas = await personasApis.GetPersonasAsync();
            AssertNoExtensionData(personas, "Personas", null, true);
            foreach (var persona in personas)
            {
                var p = await personasApis.GetPersonaAsync(persona.Id);
                AssertNoExtensionData(p, "Persona", persona.Id, true);
            }
        }
    }
}