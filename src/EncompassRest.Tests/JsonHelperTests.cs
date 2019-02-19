using EncompassRest.Loans;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class JsonHelperTests
    {
        [TestMethod]
        public void PopulateArray_HandlesDuplicateIds()
        {
            var customField = new CustomField { FieldName = "CX.ABC", StringValue = "ABC" };
            var list = new DirtyList<CustomField>
            {
                customField
            };
            JsonHelper.PopulateFromJson(@"[{""fieldName"":""CX.ABC"",""stringValue"":""DEF""},{""fieldName"":""CX.ABC"",""stringValue"":""GHI""}]", list);
            Assert.AreEqual(2, list.Count);
            Assert.AreSame(customField, list[0]);
            Assert.AreEqual("DEF", customField.StringValue);
            Assert.AreEqual("GHI", list[1].StringValue);
        }
    }
}