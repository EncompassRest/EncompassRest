using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Miscellaneous : IDirty
    {
        private DirtyValue<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private DirtyValue<string> _borrowerDescription1;
        public string BorrowerDescription1 { get { return _borrowerDescription1; } set { _borrowerDescription1 = value; } }
        private DirtyValue<string> _borrowerDescription2;
        public string BorrowerDescription2 { get { return _borrowerDescription2; } set { _borrowerDescription2 = value; } }
        private DirtyValue<string> _borrowerDescription3;
        public string BorrowerDescription3 { get { return _borrowerDescription3; } set { _borrowerDescription3 = value; } }
        private DirtyValue<string> _borrowerDescription4;
        public string BorrowerDescription4 { get { return _borrowerDescription4; } set { _borrowerDescription4 = value; } }
        private DirtyValue<string> _borrowerDescription5;
        public string BorrowerDescription5 { get { return _borrowerDescription5; } set { _borrowerDescription5 = value; } }
        private DirtyValue<string> _borrowerDescription6;
        public string BorrowerDescription6 { get { return _borrowerDescription6; } set { _borrowerDescription6 = value; } }
        private DirtyValue<string> _borrowerDescription7;
        public string BorrowerDescription7 { get { return _borrowerDescription7; } set { _borrowerDescription7 = value; } }
        private DirtyValue<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private DirtyValue<string> _closingCostProgramFile;
        public string ClosingCostProgramFile { get { return _closingCostProgramFile; } set { _closingCostProgramFile = value; } }
        private DirtyValue<string> _closingTaxYear;
        public string ClosingTaxYear { get { return _closingTaxYear; } set { _closingTaxYear = value; } }
        private DirtyValue<decimal?> _closingTaxYearInterestReceived;
        public decimal? ClosingTaxYearInterestReceived { get { return _closingTaxYearInterestReceived; } set { _closingTaxYearInterestReceived = value; } }
        private DirtyValue<string> _contactFax;
        public string ContactFax { get { return _contactFax; } set { _contactFax = value; } }
        private DirtyValue<string> _contactName;
        public string ContactName { get { return _contactName; } set { _contactName = value; } }
        private DirtyValue<string> _contactPhone;
        public string ContactPhone { get { return _contactPhone; } set { _contactPhone = value; } }
        private DirtyValue<string> _contactTitle;
        public string ContactTitle { get { return _contactTitle; } set { _contactTitle = value; } }
        private DirtyValue<bool?> _copyFromSubjectProperty;
        public bool? CopyFromSubjectProperty { get { return _copyFromSubjectProperty; } set { _copyFromSubjectProperty = value; } }
        private DirtyValue<string> _dataTracLoanId;
        public string DataTracLoanId { get { return _dataTracLoanId; } set { _dataTracLoanId = value; } }
        private DirtyValue<string> _docSetFile;
        public string DocSetFile { get { return _docSetFile; } set { _docSetFile = value; } }
        private DirtyValue<int?> _factorForRevolvingDebt;
        public int? FactorForRevolvingDebt { get { return _factorForRevolvingDebt; } set { _factorForRevolvingDebt = value; } }
        private DirtyValue<bool?> _fannieDuAutoOrderIndicator;
        public bool? FannieDuAutoOrderIndicator { get { return _fannieDuAutoOrderIndicator; } set { _fannieDuAutoOrderIndicator = value; } }
        private DirtyValue<bool?> _fannieEcAutoOrderIndicator;
        public bool? FannieEcAutoOrderIndicator { get { return _fannieEcAutoOrderIndicator; } set { _fannieEcAutoOrderIndicator = value; } }
        private DirtyValue<string> _floodInsuranceExcluded;
        public string FloodInsuranceExcluded { get { return _floodInsuranceExcluded; } set { _floodInsuranceExcluded = value; } }
        private DirtyValue<string> _formListFile;
        public string FormListFile { get { return _formListFile; } set { _formListFile = value; } }
        private DirtyValue<bool?> _freddieLPAAutoOrderIndicator;
        public bool? FreddieLPAAutoOrderIndicator { get { return _freddieLPAAutoOrderIndicator; } set { _freddieLPAAutoOrderIndicator = value; } }
        private DirtyValue<bool?> _freddieLQAAutoOrderIndicator;
        public bool? FreddieLQAAutoOrderIndicator { get { return _freddieLQAAutoOrderIndicator; } set { _freddieLQAAutoOrderIndicator = value; } }
        private DirtyValue<decimal?> _housingExpenseIntRate1;
        public decimal? HousingExpenseIntRate1 { get { return _housingExpenseIntRate1; } set { _housingExpenseIntRate1 = value; } }
        private DirtyValue<decimal?> _housingExpenseIntRate2;
        public decimal? HousingExpenseIntRate2 { get { return _housingExpenseIntRate2; } set { _housingExpenseIntRate2 = value; } }
        private DirtyValue<decimal?> _housingExpenseLoanAmt1;
        public decimal? HousingExpenseLoanAmt1 { get { return _housingExpenseLoanAmt1; } set { _housingExpenseLoanAmt1 = value; } }
        private DirtyValue<decimal?> _housingExpenseLoanAmt2;
        public decimal? HousingExpenseLoanAmt2 { get { return _housingExpenseLoanAmt2; } set { _housingExpenseLoanAmt2 = value; } }
        private DirtyValue<decimal?> _housingExpensePayment1;
        public decimal? HousingExpensePayment1 { get { return _housingExpensePayment1; } set { _housingExpensePayment1 = value; } }
        private DirtyValue<decimal?> _housingExpensePayment2;
        public decimal? HousingExpensePayment2 { get { return _housingExpensePayment2; } set { _housingExpensePayment2 = value; } }
        private DirtyValue<int?> _housingExpenseTerm1;
        public int? HousingExpenseTerm1 { get { return _housingExpenseTerm1; } set { _housingExpenseTerm1 = value; } }
        private DirtyValue<int?> _housingExpenseTerm2;
        public int? HousingExpenseTerm2 { get { return _housingExpenseTerm2; } set { _housingExpenseTerm2 = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _isSameAddresswithPayer;
        public bool? IsSameAddresswithPayer { get { return _isSameAddresswithPayer; } set { _isSameAddresswithPayer = value; } }
        private DirtyValue<string> _line1006Excluded;
        public string Line1006Excluded { get { return _line1006Excluded; } set { _line1006Excluded = value; } }
        private DirtyValue<string> _line1007Excluded;
        public string Line1007Excluded { get { return _line1007Excluded; } set { _line1007Excluded = value; } }
        private DirtyValue<string> _line1008Excluded;
        public string Line1008Excluded { get { return _line1008Excluded; } set { _line1008Excluded = value; } }
        private DirtyValue<string> _line1010Excluded;
        public string Line1010Excluded { get { return _line1010Excluded; } set { _line1010Excluded = value; } }
        private DirtyValue<string> _loanProgramFile;
        public string LoanProgramFile { get { return _loanProgramFile; } set { _loanProgramFile = value; } }
        private DirtyValue<string> _loanTemplateFile;
        public string LoanTemplateFile { get { return _loanTemplateFile; } set { _loanTemplateFile = value; } }
        private DirtyValue<string> _maventATRQMResult;
        public string MaventATRQMResult { get { return _maventATRQMResult; } set { _maventATRQMResult = value; } }
        private DirtyValue<bool?> _maventAutoOrderIndicator;
        public bool? MaventAutoOrderIndicator { get { return _maventAutoOrderIndicator; } set { _maventAutoOrderIndicator = value; } }
        private DirtyValue<string> _maventCraxResult;
        public string MaventCraxResult { get { return _maventCraxResult; } set { _maventCraxResult = value; } }
        private DirtyValue<string> _maventEnterpriseResult;
        public string MaventEnterpriseResult { get { return _maventEnterpriseResult; } set { _maventEnterpriseResult = value; } }
        private DirtyValue<string> _maventGseResult;
        public string MaventGseResult { get { return _maventGseResult; } set { _maventGseResult = value; } }
        private DirtyValue<string> _maventHighCostResult;
        public string MaventHighCostResult { get { return _maventHighCostResult; } set { _maventHighCostResult = value; } }
        private DirtyValue<string> _maventHmdaResult;
        public string MaventHmdaResult { get { return _maventHmdaResult; } set { _maventHmdaResult = value; } }
        private DirtyValue<string> _maventHpmlResult;
        public string MaventHpmlResult { get { return _maventHpmlResult; } set { _maventHpmlResult = value; } }
        private DirtyValue<string> _maventLicenseResult;
        public string MaventLicenseResult { get { return _maventLicenseResult; } set { _maventLicenseResult = value; } }
        private DirtyValue<string> _maventNmlsResult;
        public string MaventNmlsResult { get { return _maventNmlsResult; } set { _maventNmlsResult = value; } }
        private DirtyValue<string> _maventOfacResult;
        public string MaventOfacResult { get { return _maventOfacResult; } set { _maventOfacResult = value; } }
        private DirtyValue<string> _maventOrderedBy;
        public string MaventOrderedBy { get { return _maventOrderedBy; } set { _maventOrderedBy = value; } }
        private DirtyValue<DateTime?> _maventOrderedDate;
        public DateTime? MaventOrderedDate { get { return _maventOrderedDate; } set { _maventOrderedDate = value; } }
        private DirtyValue<string> _maventOtherResult;
        public string MaventOtherResult { get { return _maventOtherResult; } set { _maventOtherResult = value; } }
        private DirtyValue<string> _maventReviewResult;
        public string MaventReviewResult { get { return _maventReviewResult; } set { _maventReviewResult = value; } }
        private DirtyValue<string> _maventStateResult;
        public string MaventStateResult { get { return _maventStateResult; } set { _maventStateResult = value; } }
        private DirtyValue<string> _maventTilaRorResult;
        public string MaventTilaRorResult { get { return _maventTilaRorResult; } set { _maventTilaRorResult = value; } }
        private DirtyValue<string> _maventTilaToleranceResult;
        public string MaventTilaToleranceResult { get { return _maventTilaToleranceResult; } set { _maventTilaToleranceResult = value; } }
        private DirtyValue<decimal?> _mIPremiums;
        public decimal? MIPremiums { get { return _mIPremiums; } set { _mIPremiums = value; } }
        private DirtyValue<string> _miscDataFile;
        public string MiscDataFile { get { return _miscDataFile; } set { _miscDataFile = value; } }
        private DirtyValue<int?> _monthsToExclude;
        public int? MonthsToExclude { get { return _monthsToExclude; } set { _monthsToExclude = value; } }
        private DirtyValue<string> _optimalBlueHistoryData;
        public string OptimalBlueHistoryData { get { return _optimalBlueHistoryData; } set { _optimalBlueHistoryData = value; } }
        private DirtyValue<string> _optimalBlueRequest;
        public string OptimalBlueRequest { get { return _optimalBlueRequest; } set { _optimalBlueRequest = value; } }
        private DirtyValue<string> _optimalBlueResponse;
        public string OptimalBlueResponse { get { return _optimalBlueResponse; } set { _optimalBlueResponse = value; } }
        private DirtyValue<decimal?> _otherPresentHousingExpense;
        public decimal? OtherPresentHousingExpense { get { return _otherPresentHousingExpense; } set { _otherPresentHousingExpense = value; } }
        private DirtyValue<decimal?> _outstandingMtgPrincipal;
        public decimal? OutstandingMtgPrincipal { get { return _outstandingMtgPrincipal; } set { _outstandingMtgPrincipal = value; } }
        private DirtyValue<DateTime?> _outstandingMtgPrincipalDate;
        public DateTime? OutstandingMtgPrincipalDate { get { return _outstandingMtgPrincipalDate; } set { _outstandingMtgPrincipalDate = value; } }
        private DirtyValue<bool?> _participateHomePoints;
        public bool? ParticipateHomePoints { get { return _participateHomePoints; } set { _participateHomePoints = value; } }
        private DirtyValue<string> _partnerEmail;
        public string PartnerEmail { get { return _partnerEmail; } set { _partnerEmail = value; } }
        private DirtyValue<string> _partnerName;
        public string PartnerName { get { return _partnerName; } set { _partnerName = value; } }
        private DirtyValue<string> _partnerPhone;
        public string PartnerPhone { get { return _partnerPhone; } set { _partnerPhone = value; } }
        private DirtyValue<decimal?> _pointsPaid;
        public decimal? PointsPaid { get { return _pointsPaid; } set { _pointsPaid = value; } }
        private DirtyValue<DateTime?> _rateRegistrationExpirationDate;
        public DateTime? RateRegistrationExpirationDate { get { return _rateRegistrationExpirationDate; } set { _rateRegistrationExpirationDate = value; } }
        private DirtyValue<string> _rateRegistrationInvestorName;
        public string RateRegistrationInvestorName { get { return _rateRegistrationInvestorName; } set { _rateRegistrationInvestorName = value; } }
        private DirtyValue<bool?> _rateRegistrationLoanIsRegistered;
        public bool? RateRegistrationLoanIsRegistered { get { return _rateRegistrationLoanIsRegistered; } set { _rateRegistrationLoanIsRegistered = value; } }
        private DirtyValue<string> _rateRegistrationReference;
        public string RateRegistrationReference { get { return _rateRegistrationReference; } set { _rateRegistrationReference = value; } }
        private DirtyValue<string> _rateRegistrationRegisteredBy;
        public string RateRegistrationRegisteredBy { get { return _rateRegistrationRegisteredBy; } set { _rateRegistrationRegisteredBy = value; } }
        private DirtyValue<string> _rateRegistrationRegisteredUserId;
        public string RateRegistrationRegisteredUserId { get { return _rateRegistrationRegisteredUserId; } set { _rateRegistrationRegisteredUserId = value; } }
        private DirtyValue<DateTime?> _rateRegistrationRegistrationDate;
        public DateTime? RateRegistrationRegistrationDate { get { return _rateRegistrationRegistrationDate; } set { _rateRegistrationRegistrationDate = value; } }
        private DirtyValue<decimal?> _refundOrOverpaidInterest;
        public decimal? RefundOrOverpaidInterest { get { return _refundOrOverpaidInterest; } set { _refundOrOverpaidInterest = value; } }
        private DirtyValue<string> _schoolTaxExcluded;
        public string SchoolTaxExcluded { get { return _schoolTaxExcluded; } set { _schoolTaxExcluded = value; } }
        private DirtyValue<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private DirtyValue<string> _statusUrl;
        public string StatusUrl { get { return _statusUrl; } set { _statusUrl = value; } }
        private DirtyValue<DateTime?> _submitDate;
        public DateTime? SubmitDate { get { return _submitDate; } set { _submitDate = value; } }
        private DirtyValue<string> _subTaxYear;
        public string SubTaxYear { get { return _subTaxYear; } set { _subTaxYear = value; } }
        private DirtyValue<decimal?> _subTaxYearInterestReceived;
        public decimal? SubTaxYearInterestReceived { get { return _subTaxYearInterestReceived; } set { _subTaxYearInterestReceived = value; } }
        private DirtyValue<decimal?> _subTaxYearMIPremiums;
        public decimal? SubTaxYearMIPremiums { get { return _subTaxYearMIPremiums; } set { _subTaxYearMIPremiums = value; } }
        private DirtyValue<decimal?> _subTaxYearPointsPaid;
        public decimal? SubTaxYearPointsPaid { get { return _subTaxYearPointsPaid; } set { _subTaxYearPointsPaid = value; } }
        private DirtyValue<decimal?> _subTaxYearRefundOrOverpaidInterest;
        public decimal? SubTaxYearRefundOrOverpaidInterest { get { return _subTaxYearRefundOrOverpaidInterest; } set { _subTaxYearRefundOrOverpaidInterest = value; } }
        private DirtyValue<string> _taxId;
        public string TaxId { get { return _taxId; } set { _taxId = value; } }
        private DirtyValue<decimal?> _totalBox4;
        public decimal? TotalBox4 { get { return _totalBox4; } set { _totalBox4 = value; } }
        private DirtyValue<decimal?> _totalYearlyMi;
        public decimal? TotalYearlyMi { get { return _totalYearlyMi; } set { _totalYearlyMi = value; } }
        private DirtyValue<string> _useGfeTax;
        public string UseGfeTax { get { return _useGfeTax; } set { _useGfeTax = value; } }
        private DirtyValue<string> _useRegZMi;
        public string UseRegZMi { get { return _useRegZMi; } set { _useRegZMi = value; } }
        private DirtyValue<string> _zip;
        public string Zip { get { return _zip; } set { _zip = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _address.Dirty
                    || _borrowerDescription1.Dirty
                    || _borrowerDescription2.Dirty
                    || _borrowerDescription3.Dirty
                    || _borrowerDescription4.Dirty
                    || _borrowerDescription5.Dirty
                    || _borrowerDescription6.Dirty
                    || _borrowerDescription7.Dirty
                    || _city.Dirty
                    || _closingCostProgramFile.Dirty
                    || _closingTaxYear.Dirty
                    || _closingTaxYearInterestReceived.Dirty
                    || _contactFax.Dirty
                    || _contactName.Dirty
                    || _contactPhone.Dirty
                    || _contactTitle.Dirty
                    || _copyFromSubjectProperty.Dirty
                    || _dataTracLoanId.Dirty
                    || _docSetFile.Dirty
                    || _factorForRevolvingDebt.Dirty
                    || _fannieDuAutoOrderIndicator.Dirty
                    || _fannieEcAutoOrderIndicator.Dirty
                    || _floodInsuranceExcluded.Dirty
                    || _formListFile.Dirty
                    || _freddieLPAAutoOrderIndicator.Dirty
                    || _freddieLQAAutoOrderIndicator.Dirty
                    || _housingExpenseIntRate1.Dirty
                    || _housingExpenseIntRate2.Dirty
                    || _housingExpenseLoanAmt1.Dirty
                    || _housingExpenseLoanAmt2.Dirty
                    || _housingExpensePayment1.Dirty
                    || _housingExpensePayment2.Dirty
                    || _housingExpenseTerm1.Dirty
                    || _housingExpenseTerm2.Dirty
                    || _id.Dirty
                    || _isSameAddresswithPayer.Dirty
                    || _line1006Excluded.Dirty
                    || _line1007Excluded.Dirty
                    || _line1008Excluded.Dirty
                    || _line1010Excluded.Dirty
                    || _loanProgramFile.Dirty
                    || _loanTemplateFile.Dirty
                    || _maventATRQMResult.Dirty
                    || _maventAutoOrderIndicator.Dirty
                    || _maventCraxResult.Dirty
                    || _maventEnterpriseResult.Dirty
                    || _maventGseResult.Dirty
                    || _maventHighCostResult.Dirty
                    || _maventHmdaResult.Dirty
                    || _maventHpmlResult.Dirty
                    || _maventLicenseResult.Dirty
                    || _maventNmlsResult.Dirty
                    || _maventOfacResult.Dirty
                    || _maventOrderedBy.Dirty
                    || _maventOrderedDate.Dirty
                    || _maventOtherResult.Dirty
                    || _maventReviewResult.Dirty
                    || _maventStateResult.Dirty
                    || _maventTilaRorResult.Dirty
                    || _maventTilaToleranceResult.Dirty
                    || _mIPremiums.Dirty
                    || _miscDataFile.Dirty
                    || _monthsToExclude.Dirty
                    || _optimalBlueHistoryData.Dirty
                    || _optimalBlueRequest.Dirty
                    || _optimalBlueResponse.Dirty
                    || _otherPresentHousingExpense.Dirty
                    || _outstandingMtgPrincipal.Dirty
                    || _outstandingMtgPrincipalDate.Dirty
                    || _participateHomePoints.Dirty
                    || _partnerEmail.Dirty
                    || _partnerName.Dirty
                    || _partnerPhone.Dirty
                    || _pointsPaid.Dirty
                    || _rateRegistrationExpirationDate.Dirty
                    || _rateRegistrationInvestorName.Dirty
                    || _rateRegistrationLoanIsRegistered.Dirty
                    || _rateRegistrationReference.Dirty
                    || _rateRegistrationRegisteredBy.Dirty
                    || _rateRegistrationRegisteredUserId.Dirty
                    || _rateRegistrationRegistrationDate.Dirty
                    || _refundOrOverpaidInterest.Dirty
                    || _schoolTaxExcluded.Dirty
                    || _state.Dirty
                    || _statusUrl.Dirty
                    || _submitDate.Dirty
                    || _subTaxYear.Dirty
                    || _subTaxYearInterestReceived.Dirty
                    || _subTaxYearMIPremiums.Dirty
                    || _subTaxYearPointsPaid.Dirty
                    || _subTaxYearRefundOrOverpaidInterest.Dirty
                    || _taxId.Dirty
                    || _totalBox4.Dirty
                    || _totalYearlyMi.Dirty
                    || _useGfeTax.Dirty
                    || _useRegZMi.Dirty
                    || _zip.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _address.Dirty = value;
                _borrowerDescription1.Dirty = value;
                _borrowerDescription2.Dirty = value;
                _borrowerDescription3.Dirty = value;
                _borrowerDescription4.Dirty = value;
                _borrowerDescription5.Dirty = value;
                _borrowerDescription6.Dirty = value;
                _borrowerDescription7.Dirty = value;
                _city.Dirty = value;
                _closingCostProgramFile.Dirty = value;
                _closingTaxYear.Dirty = value;
                _closingTaxYearInterestReceived.Dirty = value;
                _contactFax.Dirty = value;
                _contactName.Dirty = value;
                _contactPhone.Dirty = value;
                _contactTitle.Dirty = value;
                _copyFromSubjectProperty.Dirty = value;
                _dataTracLoanId.Dirty = value;
                _docSetFile.Dirty = value;
                _factorForRevolvingDebt.Dirty = value;
                _fannieDuAutoOrderIndicator.Dirty = value;
                _fannieEcAutoOrderIndicator.Dirty = value;
                _floodInsuranceExcluded.Dirty = value;
                _formListFile.Dirty = value;
                _freddieLPAAutoOrderIndicator.Dirty = value;
                _freddieLQAAutoOrderIndicator.Dirty = value;
                _housingExpenseIntRate1.Dirty = value;
                _housingExpenseIntRate2.Dirty = value;
                _housingExpenseLoanAmt1.Dirty = value;
                _housingExpenseLoanAmt2.Dirty = value;
                _housingExpensePayment1.Dirty = value;
                _housingExpensePayment2.Dirty = value;
                _housingExpenseTerm1.Dirty = value;
                _housingExpenseTerm2.Dirty = value;
                _id.Dirty = value;
                _isSameAddresswithPayer.Dirty = value;
                _line1006Excluded.Dirty = value;
                _line1007Excluded.Dirty = value;
                _line1008Excluded.Dirty = value;
                _line1010Excluded.Dirty = value;
                _loanProgramFile.Dirty = value;
                _loanTemplateFile.Dirty = value;
                _maventATRQMResult.Dirty = value;
                _maventAutoOrderIndicator.Dirty = value;
                _maventCraxResult.Dirty = value;
                _maventEnterpriseResult.Dirty = value;
                _maventGseResult.Dirty = value;
                _maventHighCostResult.Dirty = value;
                _maventHmdaResult.Dirty = value;
                _maventHpmlResult.Dirty = value;
                _maventLicenseResult.Dirty = value;
                _maventNmlsResult.Dirty = value;
                _maventOfacResult.Dirty = value;
                _maventOrderedBy.Dirty = value;
                _maventOrderedDate.Dirty = value;
                _maventOtherResult.Dirty = value;
                _maventReviewResult.Dirty = value;
                _maventStateResult.Dirty = value;
                _maventTilaRorResult.Dirty = value;
                _maventTilaToleranceResult.Dirty = value;
                _mIPremiums.Dirty = value;
                _miscDataFile.Dirty = value;
                _monthsToExclude.Dirty = value;
                _optimalBlueHistoryData.Dirty = value;
                _optimalBlueRequest.Dirty = value;
                _optimalBlueResponse.Dirty = value;
                _otherPresentHousingExpense.Dirty = value;
                _outstandingMtgPrincipal.Dirty = value;
                _outstandingMtgPrincipalDate.Dirty = value;
                _participateHomePoints.Dirty = value;
                _partnerEmail.Dirty = value;
                _partnerName.Dirty = value;
                _partnerPhone.Dirty = value;
                _pointsPaid.Dirty = value;
                _rateRegistrationExpirationDate.Dirty = value;
                _rateRegistrationInvestorName.Dirty = value;
                _rateRegistrationLoanIsRegistered.Dirty = value;
                _rateRegistrationReference.Dirty = value;
                _rateRegistrationRegisteredBy.Dirty = value;
                _rateRegistrationRegisteredUserId.Dirty = value;
                _rateRegistrationRegistrationDate.Dirty = value;
                _refundOrOverpaidInterest.Dirty = value;
                _schoolTaxExcluded.Dirty = value;
                _state.Dirty = value;
                _statusUrl.Dirty = value;
                _submitDate.Dirty = value;
                _subTaxYear.Dirty = value;
                _subTaxYearInterestReceived.Dirty = value;
                _subTaxYearMIPremiums.Dirty = value;
                _subTaxYearPointsPaid.Dirty = value;
                _subTaxYearRefundOrOverpaidInterest.Dirty = value;
                _taxId.Dirty = value;
                _totalBox4.Dirty = value;
                _totalYearlyMi.Dirty = value;
                _useGfeTax.Dirty = value;
                _useRegZMi.Dirty = value;
                _zip.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}