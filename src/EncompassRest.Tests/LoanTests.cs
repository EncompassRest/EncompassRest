using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection;
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

namespace EncompassRest.Tests
{
    [TestClass]
    public class LoanTests : TestBaseClass
    {
        [TestMethod]
        [ApiTest]
        public async Task Loan_GetSupportedEntities()
        {
            var client = await GetTestClientAsync();
            var supportedEntities = await client.Loans.GetSupportedEntitiesAsync();
            AssertNoUndefinedEnumOptions(supportedEntities, "SupportedEntities", new Dictionary<Type, HashSet<string>> { { typeof(LoanEntity), new HashSet<string>(new[] { "CoBorrower", "LOCompensation", "GffVAlertTriggerFieldLog", "ConditionLog", "EntityRef" }, StringComparer.OrdinalIgnoreCase) } });
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_PublicSerialization()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var serializerSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, Formatting = Formatting.Indented };
            Assert.AreEqual("{}", JsonConvert.SerializeObject(loan, serializerSettings));
            loan.ExtensionData.Add("dog", true);
            Assert.AreEqual(@"{""dog"":true}", loan.ToString(SerializationOptions.Dirty));
            Assert.AreEqual(@"{
  ""dog"": true
}", JsonConvert.SerializeObject(loan, serializerSettings));
            loan.Dirty = false;
            Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
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
            
            var loanId = await client.Loans.CreateLoanAsync(loan, true);
            Assert.IsNotNull(loanId);

            try
            {
                Assert.AreEqual(loanId, loan.EncompassId);
                var json = JsonConvert.SerializeObject(loan, serializerSettings);
                var deserializedLoan = JsonConvert.DeserializeObject<Loan>(json, serializerSettings);
                var newJson = JsonConvert.SerializeObject(loan, serializerSettings);
                Assert.AreEqual(json, newJson);
            }
            finally
            {
                try
                {
                    await Task.Delay(5000);
                    await client.Loans.DeleteLoanAsync(loanId);
                }
                catch
                {
                }
            }
        }

