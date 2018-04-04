using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EncompassRest.Filters;
using EncompassRest.LoanPipeline;
using EncompassRest.Loans;
using EncompassRest.Loans.Enums;
using EncompassRest.Utilities;
using EnumsNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

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
            foreach (var fieldId in LoanFields.FieldMappings.FieldIds)
            {
                var loan = new Loan();
                var field = loan.Fields[fieldId];
                Assert.IsNull(field.Value);
                Assert.IsTrue(field.IsEmpty);
                switch (field.Type)
                {
                    case LoanFieldType.Standard:
                        switch (field.ValueType)
                        {
                            case LoanFieldValueType.String:
                                var str = "abc";
                                field.Value = str;
                                Assert.AreEqual(str, (string)field.Value);
                                Assert.AreEqual(str, field.ToString());
                                break;
                            case LoanFieldValueType.DateTime:
                                var now = DateTime.Now;
                                field.Value = now;
                                Assert.AreEqual(now, (DateTime?)field.Value);
                                Assert.AreEqual(now, field.ToDateTime());
                                break;
                            case LoanFieldValueType.Decimal:
                                var d = 12.5M;
                                field.Value = d;
                                Assert.AreEqual(d, (decimal?)field.Value);
                                Assert.AreEqual(d, field.ToDecimal());
                                break;
                            case LoanFieldValueType.Int32:
                                var i = 6;
                                field.Value = i;
                                Assert.AreEqual(i, (int?)field.Value);
                                Assert.AreEqual(i, field.ToInt32());
                                break;
                            case LoanFieldValueType.Boolean:
                                var b = true;
                                field.Value = b;
                                Assert.AreEqual(b, (bool?)field.Value);
                                Assert.AreEqual(b, field.ToBoolean());
                                break;
                            case LoanFieldValueType.NADecimal:
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
                        break;
                    case LoanFieldType.Virtual:
                        var value = "Processing";

                        Assert.ThrowsException<InvalidOperationException>(() => field.Value = value);

                        loan.VirtualFields[field.FieldId] = value;
                        Assert.IsFalse(field.IsEmpty);
                        Assert.AreEqual(value, (string)field.Value);
                        Assert.AreEqual(value, field.ToString());
                        Assert.AreEqual($@"{{""virtualFields"":{{""{field.FieldId}"":""{value}""}}}}", loan.ToJson());

                        Assert.ThrowsException<InvalidOperationException>(() => field.Value = null);

                        loan.VirtualFields[field.FieldId] = null;
                        Assert.IsTrue(field.IsEmpty);
                        Assert.IsNull(field.Value);
                        Assert.AreEqual($@"{{""virtualFields"":{{""{field.FieldId}"":null}}}}", loan.ToJson());
                        break;
                    default:
                        Assert.Fail($"Invalid LoanFieldType of {field.Type}");
                        break;
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

            field.Value = "Y";
            Assert.AreEqual(true, (bool?)field.Value);
            Assert.AreEqual(true, field.ToBoolean());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""borrowerCoBorrowerMarriedIndicator"":true}}", loan.ToJson());
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
        public void Loan_FieldsSimpleLocking()
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
        public async Task Loan_FieldsLocking()
        {
            var loan = new Loan();
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanAsync(loan);

            try
            {
                var distinctFieldMappings = LoanFields.FieldMappings._dictionary.Distinct(new FieldMappingComparer()).ToDictionary(p => p.Key, p => p.Value, StringComparer.OrdinalIgnoreCase);
                foreach (var pair in distinctFieldMappings)
                {
                    var field = loan.Fields[pair.Key];
                    Assert.AreEqual(pair.Value.ToString(), field.ModelPath);
                    if (field.Type != LoanFieldType.Virtual)
                    {
                        Assert.IsFalse(field.Locked);
                        field.Locked = true;
                        Assert.IsTrue(field.Locked);
                    }
                }

                await client.Loans.UpdateLoanAsync(loan);
                
                loan = await client.Loans.GetLoanAsync(loanId, new[] { LoanEntity.FieldLockData });

                var failedLockingFields = new List<string>();
                foreach (var pair in distinctFieldMappings)
                {
                    var field = loan.Fields[pair.Key];
                    if (field.Type != LoanFieldType.Virtual)
                    {
                        if (!field.Locked)
                        {
                            failedLockingFields.Add(field.FieldId);
                        }
                    }
                }

                var fieldsUnableToLock = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "4177", "4175", "4174", "4178", "NEWHUD.X720", "NEWHUD2.X3728", "NEWHUD2.X3761", "NEWHUD2.X3794", "NEWHUD2.X3530", "NEWHUD2.X3563", "NEWHUD2.X3596", "NEWHUD2.X3629", "NEWHUD2.X3695", "NEWHUD2.X3662", "NEWHUD2.X3365", "NEWHUD2.X3332", "NEWHUD2.X3398", "NEWHUD2.X3431", "NEWHUD2.X3464", "NEWHUD2.X3497", "NEWHUD2.X3167", "NEWHUD2.X3134", "NEWHUD2.X3101", "NEWHUD2.X3266", "NEWHUD2.X3233", "NEWHUD2.X3200", "NEWHUD2.X3299", "NEWHUD2.X3068", "NEWHUD2.X3035", "NEWHUD2.X3002", "CD1.X52", "CD1.X53", "CD1.X54", "CD1.X55", "CD1.X56", "CD1.X57", "CD1.X58", "CD1.X59", "CD1.X67", "CD1.X66", "CD1.X68", "NEWHUD.X13", "NEWHUD2.X3992", "NEWHUD2.X3959", "NEWHUD2.X3926", "1417", "1416", "1419", "1418", "NEWHUD2.X3893", "NEWHUD2.X3860", "NEWHUD2.X3827", "1519", "1522", "1521", "1520", "NMLS.X4", "MORNET.X68", "NEWHUD2.X2705", "NEWHUD2.X2738", "NEWHUD2.X2771", "NEWHUD2.X2606", "NEWHUD2.X2639", "NEWHUD2.X2672", "NEWHUD2.X2507", "NEWHUD2.X2573", "NEWHUD2.X2540", "NEWHUD2.X2408", "NEWHUD2.X2441", "NEWHUD2.X2474", "NEWHUD2.X2342", "NEWHUD2.X2375", "NEWHUD2.X2309", "NEWHUD2.X2243", "NEWHUD2.X2276", "NEWHUD2.X2210", "NEWHUD2.X2177", "NEWHUD2.X2144", "NEWHUD2.X2111", "NEWHUD2.X2045", "NEWHUD2.X2078", "NEWHUD2.X2012", "NEWHUD2.X2969", "NEWHUD2.X2936", "NEWHUD2.X2903", "NEWHUD2.X2870", "NEWHUD2.X2804", "NEWHUD2.X2837", "NEWHUD2.X2832", "NEWHUD2.X1517", "NEWHUD2.X1550", "NEWHUD2.X1583", "NEWHUD2.X1715", "NEWHUD2.X1748", "NEWHUD2.X1781", "NEWHUD2.X1418", "NEWHUD2.X1451", "NEWHUD2.X1484", "NEWHUD2.X1154", "NEWHUD2.X1121", "NEWHUD2.X1187", "NEWHUD2.X1616", "NEWHUD2.X1649", "NEWHUD2.X1682", "NEWHUD2.X1352", "NEWHUD2.X1319", "NEWHUD2.X1385", "NEWHUD2.X1055", "NEWHUD2.X1022", "NEWHUD2.X1088", "NEWHUD2.X1253", "NEWHUD2.X1220", "NEWHUD2.X1286", "NEWHUD2.X1946", "NEWHUD2.X1979", "NEWHUD2.X1913", "NEWHUD2.X428", "NEWHUD2.X461", "NEWHUD2.X494", "NEWHUD2.X626", "NEWHUD2.X659", "NEWHUD2.X692", "NEWHUD2.X1880", "NEWHUD2.X1847", "NEWHUD2.X1814", "NEWHUD2.X527", "NEWHUD2.X593", "NEWHUD2.X560", "NEWHUD2.X725", "NEWHUD2.X758", "NEWHUD2.X791", "NEWHUD2.X263", "NEWHUD2.X230", "NEWHUD2.X296", "FE0204", "FE0205", "FE0206", "FE0207", "FE0202", "FE0203", "FE0209", "FE0215", "FE0217", "FE0216", "FE0210", "FE0213", "FE0233", "FE0299", "FE0298", "NEWHUD2.X362", "NEWHUD2.X329", "NEWHUD2.X395", "FE0133", "FE0107", "FE0106", "FE0105", "FE0104", "FE0103", "FE0102", "FE0109", "FE0116", "FE0117", "FE0115", "FE0113", "FE0110", "FE0198", "FE0199", "181", "NEWHUD2.X890", "NEWHUD2.X857", "NEWHUD2.X824", "334", "NEWHUD2.X989", "NEWHUD2.X956", "NEWHUD2.X4124", "NEWHUD2.X4157", "NEWHUD2.X4190", "NEWHUD2.X4025", "NEWHUD2.X4058", "NEWHUD2.X4091", "NEWHUD2.X4322", "NEWHUD2.X4355", "NEWHUD2.X4388", "NEWHUD2.X4223", "NEWHUD2.X4256", "NEWHUD2.X4289", "FR0104", "FR0106", "FR0107", "FR0108", "FR0124", "FR0112", "FR0115", "FR0199", "FR0198", "NEWHUD2.X4540", "NEWHUD2.X4573", "NEWHUD2.X4507", "FR0224", "FR0207", "FR0206", "FR0204", "FR0208", "FR0212", "FR0215", "FR0298", "FR0299", "NEWHUD2.X4474", "FR0324", "FR0306", "FR0307", "FR0304", "FR0308", "FR0312", "FR0315", "RE88395.X316", "FR0399", "FR0398", "FR0404", "FR0407", "FR0406", "FR0408", "FR0415", "FR0412", "FR0424", "FR0498", "FR0499", "NEWHUD2.X4606", "FR0504", "FR0506", "FR0507", "FR0508", "FR0524", "FR0515", "FR0512", "FR0599", "FR0598", "FR0624", "FR0607", "FR0606", "FR0604", "FR0608", "FR0615", "FR0612", "LE1.X83", "LE1.X82", "LE1.X81", "LE1.X80", "LE1.X84", "FR0698", "FR0699", "LE1.X78", "LE1.X79" };

                var fieldsThatCanNowBeLocked = fieldsUnableToLock.Except(failedLockingFields).ToList();
                if (fieldsThatCanNowBeLocked.Count > 0)
                {
                    Console.WriteLine($"Can now lock the following fields {string.Join(", ", fieldsThatCanNowBeLocked)}");
                }
                var fieldsThatShouldBeAbleToLock = failedLockingFields.Except(fieldsUnableToLock).ToList();
                if (fieldsThatShouldBeAbleToLock.Count > 0)
                {
                    Assert.Fail($"Failed to lock {failedLockingFields.Count} fields {string.Join(", ", fieldsThatShouldBeAbleToLock)}");
                }
            }
            finally
            {
                try
                {
                    await client.Loans.DeleteLoanAsync(loanId);
                }
                catch
                {
                }
            }
        }

        [TestMethod]
        public async Task Loan_FieldPatternsLocking()
        {
            var loan = new Loan();
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanAsync(loan);

            try
            {
                const int patternCount = 10;
                var fieldPatternMappings = LoanFields.FieldPatternMappings.Where(p => !p.Key.StartsWith("TQL4506T") && !p.Key.StartsWith("LP")).ToList();
                foreach (var pair in fieldPatternMappings)
                {
                    var fieldPattern = pair.Key;
                    for (var i = 1; i <= patternCount; ++i)
                    {
                        var field = loan.Fields[string.Format(fieldPattern, i)];
                        Assert.AreEqual(string.Format(pair.Value, i), field.ModelPath);
                        if (field.Type != LoanFieldType.Virtual)
                        {
                            Assert.IsFalse(field.Locked);
                            field.Locked = true;
                            Assert.IsTrue(field.Locked);
                        }
                    }
                }

                await client.Loans.UpdateLoanAsync(loan);

                loan = await client.Loans.GetLoanAsync(loanId, new[] { LoanEntity.FieldLockData });

                var failedLockingFields = new List<string>();
                foreach (var pair in fieldPatternMappings)
                {
                    var fieldPattern = pair.Key;
                    for (var i = 1; i <= patternCount; ++i)
                    {
                        var field = loan.Fields[string.Format(fieldPattern, i)];
                        if (field.Type != LoanFieldType.Virtual)
                        {
                            if (!field.Locked)
                            {
                                failedLockingFields.Add(field.FieldId);
                            }
                        }
                    }
                }

                if (failedLockingFields.Count > 0)
                {
                    Assert.Fail($"Failed to lock {failedLockingFields.Count} fields {string.Join(", ", failedLockingFields)}");
                }
            }
            finally
            {
                try
                {
                    await client.Loans.DeleteLoanAsync(loanId);
                }
                catch
                {
                }
            }
        }

        private sealed class FieldMappingComparer : IEqualityComparer<KeyValuePair<string, ModelPath>>
        {
            public bool Equals(KeyValuePair<string, ModelPath> x, KeyValuePair<string, ModelPath> y) => x.Value.Equals(y.Value);

            public int GetHashCode(KeyValuePair<string, ModelPath> obj) => obj.Value?.GetHashCode() ?? 0;
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

        [TestMethod]
        public void Loan_FieldsZeroBased()
        {
            var loan = new Loan();
            var field = loan.Fields["3669"];
            Assert.AreEqual("Loan.MilestoneTemplateLogs[0].IsTemplateLocked", field.ModelPath);
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            var value = true;
            field.Value = value;
            Assert.AreEqual(value, (bool?)field.Value);
            Assert.AreEqual(value, field.ToBoolean());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(@"{""milestoneTemplateLogs"":[{""isTemplateLocked"":true}]}", loan.ToJson());

            field.Value = null;
            Assert.AreEqual(null, (bool?)field.Value);
            Assert.AreEqual(null, field.ToBoolean());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""milestoneTemplateLogs"":[{""isTemplateLocked"":null}]}", loan.ToJson());

            Assert.IsFalse(field.Locked);
            field.Locked = true;
            Assert.IsTrue(field.Locked);
        }

        [TestMethod]
        public void Loan_FieldsCustomMapping()
        {
            Assert.IsTrue(LoanFields.FieldMappings.TryAdd("NEWFIELD", "Loan.NewEntity[2].Borrower.BorrowerId", false));
            var loan = new Loan();
            var field = loan.Fields["NEWFIELD"];
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual("{}", loan.ToJson());
            var intValue = 4;
            field.Value = intValue;
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(intValue, (int?)field.Value);
            Assert.AreEqual(intValue, field.ToInt32());
            Assert.AreEqual($@"{{""newEntity"":[{{}},{{""borrower"":{{""borrowerId"":{intValue}}}}}]}}", loan.ToJson());

            field.Value = null;
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            Assert.AreEqual(@"{""newEntity"":[{},{""borrower"":{""borrowerId"":null}}]}", loan.ToJson());

            loan = new Loan();
            field = loan.Fields["NEWFIELD"];
            Assert.IsFalse(field.Locked);
            field.Locked = true;
            Assert.IsTrue(field.Locked);
            Assert.AreEqual(@"{""fieldLockData"":[{""lockRemoved"":false,""modelPath"":""Loan.NewEntity[2].Borrower.BorrowerId""}]}", loan.ToJson());

            Assert.IsTrue(LoanFields.FieldMappings.TryRemove("NEWFIELD", out _));
        }

        [TestMethod]
        public void Loan_FieldsVirtualFields()
        {
            var loan = new Loan();
            var field = loan.Fields["Log.MS.CurrentMilestone"];
            Assert.AreEqual(LoanFieldType.Virtual, field.Type);
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual("{}", loan.ToJson());
            var value = "Processing";

            Assert.ThrowsException<InvalidOperationException>(() => field.Value = value);

            loan.VirtualFields["Log.MS.CurrentMilestone"] = value;
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.AreEqual($@"{{""virtualFields"":{{""Log.MS.CurrentMilestone"":""{value}""}}}}", loan.ToJson());

            Assert.ThrowsException<InvalidOperationException>(() => field.Value = null);

            loan.VirtualFields["Log.MS.CurrentMilestone"] = null;
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            Assert.AreEqual(@"{""virtualFields"":{""Log.MS.CurrentMilestone"":null}}", loan.ToJson());
        }

        [TestMethod]
        public void Loan_FieldsCustomVirtualField()
        {
            Assert.IsTrue(LoanFields.FieldMappings.TryAdd("NEW.VIRTUAL.FIELD", "Loan.VirtualFields['NEW.VIRTUAL.FIELD']", false));
            var loan = new Loan();
            var field = loan.Fields["NEW.VIRTUAL.FIELD"];
            Assert.AreEqual(LoanFieldType.Virtual, field.Type);
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual("{}", loan.ToJson());
            var value = "Processing";

            Assert.ThrowsException<InvalidOperationException>(() => field.Value = value);

            loan.VirtualFields["NEW.VIRTUAL.FIELD"] = value;
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.AreEqual($@"{{""virtualFields"":{{""NEW.VIRTUAL.FIELD"":""{value}""}}}}", loan.ToJson());

            Assert.ThrowsException<InvalidOperationException>(() => field.Value = null);

            loan.VirtualFields["NEW.VIRTUAL.FIELD"] = null;
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            Assert.AreEqual(@"{""virtualFields"":{""NEW.VIRTUAL.FIELD"":null}}", loan.ToJson());

            Assert.IsTrue(LoanFields.FieldMappings.TryRemove("NEW.VIRTUAL.FIELD", out _));
        }

        [TestMethod]
        public void Loan_FieldsVirtualFieldPattern()
        {
            var loan = new Loan();
            var field = loan.Fields["Log.MS.Date.Clear to Close"];
            Assert.AreEqual(LoanFieldType.Virtual, field.Type);
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual("{}", loan.ToJson());
            var now = DateTime.Now;
            var value = JsonConvert.ToString(now);
            value = value.Substring(1, value.Length - 2);

            Assert.ThrowsException<InvalidOperationException>(() => field.Value = value);

            loan.VirtualFields["Log.MS.Date.Clear to Close"] = value;
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.AreEqual(now, field.ToDateTime());
            Assert.AreEqual($@"{{""virtualFields"":{{""Log.MS.Date.Clear to Close"":""{value}""}}}}", loan.ToJson());

            Assert.ThrowsException<InvalidOperationException>(() => field.Value = null);

            loan.VirtualFields["Log.MS.Date.Clear to Close"] = null;
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            Assert.AreEqual(@"{""virtualFields"":{""Log.MS.Date.Clear to Close"":null}}", loan.ToJson());
        }

        [TestMethod]
        public async Task Loan_NoExtensionData()
        {
            var client = await GetTestClientAsync().ConfigureAwait(false);
            var list = await client.Pipeline.ViewPipelineAsync(new PipelineParameters(new StringFieldFilter(CanonicalLoanField.LoanFolder, StringFieldMatchType.Exact, "IncludeAllFolders", false)), 200).ConfigureAwait(false);
            var tasks = new List<Task>();
            foreach (var item in list)
            {
                tasks.Add(client.Loans.GetLoanAsync(item.LoanGuid).ContinueWith(async task =>
                {
                    var loan = await task.ConfigureAwait(false);
                    var fails = new List<string>();
                    TestForExtensionData(loan, new List<string> { "Loan" }, fails);
                    Assert.AreEqual(0, fails.Count, $@"{loan.EncompassId} has the following extension data.
{string.Join(Environment.NewLine, fails)}");
                }));
            }
            await Task.WhenAll(tasks).ConfigureAwait(false);
        }

        private void TestForExtensionData(ExtensibleObject value, List<string> path, List<string> fails)
        {
            if (value.ExtensionData.Count > 0)
            {
                fails.Add($"{string.Concat(path)}: {JsonConvert.SerializeObject(new Dictionary<string, object>(value.ExtensionData))}");
            }
            var type = value.GetType();
            var contract = JsonHelper.InternalPrivateContractResolver.ResolveContract(type);
            switch (contract)
            {
                case JsonObjectContract jsonObjectContract:
                    foreach (var property in jsonObjectContract.Properties)
                    {
                        var propertyUnderlyingName = property.UnderlyingName;
                        var propertyValue = property.ValueProvider.GetValue(value);
                        if (propertyValue != null)
                        {
                            switch (propertyValue)
                            {
                                case ExtensibleObject extensibleObject:
                                    path.Add($".{propertyUnderlyingName}");
                                    TestForExtensionData(extensibleObject, path, fails);
                                    path.RemoveAt(path.Count - 1);
                                    break;
                                case IList list:
                                    var i = 0;
                                    foreach (var element in list)
                                    {
                                        if (element is ExtensibleObject extObj)
                                        {
                                            path.Add($".{propertyUnderlyingName}[{i}]");
                                            TestForExtensionData(extObj, path, fails);
                                            path.RemoveAt(path.Count - 1);
                                        }
                                        ++i;
                                    }
                                    break;
                            }
                        }
                    }
                    break;
            }
        }
    }
}