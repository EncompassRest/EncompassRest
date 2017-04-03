using EncompassREST.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EncompassREST.HelperClasses;
using EncompassREST.Exceptions;

namespace EncompassREST
{
    public class Loans
    {
        
        private string API_PATH = "encompass/v1/loans";
        private Session _Session;
        private List<string> supportedEntities = new List<string> {
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
  "FundingFee"};
        #region private properties
        private AccessToken _AccessToken
        {
            get
            {
                return _Session.AccessToken;
            }
        }

        private HttpClient client
        {
            get { return _Session.RESTClient; }
        }
        #endregion

        #region public properties
        public Session Session
        {
            get { return _Session; }
        }
        #endregion


        public Loans(Session Session)
        {
            _Session = Session;
        }

        public async Task<Data.Loan> GetLoanAsync(string GUID)
        {
            return await GetLoanAsync(GUID, null);
        }

        public async Task<Data.Loan> GetLoanAsync(string GUID, IEnumerable<string> entities)
        {
            //TaskCompletionSource<Loan> tcs = new TaskCompletionSource<Loan>();
            RequestParameters rp = new RequestParameters();
            if (entities!= null)
            {
                if (entities.Count() > 0)
                {
                    //var eList = await GetSupportedEntitiesAsync();
                    var exList = entities.Except(supportedEntities);
                    if (exList.Count() > 0)
                        throw new InvalidEntitiesException(exList);
                    rp.Add("entities", string.Join(",", entities));
                }
            }
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, string.Format("{0}/{1}{2}", API_PATH, GUID, rp.ToString()));

            var response = await client.SendAsync(message);
                //await client.GetAsync(API_PATH + "/" + GUID + rp.ToString());
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Data.Loan l = new Loan(_Session); 
                await l.PopulateLoan(await response.Content.ReadAsStringAsync(), _Session);
                return l;
                //tcs.TrySetResult(l);
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new FileNotFoundException("GUID Not found",GUID);
                //tcs.TrySetException(new FileNotFoundException("GUID Not Found", GUID));
            }
            else
            {
                throw new RESTException("GetLoanAsync",response);
                //tcs.TrySetException(new RESTException("GetLoanAsync", response));
            }
            //return tcs.Task;
        }

        public async Task<Data.Loan> PostLoanAsync(Data.Loan Loan)
        {
            return await PostLoanAsync(Loan.JsonValue);
        }
        
        public async Task<Data.Loan> PostLoanAsync(string LoanData)
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Post, string.Format("{0}", API_PATH));
            message.Content = new StringContent(LoanData, Encoding.UTF8, "application/json");

            var response = await _Session.RESTClient.SendAsync(message);
                //await _Session.RESTClient.PostAsync(API_PATH, new StringContent(LoanData, Encoding.UTF8, "application/json"));
            if (response.StatusCode == HttpStatusCode.Created)
            {
                var GUID = response.Headers.Location.ToString().Split('/').Last();
                return await GetLoanAsync(GUID);
            }
            else
            {
                throw new RESTException("PostLoanAsync", response);
            }
        }

        public async Task<Data.Loan> PatchLoanAsync(Data.Loan Loan)
        {
            return await PatchLoanAsync(Loan.JsonValue, Loan.encompassId);
        }
        
        public async Task<Data.Loan> PatchLoanAsync(string LoanData, string GUID)
        {
            HttpRequestMessage message = new HttpRequestMessage(new HttpMethod("PATCH"), string.Format("{0}/{1}", API_PATH, GUID));
            message.Content = new StringContent(LoanData, Encoding.UTF8, "application/json");

            var response = await _Session.RESTClient.SendAsync(message);
                //await _Session.RESTClient.PatchAsync(API_PATH + "/" + GUID, new StringContent(LoanData, Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                return await GetLoanAsync(GUID);
            }
            else if (response.StatusCode == HttpStatusCode.Conflict) //409
            {
                throw new LoanLockedException("PatchLoanAsync", response);
            }
            else
            {
                throw new RESTException("PatchLoanAsync", response);
            }
        }

        public async Task<Data.Loan> DeleteLoanAsync(string GUID)
        {
            if (GUID == "")
                throw new InvalidOperationException("Missing GUID");

            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Delete, string.Format("{0}/{1}", API_PATH, GUID));

            var response = await client.SendAsync(message);
                //await client.DeleteAsync(API_PATH + "/" + GUID);
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                Data.Loan tloan = null;
                try
                {
                    tloan = await GetLoanAsync(GUID);
                }
                catch (FileNotFoundException)
                {
                    
                }
                return tloan;
            }
            else
            {
                throw new RESTException("DeleteLoanAsync", response);
            }
        }

        public async Task<IEnumerable<string>> GetSupportedEntitiesAsync()
        {
            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Get, string.Format("{0}/supportedEntities", API_PATH));
            var response = await client.SendAsync(message);
                //await client.GetAsync(API_PATH + "/supportedEntities");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                var c = content.Replace(((char)65279).ToString(),"");
                var data  = JsonConvert.DeserializeObject<IEnumerable<string>>(c);
                return data;
            }
            else
            {
                throw new RESTException("GetSupportedEntitiesAsync", response);
            }
        }


    }
}
