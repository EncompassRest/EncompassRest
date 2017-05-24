using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Miscellaneous
    {
        public Value<string> Address { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress() => !Address.Clean;
        public Value<string> BorrowerDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerDescription1() => !BorrowerDescription1.Clean;
        public Value<string> BorrowerDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerDescription2() => !BorrowerDescription2.Clean;
        public Value<string> BorrowerDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerDescription3() => !BorrowerDescription3.Clean;
        public Value<string> BorrowerDescription4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerDescription4() => !BorrowerDescription4.Clean;
        public Value<string> BorrowerDescription5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerDescription5() => !BorrowerDescription5.Clean;
        public Value<string> BorrowerDescription6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerDescription6() => !BorrowerDescription6.Clean;
        public Value<string> BorrowerDescription7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerDescription7() => !BorrowerDescription7.Clean;
        public Value<string> City { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !City.Clean;
        public Value<string> ClosingCostProgramFile { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostProgramFile() => !ClosingCostProgramFile.Clean;
        public Value<string> ClosingTaxYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingTaxYear() => !ClosingTaxYear.Clean;
        public Value<decimal?> ClosingTaxYearInterestReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingTaxYearInterestReceived() => !ClosingTaxYearInterestReceived.Clean;
        public Value<bool?> CopyFromSubjectProperty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCopyFromSubjectProperty() => !CopyFromSubjectProperty.Clean;
        public Value<string> DataTracLoanId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDataTracLoanId() => !DataTracLoanId.Clean;
        public Value<string> DocSetFile { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocSetFile() => !DocSetFile.Clean;
        public Value<int?> FactorForRevolvingDebt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFactorForRevolvingDebt() => !FactorForRevolvingDebt.Clean;
        public Value<bool?> FannieDuAutoOrderIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieDuAutoOrderIndicator() => !FannieDuAutoOrderIndicator.Clean;
        public Value<bool?> FannieEcAutoOrderIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFannieEcAutoOrderIndicator() => !FannieEcAutoOrderIndicator.Clean;
        public Value<string> FloodInsuranceExcluded { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodInsuranceExcluded() => !FloodInsuranceExcluded.Clean;
        public Value<string> FormListFile { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFormListFile() => !FormListFile.Clean;
        public Value<bool?> FreddieLPAAutoOrderIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieLPAAutoOrderIndicator() => !FreddieLPAAutoOrderIndicator.Clean;
        public Value<bool?> FreddieLQAAutoOrderIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieLQAAutoOrderIndicator() => !FreddieLQAAutoOrderIndicator.Clean;
        public Value<decimal?> HousingExpenseIntRate1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHousingExpenseIntRate1() => !HousingExpenseIntRate1.Clean;
        public Value<decimal?> HousingExpenseIntRate2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHousingExpenseIntRate2() => !HousingExpenseIntRate2.Clean;
        public Value<decimal?> HousingExpenseLoanAmt1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHousingExpenseLoanAmt1() => !HousingExpenseLoanAmt1.Clean;
        public Value<decimal?> HousingExpenseLoanAmt2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHousingExpenseLoanAmt2() => !HousingExpenseLoanAmt2.Clean;
        public Value<decimal?> HousingExpensePayment1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHousingExpensePayment1() => !HousingExpensePayment1.Clean;
        public Value<decimal?> HousingExpensePayment2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHousingExpensePayment2() => !HousingExpensePayment2.Clean;
        public Value<int?> HousingExpenseTerm1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHousingExpenseTerm1() => !HousingExpenseTerm1.Clean;
        public Value<int?> HousingExpenseTerm2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHousingExpenseTerm2() => !HousingExpenseTerm2.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IsSameAddresswithPayer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSameAddresswithPayer() => !IsSameAddresswithPayer.Clean;
        public Value<string> Line1006Excluded { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1006Excluded() => !Line1006Excluded.Clean;
        public Value<string> Line1007Excluded { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1007Excluded() => !Line1007Excluded.Clean;
        public Value<string> Line1008Excluded { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1008Excluded() => !Line1008Excluded.Clean;
        public Value<string> Line1010Excluded { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1010Excluded() => !Line1010Excluded.Clean;
        public Value<string> LoanProgramFile { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProgramFile() => !LoanProgramFile.Clean;
        public Value<string> LoanTemplateFile { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanTemplateFile() => !LoanTemplateFile.Clean;
        public Value<string> MaventATRQMResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventATRQMResult() => !MaventATRQMResult.Clean;
        public Value<bool?> MaventAutoOrderIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventAutoOrderIndicator() => !MaventAutoOrderIndicator.Clean;
        public Value<string> MaventCraxResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventCraxResult() => !MaventCraxResult.Clean;
        public Value<string> MaventEnterpriseResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventEnterpriseResult() => !MaventEnterpriseResult.Clean;
        public Value<string> MaventGseResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventGseResult() => !MaventGseResult.Clean;
        public Value<string> MaventHighCostResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventHighCostResult() => !MaventHighCostResult.Clean;
        public Value<string> MaventHmdaResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventHmdaResult() => !MaventHmdaResult.Clean;
        public Value<string> MaventHpmlResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventHpmlResult() => !MaventHpmlResult.Clean;
        public Value<string> MaventLicenseResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventLicenseResult() => !MaventLicenseResult.Clean;
        public Value<string> MaventNmlsResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventNmlsResult() => !MaventNmlsResult.Clean;
        public Value<string> MaventOfacResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventOfacResult() => !MaventOfacResult.Clean;
        public Value<string> MaventOrderedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventOrderedBy() => !MaventOrderedBy.Clean;
        public Value<DateTime?> MaventOrderedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventOrderedDate() => !MaventOrderedDate.Clean;
        public Value<string> MaventOtherResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventOtherResult() => !MaventOtherResult.Clean;
        public Value<string> MaventReviewResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventReviewResult() => !MaventReviewResult.Clean;
        public Value<string> MaventStateResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventStateResult() => !MaventStateResult.Clean;
        public Value<string> MaventTilaRorResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventTilaRorResult() => !MaventTilaRorResult.Clean;
        public Value<string> MaventTilaToleranceResult { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaventTilaToleranceResult() => !MaventTilaToleranceResult.Clean;
        public Value<decimal?> MIPremiums { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMIPremiums() => !MIPremiums.Clean;
        public Value<string> MiscDataFile { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiscDataFile() => !MiscDataFile.Clean;
        public Value<int?> MonthsToExclude { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthsToExclude() => !MonthsToExclude.Clean;
        public Value<string> OptimalBlueHistoryData { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOptimalBlueHistoryData() => !OptimalBlueHistoryData.Clean;
        public Value<string> OptimalBlueRequest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOptimalBlueRequest() => !OptimalBlueRequest.Clean;
        public Value<string> OptimalBlueResponse { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOptimalBlueResponse() => !OptimalBlueResponse.Clean;
        public Value<decimal?> OtherPresentHousingExpense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherPresentHousingExpense() => !OtherPresentHousingExpense.Clean;
        public Value<decimal?> OutstandingMtgPrincipal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOutstandingMtgPrincipal() => !OutstandingMtgPrincipal.Clean;
        public Value<DateTime?> OutstandingMtgPrincipalDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOutstandingMtgPrincipalDate() => !OutstandingMtgPrincipalDate.Clean;
        public Value<bool?> ParticipateHomePoints { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeParticipateHomePoints() => !ParticipateHomePoints.Clean;
        public Value<string> PartnerEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePartnerEmail() => !PartnerEmail.Clean;
        public Value<string> PartnerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePartnerName() => !PartnerName.Clean;
        public Value<string> PartnerPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePartnerPhone() => !PartnerPhone.Clean;
        public Value<decimal?> PointsPaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePointsPaid() => !PointsPaid.Clean;
        public Value<DateTime?> RateRegistrationExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateRegistrationExpirationDate() => !RateRegistrationExpirationDate.Clean;
        public Value<string> RateRegistrationInvestorName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateRegistrationInvestorName() => !RateRegistrationInvestorName.Clean;
        public Value<bool?> RateRegistrationLoanIsRegistered { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateRegistrationLoanIsRegistered() => !RateRegistrationLoanIsRegistered.Clean;
        public Value<string> RateRegistrationReference { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateRegistrationReference() => !RateRegistrationReference.Clean;
        public Value<string> RateRegistrationRegisteredBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateRegistrationRegisteredBy() => !RateRegistrationRegisteredBy.Clean;
        public Value<string> RateRegistrationRegisteredUserId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateRegistrationRegisteredUserId() => !RateRegistrationRegisteredUserId.Clean;
        public Value<DateTime?> RateRegistrationRegistrationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateRegistrationRegistrationDate() => !RateRegistrationRegistrationDate.Clean;
        public Value<decimal?> RefundOrOverpaidInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefundOrOverpaidInterest() => !RefundOrOverpaidInterest.Clean;
        public Value<string> SchoolTaxExcluded { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSchoolTaxExcluded() => !SchoolTaxExcluded.Clean;
        public Value<string> State { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !State.Clean;
        public Value<string> StatusUrl { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStatusUrl() => !StatusUrl.Clean;
        public Value<DateTime?> SubmitDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmitDate() => !SubmitDate.Clean;
        public Value<string> SubTaxYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubTaxYear() => !SubTaxYear.Clean;
        public Value<decimal?> SubTaxYearInterestReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubTaxYearInterestReceived() => !SubTaxYearInterestReceived.Clean;
        public Value<decimal?> SubTaxYearMIPremiums { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubTaxYearMIPremiums() => !SubTaxYearMIPremiums.Clean;
        public Value<decimal?> SubTaxYearPointsPaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubTaxYearPointsPaid() => !SubTaxYearPointsPaid.Clean;
        public Value<decimal?> SubTaxYearRefundOrOverpaidInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubTaxYearRefundOrOverpaidInterest() => !SubTaxYearRefundOrOverpaidInterest.Clean;
        public Value<string> TaxId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxId() => !TaxId.Clean;
        public Value<decimal?> TotalBox4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBox4() => !TotalBox4.Clean;
        public Value<decimal?> TotalYearlyMi { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalYearlyMi() => !TotalYearlyMi.Clean;
        public Value<string> UseGfeTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUseGfeTax() => !UseGfeTax.Clean;
        public Value<string> UseRegZMi { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUseRegZMi() => !UseRegZMi.Clean;
        public Value<string> Zip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeZip() => !Zip.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Address.Clean
                    && BorrowerDescription1.Clean
                    && BorrowerDescription2.Clean
                    && BorrowerDescription3.Clean
                    && BorrowerDescription4.Clean
                    && BorrowerDescription5.Clean
                    && BorrowerDescription6.Clean
                    && BorrowerDescription7.Clean
                    && City.Clean
                    && ClosingCostProgramFile.Clean
                    && ClosingTaxYear.Clean
                    && ClosingTaxYearInterestReceived.Clean
                    && CopyFromSubjectProperty.Clean
                    && DataTracLoanId.Clean
                    && DocSetFile.Clean
                    && FactorForRevolvingDebt.Clean
                    && FannieDuAutoOrderIndicator.Clean
                    && FannieEcAutoOrderIndicator.Clean
                    && FloodInsuranceExcluded.Clean
                    && FormListFile.Clean
                    && FreddieLPAAutoOrderIndicator.Clean
                    && FreddieLQAAutoOrderIndicator.Clean
                    && HousingExpenseIntRate1.Clean
                    && HousingExpenseIntRate2.Clean
                    && HousingExpenseLoanAmt1.Clean
                    && HousingExpenseLoanAmt2.Clean
                    && HousingExpensePayment1.Clean
                    && HousingExpensePayment2.Clean
                    && HousingExpenseTerm1.Clean
                    && HousingExpenseTerm2.Clean
                    && Id.Clean
                    && IsSameAddresswithPayer.Clean
                    && Line1006Excluded.Clean
                    && Line1007Excluded.Clean
                    && Line1008Excluded.Clean
                    && Line1010Excluded.Clean
                    && LoanProgramFile.Clean
                    && LoanTemplateFile.Clean
                    && MaventATRQMResult.Clean
                    && MaventAutoOrderIndicator.Clean
                    && MaventCraxResult.Clean
                    && MaventEnterpriseResult.Clean
                    && MaventGseResult.Clean
                    && MaventHighCostResult.Clean
                    && MaventHmdaResult.Clean
                    && MaventHpmlResult.Clean
                    && MaventLicenseResult.Clean
                    && MaventNmlsResult.Clean
                    && MaventOfacResult.Clean
                    && MaventOrderedBy.Clean
                    && MaventOrderedDate.Clean
                    && MaventOtherResult.Clean
                    && MaventReviewResult.Clean
                    && MaventStateResult.Clean
                    && MaventTilaRorResult.Clean
                    && MaventTilaToleranceResult.Clean
                    && MIPremiums.Clean
                    && MiscDataFile.Clean
                    && MonthsToExclude.Clean
                    && OptimalBlueHistoryData.Clean
                    && OptimalBlueRequest.Clean
                    && OptimalBlueResponse.Clean
                    && OtherPresentHousingExpense.Clean
                    && OutstandingMtgPrincipal.Clean
                    && OutstandingMtgPrincipalDate.Clean
                    && ParticipateHomePoints.Clean
                    && PartnerEmail.Clean
                    && PartnerName.Clean
                    && PartnerPhone.Clean
                    && PointsPaid.Clean
                    && RateRegistrationExpirationDate.Clean
                    && RateRegistrationInvestorName.Clean
                    && RateRegistrationLoanIsRegistered.Clean
                    && RateRegistrationReference.Clean
                    && RateRegistrationRegisteredBy.Clean
                    && RateRegistrationRegisteredUserId.Clean
                    && RateRegistrationRegistrationDate.Clean
                    && RefundOrOverpaidInterest.Clean
                    && SchoolTaxExcluded.Clean
                    && State.Clean
                    && StatusUrl.Clean
                    && SubmitDate.Clean
                    && SubTaxYear.Clean
                    && SubTaxYearInterestReceived.Clean
                    && SubTaxYearMIPremiums.Clean
                    && SubTaxYearPointsPaid.Clean
                    && SubTaxYearRefundOrOverpaidInterest.Clean
                    && TaxId.Clean
                    && TotalBox4.Clean
                    && TotalYearlyMi.Clean
                    && UseGfeTax.Clean
                    && UseRegZMi.Clean
                    && Zip.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Address; v0.Clean = value; Address = v0;
                var v1 = BorrowerDescription1; v1.Clean = value; BorrowerDescription1 = v1;
                var v2 = BorrowerDescription2; v2.Clean = value; BorrowerDescription2 = v2;
                var v3 = BorrowerDescription3; v3.Clean = value; BorrowerDescription3 = v3;
                var v4 = BorrowerDescription4; v4.Clean = value; BorrowerDescription4 = v4;
                var v5 = BorrowerDescription5; v5.Clean = value; BorrowerDescription5 = v5;
                var v6 = BorrowerDescription6; v6.Clean = value; BorrowerDescription6 = v6;
                var v7 = BorrowerDescription7; v7.Clean = value; BorrowerDescription7 = v7;
                var v8 = City; v8.Clean = value; City = v8;
                var v9 = ClosingCostProgramFile; v9.Clean = value; ClosingCostProgramFile = v9;
                var v10 = ClosingTaxYear; v10.Clean = value; ClosingTaxYear = v10;
                var v11 = ClosingTaxYearInterestReceived; v11.Clean = value; ClosingTaxYearInterestReceived = v11;
                var v12 = CopyFromSubjectProperty; v12.Clean = value; CopyFromSubjectProperty = v12;
                var v13 = DataTracLoanId; v13.Clean = value; DataTracLoanId = v13;
                var v14 = DocSetFile; v14.Clean = value; DocSetFile = v14;
                var v15 = FactorForRevolvingDebt; v15.Clean = value; FactorForRevolvingDebt = v15;
                var v16 = FannieDuAutoOrderIndicator; v16.Clean = value; FannieDuAutoOrderIndicator = v16;
                var v17 = FannieEcAutoOrderIndicator; v17.Clean = value; FannieEcAutoOrderIndicator = v17;
                var v18 = FloodInsuranceExcluded; v18.Clean = value; FloodInsuranceExcluded = v18;
                var v19 = FormListFile; v19.Clean = value; FormListFile = v19;
                var v20 = FreddieLPAAutoOrderIndicator; v20.Clean = value; FreddieLPAAutoOrderIndicator = v20;
                var v21 = FreddieLQAAutoOrderIndicator; v21.Clean = value; FreddieLQAAutoOrderIndicator = v21;
                var v22 = HousingExpenseIntRate1; v22.Clean = value; HousingExpenseIntRate1 = v22;
                var v23 = HousingExpenseIntRate2; v23.Clean = value; HousingExpenseIntRate2 = v23;
                var v24 = HousingExpenseLoanAmt1; v24.Clean = value; HousingExpenseLoanAmt1 = v24;
                var v25 = HousingExpenseLoanAmt2; v25.Clean = value; HousingExpenseLoanAmt2 = v25;
                var v26 = HousingExpensePayment1; v26.Clean = value; HousingExpensePayment1 = v26;
                var v27 = HousingExpensePayment2; v27.Clean = value; HousingExpensePayment2 = v27;
                var v28 = HousingExpenseTerm1; v28.Clean = value; HousingExpenseTerm1 = v28;
                var v29 = HousingExpenseTerm2; v29.Clean = value; HousingExpenseTerm2 = v29;
                var v30 = Id; v30.Clean = value; Id = v30;
                var v31 = IsSameAddresswithPayer; v31.Clean = value; IsSameAddresswithPayer = v31;
                var v32 = Line1006Excluded; v32.Clean = value; Line1006Excluded = v32;
                var v33 = Line1007Excluded; v33.Clean = value; Line1007Excluded = v33;
                var v34 = Line1008Excluded; v34.Clean = value; Line1008Excluded = v34;
                var v35 = Line1010Excluded; v35.Clean = value; Line1010Excluded = v35;
                var v36 = LoanProgramFile; v36.Clean = value; LoanProgramFile = v36;
                var v37 = LoanTemplateFile; v37.Clean = value; LoanTemplateFile = v37;
                var v38 = MaventATRQMResult; v38.Clean = value; MaventATRQMResult = v38;
                var v39 = MaventAutoOrderIndicator; v39.Clean = value; MaventAutoOrderIndicator = v39;
                var v40 = MaventCraxResult; v40.Clean = value; MaventCraxResult = v40;
                var v41 = MaventEnterpriseResult; v41.Clean = value; MaventEnterpriseResult = v41;
                var v42 = MaventGseResult; v42.Clean = value; MaventGseResult = v42;
                var v43 = MaventHighCostResult; v43.Clean = value; MaventHighCostResult = v43;
                var v44 = MaventHmdaResult; v44.Clean = value; MaventHmdaResult = v44;
                var v45 = MaventHpmlResult; v45.Clean = value; MaventHpmlResult = v45;
                var v46 = MaventLicenseResult; v46.Clean = value; MaventLicenseResult = v46;
                var v47 = MaventNmlsResult; v47.Clean = value; MaventNmlsResult = v47;
                var v48 = MaventOfacResult; v48.Clean = value; MaventOfacResult = v48;
                var v49 = MaventOrderedBy; v49.Clean = value; MaventOrderedBy = v49;
                var v50 = MaventOrderedDate; v50.Clean = value; MaventOrderedDate = v50;
                var v51 = MaventOtherResult; v51.Clean = value; MaventOtherResult = v51;
                var v52 = MaventReviewResult; v52.Clean = value; MaventReviewResult = v52;
                var v53 = MaventStateResult; v53.Clean = value; MaventStateResult = v53;
                var v54 = MaventTilaRorResult; v54.Clean = value; MaventTilaRorResult = v54;
                var v55 = MaventTilaToleranceResult; v55.Clean = value; MaventTilaToleranceResult = v55;
                var v56 = MIPremiums; v56.Clean = value; MIPremiums = v56;
                var v57 = MiscDataFile; v57.Clean = value; MiscDataFile = v57;
                var v58 = MonthsToExclude; v58.Clean = value; MonthsToExclude = v58;
                var v59 = OptimalBlueHistoryData; v59.Clean = value; OptimalBlueHistoryData = v59;
                var v60 = OptimalBlueRequest; v60.Clean = value; OptimalBlueRequest = v60;
                var v61 = OptimalBlueResponse; v61.Clean = value; OptimalBlueResponse = v61;
                var v62 = OtherPresentHousingExpense; v62.Clean = value; OtherPresentHousingExpense = v62;
                var v63 = OutstandingMtgPrincipal; v63.Clean = value; OutstandingMtgPrincipal = v63;
                var v64 = OutstandingMtgPrincipalDate; v64.Clean = value; OutstandingMtgPrincipalDate = v64;
                var v65 = ParticipateHomePoints; v65.Clean = value; ParticipateHomePoints = v65;
                var v66 = PartnerEmail; v66.Clean = value; PartnerEmail = v66;
                var v67 = PartnerName; v67.Clean = value; PartnerName = v67;
                var v68 = PartnerPhone; v68.Clean = value; PartnerPhone = v68;
                var v69 = PointsPaid; v69.Clean = value; PointsPaid = v69;
                var v70 = RateRegistrationExpirationDate; v70.Clean = value; RateRegistrationExpirationDate = v70;
                var v71 = RateRegistrationInvestorName; v71.Clean = value; RateRegistrationInvestorName = v71;
                var v72 = RateRegistrationLoanIsRegistered; v72.Clean = value; RateRegistrationLoanIsRegistered = v72;
                var v73 = RateRegistrationReference; v73.Clean = value; RateRegistrationReference = v73;
                var v74 = RateRegistrationRegisteredBy; v74.Clean = value; RateRegistrationRegisteredBy = v74;
                var v75 = RateRegistrationRegisteredUserId; v75.Clean = value; RateRegistrationRegisteredUserId = v75;
                var v76 = RateRegistrationRegistrationDate; v76.Clean = value; RateRegistrationRegistrationDate = v76;
                var v77 = RefundOrOverpaidInterest; v77.Clean = value; RefundOrOverpaidInterest = v77;
                var v78 = SchoolTaxExcluded; v78.Clean = value; SchoolTaxExcluded = v78;
                var v79 = State; v79.Clean = value; State = v79;
                var v80 = StatusUrl; v80.Clean = value; StatusUrl = v80;
                var v81 = SubmitDate; v81.Clean = value; SubmitDate = v81;
                var v82 = SubTaxYear; v82.Clean = value; SubTaxYear = v82;
                var v83 = SubTaxYearInterestReceived; v83.Clean = value; SubTaxYearInterestReceived = v83;
                var v84 = SubTaxYearMIPremiums; v84.Clean = value; SubTaxYearMIPremiums = v84;
                var v85 = SubTaxYearPointsPaid; v85.Clean = value; SubTaxYearPointsPaid = v85;
                var v86 = SubTaxYearRefundOrOverpaidInterest; v86.Clean = value; SubTaxYearRefundOrOverpaidInterest = v86;
                var v87 = TaxId; v87.Clean = value; TaxId = v87;
                var v88 = TotalBox4; v88.Clean = value; TotalBox4 = v88;
                var v89 = TotalYearlyMi; v89.Clean = value; TotalYearlyMi = v89;
                var v90 = UseGfeTax; v90.Clean = value; UseGfeTax = v90;
                var v91 = UseRegZMi; v91.Clean = value; UseRegZMi = v91;
                var v92 = Zip; v92.Clean = value; Zip = v92;
                _settingClean = 0;
            }
        }
    }
}