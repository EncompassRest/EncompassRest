using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Section32
    {
        public Value<bool?> AppraisalFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalFeeToBeFinancedIndicator() => !AppraisalFeeToBeFinancedIndicator.Clean;
        public Value<bool?> AppraisalPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalPortionOfFeeIndicator() => !AppraisalPortionOfFeeIndicator.Clean;
        public Value<decimal?> AprExceedsTsyForFirstMortgage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAprExceedsTsyForFirstMortgage() => !AprExceedsTsyForFirstMortgage.Clean;
        public Value<decimal?> AprExceedsTsyForSubordinateMortgage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAprExceedsTsyForSubordinateMortgage() => !AprExceedsTsyForSubordinateMortgage.Clean;
        public Value<bool?> AssumptionFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssumptionFeeToBeFinancedIndicator() => !AssumptionFeeToBeFinancedIndicator.Clean;
        public Value<bool?> AssumptionPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssumptionPortionOfFeeIndicator() => !AssumptionPortionOfFeeIndicator.Clean;
        public Value<bool?> AttorneyFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAttorneyFeeToBeFinancedIndicator() => !AttorneyFeeToBeFinancedIndicator.Clean;
        public Value<bool?> AttorneyPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAttorneyPortionOfFeeIndicator() => !AttorneyPortionOfFeeIndicator.Clean;
        public Value<bool?> CityCountyTaxStampsFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityCountyTaxStampsFeeToBeFinancedIndicator() => !CityCountyTaxStampsFeeToBeFinancedIndicator.Clean;
        public Value<bool?> CityCountyTaxStampsPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityCountyTaxStampsPortionOfFeeIndicator() => !CityCountyTaxStampsPortionOfFeeIndicator.Clean;
        public Value<bool?> ClosingFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingFeeToBeFinancedIndicator() => !ClosingFeeToBeFinancedIndicator.Clean;
        public Value<bool?> ClosingPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingPortionOfFeeIndicator() => !ClosingPortionOfFeeIndicator.Clean;
        public Value<bool?> CreditReportFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditReportFeeToBeFinancedIndicator() => !CreditReportFeeToBeFinancedIndicator.Clean;
        public Value<bool?> CreditReportPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditReportPortionOfFeeIndicator() => !CreditReportPortionOfFeeIndicator.Clean;
        public Value<bool?> DocPrepFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocPrepFeeToBeFinancedIndicator() => !DocPrepFeeToBeFinancedIndicator.Clean;
        public Value<bool?> DocPrepPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocPrepPortionOfFeeIndicator() => !DocPrepPortionOfFeeIndicator.Clean;
        public Value<string> Exceed2PercentPrepayPenalty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExceed2PercentPrepayPenalty() => !Exceed2PercentPrepayPenalty.Clean;
        public Value<decimal?> HoepaAPR { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHoepaAPR() => !HoepaAPR.Clean;
        public Value<decimal?> HoepaFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHoepaFee() => !HoepaFee.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> Jurisdications { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeJurisdications() => !Jurisdications.Clean;
        public Value<bool?> LendersInspectionFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLendersInspectionFeeToBeFinancedIndicator() => !LendersInspectionFeeToBeFinancedIndicator.Clean;
        public Value<bool?> LendersInspectionPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLendersInspectionPortionOfFeeIndicator() => !LendersInspectionPortionOfFeeIndicator.Clean;
        public Value<bool?> LoanDiscountFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanDiscountFeeToBeFinancedIndicator() => !LoanDiscountFeeToBeFinancedIndicator.Clean;
        public Value<bool?> LoanDiscountPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanDiscountPortionOfFeeIndicator() => !LoanDiscountPortionOfFeeIndicator.Clean;
        public Value<bool?> LoanOriginationFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanOriginationFeeToBeFinancedIndicator() => !LoanOriginationFeeToBeFinancedIndicator.Clean;
        public Value<bool?> LoanOriginationPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanOriginationPortionOfFeeIndicator() => !LoanOriginationPortionOfFeeIndicator.Clean;
        public Value<string> LoanQualifyAsHighCostMortgage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanQualifyAsHighCostMortgage() => !LoanQualifyAsHighCostMortgage.Clean;
        public Value<decimal?> MaximumPercentageOfLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumPercentageOfLoan() => !MaximumPercentageOfLoan.Clean;
        public Value<decimal?> MaximumPointsAndFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumPointsAndFees() => !MaximumPointsAndFees.Clean;
        public Value<bool?> MortgageBrokerFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerFeeToBeFinancedIndicator() => !MortgageBrokerFeeToBeFinancedIndicator.Clean;
        public Value<bool?> MortgageBrokerPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerPortionOfFeeIndicator() => !MortgageBrokerPortionOfFeeIndicator.Clean;
        public Value<bool?> MortgageInspectionFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInspectionFeeToBeFinancedIndicator() => !MortgageInspectionFeeToBeFinancedIndicator.Clean;
        public Value<bool?> MortgageInspectionPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInspectionPortionOfFeeIndicator() => !MortgageInspectionPortionOfFeeIndicator.Clean;
        public Value<bool?> MortgageInsuranceFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsuranceFeeToBeFinancedIndicator() => !MortgageInsuranceFeeToBeFinancedIndicator.Clean;
        public Value<bool?> MortgageInsurancePortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsurancePortionOfFeeIndicator() => !MortgageInsurancePortionOfFeeIndicator.Clean;
        public Value<bool?> MortgageInsurancePremiumFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsurancePremiumFeeToBeFinancedIndicator() => !MortgageInsurancePremiumFeeToBeFinancedIndicator.Clean;
        public Value<bool?> MortgageInsurancePremiumPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsurancePremiumPortionOfFeeIndicator() => !MortgageInsurancePremiumPortionOfFeeIndicator.Clean;
        public Value<bool?> NotaryFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotaryFeeToBeFinancedIndicator() => !NotaryFeeToBeFinancedIndicator.Clean;
        public Value<bool?> NotaryPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotaryPortionOfFeeIndicator() => !NotaryPortionOfFeeIndicator.Clean;
        public Value<bool?> OtherHighCostIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherHighCostIndicator() => !OtherHighCostIndicator.Clean;
        public Value<string> PenaltyChargeMoreThan36Months { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePenaltyChargeMoreThan36Months() => !PenaltyChargeMoreThan36Months.Clean;
        public Value<bool?> PestInspectionFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePestInspectionFeeToBeFinancedIndicator() => !PestInspectionFeeToBeFinancedIndicator.Clean;
        public Value<bool?> PestInspectionPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePestInspectionPortionOfFeeIndicator() => !PestInspectionPortionOfFeeIndicator.Clean;
        public Value<decimal?> PrepayPenaltyPercentofAmtPrepaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepayPenaltyPercentofAmtPrepaid() => !PrepayPenaltyPercentofAmtPrepaid.Clean;
        public Value<bool?> ProcessingFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProcessingFeeToBeFinancedIndicator() => !ProcessingFeeToBeFinancedIndicator.Clean;
        public Value<bool?> ProcessingPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProcessingPortionOfFeeIndicator() => !ProcessingPortionOfFeeIndicator.Clean;
        public Value<decimal?> RateSetIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateSetIndex() => !RateSetIndex.Clean;
        public Value<bool?> RecordingFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecordingFeeToBeFinancedIndicator() => !RecordingFeeToBeFinancedIndicator.Clean;
        public Value<bool?> RecordingPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecordingPortionOfFeeIndicator() => !RecordingPortionOfFeeIndicator.Clean;
        public Value<string> ResultOfPointAndFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeResultOfPointAndFees() => !ResultOfPointAndFees.Clean;
        public Value<string> ResultOfSecurityYieldTest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeResultOfSecurityYieldTest() => !ResultOfSecurityYieldTest.Clean;
        public Value<bool?> Section32Indicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection32Indicator() => !Section32Indicator.Clean;
        public Value<decimal?> Section35AveragePrimeRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection35AveragePrimeRate() => !Section35AveragePrimeRate.Clean;
        public Value<string> Section35IsSecondAppraisalRequired { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection35IsSecondAppraisalRequired() => !Section35IsSecondAppraisalRequired.Clean;
        public Value<DateTime?> Section35PriorAcquisitionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection35PriorAcquisitionDate() => !Section35PriorAcquisitionDate.Clean;
        public Value<decimal?> Section35PriorAcquisitionPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection35PriorAcquisitionPrice() => !Section35PriorAcquisitionPrice.Clean;
        public Value<string> Section35PriorAcquisitionSource { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection35PriorAcquisitionSource() => !Section35PriorAcquisitionSource.Clean;
        public Value<string> Section35ResultOfSecurityYieldTest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection35ResultOfSecurityYieldTest() => !Section35ResultOfSecurityYieldTest.Clean;
        public Value<DateTime?> Section35SalesContractDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection35SalesContractDate() => !Section35SalesContractDate.Clean;
        public Value<bool?> StateTaxStampsFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStateTaxStampsFeeToBeFinancedIndicator() => !StateTaxStampsFeeToBeFinancedIndicator.Clean;
        public Value<bool?> StateTaxStampsPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStateTaxStampsPortionOfFeeIndicator() => !StateTaxStampsPortionOfFeeIndicator.Clean;
        public Value<bool?> SurveyFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSurveyFeeToBeFinancedIndicator() => !SurveyFeeToBeFinancedIndicator.Clean;
        public Value<bool?> SurveyPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSurveyPortionOfFeeIndicator() => !SurveyPortionOfFeeIndicator.Clean;
        public Value<bool?> TaxServiceFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxServiceFeeToBeFinancedIndicator() => !TaxServiceFeeToBeFinancedIndicator.Clean;
        public Value<bool?> TaxServicePortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxServicePortionOfFeeIndicator() => !TaxServicePortionOfFeeIndicator.Clean;
        public Value<bool?> TitleBinderFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleBinderFeeToBeFinancedIndicator() => !TitleBinderFeeToBeFinancedIndicator.Clean;
        public Value<bool?> TitleBinderPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleBinderPortionOfFeeIndicator() => !TitleBinderPortionOfFeeIndicator.Clean;
        public Value<bool?> TitleExaminationFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleExaminationFeeToBeFinancedIndicator() => !TitleExaminationFeeToBeFinancedIndicator.Clean;
        public Value<bool?> TitleExaminationPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleExaminationPortionOfFeeIndicator() => !TitleExaminationPortionOfFeeIndicator.Clean;
        public Value<bool?> TitleInsuranceFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleInsuranceFeeToBeFinancedIndicator() => !TitleInsuranceFeeToBeFinancedIndicator.Clean;
        public Value<bool?> TitleInsurancePortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleInsurancePortionOfFeeIndicator() => !TitleInsurancePortionOfFeeIndicator.Clean;
        public Value<bool?> TitleSearchFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleSearchFeeToBeFinancedIndicator() => !TitleSearchFeeToBeFinancedIndicator.Clean;
        public Value<bool?> TitleSearchPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleSearchPortionOfFeeIndicator() => !TitleSearchPortionOfFeeIndicator.Clean;
        public Value<decimal?> TotalPointsAndFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPointsAndFees() => !TotalPointsAndFees.Clean;
        public Value<decimal?> TreasurySecurityYield { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTreasurySecurityYield() => !TreasurySecurityYield.Clean;
        public Value<bool?> UnderwritingFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingFeeToBeFinancedIndicator() => !UnderwritingFeeToBeFinancedIndicator.Clean;
        public Value<bool?> UnderwritingPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingPortionOfFeeIndicator() => !UnderwritingPortionOfFeeIndicator.Clean;
        public Value<decimal?> UserDefined1109BorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1109BorPaidAmount() => !UserDefined1109BorPaidAmount.Clean;
        public Value<bool?> UserDefined1109FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1109FeeToBeFinancedIndicator() => !UserDefined1109FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1109PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1109PortionOfFeeIndicator() => !UserDefined1109PortionOfFeeIndicator.Clean;
        public Value<decimal?> UserDefined1110BorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1110BorPaidAmount() => !UserDefined1110BorPaidAmount.Clean;
        public Value<bool?> UserDefined1110FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1110FeeToBeFinancedIndicator() => !UserDefined1110FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1110PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1110PortionOfFeeIndicator() => !UserDefined1110PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined1111FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1111FeeToBeFinancedIndicator() => !UserDefined1111FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1111PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1111PortionOfFeeIndicator() => !UserDefined1111PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined1112FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1112FeeToBeFinancedIndicator() => !UserDefined1112FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1112PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1112PortionOfFeeIndicator() => !UserDefined1112PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined1113FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1113FeeToBeFinancedIndicator() => !UserDefined1113FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1113PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1113PortionOfFeeIndicator() => !UserDefined1113PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined1114FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1114FeeToBeFinancedIndicator() => !UserDefined1114FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1114PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1114PortionOfFeeIndicator() => !UserDefined1114PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined1204FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1204FeeToBeFinancedIndicator() => !UserDefined1204FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1204PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1204PortionOfFeeIndicator() => !UserDefined1204PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined1205FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1205FeeToBeFinancedIndicator() => !UserDefined1205FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1205PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1205PortionOfFeeIndicator() => !UserDefined1205PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined1206FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1206FeeToBeFinancedIndicator() => !UserDefined1206FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1206PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1206PortionOfFeeIndicator() => !UserDefined1206PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined1303FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1303FeeToBeFinancedIndicator() => !UserDefined1303FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1303PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1303PortionOfFeeIndicator() => !UserDefined1303PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined1304FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1304FeeToBeFinancedIndicator() => !UserDefined1304FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1304PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1304PortionOfFeeIndicator() => !UserDefined1304PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined1305FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1305FeeToBeFinancedIndicator() => !UserDefined1305FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1305PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1305PortionOfFeeIndicator() => !UserDefined1305PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined1306FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1306FeeToBeFinancedIndicator() => !UserDefined1306FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1306PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1306PortionOfFeeIndicator() => !UserDefined1306PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined1307FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1307FeeToBeFinancedIndicator() => !UserDefined1307FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1307PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1307PortionOfFeeIndicator() => !UserDefined1307PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined1308FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1308FeeToBeFinancedIndicator() => !UserDefined1308FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1308PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1308PortionOfFeeIndicator() => !UserDefined1308PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined1309FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1309FeeToBeFinancedIndicator() => !UserDefined1309FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined1309PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1309PortionOfFeeIndicator() => !UserDefined1309PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined813FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined813FeeToBeFinancedIndicator() => !UserDefined813FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined813PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined813PortionOfFeeIndicator() => !UserDefined813PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined814FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined814FeeToBeFinancedIndicator() => !UserDefined814FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined814PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined814PortionOfFeeIndicator() => !UserDefined814PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined815FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined815FeeToBeFinancedIndicator() => !UserDefined815FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined815PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined815PortionOfFeeIndicator() => !UserDefined815PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined816FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined816FeeToBeFinancedIndicator() => !UserDefined816FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined816PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined816PortionOfFeeIndicator() => !UserDefined816PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined817FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined817FeeToBeFinancedIndicator() => !UserDefined817FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined817PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined817PortionOfFeeIndicator() => !UserDefined817PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined818FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined818FeeToBeFinancedIndicator() => !UserDefined818FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined818PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined818PortionOfFeeIndicator() => !UserDefined818PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined819FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined819FeeToBeFinancedIndicator() => !UserDefined819FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined819PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined819PortionOfFeeIndicator() => !UserDefined819PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined820FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined820FeeToBeFinancedIndicator() => !UserDefined820FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined820PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined820PortionOfFeeIndicator() => !UserDefined820PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined821FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined821FeeToBeFinancedIndicator() => !UserDefined821FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined821PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined821PortionOfFeeIndicator() => !UserDefined821PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined822FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined822FeeToBeFinancedIndicator() => !UserDefined822FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined822PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined822PortionOfFeeIndicator() => !UserDefined822PortionOfFeeIndicator.Clean;
        public Value<bool?> UserDefined823FeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined823FeeToBeFinancedIndicator() => !UserDefined823FeeToBeFinancedIndicator.Clean;
        public Value<bool?> UserDefined823PortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined823PortionOfFeeIndicator() => !UserDefined823PortionOfFeeIndicator.Clean;
        public Value<bool?> WireTransferFeeToBeFinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWireTransferFeeToBeFinancedIndicator() => !WireTransferFeeToBeFinancedIndicator.Clean;
        public Value<bool?> WireTransferPortionOfFeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWireTransferPortionOfFeeIndicator() => !WireTransferPortionOfFeeIndicator.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AppraisalFeeToBeFinancedIndicator.Clean
                    && AppraisalPortionOfFeeIndicator.Clean
                    && AprExceedsTsyForFirstMortgage.Clean
                    && AprExceedsTsyForSubordinateMortgage.Clean
                    && AssumptionFeeToBeFinancedIndicator.Clean
                    && AssumptionPortionOfFeeIndicator.Clean
                    && AttorneyFeeToBeFinancedIndicator.Clean
                    && AttorneyPortionOfFeeIndicator.Clean
                    && CityCountyTaxStampsFeeToBeFinancedIndicator.Clean
                    && CityCountyTaxStampsPortionOfFeeIndicator.Clean
                    && ClosingFeeToBeFinancedIndicator.Clean
                    && ClosingPortionOfFeeIndicator.Clean
                    && CreditReportFeeToBeFinancedIndicator.Clean
                    && CreditReportPortionOfFeeIndicator.Clean
                    && DocPrepFeeToBeFinancedIndicator.Clean
                    && DocPrepPortionOfFeeIndicator.Clean
                    && Exceed2PercentPrepayPenalty.Clean
                    && HoepaAPR.Clean
                    && HoepaFee.Clean
                    && Id.Clean
                    && Jurisdications.Clean
                    && LendersInspectionFeeToBeFinancedIndicator.Clean
                    && LendersInspectionPortionOfFeeIndicator.Clean
                    && LoanDiscountFeeToBeFinancedIndicator.Clean
                    && LoanDiscountPortionOfFeeIndicator.Clean
                    && LoanOriginationFeeToBeFinancedIndicator.Clean
                    && LoanOriginationPortionOfFeeIndicator.Clean
                    && LoanQualifyAsHighCostMortgage.Clean
                    && MaximumPercentageOfLoan.Clean
                    && MaximumPointsAndFees.Clean
                    && MortgageBrokerFeeToBeFinancedIndicator.Clean
                    && MortgageBrokerPortionOfFeeIndicator.Clean
                    && MortgageInspectionFeeToBeFinancedIndicator.Clean
                    && MortgageInspectionPortionOfFeeIndicator.Clean
                    && MortgageInsuranceFeeToBeFinancedIndicator.Clean
                    && MortgageInsurancePortionOfFeeIndicator.Clean
                    && MortgageInsurancePremiumFeeToBeFinancedIndicator.Clean
                    && MortgageInsurancePremiumPortionOfFeeIndicator.Clean
                    && NotaryFeeToBeFinancedIndicator.Clean
                    && NotaryPortionOfFeeIndicator.Clean
                    && OtherHighCostIndicator.Clean
                    && PenaltyChargeMoreThan36Months.Clean
                    && PestInspectionFeeToBeFinancedIndicator.Clean
                    && PestInspectionPortionOfFeeIndicator.Clean
                    && PrepayPenaltyPercentofAmtPrepaid.Clean
                    && ProcessingFeeToBeFinancedIndicator.Clean
                    && ProcessingPortionOfFeeIndicator.Clean
                    && RateSetIndex.Clean
                    && RecordingFeeToBeFinancedIndicator.Clean
                    && RecordingPortionOfFeeIndicator.Clean
                    && ResultOfPointAndFees.Clean
                    && ResultOfSecurityYieldTest.Clean
                    && Section32Indicator.Clean
                    && Section35AveragePrimeRate.Clean
                    && Section35IsSecondAppraisalRequired.Clean
                    && Section35PriorAcquisitionDate.Clean
                    && Section35PriorAcquisitionPrice.Clean
                    && Section35PriorAcquisitionSource.Clean
                    && Section35ResultOfSecurityYieldTest.Clean
                    && Section35SalesContractDate.Clean
                    && StateTaxStampsFeeToBeFinancedIndicator.Clean
                    && StateTaxStampsPortionOfFeeIndicator.Clean
                    && SurveyFeeToBeFinancedIndicator.Clean
                    && SurveyPortionOfFeeIndicator.Clean
                    && TaxServiceFeeToBeFinancedIndicator.Clean
                    && TaxServicePortionOfFeeIndicator.Clean
                    && TitleBinderFeeToBeFinancedIndicator.Clean
                    && TitleBinderPortionOfFeeIndicator.Clean
                    && TitleExaminationFeeToBeFinancedIndicator.Clean
                    && TitleExaminationPortionOfFeeIndicator.Clean
                    && TitleInsuranceFeeToBeFinancedIndicator.Clean
                    && TitleInsurancePortionOfFeeIndicator.Clean
                    && TitleSearchFeeToBeFinancedIndicator.Clean
                    && TitleSearchPortionOfFeeIndicator.Clean
                    && TotalPointsAndFees.Clean
                    && TreasurySecurityYield.Clean
                    && UnderwritingFeeToBeFinancedIndicator.Clean
                    && UnderwritingPortionOfFeeIndicator.Clean
                    && UserDefined1109BorPaidAmount.Clean
                    && UserDefined1109FeeToBeFinancedIndicator.Clean
                    && UserDefined1109PortionOfFeeIndicator.Clean
                    && UserDefined1110BorPaidAmount.Clean
                    && UserDefined1110FeeToBeFinancedIndicator.Clean
                    && UserDefined1110PortionOfFeeIndicator.Clean
                    && UserDefined1111FeeToBeFinancedIndicator.Clean
                    && UserDefined1111PortionOfFeeIndicator.Clean
                    && UserDefined1112FeeToBeFinancedIndicator.Clean
                    && UserDefined1112PortionOfFeeIndicator.Clean
                    && UserDefined1113FeeToBeFinancedIndicator.Clean
                    && UserDefined1113PortionOfFeeIndicator.Clean
                    && UserDefined1114FeeToBeFinancedIndicator.Clean
                    && UserDefined1114PortionOfFeeIndicator.Clean
                    && UserDefined1204FeeToBeFinancedIndicator.Clean
                    && UserDefined1204PortionOfFeeIndicator.Clean
                    && UserDefined1205FeeToBeFinancedIndicator.Clean
                    && UserDefined1205PortionOfFeeIndicator.Clean
                    && UserDefined1206FeeToBeFinancedIndicator.Clean
                    && UserDefined1206PortionOfFeeIndicator.Clean
                    && UserDefined1303FeeToBeFinancedIndicator.Clean
                    && UserDefined1303PortionOfFeeIndicator.Clean
                    && UserDefined1304FeeToBeFinancedIndicator.Clean
                    && UserDefined1304PortionOfFeeIndicator.Clean
                    && UserDefined1305FeeToBeFinancedIndicator.Clean
                    && UserDefined1305PortionOfFeeIndicator.Clean
                    && UserDefined1306FeeToBeFinancedIndicator.Clean
                    && UserDefined1306PortionOfFeeIndicator.Clean
                    && UserDefined1307FeeToBeFinancedIndicator.Clean
                    && UserDefined1307PortionOfFeeIndicator.Clean
                    && UserDefined1308FeeToBeFinancedIndicator.Clean
                    && UserDefined1308PortionOfFeeIndicator.Clean
                    && UserDefined1309FeeToBeFinancedIndicator.Clean
                    && UserDefined1309PortionOfFeeIndicator.Clean
                    && UserDefined813FeeToBeFinancedIndicator.Clean
                    && UserDefined813PortionOfFeeIndicator.Clean
                    && UserDefined814FeeToBeFinancedIndicator.Clean
                    && UserDefined814PortionOfFeeIndicator.Clean
                    && UserDefined815FeeToBeFinancedIndicator.Clean
                    && UserDefined815PortionOfFeeIndicator.Clean
                    && UserDefined816FeeToBeFinancedIndicator.Clean
                    && UserDefined816PortionOfFeeIndicator.Clean
                    && UserDefined817FeeToBeFinancedIndicator.Clean
                    && UserDefined817PortionOfFeeIndicator.Clean
                    && UserDefined818FeeToBeFinancedIndicator.Clean
                    && UserDefined818PortionOfFeeIndicator.Clean
                    && UserDefined819FeeToBeFinancedIndicator.Clean
                    && UserDefined819PortionOfFeeIndicator.Clean
                    && UserDefined820FeeToBeFinancedIndicator.Clean
                    && UserDefined820PortionOfFeeIndicator.Clean
                    && UserDefined821FeeToBeFinancedIndicator.Clean
                    && UserDefined821PortionOfFeeIndicator.Clean
                    && UserDefined822FeeToBeFinancedIndicator.Clean
                    && UserDefined822PortionOfFeeIndicator.Clean
                    && UserDefined823FeeToBeFinancedIndicator.Clean
                    && UserDefined823PortionOfFeeIndicator.Clean
                    && WireTransferFeeToBeFinancedIndicator.Clean
                    && WireTransferPortionOfFeeIndicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AppraisalFeeToBeFinancedIndicator; v0.Clean = value; AppraisalFeeToBeFinancedIndicator = v0;
                var v1 = AppraisalPortionOfFeeIndicator; v1.Clean = value; AppraisalPortionOfFeeIndicator = v1;
                var v2 = AprExceedsTsyForFirstMortgage; v2.Clean = value; AprExceedsTsyForFirstMortgage = v2;
                var v3 = AprExceedsTsyForSubordinateMortgage; v3.Clean = value; AprExceedsTsyForSubordinateMortgage = v3;
                var v4 = AssumptionFeeToBeFinancedIndicator; v4.Clean = value; AssumptionFeeToBeFinancedIndicator = v4;
                var v5 = AssumptionPortionOfFeeIndicator; v5.Clean = value; AssumptionPortionOfFeeIndicator = v5;
                var v6 = AttorneyFeeToBeFinancedIndicator; v6.Clean = value; AttorneyFeeToBeFinancedIndicator = v6;
                var v7 = AttorneyPortionOfFeeIndicator; v7.Clean = value; AttorneyPortionOfFeeIndicator = v7;
                var v8 = CityCountyTaxStampsFeeToBeFinancedIndicator; v8.Clean = value; CityCountyTaxStampsFeeToBeFinancedIndicator = v8;
                var v9 = CityCountyTaxStampsPortionOfFeeIndicator; v9.Clean = value; CityCountyTaxStampsPortionOfFeeIndicator = v9;
                var v10 = ClosingFeeToBeFinancedIndicator; v10.Clean = value; ClosingFeeToBeFinancedIndicator = v10;
                var v11 = ClosingPortionOfFeeIndicator; v11.Clean = value; ClosingPortionOfFeeIndicator = v11;
                var v12 = CreditReportFeeToBeFinancedIndicator; v12.Clean = value; CreditReportFeeToBeFinancedIndicator = v12;
                var v13 = CreditReportPortionOfFeeIndicator; v13.Clean = value; CreditReportPortionOfFeeIndicator = v13;
                var v14 = DocPrepFeeToBeFinancedIndicator; v14.Clean = value; DocPrepFeeToBeFinancedIndicator = v14;
                var v15 = DocPrepPortionOfFeeIndicator; v15.Clean = value; DocPrepPortionOfFeeIndicator = v15;
                var v16 = Exceed2PercentPrepayPenalty; v16.Clean = value; Exceed2PercentPrepayPenalty = v16;
                var v17 = HoepaAPR; v17.Clean = value; HoepaAPR = v17;
                var v18 = HoepaFee; v18.Clean = value; HoepaFee = v18;
                var v19 = Id; v19.Clean = value; Id = v19;
                var v20 = Jurisdications; v20.Clean = value; Jurisdications = v20;
                var v21 = LendersInspectionFeeToBeFinancedIndicator; v21.Clean = value; LendersInspectionFeeToBeFinancedIndicator = v21;
                var v22 = LendersInspectionPortionOfFeeIndicator; v22.Clean = value; LendersInspectionPortionOfFeeIndicator = v22;
                var v23 = LoanDiscountFeeToBeFinancedIndicator; v23.Clean = value; LoanDiscountFeeToBeFinancedIndicator = v23;
                var v24 = LoanDiscountPortionOfFeeIndicator; v24.Clean = value; LoanDiscountPortionOfFeeIndicator = v24;
                var v25 = LoanOriginationFeeToBeFinancedIndicator; v25.Clean = value; LoanOriginationFeeToBeFinancedIndicator = v25;
                var v26 = LoanOriginationPortionOfFeeIndicator; v26.Clean = value; LoanOriginationPortionOfFeeIndicator = v26;
                var v27 = LoanQualifyAsHighCostMortgage; v27.Clean = value; LoanQualifyAsHighCostMortgage = v27;
                var v28 = MaximumPercentageOfLoan; v28.Clean = value; MaximumPercentageOfLoan = v28;
                var v29 = MaximumPointsAndFees; v29.Clean = value; MaximumPointsAndFees = v29;
                var v30 = MortgageBrokerFeeToBeFinancedIndicator; v30.Clean = value; MortgageBrokerFeeToBeFinancedIndicator = v30;
                var v31 = MortgageBrokerPortionOfFeeIndicator; v31.Clean = value; MortgageBrokerPortionOfFeeIndicator = v31;
                var v32 = MortgageInspectionFeeToBeFinancedIndicator; v32.Clean = value; MortgageInspectionFeeToBeFinancedIndicator = v32;
                var v33 = MortgageInspectionPortionOfFeeIndicator; v33.Clean = value; MortgageInspectionPortionOfFeeIndicator = v33;
                var v34 = MortgageInsuranceFeeToBeFinancedIndicator; v34.Clean = value; MortgageInsuranceFeeToBeFinancedIndicator = v34;
                var v35 = MortgageInsurancePortionOfFeeIndicator; v35.Clean = value; MortgageInsurancePortionOfFeeIndicator = v35;
                var v36 = MortgageInsurancePremiumFeeToBeFinancedIndicator; v36.Clean = value; MortgageInsurancePremiumFeeToBeFinancedIndicator = v36;
                var v37 = MortgageInsurancePremiumPortionOfFeeIndicator; v37.Clean = value; MortgageInsurancePremiumPortionOfFeeIndicator = v37;
                var v38 = NotaryFeeToBeFinancedIndicator; v38.Clean = value; NotaryFeeToBeFinancedIndicator = v38;
                var v39 = NotaryPortionOfFeeIndicator; v39.Clean = value; NotaryPortionOfFeeIndicator = v39;
                var v40 = OtherHighCostIndicator; v40.Clean = value; OtherHighCostIndicator = v40;
                var v41 = PenaltyChargeMoreThan36Months; v41.Clean = value; PenaltyChargeMoreThan36Months = v41;
                var v42 = PestInspectionFeeToBeFinancedIndicator; v42.Clean = value; PestInspectionFeeToBeFinancedIndicator = v42;
                var v43 = PestInspectionPortionOfFeeIndicator; v43.Clean = value; PestInspectionPortionOfFeeIndicator = v43;
                var v44 = PrepayPenaltyPercentofAmtPrepaid; v44.Clean = value; PrepayPenaltyPercentofAmtPrepaid = v44;
                var v45 = ProcessingFeeToBeFinancedIndicator; v45.Clean = value; ProcessingFeeToBeFinancedIndicator = v45;
                var v46 = ProcessingPortionOfFeeIndicator; v46.Clean = value; ProcessingPortionOfFeeIndicator = v46;
                var v47 = RateSetIndex; v47.Clean = value; RateSetIndex = v47;
                var v48 = RecordingFeeToBeFinancedIndicator; v48.Clean = value; RecordingFeeToBeFinancedIndicator = v48;
                var v49 = RecordingPortionOfFeeIndicator; v49.Clean = value; RecordingPortionOfFeeIndicator = v49;
                var v50 = ResultOfPointAndFees; v50.Clean = value; ResultOfPointAndFees = v50;
                var v51 = ResultOfSecurityYieldTest; v51.Clean = value; ResultOfSecurityYieldTest = v51;
                var v52 = Section32Indicator; v52.Clean = value; Section32Indicator = v52;
                var v53 = Section35AveragePrimeRate; v53.Clean = value; Section35AveragePrimeRate = v53;
                var v54 = Section35IsSecondAppraisalRequired; v54.Clean = value; Section35IsSecondAppraisalRequired = v54;
                var v55 = Section35PriorAcquisitionDate; v55.Clean = value; Section35PriorAcquisitionDate = v55;
                var v56 = Section35PriorAcquisitionPrice; v56.Clean = value; Section35PriorAcquisitionPrice = v56;
                var v57 = Section35PriorAcquisitionSource; v57.Clean = value; Section35PriorAcquisitionSource = v57;
                var v58 = Section35ResultOfSecurityYieldTest; v58.Clean = value; Section35ResultOfSecurityYieldTest = v58;
                var v59 = Section35SalesContractDate; v59.Clean = value; Section35SalesContractDate = v59;
                var v60 = StateTaxStampsFeeToBeFinancedIndicator; v60.Clean = value; StateTaxStampsFeeToBeFinancedIndicator = v60;
                var v61 = StateTaxStampsPortionOfFeeIndicator; v61.Clean = value; StateTaxStampsPortionOfFeeIndicator = v61;
                var v62 = SurveyFeeToBeFinancedIndicator; v62.Clean = value; SurveyFeeToBeFinancedIndicator = v62;
                var v63 = SurveyPortionOfFeeIndicator; v63.Clean = value; SurveyPortionOfFeeIndicator = v63;
                var v64 = TaxServiceFeeToBeFinancedIndicator; v64.Clean = value; TaxServiceFeeToBeFinancedIndicator = v64;
                var v65 = TaxServicePortionOfFeeIndicator; v65.Clean = value; TaxServicePortionOfFeeIndicator = v65;
                var v66 = TitleBinderFeeToBeFinancedIndicator; v66.Clean = value; TitleBinderFeeToBeFinancedIndicator = v66;
                var v67 = TitleBinderPortionOfFeeIndicator; v67.Clean = value; TitleBinderPortionOfFeeIndicator = v67;
                var v68 = TitleExaminationFeeToBeFinancedIndicator; v68.Clean = value; TitleExaminationFeeToBeFinancedIndicator = v68;
                var v69 = TitleExaminationPortionOfFeeIndicator; v69.Clean = value; TitleExaminationPortionOfFeeIndicator = v69;
                var v70 = TitleInsuranceFeeToBeFinancedIndicator; v70.Clean = value; TitleInsuranceFeeToBeFinancedIndicator = v70;
                var v71 = TitleInsurancePortionOfFeeIndicator; v71.Clean = value; TitleInsurancePortionOfFeeIndicator = v71;
                var v72 = TitleSearchFeeToBeFinancedIndicator; v72.Clean = value; TitleSearchFeeToBeFinancedIndicator = v72;
                var v73 = TitleSearchPortionOfFeeIndicator; v73.Clean = value; TitleSearchPortionOfFeeIndicator = v73;
                var v74 = TotalPointsAndFees; v74.Clean = value; TotalPointsAndFees = v74;
                var v75 = TreasurySecurityYield; v75.Clean = value; TreasurySecurityYield = v75;
                var v76 = UnderwritingFeeToBeFinancedIndicator; v76.Clean = value; UnderwritingFeeToBeFinancedIndicator = v76;
                var v77 = UnderwritingPortionOfFeeIndicator; v77.Clean = value; UnderwritingPortionOfFeeIndicator = v77;
                var v78 = UserDefined1109BorPaidAmount; v78.Clean = value; UserDefined1109BorPaidAmount = v78;
                var v79 = UserDefined1109FeeToBeFinancedIndicator; v79.Clean = value; UserDefined1109FeeToBeFinancedIndicator = v79;
                var v80 = UserDefined1109PortionOfFeeIndicator; v80.Clean = value; UserDefined1109PortionOfFeeIndicator = v80;
                var v81 = UserDefined1110BorPaidAmount; v81.Clean = value; UserDefined1110BorPaidAmount = v81;
                var v82 = UserDefined1110FeeToBeFinancedIndicator; v82.Clean = value; UserDefined1110FeeToBeFinancedIndicator = v82;
                var v83 = UserDefined1110PortionOfFeeIndicator; v83.Clean = value; UserDefined1110PortionOfFeeIndicator = v83;
                var v84 = UserDefined1111FeeToBeFinancedIndicator; v84.Clean = value; UserDefined1111FeeToBeFinancedIndicator = v84;
                var v85 = UserDefined1111PortionOfFeeIndicator; v85.Clean = value; UserDefined1111PortionOfFeeIndicator = v85;
                var v86 = UserDefined1112FeeToBeFinancedIndicator; v86.Clean = value; UserDefined1112FeeToBeFinancedIndicator = v86;
                var v87 = UserDefined1112PortionOfFeeIndicator; v87.Clean = value; UserDefined1112PortionOfFeeIndicator = v87;
                var v88 = UserDefined1113FeeToBeFinancedIndicator; v88.Clean = value; UserDefined1113FeeToBeFinancedIndicator = v88;
                var v89 = UserDefined1113PortionOfFeeIndicator; v89.Clean = value; UserDefined1113PortionOfFeeIndicator = v89;
                var v90 = UserDefined1114FeeToBeFinancedIndicator; v90.Clean = value; UserDefined1114FeeToBeFinancedIndicator = v90;
                var v91 = UserDefined1114PortionOfFeeIndicator; v91.Clean = value; UserDefined1114PortionOfFeeIndicator = v91;
                var v92 = UserDefined1204FeeToBeFinancedIndicator; v92.Clean = value; UserDefined1204FeeToBeFinancedIndicator = v92;
                var v93 = UserDefined1204PortionOfFeeIndicator; v93.Clean = value; UserDefined1204PortionOfFeeIndicator = v93;
                var v94 = UserDefined1205FeeToBeFinancedIndicator; v94.Clean = value; UserDefined1205FeeToBeFinancedIndicator = v94;
                var v95 = UserDefined1205PortionOfFeeIndicator; v95.Clean = value; UserDefined1205PortionOfFeeIndicator = v95;
                var v96 = UserDefined1206FeeToBeFinancedIndicator; v96.Clean = value; UserDefined1206FeeToBeFinancedIndicator = v96;
                var v97 = UserDefined1206PortionOfFeeIndicator; v97.Clean = value; UserDefined1206PortionOfFeeIndicator = v97;
                var v98 = UserDefined1303FeeToBeFinancedIndicator; v98.Clean = value; UserDefined1303FeeToBeFinancedIndicator = v98;
                var v99 = UserDefined1303PortionOfFeeIndicator; v99.Clean = value; UserDefined1303PortionOfFeeIndicator = v99;
                var v100 = UserDefined1304FeeToBeFinancedIndicator; v100.Clean = value; UserDefined1304FeeToBeFinancedIndicator = v100;
                var v101 = UserDefined1304PortionOfFeeIndicator; v101.Clean = value; UserDefined1304PortionOfFeeIndicator = v101;
                var v102 = UserDefined1305FeeToBeFinancedIndicator; v102.Clean = value; UserDefined1305FeeToBeFinancedIndicator = v102;
                var v103 = UserDefined1305PortionOfFeeIndicator; v103.Clean = value; UserDefined1305PortionOfFeeIndicator = v103;
                var v104 = UserDefined1306FeeToBeFinancedIndicator; v104.Clean = value; UserDefined1306FeeToBeFinancedIndicator = v104;
                var v105 = UserDefined1306PortionOfFeeIndicator; v105.Clean = value; UserDefined1306PortionOfFeeIndicator = v105;
                var v106 = UserDefined1307FeeToBeFinancedIndicator; v106.Clean = value; UserDefined1307FeeToBeFinancedIndicator = v106;
                var v107 = UserDefined1307PortionOfFeeIndicator; v107.Clean = value; UserDefined1307PortionOfFeeIndicator = v107;
                var v108 = UserDefined1308FeeToBeFinancedIndicator; v108.Clean = value; UserDefined1308FeeToBeFinancedIndicator = v108;
                var v109 = UserDefined1308PortionOfFeeIndicator; v109.Clean = value; UserDefined1308PortionOfFeeIndicator = v109;
                var v110 = UserDefined1309FeeToBeFinancedIndicator; v110.Clean = value; UserDefined1309FeeToBeFinancedIndicator = v110;
                var v111 = UserDefined1309PortionOfFeeIndicator; v111.Clean = value; UserDefined1309PortionOfFeeIndicator = v111;
                var v112 = UserDefined813FeeToBeFinancedIndicator; v112.Clean = value; UserDefined813FeeToBeFinancedIndicator = v112;
                var v113 = UserDefined813PortionOfFeeIndicator; v113.Clean = value; UserDefined813PortionOfFeeIndicator = v113;
                var v114 = UserDefined814FeeToBeFinancedIndicator; v114.Clean = value; UserDefined814FeeToBeFinancedIndicator = v114;
                var v115 = UserDefined814PortionOfFeeIndicator; v115.Clean = value; UserDefined814PortionOfFeeIndicator = v115;
                var v116 = UserDefined815FeeToBeFinancedIndicator; v116.Clean = value; UserDefined815FeeToBeFinancedIndicator = v116;
                var v117 = UserDefined815PortionOfFeeIndicator; v117.Clean = value; UserDefined815PortionOfFeeIndicator = v117;
                var v118 = UserDefined816FeeToBeFinancedIndicator; v118.Clean = value; UserDefined816FeeToBeFinancedIndicator = v118;
                var v119 = UserDefined816PortionOfFeeIndicator; v119.Clean = value; UserDefined816PortionOfFeeIndicator = v119;
                var v120 = UserDefined817FeeToBeFinancedIndicator; v120.Clean = value; UserDefined817FeeToBeFinancedIndicator = v120;
                var v121 = UserDefined817PortionOfFeeIndicator; v121.Clean = value; UserDefined817PortionOfFeeIndicator = v121;
                var v122 = UserDefined818FeeToBeFinancedIndicator; v122.Clean = value; UserDefined818FeeToBeFinancedIndicator = v122;
                var v123 = UserDefined818PortionOfFeeIndicator; v123.Clean = value; UserDefined818PortionOfFeeIndicator = v123;
                var v124 = UserDefined819FeeToBeFinancedIndicator; v124.Clean = value; UserDefined819FeeToBeFinancedIndicator = v124;
                var v125 = UserDefined819PortionOfFeeIndicator; v125.Clean = value; UserDefined819PortionOfFeeIndicator = v125;
                var v126 = UserDefined820FeeToBeFinancedIndicator; v126.Clean = value; UserDefined820FeeToBeFinancedIndicator = v126;
                var v127 = UserDefined820PortionOfFeeIndicator; v127.Clean = value; UserDefined820PortionOfFeeIndicator = v127;
                var v128 = UserDefined821FeeToBeFinancedIndicator; v128.Clean = value; UserDefined821FeeToBeFinancedIndicator = v128;
                var v129 = UserDefined821PortionOfFeeIndicator; v129.Clean = value; UserDefined821PortionOfFeeIndicator = v129;
                var v130 = UserDefined822FeeToBeFinancedIndicator; v130.Clean = value; UserDefined822FeeToBeFinancedIndicator = v130;
                var v131 = UserDefined822PortionOfFeeIndicator; v131.Clean = value; UserDefined822PortionOfFeeIndicator = v131;
                var v132 = UserDefined823FeeToBeFinancedIndicator; v132.Clean = value; UserDefined823FeeToBeFinancedIndicator = v132;
                var v133 = UserDefined823PortionOfFeeIndicator; v133.Clean = value; UserDefined823PortionOfFeeIndicator = v133;
                var v134 = WireTransferFeeToBeFinancedIndicator; v134.Clean = value; WireTransferFeeToBeFinancedIndicator = v134;
                var v135 = WireTransferPortionOfFeeIndicator; v135.Clean = value; WireTransferPortionOfFeeIndicator = v135;
                _settingClean = 0;
            }
        }
    }
}