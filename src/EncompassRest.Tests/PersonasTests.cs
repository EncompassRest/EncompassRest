using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EncompassRest.Settings.Personas.v1;
using EnumsNET;
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
            var personaList = new List<Persona>();
            foreach (var persona in personas)
            {
                var p = await personasApis.GetPersonaAsync(persona.Id);
                personaList.Add(p);
            }
            AssertNoExtensionData(personaList, "PersonaList", null, true);
        }

        [TestMethod]
        [ApiTest]
        public async Task Personas_GetPersonaCategories()
        {
            var client = await GetTestClientAsync();
            var categories = Enums.GetValues<PersonaCategory>();
            try
            {
                var persona = await client.Settings.Personas.GetPersonaAsync("1", categories);
            }
            catch
            {
                var problemCategories = new List<string>();
                foreach (var category in categories)
                {
                    try
                    {
                        var persona = await client.Settings.Personas.GetPersonaAsync("1", new[] { category });
                    }
                    catch
                    {
                        problemCategories.Add(category.GetName());
                    }
                }
                throw new Exception($"Problem categories include {string.Join(", ", problemCategories)}");
            }
        }
    }
}