using System;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Loans.Enums;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    public abstract class LoanTests : TestBaseClass
    {
        public abstract ILoan ConstructLoan();

        public abstract ILoan ConstructLoan(IEncompassRestClient client);

        public abstract ILoan ConstructLoan(IEncompassRestClient client, string loanId);

        public abstract Task<string> CreateLoanAsync(IEncompassRestClient client, ILoan loan, bool populate = false);

        public abstract Task DeleteLoanAsync(IEncompassRestClient client, string loanId);

        public abstract Task<ILoan> GetLoanAsync(IEncompassRestClient client, string loanId);

        public abstract Task UpdateLoanAsync(IEncompassRestClient client, ILoan loan, bool populate = false);

        [TestMethod]
        [ApiTest]
        public async Task Loan_Clone()
        {
            var client = await GetTestClientAsync();
            var loanId = await CreateLoanAsync(client, ConstructLoan(client));
            try
            {
                await Task.Delay(5000);
                var loan = await GetLoanAsync(client, loanId);
                var clonedLoan = loan.Clone();
                var loanAsJson = loan.ToString(SerializationOptions.Indent);
                var clonedLoanAsJson = clonedLoan.ToString(SerializationOptions.Indent);
                Assert.AreEqual(loanAsJson, clonedLoanAsJson);
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
        public void Loan_Empty_Serialization()
        {
            var loan = ConstructLoan();
            Assert.AreEqual("{}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        [ApiTest]
        public async Task Loan_CreateAndDelete()
        {
            var client = await GetTestClientAsync();
            var loan = ConstructLoan(client);
            var loanId = await CreateLoanAsync(client, loan, true);
            Assert.IsNotNull(loanId);
            Assert.AreEqual(loanId, loan.Id);
            await Task.Delay(5000);
            await DeleteLoanAsync(client, loanId);
        }

        [TestMethod]
        public void Loan_FieldsAssignField()
        {
            var loan = ConstructLoan();
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
            var loan = ConstructLoan();
            var loanNumber = "9876543210";
            var field = loan.Fields["364"];
            Assert.AreEqual("Loan.LoanNumber", field.ModelPath, ignoreCase: true);
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
            var loan = ConstructLoan();
            var now = DateTime.Now;
            var field = loan.Fields["CD1.X1"];
            Assert.AreEqual("Loan.ClosingCost.ClosingDisclosure1.CDDateIssued", field.ModelPath, ignoreCase: true);
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
            var loan = ConstructLoan();
            var borrowerRequestedLoanAmount = 185000;
            var field = loan.Fields["1109"];
            Assert.AreEqual("Loan.BorrowerRequestedLoanAmount", field.ModelPath, ignoreCase: true);
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
            var loan = ConstructLoan();
            var bltv = 75;
            var field = loan.Fields["4012"];
            Assert.AreEqual("Loan.BLTV", field.ModelPath, ignoreCase: true);
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
            var loan = ConstructLoan();
            var borrowerCoBorrowerMarriedIndicator = true;
            var field = loan.Fields["100"];
            Assert.AreEqual("Loan.BorrowerCoBorrowerMarriedIndicator", field.ModelPath, ignoreCase: true);
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
            var loan = ConstructLoan();
            var applicationTakenMethodType = "Internet";
            var field = loan.Fields["479"];
            Assert.AreEqual("Loan.ApplicationTakenMethodType", field.ModelPath, ignoreCase: true);
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
            var loan = ConstructLoan();
            var income = 4000;
            var field = loan.Fields["HMDA.X32"];
            Assert.AreEqual("Loan.Hmda.Income", field.ModelPath, ignoreCase: true);
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
        public void Loan_FieldsStringDecimalValue()
        {
            var loan = ConstructLoan();
            var rateSpread = 3;
            var field = loan.Fields["HMDA.X15"];
            Assert.AreEqual("Loan.Hmda.RateSpread", field.ModelPath, ignoreCase: true);
            field.Value = rateSpread;
            Assert.AreEqual(rateSpread.ToString(), (string)field.Value);
            Assert.AreEqual(rateSpread.ToString(), field.ToString());
            Assert.AreEqual(rateSpread, field.ToDecimal());
            Assert.AreEqual(rateSpread, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""hmda"":{{""rateSpread"":""{rateSpread}""}}}}", loan.ToString(SerializationOptions.Dirty));
            rateSpread = 5;
            field.Value = rateSpread.ToString();
            Assert.AreEqual(rateSpread.ToString(), (string)field.Value);
            Assert.AreEqual(rateSpread.ToString(), field.ToString());
            Assert.AreEqual(rateSpread, field.ToDecimal());
            Assert.AreEqual(rateSpread, field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""hmda"":{{""rateSpread"":""{rateSpread}""}}}}", loan.ToString(SerializationOptions.Dirty));
            var stringValue = "Exempt";
            field.Value = stringValue;
            Assert.AreEqual(stringValue, (string)field.Value);
            Assert.AreEqual(stringValue, field.ToString());
            Assert.IsNull(field.ToDecimal());
            Assert.IsNull(field.ToInt32());
            Assert.IsFalse(field.IsEmpty);
            Assert.AreEqual($@"{{""hmda"":{{""rateSpread"":""{stringValue}""}}}}", loan.ToString(SerializationOptions.Dirty));
            field.Value = null;
            Assert.IsNull(field.Value);
            Assert.IsNull(field.ToString());
            Assert.IsNull(field.ToDecimal());
            Assert.IsNull(field.ToInt32());
            Assert.IsTrue(field.IsEmpty);
            Assert.AreEqual(@"{""hmda"":{""rateSpread"":null}}", loan.ToString(SerializationOptions.Dirty));
        }

        [TestMethod]
        public void Loan_FieldsLPNN126()
        {
            var loan = ConstructLoan();
            var field = loan.Fields["LP01126"];
            Assert.AreEqual("Loan.LoanPrograms[1].TerminationFeeAmount", field.ModelPath, ignoreCase: true);
        }


        [TestMethod]
        public void Loan_FieldsInvalidField()
        {
            var loan = ConstructLoan();
            Assert.ThrowsException<ArgumentException>(() => loan.Fields["1"]);
        }

        [TestMethod]
        public void Loan_FieldsZeroBased()
        {
            var loan = ConstructLoan();
            var field = loan.Fields["3669"];
            Assert.AreEqual("Loan.MilestoneTemplateLogs[0].IsTemplateLocked", field.ModelPath, ignoreCase: true);
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

            //Assert.IsFalse(field.Locked);
            //field.Locked = true;
            //Assert.IsTrue(field.Locked);
        }

        [TestMethod]
        public void Loan_FieldUpdateReadOnlyField()
        {
            var loan = ConstructLoan();
            var field = loan.Fields["2"];
            Assert.IsTrue(field.IsEmpty);
            Assert.IsNull(field.Value);
            Assert.IsTrue(field.ReadOnly);
            var value = 200000M;
            Assert.ThrowsException<InvalidOperationException>(() => field.Value = value);
        }

        [TestMethod]
        public void Loan_SetReadOnlyFields()
        {
            var loan = ConstructLoan();
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

        [TestMethod]
        [ApiTest]
        public async Task Loan_FieldsPresentAddress()
        {
            var client = await GetTestClientAsync();
            var loan = ConstructLoan(client);
            const string address = "123 Main Street";
            const string addressFieldId = "FR0104";
            loan.Fields[addressFieldId].Value = address;
            var loanId = await CreateLoanAsync(client, loan);
            try
            {
                await Task.Delay(1000);
                loan = await GetLoanAsync(client, loanId);
                Assert.AreEqual(address, loan.Fields[addressFieldId].ToString());
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
        [ApiTest]
        public async Task Loan_UpdateIncome()
        {
            var client = await GetTestClientAsync();
            var loan = ConstructLoan(client);
            var loanId = await CreateLoanAsync(client, loan, populate: true);

            try
            {
                loan.Fields["144"].Value = BorrowerOrCoBorrower.CoBorrower;
                loan.Fields["145"].Value = Description.MilitaryCombatPay;
                loan.Fields["146"].Value = 10000M;

                await UpdateLoanAsync(client, loan);

                loan = await GetLoanAsync(client, loanId);

                Assert.AreEqual("CoBorrower", loan.Fields["144"].ToString());
                Assert.AreEqual("MilitaryCombatPay", loan.Fields["145"].ToString());
                Assert.AreEqual(10000M, loan.Fields["146"].ToDecimal());
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

        [ApiTest]
        [TestMethod]
        public async Task Loan_UpdateOtherIncome()
        {
            var client = await GetTestClientAsync();
            var loan = ConstructLoan(client);
            var loanId = await CreateLoanAsync(client, loan, populate: true);
            try
            {
                loan.Fields["149"].Value = 500;

                Assert.AreEqual(500M, loan.Fields["149"].Value);

                await UpdateLoanAsync(client, loan);

                loan = await GetLoanAsync(client, loanId);

                Assert.AreEqual(500M, loan.Fields["149"].Value);
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
    }
}