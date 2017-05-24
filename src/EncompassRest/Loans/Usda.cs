using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Usda
    {
        private Value<decimal?> _additionalIncomeFromPrimaryEmployment;
        public decimal? AdditionalIncomeFromPrimaryEmployment { get { return _additionalIncomeFromPrimaryEmployment; } set { _additionalIncomeFromPrimaryEmployment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalIncomeFromPrimaryEmployment() => !_additionalIncomeFromPrimaryEmployment.Clean;
        private Value<decimal?> _additionalMemberBaseIncome;
        public decimal? AdditionalMemberBaseIncome { get { return _additionalMemberBaseIncome; } set { _additionalMemberBaseIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalMemberBaseIncome() => !_additionalMemberBaseIncome.Clean;
        private Value<decimal?> _adjustedAnnualIncome;
        public decimal? AdjustedAnnualIncome { get { return _adjustedAnnualIncome; } set { _adjustedAnnualIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedAnnualIncome() => !_adjustedAnnualIncome.Clean;
        private Value<string> _adjustedIncomeCalculationDescription1;
        public string AdjustedIncomeCalculationDescription1 { get { return _adjustedIncomeCalculationDescription1; } set { _adjustedIncomeCalculationDescription1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedIncomeCalculationDescription1() => !_adjustedIncomeCalculationDescription1.Clean;
        private Value<string> _adjustedIncomeCalculationDescription2;
        public string AdjustedIncomeCalculationDescription2 { get { return _adjustedIncomeCalculationDescription2; } set { _adjustedIncomeCalculationDescription2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedIncomeCalculationDescription2() => !_adjustedIncomeCalculationDescription2.Clean;
        private Value<string> _adjustedIncomeCalculationDescription3;
        public string AdjustedIncomeCalculationDescription3 { get { return _adjustedIncomeCalculationDescription3; } set { _adjustedIncomeCalculationDescription3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedIncomeCalculationDescription3() => !_adjustedIncomeCalculationDescription3.Clean;
        private Value<decimal?> _advanceAmountToDate;
        public decimal? AdvanceAmountToDate { get { return _advanceAmountToDate; } set { _advanceAmountToDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdvanceAmountToDate() => !_advanceAmountToDate.Clean;
        private Value<decimal?> _amountLoanlineCredit;
        public decimal? AmountLoanlineCredit { get { return _amountLoanlineCredit; } set { _amountLoanlineCredit = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountLoanlineCredit() => !_amountLoanlineCredit.Clean;
        private Value<decimal?> _annualChildCareExpenses;
        public decimal? AnnualChildCareExpenses { get { return _annualChildCareExpenses; } set { _annualChildCareExpenses = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualChildCareExpenses() => !_annualChildCareExpenses.Clean;
        private Value<decimal?> _annualIncome;
        public decimal? AnnualIncome { get { return _annualIncome; } set { _annualIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualIncome() => !_annualIncome.Clean;
        private Value<string> _annualIncomeCalculationDescription1;
        public string AnnualIncomeCalculationDescription1 { get { return _annualIncomeCalculationDescription1; } set { _annualIncomeCalculationDescription1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualIncomeCalculationDescription1() => !_annualIncomeCalculationDescription1.Clean;
        private Value<string> _annualIncomeCalculationDescription2;
        public string AnnualIncomeCalculationDescription2 { get { return _annualIncomeCalculationDescription2; } set { _annualIncomeCalculationDescription2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualIncomeCalculationDescription2() => !_annualIncomeCalculationDescription2.Clean;
        private Value<string> _annualIncomeCalculationDescription3;
        public string AnnualIncomeCalculationDescription3 { get { return _annualIncomeCalculationDescription3; } set { _annualIncomeCalculationDescription3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualIncomeCalculationDescription3() => !_annualIncomeCalculationDescription3.Clean;
        private Value<string> _annualIncomeCalculationDescription4;
        public string AnnualIncomeCalculationDescription4 { get { return _annualIncomeCalculationDescription4; } set { _annualIncomeCalculationDescription4 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualIncomeCalculationDescription4() => !_annualIncomeCalculationDescription4.Clean;
        private Value<string> _annualIncomeCalculationDescription5;
        public string AnnualIncomeCalculationDescription5 { get { return _annualIncomeCalculationDescription5; } set { _annualIncomeCalculationDescription5 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualIncomeCalculationDescription5() => !_annualIncomeCalculationDescription5.Clean;
        private Value<DateTime?> _annualReviewDate;
        public DateTime? AnnualReviewDate { get { return _annualReviewDate; } set { _annualReviewDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualReviewDate() => !_annualReviewDate.Clean;
        private Value<string> _applicationNumber;
        public string ApplicationNumber { get { return _applicationNumber; } set { _applicationNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicationNumber() => !_applicationNumber.Clean;
        private Value<string> _approvedLenderTaxId;
        public string ApprovedLenderTaxId { get { return _approvedLenderTaxId; } set { _approvedLenderTaxId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApprovedLenderTaxId() => !_approvedLenderTaxId.Clean;
        private Value<decimal?> _assetIncome;
        public decimal? AssetIncome { get { return _assetIncome; } set { _assetIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssetIncome() => !_assetIncome.Clean;
        private Value<decimal?> _balanceOwedOnLoan;
        public decimal? BalanceOwedOnLoan { get { return _balanceOwedOnLoan; } set { _balanceOwedOnLoan = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalanceOwedOnLoan() => !_balanceOwedOnLoan.Clean;
        private Value<decimal?> _borrowerBaseIncome;
        public decimal? BorrowerBaseIncome { get { return _borrowerBaseIncome; } set { _borrowerBaseIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerBaseIncome() => !_borrowerBaseIncome.Clean;
        private Value<decimal?> _borrowerTotalStableIncome;
        public decimal? BorrowerTotalStableIncome { get { return _borrowerTotalStableIncome; } set { _borrowerTotalStableIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTotalStableIncome() => !_borrowerTotalStableIncome.Clean;
        private Value<string> _borrowerTypeCode;
        public string BorrowerTypeCode { get { return _borrowerTypeCode; } set { _borrowerTypeCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTypeCode() => !_borrowerTypeCode.Clean;
        private Value<decimal?> _buydownInterestAssistanceRate;
        public decimal? BuydownInterestAssistanceRate { get { return _buydownInterestAssistanceRate; } set { _buydownInterestAssistanceRate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownInterestAssistanceRate() => !_buydownInterestAssistanceRate.Clean;
        private Value<string> _caseNumberBorrowerId;
        public string CaseNumberBorrowerId { get { return _caseNumberBorrowerId; } set { _caseNumberBorrowerId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCaseNumberBorrowerId() => !_caseNumberBorrowerId.Clean;
        private Value<string> _caseNumberCo;
        public string CaseNumberCo { get { return _caseNumberCo; } set { _caseNumberCo = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCaseNumberCo() => !_caseNumberCo.Clean;
        private Value<string> _caseNumberSt;
        public string CaseNumberSt { get { return _caseNumberSt; } set { _caseNumberSt = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCaseNumberSt() => !_caseNumberSt.Clean;
        private Value<DateTime?> _certificationEffectiveDate;
        public DateTime? CertificationEffectiveDate { get { return _certificationEffectiveDate; } set { _certificationEffectiveDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertificationEffectiveDate() => !_certificationEffectiveDate.Clean;
        private Value<DateTime?> _certificationExpirationDate;
        public DateTime? CertificationExpirationDate { get { return _certificationExpirationDate; } set { _certificationExpirationDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertificationExpirationDate() => !_certificationExpirationDate.Clean;
        private Value<bool?> _certifiedLoanIndicator;
        public bool? CertifiedLoanIndicator { get { return _certifiedLoanIndicator; } set { _certifiedLoanIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertifiedLoanIndicator() => !_certifiedLoanIndicator.Clean;
        private Value<string> _childCareProviderAddress;
        public string ChildCareProviderAddress { get { return _childCareProviderAddress; } set { _childCareProviderAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCareProviderAddress() => !_childCareProviderAddress.Clean;
        private Value<string> _childCareProviderCity;
        public string ChildCareProviderCity { get { return _childCareProviderCity; } set { _childCareProviderCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCareProviderCity() => !_childCareProviderCity.Clean;
        private Value<string> _childCareProviderPhone;
        public string ChildCareProviderPhone { get { return _childCareProviderPhone; } set { _childCareProviderPhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCareProviderPhone() => !_childCareProviderPhone.Clean;
        private Value<string> _childCareProviderProviderName;
        public string ChildCareProviderProviderName { get { return _childCareProviderProviderName; } set { _childCareProviderProviderName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCareProviderProviderName() => !_childCareProviderProviderName.Clean;
        private Value<string> _childCareProviderState;
        public string ChildCareProviderState { get { return _childCareProviderState; } set { _childCareProviderState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCareProviderState() => !_childCareProviderState.Clean;
        private Value<string> _childCareProviderZip;
        public string ChildCareProviderZip { get { return _childCareProviderZip; } set { _childCareProviderZip = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCareProviderZip() => !_childCareProviderZip.Clean;
        private Value<decimal?> _childCostPerMonth;
        public decimal? ChildCostPerMonth { get { return _childCostPerMonth; } set { _childCostPerMonth = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCostPerMonth() => !_childCostPerMonth.Clean;
        private Value<decimal?> _childCostPerWeek;
        public decimal? ChildCostPerWeek { get { return _childCostPerWeek; } set { _childCostPerWeek = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChildCostPerWeek() => !_childCostPerWeek.Clean;
        private Value<decimal?> _coborrowerBaseIncome;
        public decimal? CoborrowerBaseIncome { get { return _coborrowerBaseIncome; } set { _coborrowerBaseIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoborrowerBaseIncome() => !_coborrowerBaseIncome.Clean;
        private Value<decimal?> _coborrowerStableBaseIncome;
        public decimal? CoborrowerStableBaseIncome { get { return _coborrowerStableBaseIncome; } set { _coborrowerStableBaseIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoborrowerStableBaseIncome() => !_coborrowerStableBaseIncome.Clean;
        private Value<string> _coborrowerStableBaseIncomeDesc;
        public string CoborrowerStableBaseIncomeDesc { get { return _coborrowerStableBaseIncomeDesc; } set { _coborrowerStableBaseIncomeDesc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoborrowerStableBaseIncomeDesc() => !_coborrowerStableBaseIncomeDesc.Clean;
        private Value<decimal?> _coborrowerStableOtherIncome;
        public decimal? CoborrowerStableOtherIncome { get { return _coborrowerStableOtherIncome; } set { _coborrowerStableOtherIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoborrowerStableOtherIncome() => !_coborrowerStableOtherIncome.Clean;
        private Value<string> _coborrowerStableOtherIncomeDesc;
        public string CoborrowerStableOtherIncomeDesc { get { return _coborrowerStableOtherIncomeDesc; } set { _coborrowerStableOtherIncomeDesc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoborrowerStableOtherIncomeDesc() => !_coborrowerStableOtherIncomeDesc.Clean;
        private Value<decimal?> _coBorrowerTotalStableIncome;
        public decimal? CoBorrowerTotalStableIncome { get { return _coBorrowerTotalStableIncome; } set { _coBorrowerTotalStableIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerTotalStableIncome() => !_coBorrowerTotalStableIncome.Clean;
        private Value<DateTime?> _dateConfirmedObligationProcessed;
        public DateTime? DateConfirmedObligationProcessed { get { return _dateConfirmedObligationProcessed; } set { _dateConfirmedObligationProcessed = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateConfirmedObligationProcessed() => !_dateConfirmedObligationProcessed.Clean;
        private Value<DateTime?> _dateLoanNoteGuaranteeIssued;
        public DateTime? DateLoanNoteGuaranteeIssued { get { return _dateLoanNoteGuaranteeIssued; } set { _dateLoanNoteGuaranteeIssued = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateLoanNoteGuaranteeIssued() => !_dateLoanNoteGuaranteeIssued.Clean;
        private Value<DateTime?> _dateLoanNoteGuaranteeRequestReceived;
        public DateTime? DateLoanNoteGuaranteeRequestReceived { get { return _dateLoanNoteGuaranteeRequestReceived; } set { _dateLoanNoteGuaranteeRequestReceived = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateLoanNoteGuaranteeRequestReceived() => !_dateLoanNoteGuaranteeRequestReceived.Clean;
        private Value<DateTime?> _dateObligationInGls;
        public DateTime? DateObligationInGls { get { return _dateObligationInGls; } set { _dateObligationInGls = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateObligationInGls() => !_dateObligationInGls.Clean;
        private Value<DateTime?> _dateVerifiedInUnifi;
        public DateTime? DateVerifiedInUnifi { get { return _dateVerifiedInUnifi; } set { _dateVerifiedInUnifi = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateVerifiedInUnifi() => !_dateVerifiedInUnifi.Clean;
        private Value<decimal?> _dependentDeduction;
        public decimal? DependentDeduction { get { return _dependentDeduction; } set { _dependentDeduction = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDependentDeduction() => !_dependentDeduction.Clean;
        private Value<decimal?> _disabilityDeduction;
        public decimal? DisabilityDeduction { get { return _disabilityDeduction; } set { _disabilityDeduction = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisabilityDeduction() => !_disabilityDeduction.Clean;
        private Value<decimal?> _elderlyHouseholdDeduction;
        public decimal? ElderlyHouseholdDeduction { get { return _elderlyHouseholdDeduction; } set { _elderlyHouseholdDeduction = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeElderlyHouseholdDeduction() => !_elderlyHouseholdDeduction.Clean;
        private Value<decimal?> _feeRate;
        public decimal? FeeRate { get { return _feeRate; } set { _feeRate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeRate() => !_feeRate.Clean;
        private Value<string> _financedLoanClosingCostDescription;
        public string FinancedLoanClosingCostDescription { get { return _financedLoanClosingCostDescription; } set { _financedLoanClosingCostDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancedLoanClosingCostDescription() => !_financedLoanClosingCostDescription.Clean;
        private Value<decimal?> _guaranteeFeeCollected;
        public decimal? GuaranteeFeeCollected { get { return _guaranteeFeeCollected; } set { _guaranteeFeeCollected = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuaranteeFeeCollected() => !_guaranteeFeeCollected.Clean;
        private Value<decimal?> _guaranteeFeeOnCommitment;
        public decimal? GuaranteeFeeOnCommitment { get { return _guaranteeFeeOnCommitment; } set { _guaranteeFeeOnCommitment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuaranteeFeeOnCommitment() => !_guaranteeFeeOnCommitment.Clean;
        private Value<string> _guaranteeFeePurposeCodeType;
        public string GuaranteeFeePurposeCodeType { get { return _guaranteeFeePurposeCodeType; } set { _guaranteeFeePurposeCodeType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuaranteeFeePurposeCodeType() => !_guaranteeFeePurposeCodeType.Clean;
        private Value<DateTime?> _guaranteePeriodBeginsDate;
        public DateTime? GuaranteePeriodBeginsDate { get { return _guaranteePeriodBeginsDate; } set { _guaranteePeriodBeginsDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuaranteePeriodBeginsDate() => !_guaranteePeriodBeginsDate.Clean;
        private Value<DateTime?> _guaranteePeriodEndsDate;
        public DateTime? GuaranteePeriodEndsDate { get { return _guaranteePeriodEndsDate; } set { _guaranteePeriodEndsDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuaranteePeriodEndsDate() => !_guaranteePeriodEndsDate.Clean;
        private Value<string> _guaranteeType;
        public string GuaranteeType { get { return _guaranteeType; } set { _guaranteeType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuaranteeType() => !_guaranteeType.Clean;
        private Value<int?> _householdSize;
        public int? HouseholdSize { get { return _householdSize; } set { _householdSize = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHouseholdSize() => !_householdSize.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _interestAssistanceCodeType;
        public string InterestAssistanceCodeType { get { return _interestAssistanceCodeType; } set { _interestAssistanceCodeType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestAssistanceCodeType() => !_interestAssistanceCodeType.Clean;
        private Value<bool?> _interestRateBasedonFannieIndicator;
        public bool? InterestRateBasedonFannieIndicator { get { return _interestRateBasedonFannieIndicator; } set { _interestRateBasedonFannieIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateBasedonFannieIndicator() => !_interestRateBasedonFannieIndicator.Clean;
        private Value<string> _interestRateCodeType;
        public string InterestRateCodeType { get { return _interestRateCodeType; } set { _interestRateCodeType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateCodeType() => !_interestRateCodeType.Clean;
        private Value<bool?> _interestRateFloatToLoanClosingIndicator;
        public bool? InterestRateFloatToLoanClosingIndicator { get { return _interestRateFloatToLoanClosingIndicator; } set { _interestRateFloatToLoanClosingIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateFloatToLoanClosingIndicator() => !_interestRateFloatToLoanClosingIndicator.Clean;
        private Value<bool?> _lackAdequateHeatIndicator;
        public bool? LackAdequateHeatIndicator { get { return _lackAdequateHeatIndicator; } set { _lackAdequateHeatIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLackAdequateHeatIndicator() => !_lackAdequateHeatIndicator.Clean;
        private Value<string> _lenderAuthorizedRepCompany;
        public string LenderAuthorizedRepCompany { get { return _lenderAuthorizedRepCompany; } set { _lenderAuthorizedRepCompany = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAuthorizedRepCompany() => !_lenderAuthorizedRepCompany.Clean;
        private Value<string> _lenderAuthorizedRepName;
        public string LenderAuthorizedRepName { get { return _lenderAuthorizedRepName; } set { _lenderAuthorizedRepName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAuthorizedRepName() => !_lenderAuthorizedRepName.Clean;
        private Value<string> _lenderAuthorizedRepTitle;
        public string LenderAuthorizedRepTitle { get { return _lenderAuthorizedRepTitle; } set { _lenderAuthorizedRepTitle = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAuthorizedRepTitle() => !_lenderAuthorizedRepTitle.Clean;
        private Value<string> _lenderIdNo;
        public string LenderIdNo { get { return _lenderIdNo; } set { _lenderIdNo = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderIdNo() => !_lenderIdNo.Clean;
        private Value<decimal?> _lenderNoteRateOnGuaranteedPortion;
        public decimal? LenderNoteRateOnGuaranteedPortion { get { return _lenderNoteRateOnGuaranteedPortion; } set { _lenderNoteRateOnGuaranteedPortion = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderNoteRateOnGuaranteedPortion() => !_lenderNoteRateOnGuaranteedPortion.Clean;
        private Value<decimal?> _lenderNoteRateOnNonGuaranteedPortion;
        public decimal? LenderNoteRateOnNonGuaranteedPortion { get { return _lenderNoteRateOnNonGuaranteedPortion; } set { _lenderNoteRateOnNonGuaranteedPortion = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderNoteRateOnNonGuaranteedPortion() => !_lenderNoteRateOnNonGuaranteedPortion.Clean;
        private Value<string> _lenderStatusCodeType;
        public string LenderStatusCodeType { get { return _lenderStatusCodeType; } set { _lenderStatusCodeType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderStatusCodeType() => !_lenderStatusCodeType.Clean;
        private Value<string> _lenderTypeCode;
        public string LenderTypeCode { get { return _lenderTypeCode; } set { _lenderTypeCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderTypeCode() => !_lenderTypeCode.Clean;
        private Value<string> _loanType;
        public string LoanType { get { return _loanType; } set { _loanType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanType() => !_loanType.Clean;
        private Value<bool?> _lockCompletePlumbingIndicator;
        public bool? LockCompletePlumbingIndicator { get { return _lockCompletePlumbingIndicator; } set { _lockCompletePlumbingIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockCompletePlumbingIndicator() => !_lockCompletePlumbingIndicator.Clean;
        private Value<decimal?> _medicalExpenses;
        public decimal? MedicalExpenses { get { return _medicalExpenses; } set { _medicalExpenses = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMedicalExpenses() => !_medicalExpenses.Clean;
        private Value<decimal?> _moderateIncomeLimit;
        public decimal? ModerateIncomeLimit { get { return _moderateIncomeLimit; } set { _moderateIncomeLimit = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeModerateIncomeLimit() => !_moderateIncomeLimit.Clean;
        private Value<decimal?> _monthlyRepaymentIncome;
        public decimal? MonthlyRepaymentIncome { get { return _monthlyRepaymentIncome; } set { _monthlyRepaymentIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyRepaymentIncome() => !_monthlyRepaymentIncome.Clean;
        private Value<int?> _numberofDependents;
        public int? NumberofDependents { get { return _numberofDependents; } set { _numberofDependents = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberofDependents() => !_numberofDependents.Clean;
        private Value<int?> _numberofPeopleInHousehold;
        public int? NumberofPeopleInHousehold { get { return _numberofPeopleInHousehold; } set { _numberofPeopleInHousehold = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberofPeopleInHousehold() => !_numberofPeopleInHousehold.Clean;
        private Value<bool?> _obligationMatchesCommitmentLenderRequestIndicator;
        public bool? ObligationMatchesCommitmentLenderRequestIndicator { get { return _obligationMatchesCommitmentLenderRequestIndicator; } set { _obligationMatchesCommitmentLenderRequestIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeObligationMatchesCommitmentLenderRequestIndicator() => !_obligationMatchesCommitmentLenderRequestIndicator.Clean;
        private Value<string> _officialWhoConfirmedGlsUpdated;
        public string OfficialWhoConfirmedGlsUpdated { get { return _officialWhoConfirmedGlsUpdated; } set { _officialWhoConfirmedGlsUpdated = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOfficialWhoConfirmedGlsUpdated() => !_officialWhoConfirmedGlsUpdated.Clean;
        private Value<decimal?> _otherIncome;
        public decimal? OtherIncome { get { return _otherIncome; } set { _otherIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherIncome() => !_otherIncome.Clean;
        private Value<decimal?> _otherStableDependableMonthlyIncome;
        public decimal? OtherStableDependableMonthlyIncome { get { return _otherStableDependableMonthlyIncome; } set { _otherStableDependableMonthlyIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherStableDependableMonthlyIncome() => !_otherStableDependableMonthlyIncome.Clean;
        private Value<bool?> _overcrowdedIndicator;
        public bool? OvercrowdedIndicator { get { return _overcrowdedIndicator; } set { _overcrowdedIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOvercrowdedIndicator() => !_overcrowdedIndicator.Clean;
        private Value<decimal?> _percentofLoanGuaranteed;
        public decimal? PercentofLoanGuaranteed { get { return _percentofLoanGuaranteed; } set { _percentofLoanGuaranteed = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentofLoanGuaranteed() => !_percentofLoanGuaranteed.Clean;
        private Value<string> _periodOperatingLineCreditYearsType;
        public string PeriodOperatingLineCreditYearsType { get { return _periodOperatingLineCreditYearsType; } set { _periodOperatingLineCreditYearsType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePeriodOperatingLineCreditYearsType() => !_periodOperatingLineCreditYearsType.Clean;
        private Value<bool?> _physicallyDeterioratedIndicator;
        public bool? PhysicallyDeterioratedIndicator { get { return _physicallyDeterioratedIndicator; } set { _physicallyDeterioratedIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhysicallyDeterioratedIndicator() => !_physicallyDeterioratedIndicator.Clean;
        private Value<string> _preparedByName;
        public string PreparedByName { get { return _preparedByName; } set { _preparedByName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreparedByName() => !_preparedByName.Clean;
        private Value<string> _preparedByTitle;
        public string PreparedByTitle { get { return _preparedByTitle; } set { _preparedByTitle = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreparedByTitle() => !_preparedByTitle.Clean;
        private Value<string> _presentLandloardAddress;
        public string PresentLandloardAddress { get { return _presentLandloardAddress; } set { _presentLandloardAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePresentLandloardAddress() => !_presentLandloardAddress.Clean;
        private Value<string> _presentLandloardCity;
        public string PresentLandloardCity { get { return _presentLandloardCity; } set { _presentLandloardCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePresentLandloardCity() => !_presentLandloardCity.Clean;
        private Value<string> _presentLandloardName;
        public string PresentLandloardName { get { return _presentLandloardName; } set { _presentLandloardName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePresentLandloardName() => !_presentLandloardName.Clean;
        private Value<string> _presentLandloardPhone;
        public string PresentLandloardPhone { get { return _presentLandloardPhone; } set { _presentLandloardPhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePresentLandloardPhone() => !_presentLandloardPhone.Clean;
        private Value<string> _presentLandloardState;
        public string PresentLandloardState { get { return _presentLandloardState; } set { _presentLandloardState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePresentLandloardState() => !_presentLandloardState.Clean;
        private Value<string> _presentLandloardZip;
        public string PresentLandloardZip { get { return _presentLandloardZip; } set { _presentLandloardZip = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePresentLandloardZip() => !_presentLandloardZip.Clean;
        private Value<string> _previousLandloardAddress;
        public string PreviousLandloardAddress { get { return _previousLandloardAddress; } set { _previousLandloardAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousLandloardAddress() => !_previousLandloardAddress.Clean;
        private Value<string> _previousLandloardCity;
        public string PreviousLandloardCity { get { return _previousLandloardCity; } set { _previousLandloardCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousLandloardCity() => !_previousLandloardCity.Clean;
        private Value<string> _previousLandloardName;
        public string PreviousLandloardName { get { return _previousLandloardName; } set { _previousLandloardName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousLandloardName() => !_previousLandloardName.Clean;
        private Value<string> _previousLandloardPhone;
        public string PreviousLandloardPhone { get { return _previousLandloardPhone; } set { _previousLandloardPhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousLandloardPhone() => !_previousLandloardPhone.Clean;
        private Value<string> _previousLandloardState;
        public string PreviousLandloardState { get { return _previousLandloardState; } set { _previousLandloardState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousLandloardState() => !_previousLandloardState.Clean;
        private Value<string> _previousLandloardZip;
        public string PreviousLandloardZip { get { return _previousLandloardZip; } set { _previousLandloardZip = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousLandloardZip() => !_previousLandloardZip.Clean;
        private Value<decimal?> _purchaseOrRefinancedAmount;
        public decimal? PurchaseOrRefinancedAmount { get { return _purchaseOrRefinancedAmount; } set { _purchaseOrRefinancedAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseOrRefinancedAmount() => !_purchaseOrRefinancedAmount.Clean;
        private Value<string> _purchaseOrRefinanceDescription;
        public string PurchaseOrRefinanceDescription { get { return _purchaseOrRefinanceDescription; } set { _purchaseOrRefinanceDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchaseOrRefinanceDescription() => !_purchaseOrRefinanceDescription.Clean;
        private Value<string> _rdsfhRefinancedLoanIndicatorType;
        public string RdsfhRefinancedLoanIndicatorType { get { return _rdsfhRefinancedLoanIndicatorType; } set { _rdsfhRefinancedLoanIndicatorType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRdsfhRefinancedLoanIndicatorType() => !_rdsfhRefinancedLoanIndicatorType.Clean;
        private Value<bool?> _refinanceLoanIndicator;
        public bool? RefinanceLoanIndicator { get { return _refinanceLoanIndicator; } set { _refinanceLoanIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceLoanIndicator() => !_refinanceLoanIndicator.Clean;
        private Value<decimal?> _repairOtherAmount;
        public decimal? RepairOtherAmount { get { return _repairOtherAmount; } set { _repairOtherAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRepairOtherAmount() => !_repairOtherAmount.Clean;
        private Value<string> _repairOtherDescription;
        public string RepairOtherDescription { get { return _repairOtherDescription; } set { _repairOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRepairOtherDescription() => !_repairOtherDescription.Clean;
        private Value<decimal?> _reservationAmountRequested;
        public decimal? ReservationAmountRequested { get { return _reservationAmountRequested; } set { _reservationAmountRequested = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReservationAmountRequested() => !_reservationAmountRequested.Clean;
        private Value<string> _reserved;
        public string Reserved { get { return _reserved; } set { _reserved = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReserved() => !_reserved.Clean;
        private Value<string> _servicingOfficeName;
        public string ServicingOfficeName { get { return _servicingOfficeName; } set { _servicingOfficeName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingOfficeName() => !_servicingOfficeName.Clean;
        private Value<bool?> _sfhglpIndicator;
        public bool? SfhglpIndicator { get { return _sfhglpIndicator; } set { _sfhglpIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSfhglpIndicator() => !_sfhglpIndicator.Clean;
        private Value<string> _sourceOfFundsType;
        public string SourceOfFundsType { get { return _sourceOfFundsType; } set { _sourceOfFundsType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourceOfFundsType() => !_sourceOfFundsType.Clean;
        private Value<decimal?> _stableDependableMonthlyIncome;
        public decimal? StableDependableMonthlyIncome { get { return _stableDependableMonthlyIncome; } set { _stableDependableMonthlyIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStableDependableMonthlyIncome() => !_stableDependableMonthlyIncome.Clean;
        private Value<string> _stableOtherIncomeDesc;
        public string StableOtherIncomeDesc { get { return _stableOtherIncomeDesc; } set { _stableOtherIncomeDesc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStableOtherIncomeDesc() => !_stableOtherIncomeDesc.Clean;
        private Value<string> _submittingLenderAddress;
        public string SubmittingLenderAddress { get { return _submittingLenderAddress; } set { _submittingLenderAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderAddress() => !_submittingLenderAddress.Clean;
        private Value<string> _submittingLenderCity;
        public string SubmittingLenderCity { get { return _submittingLenderCity; } set { _submittingLenderCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderCity() => !_submittingLenderCity.Clean;
        private Value<string> _submittingLenderContactFax;
        public string SubmittingLenderContactFax { get { return _submittingLenderContactFax; } set { _submittingLenderContactFax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderContactFax() => !_submittingLenderContactFax.Clean;
        private Value<string> _submittingLenderContactName;
        public string SubmittingLenderContactName { get { return _submittingLenderContactName; } set { _submittingLenderContactName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderContactName() => !_submittingLenderContactName.Clean;
        private Value<string> _submittingLenderContactPhone;
        public string SubmittingLenderContactPhone { get { return _submittingLenderContactPhone; } set { _submittingLenderContactPhone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderContactPhone() => !_submittingLenderContactPhone.Clean;
        private Value<string> _submittingLenderName;
        public string SubmittingLenderName { get { return _submittingLenderName; } set { _submittingLenderName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderName() => !_submittingLenderName.Clean;
        private Value<string> _submittingLenderState;
        public string SubmittingLenderState { get { return _submittingLenderState; } set { _submittingLenderState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderState() => !_submittingLenderState.Clean;
        private Value<string> _submittingLenderTaxId;
        public string SubmittingLenderTaxId { get { return _submittingLenderTaxId; } set { _submittingLenderTaxId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderTaxId() => !_submittingLenderTaxId.Clean;
        private Value<string> _submittingLenderZip;
        public string SubmittingLenderZip { get { return _submittingLenderZip; } set { _submittingLenderZip = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmittingLenderZip() => !_submittingLenderZip.Clean;
        private Value<int?> _termOfBuydown;
        public int? TermOfBuydown { get { return _termOfBuydown; } set { _termOfBuydown = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTermOfBuydown() => !_termOfBuydown.Clean;
        private Value<string> _thirdPartyOriginator;
        public string ThirdPartyOriginator { get { return _thirdPartyOriginator; } set { _thirdPartyOriginator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThirdPartyOriginator() => !_thirdPartyOriginator.Clean;
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitle() => !_title.Clean;
        private Value<decimal?> _totalBorrowerStableBaseIncome;
        public decimal? TotalBorrowerStableBaseIncome { get { return _totalBorrowerStableBaseIncome; } set { _totalBorrowerStableBaseIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBorrowerStableBaseIncome() => !_totalBorrowerStableBaseIncome.Clean;
        private Value<decimal?> _totalBorrowerStableOtherIncome;
        public decimal? TotalBorrowerStableOtherIncome { get { return _totalBorrowerStableOtherIncome; } set { _totalBorrowerStableOtherIncome = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBorrowerStableOtherIncome() => !_totalBorrowerStableOtherIncome.Clean;
        private Value<decimal?> _totalHouseholdDeduction;
        public decimal? TotalHouseholdDeduction { get { return _totalHouseholdDeduction; } set { _totalHouseholdDeduction = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalHouseholdDeduction() => !_totalHouseholdDeduction.Clean;
        private Value<decimal?> _totalRequestAmount;
        public decimal? TotalRequestAmount { get { return _totalRequestAmount; } set { _totalRequestAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalRequestAmount() => !_totalRequestAmount.Clean;
        private Value<string> _tpoTaxId;
        public string TpoTaxId { get { return _tpoTaxId; } set { _tpoTaxId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTpoTaxId() => !_tpoTaxId.Clean;
        private Value<string> _underwritingDecisionBy;
        public string UnderwritingDecisionBy { get { return _underwritingDecisionBy; } set { _underwritingDecisionBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingDecisionBy() => !_underwritingDecisionBy.Clean;
        private Value<DateTime?> _underwritingDecisionDate;
        public DateTime? UnderwritingDecisionDate { get { return _underwritingDecisionDate; } set { _underwritingDecisionDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingDecisionDate() => !_underwritingDecisionDate.Clean;
        private Value<string> _underwritingDecisionType;
        public string UnderwritingDecisionType { get { return _underwritingDecisionType; } set { _underwritingDecisionType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingDecisionType() => !_underwritingDecisionType.Clean;
        private Value<List<UsdaHouseholdIncome>> _usdaHouseholdIncomes;
        public List<UsdaHouseholdIncome> UsdaHouseholdIncomes { get { return _usdaHouseholdIncomes; } set { _usdaHouseholdIncomes = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUsdaHouseholdIncomes() => !_usdaHouseholdIncomes.Clean;
        private Value<string> _verificationCode;
        public string VerificationCode { get { return _verificationCode; } set { _verificationCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVerificationCode() => !_verificationCode.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _additionalIncomeFromPrimaryEmployment.Clean
                    && _additionalMemberBaseIncome.Clean
                    && _adjustedAnnualIncome.Clean
                    && _adjustedIncomeCalculationDescription1.Clean
                    && _adjustedIncomeCalculationDescription2.Clean
                    && _adjustedIncomeCalculationDescription3.Clean
                    && _advanceAmountToDate.Clean
                    && _amountLoanlineCredit.Clean
                    && _annualChildCareExpenses.Clean
                    && _annualIncome.Clean
                    && _annualIncomeCalculationDescription1.Clean
                    && _annualIncomeCalculationDescription2.Clean
                    && _annualIncomeCalculationDescription3.Clean
                    && _annualIncomeCalculationDescription4.Clean
                    && _annualIncomeCalculationDescription5.Clean
                    && _annualReviewDate.Clean
                    && _applicationNumber.Clean
                    && _approvedLenderTaxId.Clean
                    && _assetIncome.Clean
                    && _balanceOwedOnLoan.Clean
                    && _borrowerBaseIncome.Clean
                    && _borrowerTotalStableIncome.Clean
                    && _borrowerTypeCode.Clean
                    && _buydownInterestAssistanceRate.Clean
                    && _caseNumberBorrowerId.Clean
                    && _caseNumberCo.Clean
                    && _caseNumberSt.Clean
                    && _certificationEffectiveDate.Clean
                    && _certificationExpirationDate.Clean
                    && _certifiedLoanIndicator.Clean
                    && _childCareProviderAddress.Clean
                    && _childCareProviderCity.Clean
                    && _childCareProviderPhone.Clean
                    && _childCareProviderProviderName.Clean
                    && _childCareProviderState.Clean
                    && _childCareProviderZip.Clean
                    && _childCostPerMonth.Clean
                    && _childCostPerWeek.Clean
                    && _coborrowerBaseIncome.Clean
                    && _coborrowerStableBaseIncome.Clean
                    && _coborrowerStableBaseIncomeDesc.Clean
                    && _coborrowerStableOtherIncome.Clean
                    && _coborrowerStableOtherIncomeDesc.Clean
                    && _coBorrowerTotalStableIncome.Clean
                    && _dateConfirmedObligationProcessed.Clean
                    && _dateLoanNoteGuaranteeIssued.Clean
                    && _dateLoanNoteGuaranteeRequestReceived.Clean
                    && _dateObligationInGls.Clean
                    && _dateVerifiedInUnifi.Clean
                    && _dependentDeduction.Clean
                    && _disabilityDeduction.Clean
                    && _elderlyHouseholdDeduction.Clean
                    && _feeRate.Clean
                    && _financedLoanClosingCostDescription.Clean
                    && _guaranteeFeeCollected.Clean
                    && _guaranteeFeeOnCommitment.Clean
                    && _guaranteeFeePurposeCodeType.Clean
                    && _guaranteePeriodBeginsDate.Clean
                    && _guaranteePeriodEndsDate.Clean
                    && _guaranteeType.Clean
                    && _householdSize.Clean
                    && _id.Clean
                    && _interestAssistanceCodeType.Clean
                    && _interestRateBasedonFannieIndicator.Clean
                    && _interestRateCodeType.Clean
                    && _interestRateFloatToLoanClosingIndicator.Clean
                    && _lackAdequateHeatIndicator.Clean
                    && _lenderAuthorizedRepCompany.Clean
                    && _lenderAuthorizedRepName.Clean
                    && _lenderAuthorizedRepTitle.Clean
                    && _lenderIdNo.Clean
                    && _lenderNoteRateOnGuaranteedPortion.Clean
                    && _lenderNoteRateOnNonGuaranteedPortion.Clean
                    && _lenderStatusCodeType.Clean
                    && _lenderTypeCode.Clean
                    && _loanType.Clean
                    && _lockCompletePlumbingIndicator.Clean
                    && _medicalExpenses.Clean
                    && _moderateIncomeLimit.Clean
                    && _monthlyRepaymentIncome.Clean
                    && _numberofDependents.Clean
                    && _numberofPeopleInHousehold.Clean
                    && _obligationMatchesCommitmentLenderRequestIndicator.Clean
                    && _officialWhoConfirmedGlsUpdated.Clean
                    && _otherIncome.Clean
                    && _otherStableDependableMonthlyIncome.Clean
                    && _overcrowdedIndicator.Clean
                    && _percentofLoanGuaranteed.Clean
                    && _periodOperatingLineCreditYearsType.Clean
                    && _physicallyDeterioratedIndicator.Clean
                    && _preparedByName.Clean
                    && _preparedByTitle.Clean
                    && _presentLandloardAddress.Clean
                    && _presentLandloardCity.Clean
                    && _presentLandloardName.Clean
                    && _presentLandloardPhone.Clean
                    && _presentLandloardState.Clean
                    && _presentLandloardZip.Clean
                    && _previousLandloardAddress.Clean
                    && _previousLandloardCity.Clean
                    && _previousLandloardName.Clean
                    && _previousLandloardPhone.Clean
                    && _previousLandloardState.Clean
                    && _previousLandloardZip.Clean
                    && _purchaseOrRefinancedAmount.Clean
                    && _purchaseOrRefinanceDescription.Clean
                    && _rdsfhRefinancedLoanIndicatorType.Clean
                    && _refinanceLoanIndicator.Clean
                    && _repairOtherAmount.Clean
                    && _repairOtherDescription.Clean
                    && _reservationAmountRequested.Clean
                    && _reserved.Clean
                    && _servicingOfficeName.Clean
                    && _sfhglpIndicator.Clean
                    && _sourceOfFundsType.Clean
                    && _stableDependableMonthlyIncome.Clean
                    && _stableOtherIncomeDesc.Clean
                    && _submittingLenderAddress.Clean
                    && _submittingLenderCity.Clean
                    && _submittingLenderContactFax.Clean
                    && _submittingLenderContactName.Clean
                    && _submittingLenderContactPhone.Clean
                    && _submittingLenderName.Clean
                    && _submittingLenderState.Clean
                    && _submittingLenderTaxId.Clean
                    && _submittingLenderZip.Clean
                    && _termOfBuydown.Clean
                    && _thirdPartyOriginator.Clean
                    && _title.Clean
                    && _totalBorrowerStableBaseIncome.Clean
                    && _totalBorrowerStableOtherIncome.Clean
                    && _totalHouseholdDeduction.Clean
                    && _totalRequestAmount.Clean
                    && _tpoTaxId.Clean
                    && _underwritingDecisionBy.Clean
                    && _underwritingDecisionDate.Clean
                    && _underwritingDecisionType.Clean
                    && _usdaHouseholdIncomes.Clean
                    && _verificationCode.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _additionalIncomeFromPrimaryEmployment; v0.Clean = value; _additionalIncomeFromPrimaryEmployment = v0;
                var v1 = _additionalMemberBaseIncome; v1.Clean = value; _additionalMemberBaseIncome = v1;
                var v2 = _adjustedAnnualIncome; v2.Clean = value; _adjustedAnnualIncome = v2;
                var v3 = _adjustedIncomeCalculationDescription1; v3.Clean = value; _adjustedIncomeCalculationDescription1 = v3;
                var v4 = _adjustedIncomeCalculationDescription2; v4.Clean = value; _adjustedIncomeCalculationDescription2 = v4;
                var v5 = _adjustedIncomeCalculationDescription3; v5.Clean = value; _adjustedIncomeCalculationDescription3 = v5;
                var v6 = _advanceAmountToDate; v6.Clean = value; _advanceAmountToDate = v6;
                var v7 = _amountLoanlineCredit; v7.Clean = value; _amountLoanlineCredit = v7;
                var v8 = _annualChildCareExpenses; v8.Clean = value; _annualChildCareExpenses = v8;
                var v9 = _annualIncome; v9.Clean = value; _annualIncome = v9;
                var v10 = _annualIncomeCalculationDescription1; v10.Clean = value; _annualIncomeCalculationDescription1 = v10;
                var v11 = _annualIncomeCalculationDescription2; v11.Clean = value; _annualIncomeCalculationDescription2 = v11;
                var v12 = _annualIncomeCalculationDescription3; v12.Clean = value; _annualIncomeCalculationDescription3 = v12;
                var v13 = _annualIncomeCalculationDescription4; v13.Clean = value; _annualIncomeCalculationDescription4 = v13;
                var v14 = _annualIncomeCalculationDescription5; v14.Clean = value; _annualIncomeCalculationDescription5 = v14;
                var v15 = _annualReviewDate; v15.Clean = value; _annualReviewDate = v15;
                var v16 = _applicationNumber; v16.Clean = value; _applicationNumber = v16;
                var v17 = _approvedLenderTaxId; v17.Clean = value; _approvedLenderTaxId = v17;
                var v18 = _assetIncome; v18.Clean = value; _assetIncome = v18;
                var v19 = _balanceOwedOnLoan; v19.Clean = value; _balanceOwedOnLoan = v19;
                var v20 = _borrowerBaseIncome; v20.Clean = value; _borrowerBaseIncome = v20;
                var v21 = _borrowerTotalStableIncome; v21.Clean = value; _borrowerTotalStableIncome = v21;
                var v22 = _borrowerTypeCode; v22.Clean = value; _borrowerTypeCode = v22;
                var v23 = _buydownInterestAssistanceRate; v23.Clean = value; _buydownInterestAssistanceRate = v23;
                var v24 = _caseNumberBorrowerId; v24.Clean = value; _caseNumberBorrowerId = v24;
                var v25 = _caseNumberCo; v25.Clean = value; _caseNumberCo = v25;
                var v26 = _caseNumberSt; v26.Clean = value; _caseNumberSt = v26;
                var v27 = _certificationEffectiveDate; v27.Clean = value; _certificationEffectiveDate = v27;
                var v28 = _certificationExpirationDate; v28.Clean = value; _certificationExpirationDate = v28;
                var v29 = _certifiedLoanIndicator; v29.Clean = value; _certifiedLoanIndicator = v29;
                var v30 = _childCareProviderAddress; v30.Clean = value; _childCareProviderAddress = v30;
                var v31 = _childCareProviderCity; v31.Clean = value; _childCareProviderCity = v31;
                var v32 = _childCareProviderPhone; v32.Clean = value; _childCareProviderPhone = v32;
                var v33 = _childCareProviderProviderName; v33.Clean = value; _childCareProviderProviderName = v33;
                var v34 = _childCareProviderState; v34.Clean = value; _childCareProviderState = v34;
                var v35 = _childCareProviderZip; v35.Clean = value; _childCareProviderZip = v35;
                var v36 = _childCostPerMonth; v36.Clean = value; _childCostPerMonth = v36;
                var v37 = _childCostPerWeek; v37.Clean = value; _childCostPerWeek = v37;
                var v38 = _coborrowerBaseIncome; v38.Clean = value; _coborrowerBaseIncome = v38;
                var v39 = _coborrowerStableBaseIncome; v39.Clean = value; _coborrowerStableBaseIncome = v39;
                var v40 = _coborrowerStableBaseIncomeDesc; v40.Clean = value; _coborrowerStableBaseIncomeDesc = v40;
                var v41 = _coborrowerStableOtherIncome; v41.Clean = value; _coborrowerStableOtherIncome = v41;
                var v42 = _coborrowerStableOtherIncomeDesc; v42.Clean = value; _coborrowerStableOtherIncomeDesc = v42;
                var v43 = _coBorrowerTotalStableIncome; v43.Clean = value; _coBorrowerTotalStableIncome = v43;
                var v44 = _dateConfirmedObligationProcessed; v44.Clean = value; _dateConfirmedObligationProcessed = v44;
                var v45 = _dateLoanNoteGuaranteeIssued; v45.Clean = value; _dateLoanNoteGuaranteeIssued = v45;
                var v46 = _dateLoanNoteGuaranteeRequestReceived; v46.Clean = value; _dateLoanNoteGuaranteeRequestReceived = v46;
                var v47 = _dateObligationInGls; v47.Clean = value; _dateObligationInGls = v47;
                var v48 = _dateVerifiedInUnifi; v48.Clean = value; _dateVerifiedInUnifi = v48;
                var v49 = _dependentDeduction; v49.Clean = value; _dependentDeduction = v49;
                var v50 = _disabilityDeduction; v50.Clean = value; _disabilityDeduction = v50;
                var v51 = _elderlyHouseholdDeduction; v51.Clean = value; _elderlyHouseholdDeduction = v51;
                var v52 = _feeRate; v52.Clean = value; _feeRate = v52;
                var v53 = _financedLoanClosingCostDescription; v53.Clean = value; _financedLoanClosingCostDescription = v53;
                var v54 = _guaranteeFeeCollected; v54.Clean = value; _guaranteeFeeCollected = v54;
                var v55 = _guaranteeFeeOnCommitment; v55.Clean = value; _guaranteeFeeOnCommitment = v55;
                var v56 = _guaranteeFeePurposeCodeType; v56.Clean = value; _guaranteeFeePurposeCodeType = v56;
                var v57 = _guaranteePeriodBeginsDate; v57.Clean = value; _guaranteePeriodBeginsDate = v57;
                var v58 = _guaranteePeriodEndsDate; v58.Clean = value; _guaranteePeriodEndsDate = v58;
                var v59 = _guaranteeType; v59.Clean = value; _guaranteeType = v59;
                var v60 = _householdSize; v60.Clean = value; _householdSize = v60;
                var v61 = _id; v61.Clean = value; _id = v61;
                var v62 = _interestAssistanceCodeType; v62.Clean = value; _interestAssistanceCodeType = v62;
                var v63 = _interestRateBasedonFannieIndicator; v63.Clean = value; _interestRateBasedonFannieIndicator = v63;
                var v64 = _interestRateCodeType; v64.Clean = value; _interestRateCodeType = v64;
                var v65 = _interestRateFloatToLoanClosingIndicator; v65.Clean = value; _interestRateFloatToLoanClosingIndicator = v65;
                var v66 = _lackAdequateHeatIndicator; v66.Clean = value; _lackAdequateHeatIndicator = v66;
                var v67 = _lenderAuthorizedRepCompany; v67.Clean = value; _lenderAuthorizedRepCompany = v67;
                var v68 = _lenderAuthorizedRepName; v68.Clean = value; _lenderAuthorizedRepName = v68;
                var v69 = _lenderAuthorizedRepTitle; v69.Clean = value; _lenderAuthorizedRepTitle = v69;
                var v70 = _lenderIdNo; v70.Clean = value; _lenderIdNo = v70;
                var v71 = _lenderNoteRateOnGuaranteedPortion; v71.Clean = value; _lenderNoteRateOnGuaranteedPortion = v71;
                var v72 = _lenderNoteRateOnNonGuaranteedPortion; v72.Clean = value; _lenderNoteRateOnNonGuaranteedPortion = v72;
                var v73 = _lenderStatusCodeType; v73.Clean = value; _lenderStatusCodeType = v73;
                var v74 = _lenderTypeCode; v74.Clean = value; _lenderTypeCode = v74;
                var v75 = _loanType; v75.Clean = value; _loanType = v75;
                var v76 = _lockCompletePlumbingIndicator; v76.Clean = value; _lockCompletePlumbingIndicator = v76;
                var v77 = _medicalExpenses; v77.Clean = value; _medicalExpenses = v77;
                var v78 = _moderateIncomeLimit; v78.Clean = value; _moderateIncomeLimit = v78;
                var v79 = _monthlyRepaymentIncome; v79.Clean = value; _monthlyRepaymentIncome = v79;
                var v80 = _numberofDependents; v80.Clean = value; _numberofDependents = v80;
                var v81 = _numberofPeopleInHousehold; v81.Clean = value; _numberofPeopleInHousehold = v81;
                var v82 = _obligationMatchesCommitmentLenderRequestIndicator; v82.Clean = value; _obligationMatchesCommitmentLenderRequestIndicator = v82;
                var v83 = _officialWhoConfirmedGlsUpdated; v83.Clean = value; _officialWhoConfirmedGlsUpdated = v83;
                var v84 = _otherIncome; v84.Clean = value; _otherIncome = v84;
                var v85 = _otherStableDependableMonthlyIncome; v85.Clean = value; _otherStableDependableMonthlyIncome = v85;
                var v86 = _overcrowdedIndicator; v86.Clean = value; _overcrowdedIndicator = v86;
                var v87 = _percentofLoanGuaranteed; v87.Clean = value; _percentofLoanGuaranteed = v87;
                var v88 = _periodOperatingLineCreditYearsType; v88.Clean = value; _periodOperatingLineCreditYearsType = v88;
                var v89 = _physicallyDeterioratedIndicator; v89.Clean = value; _physicallyDeterioratedIndicator = v89;
                var v90 = _preparedByName; v90.Clean = value; _preparedByName = v90;
                var v91 = _preparedByTitle; v91.Clean = value; _preparedByTitle = v91;
                var v92 = _presentLandloardAddress; v92.Clean = value; _presentLandloardAddress = v92;
                var v93 = _presentLandloardCity; v93.Clean = value; _presentLandloardCity = v93;
                var v94 = _presentLandloardName; v94.Clean = value; _presentLandloardName = v94;
                var v95 = _presentLandloardPhone; v95.Clean = value; _presentLandloardPhone = v95;
                var v96 = _presentLandloardState; v96.Clean = value; _presentLandloardState = v96;
                var v97 = _presentLandloardZip; v97.Clean = value; _presentLandloardZip = v97;
                var v98 = _previousLandloardAddress; v98.Clean = value; _previousLandloardAddress = v98;
                var v99 = _previousLandloardCity; v99.Clean = value; _previousLandloardCity = v99;
                var v100 = _previousLandloardName; v100.Clean = value; _previousLandloardName = v100;
                var v101 = _previousLandloardPhone; v101.Clean = value; _previousLandloardPhone = v101;
                var v102 = _previousLandloardState; v102.Clean = value; _previousLandloardState = v102;
                var v103 = _previousLandloardZip; v103.Clean = value; _previousLandloardZip = v103;
                var v104 = _purchaseOrRefinancedAmount; v104.Clean = value; _purchaseOrRefinancedAmount = v104;
                var v105 = _purchaseOrRefinanceDescription; v105.Clean = value; _purchaseOrRefinanceDescription = v105;
                var v106 = _rdsfhRefinancedLoanIndicatorType; v106.Clean = value; _rdsfhRefinancedLoanIndicatorType = v106;
                var v107 = _refinanceLoanIndicator; v107.Clean = value; _refinanceLoanIndicator = v107;
                var v108 = _repairOtherAmount; v108.Clean = value; _repairOtherAmount = v108;
                var v109 = _repairOtherDescription; v109.Clean = value; _repairOtherDescription = v109;
                var v110 = _reservationAmountRequested; v110.Clean = value; _reservationAmountRequested = v110;
                var v111 = _reserved; v111.Clean = value; _reserved = v111;
                var v112 = _servicingOfficeName; v112.Clean = value; _servicingOfficeName = v112;
                var v113 = _sfhglpIndicator; v113.Clean = value; _sfhglpIndicator = v113;
                var v114 = _sourceOfFundsType; v114.Clean = value; _sourceOfFundsType = v114;
                var v115 = _stableDependableMonthlyIncome; v115.Clean = value; _stableDependableMonthlyIncome = v115;
                var v116 = _stableOtherIncomeDesc; v116.Clean = value; _stableOtherIncomeDesc = v116;
                var v117 = _submittingLenderAddress; v117.Clean = value; _submittingLenderAddress = v117;
                var v118 = _submittingLenderCity; v118.Clean = value; _submittingLenderCity = v118;
                var v119 = _submittingLenderContactFax; v119.Clean = value; _submittingLenderContactFax = v119;
                var v120 = _submittingLenderContactName; v120.Clean = value; _submittingLenderContactName = v120;
                var v121 = _submittingLenderContactPhone; v121.Clean = value; _submittingLenderContactPhone = v121;
                var v122 = _submittingLenderName; v122.Clean = value; _submittingLenderName = v122;
                var v123 = _submittingLenderState; v123.Clean = value; _submittingLenderState = v123;
                var v124 = _submittingLenderTaxId; v124.Clean = value; _submittingLenderTaxId = v124;
                var v125 = _submittingLenderZip; v125.Clean = value; _submittingLenderZip = v125;
                var v126 = _termOfBuydown; v126.Clean = value; _termOfBuydown = v126;
                var v127 = _thirdPartyOriginator; v127.Clean = value; _thirdPartyOriginator = v127;
                var v128 = _title; v128.Clean = value; _title = v128;
                var v129 = _totalBorrowerStableBaseIncome; v129.Clean = value; _totalBorrowerStableBaseIncome = v129;
                var v130 = _totalBorrowerStableOtherIncome; v130.Clean = value; _totalBorrowerStableOtherIncome = v130;
                var v131 = _totalHouseholdDeduction; v131.Clean = value; _totalHouseholdDeduction = v131;
                var v132 = _totalRequestAmount; v132.Clean = value; _totalRequestAmount = v132;
                var v133 = _tpoTaxId; v133.Clean = value; _tpoTaxId = v133;
                var v134 = _underwritingDecisionBy; v134.Clean = value; _underwritingDecisionBy = v134;
                var v135 = _underwritingDecisionDate; v135.Clean = value; _underwritingDecisionDate = v135;
                var v136 = _underwritingDecisionType; v136.Clean = value; _underwritingDecisionType = v136;
                var v137 = _usdaHouseholdIncomes; v137.Clean = value; _usdaHouseholdIncomes = v137;
                var v138 = _verificationCode; v138.Clean = value; _verificationCode = v138;
                _settingClean = 0;
            }
        }
    }
}