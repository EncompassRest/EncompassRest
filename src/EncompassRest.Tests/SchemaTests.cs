using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Schema;
using EnumsNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class SchemaTests : TestBaseClass
    {
        [TestMethod]
        public async Task Schema_GetLoanSchema()
        {
            var client = await GetTestClientAsync();
            var loanSchema = await client.Schema.GetLoanSchemaAsync(true);

            var loanEntities = new HashSet<string>(loanSchema.EntityTypes.Keys);
            var existingLoanEntities = new HashSet<string>(Enums.GetMembers<LoanEntity>().Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)));
            var newLoanEntities = loanEntities.Except(existingLoanEntities).ToList();
            Assert.AreEqual(0, newLoanEntities.Count);

            var ignoredElementTypes = new HashSet<string>(new[] { null, "EntityReference", "FileAttachmentReference", "EntityRefContract" });
            Assert.IsTrue(loanSchema.EntityTypes.Values.All(e => e.Properties.Values.All(p => p.ElementType.EnumValue.HasValue || ignoredElementTypes.Contains(p.ElementType.Value))));
            var elementTypes = new HashSet<string>(loanSchema.EntityTypes.Values.SelectMany(e => e.Properties.Values.Select(p => p.ElementType.Value)));
            elementTypes.ExceptWith(ignoredElementTypes);
            var newElementTypes = elementTypes.Except(existingLoanEntities).ToList();
            Assert.AreEqual(0, newElementTypes.Count);

            Assert.IsTrue(loanSchema.EntityTypes.Values.All(e => e.Properties.Values.All(p => p.EntityType.EnumValue.HasValue || p.EntityType.Value == null || p.EntityType.Value == "EntityRefContract")));
            var entityTypes = new HashSet<string>(loanSchema.EntityTypes.Values.SelectMany(e => e.Properties.Values.Select(p => p.EntityType.Value)));
            entityTypes.ExceptWith(new[] { null, "EntityRefContract" });
            var newEntityTypes = entityTypes.Except(existingLoanEntities).ToList();
            Assert.AreEqual(0, newEntityTypes.Count);

            Assert.IsTrue(loanSchema.EntityTypes.Values.All(e => e.Properties.Values.All(p => p.Type.EnumValue.HasValue || p.Type.Value == null)));
            var propertyTypes = new HashSet<string>(loanSchema.EntityTypes.Values.SelectMany(e => e.Properties.Values.Select(p => p.Type.Value)));
            propertyTypes.Remove(null);
            var existingPropertyTypes = new HashSet<string>(Enums.GetMembers<PropertySchemaType>().Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)));
            var newPropertyTypes = propertyTypes.Except(existingPropertyTypes).ToList();
            Assert.AreEqual(0, newPropertyTypes.Count);

            Assert.IsTrue(loanSchema.EntityTypes.Values.All(e => e.Properties.Values.All(p => p.Format.EnumValue.HasValue || p.Format.Value == null)));
            var formats = new HashSet<string>(loanSchema.EntityTypes.Values.SelectMany(e => e.Properties.Values.Select(p => p.Format.Value)));
            formats.Remove(null);
            var existingFormats = new HashSet<string>(Enums.GetMembers<LoanFieldFormat>().Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)));
            var newFormats = formats.Except(existingFormats).ToList();
            Assert.AreEqual(0, newFormats.Count);

            Assert.AreEqual(0, loanSchema.ExtensionData.Count);

            foreach (var entitySchema in loanSchema.EntityTypes.Values)
            {
                Assert.AreEqual(0, entitySchema.ExtensionData.Count);

                foreach (var propertySchema in entitySchema.Properties.Values)
                {
                    Assert.AreEqual(0, propertySchema.ExtensionData.Count);

                    if (propertySchema.AllowedValues != null)
                    {
                        foreach (var option in propertySchema.AllowedValues)
                        {
                            Assert.AreEqual(0, option.ExtensionData.Count);
                        }
                    }

                    if (propertySchema.InstancePatterns != null)
                    {
                        foreach (var instancePattern in propertySchema.InstancePatterns.Values)
                        {
                            Assert.AreEqual(0, instancePattern.ExtensionData.Count);
                        }
                    }
                }
            }
        }
    }
}