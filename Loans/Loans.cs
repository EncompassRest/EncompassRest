using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EncompassRest.Exceptions;
using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Documents;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public class Loans
    {
        private const string _apiPath = "encompass/v1/loans";
        private readonly List<string> _supportedEntities = new List<string> {
            "AdditionalRequests",
            "AdditionalStateDisclosure",
            "AffiliatedBusinessArrangement",
            "AntiSteeringLoanOption",
            "Application",
            "Asset",
            "AUSTrackingLog",
            "ATRQMBorrower",
            "ATRQMCommon",
            "Borrower",
            "CoBorrower",
            "Buydown",
            "ClosingCost",
            "ClosingDisclosure1",
            "ClosingDisclosure2",
            "ClosingDisclosure3",
            "ClosingDisclosure4",
            "ClosingDisclosure5",
            "ClosingDocument",
            "ClosingEntity",
            "CommitmentTerms",
            "ComplianceTestLog",
            "Contact",
            "ConstructionManagement",
            "ConversationLog",
            "Correspondent",
            "CrmLog",
            "CustomField",
            "DataTracLog",
            "DisclosureForm",
            "DisclosureNotices",
            "DisclosureTracking2015Log",
            "DisclosureTrackingLog",
            "DocumentLog",
            "DownloadLog",
            "DownPayment",
            "EdmDocument",
            "EdmLog",
            "ElliLOCompensation",
            "EmailTriggerLog",
            "EmDocumentInvestor",
            "EmDocumentLender",
            "EmDocument",
            "Employment",
            "EnergyEfficientMortgageItem",
            "EnergyEfficientMortgage",
            "EscrowDisbursementTransaction",
            "EscrowInterestTransaction",
            "FannieMae",
            "Fee",
            "FeeVariance",
            "FeeVarianceOther",
            "FhaVaLoan",
            "Form",
            "FreddieMac",
            "Funding",
            "Gfe2010Fee",
            "Gfe2010FwbcFwsc",
            "Gfe2010GfeCharge",
            "Gfe2010",
            "Gfe2010Page",
            "Gfe2010Section",
            "Gfe2010WholePoc",
            "GfeFee",
            "GfeLien",
            "Gfe",
            "GfePayment",
            "GfePayoff",
            "HelocRepaymentDrawPeriod",
            "Hmda",
            "HomeCounselingProvider",
            "HtmlEmailLog",
            "Hud1EsDate",
            "Hud1EsDueDate",
            "Hud1EsItemize",
            "Hud1Es",
            "Hud1EsPayTo",
            "Hud1EsSetup",
            "HudLoanData",
            "Income",
            "InterimServicing",
            "InterimServicingTransaction",
            "Liability",
            "Loan",
            "LoanAssociate",
            "LoanEstimate1",
            "LoanEstimate2",
            "LoanEstimate3",
            "LoanProductData",
            "LoanProgram",
            "LoanSubmissionFee",
            "LoanSubmission",
            "LockCancellationLog",
            "LockConfirmLog",
            "LockDenialLog",
            "LockRequestBorrower",
            "LockRequestLog",
            "LOCompensation",
            "LogAlert",
            "LogComment",
            "LogEntryLog",
            "LogRecord",
            "LogSnapshotField",
            "Mcaw",
            "MilestoneFreeRoleLog",
            "MilestoneLog",
            "MilestoneTaskContact",
            "MilestoneTaskLog",
            "MilestoneTemplateLog",
            "MilitaryService",
            "Miscellaneous",
            "NetTangibleBenefit",
            "NewYorkFee",
            "NewYorkPrimaryLender",
            "OtherTransaction",
            "PaymentReversalTransaction",
            "PaymentTransaction",
            "PostClosingConditionLog",
            "PreliminaryConditionLog",
            "PrepaymentPenalty",
            "Prequalification",
            "PrequalificationScenario",
            "PreviousVaLoan",
            "PriceAdjustment",
            "PrintForm",
            "PrintLog",
            "PrivacyPolicy",
            "ProfitManagementItem",
            "ProfitManagement",
            "Property",
            "PurchaseAdvicePayout",
            "PurchaseCredit",
            "RateLock",
            "RegistrationLog",
            "RegulationZInterestRatePeriod",
            "RegulationZ",
            "RegulationZPayment",
            "ReoProperty",
            "Residence",
            "RespaHudDetail",
            "SchedulePaymentTransaction",
            "SecondaryFinancingProvider",
            "Section32",
            "SelectedHomeCounselingProvider",
            "SelfEmployedIncome",
            "ServiceProviderContact",
            "ServicingDisclosure",
            "SettlementServiceCharge",
            "ShippingContact",
            "Shipping",
            "StateDisclosure",
            "StateLicense",
            "StatementCreditDenial",
            "StatusOnlineEvent",
            "StatusOnlineLog",
            "Tax4506",
            "TPO",
            "TQLComplianceAlert",
            "TQLDocument",
            "TQLFraudAlert",
            "TQL",
            "TQLReportInformation",
            "TrustAccountItem",
            "TrustAccount",
            "Tsum",
            "UCDDetail",
            "Uldd",
            "UnderwriterSummary",
            "UnderwritingConditionLog",
            "UsdaHouseholdIncome",
            "Usda",
            "VaLoanData",
            "VerificationLog",
            "LoanActionLog",
            "FieldLockData",
            "FundingFee"
        };

        #region Public Properties
        public EncompassRestClient Client { get; }
        #endregion

        public Loans(EncompassRestClient client)
        {
            Client = client;
        }

        public LoanDocuments GetLoanDocuments(string loanId)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return new LoanDocuments(Client, loanId);
        }

        public LoanAttachments GetLoanAttachments(string loanId)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return new LoanAttachments(Client, loanId);
        }

        public async Task<Loan> GetLoanAsync(string loanId, IEnumerable<string> entities = null)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                var exList = entities.Except(_supportedEntities);
                if (exList.Any())
                {
                    throw new InvalidEntitiesException(exList);
                }
                queryParameters.Add("entities", string.Join(",", entities));
            }

            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/{loanId}{queryParameters}"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw response.StatusCode == HttpStatusCode.NotFound ? new FileNotFoundException("loan not found", loanId) : (Exception)new RestException(nameof(GetLoanAsync), response);
                }

                var loan = new Loan(Client, loanId);
                var json = await response.Content.ReadAsStringAsync();
                JsonHelper.PopulateFromJson(json, loan);
                return loan;
            }
        }

        public async Task<IEnumerable<string>> GetSupportedEntitiesAsync()
        {
            using (var response = await Client.HttpClient.GetAsync($"{_apiPath}/supportedEntities"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(GetSupportedEntitiesAsync), response);
                }

                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<string>>(content);
            }
        }

        public async Task<string> CreateLoanAsync(Loan loan)
        {
            Preconditions.NotNull(loan, nameof(loan));

            using (var response = await Client.HttpClient.PostAsync(_apiPath, JsonContent.Create(loan)))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(CreateLoanAsync), response);
                }

                var location = response.Headers.Location.OriginalString;
                return location.Substring(location.LastIndexOf('/') + 1);
            }
        }

        public async Task UpdateLoanAsync(Loan loan)
        {
            Preconditions.NotNull(loan, nameof(loan));

            using (var response = await Client.HttpClient.PatchAsync($"{_apiPath}/{loan.EncompassId}", JsonContent.Create(loan)))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw response.StatusCode == HttpStatusCode.Conflict ? new LoanLockedException(nameof(UpdateLoanAsync), response) : new RestException(nameof(UpdateLoanAsync), response);
                }
            }
        }

        public async Task DeleteLoanAsync(string loanId)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            using (var response = await Client.HttpClient.DeleteAsync($"{_apiPath}/{loanId}"))
            {
                if (!response.IsSuccessStatusCode)
                {
                    throw new RestException(nameof(DeleteLoanAsync), response);
                }
            }
        }
    }
}