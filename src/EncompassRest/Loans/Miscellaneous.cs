using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v0 = _address; v0.Clean = value; _address = v0;
                var v1 = _borrowerDescription1; v1.Clean = value; _borrowerDescription1 = v1;
                var v2 = _borrowerDescription2; v2.Clean = value; _borrowerDescription2 = v2;
                var v3 = _borrowerDescription3; v3.Clean = value; _borrowerDescription3 = v3;
                var v4 = _borrowerDescription4; v4.Clean = value; _borrowerDescription4 = v4;
                var v5 = _borrowerDescription5; v5.Clean = value; _borrowerDescription5 = v5;
                var v6 = _borrowerDescription6; v6.Clean = value; _borrowerDescription6 = v6;
                var v7 = _borrowerDescription7; v7.Clean = value; _borrowerDescription7 = v7;
                var v8 = _city; v8.Clean = value; _city = v8;
                var v9 = _closingCostProgramFile; v9.Clean = value; _closingCostProgramFile = v9;
                var v10 = _closingTaxYear; v10.Clean = value; _closingTaxYear = v10;
                var v11 = _closingTaxYearInterestReceived; v11.Clean = value; _closingTaxYearInterestReceived = v11;
                var v12 = _copyFromSubjectProperty; v12.Clean = value; _copyFromSubjectProperty = v12;
                var v13 = _dataTracLoanId; v13.Clean = value; _dataTracLoanId = v13;
                var v14 = _docSetFile; v14.Clean = value; _docSetFile = v14;
                var v15 = _factorForRevolvingDebt; v15.Clean = value; _factorForRevolvingDebt = v15;
                var v16 = _fannieDuAutoOrderIndicator; v16.Clean = value; _fannieDuAutoOrderIndicator = v16;
                var v17 = _fannieEcAutoOrderIndicator; v17.Clean = value; _fannieEcAutoOrderIndicator = v17;
                var v18 = _floodInsuranceExcluded; v18.Clean = value; _floodInsuranceExcluded = v18;
                var v19 = _formListFile; v19.Clean = value; _formListFile = v19;
                var v20 = _freddieLPAAutoOrderIndicator; v20.Clean = value; _freddieLPAAutoOrderIndicator = v20;
                var v21 = _freddieLQAAutoOrderIndicator; v21.Clean = value; _freddieLQAAutoOrderIndicator = v21;
                var v22 = _housingExpenseIntRate1; v22.Clean = value; _housingExpenseIntRate1 = v22;
                var v23 = _housingExpenseIntRate2; v23.Clean = value; _housingExpenseIntRate2 = v23;
                var v24 = _housingExpenseLoanAmt1; v24.Clean = value; _housingExpenseLoanAmt1 = v24;
                var v25 = _housingExpenseLoanAmt2; v25.Clean = value; _housingExpenseLoanAmt2 = v25;
                var v26 = _housingExpensePayment1; v26.Clean = value; _housingExpensePayment1 = v26;
                var v27 = _housingExpensePayment2; v27.Clean = value; _housingExpensePayment2 = v27;
                var v28 = _housingExpenseTerm1; v28.Clean = value; _housingExpenseTerm1 = v28;
                var v29 = _housingExpenseTerm2; v29.Clean = value; _housingExpenseTerm2 = v29;
                var v30 = _id; v30.Clean = value; _id = v30;
                var v31 = _isSameAddresswithPayer; v31.Clean = value; _isSameAddresswithPayer = v31;
                var v32 = _line1006Excluded; v32.Clean = value; _line1006Excluded = v32;
                var v33 = _line1007Excluded; v33.Clean = value; _line1007Excluded = v33;
                var v34 = _line1008Excluded; v34.Clean = value; _line1008Excluded = v34;
                var v35 = _line1010Excluded; v35.Clean = value; _line1010Excluded = v35;
                var v36 = _loanProgramFile; v36.Clean = value; _loanProgramFile = v36;
                var v37 = _loanTemplateFile; v37.Clean = value; _loanTemplateFile = v37;
                var v38 = _maventATRQMResult; v38.Clean = value; _maventATRQMResult = v38;
                var v39 = _maventAutoOrderIndicator; v39.Clean = value; _maventAutoOrderIndicator = v39;
                var v40 = _maventCraxResult; v40.Clean = value; _maventCraxResult = v40;
                var v41 = _maventEnterpriseResult; v41.Clean = value; _maventEnterpriseResult = v41;
                var v42 = _maventGseResult; v42.Clean = value; _maventGseResult = v42;
                var v43 = _maventHighCostResult; v43.Clean = value; _maventHighCostResult = v43;
                var v44 = _maventHmdaResult; v44.Clean = value; _maventHmdaResult = v44;
                var v45 = _maventHpmlResult; v45.Clean = value; _maventHpmlResult = v45;
                var v46 = _maventLicenseResult; v46.Clean = value; _maventLicenseResult = v46;
                var v47 = _maventNmlsResult; v47.Clean = value; _maventNmlsResult = v47;
                var v48 = _maventOfacResult; v48.Clean = value; _maventOfacResult = v48;
                var v49 = _maventOrderedBy; v49.Clean = value; _maventOrderedBy = v49;
                var v50 = _maventOrderedDate; v50.Clean = value; _maventOrderedDate = v50;
                var v51 = _maventOtherResult; v51.Clean = value; _maventOtherResult = v51;
                var v52 = _maventReviewResult; v52.Clean = value; _maventReviewResult = v52;
                var v53 = _maventStateResult; v53.Clean = value; _maventStateResult = v53;
                var v54 = _maventTilaRorResult; v54.Clean = value; _maventTilaRorResult = v54;
                var v55 = _maventTilaToleranceResult; v55.Clean = value; _maventTilaToleranceResult = v55;
                var v56 = _mIPremiums; v56.Clean = value; _mIPremiums = v56;
                var v57 = _miscDataFile; v57.Clean = value; _miscDataFile = v57;
                var v58 = _monthsToExclude; v58.Clean = value; _monthsToExclude = v58;
                var v59 = _optimalBlueHistoryData; v59.Clean = value; _optimalBlueHistoryData = v59;
                var v60 = _optimalBlueRequest; v60.Clean = value; _optimalBlueRequest = v60;
                var v61 = _optimalBlueResponse; v61.Clean = value; _optimalBlueResponse = v61;
                var v62 = _otherPresentHousingExpense; v62.Clean = value; _otherPresentHousingExpense = v62;
                var v63 = _outstandingMtgPrincipal; v63.Clean = value; _outstandingMtgPrincipal = v63;
                var v64 = _outstandingMtgPrincipalDate; v64.Clean = value; _outstandingMtgPrincipalDate = v64;
                var v65 = _participateHomePoints; v65.Clean = value; _participateHomePoints = v65;
                var v66 = _partnerEmail; v66.Clean = value; _partnerEmail = v66;
                var v67 = _partnerName; v67.Clean = value; _partnerName = v67;
                var v68 = _partnerPhone; v68.Clean = value; _partnerPhone = v68;
                var v69 = _pointsPaid; v69.Clean = value; _pointsPaid = v69;
                var v70 = _rateRegistrationExpirationDate; v70.Clean = value; _rateRegistrationExpirationDate = v70;
                var v71 = _rateRegistrationInvestorName; v71.Clean = value; _rateRegistrationInvestorName = v71;
                var v72 = _rateRegistrationLoanIsRegistered; v72.Clean = value; _rateRegistrationLoanIsRegistered = v72;
                var v73 = _rateRegistrationReference; v73.Clean = value; _rateRegistrationReference = v73;
                var v74 = _rateRegistrationRegisteredBy; v74.Clean = value; _rateRegistrationRegisteredBy = v74;
                var v75 = _rateRegistrationRegisteredUserId; v75.Clean = value; _rateRegistrationRegisteredUserId = v75;
                var v76 = _rateRegistrationRegistrationDate; v76.Clean = value; _rateRegistrationRegistrationDate = v76;
                var v77 = _refundOrOverpaidInterest; v77.Clean = value; _refundOrOverpaidInterest = v77;
                var v78 = _schoolTaxExcluded; v78.Clean = value; _schoolTaxExcluded = v78;
                var v79 = _state; v79.Clean = value; _state = v79;
                var v80 = _statusUrl; v80.Clean = value; _statusUrl = v80;
                var v81 = _submitDate; v81.Clean = value; _submitDate = v81;
                var v82 = _subTaxYear; v82.Clean = value; _subTaxYear = v82;
                var v83 = _subTaxYearInterestReceived; v83.Clean = value; _subTaxYearInterestReceived = v83;
                var v84 = _subTaxYearMIPremiums; v84.Clean = value; _subTaxYearMIPremiums = v84;
                var v85 = _subTaxYearPointsPaid; v85.Clean = value; _subTaxYearPointsPaid = v85;
                var v86 = _subTaxYearRefundOrOverpaidInterest; v86.Clean = value; _subTaxYearRefundOrOverpaidInterest = v86;
                var v87 = _taxId; v87.Clean = value; _taxId = v87;
                var v88 = _totalBox4; v88.Clean = value; _totalBox4 = v88;
                var v89 = _totalYearlyMi; v89.Clean = value; _totalYearlyMi = v89;
                var v90 = _useGfeTax; v90.Clean = value; _useGfeTax = v90;
                var v91 = _useRegZMi; v91.Clean = value; _useRegZMi = v91;
                var v92 = _zip; v92.Clean = value; _zip = v92;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}