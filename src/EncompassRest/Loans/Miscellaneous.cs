using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Miscellaneous : IClean
    {
        private Value<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private Value<string> _borrowerDescription1;
        public string BorrowerDescription1 { get { return _borrowerDescription1; } set { _borrowerDescription1 = value; } }
        private Value<string> _borrowerDescription2;
        public string BorrowerDescription2 { get { return _borrowerDescription2; } set { _borrowerDescription2 = value; } }
        private Value<string> _borrowerDescription3;
        public string BorrowerDescription3 { get { return _borrowerDescription3; } set { _borrowerDescription3 = value; } }
        private Value<string> _borrowerDescription4;
        public string BorrowerDescription4 { get { return _borrowerDescription4; } set { _borrowerDescription4 = value; } }
        private Value<string> _borrowerDescription5;
        public string BorrowerDescription5 { get { return _borrowerDescription5; } set { _borrowerDescription5 = value; } }
        private Value<string> _borrowerDescription6;
        public string BorrowerDescription6 { get { return _borrowerDescription6; } set { _borrowerDescription6 = value; } }
        private Value<string> _borrowerDescription7;
        public string BorrowerDescription7 { get { return _borrowerDescription7; } set { _borrowerDescription7 = value; } }
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private Value<string> _closingCostProgramFile;
        public string ClosingCostProgramFile { get { return _closingCostProgramFile; } set { _closingCostProgramFile = value; } }
        private Value<string> _closingTaxYear;
        public string ClosingTaxYear { get { return _closingTaxYear; } set { _closingTaxYear = value; } }
        private Value<decimal?> _closingTaxYearInterestReceived;
        public decimal? ClosingTaxYearInterestReceived { get { return _closingTaxYearInterestReceived; } set { _closingTaxYearInterestReceived = value; } }
        private Value<bool?> _copyFromSubjectProperty;
        public bool? CopyFromSubjectProperty { get { return _copyFromSubjectProperty; } set { _copyFromSubjectProperty = value; } }
        private Value<string> _dataTracLoanId;
        public string DataTracLoanId { get { return _dataTracLoanId; } set { _dataTracLoanId = value; } }
        private Value<string> _docSetFile;
        public string DocSetFile { get { return _docSetFile; } set { _docSetFile = value; } }
        private Value<int?> _factorForRevolvingDebt;
        public int? FactorForRevolvingDebt { get { return _factorForRevolvingDebt; } set { _factorForRevolvingDebt = value; } }
        private Value<bool?> _fannieDuAutoOrderIndicator;
        public bool? FannieDuAutoOrderIndicator { get { return _fannieDuAutoOrderIndicator; } set { _fannieDuAutoOrderIndicator = value; } }
        private Value<bool?> _fannieEcAutoOrderIndicator;
        public bool? FannieEcAutoOrderIndicator { get { return _fannieEcAutoOrderIndicator; } set { _fannieEcAutoOrderIndicator = value; } }
        private Value<string> _floodInsuranceExcluded;
        public string FloodInsuranceExcluded { get { return _floodInsuranceExcluded; } set { _floodInsuranceExcluded = value; } }
        private Value<string> _formListFile;
        public string FormListFile { get { return _formListFile; } set { _formListFile = value; } }
        private Value<bool?> _freddieLPAAutoOrderIndicator;
        public bool? FreddieLPAAutoOrderIndicator { get { return _freddieLPAAutoOrderIndicator; } set { _freddieLPAAutoOrderIndicator = value; } }
        private Value<bool?> _freddieLQAAutoOrderIndicator;
        public bool? FreddieLQAAutoOrderIndicator { get { return _freddieLQAAutoOrderIndicator; } set { _freddieLQAAutoOrderIndicator = value; } }
        private Value<decimal?> _housingExpenseIntRate1;
        public decimal? HousingExpenseIntRate1 { get { return _housingExpenseIntRate1; } set { _housingExpenseIntRate1 = value; } }
        private Value<decimal?> _housingExpenseIntRate2;
        public decimal? HousingExpenseIntRate2 { get { return _housingExpenseIntRate2; } set { _housingExpenseIntRate2 = value; } }
        private Value<decimal?> _housingExpenseLoanAmt1;
        public decimal? HousingExpenseLoanAmt1 { get { return _housingExpenseLoanAmt1; } set { _housingExpenseLoanAmt1 = value; } }
        private Value<decimal?> _housingExpenseLoanAmt2;
        public decimal? HousingExpenseLoanAmt2 { get { return _housingExpenseLoanAmt2; } set { _housingExpenseLoanAmt2 = value; } }
        private Value<decimal?> _housingExpensePayment1;
        public decimal? HousingExpensePayment1 { get { return _housingExpensePayment1; } set { _housingExpensePayment1 = value; } }
        private Value<decimal?> _housingExpensePayment2;
        public decimal? HousingExpensePayment2 { get { return _housingExpensePayment2; } set { _housingExpensePayment2 = value; } }
        private Value<int?> _housingExpenseTerm1;
        public int? HousingExpenseTerm1 { get { return _housingExpenseTerm1; } set { _housingExpenseTerm1 = value; } }
        private Value<int?> _housingExpenseTerm2;
        public int? HousingExpenseTerm2 { get { return _housingExpenseTerm2; } set { _housingExpenseTerm2 = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isSameAddresswithPayer;
        public bool? IsSameAddresswithPayer { get { return _isSameAddresswithPayer; } set { _isSameAddresswithPayer = value; } }
        private Value<string> _line1006Excluded;
        public string Line1006Excluded { get { return _line1006Excluded; } set { _line1006Excluded = value; } }
        private Value<string> _line1007Excluded;
        public string Line1007Excluded { get { return _line1007Excluded; } set { _line1007Excluded = value; } }
        private Value<string> _line1008Excluded;
        public string Line1008Excluded { get { return _line1008Excluded; } set { _line1008Excluded = value; } }
        private Value<string> _line1010Excluded;
        public string Line1010Excluded { get { return _line1010Excluded; } set { _line1010Excluded = value; } }
        private Value<string> _loanProgramFile;
        public string LoanProgramFile { get { return _loanProgramFile; } set { _loanProgramFile = value; } }
        private Value<string> _loanTemplateFile;
        public string LoanTemplateFile { get { return _loanTemplateFile; } set { _loanTemplateFile = value; } }
        private Value<string> _maventATRQMResult;
        public string MaventATRQMResult { get { return _maventATRQMResult; } set { _maventATRQMResult = value; } }
        private Value<bool?> _maventAutoOrderIndicator;
        public bool? MaventAutoOrderIndicator { get { return _maventAutoOrderIndicator; } set { _maventAutoOrderIndicator = value; } }
        private Value<string> _maventCraxResult;
        public string MaventCraxResult { get { return _maventCraxResult; } set { _maventCraxResult = value; } }
        private Value<string> _maventEnterpriseResult;
        public string MaventEnterpriseResult { get { return _maventEnterpriseResult; } set { _maventEnterpriseResult = value; } }
        private Value<string> _maventGseResult;
        public string MaventGseResult { get { return _maventGseResult; } set { _maventGseResult = value; } }
        private Value<string> _maventHighCostResult;
        public string MaventHighCostResult { get { return _maventHighCostResult; } set { _maventHighCostResult = value; } }
        private Value<string> _maventHmdaResult;
        public string MaventHmdaResult { get { return _maventHmdaResult; } set { _maventHmdaResult = value; } }
        private Value<string> _maventHpmlResult;
        public string MaventHpmlResult { get { return _maventHpmlResult; } set { _maventHpmlResult = value; } }
        private Value<string> _maventLicenseResult;
        public string MaventLicenseResult { get { return _maventLicenseResult; } set { _maventLicenseResult = value; } }
        private Value<string> _maventNmlsResult;
        public string MaventNmlsResult { get { return _maventNmlsResult; } set { _maventNmlsResult = value; } }
        private Value<string> _maventOfacResult;
        public string MaventOfacResult { get { return _maventOfacResult; } set { _maventOfacResult = value; } }
        private Value<string> _maventOrderedBy;
        public string MaventOrderedBy { get { return _maventOrderedBy; } set { _maventOrderedBy = value; } }
        private Value<DateTime?> _maventOrderedDate;
        public DateTime? MaventOrderedDate { get { return _maventOrderedDate; } set { _maventOrderedDate = value; } }
        private Value<string> _maventOtherResult;
        public string MaventOtherResult { get { return _maventOtherResult; } set { _maventOtherResult = value; } }
        private Value<string> _maventReviewResult;
        public string MaventReviewResult { get { return _maventReviewResult; } set { _maventReviewResult = value; } }
        private Value<string> _maventStateResult;
        public string MaventStateResult { get { return _maventStateResult; } set { _maventStateResult = value; } }
        private Value<string> _maventTilaRorResult;
        public string MaventTilaRorResult { get { return _maventTilaRorResult; } set { _maventTilaRorResult = value; } }
        private Value<string> _maventTilaToleranceResult;
        public string MaventTilaToleranceResult { get { return _maventTilaToleranceResult; } set { _maventTilaToleranceResult = value; } }
        private Value<decimal?> _mIPremiums;
        public decimal? MIPremiums { get { return _mIPremiums; } set { _mIPremiums = value; } }
        private Value<string> _miscDataFile;
        public string MiscDataFile { get { return _miscDataFile; } set { _miscDataFile = value; } }
        private Value<int?> _monthsToExclude;
        public int? MonthsToExclude { get { return _monthsToExclude; } set { _monthsToExclude = value; } }
        private Value<string> _optimalBlueHistoryData;
        public string OptimalBlueHistoryData { get { return _optimalBlueHistoryData; } set { _optimalBlueHistoryData = value; } }
        private Value<string> _optimalBlueRequest;
        public string OptimalBlueRequest { get { return _optimalBlueRequest; } set { _optimalBlueRequest = value; } }
        private Value<string> _optimalBlueResponse;
        public string OptimalBlueResponse { get { return _optimalBlueResponse; } set { _optimalBlueResponse = value; } }
        private Value<decimal?> _otherPresentHousingExpense;
        public decimal? OtherPresentHousingExpense { get { return _otherPresentHousingExpense; } set { _otherPresentHousingExpense = value; } }
        private Value<decimal?> _outstandingMtgPrincipal;
        public decimal? OutstandingMtgPrincipal { get { return _outstandingMtgPrincipal; } set { _outstandingMtgPrincipal = value; } }
        private Value<DateTime?> _outstandingMtgPrincipalDate;
        public DateTime? OutstandingMtgPrincipalDate { get { return _outstandingMtgPrincipalDate; } set { _outstandingMtgPrincipalDate = value; } }
        private Value<bool?> _participateHomePoints;
        public bool? ParticipateHomePoints { get { return _participateHomePoints; } set { _participateHomePoints = value; } }
        private Value<string> _partnerEmail;
        public string PartnerEmail { get { return _partnerEmail; } set { _partnerEmail = value; } }
        private Value<string> _partnerName;
        public string PartnerName { get { return _partnerName; } set { _partnerName = value; } }
        private Value<string> _partnerPhone;
        public string PartnerPhone { get { return _partnerPhone; } set { _partnerPhone = value; } }
        private Value<decimal?> _pointsPaid;
        public decimal? PointsPaid { get { return _pointsPaid; } set { _pointsPaid = value; } }
        private Value<DateTime?> _rateRegistrationExpirationDate;
        public DateTime? RateRegistrationExpirationDate { get { return _rateRegistrationExpirationDate; } set { _rateRegistrationExpirationDate = value; } }
        private Value<string> _rateRegistrationInvestorName;
        public string RateRegistrationInvestorName { get { return _rateRegistrationInvestorName; } set { _rateRegistrationInvestorName = value; } }
        private Value<bool?> _rateRegistrationLoanIsRegistered;
        public bool? RateRegistrationLoanIsRegistered { get { return _rateRegistrationLoanIsRegistered; } set { _rateRegistrationLoanIsRegistered = value; } }
        private Value<string> _rateRegistrationReference;
        public string RateRegistrationReference { get { return _rateRegistrationReference; } set { _rateRegistrationReference = value; } }
        private Value<string> _rateRegistrationRegisteredBy;
        public string RateRegistrationRegisteredBy { get { return _rateRegistrationRegisteredBy; } set { _rateRegistrationRegisteredBy = value; } }
        private Value<string> _rateRegistrationRegisteredUserId;
        public string RateRegistrationRegisteredUserId { get { return _rateRegistrationRegisteredUserId; } set { _rateRegistrationRegisteredUserId = value; } }
        private Value<DateTime?> _rateRegistrationRegistrationDate;
        public DateTime? RateRegistrationRegistrationDate { get { return _rateRegistrationRegistrationDate; } set { _rateRegistrationRegistrationDate = value; } }
        private Value<decimal?> _refundOrOverpaidInterest;
        public decimal? RefundOrOverpaidInterest { get { return _refundOrOverpaidInterest; } set { _refundOrOverpaidInterest = value; } }
        private Value<string> _schoolTaxExcluded;
        public string SchoolTaxExcluded { get { return _schoolTaxExcluded; } set { _schoolTaxExcluded = value; } }
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private Value<string> _statusUrl;
        public string StatusUrl { get { return _statusUrl; } set { _statusUrl = value; } }
        private Value<DateTime?> _submitDate;
        public DateTime? SubmitDate { get { return _submitDate; } set { _submitDate = value; } }
        private Value<string> _subTaxYear;
        public string SubTaxYear { get { return _subTaxYear; } set { _subTaxYear = value; } }
        private Value<decimal?> _subTaxYearInterestReceived;
        public decimal? SubTaxYearInterestReceived { get { return _subTaxYearInterestReceived; } set { _subTaxYearInterestReceived = value; } }
        private Value<decimal?> _subTaxYearMIPremiums;
        public decimal? SubTaxYearMIPremiums { get { return _subTaxYearMIPremiums; } set { _subTaxYearMIPremiums = value; } }
        private Value<decimal?> _subTaxYearPointsPaid;
        public decimal? SubTaxYearPointsPaid { get { return _subTaxYearPointsPaid; } set { _subTaxYearPointsPaid = value; } }
        private Value<decimal?> _subTaxYearRefundOrOverpaidInterest;
        public decimal? SubTaxYearRefundOrOverpaidInterest { get { return _subTaxYearRefundOrOverpaidInterest; } set { _subTaxYearRefundOrOverpaidInterest = value; } }
        private Value<string> _taxId;
        public string TaxId { get { return _taxId; } set { _taxId = value; } }
        private Value<decimal?> _totalBox4;
        public decimal? TotalBox4 { get { return _totalBox4; } set { _totalBox4 = value; } }
        private Value<decimal?> _totalYearlyMi;
        public decimal? TotalYearlyMi { get { return _totalYearlyMi; } set { _totalYearlyMi = value; } }
        private Value<string> _useGfeTax;
        public string UseGfeTax { get { return _useGfeTax; } set { _useGfeTax = value; } }
        private Value<string> _useRegZMi;
        public string UseRegZMi { get { return _useRegZMi; } set { _useRegZMi = value; } }
        private Value<string> _zip;
        public string Zip { get { return _zip; } set { _zip = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _address.Clean
                    && _borrowerDescription1.Clean
                    && _borrowerDescription2.Clean
                    && _borrowerDescription3.Clean
                    && _borrowerDescription4.Clean
                    && _borrowerDescription5.Clean
                    && _borrowerDescription6.Clean
                    && _borrowerDescription7.Clean
                    && _city.Clean
                    && _closingCostProgramFile.Clean
                    && _closingTaxYear.Clean
                    && _closingTaxYearInterestReceived.Clean
                    && _copyFromSubjectProperty.Clean
                    && _dataTracLoanId.Clean
                    && _docSetFile.Clean
                    && _factorForRevolvingDebt.Clean
                    && _fannieDuAutoOrderIndicator.Clean
                    && _fannieEcAutoOrderIndicator.Clean
                    && _floodInsuranceExcluded.Clean
                    && _formListFile.Clean
                    && _freddieLPAAutoOrderIndicator.Clean
                    && _freddieLQAAutoOrderIndicator.Clean
                    && _housingExpenseIntRate1.Clean
                    && _housingExpenseIntRate2.Clean
                    && _housingExpenseLoanAmt1.Clean
                    && _housingExpenseLoanAmt2.Clean
                    && _housingExpensePayment1.Clean
                    && _housingExpensePayment2.Clean
                    && _housingExpenseTerm1.Clean
                    && _housingExpenseTerm2.Clean
                    && _id.Clean
                    && _isSameAddresswithPayer.Clean
                    && _line1006Excluded.Clean
                    && _line1007Excluded.Clean
                    && _line1008Excluded.Clean
                    && _line1010Excluded.Clean
                    && _loanProgramFile.Clean
                    && _loanTemplateFile.Clean
                    && _maventATRQMResult.Clean
                    && _maventAutoOrderIndicator.Clean
                    && _maventCraxResult.Clean
                    && _maventEnterpriseResult.Clean
                    && _maventGseResult.Clean
                    && _maventHighCostResult.Clean
                    && _maventHmdaResult.Clean
                    && _maventHpmlResult.Clean
                    && _maventLicenseResult.Clean
                    && _maventNmlsResult.Clean
                    && _maventOfacResult.Clean
                    && _maventOrderedBy.Clean
                    && _maventOrderedDate.Clean
                    && _maventOtherResult.Clean
                    && _maventReviewResult.Clean
                    && _maventStateResult.Clean
                    && _maventTilaRorResult.Clean
                    && _maventTilaToleranceResult.Clean
                    && _mIPremiums.Clean
                    && _miscDataFile.Clean
                    && _monthsToExclude.Clean
                    && _optimalBlueHistoryData.Clean
                    && _optimalBlueRequest.Clean
                    && _optimalBlueResponse.Clean
                    && _otherPresentHousingExpense.Clean
                    && _outstandingMtgPrincipal.Clean
                    && _outstandingMtgPrincipalDate.Clean
                    && _participateHomePoints.Clean
                    && _partnerEmail.Clean
                    && _partnerName.Clean
                    && _partnerPhone.Clean
                    && _pointsPaid.Clean
                    && _rateRegistrationExpirationDate.Clean
                    && _rateRegistrationInvestorName.Clean
                    && _rateRegistrationLoanIsRegistered.Clean
                    && _rateRegistrationReference.Clean
                    && _rateRegistrationRegisteredBy.Clean
                    && _rateRegistrationRegisteredUserId.Clean
                    && _rateRegistrationRegistrationDate.Clean
                    && _refundOrOverpaidInterest.Clean
                    && _schoolTaxExcluded.Clean
                    && _state.Clean
                    && _statusUrl.Clean
                    && _submitDate.Clean
                    && _subTaxYear.Clean
                    && _subTaxYearInterestReceived.Clean
                    && _subTaxYearMIPremiums.Clean
                    && _subTaxYearPointsPaid.Clean
                    && _subTaxYearRefundOrOverpaidInterest.Clean
                    && _taxId.Clean
                    && _totalBox4.Clean
                    && _totalYearlyMi.Clean
                    && _useGfeTax.Clean
                    && _useRegZMi.Clean
                    && _zip.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var address = _address; address.Clean = value; _address = address;
                var borrowerDescription1 = _borrowerDescription1; borrowerDescription1.Clean = value; _borrowerDescription1 = borrowerDescription1;
                var borrowerDescription2 = _borrowerDescription2; borrowerDescription2.Clean = value; _borrowerDescription2 = borrowerDescription2;
                var borrowerDescription3 = _borrowerDescription3; borrowerDescription3.Clean = value; _borrowerDescription3 = borrowerDescription3;
                var borrowerDescription4 = _borrowerDescription4; borrowerDescription4.Clean = value; _borrowerDescription4 = borrowerDescription4;
                var borrowerDescription5 = _borrowerDescription5; borrowerDescription5.Clean = value; _borrowerDescription5 = borrowerDescription5;
                var borrowerDescription6 = _borrowerDescription6; borrowerDescription6.Clean = value; _borrowerDescription6 = borrowerDescription6;
                var borrowerDescription7 = _borrowerDescription7; borrowerDescription7.Clean = value; _borrowerDescription7 = borrowerDescription7;
                var city = _city; city.Clean = value; _city = city;
                var closingCostProgramFile = _closingCostProgramFile; closingCostProgramFile.Clean = value; _closingCostProgramFile = closingCostProgramFile;
                var closingTaxYear = _closingTaxYear; closingTaxYear.Clean = value; _closingTaxYear = closingTaxYear;
                var closingTaxYearInterestReceived = _closingTaxYearInterestReceived; closingTaxYearInterestReceived.Clean = value; _closingTaxYearInterestReceived = closingTaxYearInterestReceived;
                var copyFromSubjectProperty = _copyFromSubjectProperty; copyFromSubjectProperty.Clean = value; _copyFromSubjectProperty = copyFromSubjectProperty;
                var dataTracLoanId = _dataTracLoanId; dataTracLoanId.Clean = value; _dataTracLoanId = dataTracLoanId;
                var docSetFile = _docSetFile; docSetFile.Clean = value; _docSetFile = docSetFile;
                var factorForRevolvingDebt = _factorForRevolvingDebt; factorForRevolvingDebt.Clean = value; _factorForRevolvingDebt = factorForRevolvingDebt;
                var fannieDuAutoOrderIndicator = _fannieDuAutoOrderIndicator; fannieDuAutoOrderIndicator.Clean = value; _fannieDuAutoOrderIndicator = fannieDuAutoOrderIndicator;
                var fannieEcAutoOrderIndicator = _fannieEcAutoOrderIndicator; fannieEcAutoOrderIndicator.Clean = value; _fannieEcAutoOrderIndicator = fannieEcAutoOrderIndicator;
                var floodInsuranceExcluded = _floodInsuranceExcluded; floodInsuranceExcluded.Clean = value; _floodInsuranceExcluded = floodInsuranceExcluded;
                var formListFile = _formListFile; formListFile.Clean = value; _formListFile = formListFile;
                var freddieLPAAutoOrderIndicator = _freddieLPAAutoOrderIndicator; freddieLPAAutoOrderIndicator.Clean = value; _freddieLPAAutoOrderIndicator = freddieLPAAutoOrderIndicator;
                var freddieLQAAutoOrderIndicator = _freddieLQAAutoOrderIndicator; freddieLQAAutoOrderIndicator.Clean = value; _freddieLQAAutoOrderIndicator = freddieLQAAutoOrderIndicator;
                var housingExpenseIntRate1 = _housingExpenseIntRate1; housingExpenseIntRate1.Clean = value; _housingExpenseIntRate1 = housingExpenseIntRate1;
                var housingExpenseIntRate2 = _housingExpenseIntRate2; housingExpenseIntRate2.Clean = value; _housingExpenseIntRate2 = housingExpenseIntRate2;
                var housingExpenseLoanAmt1 = _housingExpenseLoanAmt1; housingExpenseLoanAmt1.Clean = value; _housingExpenseLoanAmt1 = housingExpenseLoanAmt1;
                var housingExpenseLoanAmt2 = _housingExpenseLoanAmt2; housingExpenseLoanAmt2.Clean = value; _housingExpenseLoanAmt2 = housingExpenseLoanAmt2;
                var housingExpensePayment1 = _housingExpensePayment1; housingExpensePayment1.Clean = value; _housingExpensePayment1 = housingExpensePayment1;
                var housingExpensePayment2 = _housingExpensePayment2; housingExpensePayment2.Clean = value; _housingExpensePayment2 = housingExpensePayment2;
                var housingExpenseTerm1 = _housingExpenseTerm1; housingExpenseTerm1.Clean = value; _housingExpenseTerm1 = housingExpenseTerm1;
                var housingExpenseTerm2 = _housingExpenseTerm2; housingExpenseTerm2.Clean = value; _housingExpenseTerm2 = housingExpenseTerm2;
                var id = _id; id.Clean = value; _id = id;
                var isSameAddresswithPayer = _isSameAddresswithPayer; isSameAddresswithPayer.Clean = value; _isSameAddresswithPayer = isSameAddresswithPayer;
                var line1006Excluded = _line1006Excluded; line1006Excluded.Clean = value; _line1006Excluded = line1006Excluded;
                var line1007Excluded = _line1007Excluded; line1007Excluded.Clean = value; _line1007Excluded = line1007Excluded;
                var line1008Excluded = _line1008Excluded; line1008Excluded.Clean = value; _line1008Excluded = line1008Excluded;
                var line1010Excluded = _line1010Excluded; line1010Excluded.Clean = value; _line1010Excluded = line1010Excluded;
                var loanProgramFile = _loanProgramFile; loanProgramFile.Clean = value; _loanProgramFile = loanProgramFile;
                var loanTemplateFile = _loanTemplateFile; loanTemplateFile.Clean = value; _loanTemplateFile = loanTemplateFile;
                var maventATRQMResult = _maventATRQMResult; maventATRQMResult.Clean = value; _maventATRQMResult = maventATRQMResult;
                var maventAutoOrderIndicator = _maventAutoOrderIndicator; maventAutoOrderIndicator.Clean = value; _maventAutoOrderIndicator = maventAutoOrderIndicator;
                var maventCraxResult = _maventCraxResult; maventCraxResult.Clean = value; _maventCraxResult = maventCraxResult;
                var maventEnterpriseResult = _maventEnterpriseResult; maventEnterpriseResult.Clean = value; _maventEnterpriseResult = maventEnterpriseResult;
                var maventGseResult = _maventGseResult; maventGseResult.Clean = value; _maventGseResult = maventGseResult;
                var maventHighCostResult = _maventHighCostResult; maventHighCostResult.Clean = value; _maventHighCostResult = maventHighCostResult;
                var maventHmdaResult = _maventHmdaResult; maventHmdaResult.Clean = value; _maventHmdaResult = maventHmdaResult;
                var maventHpmlResult = _maventHpmlResult; maventHpmlResult.Clean = value; _maventHpmlResult = maventHpmlResult;
                var maventLicenseResult = _maventLicenseResult; maventLicenseResult.Clean = value; _maventLicenseResult = maventLicenseResult;
                var maventNmlsResult = _maventNmlsResult; maventNmlsResult.Clean = value; _maventNmlsResult = maventNmlsResult;
                var maventOfacResult = _maventOfacResult; maventOfacResult.Clean = value; _maventOfacResult = maventOfacResult;
                var maventOrderedBy = _maventOrderedBy; maventOrderedBy.Clean = value; _maventOrderedBy = maventOrderedBy;
                var maventOrderedDate = _maventOrderedDate; maventOrderedDate.Clean = value; _maventOrderedDate = maventOrderedDate;
                var maventOtherResult = _maventOtherResult; maventOtherResult.Clean = value; _maventOtherResult = maventOtherResult;
                var maventReviewResult = _maventReviewResult; maventReviewResult.Clean = value; _maventReviewResult = maventReviewResult;
                var maventStateResult = _maventStateResult; maventStateResult.Clean = value; _maventStateResult = maventStateResult;
                var maventTilaRorResult = _maventTilaRorResult; maventTilaRorResult.Clean = value; _maventTilaRorResult = maventTilaRorResult;
                var maventTilaToleranceResult = _maventTilaToleranceResult; maventTilaToleranceResult.Clean = value; _maventTilaToleranceResult = maventTilaToleranceResult;
                var mIPremiums = _mIPremiums; mIPremiums.Clean = value; _mIPremiums = mIPremiums;
                var miscDataFile = _miscDataFile; miscDataFile.Clean = value; _miscDataFile = miscDataFile;
                var monthsToExclude = _monthsToExclude; monthsToExclude.Clean = value; _monthsToExclude = monthsToExclude;
                var optimalBlueHistoryData = _optimalBlueHistoryData; optimalBlueHistoryData.Clean = value; _optimalBlueHistoryData = optimalBlueHistoryData;
                var optimalBlueRequest = _optimalBlueRequest; optimalBlueRequest.Clean = value; _optimalBlueRequest = optimalBlueRequest;
                var optimalBlueResponse = _optimalBlueResponse; optimalBlueResponse.Clean = value; _optimalBlueResponse = optimalBlueResponse;
                var otherPresentHousingExpense = _otherPresentHousingExpense; otherPresentHousingExpense.Clean = value; _otherPresentHousingExpense = otherPresentHousingExpense;
                var outstandingMtgPrincipal = _outstandingMtgPrincipal; outstandingMtgPrincipal.Clean = value; _outstandingMtgPrincipal = outstandingMtgPrincipal;
                var outstandingMtgPrincipalDate = _outstandingMtgPrincipalDate; outstandingMtgPrincipalDate.Clean = value; _outstandingMtgPrincipalDate = outstandingMtgPrincipalDate;
                var participateHomePoints = _participateHomePoints; participateHomePoints.Clean = value; _participateHomePoints = participateHomePoints;
                var partnerEmail = _partnerEmail; partnerEmail.Clean = value; _partnerEmail = partnerEmail;
                var partnerName = _partnerName; partnerName.Clean = value; _partnerName = partnerName;
                var partnerPhone = _partnerPhone; partnerPhone.Clean = value; _partnerPhone = partnerPhone;
                var pointsPaid = _pointsPaid; pointsPaid.Clean = value; _pointsPaid = pointsPaid;
                var rateRegistrationExpirationDate = _rateRegistrationExpirationDate; rateRegistrationExpirationDate.Clean = value; _rateRegistrationExpirationDate = rateRegistrationExpirationDate;
                var rateRegistrationInvestorName = _rateRegistrationInvestorName; rateRegistrationInvestorName.Clean = value; _rateRegistrationInvestorName = rateRegistrationInvestorName;
                var rateRegistrationLoanIsRegistered = _rateRegistrationLoanIsRegistered; rateRegistrationLoanIsRegistered.Clean = value; _rateRegistrationLoanIsRegistered = rateRegistrationLoanIsRegistered;
                var rateRegistrationReference = _rateRegistrationReference; rateRegistrationReference.Clean = value; _rateRegistrationReference = rateRegistrationReference;
                var rateRegistrationRegisteredBy = _rateRegistrationRegisteredBy; rateRegistrationRegisteredBy.Clean = value; _rateRegistrationRegisteredBy = rateRegistrationRegisteredBy;
                var rateRegistrationRegisteredUserId = _rateRegistrationRegisteredUserId; rateRegistrationRegisteredUserId.Clean = value; _rateRegistrationRegisteredUserId = rateRegistrationRegisteredUserId;
                var rateRegistrationRegistrationDate = _rateRegistrationRegistrationDate; rateRegistrationRegistrationDate.Clean = value; _rateRegistrationRegistrationDate = rateRegistrationRegistrationDate;
                var refundOrOverpaidInterest = _refundOrOverpaidInterest; refundOrOverpaidInterest.Clean = value; _refundOrOverpaidInterest = refundOrOverpaidInterest;
                var schoolTaxExcluded = _schoolTaxExcluded; schoolTaxExcluded.Clean = value; _schoolTaxExcluded = schoolTaxExcluded;
                var state = _state; state.Clean = value; _state = state;
                var statusUrl = _statusUrl; statusUrl.Clean = value; _statusUrl = statusUrl;
                var submitDate = _submitDate; submitDate.Clean = value; _submitDate = submitDate;
                var subTaxYear = _subTaxYear; subTaxYear.Clean = value; _subTaxYear = subTaxYear;
                var subTaxYearInterestReceived = _subTaxYearInterestReceived; subTaxYearInterestReceived.Clean = value; _subTaxYearInterestReceived = subTaxYearInterestReceived;
                var subTaxYearMIPremiums = _subTaxYearMIPremiums; subTaxYearMIPremiums.Clean = value; _subTaxYearMIPremiums = subTaxYearMIPremiums;
                var subTaxYearPointsPaid = _subTaxYearPointsPaid; subTaxYearPointsPaid.Clean = value; _subTaxYearPointsPaid = subTaxYearPointsPaid;
                var subTaxYearRefundOrOverpaidInterest = _subTaxYearRefundOrOverpaidInterest; subTaxYearRefundOrOverpaidInterest.Clean = value; _subTaxYearRefundOrOverpaidInterest = subTaxYearRefundOrOverpaidInterest;
                var taxId = _taxId; taxId.Clean = value; _taxId = taxId;
                var totalBox4 = _totalBox4; totalBox4.Clean = value; _totalBox4 = totalBox4;
                var totalYearlyMi = _totalYearlyMi; totalYearlyMi.Clean = value; _totalYearlyMi = totalYearlyMi;
                var useGfeTax = _useGfeTax; useGfeTax.Clean = value; _useGfeTax = useGfeTax;
                var useRegZMi = _useRegZMi; useRegZMi.Clean = value; _useRegZMi = useRegZMi;
                var zip = _zip; zip.Clean = value; _zip = zip;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Miscellaneous()
        {
            Clean = true;
        }
    }
}