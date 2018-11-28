using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Loans.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class LoanConditionsTests : TestBaseClass
    {
        [TestMethod]
        public async Task LoanConditions_GetUnderwritingConditions()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);
            try
            {
                await Task.Delay(1000);
                var underwritingConditions = loan.LoanApis.Conditions.Underwriting;
                var conditions = await underwritingConditions.GetConditionsAsync();
                Assert.IsNotNull(conditions);
                Assert.AreEqual(0, conditions.Count);
                var addedCondition = new UnderwritingCondition { Title = "ABC", Source = ConditionSource.RecordersOffice, ForAllApplications = true };
                await underwritingConditions.CreateConditionsAsync(new[] { addedCondition });
                var conditionId = addedCondition.Id;
                Assert.IsFalse(string.IsNullOrEmpty(conditionId));
                await Task.Delay(1000);
                conditions = await underwritingConditions.GetConditionsAsync();
                Assert.IsNotNull(conditions);
                Assert.AreEqual(1, conditions.Count);
                Assert.AreEqual(addedCondition.Title, conditions[0].Title);
                Assert.AreEqual(addedCondition.Source.Value, conditions[0].Source.Value);
                Assert.AreEqual(addedCondition.ForAllApplications, conditions[0].ForAllApplications);
                AssertNoExtensionData(conditions[0], "Conditions[0]", conditions[0].Title);
                var retrievedCondition = await underwritingConditions.GetConditionAsync(conditionId);
                Assert.IsNotNull(retrievedCondition);
                Assert.AreEqual(addedCondition.Title, retrievedCondition.Title);
                Assert.AreEqual(addedCondition.Source.Value, retrievedCondition.Source.Value);
                Assert.AreEqual(addedCondition.ForAllApplications, retrievedCondition.ForAllApplications);
                AssertNoExtensionData(retrievedCondition, "RetrievedCondition", retrievedCondition.Title);
                addedCondition.Title = "DEF";
                addedCondition.ForAllApplications = true;
                await underwritingConditions.UpdateConditionsAsync(new[] { addedCondition });
                await Task.Delay(1000);
                retrievedCondition = await underwritingConditions.GetConditionAsync(conditionId);
                Assert.AreEqual(addedCondition.Title, retrievedCondition.Title);
                Assert.IsTrue(await underwritingConditions.DeleteConditionsAsync(new[] { conditionId }));
                await Task.Delay(1000);
                Assert.AreEqual(0, (await underwritingConditions.GetConditionsAsync()).Count);
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
        public async Task LoanConditions_GetPostClosingConditions()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);
            try
            {
                await Task.Delay(1000);
                var postClosingConditions = loan.LoanApis.Conditions.PostClosing;
                var conditions = await postClosingConditions.GetConditionsAsync();
                Assert.IsNotNull(conditions);
                Assert.AreEqual(0, conditions.Count);
                var addedCondition = new PostClosingCondition { Title = "ABC", Source = ConditionSource.RecordersOffice, ForAllApplications = true };
                var conditionId = await postClosingConditions.CreateConditionAsync(addedCondition);
                Assert.IsFalse(string.IsNullOrEmpty(conditionId));
                await Task.Delay(1000);
                conditions = await postClosingConditions.GetConditionsAsync();
                Assert.IsNotNull(conditions);
                Assert.AreEqual(1, conditions.Count);
                Assert.AreEqual(addedCondition.Title, conditions[0].Title);
                Assert.AreEqual(addedCondition.Source.Value, conditions[0].Source.Value);
                Assert.AreEqual(addedCondition.ForAllApplications, conditions[0].ForAllApplications);
                AssertNoExtensionData(conditions[0], "Conditions[0]", conditions[0].Title);
                var retrievedCondition = await postClosingConditions.GetConditionAsync(conditionId);
                Assert.IsNotNull(retrievedCondition);
                Assert.AreEqual(addedCondition.Title, retrievedCondition.Title);
                Assert.AreEqual(addedCondition.Source.Value, retrievedCondition.Source.Value);
                Assert.AreEqual(addedCondition.ForAllApplications, retrievedCondition.ForAllApplications);
                AssertNoExtensionData(retrievedCondition, "RetrievedCondition", retrievedCondition.Title);
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
        public async Task LoanConditions_GetPreliminaryConditions()
        {
            var client = await GetTestClientAsync();
            var loan = new Loan(client);
            var loanId = await client.Loans.CreateLoanAsync(loan);
            try
            {
                await Task.Delay(1000);
                var preliminaryConditions = loan.LoanApis.Conditions.Preliminary;
                var conditions = await preliminaryConditions.GetConditionsAsync();
                Assert.IsNotNull(conditions);
                Assert.AreEqual(0, conditions.Count);
                var addedCondition = new PreliminaryCondition { Title = "ABC", Source = ConditionSource.RecordersOffice, ForAllApplications = true };
                var conditionId = await preliminaryConditions.CreateConditionAsync(addedCondition);
                Assert.IsFalse(string.IsNullOrEmpty(conditionId));
                await Task.Delay(1000);
                conditions = await preliminaryConditions.GetConditionsAsync();
                Assert.IsNotNull(conditions);
                Assert.AreEqual(1, conditions.Count);
                Assert.AreEqual(addedCondition.Title, conditions[0].Title);
                Assert.AreEqual(addedCondition.Source.Value, conditions[0].Source.Value);
                Assert.AreEqual(addedCondition.ForAllApplications, conditions[0].ForAllApplications);
                AssertNoExtensionData(conditions[0], "Conditions[0]", conditions[0].Title);
                var retrievedCondition = await preliminaryConditions.GetConditionAsync(conditionId);
                Assert.IsNotNull(retrievedCondition);
                Assert.AreEqual(addedCondition.Title, retrievedCondition.Title);
                Assert.AreEqual(addedCondition.Source.Value, retrievedCondition.Source.Value);
                Assert.AreEqual(addedCondition.ForAllApplications, retrievedCondition.ForAllApplications);
                AssertNoExtensionData(retrievedCondition, "RetrievedCondition", retrievedCondition.Title);
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