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
        public void Loan_FieldsValueAssignment()
        {
            foreach (var fieldId in LoanFields.FieldMappings.Keys)
            {
                var loan = new Loan();
                var field = loan.Fields[fieldId];
                Assert.IsNull(field.Value);
                Assert.IsTrue(field.IsEmpty);
                switch (field.Type)
                {
                    case LoanFieldType.String:
                        var str = "abc";
                        field.Value = str;
                        Assert.AreEqual(str, (string)field.Value);
                        Assert.AreEqual(str, field.ToString());
                        break;
                    case LoanFieldType.DateTime:
                        var now = DateTime.Now;
                        field.Value = now;
                        Assert.AreEqual(now, (DateTime?)field.Value);
                        Assert.AreEqual(now, field.ToDateTime());
                        break;
                    case LoanFieldType.Decimal:
                        var d = 12.5M;
                        field.Value = d;
                        Assert.AreEqual(d, (decimal?)field.Value);
                        Assert.AreEqual(d, field.ToDecimal());
                        break;
                    case LoanFieldType.Int32:
                        var i = 6;
                        field.Value = i;
                        Assert.AreEqual(i, (int?)field.Value);
                        Assert.AreEqual(i, field.ToInt32());
                        break;
                    case LoanFieldType.Boolean:
                        var b = true;
                        field.Value = b;
                        Assert.AreEqual(b, (bool?)field.Value);
                        Assert.AreEqual(b, field.ToBoolean());
                        break;
                    case LoanFieldType.NADecimal:
                        var n = 95.125M;
                        field.Value = n;
                        Assert.AreEqual(n.ToString(), (string)field.Value);
                        Assert.AreEqual(n.ToString(), field.ToString());
                        Assert.AreEqual(n, field.ToDecimal());
                        break;
                    default:
                        Assert.Fail($"Invalid LoanFieldType for {fieldId}");
                        break;
                }
                Assert.IsFalse(field.IsEmpty);
                if (fieldId != "GUID")
                {
                    Assert.AreNotEqual("{}", loan.ToJson());
                }

                loan.Dirty = false;
                if (fieldId != "GUID")
                {
                    Assert.AreEqual("{}", loan.ToJson());
                }

                field.Value = null;
                Assert.IsNull(field.Value);
                Assert.IsTrue(field.IsEmpty);
                if (fieldId != "GUID")
                {
                    Assert.AreNotEqual("{}", loan.ToJson());
                }
            }
        }

        [TestMethod]
        public void Loan_FieldsString()
        {
            var loan = new Loan();
            var loanNumber = "9876543210";
            var field = loan.Fields["364"];
            Assert.AreEqual("Loan.LoanNumber", field.ModelPath);
            field.Value = loanNumber;
            Assert.AreEqual(loanNumber, (string)field.Value);
            Assert.AreEqual(loanNumber, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""loanNumber"":""{loanNumber}""}}", loan.ToJson());
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToString());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""loanNumber"":null}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsDateTime()
        {
            var loan = new Loan();
            var now = DateTime.Now;
            var field = loan.Fields["CD1.X1"];
            Assert.AreEqual("Loan.ClosingCost.ClosingDisclosure1.CDDateIssued", field.ModelPath);
            field.Value = now;
            Assert.AreEqual(now, (DateTime?)field.Value);
            Assert.AreEqual(now, field.ToDateTime());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""closingCost"":{{""closingDisclosure1"":{{""cdDateIssued"":{now.ToJson()}}}}}}}", loan.ToJson());
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToDateTime());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""closingCost"":{""closingDisclosure1"":{""cdDateIssued"":null}}}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsDecimal()
        {
            var loan = new Loan();
            var baseLoanAmount = 185000;
            var field = loan.Fields["2"];
            Assert.AreEqual("Loan.BaseLoanAmount", field.ModelPath);
            field.Value = baseLoanAmount;
            Assert.AreEqual(baseLoanAmount, (decimal?)field.Value);
            Assert.AreEqual(baseLoanAmount, field.ToDecimal());
            Assert.AreEqual(baseLoanAmount, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""baseLoanAmount"":{baseLoanAmount}.0}}", loan.ToJson());
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToDecimal());
            Assert.IsNull(field.ToInt32());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual($@"{{""baseLoanAmount"":null}}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsInt()
        {
            var loan = new Loan();
            var bltv = 75;
            var field = loan.Fields["4012"];
            Assert.AreEqual("Loan.BLTV", field.ModelPath);
            field.Value = bltv;
            Assert.AreEqual(bltv, (int?)field.Value);
            Assert.AreEqual(bltv, field.ToInt32());
            Assert.AreEqual(bltv, field.ToDecimal());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""bltv"":{bltv}}}", loan.ToJson());
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToInt32());
            Assert.IsNull(field.ToDecimal());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual($@"{{""bltv"":null}}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsBool()
        {
            var loan = new Loan();
            var borrowerCoBorrowerMarriedIndicator = true;
            var field = loan.Fields["100"];
            Assert.AreEqual("Loan.BorrowerCoBorrowerMarriedIndicator", field.ModelPath);
            field.Value = borrowerCoBorrowerMarriedIndicator;
            Assert.AreEqual(borrowerCoBorrowerMarriedIndicator, (bool?)field.Value);
            Assert.AreEqual(borrowerCoBorrowerMarriedIndicator, field.ToBoolean());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""borrowerCoBorrowerMarriedIndicator"":{borrowerCoBorrowerMarriedIndicator.ToString().ToLower()}}}", loan.ToJson());
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToBoolean());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual($@"{{""borrowerCoBorrowerMarriedIndicator"":null}}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsStringEnumValue()
        {
            var loan = new Loan();
            var applicationTakenMethodType = "Internet";
            var field = loan.Fields["479"];
            Assert.AreEqual("Loan.ApplicationTakenMethodType", field.ModelPath);
            field.Value = applicationTakenMethodType;
            Assert.AreEqual(applicationTakenMethodType, (string)field.Value);
            Assert.AreEqual(applicationTakenMethodType, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(@"{""applicationTakenMethodType"":""Internet""}", loan.ToJson());
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToString());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""applicationTakenMethodType"":null}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsNADecimal()
        {
            var loan = new Loan();
            var income = 4000;
            var field = loan.Fields["HMDA.X32"];
            Assert.AreEqual("Loan.Hmda.Income", field.ModelPath);
            field.Value = income;
            Assert.AreEqual(income.ToString(), (string)field.Value);
            Assert.AreEqual(income.ToString(), field.ToString());
            Assert.AreEqual(income, field.ToDecimal());
            Assert.AreEqual(income, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""hmda"":{{""income"":""{income}""}}}}", loan.ToJson());
            income = 5500;
            field.Value = income.ToString();
            Assert.AreEqual(income.ToString(), (string)field.Value);
            Assert.AreEqual(income.ToString(), field.ToString());
            Assert.AreEqual(income, field.ToDecimal());
            Assert.AreEqual(income, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""hmda"":{{""income"":""{income}""}}}}", loan.ToJson());
            field.Value = "NA";
            Assert.AreEqual("NA", (string)field.Value);
            Assert.AreEqual("NA", field.ToString());
            Assert.IsNull(field.ToDecimal());
            Assert.IsNull(field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(@"{""hmda"":{""income"":""NA""}}", loan.ToJson());
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToString());
            Assert.IsNull(field.ToDecimal());
            Assert.IsNull(field.ToInt32());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""hmda"":{""income"":null}}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsCustomString()
        {
            var loan = new Loan();
            var value = "ABC";
            var field = loan.Fields["CX.NAME"];
            Assert.AreEqual("Loan.CustomFields[(FieldName == 'CX.NAME')].StringValue", field.ModelPath);
            field.Value = value;
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""customFields"":[{{""fieldName"":""CX.NAME"",""stringValue"":""{value}""}}]}}", loan.ToJson());
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToString());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CX.NAME"",""stringValue"":null}]}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsCustomDate()
        {
            var loan = new Loan();
            var value = DateTime.Now;
            var field = loan.Fields["CX.NOW"];
            Assert.AreEqual("Loan.CustomFields[(FieldName == 'CX.NOW')].StringValue", field.ModelPath);
            field.Value = value;
            Assert.AreEqual(value, (DateTime?)field.Value);
            Assert.AreEqual(value, field.ToDateTime());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""customFields"":[{{""dateValue"":{value.ToJson()},""fieldName"":""CX.NOW""}}]}}", loan.ToJson());
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToDateTime());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""customFields"":[{""dateValue"":null,""fieldName"":""CX.NOW""}]}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsCustomNumeric()
        {
            var loan = new Loan();
            var value = 1234.56M;
            var field = loan.Fields["CX.NUMBER"];
            Assert.AreEqual("Loan.CustomFields[(FieldName == 'CX.NUMBER')].StringValue", field.ModelPath);
            field.Value = value;
            Assert.AreEqual(value, (decimal?)field.Value);
            Assert.AreEqual(value, field.ToDecimal());
            Assert.AreEqual(1235, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""customFields"":[{{""fieldName"":""CX.NUMBER"",""numericValue"":{value}}}]}}", loan.ToJson());
            var integerValue = 98765;
            field.Value = integerValue;
            Assert.AreEqual(integerValue, (decimal?)field.Value);
            Assert.AreEqual(integerValue, field.ToDecimal());
            Assert.AreEqual(integerValue, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""customFields"":[{{""fieldName"":""CX.NUMBER"",""numericValue"":{integerValue}.0}}]}}", loan.ToJson());
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToDecimal());
            Assert.IsNull(field.ToInt32());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CX.NUMBER"",""numericValue"":null}]}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsBP()
        {
            var loan = new Loan();
            var value = "Joe";
            var field = loan.Fields["4000#2"];
            Assert.AreEqual("Loan.Applications[(ApplicationIndex == '1')].Borrower.FirstName", field.ModelPath);
            field.Value = value;
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""applications"":[{{""applicationIndex"":1,""borrower"":{{""firstName"":""{value}""}}}}]}}", loan.ToJson());
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToString());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual($@"{{""applications"":[{{""applicationIndex"":1,""borrower"":{{""firstName"":null}}}}]}}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsInvalidField()
        {
            var loan = new Loan();
            Assert.ThrowsException<ArgumentException>(() => loan.Fields["1"]);
        }

        [TestMethod]
        public void Loan_FieldsLocking()
        {
            var loan = new Loan();
            var field = loan.Fields["CD1.X65"];
            Assert.AreEqual("Loan.ClosingCost.ClosingDisclosure1.Comments", field.ModelPath);
            Assert.IsFalse(field.Locked);
            field.Locked = true;
            Assert.IsTrue(field.Locked);
            Assert.AreEqual(field.ModelPath, loan.FieldLockData[0].ModelPath);
            Assert.AreEqual(false, loan.FieldLockData[0].LockRemoved);
            Assert.AreEqual($@"{{""fieldLockData"":[{{""lockRemoved"":false,""modelPath"":""{field.ModelPath}""}}]}}", loan.ToJson());
            field.Locked = false;
            Assert.IsFalse(field.Locked);
            Assert.AreEqual(field.ModelPath, loan.FieldLockData[0].ModelPath);
            Assert.AreEqual(true, loan.FieldLockData[0].LockRemoved);
            Assert.AreEqual($@"{{""fieldLockData"":[{{""lockRemoved"":true,""modelPath"":""{field.ModelPath}""}}]}}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_ModelPaths()
        {
            var loan = new Loan();
            foreach (var pair in LoanFields.FieldMappings.Distinct(new FieldMappingComparer()))
            {
                var parsedModelPath = new ModelPath($"Loan.{pair.Value}");
                Assert.AreEqual($"Loan.{pair.Value}", parsedModelPath.ToString());
                var field = loan.Fields[pair.Key];
                Assert.IsFalse(field.Locked);
                field.Locked = true;
                Assert.IsTrue(field.Locked);
            }

            var fieldsWithDuplicateFieldMappings = new List<string>();
            foreach (var pair in LoanFields.FieldMappings)
            {
                if (LoanFields.FieldMappings.Values.Count(f => string.Equals(f, pair.Value)) > 1)
                {
                    fieldsWithDuplicateFieldMappings.Add(pair.Key);
                }
            }
            if (fieldsWithDuplicateFieldMappings.Count > 0)
            {
                //Assert.Fail($"Multiple fields have same field mapping {string.Join(", ", fieldsWithDuplicateFieldMappings)}");
            }
        }

        private sealed class FieldMappingComparer : IEqualityComparer<KeyValuePair<string, string>>
        {
            public bool Equals(KeyValuePair<string, string> x, KeyValuePair<string, string> y) => string.Equals(x.Value, y.Value, StringComparison.OrdinalIgnoreCase);

            public int GetHashCode(KeyValuePair<string, string> obj) => obj.Value?.GetHashCode() ?? 0;
        }

        [TestMethod]
        public void Loan_FieldsComplex()
        {
            var loan = new Loan();
            var field = loan.Fields["2181"];
            Assert.AreEqual("Loan.RateLock.BuySideAdjustments[(PriceAdjustmentType == 'BasePrice' && AdjustmentType == 'Adjustment')][10].Rate", field.ModelPath);
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            var value = 1;
            field.Value = value;
            Assert.AreEqual(value, (decimal?)field.Value);
            Assert.AreEqual(value, field.ToDecimal());
            Assert.AreEqual(value, field.ToInt32());
            Assert.AreEqual(value.ToString(), field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(@"{""rateLock"":{""buySideAdjustments"":[{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice"",""rate"":1.0}]}}", loan.ToJson());
            field.Value = 2.5M;
            Assert.AreEqual(@"{""rateLock"":{""buySideAdjustments"":[{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice"",""rate"":2.5}]}}", loan.ToJson());
            loan.Dirty = false;
            Assert.AreEqual("{}", loan.ToJson());
            field.Value = 3.25;
            Assert.AreEqual(@"{""rateLock"":{""buySideAdjustments"":[{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice""},{""adjustmentType"":""Adjustment"",""priceAdjustmentType"":""BasePrice"",""rate"":3.25}]}}", loan.ToJson());
        }
    }
}