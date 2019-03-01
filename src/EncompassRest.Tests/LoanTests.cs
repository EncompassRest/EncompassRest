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
            AssertNoUndefinedEnumOptions(supportedEntities, "SupportedEntities", new Dictionary<Type, HashSet<string>> { { typeof(LoanEntity), new HashSet<string>(new[] { "CoBorrower", "LOCompensation" }, StringComparer.OrdinalIgnoreCase) } });
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
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
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
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));

            var json = await client.Loans.CreateLoanRawAsync("{}", "?view=entity");
            Assert.IsNotNull(json);
            Assert.IsTrue(json.StartsWith("{"));
            var loan = JToken.Parse(json);
            loanId = loan["encompassId"].ToString();
            await Task.Delay(5000);
            Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
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
        public async Task Loan_CreateWithLoanTemplate()
        {
            var client = await GetTestClientAsync();
            if (client.AccessToken.Token == "Token")
            {
                var loan = new Loan(client);
                var loanId = await client.Loans.CreateLoanAsync(loan, new CreateLoanOptions { LoanTemplate = @"Public:\\Companywide\Example Purchase Loan Template", Populate = true });
                var metaData = await loan.LoanApis.GetMetadataAsync();
                await Task.Delay(5000);
                Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
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
                Assert.IsTrue(await client.Loans.DeleteLoanAsync(loanId));
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

                var fieldsWhereLockingCausesEncompassError = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "NEWHUD.X769", "NEWHUD.X770" };
                
                foreach (var fieldId in fieldsWhereLockingCausesEncompassError)
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
                    
                foreach (var pair in distinctFieldMappings)
                {
                    var field = loan.Fields[pair.Key];
                    Assert.AreEqual(pair.Value.ModelPath, field.ModelPath);
                    if (!fieldsWhereLockingCausesEncompassError.Contains(field.FieldId))
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
                    if (!fieldsWhereLockingCausesEncompassError.Contains(field.FieldId))
                    {
                        if (!field.Locked)
                        {
                            failedLockingFields.Add(field.FieldId);
                        }
                    }
                }

                var fieldsWithBadModelPaths = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "MORNET.X68", "181", "1416", "1417", "1418", "1419", "1519", "1520", "1521", "1522", "FR0504", "FR0506", "FR0507", "FR0508", "FR0524", "FR0515", "FR0512", "FR0599", "FR0598", "FR0624", "FR0607", "FR0606", "FR0604", "FR0608", "FR0615", "FR0612", "FR0698", "FR0699", "FR0324", "FR0306", "FR0307", "FR0304", "FR0308", "FR0312", "FR0315", "FR0399", "FR0398", "FR0404", "FR0407", "FR0406", "FR0408", "FR0415", "FR0412", "FR0424", "FR0498", "FR0499", "FR0224", "FR0207", "FR0206", "FR0204", "FR0208", "FR0212", "FR0215", "FR0298", "FR0299", "FR0104", "FR0106", "FR0107", "FR0108", "FR0124", "FR0112", "FR0115", "FR0199", "FR0198", "URLA.X197", "URLA.X198", "URLA.X10", "URLA.X11", "URLA.X12", "URLA.X9", "URLA.X8", "URLA.X7" };

                var fieldsUnableToLock = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "4177", "4175", "4174", "4178", "NEWHUD.X720", "NEWHUD2.X3728", "NEWHUD2.X3761", "NEWHUD2.X3794", "NEWHUD2.X3530", "NEWHUD2.X3563", "NEWHUD2.X3596", "NEWHUD2.X3629", "NEWHUD2.X3695", "NEWHUD2.X3662", "NEWHUD2.X3365", "NEWHUD2.X3332", "NEWHUD2.X3398", "NEWHUD2.X3431", "NEWHUD2.X3464", "NEWHUD2.X3497", "NEWHUD2.X3167", "NEWHUD2.X3134", "NEWHUD2.X3101", "NEWHUD2.X3266", "NEWHUD2.X3233", "NEWHUD2.X3200", "NEWHUD2.X3299", "NEWHUD2.X3068", "NEWHUD2.X3035", "NEWHUD2.X3002", "CD1.X52", "CD1.X53", "CD1.X54", "CD1.X55", "CD1.X56", "CD1.X57", "CD1.X58", "CD1.X59", "CD1.X67", "CD1.X66", "CD1.X68", "NEWHUD.X13", "NEWHUD2.X3992", "NEWHUD2.X3959", "NEWHUD2.X3926",  "NEWHUD2.X3893", "NEWHUD2.X3860", "NEWHUD2.X3827", "NMLS.X4", "NEWHUD2.X2705", "NEWHUD2.X2738", "NEWHUD2.X2771", "NEWHUD2.X2606", "NEWHUD2.X2639", "NEWHUD2.X2672", "NEWHUD2.X2507", "NEWHUD2.X2573", "NEWHUD2.X2540", "NEWHUD2.X2408", "NEWHUD2.X2441", "NEWHUD2.X2474", "NEWHUD2.X2342", "NEWHUD2.X2375", "NEWHUD2.X2309", "NEWHUD2.X2243", "NEWHUD2.X2276", "NEWHUD2.X2210", "NEWHUD2.X2177", "NEWHUD2.X2144", "NEWHUD2.X2111", "NEWHUD2.X2045", "NEWHUD2.X2078", "NEWHUD2.X2012", "NEWHUD2.X2969", "NEWHUD2.X2936", "NEWHUD2.X2903", "NEWHUD2.X2870", "NEWHUD2.X2804", "NEWHUD2.X2837", "NEWHUD2.X2832", "NEWHUD2.X1517", "NEWHUD2.X1550", "NEWHUD2.X1583", "NEWHUD2.X1715", "NEWHUD2.X1748", "NEWHUD2.X1781", "NEWHUD2.X1418", "NEWHUD2.X1451", "NEWHUD2.X1484", "NEWHUD2.X1154", "NEWHUD2.X1121", "NEWHUD2.X1187", "NEWHUD2.X1616", "NEWHUD2.X1649", "NEWHUD2.X1682", "NEWHUD2.X1352", "NEWHUD2.X1319", "NEWHUD2.X1385", "NEWHUD2.X1055", "NEWHUD2.X1022", "NEWHUD2.X1088", "NEWHUD2.X1253", "NEWHUD2.X1220", "NEWHUD2.X1286", "NEWHUD2.X1946", "NEWHUD2.X1979", "NEWHUD2.X1913", "NEWHUD2.X428", "NEWHUD2.X461", "NEWHUD2.X494", "NEWHUD2.X626", "NEWHUD2.X659", "NEWHUD2.X692", "NEWHUD2.X1880", "NEWHUD2.X1847", "NEWHUD2.X1814", "NEWHUD2.X527", "NEWHUD2.X593", "NEWHUD2.X560", "NEWHUD2.X725", "NEWHUD2.X758", "NEWHUD2.X791", "NEWHUD2.X263", "NEWHUD2.X230", "NEWHUD2.X296", "NEWHUD2.X362", "NEWHUD2.X329", "NEWHUD2.X395", "NEWHUD2.X890", "NEWHUD2.X857", "NEWHUD2.X824", "334", "NEWHUD2.X989", "NEWHUD2.X956", "NEWHUD2.X4124", "NEWHUD2.X4157", "NEWHUD2.X4190", "NEWHUD2.X4025", "NEWHUD2.X4058", "NEWHUD2.X4091", "NEWHUD2.X4322", "NEWHUD2.X4355", "NEWHUD2.X4388", "NEWHUD2.X4223", "NEWHUD2.X4256", "NEWHUD2.X4289", "NEWHUD2.X4540", "NEWHUD2.X4573", "NEWHUD2.X4507", "NEWHUD2.X4474", "NEWHUD2.X4606", "LE1.X83", "LE1.X82", "LE1.X81", "LE1.X80", "LE1.X84", "LE1.X78", "LE1.X79", "NEWHUD2.X4764", "NEWHUD2.X4765", "NEWHUD2.X4766", "NEWHUD2.X4767", "RE88395.X316", "FR0126", "FR0127", "FR0125", "FR0128", "FR0225", "FR0227", "FR0226", "FR0228", "FR0325", "FR0326", "FR0327", "FR0328", "FR0427", "FR0426", "FR0425", "FR0428", "HMDA.X117", "HMDA.X116", "HMDA.X119", "HMDA.X118", "FE0602", "FE0604", "FE0605", "FE0606", "FE0607", "FE0609", "FE0610", "FE0612", "FE0615", "FE0614", "FE0617", "FE0502", "FE0507", "FE0506", "FE0505", "FE0504", "FE0509", "FE0512", "FE0510", "FE0517", "FE0514", "FE0515", "FE0203", "FE0222", "FE0223", "FE0220", "FE0221", "FE0216", "FE0213", "FE0219", "FE0233", "FE0299", "FE0298", "FE0121", "FE0120", "FE0123", "FE0122", "FE0133", "FE0103", "FE0116", "FE0113", "FE0119", "FE0198", "FE0199" };

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
                var fieldPatternMappings = LoanFieldDescriptors.FieldPatternMappings.Where(p => !p.Key.StartsWith("TQL4506T") && !p.Key.StartsWith("LP") && !p.Key.StartsWith("CX.") && !p.Key.StartsWith("FBE") && !p.Key.StartsWith("FCE") && !p.Key.StartsWith("XCOC") && !p.Key.StartsWith("CUST") && !p.Key.StartsWith("DD")).ToList();
                foreach (var pair in fieldPatternMappings)
                {
                    var fieldPattern = pair.Key;
                    for (var i = 1; i <= patternCount; ++i)
                    {
                        var field = loan.Fields[string.Format(fieldPattern, i)];
                        Assert.AreEqual(string.Format(pair.Value, i), field.ModelPath);
                        if (field.Descriptor.Type != LoanFieldType.Virtual)
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
            Assert.AreEqual("true", options[0].Value);
            Assert.AreEqual("Yes", options[0].Text);
            Assert.AreEqual("false", options[1].Value);
            Assert.AreEqual("No", options[1].Text);

            field = loan.Fields["100"];
            options = field.Descriptor.Options;
            Assert.AreEqual(2, options.Count);
            Assert.AreEqual("true", options[0].Value);
            Assert.AreEqual("Borrower / Co-Borrower are Married", options[0].Text);
            Assert.AreEqual("false", options[1].Value);
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
                await client.Loans.UpdateLoanAsync(loan, new UpdateLoanOptions { Populate = true, Persistent = false });
                Assert.IsFalse(loan.Dirty);
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
                Assert.AreEqual(ResidencyType.Current.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name), currentResidence.ResidencyType.Value);
                Assert.AreSame(priorResidence, residences[1]);
                Assert.AreEqual(ResidencyType.Prior.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name), priorResidence.ResidencyType.Value);
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
    }
}