        [TestMethod]
        public void Loan_ToString()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            Assert.AreEqual("{}", loan.ToString());
            loan.BaseLoanAmount = 123456.78M;
            Assert.AreEqual(@"{""baseLoanAmount"":123456.78}", loan.ToString());
            Assert.AreEqual(@"{
  ""baseLoanAmount"": 123456.78
}", loan.ToString(SerializationOptions.Indent));
            loan.BaseLoanAmount = null;
            Assert.AreEqual("{}", loan.ToString());
            loan.ExtensionData.Add("dog", true);
            Assert.AreEqual(@"{
  ""dog"": true
}", loan.ToString(SerializationOptions.Indent));
            loan.CustomFields.Add(new CustomField { FieldName = "CX.TEMP", StringValue = "TempValue" });
            Assert.AreEqual(@"{
  ""customFields"": [
    {
      ""fieldName"": ""CX.TEMP"",
      ""stringValue"": ""TempValue""
    }
  ],
  ""dog"": true
}", loan.ToString(SerializationOptions.Indent));
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_Clone()
        {
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanAsync(new Loan(client));
            try
            {
                await Task.Delay(5000);
                var loan = await client.Loans.GetLoanAsync(loanId);
                loan.Fees.First(f => f.FeeType == "TitleExamination").NewHUDBorPaidAmount = 0.0M; // Required due to issue with number of decimals serialized
                var clonedLoan = loan.Clone();
                var loanAsJson = loan.ToString(SerializationOptions.Indent);
                var clonedLoanAsJson = clonedLoan.ToString(SerializationOptions.Indent);
                Assert.AreEqual(loanAsJson, clonedLoanAsJson);
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
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_NonNullProperty_Serialization()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan
            {
                Tltv = 85.00M
            };
#pragma warning restore CS0618 // Type or member is obsolete
            Assert.AreEqual(@"{""tltv"":85.00}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_NullProperty_Serialization()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan
            {
                Tltv = null
            };
#pragma warning restore CS0618 // Type or member is obsolete
            Assert.AreEqual(@"{""tltv"":null}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_CustomFields_Serialization()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var customField = new CustomField { FieldName = "CUST91FV", StringValue = "Initial Value" };
            loan.CustomFields.Add(customField);
            loan.CustomFields.Add(new CustomField { FieldName = "CUST92FV", NumericValue = 10.0M });
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CUST91FV"",""stringValue"":""Initial Value""},{""fieldName"":""CUST92FV"",""numericValue"":10.0}]}", loan.ToString(SerializationOptions.Dirty));
            loan.Dirty = false;
            Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
            customField.StringValue = "New Value";
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CUST91FV"",""stringValue"":""New Value""}]}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_ExtensionData_Serialization()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
            const string boolPropertyName = "boolProperty";
            loan.ExtensionData[boolPropertyName] = true;
            Assert.AreEqual(1, loan.ExtensionData.Count);
            Assert.IsTrue(loan.ExtensionData.ContainsKey(boolPropertyName));
            Assert.AreEqual(true, (bool)loan.ExtensionData[boolPropertyName]);
            Assert.AreEqual($@"{{""{boolPropertyName}"":true}}", loan.ToString(SerializationOptions.Dirty));
            loan.Dirty = false;
            Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
            const string decimalPropertyName = "decimalProperty";
            loan.ExtensionData[decimalPropertyName] = 10.5M;
            Assert.AreEqual(2, loan.ExtensionData.Count);
            Assert.IsTrue(loan.ExtensionData.ContainsKey(boolPropertyName));
            Assert.IsTrue(loan.ExtensionData.ContainsKey(decimalPropertyName));
            Assert.AreEqual(true, (bool)loan.ExtensionData[boolPropertyName]);
            Assert.AreEqual(10.5M, (decimal)loan.ExtensionData[decimalPropertyName]);
            Assert.AreEqual($@"{{""{decimalPropertyName}"":10.5}}", loan.ToString(SerializationOptions.Dirty));
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
            Assert.AreEqual($@"{{""{decimalPropertyName}"":10.5,""{stringPropertyName}"":""{stringPropertyValue}""}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_CreateAndDelete()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan, true);
            Assert.IsNotNull(loanId);
            Assert.AreEqual(loanId, loan.EncompassId);
            await Task.Delay(5000);
            await client.Loans.DeleteLoanAsync(loanId);
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_CreateRawAndDelete()
        {
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanRawAsync("{}");
            Assert.IsNotNull(loanId);
            Assert.IsFalse(loanId.StartsWith("{"));
            await Task.Delay(5000);
            await client.Loans.DeleteLoanAsync(loanId);

            var json = await client.Loans.CreateLoanRawAsync("{}", "?view=entity");
            Assert.IsNotNull(json);
            Assert.IsTrue(json.StartsWith("{"));
            var loan = JToken.Parse(json);
            loanId = loan["encompassId"].ToString();
            await Task.Delay(5000);
            await client.Loans.DeleteLoanAsync(loanId);
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_BadUpdateException()
        {
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanRawAsync("{}");
            Assert.IsNotNull(loanId);

            try
            {
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
            }
            finally
            {
                try
                {
                    await Task.Delay(5000);
                    await client.Loans.DeleteLoanAsync(loanId);
                }
                catch
                {
                }
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_GetMetadata()
        {
            var client = await GetTestClientAsync();
            if (client.AccessToken.Token == "Token")
            {
                var loan = new Loan(client);
                var loanId = await client.Loans.CreateLoanAsync(loan);
                try
                {
                    var metaData = await loan.LoanApis.GetMetadataAsync();
                    AssertNoExtensionData(metaData, "LoanMetaData", loanId, true);
                }
                finally
                {
                    try
                    {
                        await Task.Delay(5000);
                        await client.Loans.DeleteLoanAsync(loanId);
                    }
                    catch
                    {
                    }
                }
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_CreateInLoanFolder()
        {
            var client = await GetTestClientAsync();
            if (client.AccessToken.Token == "Token")
            {
                var loan = new Loan(client);
                var loanId = await client.Loans.CreateLoanAsync(loan, new CreateLoanOptions { LoanFolder = "My Pipeline" });
                try
                {
                    var metaData = await loan.LoanApis.GetMetadataAsync();
                    Assert.AreEqual("My Pipeline", metaData.LoanFolder);
                    //await client.LoanFolders.MoveLoanToFolderAsync(loanId, "OAPI"); // Unauthorized error
                    //metaData = await loan.LoanApis.GetMetadataAsync();
                    //Assert.AreEqual("OAPI", metaData.LoanFolder);
                }
                finally
                {
                    try
                    {
                        await Task.Delay(5000);
                        await client.Loans.DeleteLoanAsync(loanId);
                    }
                    catch
                    {
                    }
                }
                var loan2 = new Loan(client);
                var loanId2 = await client.Loans.CreateLoanAsync(loan2, new CreateLoanOptions { LoanFolder = "OAPI" });
                try
                {
                    var metaData2 = await loan2.LoanApis.GetMetadataAsync();
                    Assert.AreEqual("OAPI", metaData2.LoanFolder);
                }
                finally
                {
                    try
                    {
                        await Task.Delay(5000);
                        await client.Loans.DeleteLoanAsync(loanId2);
                    }
                    catch
                    {
                    }
                }
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_CreateWithLoanOfficer()
        {
            var client = await GetTestClientAsync();
            if (client.AccessToken.Token == "Token")
            {
                var loan = new Loan(client);
                var loanId = await client.Loans.CreateLoanAsync(loan, new CreateLoanOptions { LoId = "officer", Populate = true });
                try
                {
                    Assert.AreEqual("officer", loan.Contacts.First(c => c.ContactType == ContactType.LOANOFFICER).LoginId);
                }
                finally
                {
                    try
                    {
                        await Task.Delay(5000);
                        await client.Loans.DeleteLoanAsync(loanId);
                    }
                    catch
                    {
                    }
                }
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_CreateWithLoanTemplate()
        {
            var client = await GetTestClientAsync();
            if (client.AccessToken.Token == "Token")
            {
                var loan = new Loan(client);
                var loanId = await client.Loans.CreateLoanAsync(loan, new CreateLoanOptions { LoanTemplate = @"Public:\\Companywide\Example Purchase Loan Template", Populate = true });
                var metaData = await loan.LoanApis.GetMetadataAsync();
                await Task.Delay(5000);
                await client.Loans.DeleteLoanAsync(loanId);
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_UpdateWithLoanTemplate()
        {
            var client = await GetTestClientAsync();
            if (client.AccessToken.Token == "Token")
            {
                var loan = new Loan(client);
                var loanId = await client.Loans.CreateLoanAsync(loan, true);
                await client.Loans.UpdateLoanAsync(loan, new UpdateLoanOptions { LoanTemplate = @"Public:\\Companywide\Example Purchase Loan Template", Populate = true });
                var metaData = await loan.LoanApis.GetMetadataAsync();
                await Task.Delay(5000);
                await client.Loans.DeleteLoanAsync(loanId);
            }
        }

        [TestMethod]
        [TestCategory("SkipWhenLiveUnitTesting")]
        public void Loan_FieldsValueAssignment()
        {
            var excludedFields = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "FE0509", "FE0609" };
            foreach (var fieldId in LoanFieldDescriptors.FieldMappings.FieldIds.Where(f => !excludedFields.Contains(f)))
            {
#pragma warning disable CS0618 // Type or member is obsolete
                var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
                var field = loan.Fields[fieldId];
                Assert.IsNull(field.Value);
                Assert.IsTrue(field.IsEmpty);
                if (!field.ReadOnly)
                {
                    switch (field.Descriptor.Type)
                    {
                        case LoanFieldType.Standard:
                            switch (field.Descriptor.ValueType)
                            {
                                case LoanFieldValueType.String:
                                    var str = "abc";
                                    field.Value = str;
                                    Assert.AreEqual(str, (string)field.Value, fieldId);
                                    Assert.AreEqual(str, field.ToString(), fieldId);
                                    break;
                                case LoanFieldValueType.DateTime:
                                    var now = DateTime.Now;
                                    field.Value = now;
                                    Assert.AreEqual(now, (DateTime?)field.Value, fieldId);
                                    Assert.AreEqual(now, field.ToDateTime(), fieldId);
                                    break;
                                case LoanFieldValueType.Decimal:
                                    var d = 12.5M;
                                    field.Value = d;
                                    Assert.AreEqual(d, (decimal?)field.Value, fieldId);
                                    Assert.AreEqual(d, field.ToDecimal(), fieldId);
                                    break;
                                case LoanFieldValueType.Int32:
                                    var i = 6;
                                    field.Value = i;
                                    Assert.AreEqual(i, (int?)field.Value, fieldId);
                                    Assert.AreEqual(i, field.ToInt32(), fieldId);
                                    break;
                                case LoanFieldValueType.Boolean:
                                    if (field.Descriptor.Options.Count > 0 && (field.FieldId.Length != 6 || !field.FieldId.StartsWith("FE") || !field.FieldId.EndsWith("09")))
                                    {
                                        foreach (var option in field.Descriptor.Options)
                                        {
                                            field.Value = option.Value;
                                            Assert.IsNotNull(field.Value, fieldId);
                                            Assert.AreEqual(option.Value, field.ToString(), fieldId);
                                        }
                                    }
                                    var b = true;
                                    field.Value = b;
                                    Assert.AreEqual(b, (bool?)field.Value, fieldId);
                                    Assert.AreEqual(b, field.ToBoolean(), fieldId);
                                    break;
                                case LoanFieldValueType.NADecimal:
                                    var n = 95.125M;
                                    field.Value = n;
                                    Assert.AreEqual(n.ToString(), (string)field.Value, fieldId);
                                    Assert.AreEqual(n.ToString(), field.ToString(), fieldId);
                                    Assert.AreEqual(n, field.ToDecimal(), fieldId);
                                    break;
                                default:
                                    Assert.Fail($"Invalid LoanFieldType for {fieldId}");
                                    break;
                            }
                            Assert.IsFalse(field.IsEmpty);
                            if (fieldId != "GUID")
                            {
                                Assert.AreNotEqual("{}", loan.ToString(SerializationOptions.Dirty));
                            }

                            loan.Dirty = false;
                            if (fieldId != "GUID")
                            {
                                Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
                            }

                            field.Value = null;
                            Assert.IsNull(field.Value);
                            Assert.IsTrue(field.IsEmpty);
                            if (fieldId != "GUID")
                            {
                                Assert.AreNotEqual("{}", loan.ToString(SerializationOptions.Dirty));
                            }
                            break;
                        case LoanFieldType.Virtual:
                            var value = "Processing";

                            Assert.ThrowsException<InvalidOperationException>(() => field.Value = value);

                            loan.VirtualFields[field.FieldId] = value;
                            Assert.IsFalse(field.IsEmpty);
                            Assert.AreEqual(value, (string)field.Value);
                            Assert.AreEqual(value, field.ToString());
                            Assert.AreEqual($@"{{""virtualFields"":{{""{field.FieldId}"":""{value}""}}}}", loan.ToString(SerializationOptions.Dirty));

                            Assert.ThrowsException<InvalidOperationException>(() => field.Value = null);

                            loan.VirtualFields[field.FieldId] = null;
                            Assert.IsTrue(field.IsEmpty);
                            Assert.IsNull(field.Value);
                            Assert.AreEqual($@"{{""virtualFields"":{{""{field.FieldId}"":null}}}}", loan.ToString(SerializationOptions.Dirty));
                            break;
                        default:
                            Assert.Fail($"Invalid LoanFieldType of {field.Descriptor.Type}");
                            break;
                    }
                }
            }
        }

        [TestMethod]
        public void Loan_FieldsAssignField()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var today = DateTime.Today;
            var field = loan.Fields["745"];
            field.Value = today;
            Assert.AreEqual(today, (DateTime?)field.Value);
            Assert.AreEqual(today, field.ToDateTime());
            var otherField = loan.Fields["3142"];
            otherField.Value = field;
            Assert.AreEqual(today, (DateTime?)otherField.Value);
            Assert.AreEqual(today, otherField.ToDateTime());
        }

        [TestMethod]
        public void Loan_FieldsString()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var loanNumber = "9876543210";
            var field = loan.Fields["364"];
            Assert.AreEqual("Loan.LoanNumber", field.ModelPath);
            field.Value = loanNumber;
            Assert.AreEqual(loanNumber, (string)field.Value);
            Assert.AreEqual(loanNumber, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""loanNumber"":""{loanNumber}""}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToString());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""loanNumber"":null}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsDateTime()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var now = DateTime.Now;
            var field = loan.Fields["CD1.X1"];
            Assert.AreEqual("Loan.ClosingCost.ClosingDisclosure1.CDDateIssued", field.ModelPath);
            field.Value = now;
            Assert.AreEqual(now, (DateTime?)field.Value);
            Assert.AreEqual(now, field.ToDateTime());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""closingCost"":{{""closingDisclosure1"":{{""cdDateIssued"":{now.ToJson()}}}}}}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToDateTime());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""closingCost"":{""closingDisclosure1"":{""cdDateIssued"":null}}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsDecimal()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var borrowerRequestedLoanAmount = 185000;
            var field = loan.Fields["1109"];
            Assert.AreEqual("Loan.BorrowerRequestedLoanAmount", field.ModelPath);
            field.Value = borrowerRequestedLoanAmount;
            Assert.AreEqual(borrowerRequestedLoanAmount, (decimal?)field.Value);
            Assert.AreEqual(borrowerRequestedLoanAmount, field.ToDecimal());
            Assert.AreEqual(borrowerRequestedLoanAmount, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""borrowerRequestedLoanAmount"":{borrowerRequestedLoanAmount}.0}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToDecimal());
            Assert.IsNull(field.ToInt32());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual($@"{{""borrowerRequestedLoanAmount"":null}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsInt()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var bltv = 75;
            var field = loan.Fields["4012"];
            Assert.AreEqual("Loan.BLTV", field.ModelPath);
            field.Value = bltv;
            Assert.AreEqual(bltv, (int?)field.Value);
            Assert.AreEqual(bltv, field.ToInt32());
            Assert.AreEqual(bltv, field.ToDecimal());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""bltv"":{bltv}}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToInt32());
            Assert.IsNull(field.ToDecimal());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual($@"{{""bltv"":null}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsBool()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var borrowerCoBorrowerMarriedIndicator = true;
            var field = loan.Fields["100"];
            Assert.AreEqual("Loan.BorrowerCoBorrowerMarriedIndicator", field.ModelPath);
            field.Value = borrowerCoBorrowerMarriedIndicator;
            Assert.AreEqual(borrowerCoBorrowerMarriedIndicator, (bool?)field.Value);
            Assert.AreEqual(borrowerCoBorrowerMarriedIndicator, field.ToBoolean());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""borrowerCoBorrowerMarriedIndicator"":{borrowerCoBorrowerMarriedIndicator.ToString().ToLower()}}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToBoolean());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual($@"{{""borrowerCoBorrowerMarriedIndicator"":null}}", loan.ToString(SerializationOptions.Dirty));

            field.Value = "Y";
            Assert.AreEqual(true, (bool?)field.Value);
            Assert.AreEqual(true, field.ToBoolean());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""borrowerCoBorrowerMarriedIndicator"":true}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsStringEnumValue()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var applicationTakenMethodType = "Internet";
            var field = loan.Fields["479"];
            Assert.AreEqual("Loan.ApplicationTakenMethodType", field.ModelPath);
            field.Value = applicationTakenMethodType;
            Assert.AreEqual(applicationTakenMethodType, (string)field.Value);
            Assert.AreEqual(applicationTakenMethodType, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(@"{""applicationTakenMethodType"":""Internet""}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToString());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""applicationTakenMethodType"":null}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsNADecimal()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var income = 4000;
            var field = loan.Fields["HMDA.X32"];
            Assert.AreEqual("Loan.Hmda.Income", field.ModelPath);
            field.Value = income;
            Assert.AreEqual(income.ToString(), (string)field.Value);
            Assert.AreEqual(income.ToString(), field.ToString());
            Assert.AreEqual(income, field.ToDecimal());
            Assert.AreEqual(income, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""hmda"":{{""income"":""{income}""}}}}", loan.ToString(SerializationOptions.Dirty));
            income = 5500;
            field.Value = income.ToString();
            Assert.AreEqual(income.ToString(), (string)field.Value);
            Assert.AreEqual(income.ToString(), field.ToString());
            Assert.AreEqual(income, field.ToDecimal());
            Assert.AreEqual(income, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""hmda"":{{""income"":""{income}""}}}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = "NA";
            Assert.AreEqual("NA", (string)field.Value);
            Assert.AreEqual("NA", field.ToString());
            Assert.IsNull(field.ToDecimal());
            Assert.IsNull(field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(@"{""hmda"":{""income"":""NA""}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToString());
            Assert.IsNull(field.ToDecimal());
            Assert.IsNull(field.ToInt32());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""hmda"":{""income"":null}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsCustomString()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var value = "ABC";
            var field = loan.Fields["CX.NAME"];
            Assert.AreEqual("Loan.CustomFields[(FieldName == 'CX.NAME')].StringValue", field.ModelPath);
            field.Value = value;
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""customFields"":[{{""fieldName"":""CX.NAME"",""stringValue"":""{value}""}}]}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToString());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CX.NAME"",""stringValue"":null}]}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsCustomDate()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var value = DateTime.Now;
            var field = loan.Fields["CX.NOW"];
            Assert.AreEqual("Loan.CustomFields[(FieldName == 'CX.NOW')].StringValue", field.ModelPath);
            field.Value = value;
            Assert.AreEqual(value, (DateTime?)field.Value);
            Assert.AreEqual(value, field.ToDateTime());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""customFields"":[{{""dateValue"":{value.ToJson()},""fieldName"":""CX.NOW""}}]}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToDateTime());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""customFields"":[{""dateValue"":null,""fieldName"":""CX.NOW""}]}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToDateTime());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""customFields"":[{""dateValue"":null,""fieldName"":""CX.NOW""}]}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsCustomNumeric()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var value = 1234.56M;
            var field = loan.Fields["CX.NUMBER"];
            Assert.AreEqual("Loan.CustomFields[(FieldName == 'CX.NUMBER')].StringValue", field.ModelPath);
            field.Value = value;
            Assert.AreEqual(value, (decimal?)field.Value);
            Assert.AreEqual(value, field.ToDecimal());
            Assert.AreEqual(1235, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""customFields"":[{{""fieldName"":""CX.NUMBER"",""numericValue"":{value}}}]}}", loan.ToString(SerializationOptions.Dirty));
            var integerValue = 98765;
            field.Value = integerValue;
            Assert.AreEqual(integerValue, (decimal?)field.Value);
            Assert.AreEqual(integerValue, field.ToDecimal());
            Assert.AreEqual(integerValue, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""customFields"":[{{""fieldName"":""CX.NUMBER"",""numericValue"":{integerValue}.0}}]}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToDecimal());
            Assert.IsNull(field.ToInt32());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CX.NUMBER"",""numericValue"":null}]}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToDecimal());
            Assert.IsNull(field.ToInt32());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CX.NUMBER"",""numericValue"":null}]}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsCUST100FV()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var value = 987.65M;
            var field = loan.Fields["CUST100FV"];
            Assert.AreEqual("Loan.CustomFields[(FieldName == 'CUST100FV')].StringValue", field.ModelPath);
            field.Value = value;
            Assert.AreEqual(value, (decimal?)field.Value);
            Assert.AreEqual(value, field.ToDecimal());
            Assert.AreEqual(988, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""customFields"":[{{""fieldName"":""CUST100FV"",""numericValue"":{value}}}]}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsLPNN126()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var field = loan.Fields["LP01126"];
            Assert.AreEqual("Loan.LoanPrograms[1].TerminationFeeAmount", field.ModelPath);
        }

        [TestMethod]
        public void Loan_FieldsBP()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var value = "Joe";
            var field = loan.Fields["4000#2"];
            Assert.IsTrue(field.Descriptor.IsBorrowerPairSpecific);
            Assert.AreEqual(1, field.BorrowerPairIndex);
            Assert.AreEqual("Loan.Applications[(ApplicationIndex == '1')].Borrower.FirstName", field.ModelPath);
            field.Value = value;
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""applications"":[{{""applicationIndex"":1,""borrower"":{{""firstName"":""{value}""}}}}]}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToString());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual($@"{{""applications"":[{{""applicationIndex"":1,""borrower"":{{""firstName"":null}}}}]}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsInvalidField()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            Assert.ThrowsException<ArgumentException>(() => loan.Fields["1"]);
        }

        [TestMethod]
        public void Loan_FieldsSimpleLocking()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var field = loan.Fields["CD1.X65"];
            Assert.AreEqual("Loan.ClosingCost.ClosingDisclosure1.Comments", field.ModelPath);
            Assert.IsFalse(field.Locked);
            field.Locked = true;
            Assert.IsTrue(field.Locked);
            Assert.AreEqual(field.ModelPath, loan.FieldLockData[0].ModelPath);
            Assert.AreEqual(false, loan.FieldLockData[0].LockRemoved);
            Assert.AreEqual($@"{{""fieldLockData"":[{{""lockRemoved"":false,""modelPath"":""{field.ModelPath}""}}]}}", loan.ToString(SerializationOptions.Dirty));
            field.Locked = false;
            Assert.IsFalse(field.Locked);
            Assert.AreEqual(field.ModelPath, loan.FieldLockData[0].ModelPath);
            Assert.AreEqual(true, loan.FieldLockData[0].LockRemoved);
            Assert.AreEqual($@"{{""fieldLockData"":[{{""lockRemoved"":true,""modelPath"":""{field.ModelPath}""}}]}}", loan.ToString(SerializationOptions.Dirty));
        }

        // Currently fails
        [TestMethod]
        [ApiTest]
        public async Task Loan_Locking_RE88395X316()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);

            try
            {
                var fields = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "RE88395.X123", "RE88395.X316" };
                foreach (var fieldId in fields)
                {
                    var field = loan.Fields[fieldId];
                    Assert.IsFalse(field.Locked);
                    field.Locked = true;
                    Assert.IsTrue(field.Locked);
                }

                Assert.AreEqual(fields.Count, loan.FieldLockData.Count);

                await client.Loans.UpdateLoanAsync(loan);

                loan = await client.Loans.GetLoanAsync(loanId, new[] { LoanEntity.FieldLockData });

                Assert.AreEqual(fields.Count, loan.FieldLockData.Count);

                foreach (var fieldId in fields)
                {
                    var field = loan.Fields[fieldId];
                    Assert.IsTrue(field.Locked);
                }
                throw new Exception("Can now lock RE88395.X316");
            }
            catch (AssertFailedException ex)
            {
                Console.WriteLine(ex.ToString());
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

        private static readonly HashSet<string> _fieldsWhereLockingCausesEncompassError = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "NEWHUD.X769", "NEWHUD.X770" };

        [TestMethod]
        [ApiTest]
        public async Task Loan_CheckKnownBadLockingFields()
        {
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanAsync(new Loan(client));

            try
            {
                foreach (var fieldId in _fieldsWhereLockingCausesEncompassError)
                {
                    await Assert.ThrowsExceptionAsync<EncompassRestException>(() =>
                    {
                        var newLoan = new Loan(client, loanId);
                        var field = newLoan.Fields[fieldId];
                        field.Locked = true;
                        Assert.IsTrue(field.Locked);
                        return client.Loans.UpdateLoanAsync(newLoan);
                    });
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
        [ApiTest]
        public async Task Loan_CheckForNewBadLockingFields()
        {
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanAsync(new Loan(client));
            var fieldsWhereLockingCausesEncompassError = new List<string>();
            var distinctFieldMappings = LoanFieldDescriptors.FieldMappings._standardFields.Distinct(new FieldMappingComparer()).ToDictionary(p => p.Key, p => p.Value, StringComparer.OrdinalIgnoreCase).Keys.Where(f => !_fieldsWhereLockingCausesEncompassError.Contains(f)).ToList();

            try
            {
                await TryFields(0, distinctFieldMappings.Count - 1);
                if (fieldsWhereLockingCausesEncompassError.Count > 0)
                {
                    Assert.Fail($"The following {fieldsWhereLockingCausesEncompassError.Count} fields cause update errors: {string.Join(", ", fieldsWhereLockingCausesEncompassError)}");
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

            async Task SplitFields(int start, int end)
            {
                if (start == end)
                {
                    fieldsWhereLockingCausesEncompassError.Add(distinctFieldMappings[start]);
                }
                else
                {
                    var mid = (end + start) / 2;

                    await TryFields(start, mid);
                    await TryFields(mid + 1, end);
                }
            }

            async Task TryFields(int start, int end)
            {
                var loan = new Loan(client, loanId);

                for (var i = start; i <= end; ++i)
                {
                    var fieldId = distinctFieldMappings[i];
                    var field = loan.Fields[fieldId];
                    Assert.IsFalse(field.Locked);
                    field.Locked = true;
                    Assert.IsTrue(field.Locked);
                }
                try
                {
                    await client.Loans.UpdateLoanAsync(loan);
                }
                catch
                {
                    await SplitFields(start, end);
                }
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_FieldsLocking()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);

            try
            {
                var distinctFieldMappings = LoanFieldDescriptors.FieldMappings._standardFields.Distinct(new FieldMappingComparer()).ToDictionary(p => p.Key, p => p.Value, StringComparer.OrdinalIgnoreCase);

                foreach (var pair in distinctFieldMappings)
                {
                    var field = loan.Fields[pair.Key];
                    Assert.AreEqual(pair.Value.ModelPath, field.ModelPath);
                    if (!_fieldsWhereLockingCausesEncompassError.Contains(field.FieldId))
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
                    if (!_fieldsWhereLockingCausesEncompassError.Contains(field.FieldId))
                    {
                        if (!field.Locked)
                        {
                            failedLockingFields.Add(field.FieldId);
                        }
                    }
                }

                var fieldsWithBadModelPaths = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "MORNET.X68", "181", "1416", "1417", "1418", "1419", "1519", "1520", "1521", "1522", "URLA.X197", "URLA.X198", "URLA.X10", "URLA.X11", "URLA.X12", "URLA.X9", "URLA.X8", "URLA.X7" };

                var fieldsUnableToLock = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "4177", "4175", "4174", "4178", "NEWHUD.X720", "NEWHUD2.X3728", "NEWHUD2.X3761", "NEWHUD2.X3794", "NEWHUD2.X3530", "NEWHUD2.X3563", "NEWHUD2.X3596", "NEWHUD2.X3629", "NEWHUD2.X3695", "NEWHUD2.X3662", "NEWHUD2.X3365", "NEWHUD2.X3332", "NEWHUD2.X3398", "NEWHUD2.X3431", "NEWHUD2.X3464", "NEWHUD2.X3497", "NEWHUD2.X3167", "NEWHUD2.X3134", "NEWHUD2.X3101", "NEWHUD2.X3266", "NEWHUD2.X3233", "NEWHUD2.X3200", "NEWHUD2.X3299", "NEWHUD2.X3068", "NEWHUD2.X3035", "NEWHUD2.X3002", "CD1.X52", "CD1.X53", "CD1.X54", "CD1.X55", "CD1.X56", "CD1.X57", "CD1.X58", "CD1.X59", "CD1.X67", "CD1.X66", "CD1.X68", "NEWHUD.X13", "NEWHUD2.X3992", "NEWHUD2.X3959", "NEWHUD2.X3926",  "NEWHUD2.X3893", "NEWHUD2.X3860", "NEWHUD2.X3827", "NMLS.X4", "NEWHUD2.X2705", "NEWHUD2.X2738", "NEWHUD2.X2771", "NEWHUD2.X2606", "NEWHUD2.X2639", "NEWHUD2.X2672", "NEWHUD2.X2507", "NEWHUD2.X2573", "NEWHUD2.X2540", "NEWHUD2.X2408", "NEWHUD2.X2441", "NEWHUD2.X2474", "NEWHUD2.X2342", "NEWHUD2.X2375", "NEWHUD2.X2309", "NEWHUD2.X2243", "NEWHUD2.X2276", "NEWHUD2.X2210", "NEWHUD2.X2177", "NEWHUD2.X2144", "NEWHUD2.X2111", "NEWHUD2.X2045", "NEWHUD2.X2078", "NEWHUD2.X2012", "NEWHUD2.X2969", "NEWHUD2.X2936", "NEWHUD2.X2903", "NEWHUD2.X2870", "NEWHUD2.X2804", "NEWHUD2.X2837", "NEWHUD2.X2832", "NEWHUD2.X1517", "NEWHUD2.X1550", "NEWHUD2.X1583", "NEWHUD2.X1715", "NEWHUD2.X1748", "NEWHUD2.X1781", "NEWHUD2.X1418", "NEWHUD2.X1451", "NEWHUD2.X1484", "NEWHUD2.X1154", "NEWHUD2.X1121", "NEWHUD2.X1187", "NEWHUD2.X1616", "NEWHUD2.X1649", "NEWHUD2.X1682", "NEWHUD2.X1352", "NEWHUD2.X1319", "NEWHUD2.X1385", "NEWHUD2.X1055", "NEWHUD2.X1022", "NEWHUD2.X1088", "NEWHUD2.X1253", "NEWHUD2.X1220", "NEWHUD2.X1286", "NEWHUD2.X1946", "NEWHUD2.X1979", "NEWHUD2.X1913", "NEWHUD2.X428", "NEWHUD2.X461", "NEWHUD2.X494", "NEWHUD2.X626", "NEWHUD2.X659", "NEWHUD2.X692", "NEWHUD2.X1880", "NEWHUD2.X1847", "NEWHUD2.X1814", "NEWHUD2.X527", "NEWHUD2.X593", "NEWHUD2.X560", "NEWHUD2.X725", "NEWHUD2.X758", "NEWHUD2.X791", "NEWHUD2.X263", "NEWHUD2.X230", "NEWHUD2.X296", "NEWHUD2.X362", "NEWHUD2.X329", "NEWHUD2.X395", "NEWHUD2.X890", "NEWHUD2.X857", "NEWHUD2.X824", "334", "NEWHUD2.X989", "NEWHUD2.X956", "NEWHUD2.X4124", "NEWHUD2.X4157", "NEWHUD2.X4190", "NEWHUD2.X4025", "NEWHUD2.X4058", "NEWHUD2.X4091", "NEWHUD2.X4322", "NEWHUD2.X4355", "NEWHUD2.X4388", "NEWHUD2.X4223", "NEWHUD2.X4256", "NEWHUD2.X4289", "NEWHUD2.X4540", "NEWHUD2.X4573", "NEWHUD2.X4507", "NEWHUD2.X4474", "NEWHUD2.X4606", "LE1.X83", "LE1.X82", "LE1.X81", "LE1.X80", "LE1.X84", "LE1.X78", "LE1.X79", "NEWHUD2.X4764", "NEWHUD2.X4765", "NEWHUD2.X4766", "NEWHUD2.X4767", "RE88395.X316", "HMDA.X117", "HMDA.X116", "HMDA.X119", "HMDA.X118", "QM.X378", "URLA.X62", "VASUMM.X132", "URLA.X269", "URLA.X268", "URLA.X267", "URLA.X270", "RE88395.X290", "RE88395.X291", "RE88395.X292", "RE88395.X293", "RE88395.X294", "RE88395.X295", "RE88395.X296", "RE88395.X297", "RE88395.X298", "RE88395.X299", "RE88395.X281", "RE88395.X280", "RE88395.X283", "RE88395.X282", "RE88395.X285", "RE88395.X284", "RE88395.X287", "RE88395.X286", "RE88395.X289", "RE88395.X288", "RE88395.X258", "RE88395.X259", "RE88395.X254", "RE88395.X255", "RE88395.X256", "RE88395.X257", "RE88395.X250", "RE88395.X251", "RE88395.X252", "RE88395.X253", "RE88395.X278", "RE88395.X279", "RE88395.X276", "RE88395.X277", "RE88395.X274", "RE88395.X275", "RE88395.X272", "RE88395.X273", "RE88395.X270", "RE88395.X271", "RE88395.X249", "RE88395.X269", "RE88395.X268", "RE88395.X267", "RE88395.X266", "RE88395.X265", "RE88395.X264", "RE88395.X263", "RE88395.X262", "RE88395.X261", "RE88395.X260", "PREQUAL.X287", "PREQUAL.X286", "PREQUAL.X285", "PREQUAL.X284", "PREQUAL.X283", "PREQUAL.X282", "PREQUAL.X281", "PREQUAL.X280", "PREQUAL.X289", "PREQUAL.X288", "PREQUAL.X296", "PREQUAL.X297", "PREQUAL.X295", "PREQUAL.X292", "PREQUAL.X293", "PREQUAL.X290", "PREQUAL.X291", "PREQUAL.X298", "PREQUAL.X299", "PREQUAL.X269", "PREQUAL.X268", "PREQUAL.X261", "PREQUAL.X260", "PREQUAL.X263", "PREQUAL.X262", "PREQUAL.X265", "PREQUAL.X264", "PREQUAL.X267", "PREQUAL.X266", "PREQUAL.X278", "PREQUAL.X279", "PREQUAL.X270", "PREQUAL.X271", "PREQUAL.X272", "PREQUAL.X273", "PREQUAL.X275", "PREQUAL.X276", "PREQUAL.X277", "PREQUAL.X243", "PREQUAL.X242", "PREQUAL.X241", "PREQUAL.X240", "PREQUAL.X244", "PREQUAL.X258", "PREQUAL.X259", "PREQUAL.X256", "PREQUAL.X257", "PREQUAL.X254", "PREQUAL.X255", "PREQUAL.X238", "PREQUAL.X239", "PREQUAL.X234", "PREQUAL.X235", "PREQUAL.X236", "PREQUAL.X237", "PREQUAL.X233", "PREQUAL.X209", "PREQUAL.X202", "PREQUAL.X210", "PREQUAL.X306", "PREQUAL.X304", "PREQUAL.X305", "PREQUAL.X302", "PREQUAL.X303", "PREQUAL.X300", "PREQUAL.X301", "USDA.X190", "USDA.X191", "USDA.X192", "USDA.X193", "USDA.X189", "USDA.X188", "USDA.X187", "1679", "1664", "1665", "1662", "1663", "3273", "3272", "3271", "3270", "3277", "3276", "3275", "3274", "3279", "3278", "3267", "3268", "3269", "1693", "1692", "1691", "1690", "1696", "1695", "1694", "1688", "1689", "1682", "1683", "1680", "1681", "1686", "1687", "1684", "1685", "3295", "3294", "3290", "3289", "3284", "3285", "3286", "3280", "3281", "3282", "3283", "3537", "3538", "3539", "3541", "3540", "VAELIG.X112", "VAELIG.X111", "VAELIG.X110", "VAELIG.X102", "VAELIG.X103", "VAELIG.X100", "VAELIG.X101", "VAELIG.X106", "VAELIG.X107", "VAELIG.X104", "VAELIG.X105", "VAELIG.X108", "VAELIG.X109", "IR0099", "POPT.X181", "POPT.X180", "POPT.X183", "POPT.X182", "POPT.X185", "POPT.X184", "POPT.X187", "POPT.X186", "POPT.X189", "POPT.X188", "POPT.X190", "POPT.X191", "POPT.X192", "POPT.X193", "POPT.X194", "POPT.X195", "POPT.X196", "POPT.X197", "POPT.X198", "POPT.X199", "POPT.X109", "POPT.X108", "POPT.X101", "POPT.X100", "POPT.X103", "POPT.X102", "POPT.X105", "POPT.X104", "POPT.X107", "POPT.X106", "POPT.X118", "POPT.X119", "POPT.X110", "POPT.X111", "POPT.X112", "POPT.X113", "POPT.X114", "POPT.X115", "POPT.X116", "POPT.X117", "POPT.X129", "POPT.X128", "POPT.X123", "POPT.X122", "POPT.X121", "POPT.X120", "POPT.X127", "POPT.X126", "POPT.X125", "POPT.X124", "POPT.X138", "POPT.X139", "POPT.X132", "POPT.X133", "POPT.X130", "POPT.X131", "POPT.X136", "POPT.X137", "POPT.X134", "POPT.X135", "POPT.X149", "POPT.X148", "POPT.X145", "POPT.X144", "POPT.X147", "POPT.X146", "POPT.X141", "POPT.X140", "POPT.X143", "POPT.X142", "POPT.X158", "POPT.X159", "POPT.X154", "POPT.X155", "POPT.X156", "POPT.X157", "POPT.X150", "POPT.X151", "POPT.X152", "POPT.X153", "POPT.X169", "POPT.X168", "POPT.X167", "POPT.X166", "POPT.X165", "POPT.X164", "POPT.X163", "POPT.X162", "POPT.X161", "POPT.X160", "POPT.X178", "POPT.X179", "POPT.X176", "POPT.X177", "POPT.X174", "POPT.X175", "POPT.X172", "POPT.X173", "POPT.X170", "POPT.X171", "FV.X30", "FV.X31", "FV.X32", "FV.X33", "FV.X34", "FV.X35", "FV.X36", "FV.X37", "FV.X38", "FV.X39", "FV.X12", "FV.X13", "FV.X10", "FV.X11", "FV.X16", "FV.X17", "FV.X14", "FV.X15", "FV.X18", "FV.X19", "FV.X21", "FV.X20", "FV.X23", "FV.X22", "FV.X25", "FV.X24", "FV.X26", "FV.X74", "FV.X75", "FV.X76", "FV.X77", "FV.X70", "FV.X71", "FV.X72", "FV.X73", "FV.X78", "FV.X79", "FV.X56", "FV.X57", "FV.X52", "FV.X50", "FV.X51", "FV.X58", "FV.X59", "FM1084.X5", "FM1084.X4", "FM1084.X6", "FM1084.X1", "FM1084.X3", "FM1084.X2", "FV.X65", "FV.X64", "FV.X67", "FV.X66", "FV.X61", "FV.X60", "FV.X63", "FV.X62", "FV.X69", "FV.X68", "FV.X47", "FV.X46", "FV.X45", "FV.X44", "FV.X43", "FV.X42", "FV.X41", "FV.X40", "FV.X49", "FV.X48", "FV.X98", "FV.X99", "FV.X92", "FV.X93", "FV.X90", "FV.X91", "FV.X96", "FV.X97", "FV.X94", "FV.X95", "FV.X89", "FV.X88", "FV.X83", "FV.X82", "FV.X81", "FV.X80", "FV.X87", "FV.X86", "FV.X85", "FV.X84", "FM1084.X169", "FM1084.X173", "FM1084.X172", "FM1084.X171", "FM1084.X170", "FM1084.X177", "FM1084.X176", "FM1084.X175", "FM1084.X174", "FM1084.X134", "POPT.X329", "POPT.X328", "POPT.X321", "POPT.X320", "POPT.X323", "POPT.X322", "POPT.X325", "POPT.X324", "POPT.X327", "POPT.X326", "POPT.X338", "POPT.X339", "POPT.X330", "POPT.X331", "POPT.X332", "POPT.X333", "POPT.X334", "POPT.X335", "POPT.X336", "POPT.X337", "POPT.X309", "POPT.X308", "POPT.X303", "POPT.X302", "POPT.X301", "POPT.X300", "POPT.X307", "POPT.X306", "POPT.X305", "POPT.X304", "POPT.X318", "POPT.X319", "POPT.X312", "POPT.X313", "POPT.X310", "POPT.X311", "POPT.X316", "POPT.X317", "POPT.X314", "POPT.X315", "POPT.X348", "POPT.X347", "POPT.X346", "POPT.X345", "POPT.X344", "POPT.X343", "POPT.X342", "POPT.X341", "POPT.X340", "POPT.X282", "POPT.X283", "POPT.X280", "POPT.X281", "POPT.X286", "POPT.X287", "POPT.X284", "POPT.X285", "POPT.X288", "POPT.X289", "POPT.X293", "POPT.X292", "POPT.X291", "POPT.X290", "POPT.X297", "POPT.X296", "POPT.X295", "POPT.X294", "POPT.X299", "POPT.X298", "POPT.X228", "POPT.X229", "POPT.X220", "POPT.X221", "POPT.X222", "POPT.X223", "POPT.X224", "POPT.X225", "POPT.X226", "POPT.X227", "POPT.X208", "POPT.X209", "POPT.X202", "POPT.X203", "POPT.X200", "POPT.X201", "POPT.X206", "POPT.X207", "POPT.X204", "POPT.X205", "POPT.X239", "POPT.X238", "POPT.X231", "POPT.X230", "POPT.X233", "POPT.X232", "POPT.X235", "POPT.X234", "POPT.X237", "POPT.X236", "POPT.X268", "POPT.X269", "POPT.X264", "POPT.X265", "POPT.X266", "POPT.X267", "POPT.X260", "POPT.X261", "POPT.X262", "POPT.X263", "POPT.X219", "POPT.X218", "POPT.X213", "POPT.X212", "POPT.X211", "POPT.X210", "POPT.X217", "POPT.X216", "POPT.X215", "POPT.X214", "POPT.X248", "POPT.X249", "POPT.X246", "POPT.X247", "POPT.X244", "POPT.X245", "POPT.X242", "POPT.X243", "POPT.X240", "POPT.X241", "POPT.X279", "POPT.X278", "POPT.X275", "POPT.X274", "POPT.X277", "POPT.X276", "POPT.X271", "POPT.X270", "POPT.X273", "POPT.X272", "POPT.X259", "POPT.X258", "POPT.X257", "POPT.X256", "POPT.X255", "POPT.X254", "POPT.X253", "POPT.X252", "POPT.X251", "POPT.X250", "VEND.X989", "VEND.X988", "VEND.X987", "VEND.X992", "VEND.X990", "VEND.X991", "1848", "1847", "VAELIG.X12", "VAELIG.X13", "VAELIG.X10", "VAELIG.X11", "VAELIG.X16", "VAELIG.X17", "VAELIG.X14", "VAELIG.X15", "VAELIG.X18", "VAELIG.X19", "VAELIG.X21", "VAELIG.X20", "VAELIG.X70", "VAELIG.X67", "VAELIG.X69", "VAELIG.X68", "VAELIG.X98", "VAELIG.X99", "GLOBAL.S3", "GLOBAL.S2", "GLOBAL.S1", "GLOBAL.S7", "GLOBAL.S6", "GLOBAL.S5", "GLOBAL.S4", "GLOBAL.S9", "GLOBAL.S8", "VEND.X381", "VEND.X380", "VEND.X383", "VEND.X382", "VEND.X385", "VEND.X384", "VEND.X387", "VEND.X386", "VEND.X389", "VEND.X388", "VEND.X390", "VEND.X391", "VEND.X392", "VEND.X393", "VEND.X394", "VEND.X395", "VEND.X349", "VEND.X348", "VEND.X345", "VEND.X344", "VEND.X347", "VEND.X346", "VEND.X341", "VEND.X343", "VEND.X342", "VEND.X358", "VEND.X359", "VEND.X354", "VEND.X355", "VEND.X356", "VEND.X357", "VEND.X350", "VEND.X351", "VEND.X352", "VEND.X353", "VEND.X369", "VEND.X367", "VEND.X366", "VEND.X365", "VEND.X364", "VEND.X363", "VEND.X362", "VEND.X361", "VEND.X360", "VEND.X378", "VEND.X379", "VEND.X376", "VEND.X377", "VEND.X374", "VEND.X375", "VEND.X372", "VEND.X373", "VEND.X370", "VEND.X371", "PTC.X271", "PTC.X270", "PTC.X273", "PTC.X272", "PTC.X275", "PTC.X274", "PTC.X277", "PTC.X276", "PTC.X279", "PTC.X278", "PTC.X260", "PTC.X261", "PTC.X262", "PTC.X263", "PTC.X264", "PTC.X265", "PTC.X266", "PTC.X267", "PTC.X268", "PTC.X269", "PTC.X253", "PTC.X252", "PTC.X251", "PTC.X250", "PTC.X257", "PTC.X256", "PTC.X255", "PTC.X254", "PTC.X259", "PTC.X258", "PTC.X242", "PTC.X243", "PTC.X240", "PTC.X241", "PTC.X246", "PTC.X247", "PTC.X244", "PTC.X245", "PTC.X248", "PTC.X249", "PTC.X235", "PTC.X234", "PTC.X237", "PTC.X236", "PTC.X231", "PTC.X230", "PTC.X233", "PTC.X232", "PTC.X239", "PTC.X238", "PTC.X224", "PTC.X225", "PTC.X226", "PTC.X227", "PTC.X220", "PTC.X221", "PTC.X222", "PTC.X223", "PTC.X228", "PTC.X229", "PTC.X217", "PTC.X216", "PTC.X215", "PTC.X214", "PTC.X213", "PTC.X212", "PTC.X211", "PTC.X210", "PTC.X219", "PTC.X218", "PTC.X206", "PTC.X207", "PTC.X204", "PTC.X205", "PTC.X202", "PTC.X203", "PTC.X200", "PTC.X201", "PTC.X208", "PTC.X209", "POPT.X91", "POPT.X90", "POPT.X93", "POPT.X92", "POPT.X95", "POPT.X94", "POPT.X97", "POPT.X96", "POPT.X99", "POPT.X98", "POPT.X80", "POPT.X81", "POPT.X82", "POPT.X83", "POPT.X84", "POPT.X85", "POPT.X86", "POPT.X87", "POPT.X88", "POPT.X89", "PTC.X299", "PTC.X298", "PTC.X297", "PTC.X296", "PTC.X295", "PTC.X294", "PTC.X293", "PTC.X292", "PTC.X291", "PTC.X290", "PTC.X288", "PTC.X289", "PTC.X286", "PTC.X287", "PTC.X284", "PTC.X285", "PTC.X282", "PTC.X283", "PTC.X280", "PTC.X281", "POPT.X19", "POPT.X18", "POPT.X11", "POPT.X10", "POPT.X13", "POPT.X12", "POPT.X15", "POPT.X14", "POPT.X17", "POPT.X16", "POPT.X39", "POPT.X38", "POPT.X33", "POPT.X32", "POPT.X31", "POPT.X30", "POPT.X37", "POPT.X36", "POPT.X35", "POPT.X34", "POPT.X28", "POPT.X29", "POPT.X22", "POPT.X23", "POPT.X20", "POPT.X21", "POPT.X26", "POPT.X27", "POPT.X24", "POPT.X25", "POPT.X59", "POPT.X58", "POPT.X55", "POPT.X54", "POPT.X57", "POPT.X56", "POPT.X51", "POPT.X50", "POPT.X53", "POPT.X52", "POPT.X48", "POPT.X49", "POPT.X44", "POPT.X45", "POPT.X46", "POPT.X47", "POPT.X40", "POPT.X41", "FV.X311", "POPT.X42", "FV.X310", "POPT.X43", "FV.X313", "FV.X312", "FV.X315", "FV.X314", "FV.X317", "FV.X316", "FV.X319", "FV.X318", "POPT.X79", "POPT.X78", "POPT.X77", "POPT.X76", "POPT.X75", "POPT.X74", "POPT.X73", "POPT.X72", "FV.X300", "POPT.X71", "FV.X301", "POPT.X70", "FV.X302", "FV.X303", "FV.X304", "FV.X305", "FV.X306", "FV.X307", "FV.X308", "FV.X309", "POPT.X68", "POPT.X69", "POPT.X66", "POPT.X67", "POPT.X64", "POPT.X65", "POPT.X62", "POPT.X63", "FV.X333", "POPT.X60", "FV.X332", "POPT.X61", "FV.X331", "FV.X330", "FV.X337", "FV.X336", "FV.X335", "FV.X334", "FV.X339", "FV.X338", "FV.X322", "FV.X323", "FV.X320", "FV.X321", "FV.X326", "FV.X327", "FV.X325", "FV.X328", "FV.X329", "FV.X355", "FV.X354", "FV.X351", "FV.X350", "FV.X353", "FV.X352", "FV.X344", "FV.X345", "FV.X346", "FV.X347", "FV.X340", "FV.X341", "FV.X342", "FV.X343", "FV.X349", "PTC.X150", "PTC.X151", "PTC.X152", "PTC.X153", "FV.X377", "PTC.X154", "PTC.X155", "PTC.X156", "PTC.X157", "FV.X373", "PTC.X158", "FV.X372", "PTC.X159", "FV.X371", "FV.X370", "FV.X379", "FV.X378", "PTC.X172", "PTC.X173", "PTC.X170", "PTC.X171", "PTC.X176", "PTC.X177", "PTC.X174", "PTC.X175", "PTC.X178", "PTC.X179", "PTC.X141", "PTC.X140", "PTC.X143", "PTC.X142", "FV.X388", "PTC.X145", "PTC.X144", "PTC.X147", "PTC.X146", "PTC.X149", "PTC.X148", "FV.X380", "FV.X381", "FV.X382", "FV.X383", "FV.X384", "PTC.X114", "PTC.X115", "PTC.X116", "PTC.X117", "PTC.X110", "PTC.X111", "PTC.X112", "PTC.X113", "PTC.X118", "PTC.X119", "PTC.X163", "PTC.X162", "PTC.X161", "PTC.X160", "PTC.X167", "PTC.X166", "PTC.X165", "PTC.X164", "PTC.X169", "PTC.X168", "CD3.X1521", "CD3.X1520", "PTC.X136", "CD3.X1523", "PTC.X137", "CD3.X1522", "PTC.X134", "CD3.X1525", "PTC.X135", "CD3.X1524", "PTC.X132", "CD3.X1527", "PTC.X133", "CD3.X1526", "PTC.X130", "CD3.X1529", "PTC.X131", "CD3.X1528", "PTC.X138", "PTC.X139", "CD3.X1530", "CD3.X1531", "PTC.X105", "CD3.X1532", "PTC.X104", "CD3.X1533", "PTC.X107", "CD3.X1534", "PTC.X106", "CD3.X1535", "PTC.X101", "CD3.X1536", "PTC.X100", "CD3.X1537", "PTC.X103", "CD3.X1538", "PTC.X102", "CD3.X1539", "PTC.X109", "PTC.X108", "CD3.X1501", "CD3.X1500", "CD3.X1507", "CD3.X1509", "CD3.X1508", "CD3.X1512", "CD3.X1513", "PTC.X127", "CD3.X1510", "PTC.X126", "CD3.X1511", "PTC.X125", "CD3.X1516", "PTC.X124", "CD3.X1517", "PTC.X123", "CD3.X1514", "PTC.X122", "CD3.X1515", "PTC.X121", "PTC.X120", "CD3.X1518", "CD3.X1519", "PTC.X129", "PTC.X128", "PTC.X198", "CD3.X1541", "PTC.X199", "CD3.X1540", "PTC.X194", "PTC.X195", "PTC.X196", "PTC.X197", "PTC.X190", "PTC.X191", "PTC.X192", "PTC.X193", "PTC.X189", "PTC.X188", "PTC.X185", "PTC.X184", "PTC.X187", "PTC.X186", "PTC.X181", "PTC.X180", "PTC.X183", "PTC.X182", "VEND.X648", "VEND.X640", "CD3.X1420", "VEND.X641", "CD3.X1421", "VEND.X642", "CD3.X1422", "VEND.X643", "CD3.X1423", "VEND.X644", "CD3.X1424", "VEND.X645", "CD3.X1425", "VEND.X646", "CD3.X1426", "VEND.X647", "CD3.X1427", "CD3.X1428", "CD3.X1429", "CD3.X1431", "CD3.X1430", "CD3.X1433", "CD3.X1432", "CD3.X1435", "CD3.X1434", "CD3.X1437", "CD3.X1436", "CD3.X1439", "CD3.X1438", "VEND.X608", "VEND.X609", "VEND.X604", "CD3.X1464", "VEND.X605", "CD3.X1465", "VEND.X606", "CD3.X1466", "VEND.X607", "CD3.X1467", "VEND.X600", "CD3.X1460", "VEND.X601", "CD3.X1461", "VEND.X602", "CD3.X1462", "VEND.X603", "CD3.X1463", "CD3.X1468", "CD3.X1469", "CD3.X1413", "CD3.X1412", "CD3.X1417", "CD3.X1416", "CD3.X1415", "CD3.X1414", "CD3.X1419", "CD3.X1418", "VEND.X628", "VEND.X629", "VEND.X626", "CD3.X1446", "VEND.X627", "CD3.X1447", "VEND.X624", "CD3.X1444", "VEND.X625", "CD3.X1445", "VEND.X622", "CD3.X1442", "VEND.X623", "CD3.X1443", "VEND.X620", "CD3.X1440", "VEND.X621", "CD3.X1441", "CD3.X1448", "CD3.X1449", "VEND.X619", "VEND.X618", "VEND.X615", "CD3.X1475", "VEND.X614", "CD3.X1474", "VEND.X617", "CD3.X1477", "VEND.X616", "CD3.X1476", "VEND.X611", "CD3.X1471", "VEND.X610", "CD3.X1470", "VEND.X613", "CD3.X1473", "VEND.X612", "CD3.X1472", "CD3.X1479", "CD3.X1478", "VEND.X639", "VEND.X638", "VEND.X637", "CD3.X1457", "VEND.X636", "CD3.X1456", "VEND.X635", "CD3.X1455", "VEND.X634", "CD3.X1454", "VEND.X633", "CD3.X1453", "VEND.X632", "CD3.X1452", "VEND.X631", "CD3.X1451", "VEND.X630", "CD3.X1450", "CD3.X1459", "CD3.X1458", "CD3.X1488", "CD3.X1489", "CD3.X1482", "CD3.X1483", "CD3.X1480", "CD3.X1481", "CD3.X1486", "CD3.X1487", "CD3.X1484", "CD3.X1485", "CD3.X1499", "CD3.X1498", "CD3.X1493", "CD3.X1492", "CD3.X1491", "CD3.X1490", "CD3.X1497", "CD3.X1496", "CD3.X1495", "CD3.X1494", "FV.X131", "FV.X130", "FV.X133", "FV.X132", "FV.X135", "FV.X134", "FV.X137", "FV.X136", "FV.X139", "FV.X138", "FV.X120", "FV.X121", "FV.X122", "FV.X123", "FV.X124", "FV.X125", "FV.X126", "FV.X127", "FV.X128", "FV.X129", "FV.X113", "FV.X112", "FV.X111", "FV.X110", "FV.X117", "FV.X116", "FV.X115", "FV.X114", "FV.X119", "FV.X118", "FV.X102", "FV.X103", "FV.X100", "FV.X101", "FV.X106", "FV.X107", "FV.X104", "FV.X105", "FV.X108", "FV.X109", "FV.X175", "FV.X174", "FV.X177", "FV.X176", "FV.X171", "FV.X170", "FV.X173", "FV.X172", "FV.X179", "FV.X178", "FV.X164", "FV.X165", "FV.X166", "FV.X167", "FV.X160", "FV.X161", "FV.X162", "FV.X163", "FV.X168", "FV.X169", "FV.X157", "FV.X156", "FV.X155", "FV.X154", "FV.X153", "FV.X152", "FV.X151", "FV.X150", "FV.X159", "FV.X158", "FV.X146", "FV.X147", "FV.X144", "FV.X145", "FV.X142", "FV.X143", "FV.X140", "FV.X141", "FV.X148", "FV.X149", "VEND.X587", "VEND.X586", "VEND.X585", "VEND.X584", "VEND.X583", "VEND.X582", "VEND.X581", "VEND.X580", "PTC.X334", "PTC.X335", "PTC.X336", "PTC.X337", "PTC.X330", "VEND.X589", "PTC.X331", "VEND.X588", "FV.X199", "PTC.X332", "FV.X198", "PTC.X333", "FV.X193", "PTC.X338", "FV.X192", "PTC.X339", "FV.X191", "FV.X190", "FV.X197", "FV.X196", "FV.X195", "FV.X194", "VEND.X596", "VEND.X597", "VEND.X594", "VEND.X595", "VEND.X592", "VEND.X593", "VEND.X590", "VEND.X591", "PTC.X343", "PTC.X342", "PTC.X341", "PTC.X340", "PTC.X347", "VEND.X598", "PTC.X346", "VEND.X599", "FV.X188", "PTC.X345", "FV.X189", "PTC.X344", "PTC.X348", "FV.X182", "FV.X183", "FV.X180", "FV.X181", "FV.X186", "FV.X187", "FV.X184", "FV.X185", "VEND.X569", "VEND.X568", "VEND.X561", "VEND.X560", "PTC.X316", "VEND.X563", "PTC.X317", "VEND.X562", "PTC.X314", "VEND.X565", "PTC.X315", "VEND.X564", "PTC.X312", "VEND.X567", "PTC.X313", "VEND.X566", "PTC.X310", "PTC.X311", "PTC.X318", "PTC.X319", "VEND.X578", "VEND.X579", "VEND.X570", "VEND.X571", "PTC.X325", "VEND.X572", "PTC.X324", "VEND.X573", "PTC.X327", "VEND.X574", "PTC.X326", "VEND.X575", "PTC.X321", "VEND.X576", "PTC.X320", "VEND.X577", "PTC.X323", "PTC.X322", "PTC.X329", "PTC.X328", "VEND.X549", "VEND.X548", "VEND.X543", "VEND.X542", "VEND.X541", "VEND.X540", "VEND.X547", "VEND.X546", "VEND.X545", "VEND.X544", "VEND.X558", "VEND.X559", "VEND.X552", "VEND.X553", "PTC.X307", "VEND.X550", "PTC.X306", "VEND.X551", "PTC.X305", "VEND.X556", "PTC.X304", "VEND.X557", "PTC.X303", "VEND.X554", "PTC.X302", "VEND.X555", "PTC.X301", "PTC.X300", "PTC.X309", "PTC.X308", "VEND.X529", "VEND.X538", "VEND.X539", "VEND.X534", "VEND.X535", "VEND.X536", "VEND.X537", "VEND.X530", "VEND.X531", "VEND.X532", "VEND.X533", "CD3.X1326", "CD3.X1325", "CD3.X1324", "FV.X210", "FV.X211", "FV.X212", "FV.X213", "FV.X218", "FV.X219", "FV.X232", "FV.X233", "FV.X230", "FV.X231", "FV.X236", "FV.X237", "FV.X234", "FV.X235", "FV.X238", "FV.X239", "FV.X201", "FV.X200", "FV.X203", "FV.X202", "FV.X205", "FV.X204", "FV.X207", "FV.X206", "FV.X209", "FV.X208", "FV.X254", "FV.X255", "FV.X256", "FV.X257", "FV.X250", "FV.X251", "FV.X252", "FV.X253", "FV.X258", "FV.X259", "FV.X223", "FV.X221", "FV.X220", "FV.X227", "FV.X226", "FV.X225", "FV.X224", "FV.X229", "FV.X228", "FV.X276", "FV.X277", "FV.X274", "FV.X275", "FV.X272", "FV.X273", "FV.X270", "FV.X271", "FV.X278", "FV.X279", "FV.X245", "FV.X244", "FV.X247", "FV.X246", "FV.X241", "FV.X240", "FV.X243", "FV.X242", "FV.X249", "FV.X248", "FV.X298", "FV.X299", "FV.X290", "FV.X291", "FV.X292", "FV.X293", "FV.X294", "FV.X295", "FV.X296", "FV.X297", "FV.X267", "FV.X266", "FV.X265", "FV.X264", "FV.X263", "FV.X262", "FV.X261", "FV.X260", "FV.X269", "FV.X268", "VEND.X486", "VEND.X487", "VEND.X484", "VEND.X485", "VEND.X482", "VEND.X483", "VEND.X480", "VEND.X481", "FV.X289", "FV.X288", "FV.X281", "FV.X280", "FV.X283", "FV.X282", "FV.X285", "FV.X284", "FV.X287", "FV.X286", "VEND.X468", "VEND.X469", "VEND.X460", "VEND.X461", "VEND.X462", "VEND.X463", "VEND.X464", "VEND.X465", "VEND.X466", "VEND.X467", "VEND.X479", "VEND.X478", "VEND.X471", "VEND.X470", "VEND.X473", "VEND.X472", "VEND.X475", "VEND.X474", "VEND.X477", "VEND.X476", "CD3.X1204", "CD3.X1205", "CD3.X1206", "CD3.X1207", "CD3.X1200", "CD3.X1201", "CD3.X1202", "CD3.X1203", "CD3.X1208", "CD3.X1209", "VEND.X459", "VEND.X458", "VEND.X457", "VEND.X456", "VEND.X455", "CD3.X1225", "CD3.X1222", "CD3.X1220", "CD3.X1221", "CD3.X1228", "CD3.X1215", "CD3.X1214", "CD3.X1217", "CD3.X1216", "CD3.X1211", "CD3.X1210", "CD3.X1213", "CD3.X1212", "CD3.X1219", "CD3.X1218", "VAELIG.X3", "VAELIG.X2", "CD3.X1236", "VAELIG.X7", "CD3.X1235", "VAELIG.X6", "CD3.X1234", "VAELIG.X5", "VAELIG.X4", "CD3.X1231", "VAELIG.X9", "VAELIG.X8", "VAELIG.S2", "VAELIG.S3", "VAELIG.S4", "VAELIG.S5", "NEWHUD.X716", "NEWHUD.X727", "NEWHUD.X726", "NEWHUD.X729", "NEWHUD.X728", "NEWHUD.X736", "NEWHUD.X737", "NEWHUD.X734", "NEWHUD.X735", "NEWHUD.X738", "NEWHUD.X739", "NEWHUD.X740", "NEWHUD.X789", "NEWHUD.X790", "NEWHUD.X791", "CD3.X1171", "CD3.X1144", "CD3.X1117", "CD3.X1198", "CD3.X1199", "CD3.X1196", "CD3.X1197", "NEWHUD.X644", "NEWHUD.X642", "NEWHUD.X643", "NEWHUD.X633", "NEWHUD.X632", "NEWHUD.X631", "NEWHUD.X637", "NEWHUD.X636", "NEWHUD.X635", "NEWHUD.X634", "NEWHUD.X638", "NEWHUD.X654", "NEWHUD.X653", "NEWHUD.X680", "NEWHUD.X681", "NEWHUD.X682", "NEWHUD.X683", "NEWHUD.X684", "NEWHUD.X685", "NEWHUD.X677", "NEWHUD.X676", "NEWHUD.X675", "NEWHUD.X674", "NEWHUD.X679", "NEWHUD.X678", "CD3.X1060", "CD3.X1061", "CD3.X1062", "CD3.X1063", "CD3.X1064", "CD3.X1065", "CD3.X1066", "CD3.X1067", "CD3.X1068", "CD3.X1069", "CD3.X1042", "CD3.X1043", "CD3.X1040", "CD3.X1041", "CD3.X1044", "CD3.X1045", "CD3.X1048", "CD3.X1049", "CD3.X1071", "CD3.X1070", "CD3.X1073", "CD3.X1072", "CD3.X1075", "CD3.X1074", "CD3.X1077", "CD3.X1076", "CD3.X1079", "CD3.X1078", "CD3.X1024", "CD3.X1025", "CD3.X1026", "CD3.X1027", "CD3.X1020", "CD3.X1021", "CD3.X1022", "CD3.X1023", "CD3.X1028", "CD3.X1029", "CD3.X1053", "CD3.X1052", "CD3.X1051", "CD3.X1050", "CD3.X1057", "CD3.X1056", "CD3.X1055", "CD3.X1054", "CD3.X1059", "CD3.X1058", "CD3.X1006", "CD3.X1007", "CD3.X1004", "CD3.X1005", "CD3.X1002", "CD3.X1003", "CD3.X1000", "CD3.X1001", "CD3.X1008", "CD3.X1009", "CD3.X1035", "CD3.X1034", "CD3.X1037", "CD3.X1036", "CD3.X1031", "CD3.X1030", "CD3.X1033", "CD3.X1032", "CD3.X1039", "CD3.X1038", "CD3.X1017", "CD3.X1016", "CD3.X1015", "CD3.X1014", "CD3.X1013", "CD3.X1012", "CD3.X1011", "CD3.X1010", "CD3.X1019", "CD3.X1018", "CD3.X1086", "CD3.X1087", "CD3.X1084", "CD3.X1085", "CD3.X1082", "CD3.X1083", "CD3.X1080", "CD3.X1081", "CD3.X1090", "NEWHUD.X521", "NEWHUD.X520", "NEWHUD.X503", "NEWHUD.X502", "NEWHUD.X501", "NEWHUD.X500", "NEWHUD.X507", "NEWHUD.X506", "NEWHUD.X505", "NEWHUD.X504", "NEWHUD.X509", "NEWHUD.X508", "NEWHUD.X512", "NEWHUD.X513", "NEWHUD.X510", "NEWHUD.X511", "NEWHUD.X516", "NEWHUD.X517", "NEWHUD.X514", "NEWHUD.X515", "NEWHUD.X518", "NEWHUD.X519", "NEWHUD.X564", "NEWHUD.X561", "NEWHUD.X560", "NEWHUD.X563", "NEWHUD.X562", "NEWHUD.X559", "NEWHUD.X589", "NEWHUD.X588", "NEWHUD.X587", "NEWHUD.X586", "NEWHUD.X585", "NEWHUD.X590", "NEWHUD.X420", "NEWHUD.X421", "NEWHUD.X422", "NEWHUD.X423", "NEWHUD.X424", "NEWHUD.X425", "NEWHUD.X426", "NEWHUD.X427", "NEWHUD.X428", "NEWHUD.X429", "NEWHUD.X402", "NEWHUD.X403", "NEWHUD.X401", "NEWHUD.X406", "NEWHUD.X407", "NEWHUD.X404", "NEWHUD.X405", "NEWHUD.X408", "NEWHUD.X409", "NEWHUD.X431", "NEWHUD.X430", "NEWHUD.X433", "NEWHUD.X432", "NEWHUD.X435", "PREQUAL.X8", "NEWHUD.X434", "NEWHUD.X437", "NEWHUD.X436", "NEWHUD.X439", "NEWHUD.X438", "PREQUAL.X7", "NEWHUD.X464", "NEWHUD.X465", "NEWHUD.X466", "NEWHUD.X467", "NEWHUD.X460", "NEWHUD.X461", "NEWHUD.X462", "NEWHUD.X463", "NEWHUD.X468", "NEWHUD.X469", "NEWHUD.X413", "NEWHUD.X412", "NEWHUD.X411", "NEWHUD.X410", "NEWHUD.X417", "NEWHUD.X416", "NEWHUD.X415", "NEWHUD.X414", "NEWHUD.X419", "NEWHUD.X418", "NEWHUD.X446", "NEWHUD.X447", "NEWHUD.X444", "NEWHUD.X445", "NEWHUD.X442", "NEWHUD.X443", "NEWHUD.X440", "NEWHUD.X441", "NEWHUD.X448", "NEWHUD.X449", "NEWHUD.X475", "NEWHUD.X474", "NEWHUD.X477", "NEWHUD.X476", "NEWHUD.X471", "NEWHUD.X470", "NEWHUD.X473", "NEWHUD.X472", "NEWHUD.X479", "NEWHUD.X478", "NEWHUD.X457", "NEWHUD.X456", "NEWHUD.X455", "NEWHUD.X454", "NEWHUD.X453", "NEWHUD.X452", "NEWHUD.X451", "NEWHUD.X450", "NEWHUD.X459", "NEWHUD.X458", "NEWHUD.X488", "NEWHUD.X489", "NEWHUD.X482", "NEWHUD.X483", "NEWHUD.X480", "NEWHUD.X481", "NEWHUD.X486", "NEWHUD.X487", "NEWHUD.X484", "NEWHUD.X485", "NEWHUD.X499", "NEWHUD.X498", "NEWHUD.X493", "NEWHUD.X492", "NEWHUD.X491", "NEWHUD.X490", "NEWHUD.X497", "NEWHUD.X496", "NEWHUD.X495", "NEWHUD.X494", "DISCLOSURE.X1085", "DISCLOSURE.X1084", "DISCLOSURE.X1087", "DISCLOSURE.X1086", "DISCLOSURE.X1081", "DISCLOSURE.X1083", "DISCLOSURE.X1082", "DISCLOSURE.X1089", "DISCLOSURE.X1088", "DISCLOSURE.X1094", "DISCLOSURE.X1095", "DISCLOSURE.X1096", "DISCLOSURE.X1097", "DISCLOSURE.X1090", "DISCLOSURE.X1091", "DISCLOSURE.X1092", "DISCLOSURE.X1093", "DISCLOSURE.X1098", "DISCLOSURE.X1099", "DISCLOSURE.X1049", "DISCLOSURE.X1048", "DISCLOSURE.X1041", "DISCLOSURE.X1040", "DISCLOSURE.X1043", "DISCLOSURE.X1042", "DISCLOSURE.X1045", "DISCLOSURE.X1044", "DISCLOSURE.X1047", "DISCLOSURE.X1046", "DISCLOSURE.X1058", "DISCLOSURE.X1059", "POPT2.X20", "POPT2.X21", "DISCLOSURE.X1050", "DISCLOSURE.X1051", "DISCLOSURE.X1052", "DISCLOSURE.X1053", "DISCLOSURE.X1054", "DISCLOSURE.X1055", "DISCLOSURE.X1056", "DISCLOSURE.X1057", "DISCLOSURE.X1063", "DISCLOSURE.X1062", "DISCLOSURE.X1061", "DISCLOSURE.X1060", "DISCLOSURE.X1078", "DISCLOSURE.X1079", "DISCLOSURE.X1076", "DISCLOSURE.X1077", "DISCLOSURE.X1074", "DISCLOSURE.X1075", "POPT2.X19", "POPT2.X18", "POPT2.X13", "POPT2.X12", "DISCLOSURE.X1029", "POPT2.X11", "POPT2.X10", "POPT2.X17", "POPT2.X16", "POPT2.X15", "POPT2.X14", "DISCLOSURE.X1038", "DISCLOSURE.X1039", "DISCLOSURE.X1036", "DISCLOSURE.X1037", "DISCLOSURE.X1034", "DISCLOSURE.X1035", "DISCLOSURE.X1032", "DISCLOSURE.X1033", "DISCLOSURE.X1030", "DISCLOSURE.X1031", "NEWHUD.X358", "NEWHUD.X359", "NEWHUD.X363", "NEWHUD.X362", "NEWHUD.X361", "NEWHUD.X360", "NEWHUD.X367", "NEWHUD.X366", "NEWHUD.X365", "NEWHUD.X364", "NEWHUD.X369", "NEWHUD.X368", "NEWHUD.X372", "NEWHUD.X373", "NEWHUD.X370", "NEWHUD.X371", "NEWHUD.X376", "NEWHUD.X377", "NEWHUD.X374", "NEWHUD.X375", "NEWHUD.X378", "NEWHUD.X379", "NEWHUD.X305", "NEWHUD.X304", "NEWHUD.X307", "NEWHUD.X306", "NEWHUD.X301", "NEWHUD.X300", "NEWHUD.X303", "NEWHUD.X302", "NEWHUD.X309", "NEWHUD.X308", "NEWHUD.X316", "NEWHUD.X317", "NEWHUD.X310", "NEWHUD.X311", "NEWHUD.X318", "NEWHUD.X319", "NEWHUD.X327", "NEWHUD.X326", "NEWHUD.X325", "NEWHUD.X324", "NEWHUD.X323", "NEWHUD.X322", "NEWHUD.X321", "NEWHUD.X320", "NEWHUD.X329", "NEWHUD.X328", "NEWHUD.X330", "NEWHUD.X389", "NEWHUD.X385", "NEWHUD.X384", "NEWHUD.X387", "NEWHUD.X386", "NEWHUD.X381", "NEWHUD.X380", "NEWHUD.X383", "NEWHUD.X382", "NEWHUD.X398", "NEWHUD.X395", "NEWHUD.X396", "NEWHUD.X397", "NEWHUD.X390", "NEWHUD.X392", "NEWHUD.X393", "DISCLOSURE.X1184", "DISCLOSURE.X1185", "DISCLOSURE.X1186", "DISCLOSURE.X1187", "DISCLOSURE.X1180", "DISCLOSURE.X1181", "DISCLOSURE.X1182", "DISCLOSURE.X1183", "DISCLOSURE.X1188", "DISCLOSURE.X1189", "DISCLOSURE.X1195", "DISCLOSURE.X1194", "DISCLOSURE.X1197", "DISCLOSURE.X1196", "DISCLOSURE.X1191", "DISCLOSURE.X1190", "DISCLOSURE.X1193", "DISCLOSURE.X1192", "DISCLOSURE.X1199", "DISCLOSURE.X1198", "DISCLOSURE.X1148", "DISCLOSURE.X1149", "DISCLOSURE.X1140", "DISCLOSURE.X1141", "DISCLOSURE.X1142", "DISCLOSURE.X1143", "DISCLOSURE.X1144", "DISCLOSURE.X1145", "DISCLOSURE.X1146", "DISCLOSURE.X1147", "DISCLOSURE.X1168", "DISCLOSURE.X1169", "DISCLOSURE.X1162", "DISCLOSURE.X1163", "DISCLOSURE.X1160", "DISCLOSURE.X1161", "DISCLOSURE.X1166", "DISCLOSURE.X1167", "DISCLOSURE.X1164", "DISCLOSURE.X1165", "DISCLOSURE.X1159", "DISCLOSURE.X1158", "DISCLOSURE.X1151", "DISCLOSURE.X1150", "DISCLOSURE.X1153", "DISCLOSURE.X1152", "DISCLOSURE.X1155", "DISCLOSURE.X1154", "DISCLOSURE.X1157", "DISCLOSURE.X1108", "DISCLOSURE.X1109", "DISCLOSURE.X1104", "DISCLOSURE.X1105", "DISCLOSURE.X1106", "DISCLOSURE.X1107", "DISCLOSURE.X1100", "DISCLOSURE.X1101", "DISCLOSURE.X1102", "DISCLOSURE.X1103", "DISCLOSURE.X1179", "DISCLOSURE.X1178", "DISCLOSURE.X1173", "DISCLOSURE.X1172", "DISCLOSURE.X1171", "DISCLOSURE.X1170", "DISCLOSURE.X1177", "DISCLOSURE.X1176", "DISCLOSURE.X1175", "DISCLOSURE.X1174", "DISCLOSURE.X1128", "DISCLOSURE.X1129", "DISCLOSURE.X1126", "DISCLOSURE.X1127", "DISCLOSURE.X1124", "DISCLOSURE.X1125", "DISCLOSURE.X1122", "DISCLOSURE.X1123", "DISCLOSURE.X1120", "DISCLOSURE.X1121", "DISCLOSURE.X1119", "DISCLOSURE.X1118", "DISCLOSURE.X1115", "DISCLOSURE.X1114", "DISCLOSURE.X1117", "DISCLOSURE.X1116", "DISCLOSURE.X1111", "DISCLOSURE.X1110", "DISCLOSURE.X1113", "DISCLOSURE.X1112", "DISCLOSURE.X1139", "DISCLOSURE.X1138", "DISCLOSURE.X1137", "DISCLOSURE.X1136", "DISCLOSURE.X1135", "DISCLOSURE.X1134", "DISCLOSURE.X1133", "DISCLOSURE.X1132", "DISCLOSURE.X1131", "DISCLOSURE.X1130", "NEWHUD.X279", "NEWHUD.X288", "NEWHUD.X289", "NEWHUD.X284", "NEWHUD.X285", "NEWHUD.X286", "NEWHUD.X287", "NEWHUD.X280", "NEWHUD.X281", "NEWHUD.X282", "NEWHUD.X283", "NEWHUD.X299", "NEWHUD.X298", "NEWHUD.X294", "NEWHUD.X297", "NEWHUD.X296", "NEWHUD.X291", "NEWHUD.X290", "NEWHUD.X293", "NEWHUD.X292", "DISCLOSURE.X1209", "DISCLOSURE.X1208", "DISCLOSURE.X1207", "DISCLOSURE.X1206", "DISCLOSURE.X1205", "DISCLOSURE.X1204", "DISCLOSURE.X1203", "DISCLOSURE.X1202", "DISCLOSURE.X1201", "DISCLOSURE.X1200", "DISCLOSURE.X1214", "DISCLOSURE.X1212", "DISCLOSURE.X1213", "DISCLOSURE.X1210", "DISCLOSURE.X1211", "PM22", "PM23", "PM20", "PM21", "PM26", "PM27", "PM24", "PM25", "PM19", "PM18", "PM11", "PM13", "PM12", "PM15", "PM14", "PM17", "PM16", "PTC.X40", "PTC.X41", "PTC.X42", "PTC.X43", "PTC.X44", "PTC.X45", "PTC.X46", "PTC.X47", "PTC.X48", "PTC.X49", "PTC.X62", "PTC.X63", "PTC.X60", "PTC.X61", "PTC.X66", "PTC.X67", "PTC.X64", "PTC.X65", "PTC.X68", "PTC.X69", "PTC.X51", "PTC.X50", "PTC.X53", "PTC.X52", "PTC.X55", "PTC.X54", "PTC.X57", "PTC.X56", "PTC.X59", "PTC.X58", "PTC.X73", "PTC.X72", "PTC.X71", "PTC.X70", "PTC.X77", "PTC.X76", "PTC.X75", "PTC.X74", "PTC.X79", "PTC.X78", "PTC.X26", "PTC.X27", "PTC.X24", "PTC.X25", "PTC.X22", "PTC.X23", "PTC.X20", "PTC.X21", "PTC.X28", "PTC.X29", "PTC.X15", "PTC.X14", "PTC.X17", "PTC.X16", "PTC.X11", "PTC.X10", "PTC.X13", "PTC.X12", "PTC.X19", "PTC.X18", "PTC.X37", "PTC.X36", "PTC.X35", "PTC.X34", "PTC.X33", "PTC.X32", "PTC.X31", "PTC.X30", "PTC.X39", "PTC.X38", "PTC.X88", "PTC.X89", "PTC.X84", "PTC.X85", "PTC.X86", "PTC.X87", "PTC.X80", "PTC.X81", "PTC.X82", "PTC.X83", "PTC.X99", "PTC.X98", "PTC.X95", "PTC.X94", "PTC.X97", "PTC.X96", "PTC.X91", "PTC.X90", "PTC.X93", "PTC.X92", "PTC.X4", "PTC.X5", "PTC.X6", "PTC.X7", "PTC.X1", "PTC.X2", "PTC.X3", "PTC.X8", "PTC.X9", "NEWHUD2.X4653", "NEWHUD2.X4652", "NEWHUD2.X4651", "NEWHUD2.X4650", "NEWHUD2.X4657", "NEWHUD2.X4656", "NEWHUD2.X4655", "NEWHUD2.X4654", "NEWHUD2.X4659", "NEWHUD2.X4658", "NEWHUD.X943", "NEWHUD.X942", "NEWHUD.X941", "NEWHUD.X940", "NEWHUD.X946", "NEWHUD.X945", "NEWHUD.X944", "NEWHUD.X929", "NEWHUD.X928", "NEWHUD.X925", "NEWHUD.X924", "NEWHUD.X927", "NEWHUD.X926", "NEWHUD.X921", "NEWHUD.X920", "NEWHUD.X923", "NEWHUD.X922", "NEWHUD.X938", "NEWHUD.X939", "NEWHUD.X934", "NEWHUD.X935", "NEWHUD.X936", "NEWHUD.X937", "NEWHUD.X930", "NEWHUD.X931", "NEWHUD.X932", "NEWHUD.X933", "NEWHUD.X909", "NEWHUD.X908", "NEWHUD.X907", "NEWHUD.X906", "NEWHUD.X905", "NEWHUD.X904", "NEWHUD.X903", "NEWHUD.X902", "NEWHUD.X901", "NEWHUD.X900", "NEWHUD.X918", "NEWHUD.X919", "NEWHUD.X916", "NEWHUD.X917", "NEWHUD.X914", "NEWHUD.X915", "NEWHUD.X912", "NEWHUD.X913", "NEWHUD.X910", "NEWHUD.X911", "NEWHUD.X886", "NEWHUD.X887", "NEWHUD.X884", "NEWHUD.X885", "NEWHUD.X882", "NEWHUD.X883", "NEWHUD.X880", "NEWHUD.X881", "NEWHUD.X888", "NEWHUD.X889", "NEWHUD.X868", "NEWHUD.X869", "NEWHUD.X860", "NEWHUD.X861", "NEWHUD.X862", "NEWHUD.X863", "NEWHUD.X864", "NEWHUD.X865", "NEWHUD.X866", "NEWHUD.X867", "NEWHUD.X897", "NEWHUD.X896", "NEWHUD.X895", "NEWHUD.X894", "NEWHUD.X893", "NEWHUD.X892", "NEWHUD.X891", "NEWHUD.X890", "NEWHUD.X899", "NEWHUD.X898", "NEWHUD.X848", "NEWHUD.X849", "NEWHUD.X842", "NEWHUD.X843", "NEWHUD.X840", "NEWHUD.X841", "NEWHUD.X846", "NEWHUD.X847", "NEWHUD.X844", "NEWHUD.X845", "NEWHUD.X879", "NEWHUD.X878", "NEWHUD.X871", "NEWHUD.X870", "NEWHUD.X873", "NEWHUD.X872", "NEWHUD.X875", "NEWHUD.X874", "NEWHUD.X877", "NEWHUD.X876", "NEWHUD.X828", "NEWHUD.X829", "NEWHUD.X824", "NEWHUD.X825", "NEWHUD.X826", "NEWHUD.X827", "NEWHUD.X821", "NEWHUD.X822", "NEWHUD.X823", "NEWHUD.X859", "NEWHUD.X858", "NEWHUD.X853", "NEWHUD.X852", "NEWHUD.X851", "NEWHUD.X850", "NEWHUD.X857", "NEWHUD.X856", "NEWHUD.X855", "NEWHUD.X854", "NEWHUD.X839", "NEWHUD.X838", "NEWHUD.X835", "NEWHUD.X834", "NEWHUD.X837", "NEWHUD.X836", "NEWHUD.X831", "NEWHUD.X830", "NEWHUD.X833", "NEWHUD.X832", "CD3.X779", "CD3.X778", "CD3.X780", "NEWHUD.X1667", "NEWHUD.X1666", "NEWHUD.X1665", "NEWHUD.X1664", "NEWHUD.X1669", "NEWHUD.X1668", "NEWHUD.X1676", "NEWHUD.X1677", "NEWHUD.X1674", "NEWHUD.X1675", "NEWHUD.X1672", "NEWHUD.X1673", "NEWHUD.X1670", "NEWHUD.X1671", "NEWHUD.X1678", "NEWHUD.X1679", "NEWHUD.X1681", "NEWHUD.X1680", "NEWHUD.X1683", "NEWHUD.X1682", "NEWHUD.X1685", "NEWHUD.X1684", "NEWHUD.X1690", "NEWHUD.X1691", "NEWHUD.X1692", "NEWHUD.X1693", "NEWHUD.X1694", "NEWHUD.X1695", "CD3.X539", "NEWHUD.X1700", "NEWHUD.X1701", "NEWHUD.X1702", "NEWHUD.X1703", "CD3.X517", "CD3.X516", "CD3.X515", "CD3.X518", "CD3.X575", "CD3.X574", "CD3.X577", "CD3.X576", "CD3.X571", "CD3.X570", "CD3.X573", "CD3.X572", "CD3.X579", "CD3.X578", "CD3.X564", "CD3.X565", "CD3.X566", "CD3.X567", "CD3.X563", "CD3.X568", "CD3.X569", "CD3.X542", "CD3.X540", "CD3.X541", "CD3.X599", "CD3.X598", "CD3.X592", "CD3.X595", "CD3.X589", "CD3.X582", "CD3.X583", "CD3.X580", "CD3.X581", "CD3.X586", "CD3.X584", "CD3.X585", "NEWHUD.X1421", "NEWHUD.X1420", "NEWHUD.X1423", "NEWHUD.X1422", "NEWHUD.X1425", "NEWHUD.X1424", "NEWHUD.X1427", "NEWHUD.X1426", "NEWHUD.X1429", "NEWHUD.X1428", "CD3.X600", "NEWHUD.X1430", "NEWHUD.X1431", "NEWHUD.X1432", "NEWHUD.X1433", "NEWHUD.X1434", "NEWHUD.X1435", "NEWHUD.X1436", "NEWHUD.X1437", "NEWHUD.X1438", "NEWHUD.X1439", "NEWHUD.X1419", "NEWHUD.X1465", "NEWHUD.X1464", "NEWHUD.X1467", "NEWHUD.X1466", "NEWHUD.X1461", "NEWHUD.X1460", "NEWHUD.X1463", "NEWHUD.X1462", "NEWHUD.X1469", "NEWHUD.X1468", "NEWHUD.X1474", "NEWHUD.X1475", "NEWHUD.X1476", "NEWHUD.X1477", "NEWHUD.X1470", "NEWHUD.X1471", "NEWHUD.X1472", "NEWHUD.X1473", "NEWHUD.X1478", "CD3.X690", "NEWHUD.X1447", "NEWHUD.X1446", "NEWHUD.X1445", "NEWHUD.X1444", "NEWHUD.X1443", "NEWHUD.X1442", "NEWHUD.X1441", "NEWHUD.X1440", "NEWHUD.X1449", "NEWHUD.X1448", "NEWHUD.X1456", "NEWHUD.X1457", "NEWHUD.X1454", "NEWHUD.X1455", "NEWHUD.X1452", "NEWHUD.X1453", "NEWHUD.X1450", "NEWHUD.X1451", "NEWHUD.X1458", "NEWHUD.X1459", "CD3.X689", "CD3.X688", "RE882.X7", "RE882.X8", "RE882.X9", "CD3.X351", "CD3.X350", "CD3.X353", "CD3.X352", "CD3.X355", "CD3.X354", "CD3.X357", "CD3.X356", "CD3.X359", "CD3.X358", "CD3.X340", "CD3.X343", "CD3.X346", "CD3.X347", "CD3.X348", "CD3.X349", "CD3.X373", "CD3.X372", "CD3.X371", "CD3.X370", "CD3.X377", "CD3.X376", "CD3.X375", "CD3.X374", "CD3.X379", "CD3.X378", "CD3.X362", "CD3.X363", "CD3.X360", "CD3.X361", "CD3.X366", "CD3.X367", "CD3.X364", "CD3.X365", "CD3.X368", "CD3.X369", "CD3.X315", "CD3.X314", "CD3.X317", "CD3.X316", "CD3.X311", "CD3.X310", "CD3.X313", "CD3.X312", "CD3.X319", "CD3.X318", "NEWHUD.X1564", "NEWHUD.X1565", "NEWHUD.X1566", "NEWHUD.X1567", "NEWHUD.X1560", "NEWHUD.X1561", "NEWHUD.X1562", "NEWHUD.X1563", "CD3.X304", "NEWHUD.X1568", "CD3.X305", "NEWHUD.X1569", "CD3.X306", "CD3.X307", "CD3.X300", "CD3.X301", "CD3.X302", "CD3.X303", "CD3.X308", "CD3.X309", "CD3.X337", "CD3.X336", "CD3.X335", "CD3.X334", "CD3.X333", "CD3.X332", "CD3.X331", "CD3.X330", "NEWHUD.X1546", "NEWHUD.X1547", "NEWHUD.X1544", "NEWHUD.X1545", "NEWHUD.X1542", "NEWHUD.X1543", "NEWHUD.X1541", "CD3.X326", "CD3.X327", "CD3.X324", "NEWHUD.X1548", "CD3.X325", "NEWHUD.X1549", "CD3.X322", "CD3.X323", "CD3.X320", "CD3.X321", "CD3.X328", "CD3.X329", "NEWHUD.X1575", "NEWHUD.X1574", "NEWHUD.X1577", "NEWHUD.X1576", "NEWHUD.X1571", "NEWHUD.X1570", "NEWHUD.X1573", "NEWHUD.X1572", "NEWHUD.X1579", "NEWHUD.X1578", "NEWHUD.X1557", "NEWHUD.X1556", "NEWHUD.X1555", "NEWHUD.X1554", "NEWHUD.X1553", "NEWHUD.X1552", "NEWHUD.X1551", "NEWHUD.X1550", "NEWHUD.X1559", "NEWHUD.X1558", "NEWHUD.X1582", "NEWHUD.X1583", "NEWHUD.X1580", "NEWHUD.X1581", "NEWHUD.X1584", "CD3.X399", "CD3.X398", "CD3.X395", "CD3.X394", "CD3.X397", "CD3.X396", "CD3.X391", "CD3.X390", "CD3.X393", "CD3.X392", "CD3.X388", "CD3.X389", "CD3.X384", "CD3.X385", "CD3.X386", "CD3.X387", "CD3.X380", "CD3.X381", "CD3.X382", "CD3.X383", "DISCLOSURE.X905", "DISCLOSURE.X904", "DISCLOSURE.X907", "DISCLOSURE.X906", "DISCLOSURE.X901", "DISCLOSURE.X900", "DISCLOSURE.X903", "DISCLOSURE.X902", "CD3.X430", "CD3.X431", "CD3.X432", "CD3.X433", "CD3.X434", "CD3.X435", "CD3.X436", "CD3.X437", "CD3.X438", "CD3.X439", "CD3.X412", "CD3.X413", "CD3.X410", "CD3.X411", "CD3.X416", "CD3.X417", "CD3.X414", "CD3.X415", "CD3.X418", "CD3.X419", "CD3.X421", "CD3.X420", "CD3.X423", "CD3.X422", "CD3.X425", "CD3.X424", "CD3.X427", "CD3.X426", "CD3.X429", "CD3.X428", "CD3.X470", "CD3.X403", "CD3.X402", "CD3.X401", "CD3.X400", "CD3.X407", "CD3.X406", "CD3.X405", "CD3.X404", "CD3.X409", "CD3.X408", "CD3.X467", "CD3.X469", "CD3.X468", "NEWHUD.X1217", "NEWHUD.X1218", "NEWHUD.X1219", "NEWHUD.X1224", "NEWHUD.X1223", "NEWHUD.X1222", "NEWHUD.X1221", "NEWHUD.X1220", "CD3.X446", "CD3.X445", "CD3.X444", "CD3.X443", "CD3.X442", "CD3.X441", "CD3.X440", "NEWHUD.X1234", "NEWHUD.X1232", "NEWHUD.X1233", "NEWHUD.X1231", "CD3.X492", "CD3.X493", "CD3.X491", "CD3.X494", "POPT.X8", "POPT.X9", "POPT.X1", "POPT.X2", "POPT.X3", "POPT.X4", "POPT.X5", "POPT.X6", "POPT.X7", "DISCLOSURE.X868", "DISCLOSURE.X869", "DISCLOSURE.X873", "DISCLOSURE.X872", "DISCLOSURE.X871", "DISCLOSURE.X870", "DISCLOSURE.X877", "DISCLOSURE.X876", "DISCLOSURE.X875", "DISCLOSURE.X874", "DISCLOSURE.X879", "DISCLOSURE.X878", "CD3.X171", "CD3.X170", "CD3.X173", "CD3.X172", "CD3.X175", "CD3.X174", "CD3.X177", "CD3.X176", "CD3.X179", "CD3.X178", "CD3.X160", "CD3.X161", "CD3.X162", "CD3.X163", "CD3.X164", "CD3.X165", "CD3.X166", "CD3.X167", "CD3.X168", "CD3.X169", "CD3.X153", "CD3.X152", "CD3.X151", "CD3.X150", "CD3.X157", "CD3.X156", "CD3.X155", "CD3.X154", "CD3.X159", "CD3.X158", "CD3.X142", "CD3.X143", "CD3.X140", "CD3.X141", "CD3.X146", "CD3.X147", "CD3.X144", "CD3.X145", "CD3.X148", "CD3.X149", "DISCLOSURE.X888", "DISCLOSURE.X889", "DISCLOSURE.X884", "DISCLOSURE.X885", "DISCLOSURE.X886", "DISCLOSURE.X887", "DISCLOSURE.X880", "DISCLOSURE.X881", "DISCLOSURE.X882", "DISCLOSURE.X883", "CD3.X139", "DISCLOSURE.X899", "DISCLOSURE.X898", "DISCLOSURE.X895", "DISCLOSURE.X894", "DISCLOSURE.X897", "DISCLOSURE.X896", "DISCLOSURE.X891", "DISCLOSURE.X890", "DISCLOSURE.X893", "DISCLOSURE.X892", "NEWHUD2.X150", "NEWHUD2.X151", "NEWHUD2.X152", "NEWHUD2.X153", "NEWHUD2.X154", "NEWHUD2.X155", "NEWHUD2.X156", "NEWHUD2.X157", "NEWHUD2.X158", "NEWHUD2.X159", "NEWHUD2.X172", "NEWHUD2.X173", "NEWHUD2.X170", "NEWHUD2.X171", "NEWHUD2.X176", "NEWHUD2.X177", "NEWHUD2.X174", "NEWHUD2.X175", "NEWHUD2.X178", "NEWHUD2.X179", "NEWHUD2.X141", "NEWHUD2.X143", "NEWHUD2.X142", "NEWHUD2.X145", "NEWHUD2.X144", "NEWHUD2.X147", "NEWHUD2.X146", "NEWHUD2.X149", "NEWHUD2.X148", "CD3.X199", "CD3.X198", "CD3.X197", "CD3.X196", "CD3.X195", "CD3.X194", "CD3.X193", "CD3.X192", "CD3.X191", "CD3.X190", "CD3.X188", "CD3.X189", "CD3.X186", "NEWHUD2.X163", "CD3.X187", "NEWHUD2.X162", "CD3.X184", "NEWHUD2.X161", "CD3.X185", "NEWHUD2.X160", "CD3.X182", "NEWHUD2.X167", "CD3.X183", "NEWHUD2.X166", "CD3.X180", "NEWHUD2.X165", "CD3.X181", "NEWHUD2.X164", "NEWHUD2.X169", "NEWHUD2.X168", "FM1084.X50", "NEWHUD2.X198", "NEWHUD2.X199", "NEWHUD2.X194", "NEWHUD2.X195", "NEWHUD2.X196", "NEWHUD2.X197", "NEWHUD2.X190", "NEWHUD2.X191", "NEWHUD2.X192", "NEWHUD2.X193", "NEWHUD2.X189", "NEWHUD2.X188", "NEWHUD2.X185", "NEWHUD2.X184", "NEWHUD2.X187", "NEWHUD2.X186", "NEWHUD2.X181", "NEWHUD2.X180", "NEWHUD2.X183", "NEWHUD2.X182", "CD3.X250", "CD3.X251", "CD3.X252", "CD3.X253", "CD3.X254", "CD3.X257", "FM1084.X94", "FM1084.X95", "FM1084.X96", "FM1084.X93", "CD3.X272", "CD3.X273", "CD3.X270", "CD3.X271", "CD3.X276", "CD3.X277", "CD3.X274", "CD3.X275", "CD3.X278", "CD3.X279", "CD3.X241", "CD3.X240", "CD3.X243", "CD3.X242", "CD3.X245", "CD3.X244", "CD3.X247", "CD3.X246", "CD3.X249", "CD3.X248", "CD3.X214", "CD3.X215", "CD3.X216", "CD3.X217", "CD3.X210", "CD3.X211", "CD3.X212", "CD3.X213", "CD3.X218", "CD3.X219", "NEWHUD.X1043", "NEWHUD.X1042", "NEWHUD.X1041", "NEWHUD.X1040", "NEWHUD.X1044", "CD3.X263", "CD3.X260", "CD3.X267", "CD3.X266", "CD3.X265", "CD3.X264", "CD3.X269", "CD3.X268", "CD3.X236", "CD3.X237", "CD3.X234", "CD3.X235", "CD3.X232", "CD3.X233", "CD3.X230", "CD3.X231", "CD3.X238", "CD3.X239", "NEWHUD.X1025", "NEWHUD.X1024", "NEWHUD.X1027", "NEWHUD.X1026", "NEWHUD.X1021", "NEWHUD.X1020", "NEWHUD.X1023", "NEWHUD.X1022", "CD3.X205", "NEWHUD.X1029", "CD3.X204", "NEWHUD.X1028", "CD3.X207", "CD3.X206", "CD3.X201", "CD3.X200", "CD3.X203", "CD3.X202", "CD3.X209", "CD3.X208", "NEWHUD.X1034", "NEWHUD.X1035", "NEWHUD.X1036", "NEWHUD.X1037", "NEWHUD.X1030", "NEWHUD.X1031", "NEWHUD.X1032", "NEWHUD.X1033", "NEWHUD.X1038", "NEWHUD.X1039", "CD3.X227", "CD3.X226", "CD3.X225", "CD3.X224", "CD3.X223", "CD3.X222", "CD3.X221", "CD3.X220", "CD3.X229", "CD3.X228", "NEWHUD.X1018", "NEWHUD.X1019", "CD3.X298", "CD3.X299", "CD3.X294", "CD3.X295", "CD3.X296", "CD3.X297", "CD3.X290", "CD3.X291", "CD3.X292", "CD3.X293", "CD3.X289", "CD3.X288", "CD3.X285", "CD3.X284", "CD3.X287", "CD3.X286", "CD3.X281", "CD3.X280", "CD3.X283", "CD3.X282", "NEWHUD.X1098", "NEWHUD.X1099", "NEWHUD.X1096", "NEWHUD.X1097", "NEWHUD.X1095", "NEWHUD.X1124", "NEWHUD.X1125", "NEWHUD.X1126", "NEWHUD.X1127", "NEWHUD.X1120", "NEWHUD.X1121", "NEWHUD.X1122", "NEWHUD.X1123", "NEWHUD.X1128", "NEWHUD.X1129", "NEWHUD.X1106", "NEWHUD.X1107", "NEWHUD.X1104", "NEWHUD.X1105", "NEWHUD.X1102", "NEWHUD.X1103", "NEWHUD.X1100", "NEWHUD.X1101", "NEWHUD.X1108", "NEWHUD.X1109", "NEWHUD.X1135", "NEWHUD.X1134", "NEWHUD.X1137", "NEWHUD.X1136", "NEWHUD.X1131", "NEWHUD.X1130", "NEWHUD.X1133", "NEWHUD.X1132", "NEWHUD.X1138", "NEWHUD.X1117", "NEWHUD.X1116", "NEWHUD.X1115", "NEWHUD.X1114", "NEWHUD.X1113", "NEWHUD.X1112", "NEWHUD.X1111", "NEWHUD.X1110", "NEWHUD.X1119", "NEWHUD.X1118", "DISCLOSURE.X594", "DISCLOSURE.X595", "DISCLOSURE.X596", "DISCLOSURE.X597", "DISCLOSURE.X598", "DISCLOSURE.X599", "DISCLOSURE.X509", "DISCLOSURE.X508", "DISCLOSURE.X501", "DISCLOSURE.X500", "DISCLOSURE.X503", "DISCLOSURE.X502", "DISCLOSURE.X505", "DISCLOSURE.X504", "DISCLOSURE.X507", "DISCLOSURE.X506", "DISCLOSURE.X518", "DISCLOSURE.X519", "DISCLOSURE.X510", "DISCLOSURE.X511", "DISCLOSURE.X512", "DISCLOSURE.X513", "DISCLOSURE.X514", "DISCLOSURE.X515", "DISCLOSURE.X516", "DISCLOSURE.X517", "DISCLOSURE.X529", "DISCLOSURE.X528", "DISCLOSURE.X523", "DISCLOSURE.X522", "DISCLOSURE.X521", "DISCLOSURE.X520", "DISCLOSURE.X527", "DISCLOSURE.X526", "DISCLOSURE.X525", "DISCLOSURE.X524", "DISCLOSURE.X538", "DISCLOSURE.X539", "DISCLOSURE.X532", "DISCLOSURE.X533", "DISCLOSURE.X530", "DISCLOSURE.X531", "DISCLOSURE.X536", "DISCLOSURE.X537", "DISCLOSURE.X534", "DISCLOSURE.X535", "RE882.X42", "RE882.X43", "RE882.X40", "RE882.X41", "RE882.X46", "RE882.X44", "RE882.X45", "DISCLOSURE.X549", "DISCLOSURE.X548", "DISCLOSURE.X545", "DISCLOSURE.X544", "DISCLOSURE.X547", "DISCLOSURE.X546", "DISCLOSURE.X541", "DISCLOSURE.X540", "DISCLOSURE.X543", "DISCLOSURE.X542", "DISCLOSURE.X558", "DISCLOSURE.X559", "DISCLOSURE.X554", "DISCLOSURE.X555", "DISCLOSURE.X556", "DISCLOSURE.X557", "DISCLOSURE.X550", "DISCLOSURE.X551", "DISCLOSURE.X552", "DISCLOSURE.X553", "RE882.X24", "RE882.X20", "RE882.X21", "RE882.X22", "RE882.X23", "RE882.X28", "RE882.X29", "DISCLOSURE.X569", "DISCLOSURE.X568", "DISCLOSURE.X567", "DISCLOSURE.X566", "DISCLOSURE.X565", "DISCLOSURE.X564", "DISCLOSURE.X563", "DISCLOSURE.X562", "DISCLOSURE.X561", "DISCLOSURE.X560", "RE882.X57", "RE882.X56", "RE882.X59", "RE882.X58", "DISCLOSURE.X576", "DISCLOSURE.X577", "DISCLOSURE.X574", "DISCLOSURE.X575", "DISCLOSURE.X572", "DISCLOSURE.X573", "DISCLOSURE.X570", "DISCLOSURE.X571", "RE882.X35", "RE882.X34", "RE882.X37", "RE882.X36", "RE882.X31", "RE882.X30", "RE882.X33", "RE882.X32", "RE882.X39", "RE882.X38", "RE882.X17", "RE882.X16", "RE882.X15", "RE882.X14", "RE882.X13", "RE882.X12", "RE882.X11", "RE882.X10", "RE882.X19", "RE882.X18", "DISCLOSURE.X480", "DISCLOSURE.X481", "DISCLOSURE.X482", "DISCLOSURE.X483", "DISCLOSURE.X484", "DISCLOSURE.X485", "DISCLOSURE.X486", "DISCLOSURE.X487", "DISCLOSURE.X488", "DISCLOSURE.X489", "DISCLOSURE.X491", "DISCLOSURE.X490", "DISCLOSURE.X493", "DISCLOSURE.X492", "DISCLOSURE.X495", "DISCLOSURE.X494", "DISCLOSURE.X497", "DISCLOSURE.X496", "DISCLOSURE.X499", "DISCLOSURE.X498", "DISCLOSURE.X408", "DISCLOSURE.X409", "DISCLOSURE.X400", "DISCLOSURE.X401", "DISCLOSURE.X402", "DISCLOSURE.X403", "DISCLOSURE.X405", "DISCLOSURE.X406", "DISCLOSURE.X407", "DISCLOSURE.X428", "DISCLOSURE.X429", "DISCLOSURE.X422", "DISCLOSURE.X423", "DISCLOSURE.X420", "DISCLOSURE.X421", "DISCLOSURE.X426", "DISCLOSURE.X427", "DISCLOSURE.X424", "DISCLOSURE.X425", "DISCLOSURE.X419", "DISCLOSURE.X418", "DISCLOSURE.X411", "DISCLOSURE.X410", "DISCLOSURE.X413", "DISCLOSURE.X412", "DISCLOSURE.X415", "DISCLOSURE.X414", "DISCLOSURE.X417", "DISCLOSURE.X416", "DISCLOSURE.X448", "DISCLOSURE.X449", "DISCLOSURE.X444", "DISCLOSURE.X445", "DISCLOSURE.X446", "DISCLOSURE.X447", "DISCLOSURE.X440", "DISCLOSURE.X441", "DISCLOSURE.X442", "DISCLOSURE.X443", "DISCLOSURE.X439", "DISCLOSURE.X438", "DISCLOSURE.X433", "DISCLOSURE.X432", "DISCLOSURE.X431", "DISCLOSURE.X430", "DISCLOSURE.X437", "DISCLOSURE.X436", "DISCLOSURE.X435", "DISCLOSURE.X434", "DISCLOSURE.X468", "DISCLOSURE.X469", "DISCLOSURE.X466", "DISCLOSURE.X467", "DISCLOSURE.X464", "DISCLOSURE.X465", "DISCLOSURE.X462", "DISCLOSURE.X463", "DISCLOSURE.X460", "DISCLOSURE.X461", "DISCLOSURE.X459", "DISCLOSURE.X458", "DISCLOSURE.X455", "DISCLOSURE.X454", "DISCLOSURE.X457", "DISCLOSURE.X456", "DISCLOSURE.X451", "DISCLOSURE.X450", "DISCLOSURE.X453", "DISCLOSURE.X452", "DISCLOSURE.X479", "DISCLOSURE.X478", "DISCLOSURE.X477", "DISCLOSURE.X476", "DISCLOSURE.X475", "DISCLOSURE.X474", "DISCLOSURE.X473", "DISCLOSURE.X472", "DISCLOSURE.X471", "DISCLOSURE.X470", "DISCLOSURE.X682", "DISCLOSURE.X683", "DISCLOSURE.X680", "DISCLOSURE.X681", "DISCLOSURE.X686", "DISCLOSURE.X687", "DISCLOSURE.X684", "DISCLOSURE.X685", "DISCLOSURE.X620", "DISCLOSURE.X621", "DISCLOSURE.X622", "DISCLOSURE.X623", "DISCLOSURE.X624", "DISCLOSURE.X608", "DISCLOSURE.X609", "DISCLOSURE.X602", "DISCLOSURE.X603", "DISCLOSURE.X600", "DISCLOSURE.X601", "DISCLOSURE.X606", "DISCLOSURE.X607", "DISCLOSURE.X604", "DISCLOSURE.X605", "DISCLOSURE.X668", "DISCLOSURE.X669", "DISCLOSURE.X664", "DISCLOSURE.X665", "DISCLOSURE.X666", "DISCLOSURE.X667", "DISCLOSURE.X660", "DISCLOSURE.X661", "DISCLOSURE.X662", "DISCLOSURE.X663", "PREQUAL.X84", "PREQUAL.X83", "DISCLOSURE.X619", "DISCLOSURE.X618", "DISCLOSURE.X613", "PREQUAL.X88", "DISCLOSURE.X612", "DISCLOSURE.X611", "DISCLOSURE.X610", "DISCLOSURE.X617", "DISCLOSURE.X616", "DISCLOSURE.X615", "DISCLOSURE.X614", "PREQUAL.X96", "PREQUAL.X97", "DISCLOSURE.X648", "DISCLOSURE.X649", "DISCLOSURE.X646", "DISCLOSURE.X647", "DISCLOSURE.X644", "DISCLOSURE.X645", "DISCLOSURE.X642", "DISCLOSURE.X643", "DISCLOSURE.X641", "DISCLOSURE.X679", "DISCLOSURE.X678", "DISCLOSURE.X675", "DISCLOSURE.X674", "DISCLOSURE.X677", "DISCLOSURE.X676", "DISCLOSURE.X670", "DISCLOSURE.X673", "PREQUAL.X48", "PREQUAL.X43", "DISCLOSURE.X659", "DISCLOSURE.X658", "DISCLOSURE.X657", "PREQUAL.X44", "DISCLOSURE.X656", "DISCLOSURE.X655", "DISCLOSURE.X654", "DISCLOSURE.X653", "DISCLOSURE.X652", "DISCLOSURE.X651", "DISCLOSURE.X650", "PREQUAL.X56", "PREQUAL.X57", "PREQUAL.X73", "PREQUAL.X74", "PREQUAL.X34", "PREQUAL.X33", "GLOBAL.S21", "GLOBAL.S20", "GLOBAL.S23", "GLOBAL.S22", "GLOBAL.S25", "GLOBAL.S24", "GLOBAL.S27", "GLOBAL.S26", "GLOBAL.S29", "GLOBAL.S28", "GLOBAL.S30", "GLOBAL.S31", "GLOBAL.S32", "GLOBAL.S33", "GLOBAL.S34", "GLOBAL.S35", "GLOBAL.S36", "GLOBAL.S37", "GLOBAL.S38", "GLOBAL.S39", "GLOBAL.S12", "GLOBAL.S13", "GLOBAL.S10", "GLOBAL.S11", "GLOBAL.S16", "GLOBAL.S17", "GLOBAL.S14", "GLOBAL.S15", "GLOBAL.S18", "GLOBAL.S19", "GLOBAL.S65", "GLOBAL.S64", "GLOBAL.S67", "GLOBAL.S66", "GLOBAL.S61", "GLOBAL.S60", "GLOBAL.S63", "GLOBAL.S62", "GLOBAL.S69", "GLOBAL.S68", "GLOBAL.S74", "GLOBAL.S75", "GLOBAL.S76", "GLOBAL.S77", "GLOBAL.S70", "GLOBAL.S71", "GLOBAL.S72", "GLOBAL.S73", "GLOBAL.S78", "GLOBAL.S79", "GLOBAL.S47", "GLOBAL.S46", "GLOBAL.S45", "GLOBAL.S44", "GLOBAL.S43", "GLOBAL.S42", "GLOBAL.S41", "GLOBAL.S40", "GLOBAL.S49", "GLOBAL.S48", "GLOBAL.S56", "GLOBAL.S57", "GLOBAL.S54", "GLOBAL.S55", "GLOBAL.S52", "GLOBAL.S53", "GLOBAL.S50", "GLOBAL.S51", "GLOBAL.S58", "GLOBAL.S59", "GLOBAL.S89", "GLOBAL.S88", "GLOBAL.S83", "GLOBAL.S82", "GLOBAL.S81", "GLOBAL.S80", "GLOBAL.S87", "GLOBAL.S86", "GLOBAL.S85", "GLOBAL.S84", "GLOBAL.S98", "GLOBAL.S99", "GLOBAL.S92", "GLOBAL.S93", "GLOBAL.S90", "GLOBAL.S91", "GLOBAL.S96", "GLOBAL.S97", "GLOBAL.S94", "GLOBAL.S95", "DISCLOSURE.X148", "DISCLOSURE.X141", "DISCLOSURE.X140", "DISCLOSURE.X143", "DISCLOSURE.X142", "DISCLOSURE.X145", "DISCLOSURE.X144", "DISCLOSURE.X147", "DISCLOSURE.X146", "DISCLOSURE.X138", "DISCLOSURE.X139", "DISCLOSURE.X136", "DISCLOSURE.X137", "DISCLOSURE.X134", "DISCLOSURE.X135", "DISCLOSURE.X132", "DISCLOSURE.X133", "DISCLOSURE.X131", "POPT2.X8", "POPT2.X9", "POPT2.X2", "POPT2.X3", "POPT2.X1", "POPT2.X6", "POPT2.X7", "POPT2.X4", "POPT2.X5", "CD3.X997", "CD3.X996", "CD3.X995", "CD3.X994", "CD3.X993", "CD3.X992", "CD3.X991", "CD3.X990", "CD3.X999", "CD3.X998", "CD3.X986", "CD3.X987", "CD3.X984", "CD3.X985", "CD3.X982", "CD3.X983", "CD3.X980", "GFE825", "CD3.X981", "GFE824", "CD3.X988", "CD3.X989", "CD3.X979", "CD3.X978", "CD3.X971", "CD3.X970", "CD3.X973", "CD3.X972", "CD3.X975", "CD3.X974", "CD3.X977", "CD3.X976", "CD3.X968", "CD3.X969", "CD3.X960", "CD3.X961", "CD3.X962", "CD3.X963", "CD3.X964", "CD3.X965", "CD3.X966", "CD3.X967", "CD3.X959", "CD3.X958", "CD3.X957", "CD3.X956", "DISCLOSURE.X387", "DISCLOSURE.X386", "DISCLOSURE.X385", "DISCLOSURE.X384", "DISCLOSURE.X383", "DISCLOSURE.X382", "DISCLOSURE.X381", "DISCLOSURE.X380", "DISCLOSURE.X389", "DISCLOSURE.X388", "DISCLOSURE.X396", "DISCLOSURE.X397", "DISCLOSURE.X394", "DISCLOSURE.X395", "DISCLOSURE.X392", "DISCLOSURE.X393", "DISCLOSURE.X390", "DISCLOSURE.X391", "DISCLOSURE.X398", "DISCLOSURE.X399", "DISCLOSURE.X369", "DISCLOSURE.X368", "DISCLOSURE.X361", "DISCLOSURE.X360", "DISCLOSURE.X363", "DISCLOSURE.X362", "DISCLOSURE.X365", "DISCLOSURE.X364", "DISCLOSURE.X367", "DISCLOSURE.X366", "DISCLOSURE.X378", "DISCLOSURE.X379", "DISCLOSURE.X370", "DISCLOSURE.X371", "DISCLOSURE.X372", "DISCLOSURE.X373", "DISCLOSURE.X374", "DISCLOSURE.X375", "DISCLOSURE.X376", "DISCLOSURE.X377", "DISCLOSURE.X349", "DISCLOSURE.X348", "DISCLOSURE.X343", "DISCLOSURE.X342", "DISCLOSURE.X341", "DISCLOSURE.X340", "DISCLOSURE.X347", "DISCLOSURE.X346", "DISCLOSURE.X345", "DISCLOSURE.X344", "DISCLOSURE.X358", "DISCLOSURE.X359", "DISCLOSURE.X352", "DISCLOSURE.X353", "DISCLOSURE.X350", "DISCLOSURE.X351", "DISCLOSURE.X356", "DISCLOSURE.X357", "DISCLOSURE.X354", "DISCLOSURE.X355", "DISCLOSURE.X329", "DISCLOSURE.X328", "DISCLOSURE.X325", "DISCLOSURE.X324", "DISCLOSURE.X327", "DISCLOSURE.X326", "DISCLOSURE.X321", "DISCLOSURE.X320", "DISCLOSURE.X323", "DISCLOSURE.X322", "DISCLOSURE.X338", "DISCLOSURE.X339", "DISCLOSURE.X334", "DISCLOSURE.X335", "DISCLOSURE.X336", "DISCLOSURE.X337", "DISCLOSURE.X330", "DISCLOSURE.X331", "DISCLOSURE.X332", "DISCLOSURE.X333", "DISCLOSURE.X309", "DISCLOSURE.X308", "DISCLOSURE.X307", "DISCLOSURE.X306", "DISCLOSURE.X305", "DISCLOSURE.X304", "DISCLOSURE.X303", "DISCLOSURE.X302", "DISCLOSURE.X301", "DISCLOSURE.X300", "DISCLOSURE.X318", "DISCLOSURE.X319", "DISCLOSURE.X316", "DISCLOSURE.X317", "DISCLOSURE.X314", "DISCLOSURE.X315", "DISCLOSURE.X312", "DISCLOSURE.X313", "DISCLOSURE.X310", "DISCLOSURE.X311", "DISCLOSURE.X286", "DISCLOSURE.X287", "DISCLOSURE.X284", "DISCLOSURE.X285", "DISCLOSURE.X282", "DISCLOSURE.X283", "DISCLOSURE.X280", "DISCLOSURE.X281", "DISCLOSURE.X288", "DISCLOSURE.X289", "DISCLOSURE.X268", "DISCLOSURE.X269", "DISCLOSURE.X260", "DISCLOSURE.X261", "DISCLOSURE.X262", "DISCLOSURE.X263", "DISCLOSURE.X264", "DISCLOSURE.X265", "DISCLOSURE.X266", "DISCLOSURE.X267", "DISCLOSURE.X297", "DISCLOSURE.X296", "DISCLOSURE.X295", "DISCLOSURE.X294", "DISCLOSURE.X293", "DISCLOSURE.X292", "DISCLOSURE.X290", "DISCLOSURE.X299", "DISCLOSURE.X298", "DISCLOSURE.X248", "DISCLOSURE.X249", "DISCLOSURE.X242", "DISCLOSURE.X243", "DISCLOSURE.X240", "DISCLOSURE.X241", "DISCLOSURE.X246", "DISCLOSURE.X247", "DISCLOSURE.X244", "DISCLOSURE.X245", "DISCLOSURE.X279", "DISCLOSURE.X278", "DISCLOSURE.X271", "DISCLOSURE.X270", "DISCLOSURE.X273", "DISCLOSURE.X272", "DISCLOSURE.X275", "DISCLOSURE.X274", "DISCLOSURE.X277", "DISCLOSURE.X276", "DISCLOSURE.X228", "DISCLOSURE.X229", "DISCLOSURE.X224", "DISCLOSURE.X225", "DISCLOSURE.X226", "DISCLOSURE.X227", "DISCLOSURE.X221", "DISCLOSURE.X222", "DISCLOSURE.X223", "DISCLOSURE.X259", "DISCLOSURE.X258", "DISCLOSURE.X253", "DISCLOSURE.X252", "DISCLOSURE.X251", "DISCLOSURE.X250", "DISCLOSURE.X257", "DISCLOSURE.X256", "DISCLOSURE.X255", "DISCLOSURE.X254", "DISCLOSURE.X239", "DISCLOSURE.X238", "DISCLOSURE.X235", "DISCLOSURE.X234", "DISCLOSURE.X237", "DISCLOSURE.X236", "DISCLOSURE.X231", "DISCLOSURE.X230", "DISCLOSURE.X233", "DISCLOSURE.X232", "CD3.X870", "CD3.X869", "CD3.X868", "NEWHUD.X71", "NEWHUD.X70", "NEWHUD.X73", "NEWHUD.X72", "NEWHUD.X75", "NEWHUD.X74", "NEWHUD.X62", "NEWHUD.X63", "NEWHUD.X64", "NEWHUD.X65", "NEWHUD.X66", "NEWHUD.X67", "NEWHUD.X68", "NEWHUD.X69", "NEWHUD.X53", "NEWHUD.X52", "NEWHUD.X51", "NEWHUD.X50", "NEWHUD.X56", "NEWHUD.X55", "NEWHUD.X54", "NEWHUD.X42", "NEWHUD.X43", "NEWHUD.X41", "NEWHUD.X46", "NEWHUD.X47", "NEWHUD.X44", "NEWHUD.X45", "NEWHUD.X48", "NEWHUD.X49", "NEWHUD.X35", "NEWHUD.X34", "NEWHUD.X37", "NEWHUD.X36", "NEWHUD.X31", "NEWHUD.X30", "NEWHUD.X33", "NEWHUD.X32", "NEWHUD.X24", "NEWHUD.X25", "NEWHUD.X26", "NEWHUD.X27", "NEWHUD.X20", "NEWHUD.X21", "NEWHUD.X22", "NEWHUD.X23", "NEWHUD.X28", "NEWHUD.X29", "NEWHUD.X19", "NEWHUD.X18", "NEWHUD.X91", "NEWHUD.X90", "NEWHUD.X88", "NEWHUD.X89", "NEWHUD.X86", "NEWHUD.X87", "NEWHUD.X84", "NEWHUD.X85", "NEWHUD.X82", "NEWHUD.X83", "NEWHUD.X80", "NEWHUD.X81", "FV.X7", "FV.X6", "FV.X5", "FV.X4", "FV.X9", "FV.X8", "USDA.X48", "USDA.X49", "USDA.X66", "USDA.X67", "USDA.X64", "USDA.X65", "USDA.X62", "USDA.X63", "USDA.X60", "USDA.X61", "USDA.X68", "USDA.X69", "USDA.X55", "USDA.X54", "USDA.X57", "USDA.X56", "USDA.X51", "USDA.X50", "USDA.X53", "USDA.X52", "USDA.X59", "USDA.X58", "USDA.X88", "USDA.X89", "USDA.X80", "USDA.X81", "USDA.X82", "USDA.X83", "USDA.X84", "USDA.X85", "USDA.X86", "USDA.X87", "USDA.X77", "USDA.X76", "USDA.X75", "USDA.X74", "USDA.X73", "USDA.X72", "USDA.X71", "USDA.X70", "USDA.X79", "USDA.X78", "USDA.X91", "USDA.X90", "USDA.X93", "USDA.X92", "USDA.X95", "USDA.X94", "GLOBAL.S120", "GLOBAL.S121", "GLOBAL.S122", "GLOBAL.S123", "GLOBAL.S124", "GLOBAL.S125", "GLOBAL.S126", "GLOBAL.S127", "GLOBAL.S128", "GLOBAL.S129", "GLOBAL.S102", "GLOBAL.S103", "GLOBAL.S100", "GLOBAL.S101", "GLOBAL.S104", "GLOBAL.S105", "GLOBAL.S109", "GLOBAL.S131", "GLOBAL.S130", "GLOBAL.S133", "GLOBAL.S132", "GLOBAL.S135", "GLOBAL.S134", "GLOBAL.S137", "GLOBAL.S136", "GLOBAL.S139", "GLOBAL.S138", "GLOBAL.S160", "GLOBAL.S113", "GLOBAL.S112", "GLOBAL.S111", "GLOBAL.S110", "GLOBAL.S117", "GLOBAL.S116", "GLOBAL.S115", "GLOBAL.S114", "GLOBAL.S119", "GLOBAL.S118", "GLOBAL.S146", "GLOBAL.S147", "GLOBAL.S144", "GLOBAL.S145", "GLOBAL.S142", "GLOBAL.S143", "GLOBAL.S140", "GLOBAL.S141", "GLOBAL.S148", "GLOBAL.S149", "GLOBAL.S157", "GLOBAL.S156", "GLOBAL.S155", "GLOBAL.S154", "GLOBAL.S153", "GLOBAL.S152", "GLOBAL.S151", "GLOBAL.S150", "GLOBAL.S159", "GLOBAL.S158", "RE88395.X311", "RE88395.X310", "RE88395.X313", "RE88395.X312", "RE88395.X314", "RE88395.X308", "RE88395.X309", "RE88395.X300", "RE88395.X301", "RE88395.X302", "RE88395.X303", "RE88395.X304", "RE88395.X305", "RE88395.X306", "RE88395.X307", "RE88395.X332", "RE88395.X331", "RE88395.X330", "RE88395.X328", "RE88395.X329", "RE88395.X153", "RE88395.X152" };

                fieldsUnableToLock.UnionWith(fieldsWithBadModelPaths);

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
        [ApiTest]
        public async Task Loan_FieldPatternsLocking()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);

            try
            {
                const int patternCount = 10;
                var fieldPatternMappings = LoanFieldDescriptors.FieldPatternMappings.Where(p => !p.Key.StartsWith("TQL4506T") && !p.Key.StartsWith("LP") && !p.Key.StartsWith("CX.") && !p.Key.StartsWith("FBE") && !p.Key.StartsWith("FCE") && !p.Key.StartsWith("XCOC") && !p.Key.StartsWith("CUST") && !p.Key.StartsWith("DD") && !p.Key.StartsWith("URLAROIS") && !p.Key.StartsWith("URLARGG") && !p.Key.StartsWith("URLAROA") && !p.Key.StartsWith("URLAROL") && !p.Key.StartsWith("HHI") && !p.Key.StartsWith("DOCPROV") && !p.Key.StartsWith("HTD") && !p.Key.StartsWith("URLARAL")).ToList();
                foreach (var pair in fieldPatternMappings)
                {
                    var fieldPattern = pair.Key;
                    for (var i = 1; i <= patternCount; ++i)
                    {
                        var field = loan.Fields[string.Format(fieldPattern, i)];
                        Assert.AreEqual(string.Format(pair.Value, i), field.ModelPath);
                        if (field.Descriptor.Type != LoanFieldType.Virtual)
                        {
                            Assert.IsFalse(field.Locked, field.ModelPath.ToString());
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
                        if (field.Descriptor.Type != LoanFieldType.Virtual)
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

        private sealed class FieldMappingComparer : IEqualityComparer<KeyValuePair<string, FieldDescriptor>>
        {
            public bool Equals(KeyValuePair<string, FieldDescriptor> x, KeyValuePair<string, FieldDescriptor> y) => x.Value._modelPath.Equals(y.Value._modelPath);

            public int GetHashCode(KeyValuePair<string, FieldDescriptor> obj) => obj.Value._modelPath.GetHashCode();
        }

        [TestMethod]
        public void Loan_FieldsComplex()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var field = loan.Fields["VEND.X5"];
            Assert.AreEqual("Loan.Contacts[(ContactType == 'CUSTOM')][4].State", field.ModelPath);
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            var value = "MO";
            field.Value = value;
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""contacts"":[{{""contactType"":""CUSTOM""}},{{""contactType"":""CUSTOM""}},{{""contactType"":""CUSTOM""}},{{""contactType"":""CUSTOM"",""state"":""{value}""}}]}}", loan.ToString(SerializationOptions.Dirty));
            loan.Dirty = false;
            Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
            value = "NY";
            field.Value = value;
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""contacts"":[{{""contactType"":""CUSTOM""}},{{""contactType"":""CUSTOM""}},{{""contactType"":""CUSTOM""}},{{""contactType"":""CUSTOM"",""state"":""{value}""}}]}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsZeroBased()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var field = loan.Fields["3669"];
            Assert.AreEqual("Loan.MilestoneTemplateLogs[0].IsTemplateLocked", field.ModelPath);
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            var value = true;
            field.Value = value;
            Assert.AreEqual(value, (bool?)field.Value);
            Assert.AreEqual(value, field.ToBoolean());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(@"{""milestoneTemplateLogs"":[{""isTemplateLocked"":true}]}", loan.ToString(SerializationOptions.Dirty));

            field.Value = null;
            Assert.AreEqual(null, (bool?)field.Value);
            Assert.AreEqual(null, field.ToBoolean());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""milestoneTemplateLogs"":[{""isTemplateLocked"":null}]}", loan.ToString(SerializationOptions.Dirty));

            Assert.IsFalse(field.Locked);
            field.Locked = true;
            Assert.IsTrue(field.Locked);
        }

        [TestMethod]
        public void Loan_FieldsCustomMapping()
        {
            Assert.IsTrue(LoanFieldDescriptors.FieldMappings.TryAdd("NEWFIELD", "Loan.NewEntity[2].Borrower.BorrowerId", false));
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var field = loan.Fields["NEWFIELD"];
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
            var intValue = 4;
            field.Value = intValue;
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(intValue, (int?)field.Value);
            Assert.AreEqual(intValue, field.ToInt32());
            Assert.AreEqual($@"{{""newEntity"":[{{}},{{""borrower"":{{""borrowerId"":{intValue}}}}}]}}", loan.ToString(SerializationOptions.Dirty));

            field.Value = null;
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            Assert.AreEqual(@"{""newEntity"":[{},{""borrower"":{""borrowerId"":null}}]}", loan.ToString(SerializationOptions.Dirty));

#pragma warning disable CS0618 // Type or member is obsolete
            loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            field = loan.Fields["NEWFIELD"];
            Assert.IsFalse(field.Locked);
            field.Locked = true;
            Assert.IsTrue(field.Locked);
            Assert.AreEqual(@"{""fieldLockData"":[{""lockRemoved"":false,""modelPath"":""Loan.NewEntity[2].Borrower.BorrowerId""}]}", loan.ToString(SerializationOptions.Dirty));

            Assert.IsTrue(LoanFieldDescriptors.FieldMappings.TryRemove("NEWFIELD", out _));
        }

        [TestMethod]
        public void Loan_FieldsVirtualFields()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var field = loan.Fields["Log.MS.CurrentMilestone"];
            Assert.AreEqual(LoanFieldType.Virtual, field.Descriptor.Type);
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
            var value = "Processing";

            Assert.ThrowsException<InvalidOperationException>(() => field.Value = value);

            loan.VirtualFields["Log.MS.CurrentMilestone"] = value;
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.AreEqual($@"{{""virtualFields"":{{""Log.MS.CurrentMilestone"":""{value}""}}}}", loan.ToString(SerializationOptions.Dirty));

            Assert.ThrowsException<InvalidOperationException>(() => field.Value = null);

            loan.VirtualFields["Log.MS.CurrentMilestone"] = null;
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            Assert.AreEqual(@"{""virtualFields"":{""Log.MS.CurrentMilestone"":null}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsCustomVirtualField()
        {
            Assert.IsTrue(LoanFieldDescriptors.FieldMappings.TryAdd("NEW.VIRTUAL.FIELD", "Loan.VirtualFields['NEW.VIRTUAL.FIELD']", false));
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var field = loan.Fields["NEW.VIRTUAL.FIELD"];
            Assert.AreEqual(LoanFieldType.Virtual, field.Descriptor.Type);
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
            var value = "Processing";

            Assert.ThrowsException<InvalidOperationException>(() => field.Value = value);

            loan.VirtualFields["NEW.VIRTUAL.FIELD"] = value;
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.AreEqual($@"{{""virtualFields"":{{""NEW.VIRTUAL.FIELD"":""{value}""}}}}", loan.ToString(SerializationOptions.Dirty));

            Assert.ThrowsException<InvalidOperationException>(() => field.Value = null);

            loan.VirtualFields["NEW.VIRTUAL.FIELD"] = null;
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            Assert.AreEqual(@"{""virtualFields"":{""NEW.VIRTUAL.FIELD"":null}}", loan.ToString(SerializationOptions.Dirty));

            Assert.IsTrue(LoanFieldDescriptors.FieldMappings.TryRemove("NEW.VIRTUAL.FIELD", out _));
        }

        [TestMethod]
        public void Loan_FieldsVirtualFieldPattern()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var field = loan.Fields["Log.MS.Date.Clear to Close"];
            Assert.AreEqual(LoanFieldType.Virtual, field.Descriptor.Type);
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
            var now = DateTime.Now;
            var value = JsonConvert.ToString(now);
            value = value.Substring(1, value.Length - 2);

            Assert.ThrowsException<InvalidOperationException>(() => field.Value = value);

            loan.VirtualFields["Log.MS.Date.Clear to Close"] = value;
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.AreEqual(now, field.ToDateTime());
            Assert.AreEqual($@"{{""virtualFields"":{{""Log.MS.Date.Clear to Close"":""{value}""}}}}", loan.ToString(SerializationOptions.Dirty));

            Assert.ThrowsException<InvalidOperationException>(() => field.Value = null);

            loan.VirtualFields["Log.MS.Date.Clear to Close"] = null;
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            Assert.AreEqual(@"{""virtualFields"":{""Log.MS.Date.Clear to Close"":null}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldUpdateReadOnlyField()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var field = loan.Fields["2"];
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            Assert.IsTrue(field.ReadOnly);
            var value = 200000M;
            Assert.ThrowsException<InvalidOperationException>(() => field.Value = value);
            loan.BaseLoanAmount = value;
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual(value, (decimal?)field.Value);
            Assert.AreEqual(value, field.ToDecimal());
        }

        [TestMethod]
        public void Loan_FieldOptions()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            var field = loan.Fields["479"];
            var options = field.Descriptor.Options;
            var members = Enums.GetMembers<ApplicationTakenMethodType>().ToList<EnumMember>();
            Assert.AreEqual(members.Count, options.Count);
            foreach (var member in members)
            {
                var option = options.FirstOrDefault(o => string.Equals(o.Value, member.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name), StringComparison.Ordinal));
                Assert.IsNotNull(option);
                Assert.AreEqual(member.AsString(EnumFormat.Description, EnumFormat.EnumMemberValue, EnumFormat.Name), option.Text);
            }

            field = loan.Fields["4143"];
            options = field.Descriptor.Options;
            Assert.AreEqual(members.Count, options.Count);
            var attribute = typeof(Borrower).GetTypeInfo().GetProperty(nameof(Borrower.ApplicationTakenMethodType)).GetCustomAttribute<LoanFieldPropertyAttribute>();
            foreach (var member in members)
            {
                var value = member.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name);
                var option = options.FirstOrDefault(o => string.Equals(o.Value, value, StringComparison.Ordinal));
                Assert.IsNotNull(option);
                if (!attribute.Options.TryGetValue(value, out var text))
                {
                    text = member.AsString(EnumFormat.Description, EnumFormat.EnumMemberValue, EnumFormat.Name);
                }
                Assert.AreEqual(text, option.Text);
            }

            field = loan.Fields["HMDA.X44"];
            options = field.Descriptor.Options;
            members = Enums.GetMembers<AUS>().ToList<EnumMember>();
            Assert.AreEqual(members.Count, options.Count);
            foreach (var member in members)
            {
                var option = options.FirstOrDefault(o => string.Equals(o.Value, member.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name), StringComparison.Ordinal));
                Assert.IsNotNull(option);
                Assert.AreEqual(member.AsString(EnumFormat.Description, EnumFormat.EnumMemberValue, EnumFormat.Name), option.Text);
            }

            field = loan.Fields["HMDA.X45"];
            options = field.Descriptor.Options;
            attribute = typeof(Hmda).GetTypeInfo().GetProperty(nameof(Hmda.AUS2)).GetCustomAttribute<LoanFieldPropertyAttribute>();
            Assert.AreEqual(2, attribute.MissingOptions.Count);
            Assert.AreEqual(members.Count - attribute.MissingOptions.Count, options.Count);
            foreach (var member in members)
            {
                var value = member.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name);
                if (!attribute.MissingOptions.Contains(value))
                {
                    var option = options.FirstOrDefault(o => string.Equals(o.Value, value, StringComparison.Ordinal));
                    Assert.IsNotNull(option);
                    Assert.AreEqual(member.AsString(EnumFormat.Description, EnumFormat.EnumMemberValue, EnumFormat.Name), option.Text);
                }
            }

            field = loan.Fields["3894"];
            options = field.Descriptor.Options;
            Assert.AreEqual(2, options.Count);
            Assert.AreEqual("Y", options[0].Value);
            Assert.AreEqual("Yes", options[0].Text);
            Assert.AreEqual("N", options[1].Value);
            Assert.AreEqual("No", options[1].Text);

            field = loan.Fields["100"];
            options = field.Descriptor.Options;
            Assert.AreEqual(2, options.Count);
            Assert.AreEqual("Y", options[0].Value);
            Assert.AreEqual("Borrower / Co-Borrower are Married", options[0].Text);
            Assert.AreEqual("N", options[1].Value);
            Assert.AreEqual("No", options[1].Text);

            field = loan.Fields["SYS.X2"];
            options = field.Descriptor.Options;
            Assert.AreEqual(3, options.Count);
            Assert.AreEqual("360", options[0].Value);
            Assert.AreEqual("360", options[0].Text);
            Assert.AreEqual("364", options[1].Value);
            Assert.AreEqual("364", options[1].Text);
            Assert.AreEqual("365", options[2].Value);
            Assert.AreEqual("365", options[2].Text);

            field = loan.Fields["2"];
            options = field.Descriptor.Options;
            Assert.IsNotNull(options);
            Assert.AreEqual(0, options.Count);
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_NoExtensionData()
        {
            var client = await GetTestClientAsync();
            var list = await client.Pipeline.ViewPipelineAsync(new PipelineParameters(new StringFieldFilter(CanonicalLoanField.LoanFolder, StringFieldMatchType.Exact, "IncludeAllFolders", false)), 200);
            var tasks = new List<Task>();
            foreach (var item in list)
            {
                tasks.Add(client.Loans.GetLoanAsync(item.LoanGuid).ContinueWith(async task =>
                {
                    var loan = await task;
                    AssertNoExtensionData(loan, "Loan", loan.EncompassId, true);
                }));
            }
            await Task.WhenAll(tasks);
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_FieldsPresentAddress()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            const string address = "123 Main Street";
            const string addressFieldId = "FR0104";
            loan.Fields[addressFieldId].Value = address;
            var loanId = await client.Loans.CreateLoanAsync(loan);
            try
            {
                await Task.Delay(1000);
                loan = await client.Loans.GetLoanAsync(loanId);
                Assert.AreEqual(address, loan.Fields[addressFieldId].ToString());
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
        [ApiTest]
        public async Task Loan_FieldsLoanEntity()
        {
            var client = await GetTestClientAsync();

            var fieldDescriptors = client.Loans.FieldDescriptors;

            FieldDescriptor fieldDescriptor = null;

            foreach (var pair in LoanFieldDescriptors.FieldMappings)
            {
                fieldDescriptor = fieldDescriptors[pair.Key];
                Assert.IsNotNull(fieldDescriptor.LoanEntity, pair.Key);
            }

            foreach (var pair in LoanFieldDescriptors.FieldPatternMappings)
            {
                fieldDescriptor = fieldDescriptors[string.Format(pair.Key, 1)];
                Assert.IsNotNull(fieldDescriptor.LoanEntity, pair.Key);
            }

            fieldDescriptor = fieldDescriptors["364"];
            Assert.AreEqual(LoanEntity.Loan, fieldDescriptor.LoanEntity);

            fieldDescriptor = fieldDescriptors["CX.ABC"];
            Assert.AreEqual(LoanEntity.CustomField, fieldDescriptor.LoanEntity);

            fieldDescriptor = fieldDescriptors["Log.MS.CurrentMilestone"];
            Assert.AreEqual(LoanEntity.VirtualFields, fieldDescriptor.LoanEntity);

            fieldDescriptor = fieldDescriptors["NEWHUD.X63"];
            Assert.AreEqual(LoanEntity.Gfe2010Fee, fieldDescriptor.LoanEntity);

            Assert.IsTrue(LoanFieldDescriptors.FieldMappings.TryAdd("NEWFIELD", "Loan.NewEntity[2].Borrower.BorrowerId", false));

            fieldDescriptor = fieldDescriptors["NEWFIELD"];
            Assert.IsNull(fieldDescriptor.LoanEntity);

            Assert.IsTrue(LoanFieldDescriptors.FieldMappings.TryRemove("NEWFIELD", out _));
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_FieldsFilterPath()
        {
            var client = await GetTestClientAsync();

            var fieldDescriptors = client.Loans.FieldDescriptors;
            var loanFields = new Loan(client).Fields;

            foreach (var pair in LoanFieldDescriptors.FieldMappings)
            {
                var fieldId = pair.Key;
                var fieldDescriptor = fieldDescriptors[fieldId];
                Assert.IsNotNull(fieldDescriptor.AttributePath, fieldId);
                var loanField = loanFields[fieldId];
                Assert.IsNotNull(loanField.AttributePath, fieldId);
            }

            foreach (var pair in LoanFieldDescriptors.FieldPatternMappings)
            {
                var fieldId = string.Format(pair.Key, 1);
                var fieldDescriptor = fieldDescriptors[fieldId];
                Assert.IsNotNull(fieldDescriptor.AttributePath, fieldId);
                var loanField = loanFields[fieldId];
                Assert.IsNotNull(loanField.AttributePath, fieldId);
            }

            Assert.AreEqual("/baseLoanAmount", fieldDescriptors["2"].AttributePath);
            Assert.AreEqual("/baseLoanAmount", loanFields["2"].AttributePath);
            Assert.AreEqual("/applications/*/borrower/taxIdentificationIdentifier", fieldDescriptors["65"].AttributePath);
            Assert.AreEqual("/applications/*/borrower/taxIdentificationIdentifier", loanFields["65"].AttributePath);
            Assert.AreEqual("/contacts[?(@/contactType == \"TITLE_COMPANY\")]/email", fieldDescriptors["88"].AttributePath);
            Assert.AreEqual("/contacts[?(@/contactType == \"TITLE_COMPANY\")]/email", loanFields["88"].AttributePath);
            Assert.AreEqual("/fhaVaLoan/energyEfficientMortgageItems/1/actualAmount", fieldDescriptors["EEM.X5"].AttributePath);
            Assert.AreEqual("/fhaVaLoan/energyEfficientMortgageItems/1/actualAmount", loanFields["EEM.X5"].AttributePath);
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_Recalculate()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client)
            {
                BorrowerRequestedLoanAmount = 200000M
            };
            var loanId = await client.Loans.CreateLoanAsync(loan, true);
            try
            {
                Assert.IsFalse(loan.Dirty);
                Assert.AreEqual(200000M, loan.BorrowerRequestedLoanAmount);
                Assert.AreEqual(200000M, loan.BaseLoanAmount);
                var retrievedLoan = await client.Loans.GetLoanAsync(loanId, new[] { LoanEntity.Loan });
                Assert.AreEqual(200000M, retrievedLoan.BorrowerRequestedLoanAmount);
                Assert.AreEqual(200000M, retrievedLoan.BaseLoanAmount);
                loan.BorrowerRequestedLoanAmount = 250000M;
                await client.Loans.UpdateLoanAsync(loan, true);
                Assert.IsFalse(loan.Dirty);
                Assert.AreEqual(250000M, loan.BorrowerRequestedLoanAmount);
                Assert.AreEqual(250000M, loan.BaseLoanAmount);
                retrievedLoan = await client.Loans.GetLoanAsync(loanId, new[] { LoanEntity.Loan });
                Assert.AreEqual(250000M, retrievedLoan.BorrowerRequestedLoanAmount);
                Assert.AreEqual(250000M, retrievedLoan.BaseLoanAmount);
                loan.BorrowerRequestedLoanAmount = 200000M;
                var loanAsJson = loan.ToString(SerializationOptions.Dirty);
                await client.Calculators.CalculateLoanAsync(loan);
                Assert.IsTrue(loan.Dirty);
                Assert.AreEqual(loanAsJson, loan.ToString(SerializationOptions.Dirty));
                Assert.AreEqual(200000M, loan.BorrowerRequestedLoanAmount);
                Assert.AreEqual(200000M, loan.BaseLoanAmount);
                retrievedLoan = await client.Loans.GetLoanAsync(loanId, new[] { LoanEntity.Loan });
                Assert.AreEqual(250000M, retrievedLoan.BorrowerRequestedLoanAmount);
                Assert.AreEqual(250000M, retrievedLoan.BaseLoanAmount);
                loan.AgencyCaseIdentifier = "987654321";
                await client.Loans.UpdateLoanAsync(loan, true);
                Assert.IsFalse(loan.Dirty);
                Assert.AreEqual("987654321", loan.AgencyCaseIdentifier);
                Assert.AreEqual(200000M, loan.BorrowerRequestedLoanAmount);
                Assert.AreEqual(200000M, loan.BaseLoanAmount);
                retrievedLoan = await client.Loans.GetLoanAsync(loanId, new[] { LoanEntity.Loan });
                Assert.AreEqual("987654321", retrievedLoan.AgencyCaseIdentifier);
                Assert.AreEqual(200000M, retrievedLoan.BorrowerRequestedLoanAmount);
                Assert.AreEqual(200000M, retrievedLoan.BaseLoanAmount);
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
        public void Loan_CustomFieldsGetById()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete

            var customFields = loan.CustomFields;
            for (var letter = 'A'; letter <= 'Z'; ++letter)
            {
                customFields.Add(new CustomField { FieldName = $"CX.{letter}", StringValue = letter.ToString() });
            }

            for (var number = '0'; number <= '9'; ++number)
            {
                Assert.IsNull(customFields.GetById($"CX.{number}"));
            }

            for (var letter = 'A'; letter <= 'Z'; ++letter)
            {
                var fieldId = $"CX.{letter}";
                var customField = customFields.GetById(fieldId);
                Assert.IsNotNull(customField);
                Assert.AreEqual(fieldId, customField.FieldName);
                Assert.AreEqual(letter.ToString(), customField.StringValue);
                customField.FieldName = $"CX.{letter}{letter}";
                Assert.IsNull(customFields.GetById(fieldId));
            }

            for (var letter = 'A'; letter <= 'Z'; ++letter)
            {
                var oldFieldId = $"CX.{letter}";
                Assert.IsNull(customFields.GetById(oldFieldId));
                var newFieldId = $"CX.{letter}{letter}";
                var customField = customFields.GetById(newFieldId);
                Assert.IsNotNull(customField);
                Assert.AreEqual(newFieldId, customField.FieldName);
                Assert.AreEqual(letter.ToString(), customField.StringValue);
                customFields.Remove(customField);
                customField.FieldName = oldFieldId;
                Assert.IsNull(customFields.GetById(newFieldId));
                Assert.IsNull(customFields.GetById(oldFieldId));
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_Populate()
        {
            var client = await GetTestClientAsync();
            var borrower = new Borrower
            {
                FirstName = "Bob",
                LastName = "Smith"
            };
            var priorResidence = new Residence
            {
                ResidencyType = ResidencyType.Prior,
                AddressStreetLine1 = "20153 Fifth Street",
                AddressCity = "Saint Charles",
                AddressState = State.MO,
                AddressPostalCode = "63303"
            };
            var currentResidence = new Residence
            {
                ResidencyType = ResidencyType.Current,
                AddressStreetLine1 = "123 Main Street",
                AddressCity = "Beverly Hills",
                AddressState = State.CA,
                AddressPostalCode = "90210"
            };
            var application = new Application
            {
                Borrower = borrower,
                Residences = new[] { currentResidence, priorResidence }
            };
            var residences = application.Residences;
            var loan = new Loan(client)
            {
                Applications = new[] { application }
            };
            var applications = loan.Applications;

            var loanId = await client.Loans.CreateLoanAsync(loan, true);
            try
            {
                Assert.AreSame(applications, loan.Applications);
                Assert.AreEqual(1, applications.Count);
                Assert.AreSame(application, applications[0]);
                Assert.AreSame(borrower, application.Borrower);
                Assert.AreSame(residences, application.Residences);
                Assert.AreEqual(2, residences.Count);
                Assert.AreSame(currentResidence, residences[0]);
                Assert.AreEqual(ResidencyType.Current.GetValue(), currentResidence.ResidencyType.Value);
                Assert.AreSame(priorResidence, residences[1]);
                Assert.AreEqual(ResidencyType.Prior.GetValue(), priorResidence.ResidencyType.Value);
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
        public void Loan_PropertyChanged()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            string propertyName = null;
            loan.PropertyChanged += PropertyChanged;

            var today = DateTime.Today;
            loan.AdverseActionDate = today;
            Assert.AreEqual(propertyName, nameof(loan.AdverseActionDate));
            propertyName = null;
            
            loan.AdverseActionDate = today;
            Assert.IsNull(propertyName);

            loan.AdverseActionDate = today.AddDays(1);
            Assert.AreEqual(propertyName, nameof(loan.AdverseActionDate));
            propertyName = null;

            loan.AgencyCaseIdentifier = null; // Already null
            Assert.IsNull(propertyName);

            loan.AgencyCaseIdentifier = "123";
            Assert.AreEqual(propertyName, nameof(loan.AgencyCaseIdentifier));
            propertyName = null;

            loan.AgencyCaseIdentifier = "123";
            Assert.IsNull(propertyName);

            loan.AgencyCaseIdentifier = null;
            Assert.AreEqual(propertyName, nameof(loan.AgencyCaseIdentifier));
            propertyName = null;

            loan.AlterationsImprovementsOrRepairsAmount = 5500M;
            Assert.AreEqual(propertyName, nameof(loan.AlterationsImprovementsOrRepairsAmount));
            propertyName = null;

            loan.AlterationsImprovementsOrRepairsAmount = 5500M;
            Assert.IsNull(propertyName);

            loan.AlterationsImprovementsOrRepairsAmount = 10000M;
            Assert.AreEqual(propertyName, nameof(loan.AlterationsImprovementsOrRepairsAmount));
            propertyName = null;

            loan.ApplicationTakenMethodType = ApplicationTakenMethodType.FaceToFace;
            Assert.AreEqual(propertyName, nameof(loan.ApplicationTakenMethodType));
            propertyName = null;

            loan.ApplicationTakenMethodType = ApplicationTakenMethodType.FaceToFace;
            Assert.IsNull(propertyName);

            loan.ApplicationTakenMethodType = ApplicationTakenMethodType.Internet;
            Assert.AreEqual(propertyName, nameof(loan.ApplicationTakenMethodType));
            propertyName = null;

            loan.BorrowerCoBorrowerMarriedIndicator = true;
            Assert.AreEqual(propertyName, nameof(loan.BorrowerCoBorrowerMarriedIndicator));
            propertyName = null;

            loan.BorrowerCoBorrowerMarriedIndicator = true;
            Assert.IsNull(propertyName);

            loan.BorrowerCoBorrowerMarriedIndicator = false;
            Assert.AreEqual(propertyName, nameof(loan.BorrowerCoBorrowerMarriedIndicator));
            propertyName = null;

            loan.LoanAmortizationTermMonths = 360;
            Assert.AreEqual(propertyName, nameof(loan.LoanAmortizationTermMonths));
            propertyName = null;

            loan.LoanAmortizationTermMonths = 360;
            Assert.IsNull(propertyName);

            loan.LoanAmortizationTermMonths = 180;
            Assert.AreEqual(propertyName, nameof(loan.LoanAmortizationTermMonths));
            propertyName = null;

            loan.AdditionalRequests = new AdditionalRequests();
            Assert.AreEqual(propertyName, nameof(loan.AdditionalRequests));
            propertyName = null;

            loan.AdditionalRequests = loan.AdditionalRequests;
            Assert.IsNull(propertyName);

            loan.AdditionalRequests = null;
            Assert.AreEqual(propertyName, nameof(loan.AdditionalRequests));
            propertyName = null;

            loan.Applications = new[] { new Application() };
            Assert.AreEqual(propertyName, nameof(loan.Applications));
            propertyName = null;

            loan.Applications = loan.Applications;
            Assert.IsNull(propertyName);

            loan.Applications = null;
            Assert.AreEqual(propertyName, nameof(loan.Applications));
            propertyName = null;

            loan.PropertyChanged -= PropertyChanged;

            void PropertyChanged(object sender, PropertyChangedEventArgs e)
            {
                propertyName = e.PropertyName;
            }
        }

        [TestMethod]
        public void Loan_NullableEntityProperty()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            Assert.IsNull(loan.ReferralSourceContact);
            loan.ReferralSourceContact = null;
            Assert.AreEqual(@"{""referralSourceContact"":null}", loan.ToString(SerializationOptions.Dirty));
            loan.ReferralSourceContact = new EntityReference("123", "BorrowerContact");
            Assert.AreEqual(@"{""referralSourceContact"":{""entityId"":""123"",""entityType"":""BorrowerContact""}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldDescriptions()
        {
            Assert.AreEqual("Trans Details Current Status Date", LoanFieldDescriptors.StandardFields["749"].Description);
            Assert.AreEqual("Closing Disclosure Page 3 - Due from Borrower at Closing (line 10) - Fee Account Type", LoanFieldDescriptors.StandardFields["CD3.X263"].Description);
            Assert.AreEqual("Affiliated Business Arrangements - Affiliate Name #5", LoanFieldDescriptors.StandardFields["AB0506"].Description);
            Assert.AreEqual("# of Co-Mortgagers", LoanFieldDescriptors.VirtualFields["COMORTGAGORCOUNT"].Description);
            Assert.AreEqual("Last Snapshot - AUS Tracking - Underwriting Risk Assess Type - 22", LoanFieldDescriptors.VirtualFields["AUSTRACKING.AUS.X1.22"].Description);
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_UpdateIncome()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan, true);

            try
            {
                var income = loan.CurrentApplication.Income.First(x => x.IncomeType == "OtherIncome" && x.OtherIncomeIndex == 1);
                income.Owner = BorrowerOrCoBorrower.CoBorrower;
                income.Description = Description.MilitaryCombatPay;
                income.Amount = 10000M;

                await client.Loans.UpdateLoanAsync(loan);

                loan = await client.Loans.GetLoanAsync(loanId);

                income = loan.CurrentApplication.Income.First(x => x.IncomeType == "OtherIncome" && x.OtherIncomeIndex == 1);

                Assert.AreEqual("CoBorrower", income.Owner.Value);
                Assert.AreEqual("MilitaryCombatPay", income.Description.Value);
                Assert.AreEqual(10000M, income.Amount);
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
        [ApiTest]
        public async Task Loan_UndefinedCustomFieldsError()
        {
            using (var client = await GetTestClientAsync(p => p.UndefinedCustomFieldHandling = UndefinedCustomFieldHandling.Error))
            {
                Assert.ThrowsException<ArgumentException>(() => client.Loans.FieldDescriptors["CX.ABC"]);
                Assert.ThrowsException<ArgumentException>(() => new Loan(client).Fields["CX.123"]);
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_UndefinedCustomFieldsErrorIfCustomFieldsInitialized()
        {
            using (var client = await GetTestClientAsync(p =>
                {
                    p.UndefinedCustomFieldHandling = UndefinedCustomFieldHandling.ErrorIfCustomFieldsInitialized;
                    p.CustomFieldsCacheInitialization = CacheInitialization.IfNotAlready;
                }))
            {
                Assert.ThrowsException<ArgumentException>(() => client.Loans.FieldDescriptors["CX.ABC"]);
                Assert.ThrowsException<ArgumentException>(() => new Loan(client).Fields["CX.123"]);
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_UndefinedCustomFieldsSucceedsIfCustomFieldsArentInitialized()
        {
            using (var client = await GetTestClientAsync(p =>
                {
                    p.UndefinedCustomFieldHandling = UndefinedCustomFieldHandling.ErrorIfCustomFieldsInitialized;
                }))
            {
                Assert.IsNotNull(client.Loans.FieldDescriptors["CX.ABC"]);
                Assert.IsNotNull(new Loan(client).Fields["CX.123"]);
            }
        }

        [ApiTest]
        [TestMethod]
        public async Task Loan_UpdateBaseIncome()
        {
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanAsync(new Loan(client));
            try
            {
                var loan = new Loan(client, loanId);
                loan.Fields["101"].Value = 500;

                await client.Loans.UpdateLoanAsync(loan);

                loan = await client.Loans.GetLoanAsync(loanId);

                Assert.AreEqual(500M, loan.Fields["101"].Value);
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

        [ApiTest]
        [TestMethod]
        public async Task Loan_UpdateOtherIncome()
        {
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanAsync(new Loan(client));
            try
            {
                var loan = new Loan(client, loanId);
                loan.Fields["149"].Value = 500;

                await client.Loans.UpdateLoanAsync(loan);

                loan = await client.Loans.GetLoanAsync(loanId);

                Assert.AreEqual(500M, loan.Fields["149"].Value);
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

        [ApiTest]
        [TestMethod]
        public async Task Loan_CreateFromImportFile()
        {
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanFromImportFileAsync(ImportFileType.FNMA32, @"		EH                                20190308   ENV1     
TH T100099-002TRAN1    
TPI1.00 01                              N
0001  3.20 W
00ANN
01A                                                                                                                                          0.00  0.000                                                                                                                                                                     
02A                                                                                                   F1                                                                                    
02B                                                                                                                                                          
02CTPO TPO TPO                                                 
02CTPO TPO TPO                                                 
03ABW991919991TPO                                                                   Firstimer                              5155555555 3316U 0N11111111119860307alice.f@fanniemae.com                                                           
03AQZ111111111TPO                                TPO                                TPO                                                     0N991919991                                                                ", new CreateLoanOptions { Populate = true }, out var loan);
            try
            {
                Assert.AreEqual("Firstimer", loan.Fields["4002"].ToString());
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
        public void Loan_SetReadOnlyFields()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var loan = new Loan();
#pragma warning restore CS0618 // Type or member is obsolete
            Assert.IsFalse(loan.Fields.AllowWritesToReadOnlyFieldsLocally);
            var standardField = loan.Fields["2"];
            Assert.IsNull(standardField.ToDecimal());
            var virtualField = loan.Fields["Log.MS.Date.Approval"];
            Assert.IsNull(virtualField.ToDateTime());
            Assert.ThrowsException<InvalidOperationException>(() => standardField.Value = 250000M);
            Assert.IsNull(standardField.ToDecimal());
            Assert.ThrowsException<InvalidOperationException>(() => virtualField.Value = DateTime.Today);
            Assert.IsNull(virtualField.ToDateTime());
            loan.Fields.AllowWritesToReadOnlyFieldsLocally = true;
            Assert.IsTrue(loan.Fields.AllowWritesToReadOnlyFieldsLocally);
            standardField.Value = 250000M;
            Assert.AreEqual(250000M, standardField.ToDecimal());
            virtualField.Value = DateTime.Today;
            Assert.AreEqual(DateTime.Today, virtualField.ToDateTime());
        }
    }
}