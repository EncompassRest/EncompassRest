using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Loans.Enums;
using EncompassRest.Utilities;
using EnumsNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EncompassRest.Tests
{
    [TestClass]
    public class LoanTests : TestBaseClass
    {
        [TestMethod]
        public async Task Loan_GetSupportedEntities()
        {
            var client = await GetTestClientAsync();
            var supportedEntities = await client.Loans.GetSupportedEntitiesAsync();
            var ignoredEntities = new HashSet<string>(new[] { "CoBorrower", "LOCompensation", "ElliUCDFields", "DocumentOrderLog", "NonVols" });
            Assert.IsTrue(supportedEntities.All(e => e.EnumValue.HasValue || ignoredEntities.Contains(e.Value)));
            var entities = new HashSet<string>(supportedEntities.Select(e => e.Value));
            entities.ExceptWith(ignoredEntities);
            var existingEntities = new HashSet<string>(Enums.GetMembers<LoanEntity>().Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name)));
            var newEntities = entities.Except(existingEntities).ToList();
            Assert.AreEqual(0, newEntities.Count);
        }

        [TestMethod]
        public async Task Loan_PublicSerialization()
        {
            var loan = new Loan();
            var serializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.Indented };
            Assert.AreEqual("{}", JsonConvert.SerializeObject(loan, serializerSettings));
            loan.ExtensionData.Add("dog", true);
            Assert.AreEqual(@"{""dog"":true}", loan.ToJson());
            Assert.AreEqual(@"{
  ""dog"": true
}", JsonConvert.SerializeObject(loan, serializerSettings));
            loan.Dirty = false;
            Assert.AreEqual("{}", loan.ToJson());
            Assert.AreEqual(@"{
  ""dog"": true
}", JsonConvert.SerializeObject(loan, serializerSettings));
            loan.ClosingCost.Gfe2010.OwnerTitleInsuranceAmount = 5M;
            Assert.AreEqual(@"{
  ""closingCost"": {
    ""gfe2010"": {
      ""ownerTitleInsuranceAmount"": ""5""
    }
  },
  ""dog"": true
}", JsonConvert.SerializeObject(loan, serializerSettings));
            loan.ClosingCost.Gfe2010.OwnerTitleInsuranceAmount = "na";
            Assert.AreEqual(@"{
  ""closingCost"": {
    ""gfe2010"": {
      ""ownerTitleInsuranceAmount"": ""NA""
    }
  },
  ""dog"": true
}", JsonConvert.SerializeObject(loan, serializerSettings));
            loan.ClosingCost.Gfe2010.OwnerTitleInsuranceAmount = null;
            Assert.AreEqual(@"{
  ""closingCost"": {
    ""gfe2010"": {}
  },
  ""dog"": true
}", JsonConvert.SerializeObject(loan, serializerSettings));
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanAsync(loan, true);
            Assert.IsNotNull(loanId);
            Assert.AreEqual(loanId, loan.EncompassId);
            var json = JsonConvert.SerializeObject(loan, serializerSettings);
            var deserializedLoan = JsonConvert.DeserializeObject<Loan>(json, serializerSettings);
            var newJson = JsonConvert.SerializeObject(loan, serializerSettings);
            Assert.AreEqual(json, newJson);
            await Task.Delay(5000);
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
        }

        [TestMethod]
        public void Loan_ToString()
        {
            var loan = new Loan();
            Assert.AreEqual("{}", loan.ToString());
            loan.BaseLoanAmount = 123456.78M;
            Assert.AreEqual(@"{""baseLoanAmount"":123456.78}", loan.ToString());
            Assert.AreEqual(@"{
  ""baseLoanAmount"": 123456.78
}", loan.ToString(indent: true));
            loan.BaseLoanAmount = null;
            Assert.AreEqual("{}", loan.ToString());
            loan.ExtensionData.Add("dog", true);
            Assert.AreEqual(@"{
  ""dog"": true
}", loan.ToString(indent: true));
            loan.CustomFields.Add(new CustomField { FieldName = "CX.TEMP", StringValue = "TempValue" });
            Assert.AreEqual(@"{
  ""customFields"": [
    {
      ""fieldName"": ""CX.TEMP"",
      ""stringValue"": ""TempValue""
    }
  ],
  ""dog"": true
}", loan.ToString(indent: true));
        }

        [TestMethod]
        public async Task Loan_Clone()
        {
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanAsync(new Loan());
            try
            {
                await Task.Delay(5000);
                var loan = await client.Loans.GetLoanAsync(loanId);
                loan.Fees.First(f => f.FeeType == "TitleExamination").NewHUDBorPaidAmount = 0.0M; // Required due to issue with number of decimals serialized
                var clonedLoan = loan.Clone();
                var loanAsJson = loan.ToString(true);
                var clonedLoanAsJson = clonedLoan.ToString(true);
                Assert.AreEqual(loanAsJson, clonedLoanAsJson);
            }
            finally
            {
                Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
            }
        }

        [TestMethod]
        public void Loan_PublicDeserialization()
        {
            var loan = JsonConvert.DeserializeObject<Loan>(@"{""tltv"":85.00}");
            Assert.AreEqual(85.00M, loan.Tltv.Value);
            loan = JsonConvert.DeserializeObject<Loan>(@"{""dog"":true}");
            Assert.AreEqual(1, loan.ExtensionData.Count);
            Assert.AreEqual(true, loan.ExtensionData["dog"]);
            loan = JsonConvert.DeserializeObject<Loan>(@"{""applicationTakenMethodType"":""Telephone""}");
            Assert.AreEqual(ApplicationTakenMethodType.Telephone, loan.ApplicationTakenMethodType.EnumValue.Value);

            var value = new { Loan = loan, TestString = "TESTING" };
            var serializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.Indented };
            var json = JsonConvert.SerializeObject(value, serializerSettings);
            Assert.AreEqual(@"{
  ""Loan"": {
    ""applicationTakenMethodType"": ""Telephone""
  },
  ""TestString"": ""TESTING""
}", json);
            var newValue = JsonConvert.DeserializeAnonymousType(json, value);
        }

        [TestMethod]
        public void NA_Serialization()
        {
            NA<decimal> na = null;
            Assert.AreEqual("null", na.ToJson());
            na = "na";
            Assert.AreEqual(@"""NA""", na.ToJson());
            na = 5.08M;
            Assert.AreEqual(@"""5.08""", na.ToJson());
        }

        [TestMethod]
        public void NA_Deserialization()
        {
            var na = JsonHelper.FromJson<NA<decimal>>("null");
            Assert.IsTrue(na.IsNull);
            na = JsonHelper.FromJson<NA<decimal>>(@"""NA""");
            Assert.IsTrue(na.IsNA);
            na = JsonHelper.FromJson<NA<decimal>>(@"""5.08""");
            Assert.AreEqual(5.08M, na.Value);
        }

        [TestMethod]
        public void Loan_Empty_Serialization()
        {
            var loan = new Loan();
            Assert.AreEqual("{}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_NonNullProperty_Serialization()
        {
            var loan = new Loan
            {
                Tltv = 85.00M
            };
            Assert.AreEqual(@"{""tltv"":85.00}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_NullProperty_Serialization()
        {
            var loan = new Loan
            {
                Tltv = null
            };
            Assert.AreEqual(@"{""tltv"":null}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_CustomFields_Serialization()
        {
            var loan = new Loan();
            var customField = new CustomField { FieldName = "CUST91FV", StringValue = "Initial Value" };
            loan.CustomFields.Add(customField);
            loan.CustomFields.Add(new CustomField { FieldName = "CUST92FV", NumericValue = 10.0M });
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CUST91FV"",""stringValue"":""Initial Value""},{""fieldName"":""CUST92FV"",""numericValue"":10.0}]}", loan.ToJson());
            loan.Dirty = false;
            Assert.AreEqual("{}", loan.ToJson());
            customField.StringValue = "New Value";
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CUST91FV"",""stringValue"":""New Value""}]}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_ExtensionData_Serialization()
        {
            var loan = new Loan();
            Assert.AreEqual("{}", loan.ToJson());
            const string boolPropertyName = "boolProperty";
            loan.ExtensionData[boolPropertyName] = true;
            Assert.AreEqual(1, loan.ExtensionData.Count);
            Assert.IsTrue(loan.ExtensionData.ContainsKey(boolPropertyName));
            Assert.AreEqual(true, (bool)loan.ExtensionData[boolPropertyName]);
            Assert.AreEqual($@"{{""{boolPropertyName}"":true}}", loan.ToJson());
            loan.Dirty = false;
            Assert.AreEqual("{}", loan.ToJson());
            const string decimalPropertyName = "decimalProperty";
            loan.ExtensionData[decimalPropertyName] = 10.5M;
            Assert.AreEqual(2, loan.ExtensionData.Count);
            Assert.IsTrue(loan.ExtensionData.ContainsKey(boolPropertyName));
            Assert.IsTrue(loan.ExtensionData.ContainsKey(decimalPropertyName));
            Assert.AreEqual(true, (bool)loan.ExtensionData[boolPropertyName]);
            Assert.AreEqual(10.5M, (decimal)loan.ExtensionData[decimalPropertyName]);
            Assert.AreEqual($@"{{""{decimalPropertyName}"":10.5}}", loan.ToJson());
            const string stringPropertyName = "stringProperty";
            const string stringPropertyValue = "Hello";
            loan.ExtensionData[stringPropertyName] = stringPropertyValue;
            Assert.AreEqual(3, loan.ExtensionData.Count);
            Assert.IsTrue(loan.ExtensionData.ContainsKey(boolPropertyName));
            Assert.IsTrue(loan.ExtensionData.ContainsKey(decimalPropertyName));
            Assert.IsTrue(loan.ExtensionData.ContainsKey(stringPropertyName));
            Assert.AreEqual(true, (bool)loan.ExtensionData[boolPropertyName]);
            Assert.AreEqual(10.5M, (decimal)loan.ExtensionData[decimalPropertyName]);
            Assert.AreEqual(stringPropertyValue, (string)loan.ExtensionData[stringPropertyName]);
            CollectionAssert.AreEqual(new[] { boolPropertyName, decimalPropertyName, stringPropertyName }, loan.ExtensionData.Keys.ToList());
            CollectionAssert.AreEqual(new object[] { true, 10.5M, stringPropertyValue }, loan.ExtensionData.Values.ToList());
            CollectionAssert.AreEqual(new[] { new KeyValuePair<string, object>(boolPropertyName, true), new KeyValuePair<string, object>(decimalPropertyName, 10.5M), new KeyValuePair<string, object>(stringPropertyName, stringPropertyValue) }, loan.ExtensionData.ToList());
            Assert.AreEqual($@"{{""{decimalPropertyName}"":10.5,""{stringPropertyName}"":""{stringPropertyValue}""}}", loan.ToJson());
        }

        [TestMethod]
        public async Task Loan_CreateAndDelete()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan();
            var loanId = await client.Loans.CreateLoanAsync(loan, true).ConfigureAwait(false);
            Assert.IsNotNull(loanId);
            Assert.AreEqual(loanId, loan.EncompassId);
            await Task.Delay(5000);
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId).ConfigureAwait(false));
        }

        [TestMethod]
        public async Task Loan_CreateRawAndDelete()
        {
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanRawAsync("{}").ConfigureAwait(false);
            Assert.IsNotNull(loanId);
            Assert.IsFalse(loanId.StartsWith("{"));
            await Task.Delay(5000);
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId).ConfigureAwait(false));

            var json = await client.Loans.CreateLoanRawAsync("{}", "?view=entity").ConfigureAwait(false);
            Assert.IsNotNull(json);
            Assert.IsTrue(json.StartsWith("{"));
            var loan = JToken.Parse(json);
            loanId = loan["encompassId"].ToString();
            await Task.Delay(5000);
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId).ConfigureAwait(false));
        }

        [TestMethod]
        public async Task Loan_BadUpdateException()
        {
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanRawAsync("{}");
            Assert.IsNotNull(loanId);
            var ex = await Assert.ThrowsExceptionAsync<EncompassRestException>(() => client.Loans.UpdateLoanRawAsync(loanId, "{invalidJson}"));
            Assert.AreEqual(HttpStatusCode.BadRequest, ex.StatusCode);
            Assert.AreEqual("{invalidJson}", ex.RequestContent);
            var loan = new Loan(client, Guid.NewGuid().ToString("D"))
            {
                Tltv = 85.00M
            };
            ex = await Assert.ThrowsExceptionAsync<EncompassRestException>(() => client.Loans.UpdateLoanAsync(loan));
            Assert.AreEqual(HttpStatusCode.NotFound, ex.StatusCode);
            Assert.AreEqual($@"{{""encompassId"":""{loan.EncompassId}"",""tltv"":85.00}}", ex.RequestContent);
            await Task.Delay(5000);
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
        }

        [TestMethod]
        public async Task Loan_CreateInLoanFolder()
        {
            var client = await GetTestClientAsync();
            if (client.AccessToken.Token == "Token")
            {
                var loan = new Loan();
                var loanId = await client.Loans.CreateLoanAsync(loan, new CreateLoanOptions { LoanFolder = "My Pipeline" });
                var metaData = await loan.LoanApis.GetMetadataAsync();
                Assert.AreEqual("My Pipeline", metaData.LoanFolder);
                //await client.LoanFolders.MoveLoanToFolderAsync(loanId, "OAPI"); // Unauthorized error
                //metaData = await loan.LoanApis.GetMetadataAsync();
                //Assert.AreEqual("OAPI", metaData.LoanFolder);
                var loan2 = new Loan();
                var loanId2 = await client.Loans.CreateLoanAsync(loan2, new CreateLoanOptions { LoanFolder = "OAPI" });
                var metaData2 = await loan2.LoanApis.GetMetadataAsync();
                Assert.AreEqual("OAPI", metaData2.LoanFolder);
                await Task.Delay(5000);
                Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
                Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId2));
            }
        }

        [TestMethod]
        public async Task Loan_CreateWithLoanTemplate()
        {
            var client = await GetTestClientAsync();
            if (client.AccessToken.Token == "Token")
            {
                var loan = new Loan();
                var loanId = await client.Loans.CreateLoanAsync(loan, new CreateLoanOptions { LoanTemplate = @"Public:\\Companywide\Example Purchase Loan Template", Populate = true });
                var metaData = await loan.LoanApis.GetMetadataAsync();
                await Task.Delay(5000);
                Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
            }
        }

        [TestMethod]
        public async Task Loan_UpdateWithLoanTemplate()
        {
            var client = await GetTestClientAsync();
            if (client.AccessToken.Token == "Token")
            {
                var loan = new Loan();
                var loanId = await client.Loans.CreateLoanAsync(loan, true);
                await client.Loans.UpdateLoanAsync(loan, new UpdateLoanOptions { LoanTemplate = @"Public:\\Companywide\Example Purchase Loan Template", Populate = true });
                var metaData = await loan.LoanApis.GetMetadataAsync();
                await Task.Delay(5000);
                Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
            }
        }

        [TestMethod]
        public void Loan_FieldsNullAssignment()
        {
            var loan = new Loan();
            foreach (var field in LoanFields.FieldMappings.Keys)
            {
                loan.Fields[field] = null;
                Assert.IsNull(loan.Fields[field]);
            }
            var json = loan.ToJson();
        }

        [TestMethod]
        public void Loan_FieldsString()
        {
            var loan = new Loan();
            var loanNumber = "9876543210";
            loan.Fields["364"] = loanNumber;
            Assert.AreEqual(loanNumber, (string)loan.Fields["364"]);
            Assert.AreEqual($@"{{""loanNumber"":""{loanNumber}""}}", loan.ToJson());
            loan.Fields["364"] = null;
            Assert.IsNull(loan.Fields["364"]);
            Assert.AreEqual(@"{""loanNumber"":null}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsDateTime()
        {
            var loan = new Loan();
            var now = DateTime.Now;
            loan.Fields["CD1.X1"] = now;
            Assert.AreEqual(now, (DateTime?)loan.Fields["CD1.X1"]);
            Assert.AreEqual($@"{{""closingCost"":{{""closingDisclosure1"":{{""cdDateIssued"":{now.ToJson()}}}}}}}", loan.ToJson());
            loan.Fields["CD1.X1"] = null;
            Assert.IsNull(loan.Fields["CD1.X1"]);
            Assert.AreEqual(@"{""closingCost"":{""closingDisclosure1"":{""cdDateIssued"":null}}}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsDecimal()
        {
            var loan = new Loan();
            var baseLoanAmount = 185000M;
            loan.Fields["2"] = baseLoanAmount;
            Assert.AreEqual(baseLoanAmount, (decimal?)loan.Fields["2"]);
            Assert.AreEqual($@"{{""baseLoanAmount"":{baseLoanAmount}.0}}", loan.ToJson());
            loan.Fields["2"] = null;
            Assert.IsNull(loan.Fields["2"]);
            Assert.AreEqual($@"{{""baseLoanAmount"":null}}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsInt()
        {
            var loan = new Loan();
            var bltv = 75;
            loan.Fields["4012"] = bltv;
            Assert.AreEqual(bltv, (int?)loan.Fields["4012"]);
            Assert.AreEqual($@"{{""bltv"":{bltv}}}", loan.ToJson());
            loan.Fields["4012"] = null;
            Assert.IsNull(loan.Fields["4012"]);
            Assert.AreEqual($@"{{""bltv"":null}}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsBool()
        {
            var loan = new Loan();
            var borrowerCoBorrowerMarriedIndicator = true;
            loan.Fields["100"] = borrowerCoBorrowerMarriedIndicator;
            Assert.AreEqual(borrowerCoBorrowerMarriedIndicator, (bool?)loan.Fields["100"]);
            Assert.AreEqual($@"{{""borrowerCoBorrowerMarriedIndicator"":{borrowerCoBorrowerMarriedIndicator.ToString().ToLower()}}}", loan.ToJson());
            loan.Fields["100"] = null;
            Assert.IsNull(loan.Fields["100"]);
            Assert.AreEqual($@"{{""borrowerCoBorrowerMarriedIndicator"":null}}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsStringEnumValue()
        {
            var loan = new Loan();
            var applicationTakenMethodType = "Internet";
            loan.Fields["479"] = applicationTakenMethodType;
            Assert.AreEqual(applicationTakenMethodType, (string)loan.Fields["479"]);
            Assert.AreEqual(@"{""applicationTakenMethodType"":""Internet""}", loan.ToJson());
            loan.Fields["479"] = null;
            Assert.IsNull(loan.Fields["479"]);
            Assert.AreEqual(@"{""applicationTakenMethodType"":null}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsNADecimal()
        {
            var loan = new Loan();
            var income = 4000;
            loan.Fields["HMDA.X32"] = income;
            Assert.AreEqual(income.ToString(), (string)loan.Fields["HMDA.X32"]);
            Assert.AreEqual($@"{{""hmda"":{{""income"":""{income}""}}}}", loan.ToJson());
            var incomeStr = "5500";
            loan.Fields["HMDA.X32"] = incomeStr;
            Assert.AreEqual(incomeStr, (string)loan.Fields["HMDA.X32"]);
            Assert.AreEqual($@"{{""hmda"":{{""income"":""{incomeStr}""}}}}", loan.ToJson());
            loan.Fields["HMDA.X32"] = "NA";
            Assert.AreEqual("NA", (string)loan.Fields["HMDA.X32"]);
            Assert.AreEqual(@"{""hmda"":{""income"":""NA""}}", loan.ToJson());
            loan.Fields["HMDA.X32"] = null;
            Assert.IsNull(loan.Fields["HMDA.X32"]);
            Assert.AreEqual(@"{""hmda"":{""income"":null}}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsCustomString()
        {
            var loan = new Loan();
            var value = "ABC";
            loan.Fields["CX.NAME"] = value;
            Assert.AreEqual(value, (string)loan.Fields["CX.NAME"]);
            Assert.AreEqual($@"{{""customFields"":[{{""fieldName"":""CX.NAME"",""stringValue"":""{value}""}}]}}", loan.ToJson());
            loan.Fields["CX.NAME"] = null;
            Assert.IsNull(loan.Fields["CX.NAME"]);
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CX.NAME"",""stringValue"":null}]}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsCustomDate()
        {
            var loan = new Loan();
            var value = DateTime.Now;
            loan.Fields["CX.NOW"] = value;
            Assert.AreEqual(value, (DateTime?)loan.Fields["CX.NOW"]);
            Assert.AreEqual($@"{{""customFields"":[{{""dateValue"":{value.ToJson()},""fieldName"":""CX.NOW""}}]}}", loan.ToJson());
            loan.Fields["CX.NOW"] = null;
            Assert.IsNull(loan.Fields["CX.NOW"]);
            Assert.AreEqual(@"{""customFields"":[{""dateValue"":null,""fieldName"":""CX.NOW""}]}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsCustomNumeric()
        {
            var loan = new Loan();
            var value = 1234.56M;
            loan.Fields["CX.NUMBER"] = value;
            Assert.AreEqual(value, (decimal?)loan.Fields["CX.NUMBER"]);
            Assert.AreEqual($@"{{""customFields"":[{{""fieldName"":""CX.NUMBER"",""numericValue"":{value}}}]}}", loan.ToJson());
            var integerValue = 98765;
            loan.Fields["CX.NUMBER"] = integerValue;
            Assert.AreEqual(integerValue, (decimal?)loan.Fields["CX.NUMBER"]);
            Assert.AreEqual($@"{{""customFields"":[{{""fieldName"":""CX.NUMBER"",""numericValue"":{integerValue}.0}}]}}", loan.ToJson());
            loan.Fields["CX.NUMBER"] = null;
            Assert.IsNull(loan.Fields["CX.NUMBER"]);
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CX.NUMBER"",""numericValue"":null}]}", loan.ToJson());
        }
    }
}