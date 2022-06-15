using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using EncompassRest.Filters;
using EncompassRest.LoanPipeline.v1;
using EncompassRest.Loans;
using EncompassRest.Loans.Enums;
using EncompassRest.Loans.v3;
using EncompassRest.Utilities;
using EncompassRest.v3;
using EnumsNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EncompassRest.Tests
{
    [TestClass]
    public sealed class LoanV3Tests : LoanTests
    {
#pragma warning disable CS0618 // Type or member is obsolete
        public override ILoan ConstructLoan() => new Loan();
#pragma warning restore CS0618 // Type or member is obsolete

        public override ILoan ConstructLoan(IEncompassRestClient client) => new Loan(client);

        public override ILoan ConstructLoan(IEncompassRestClient client, string loanId) => new Loan(client, loanId);

        public override Task<string> CreateLoanAsync(IEncompassRestClient client, ILoan loan, bool populate = false) => client.Loans.CreateLoanAsync((Loan)loan, new LoanCreationOptions("My Pipeline") { View = populate ? LoanView.Full : LoanView.Id });

        public override Task DeleteLoanAsync(IEncompassRestClient client, string loanId) => client.Loans.DeleteLoanAsync(loanId);

        public override async Task<ILoan> GetLoanAsync(IEncompassRestClient client, string loanId) => await client.Loans.GetLoanAsync(loanId);

        public override Task UpdateLoanAsync(IEncompassRestClient client, ILoan loan, bool populate = false) => client.Loans.UpdateLoanAsync((Loan)loan, new LoanUpdateOptions { View = populate ? LoanView.Full : LoanView.Id });

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

            loan = new Loan(client);
            var loanId = await CreateLoanAsync(client, loan, true);
            Assert.IsNotNull(loanId);

            try
            {
                Assert.AreEqual(loanId, loan.Id);
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
                    await DeleteLoanAsync(client, loanId);
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
            loan.CustomFields.Add(new CustomField { FieldName = "CX.TEMP", Value = "TempValue" });
            Assert.AreEqual(@"{
  ""customFields"": [
    {
      ""fieldName"": ""CX.TEMP"",
      ""value"": ""TempValue""
    }
  ],
  ""dog"": true
}", loan.ToString(SerializationOptions.Indent));
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
            _ = JsonConvert.DeserializeAnonymousType(json, value);
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
            var customField = new CustomField { FieldName = "CUST91FV", Value = "Initial Value" };
            loan.CustomFields.Add(customField);
            loan.CustomFields.Add(new CustomField { FieldName = "CUST92FV", Value = 10.0M });
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CUST91FV"",""value"":""Initial Value""},{""fieldName"":""CUST92FV"",""value"":10.0}]}", loan.ToString(SerializationOptions.Dirty));
            loan.Dirty = false;
            Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
            customField.Value = "New Value";
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CUST91FV"",""value"":""New Value""}]}", loan.ToString(SerializationOptions.Dirty));
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
        public async Task Loan_CreateRawAndDelete()
        {
            var client = await GetTestClientAsync();
            var loanId = await client.Loans.CreateLoanRawAsync("{}", "?loanFolder=My Pipeline");
            Assert.IsNotNull(loanId);
            Assert.IsFalse(loanId.StartsWith("{"));
            await Task.Delay(5000);
            await client.Loans.DeleteLoanAsync(loanId);

            var json = await client.Loans.CreateLoanRawAsync("{}", "?loanFolder=My Pipeline&view=entity");
            Assert.IsNotNull(json);
            Assert.IsTrue(json.StartsWith("{"));
            var loan = JToken.Parse(json);
            loanId = loan["id"].ToString();
            await Task.Delay(5000);
            await client.Loans.DeleteLoanAsync(loanId);
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_BadUpdateException()
        {
            var client = await GetTestClientAsync();
            var loanId = await CreateLoanAsync(client, ConstructLoan(client));
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
                ex = await Assert.ThrowsExceptionAsync<EncompassRestException>(() => UpdateLoanAsync(client, loan));
                Assert.AreEqual(HttpStatusCode.NotFound, ex.StatusCode);
                Assert.AreEqual($@"{{""tltv"":85.00}}", ex.RequestContent);
            }
            finally
            {
                try
                {
                    await Task.Delay(5000);
                    await DeleteLoanAsync(client, loanId);
                }
                catch
                {
                }
            }
        }

        [TestMethod]
        [TestCategory("SkipWhenLiveUnitTesting")]
        public void Loan_FieldsValueAssignment()
        {
            var excludedFields = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "FE0509", "FE0609" };
            foreach (var fieldId in LoanFieldDescriptors.FieldMappings.FieldIds.Where(f => !excludedFields.Contains(f)))
            {
                var loan = ConstructLoan();
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
                                case LoanFieldValueType.Object:
                                    var o = "19";
                                    field.Value = o;
                                    Assert.AreEqual(o, (string)field.Value, fieldId);
                                    Assert.AreEqual(int.Parse(o), field.ToInt32(), fieldId);
                                    Assert.AreEqual(decimal.Parse(o), field.ToDecimal(), fieldId);
                                    break;
                                default:
                                    Assert.Fail($"Invalid LoanFieldValueType for {fieldId}");
                                    break;
                            }
                            Assert.IsFalse(field.IsEmpty);
                            Assert.AreNotEqual("{}", loan.ToString(SerializationOptions.Dirty));

                            ((IDirty)loan).Dirty = false;
                            Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));

                            field.Value = null;
                            Assert.IsNull(field.Value);
                            Assert.IsTrue(field.IsEmpty);
                            Assert.AreNotEqual("{}", loan.ToString(SerializationOptions.Dirty));
                            break;
                        case LoanFieldType.Virtual:
                            //var value = "Processing";

                            //Assert.ThrowsException<InvalidOperationException>(() => field.Value = value);

                            //loan.VirtualFields[field.FieldId] = value;
                            //Assert.IsFalse(field.IsEmpty);
                            //Assert.AreEqual(value, (string)field.Value);
                            //Assert.AreEqual(value, field.ToString());
                            //Assert.AreEqual($@"{{""virtualFields"":{{""{field.FieldId}"":""{value}""}}}}", loan.ToString(SerializationOptions.Dirty));

                            //Assert.ThrowsException<InvalidOperationException>(() => field.Value = null);

                            //loan.VirtualFields[field.FieldId] = null;
                            //Assert.IsTrue(field.IsEmpty);
                            //Assert.IsNull(field.Value);
                            //Assert.AreEqual($@"{{""virtualFields"":{{""{field.FieldId}"":null}}}}", loan.ToString(SerializationOptions.Dirty));
                            break;
                        default:
                            Assert.Fail($"Invalid LoanFieldType of {field.Descriptor.Type}");
                            break;
                    }
                }
            }
        }

        [TestMethod]
        public void Loan_FieldsCustomString()
        {
            var loan = ConstructLoan();
            var value = "ABC";
            var field = loan.Fields["CX.NAME"];
            Assert.AreEqual("loan.customFields[(fieldName == 'CX.NAME')].value", field.ModelPath);
            field.Value = value;
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""customFields"":[{{""fieldName"":""CX.NAME"",""value"":""{value}""}}]}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToString());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CX.NAME"",""value"":null}]}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsCustomDate()
        {
            var loan = ConstructLoan();
            var value = DateTime.Now;
            var field = loan.Fields["CX.NOW"];
            Assert.AreEqual("loan.customFields[(fieldName == 'CX.NOW')].value", field.ModelPath);
            field.Value = value;
            Assert.AreEqual(value, (DateTime?)field.Value);
            Assert.AreEqual(value, field.ToDateTime());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""customFields"":[{{""fieldName"":""CX.NOW"",""value"":{value.ToJson()}}}]}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToDateTime());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CX.NOW"",""value"":null}]}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToDateTime());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CX.NOW"",""value"":null}]}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsCustomNumeric()
        {
            var loan = ConstructLoan();
            var value = 1234.56M;
            var field = loan.Fields["CX.NUMBER"];
            Assert.AreEqual("loan.customFields[(fieldName == 'CX.NUMBER')].value", field.ModelPath);
            field.Value = value;
            Assert.AreEqual(value, (decimal?)field.Value);
            Assert.AreEqual(value, field.ToDecimal());
            Assert.AreEqual(1235, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""customFields"":[{{""fieldName"":""CX.NUMBER"",""value"":{value}}}]}}", loan.ToString(SerializationOptions.Dirty));
            var integerValue = 98765;
            field.Value = integerValue;
            Assert.AreEqual(integerValue, (int?)field.Value);
            Assert.AreEqual(integerValue, field.ToDecimal());
            Assert.AreEqual(integerValue, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""customFields"":[{{""fieldName"":""CX.NUMBER"",""value"":{integerValue}}}]}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToDecimal());
            Assert.IsNull(field.ToInt32());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CX.NUMBER"",""value"":null}]}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToDecimal());
            Assert.IsNull(field.ToInt32());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""customFields"":[{""fieldName"":""CX.NUMBER"",""value"":null}]}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsCUST100FV()
        {
            var loan = ConstructLoan();
            var value = 987.65M;
            var field = loan.Fields["CUST100FV"];
            Assert.AreEqual("loan.customFields[(fieldName == 'CUST100FV')].value", field.ModelPath);
            field.Value = value;
            Assert.AreEqual(value, (decimal?)field.Value);
            Assert.AreEqual(value, field.ToDecimal());
            Assert.AreEqual(988, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""customFields"":[{{""fieldName"":""CUST100FV"",""value"":{value}}}]}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsBP()
        {
            var loan = ConstructLoan();
            var value = "Joe";
            var field = loan.Fields["4000#2"];
            Assert.IsTrue(field.Descriptor.IsBorrowerPairSpecific);
            Assert.AreEqual(1, field.BorrowerPairIndex);
            Assert.AreEqual("loan.applications[2].borrower.firstName", field.ModelPath);
            field.Value = value;
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""applications"":[{{}},{{""borrower"":{{""firstName"":""{value}""}}}}]}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToString());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual($@"{{""applications"":[{{}},{{""borrower"":{{""firstName"":null}}}}]}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsComplex()
        {
            var loan = ConstructLoan();
            var field = loan.Fields["VEND.X5"];
            Assert.AreEqual("loan.contacts[(contactType == 'CUSTOM' && customContactIndex == '4')].state", field.ModelPath);
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            var value = "MO";
            field.Value = value;
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""contacts"":[{{""contactType"":""CUSTOM"",""customContactIndex"":4,""state"":""{value}""}}]}}", loan.ToString(SerializationOptions.Dirty));
            ((IDirty)loan).Dirty = false;
            Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
            value = "NY";
            field.Value = value;
            Assert.AreEqual(value, (string)field.Value);
            Assert.AreEqual(value, field.ToString());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""contacts"":[{{""contactType"":""CUSTOM"",""customContactIndex"":4,""state"":""{value}""}}]}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsCustomMapping()
        {
            Assert.IsTrue(LoanFieldDescriptors.FieldMappings.TryAdd("NEWFIELD", "loan.newEntity[2].borrower.borrowerId", false));
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

            Assert.IsTrue(LoanFieldDescriptors.FieldMappings.TryRemove("NEWFIELD", out _));
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
            foreach (var member in members)
            {
                var value = member.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name);
                var option = options.FirstOrDefault(o => string.Equals(o.Value, value, StringComparison.Ordinal));
                Assert.IsNotNull(option);
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
            var attribute = typeof(Hmda).GetProperty(nameof(Hmda.Aus2)).GetCustomAttribute<LoanFieldPropertyAttribute>();
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
            var list = await client.Pipeline.ViewPipelineAsync(new PipelineParameters(new StringFieldFilter(CanonicalLoanField.LoanFolder, StringFieldMatchType.Exact, "IncludeAllFolders", false), sortOrder: new[] { new FieldSort(CanonicalLoanField.DateCreated, SortOrder.Descending) }), 200);
            var tasks = new List<Task>();
            foreach (var item in list)
            {
                tasks.Add(GetLoanAsync(client, item.LoanGuid).ContinueWith(async (Task<ILoan> task) =>
                {
                    var loan = await task;
                    AssertNoExtensionData(loan, "Loan", loan.Id, true);
                    Assert.IsFalse(((IDirty)loan).Dirty);
                    Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
                }));
            }
            await Task.WhenAll(tasks);
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_FieldsLoanEntity()
        {
            var client = await GetTestClientAsync();

            var fieldDescriptors = client.Loans.GetFieldDescriptors();

            FieldDescriptor fieldDescriptor;

            foreach (var pair in LoanFieldDescriptors.FieldMappings)
            {
                fieldDescriptor = fieldDescriptors[pair.Key];
                if (fieldDescriptor.Type != LoanFieldType.Virtual)
                {
                    Assert.IsNotNull(fieldDescriptor.LoanEntity, pair.Key);
                }
            }

            foreach (var pair in LoanFieldDescriptors.FieldPatternMappings)
            {
                fieldDescriptor = fieldDescriptors[string.Format(pair.Key, 1)];
                if (fieldDescriptor.Type != LoanFieldType.Virtual)
                {
                    Assert.IsNotNull(fieldDescriptor.LoanEntity, pair.Key);
                }
            }

            fieldDescriptor = fieldDescriptors["364"];
            Assert.AreEqual(LoanEntity.Loan, fieldDescriptor.LoanEntity);

            fieldDescriptor = fieldDescriptors["CX.ABC"];
            Assert.AreEqual(LoanEntity.CustomFields, fieldDescriptor.LoanEntity);

            fieldDescriptor = fieldDescriptors["NEWHUD.X63"];
            Assert.AreEqual(LoanEntity.Gfe2010Fees, fieldDescriptor.LoanEntity);

            Assert.IsTrue(LoanFieldDescriptors.FieldMappings.TryAdd("NEWFIELD", "loan.newEntity[2].borrower.borrowerId", false));

            fieldDescriptor = fieldDescriptors["NEWFIELD"];
            Assert.IsNull(fieldDescriptor.LoanEntity);

            Assert.IsTrue(LoanFieldDescriptors.FieldMappings.TryRemove("NEWFIELD", out _));
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
                customFields.Add(new CustomField { FieldName = $"CX.{letter}", Value = letter.ToString() });
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
                Assert.AreEqual(letter.ToString(), customField.Value);
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
                Assert.AreEqual(letter.ToString(), customField.Value);
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
            
            var priorResidence = new Residence
            {
                ResidencyType = ResidencyType.Prior,
                AddressStreetLine1 = "20153 Fifth Street",
                AddressCity = "Saint Charles",
                AddressState = State.MO,
                AddressPostalCode = "63303",
                ApplicantType = BorrowerOrCoBorrower.Borrower
            };
            var currentResidence = new Residence
            {
                ResidencyType = ResidencyType.Current,
                AddressStreetLine1 = "123 Main Street",
                AddressCity = "Beverly Hills",
                AddressState = State.CA,
                AddressPostalCode = "90210",
                ApplicantType = BorrowerOrCoBorrower.Borrower
            };
            var borrower = new Borrower
            {
                FirstName = "Bob",
                LastName = "Smith",
                Residences = new List<Residence>
                {
                    currentResidence,
                    priorResidence
                }
            };
            var application = new Application
            {
                Borrower = borrower
            };
            var residences = application.Borrower.Residences;
            var loan = new Loan(client)
            {
                Applications = new[] { application }
            };
            var applications = loan.Applications;

            var loanId = await CreateLoanAsync(client, loan, true);
            try
            {
                Assert.AreSame(applications, loan.Applications);
                Assert.AreEqual(1, applications.Count);
                Assert.AreSame(application, applications[0]);
                Assert.AreSame(borrower, application.Borrower);
                Assert.AreSame(residences, application.Borrower.Residences);
                Assert.AreSame(currentResidence, residences[0]);
                Assert.AreEqual(ResidencyType.Current.GetValue(), currentResidence.ResidencyType.Value);
                Assert.AreSame(priorResidence, residences[1]);
                Assert.AreEqual(ResidencyType.Prior.GetValue(), priorResidence.ResidencyType.Value);
            }
            finally
            {
                try
                {
                    await DeleteLoanAsync(client, loanId);
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
        public async Task Loan_UndefinedCustomFieldsError()
        {
            using (var client = await GetTestClientAsync(p => p.UndefinedCustomFieldHandling = UndefinedCustomFieldHandling.Error))
            {
                Assert.ThrowsException<ArgumentException>(() => client.Loans.GetFieldDescriptors()["CX.ABC"]);
                Assert.ThrowsException<ArgumentException>(() => ConstructLoan(client).Fields["CX.123"]);
            }
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_UndefinedCustomFieldsErrorIfCustomFieldsInitialized()
        {
            using (var client = await GetTestClientAsync(p =>
            {
                p.UndefinedCustomFieldHandling = UndefinedCustomFieldHandling.ErrorIfCustomFieldsInitialized;
                p.AddV3CacheInitialization().CustomFieldsCacheInitialization = CacheInitialization.IfNotAlready;
            }))
            {
                Assert.ThrowsException<ArgumentException>(() => client.Loans.GetFieldDescriptors()["CX.ABC"]);
                Assert.ThrowsException<ArgumentException>(() => ConstructLoan(client).Fields["CX.123"]);
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
                Assert.IsNotNull(client.Loans.GetFieldDescriptors()["CX.ABC"]);
                Assert.IsNotNull(ConstructLoan(client).Fields["CX.123"]);
            }
        }
    }
}