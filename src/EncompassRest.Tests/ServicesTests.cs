using System.Collections.Generic;
using EncompassRest.Services;
using EncompassRest.Services.Appraisal;
using EncompassRest.Services.AUS;
using EncompassRest.Services.Credit;
using EncompassRest.Services.Flood;
using EncompassRest.Services.Verification;
using EncompassRest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncompassRest.Tests
{
    [TestClass]
    public class ServicesTests : TestBaseClass
    {
        [TestMethod]
        public void Services_OrderCreditParametersSerialization()
        {
            var parameters = new OrderCreditParameters(
                new CreditProduct(
                    new EntityReference("0b683692-c314-4a03-9e75-f382397d3141#_borrower1", "urn:elli:encompass:loan:borrower"),
                    new CreditOptions(CreditRequestType.NewRequest)
                    {
                        DigiCert = true,
                        ReportOn = CreditReportOn.Individual,
                        ReportType = CreditReportType.Merge,
                        CreditReportIdentifier = "abc",
                        CreditBureauEquifax = true
                    })
                {
                    Credentials = new ServiceCredentials
                    {
                        UserName = "Joe",
                        Password = "password1"
                    },
                    Preferences = new CreditPreferences
                    {
                        ImportLiabilities = true
                    }
                });

            Assert.AreEqual($@"{{""product"":{{""options"":{{""requestType"":""NewRequest"",""digiCert"":true,""reportOn"":""Individual"",""reportType"":""Merge"",""creditReportIdentifier"":""abc"",""creditBureauEquifax"":true}},""preferences"":{{""importLiabilities"":true}},""entityRef"":{{""entityId"":""{parameters.Product.EntityRef.EntityId}"",""entityType"":""{parameters.Product.EntityRef.EntityType}""}},""name"":""CREDITIQ"",""credentials"":{{""userName"":""Joe"",""password"":""password1""}}}}}}", parameters.ToJson());
        }

        [TestMethod]
        public void Services_OrderEV4506TParametersSerialization()
        {
            var parameters = new OrderEV4506TParameters(
                new EV4506TProduct(
                    new EntityReference("0b683692-c314-4a03-9e75-f382397d3141#_borrower1", "urn:elli:encompass:loan:borrower"),
                    new EV4506TOptions(EV4506TRequestType.NewRequest)
                    {
                        DigiCert = true,
                        Product_1040 = EV4506TOrderProduct.Order,
                        TranscriptType_1040 = EV4506TTranscriptType.AccountTranscript
                    })
                {
                    Credentials = new ServiceCredentials
                    {
                        UserName = "Joe",
                        Password = "password1"
                    },
                    Preferences = new VerificationPreferences
                    {
                        ImportLiabilities = true
                    }
                });

            Assert.AreEqual($@"{{""product"":{{""options"":{{""requestType"":""newRequest"",""digiCert"":true,""product_1040"":""1"",""transcriptType_1040"":""Account Transcript""}},""preferences"":{{""importLiabilities"":true}},""entityRef"":{{""entityId"":""{parameters.Product.EntityRef.EntityId}"",""entityType"":""{parameters.Product.EntityRef.EntityType}""}},""name"":""VERIF"",""credentials"":{{""userName"":""Joe"",""password"":""password1""}}}}}}", parameters.ToJson());
        }

        [TestMethod]
        public void Services_OrderEVVOEParametersSerialization()
        {
            var parameters = new OrderEVVOEParameters(
                new EVVOEProduct(
                    new EntityReference("0b683692-c314-4a03-9e75-f382397d3141#_borrower1", "urn:elli:encompass:loan:borrower"),
                    new EVVOEOptions(EVVOERequestType.OrderVerification)
                    {
                        DigiCert = true,
                        ReportOn = EVVOEReportOn.CoBorrower,
                        Employment = EVVOEEmployment.EmploymentOnly
                    })
                {
                    Credentials = new ServiceCredentials
                    {
                        UserName = "Joe",
                        Password = "password1"
                    },
                    Preferences = new VerificationPreferences
                    {
                        ImportLiabilities = true
                    }
                });

            Assert.AreEqual($@"{{""product"":{{""options"":{{""requestType"":""OrderVerification"",""digiCert"":true,""reportOn"":""Co-Borrower"",""employment"":""EmploymentOnly""}},""preferences"":{{""importLiabilities"":true}},""entityRef"":{{""entityId"":""{parameters.Product.EntityRef.EntityId}"",""entityType"":""{parameters.Product.EntityRef.EntityType}""}},""name"":""VERIF"",""credentials"":{{""userName"":""Joe"",""password"":""password1""}}}}}}", parameters.ToJson());
        }

        [TestMethod]
        public void Services_OrderAUSParametersSerialization()
        {
            var parameters = new OrderAUSParameters(
                new AUSProduct(
                    new EntityReference("0b683692-c314-4a03-9e75-f382397d3141#_borrower1", "urn:elli:encompass:loan:borrower"),
                    new AUSOptions(AUSRequestType.NewOrder)
                    {
                        AUSReportIdentifier = "123",
                        OrderCreditDetails = new List<AUSOrderCreditDetail>
                        {
                            new AUSOrderCreditDetail
                            {
                                ApplicationId = "abc"
                            }
                        }
                    })
                {
                    Credentials = new AUSCredentials
                    {
                        UserName = "Joe",
                        Password = "password1",
                        LPPassword = "password2"
                    },
                    Preferences = new AUSPreferences
                    {
                        ConditionType = AUSConditionType.Underwriting
                    }
                });

            Assert.AreEqual($@"{{""product"":{{""options"":{{""requestType"":""newOrder"",""ausReportIdentifier"":""123"",""orderCreditDetails"":[{{""applicationId"":""abc""}}]}},""preferences"":{{""conditionType"":""underwriting""}},""credentials"":{{""lpPassword"":""password2"",""userName"":""Joe"",""password"":""password1""}},""entityRef"":{{""entityId"":""{parameters.Product.EntityRef.EntityId}"",""entityType"":""{parameters.Product.EntityRef.EntityType}""}},""name"":""AUS""}}}}", parameters.ToJson());
        }

        [TestMethod]
        public void Services_OrderAppraisalParametersSerialization()
        {
            var parameters = new OrderAppraisalParameters(
                new AppraisalProduct(
                    new EntityReference("0b683692-c314-4a03-9e75-f382397d3141#_borrower1", "urn:elli:encompass:loan:borrower"),
                    new AppraisalOptions(AppraisalRequestType.NewOrder)
                    {
                        LoanPurpose = AppraisalLoanPurpose.Purchase,
                        LoanType = AppraisalLoanType.VA,
                        PropertyType = AppraisalPropertyType.SingleFamily,
                        Contacts = new AppraisalContacts
                        {
                            AppointmentContact = "borrower",
                            Contact = new AppraisalContact
                            {
                                Borrower = new AppraisalContactBorrower
                                {
                                    Name = "George",
                                    State = "MO"
                                }
                            }
                        }
                    })
                {
                    Credentials = new AppraisalCredentials
                    {
                        UserName = "Joe",
                        Password = "password1",
                        AccountId = "ace"
                    }
                });

            Assert.AreEqual($@"{{""product"":{{""options"":{{""requestType"":""newOrder"",""loanPurpose"":""Purchase"",""loanType"":""VA"",""propertyType"":""Single Family"",""contacts"":{{""contact"":{{""borrower"":{{""state"":""MO"",""name"":""George""}}}},""appointmentContact"":""borrower""}}}},""credentials"":{{""accountId"":""ace"",""userName"":""Joe"",""password"":""password1""}},""entityRef"":{{""entityId"":""{parameters.Product.EntityRef.EntityId}"",""entityType"":""{parameters.Product.EntityRef.EntityType}""}},""name"":""APPRAISAL""}}}}", parameters.ToJson());
        }

        [TestMethod]
        public void Services_OrderFloodParametersSerialization()
        {
            var parameters = new OrderFloodParameters(
                new FloodProduct(
                    new EntityReference("0b683692-c314-4a03-9e75-f382397d3141#_borrower1", "urn:elli:encompass:loan:borrower"),
                    new FloodOptions(FloodRequestType.NewRequest)
                    {
                        ProductDetails = new FloodProductDetails
                        {
                            Name = FloodProductName.LifeOfLoanDetermination
                        }
                    })
                {
                    Credentials = new FloodCredentials
                    {
                        UserName = "Joe",
                        Password = "password1",
                        AccountId = "ace"
                    }
                });

            Assert.AreEqual($@"{{""product"":{{""options"":{{""requestType"":""newRequest"",""productDetails"":{{""name"":""Life of Loan Determination"",""id"":""26""}}}},""credentials"":{{""accountId"":""ace"",""userName"":""Joe"",""password"":""password1""}},""entityRef"":{{""entityId"":""{parameters.Product.EntityRef.EntityId}"",""entityType"":""{parameters.Product.EntityRef.EntityType}""}},""name"":""FLOOD""}}}}", parameters.ToJson());
        }
    }
}