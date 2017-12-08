#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Miscellaneous : ExtensibleObject
    {
        private DirtyValue<string> _address;
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<string> _borrowerDescription1;
        public string BorrowerDescription1 { get => _borrowerDescription1; set => _borrowerDescription1 = value; }
        private DirtyValue<string> _borrowerDescription2;
        public string BorrowerDescription2 { get => _borrowerDescription2; set => _borrowerDescription2 = value; }
        private DirtyValue<string> _borrowerDescription3;
        public string BorrowerDescription3 { get => _borrowerDescription3; set => _borrowerDescription3 = value; }
        private DirtyValue<string> _borrowerDescription4;
        public string BorrowerDescription4 { get => _borrowerDescription4; set => _borrowerDescription4 = value; }
        private DirtyValue<string> _borrowerDescription5;
        public string BorrowerDescription5 { get => _borrowerDescription5; set => _borrowerDescription5 = value; }
        private DirtyValue<string> _borrowerDescription6;
        public string BorrowerDescription6 { get => _borrowerDescription6; set => _borrowerDescription6 = value; }
        private DirtyValue<string> _borrowerDescription7;
        public string BorrowerDescription7 { get => _borrowerDescription7; set => _borrowerDescription7 = value; }
        private DirtyValue<string> _city;
        public string City { get => _city; set => _city = value; }
        private DirtyValue<string> _closingCostProgramFile;
        public string ClosingCostProgramFile { get => _closingCostProgramFile; set => _closingCostProgramFile = value; }
        private DirtyValue<string> _closingTaxYear;
        public string ClosingTaxYear { get => _closingTaxYear; set => _closingTaxYear = value; }
        private DirtyValue<decimal?> _closingTaxYearInterestReceived;
        public decimal? ClosingTaxYearInterestReceived { get => _closingTaxYearInterestReceived; set => _closingTaxYearInterestReceived = value; }
        private DirtyValue<string> _contactFax;
        public string ContactFax { get => _contactFax; set => _contactFax = value; }
        private DirtyValue<string> _contactName;
        public string ContactName { get => _contactName; set => _contactName = value; }
        private DirtyValue<string> _contactPhone;
        public string ContactPhone { get => _contactPhone; set => _contactPhone = value; }
        private DirtyValue<string> _contactTitle;
        public string ContactTitle { get => _contactTitle; set => _contactTitle = value; }
        private DirtyValue<bool?> _copyFromSubjectProperty;
        public bool? CopyFromSubjectProperty { get => _copyFromSubjectProperty; set => _copyFromSubjectProperty = value; }
        private DirtyValue<string> _dataTracLoanId;
        public string DataTracLoanId { get => _dataTracLoanId; set => _dataTracLoanId = value; }
        private DirtyValue<string> _docSetFile;
        public string DocSetFile { get => _docSetFile; set => _docSetFile = value; }
        private DirtyValue<int?> _factorForRevolvingDebt;
        public int? FactorForRevolvingDebt { get => _factorForRevolvingDebt; set => _factorForRevolvingDebt = value; }
        private DirtyValue<bool?> _fannieDuAutoOrderIndicator;
        public bool? FannieDuAutoOrderIndicator { get => _fannieDuAutoOrderIndicator; set => _fannieDuAutoOrderIndicator = value; }
        private DirtyValue<bool?> _fannieEcAutoOrderIndicator;
        public bool? FannieEcAutoOrderIndicator { get => _fannieEcAutoOrderIndicator; set => _fannieEcAutoOrderIndicator = value; }
        private DirtyValue<string> _floodInsuranceExcluded;
        public string FloodInsuranceExcluded { get => _floodInsuranceExcluded; set => _floodInsuranceExcluded = value; }
        private DirtyValue<string> _formListFile;
        public string FormListFile { get => _formListFile; set => _formListFile = value; }
        private DirtyValue<bool?> _freddieLPAAutoOrderIndicator;
        public bool? FreddieLPAAutoOrderIndicator { get => _freddieLPAAutoOrderIndicator; set => _freddieLPAAutoOrderIndicator = value; }
        private DirtyValue<bool?> _freddieLQAAutoOrderIndicator;
        public bool? FreddieLQAAutoOrderIndicator { get => _freddieLQAAutoOrderIndicator; set => _freddieLQAAutoOrderIndicator = value; }
        private DirtyValue<decimal?> _housingExpenseIntRate1;
        public decimal? HousingExpenseIntRate1 { get => _housingExpenseIntRate1; set => _housingExpenseIntRate1 = value; }
        private DirtyValue<decimal?> _housingExpenseIntRate2;
        public decimal? HousingExpenseIntRate2 { get => _housingExpenseIntRate2; set => _housingExpenseIntRate2 = value; }
        private DirtyValue<decimal?> _housingExpenseLoanAmt1;
        public decimal? HousingExpenseLoanAmt1 { get => _housingExpenseLoanAmt1; set => _housingExpenseLoanAmt1 = value; }
        private DirtyValue<decimal?> _housingExpenseLoanAmt2;
        public decimal? HousingExpenseLoanAmt2 { get => _housingExpenseLoanAmt2; set => _housingExpenseLoanAmt2 = value; }
        private DirtyValue<decimal?> _housingExpensePayment1;
        public decimal? HousingExpensePayment1 { get => _housingExpensePayment1; set => _housingExpensePayment1 = value; }
        private DirtyValue<decimal?> _housingExpensePayment2;
        public decimal? HousingExpensePayment2 { get => _housingExpensePayment2; set => _housingExpensePayment2 = value; }
        private DirtyValue<int?> _housingExpenseTerm1;
        public int? HousingExpenseTerm1 { get => _housingExpenseTerm1; set => _housingExpenseTerm1 = value; }
        private DirtyValue<int?> _housingExpenseTerm2;
        public int? HousingExpenseTerm2 { get => _housingExpenseTerm2; set => _housingExpenseTerm2 = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isSameAddresswithPayer;
        public bool? IsSameAddresswithPayer { get => _isSameAddresswithPayer; set => _isSameAddresswithPayer = value; }
        private DirtyValue<string> _line1006Excluded;
        public string Line1006Excluded { get => _line1006Excluded; set => _line1006Excluded = value; }
        private DirtyValue<string> _line1007Excluded;
        public string Line1007Excluded { get => _line1007Excluded; set => _line1007Excluded = value; }
        private DirtyValue<string> _line1008Excluded;
        public string Line1008Excluded { get => _line1008Excluded; set => _line1008Excluded = value; }
        private DirtyValue<string> _line1010Excluded;
        public string Line1010Excluded { get => _line1010Excluded; set => _line1010Excluded = value; }
        private DirtyValue<string> _loanProgramFile;
        public string LoanProgramFile { get => _loanProgramFile; set => _loanProgramFile = value; }
        private DirtyValue<string> _loanTemplateFile;
        public string LoanTemplateFile { get => _loanTemplateFile; set => _loanTemplateFile = value; }
        private DirtyValue<string> _maventATRQMResult;
        public string MaventATRQMResult { get => _maventATRQMResult; set => _maventATRQMResult = value; }
        private DirtyValue<bool?> _maventAutoOrderIndicator;
        public bool? MaventAutoOrderIndicator { get => _maventAutoOrderIndicator; set => _maventAutoOrderIndicator = value; }
        private DirtyValue<string> _maventCraxResult;
        public string MaventCraxResult { get => _maventCraxResult; set => _maventCraxResult = value; }
        private DirtyValue<string> _maventEnterpriseResult;
        public string MaventEnterpriseResult { get => _maventEnterpriseResult; set => _maventEnterpriseResult = value; }
        private DirtyValue<string> _maventGseResult;
        public string MaventGseResult { get => _maventGseResult; set => _maventGseResult = value; }
        private DirtyValue<string> _maventHighCostResult;
        public string MaventHighCostResult { get => _maventHighCostResult; set => _maventHighCostResult = value; }
        private DirtyValue<string> _maventHmdaResult;
        public string MaventHmdaResult { get => _maventHmdaResult; set => _maventHmdaResult = value; }
        private DirtyValue<string> _maventHpmlResult;
        public string MaventHpmlResult { get => _maventHpmlResult; set => _maventHpmlResult = value; }
        private DirtyValue<string> _maventLicenseResult;
        public string MaventLicenseResult { get => _maventLicenseResult; set => _maventLicenseResult = value; }
        private DirtyValue<string> _maventNmlsResult;
        public string MaventNmlsResult { get => _maventNmlsResult; set => _maventNmlsResult = value; }
        private DirtyValue<string> _maventOfacResult;
        public string MaventOfacResult { get => _maventOfacResult; set => _maventOfacResult = value; }
        private DirtyValue<string> _maventOrderedBy;
        public string MaventOrderedBy { get => _maventOrderedBy; set => _maventOrderedBy = value; }
        private DirtyValue<DateTime?> _maventOrderedDate;
        public DateTime? MaventOrderedDate { get => _maventOrderedDate; set => _maventOrderedDate = value; }
        private DirtyValue<string> _maventOtherResult;
        public string MaventOtherResult { get => _maventOtherResult; set => _maventOtherResult = value; }
        private DirtyValue<string> _maventReviewResult;
        public string MaventReviewResult { get => _maventReviewResult; set => _maventReviewResult = value; }
        private DirtyValue<string> _maventStateResult;
        public string MaventStateResult { get => _maventStateResult; set => _maventStateResult = value; }
        private DirtyValue<string> _maventTilaRorResult;
        public string MaventTilaRorResult { get => _maventTilaRorResult; set => _maventTilaRorResult = value; }
        private DirtyValue<string> _maventTilaToleranceResult;
        public string MaventTilaToleranceResult { get => _maventTilaToleranceResult; set => _maventTilaToleranceResult = value; }
        private DirtyValue<decimal?> _mIPremiums;
        public decimal? MIPremiums { get => _mIPremiums; set => _mIPremiums = value; }
        private DirtyValue<string> _miscDataFile;
        public string MiscDataFile { get => _miscDataFile; set => _miscDataFile = value; }
        private DirtyValue<int?> _monthsToExclude;
        public int? MonthsToExclude { get => _monthsToExclude; set => _monthsToExclude = value; }
        private DirtyValue<string> _optimalBlueHistoryData;
        public string OptimalBlueHistoryData { get => _optimalBlueHistoryData; set => _optimalBlueHistoryData = value; }
        private DirtyValue<string> _optimalBlueRequest;
        public string OptimalBlueRequest { get => _optimalBlueRequest; set => _optimalBlueRequest = value; }
        private DirtyValue<string> _optimalBlueResponse;
        public string OptimalBlueResponse { get => _optimalBlueResponse; set => _optimalBlueResponse = value; }
        private DirtyValue<decimal?> _otherPresentHousingExpense;
        public decimal? OtherPresentHousingExpense { get => _otherPresentHousingExpense; set => _otherPresentHousingExpense = value; }
        private DirtyValue<decimal?> _outstandingMtgPrincipal;
        public decimal? OutstandingMtgPrincipal { get => _outstandingMtgPrincipal; set => _outstandingMtgPrincipal = value; }
        private DirtyValue<DateTime?> _outstandingMtgPrincipalDate;
        public DateTime? OutstandingMtgPrincipalDate { get => _outstandingMtgPrincipalDate; set => _outstandingMtgPrincipalDate = value; }
        private DirtyValue<bool?> _participateHomePoints;
        public bool? ParticipateHomePoints { get => _participateHomePoints; set => _participateHomePoints = value; }
        private DirtyValue<string> _partnerEmail;
        public string PartnerEmail { get => _partnerEmail; set => _partnerEmail = value; }
        private DirtyValue<string> _partnerName;
        public string PartnerName { get => _partnerName; set => _partnerName = value; }
        private DirtyValue<string> _partnerPhone;
        public string PartnerPhone { get => _partnerPhone; set => _partnerPhone = value; }
        private DirtyValue<decimal?> _pointsPaid;
        public decimal? PointsPaid { get => _pointsPaid; set => _pointsPaid = value; }
        private DirtyValue<DateTime?> _rateRegistrationExpirationDate;
        public DateTime? RateRegistrationExpirationDate { get => _rateRegistrationExpirationDate; set => _rateRegistrationExpirationDate = value; }
        private DirtyValue<string> _rateRegistrationInvestorName;
        public string RateRegistrationInvestorName { get => _rateRegistrationInvestorName; set => _rateRegistrationInvestorName = value; }
        private DirtyValue<bool?> _rateRegistrationLoanIsRegistered;
        public bool? RateRegistrationLoanIsRegistered { get => _rateRegistrationLoanIsRegistered; set => _rateRegistrationLoanIsRegistered = value; }
        private DirtyValue<string> _rateRegistrationReference;
        public string RateRegistrationReference { get => _rateRegistrationReference; set => _rateRegistrationReference = value; }
        private DirtyValue<string> _rateRegistrationRegisteredBy;
        public string RateRegistrationRegisteredBy { get => _rateRegistrationRegisteredBy; set => _rateRegistrationRegisteredBy = value; }
        private DirtyValue<string> _rateRegistrationRegisteredUserId;
        public string RateRegistrationRegisteredUserId { get => _rateRegistrationRegisteredUserId; set => _rateRegistrationRegisteredUserId = value; }
        private DirtyValue<DateTime?> _rateRegistrationRegistrationDate;
        public DateTime? RateRegistrationRegistrationDate { get => _rateRegistrationRegistrationDate; set => _rateRegistrationRegistrationDate = value; }
        private DirtyValue<decimal?> _refundOrOverpaidInterest;
        public decimal? RefundOrOverpaidInterest { get => _refundOrOverpaidInterest; set => _refundOrOverpaidInterest = value; }
        private DirtyValue<string> _schoolTaxExcluded;
        public string SchoolTaxExcluded { get => _schoolTaxExcluded; set => _schoolTaxExcluded = value; }
        private DirtyValue<string> _state;
        public string State { get => _state; set => _state = value; }
        private DirtyValue<string> _statusUrl;
        public string StatusUrl { get => _statusUrl; set => _statusUrl = value; }
        private DirtyValue<DateTime?> _submitDate;
        public DateTime? SubmitDate { get => _submitDate; set => _submitDate = value; }
        private DirtyValue<string> _subTaxYear;
        public string SubTaxYear { get => _subTaxYear; set => _subTaxYear = value; }
        private DirtyValue<decimal?> _subTaxYearInterestReceived;
        public decimal? SubTaxYearInterestReceived { get => _subTaxYearInterestReceived; set => _subTaxYearInterestReceived = value; }
        private DirtyValue<decimal?> _subTaxYearMIPremiums;
        public decimal? SubTaxYearMIPremiums { get => _subTaxYearMIPremiums; set => _subTaxYearMIPremiums = value; }
        private DirtyValue<decimal?> _subTaxYearPointsPaid;
        public decimal? SubTaxYearPointsPaid { get => _subTaxYearPointsPaid; set => _subTaxYearPointsPaid = value; }
        private DirtyValue<decimal?> _subTaxYearRefundOrOverpaidInterest;
        public decimal? SubTaxYearRefundOrOverpaidInterest { get => _subTaxYearRefundOrOverpaidInterest; set => _subTaxYearRefundOrOverpaidInterest = value; }
        private DirtyValue<string> _taxId;
        public string TaxId { get => _taxId; set => _taxId = value; }
        private DirtyValue<decimal?> _totalBox4;
        public decimal? TotalBox4 { get => _totalBox4; set => _totalBox4 = value; }
        private DirtyValue<decimal?> _totalYearlyMi;
        public decimal? TotalYearlyMi { get => _totalYearlyMi; set => _totalYearlyMi = value; }
        private DirtyValue<string> _useGfeTax;
        public string UseGfeTax { get => _useGfeTax; set => _useGfeTax = value; }
        private DirtyValue<string> _useRegZMi;
        public string UseRegZMi { get => _useRegZMi; set => _useRegZMi = value; }
        private DirtyValue<string> _zip;
        public string Zip { get => _zip; set => _zip = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _address.Dirty
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
                    || _zip.Dirty;
            }
            set
            {
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
            }
        }
    }
}