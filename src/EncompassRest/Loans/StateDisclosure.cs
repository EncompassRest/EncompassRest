using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class StateDisclosure
    {
        public Value<bool?> AcceptedByBorrowerIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAcceptedByBorrowerIndicator() => !AcceptedByBorrowerIndicator.Clean;
        public Value<DateTime?> AcceptedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAcceptedDate() => !AcceptedDate.Clean;
        public Value<string> ActingOtherDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActingOtherDescription1() => !ActingOtherDescription1.Clean;
        public Value<string> ActingOtherDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActingOtherDescription2() => !ActingOtherDescription2.Clean;
        public Value<bool?> ActingOthersIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActingOthersIndicator() => !ActingOthersIndicator.Clean;
        public Value<int?> AdvFeeAgmtInEfctNumDay { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdvFeeAgmtInEfctNumDay() => !AdvFeeAgmtInEfctNumDay.Clean;
        public Value<string> AdvisoryCondition1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdvisoryCondition1() => !AdvisoryCondition1.Clean;
        public Value<string> AdvisoryCondition2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdvisoryCondition2() => !AdvisoryCondition2.Clean;
        public Value<string> AdvisoryCondition3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdvisoryCondition3() => !AdvisoryCondition3.Clean;
        public Value<string> AdvisoryCondition4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdvisoryCondition4() => !AdvisoryCondition4.Clean;
        public Value<decimal?> AmendedAcquisitionCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmendedAcquisitionCost() => !AmendedAcquisitionCost.Clean;
        public Value<DateTime?> ApplicationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicationDate() => !ApplicationDate.Clean;
        public Value<string> AppraisalContact { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalContact() => !AppraisalContact.Clean;
        public Value<decimal?> AppraisalDeposit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisalDeposit() => !AppraisalDeposit.Clean;
        public Value<string> Areas { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAreas() => !Areas.Clean;
        public Value<bool?> AsAttorneyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAsAttorneyIndicator() => !AsAttorneyIndicator.Clean;
        public Value<bool?> AsRealBrokerIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAsRealBrokerIndicator() => !AsRealBrokerIndicator.Clean;
        public Value<bool?> AttorneyForTheBuyerIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAttorneyForTheBuyerIndicator() => !AttorneyForTheBuyerIndicator.Clean;
        public Value<bool?> AttorneyForTheLenderIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAttorneyForTheLenderIndicator() => !AttorneyForTheLenderIndicator.Clean;
        public Value<bool?> AttorneyForTheSellerIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAttorneyForTheSellerIndicator() => !AttorneyForTheSellerIndicator.Clean;
        public Value<string> AZCmplBlankSpcsDoc1BlankFldDesc1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAZCmplBlankSpcsDoc1BlankFldDesc1() => !AZCmplBlankSpcsDoc1BlankFldDesc1.Clean;
        public Value<string> AZCmplBlankSpcsDoc1BlankFldDesc2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAZCmplBlankSpcsDoc1BlankFldDesc2() => !AZCmplBlankSpcsDoc1BlankFldDesc2.Clean;
        public Value<string> AZCmplBlankSpcsDoc1BlankFldDesc3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAZCmplBlankSpcsDoc1BlankFldDesc3() => !AZCmplBlankSpcsDoc1BlankFldDesc3.Clean;
        public Value<string> AZCmplBlankSpcsDoc1Nm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAZCmplBlankSpcsDoc1Nm() => !AZCmplBlankSpcsDoc1Nm.Clean;
        public Value<string> AZCmplBlankSpcsDoc2Nm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAZCmplBlankSpcsDoc2Nm() => !AZCmplBlankSpcsDoc2Nm.Clean;
        public Value<string> AZCmplBlankSpcsDoc3Nm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAZCmplBlankSpcsDoc3Nm() => !AZCmplBlankSpcsDoc3Nm.Clean;
        public Value<string> BasedOnOthersDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasedOnOthersDescription() => !BasedOnOthersDescription.Clean;
        public Value<bool?> BasedOnOthersIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasedOnOthersIndicator() => !BasedOnOthersIndicator.Clean;
        public Value<bool?> BasedOnWholesaleOptionsIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBasedOnWholesaleOptionsIndicator() => !BasedOnWholesaleOptionsIndicator.Clean;
        public Value<decimal?> BorrowerElectsEstablishEscrowAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerElectsEstablishEscrowAmount() => !BorrowerElectsEstablishEscrowAmount.Clean;
        public Value<bool?> BorrowerElectsEstablishEscrowIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerElectsEstablishEscrowIndicator() => !BorrowerElectsEstablishEscrowIndicator.Clean;
        public Value<decimal?> BrokerageFeeAddition1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerageFeeAddition1() => !BrokerageFeeAddition1.Clean;
        public Value<decimal?> BrokerageFeeAddition2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerageFeeAddition2() => !BrokerageFeeAddition2.Clean;
        public Value<decimal?> BrokerageFeeAddition3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerageFeeAddition3() => !BrokerageFeeAddition3.Clean;
        public Value<decimal?> BrokerageFeeAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerageFeeAmount1() => !BrokerageFeeAmount1.Clean;
        public Value<decimal?> BrokerageFeeAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerageFeeAmount2() => !BrokerageFeeAmount2.Clean;
        public Value<decimal?> BrokerageFeeAmount3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerageFeeAmount3() => !BrokerageFeeAmount3.Clean;
        public Value<int?> BrokerageFeeDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerageFeeDays() => !BrokerageFeeDays.Clean;
        public Value<decimal?> BrokerageFeePercent1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerageFeePercent1() => !BrokerageFeePercent1.Clean;
        public Value<decimal?> BrokerageFeePercent2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerageFeePercent2() => !BrokerageFeePercent2.Clean;
        public Value<decimal?> BrokerageFeePercent3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerageFeePercent3() => !BrokerageFeePercent3.Clean;
        public Value<string> BrokerAuthorizedSigningRepName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerAuthorizedSigningRepName() => !BrokerAuthorizedSigningRepName.Clean;
        public Value<string> BrokerAuthorizedSigningRepTitle { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerAuthorizedSigningRepTitle() => !BrokerAuthorizedSigningRepTitle.Clean;
        public Value<string> BrokerForTheSeller { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerForTheSeller() => !BrokerForTheSeller.Clean;
        public Value<string> BrokerLicense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerLicense() => !BrokerLicense.Clean;
        public Value<string> BrokerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerName() => !BrokerName.Clean;
        public Value<decimal?> BrokerPayAddition { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerPayAddition() => !BrokerPayAddition.Clean;
        public Value<decimal?> BrokerPayAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerPayAmount() => !BrokerPayAmount.Clean;
        public Value<bool?> BrokerPayIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerPayIndicator() => !BrokerPayIndicator.Clean;
        public Value<decimal?> BrokerPayPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerPayPercent() => !BrokerPayPercent.Clean;
        public Value<bool?> CHARMBookletIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCHARMBookletIndicator() => !CHARMBookletIndicator.Clean;
        public Value<string> CheckPayableTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCheckPayableTo() => !CheckPayableTo.Clean;
        public Value<decimal?> CommitmentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentAmount() => !CommitmentAmount.Clean;
        public Value<string> CommitmentCondition1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentCondition1() => !CommitmentCondition1.Clean;
        public Value<string> CommitmentCondition2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentCondition2() => !CommitmentCondition2.Clean;
        public Value<decimal?> CommitmentFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentFee() => !CommitmentFee.Clean;
        public Value<decimal?> CommitmentPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentPercent() => !CommitmentPercent.Clean;
        public Value<decimal?> CompensationAddition { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompensationAddition() => !CompensationAddition.Clean;
        public Value<decimal?> CompensationPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompensationPercent() => !CompensationPercent.Clean;
        public Value<decimal?> CreditDeposit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditDeposit() => !CreditDeposit.Clean;
        public Value<string> CreditIsUsedForReason { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditIsUsedForReason() => !CreditIsUsedForReason.Clean;
        public Value<string> CreditReportContact { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditReportContact() => !CreditReportContact.Clean;
        public Value<int?> DaysBeforeClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDaysBeforeClosing() => !DaysBeforeClosing.Clean;
        public Value<decimal?> DepositReceipt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDepositReceipt() => !DepositReceipt.Clean;
        public Value<bool?> DepositRefundableIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDepositRefundableIndicator() => !DepositRefundableIndicator.Clean;
        public Value<string> DirectContact { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDirectContact() => !DirectContact.Clean;
        public Value<decimal?> DirectPayAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDirectPayAmount() => !DirectPayAmount.Clean;
        public Value<decimal?> DirectPayClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDirectPayClosing() => !DirectPayClosing.Clean;
        public Value<decimal?> DirectPayCommitment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDirectPayCommitment() => !DirectPayCommitment.Clean;
        public Value<bool?> DirectPayIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDirectPayIndicator() => !DirectPayIndicator.Clean;
        public Value<decimal?> DirectPayPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDirectPayPercent() => !DirectPayPercent.Clean;
        public Value<string> DisclosureDeliveredBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureDeliveredBy() => !DisclosureDeliveredBy.Clean;
        public Value<string> DisclosureDeliveredByOtherMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureDeliveredByOtherMethod() => !DisclosureDeliveredByOtherMethod.Clean;
        public Value<DateTime?> DisclosureDeliveredDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureDeliveredDate() => !DisclosureDeliveredDate.Clean;
        public Value<bool?> EstimatedChargeShownOnGFEIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedChargeShownOnGFEIndicator() => !EstimatedChargeShownOnGFEIndicator.Clean;
        public Value<DateTime?> ExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpirationDate() => !ExpirationDate.Clean;
        public Value<decimal?> FederallySubsidizedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFederallySubsidizedAmount() => !FederallySubsidizedAmount.Clean;
        public Value<decimal?> FederallySubsidizedAmountPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFederallySubsidizedAmountPercentage() => !FederallySubsidizedAmountPercentage.Clean;
        public Value<decimal?> FeeReceived1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeReceived1() => !FeeReceived1.Clean;
        public Value<decimal?> FeeReceived2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeReceived2() => !FeeReceived2.Clean;
        public Value<string> FeeReceivedByLender { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeReceivedByLender() => !FeeReceivedByLender.Clean;
        public Value<decimal?> FeesReceiving { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeesReceiving() => !FeesReceiving.Clean;
        public Value<decimal?> FloridaApplicationFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloridaApplicationFee() => !FloridaApplicationFee.Clean;
        public Value<decimal?> FloridaOtherFee1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloridaOtherFee1() => !FloridaOtherFee1.Clean;
        public Value<decimal?> FloridaOtherFee2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloridaOtherFee2() => !FloridaOtherFee2.Clean;
        public Value<string> FloridaOtherFeeTo1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloridaOtherFeeTo1() => !FloridaOtherFeeTo1.Clean;
        public Value<string> FloridaOtherFeeTo2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloridaOtherFeeTo2() => !FloridaOtherFeeTo2.Clean;
        public Value<string> FloridaOtherFeeTo3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloridaOtherFeeTo3() => !FloridaOtherFeeTo3.Clean;
        public Value<string> FloridaOtherFeeTo4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloridaOtherFeeTo4() => !FloridaOtherFeeTo4.Clean;
        public Value<string> FurtherFeesEarnedByMortgageBroker { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFurtherFeesEarnedByMortgageBroker() => !FurtherFeesEarnedByMortgageBroker.Clean;
        public Value<decimal?> GFEFeeReceived1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGFEFeeReceived1() => !GFEFeeReceived1.Clean;
        public Value<decimal?> GFEFeeReceived2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGFEFeeReceived2() => !GFEFeeReceived2.Clean;
        public Value<bool?> HUDBookletIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUDBookletIndicator() => !HUDBookletIndicator.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IndependentContractorIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndependentContractorIndicator() => !IndependentContractorIndicator.Clean;
        public Value<string> IndexUsed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndexUsed() => !IndexUsed.Clean;
        public Value<string> InformationAboutTheIndexCanBeFound { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationAboutTheIndexCanBeFound() => !InformationAboutTheIndexCanBeFound.Clean;
        public Value<string> InLicensedNo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInLicensedNo() => !InLicensedNo.Clean;
        public Value<string> InLicensedType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInLicensedType() => !InLicensedType.Clean;
        public Value<bool?> IsEstimateIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEstimateIndicator() => !IsEstimateIndicator.Clean;
        public Value<bool?> KsUcccElectionIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeKsUcccElectionIndicator() => !KsUcccElectionIndicator.Clean;
        public Value<bool?> KyHomeSolicationLoanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeKyHomeSolicationLoanIndicator() => !KyHomeSolicationLoanIndicator.Clean;
        public Value<DateTime?> LeaseAgreementDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLeaseAgreementDate() => !LeaseAgreementDate.Clean;
        public Value<DateTime?> LenderDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderDate() => !LenderDate.Clean;
        public Value<string> LenderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderName() => !LenderName.Clean;
        public Value<decimal?> LenderPaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPaid() => !LenderPaid.Clean;
        public Value<decimal?> LenderPayAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPayAmount() => !LenderPayAmount.Clean;
        public Value<bool?> LenderPayIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPayIndicator() => !LenderPayIndicator.Clean;
        public Value<decimal?> LenderPayMaxPoint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPayMaxPoint() => !LenderPayMaxPoint.Clean;
        public Value<decimal?> LenderPayPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPayPercent() => !LenderPayPercent.Clean;
        public Value<decimal?> LenderPayPoint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPayPoint() => !LenderPayPoint.Clean;
        public Value<bool?> LenderPayUnknownIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPayUnknownIndicator() => !LenderPayUnknownIndicator.Clean;
        public Value<string> LenderStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderStatus() => !LenderStatus.Clean;
        public Value<string> LessorName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLessorName() => !LessorName.Clean;
        public Value<bool?> LoanTermsFixedThroughDateofLoanClosingIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanTermsFixedThroughDateofLoanClosingIndicator() => !LoanTermsFixedThroughDateofLoanClosingIndicator.Clean;
        public Value<decimal?> LockInFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockInFee() => !LockInFee.Clean;
        public Value<string> MethodDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMethodDescription() => !MethodDescription.Clean;
        public Value<string> MethodDetermine { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMethodDetermine() => !MethodDetermine.Clean;
        public Value<bool?> MortgageAgreementIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageAgreementIndicator() => !MortgageAgreementIndicator.Clean;
        public Value<string> MtgBrokerLicense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMtgBrokerLicense() => !MtgBrokerLicense.Clean;
        public Value<string> NameOfLicensee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNameOfLicensee() => !NameOfLicensee.Clean;
        public Value<decimal?> NewMoneyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewMoneyAmount() => !NewMoneyAmount.Clean;
        public Value<decimal?> NewYorkApplicationFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewYorkApplicationFee() => !NewYorkApplicationFee.Clean;
        public Value<decimal?> NewYorkAppraisalFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewYorkAppraisalFee() => !NewYorkAppraisalFee.Clean;
        public Value<decimal?> NewYorkCreditReportFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewYorkCreditReportFee() => !NewYorkCreditReportFee.Clean;
        public Value<List<NewYorkFee>> NewYorkFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewYorkFees() => !NewYorkFees.Clean;
        public Value<List<NewYorkPrimaryLender>> NewYorkPrimaryLenders { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewYorkPrimaryLenders() => !NewYorkPrimaryLenders.Clean;
        public Value<decimal?> NewYorkProcessingFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewYorkProcessingFee() => !NewYorkProcessingFee.Clean;
        public Value<decimal?> NotRefundableAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotRefundableAmount() => !NotRefundableAmount.Clean;
        public Value<bool?> OfferRetailPriceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOfferRetailPriceIndicator() => !OfferRetailPriceIndicator.Clean;
        public Value<decimal?> OriginalAcquisitionCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalAcquisitionCost() => !OriginalAcquisitionCost.Clean;
        public Value<decimal?> OriginationFeeChargedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationFeeChargedAmount() => !OriginationFeeChargedAmount.Clean;
        public Value<bool?> OriginationFeeChargedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationFeeChargedIndicator() => !OriginationFeeChargedIndicator.Clean;
        public Value<decimal?> OriginationFeeDecreasesRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationFeeDecreasesRate() => !OriginationFeeDecreasesRate.Clean;
        public Value<decimal?> OriginationFeeIncreasesRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationFeeIncreasesRate() => !OriginationFeeIncreasesRate.Clean;
        public Value<string> OriginationFeeInterestRateImpactedStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationFeeInterestRateImpactedStatus() => !OriginationFeeInterestRateImpactedStatus.Clean;
        public Value<string> OriginationFeePaidBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationFeePaidBy() => !OriginationFeePaidBy.Clean;
        public Value<decimal?> PaidByBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidByBorrower() => !PaidByBorrower.Clean;
        public Value<decimal?> PaidByLender { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidByLender() => !PaidByLender.Clean;
        public Value<decimal?> PaidByOther1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidByOther1() => !PaidByOther1.Clean;
        public Value<decimal?> PaidByOther2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidByOther2() => !PaidByOther2.Clean;
        public Value<string> PaidByOtherDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidByOtherDescription1() => !PaidByOtherDescription1.Clean;
        public Value<string> PaidByOtherDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidByOtherDescription2() => !PaidByOtherDescription2.Clean;
        public Value<decimal?> PreviousMortgageAmountOne { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousMortgageAmountOne() => !PreviousMortgageAmountOne.Clean;
        public Value<decimal?> PreviousMortgageAmountTwo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreviousMortgageAmountTwo() => !PreviousMortgageAmountTwo.Clean;
        public Value<bool?> PrintCertificationOfCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintCertificationOfCosts() => !PrintCertificationOfCosts.Clean;
        public Value<bool?> PrintInterestRateReductionRider { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintInterestRateReductionRider() => !PrintInterestRateReductionRider.Clean;
        public Value<bool?> PrintMDDeliveryIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintMDDeliveryIndicator() => !PrintMDDeliveryIndicator.Clean;
        public Value<string> ProvidedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProvidedBy() => !ProvidedBy.Clean;
        public Value<string> QuestionContact { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeQuestionContact() => !QuestionContact.Clean;
        public Value<string> QuestionContactPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeQuestionContactPhone() => !QuestionContactPhone.Clean;
        public Value<string> QuestionContactTollFree { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeQuestionContactTollFree() => !QuestionContactTollFree.Clean;
        public Value<bool?> RateLockHonoredIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockHonoredIndicator() => !RateLockHonoredIndicator.Clean;
        public Value<string> ReceivedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceivedBy() => !ReceivedBy.Clean;
        public Value<decimal?> RefinancingFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinancingFee() => !RefinancingFee.Clean;
        public Value<string> RefundableBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefundableBy() => !RefundableBy.Clean;
        public Value<bool?> RefundableIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefundableIndicator() => !RefundableIndicator.Clean;
        public Value<string> RefundableType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefundableType() => !RefundableType.Clean;
        public Value<string> RefundCondition1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefundCondition1() => !RefundCondition1.Clean;
        public Value<string> RefundCondition2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefundCondition2() => !RefundCondition2.Clean;
        public Value<string> RefundCondition3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefundCondition3() => !RefundCondition3.Clean;
        public Value<string> RefundCondition4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefundCondition4() => !RefundCondition4.Clean;
        public Value<string> RefundCondition5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefundCondition5() => !RefundCondition5.Clean;
        public Value<string> RefundCondition6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefundCondition6() => !RefundCondition6.Clean;
        public Value<string> RegulatorAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulatorAddress() => !RegulatorAddress.Clean;
        public Value<string> RegulatorCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulatorCity() => !RegulatorCity.Clean;
        public Value<string> RegulatorMailingAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulatorMailingAddress() => !RegulatorMailingAddress.Clean;
        public Value<string> RegulatorMailingCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulatorMailingCity() => !RegulatorMailingCity.Clean;
        public Value<string> RegulatorMailingState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulatorMailingState() => !RegulatorMailingState.Clean;
        public Value<string> RegulatorMailingZipCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulatorMailingZipCode() => !RegulatorMailingZipCode.Clean;
        public Value<string> RegulatorPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulatorPhone() => !RegulatorPhone.Clean;
        public Value<string> RegulatorState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulatorState() => !RegulatorState.Clean;
        public Value<string> RegulatorTollFreePhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulatorTollFreePhone() => !RegulatorTollFreePhone.Clean;
        public Value<string> RegulatorWebAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulatorWebAddress() => !RegulatorWebAddress.Clean;
        public Value<string> RegulatorZipCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegulatorZipCode() => !RegulatorZipCode.Clean;
        public Value<string> ScheduleOfChargesEstimatedFinalIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeScheduleOfChargesEstimatedFinalIndicator() => !ScheduleOfChargesEstimatedFinalIndicator.Clean;
        public Value<string> ScRegulatoryAgencyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeScRegulatoryAgencyType() => !ScRegulatoryAgencyType.Clean;
        public Value<bool?> SelectDivisionFeesIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSelectDivisionFeesIndicator() => !SelectDivisionFeesIndicator.Clean;
        public Value<bool?> SelectPrimaryLenderIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSelectPrimaryLenderIndicator() => !SelectPrimaryLenderIndicator.Clean;
        public Value<bool?> SelectPrivateLenderIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSelectPrivateLenderIndicator() => !SelectPrivateLenderIndicator.Clean;
        public Value<decimal?> ServicingFeeChargedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingFeeChargedAmount() => !ServicingFeeChargedAmount.Clean;
        public Value<bool?> ServicingFeeChargedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingFeeChargedIndicator() => !ServicingFeeChargedIndicator.Clean;
        public Value<string> ServicingFeePaidBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingFeePaidBy() => !ServicingFeePaidBy.Clean;
        public Value<string> ServicingFeePaidFrequence { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingFeePaidFrequence() => !ServicingFeePaidFrequence.Clean;
        public Value<bool?> SignedByBorrowerIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSignedByBorrowerIndicator() => !SignedByBorrowerIndicator.Clean;
        public Value<bool?> SpecificARMIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecificARMIndicator() => !SpecificARMIndicator.Clean;
        public Value<bool?> SubmitToLenderIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmitToLenderIndicator() => !SubmitToLenderIndicator.Clean;
        public Value<decimal?> TaxExemptAcquisitionCostCertificationAssessments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxExemptAcquisitionCostCertificationAssessments() => !TaxExemptAcquisitionCostCertificationAssessments.Clean;
        public Value<string> TaxExemptAcquisitionCostCertificationOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxExemptAcquisitionCostCertificationOther() => !TaxExemptAcquisitionCostCertificationOther.Clean;
        public Value<decimal?> TaxExemptAcquisitionCostCertificationOtherAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxExemptAcquisitionCostCertificationOtherAmount() => !TaxExemptAcquisitionCostCertificationOtherAmount.Clean;
        public Value<decimal?> TaxExemptAcquisitionCostCertificationOwnersTitleInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxExemptAcquisitionCostCertificationOwnersTitleInsurance() => !TaxExemptAcquisitionCostCertificationOwnersTitleInsurance.Clean;
        public Value<decimal?> TaxExemptAcquisitionCostCertificationRealEstateCommission { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxExemptAcquisitionCostCertificationRealEstateCommission() => !TaxExemptAcquisitionCostCertificationRealEstateCommission.Clean;
        public Value<decimal?> TaxExemptAcquisitionCostCertificationRepairsImprovements { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxExemptAcquisitionCostCertificationRepairsImprovements() => !TaxExemptAcquisitionCostCertificationRepairsImprovements.Clean;
        public Value<decimal?> TaxExemptAcquisitionCostCertificationSurvey { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxExemptAcquisitionCostCertificationSurvey() => !TaxExemptAcquisitionCostCertificationSurvey.Clean;
        public Value<decimal?> TaxExemptAcquisitionCostCertificationTotalAdjustments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxExemptAcquisitionCostCertificationTotalAdjustments() => !TaxExemptAcquisitionCostCertificationTotalAdjustments.Clean;
        public Value<string> TermsChange { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTermsChange() => !TermsChange.Clean;
        public Value<decimal?> TexasApplicationFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTexasApplicationFee() => !TexasApplicationFee.Clean;
        public Value<decimal?> TexasAppraisalFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTexasAppraisalFee() => !TexasAppraisalFee.Clean;
        public Value<decimal?> TexasCreditReportFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTexasCreditReportFee() => !TexasCreditReportFee.Clean;
        public Value<decimal?> TexasOtherFee1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTexasOtherFee1() => !TexasOtherFee1.Clean;
        public Value<decimal?> TexasOtherFee2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTexasOtherFee2() => !TexasOtherFee2.Clean;
        public Value<string> TexasOtherFeeContact1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTexasOtherFeeContact1() => !TexasOtherFeeContact1.Clean;
        public Value<string> TexasOtherFeeContact2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTexasOtherFeeContact2() => !TexasOtherFeeContact2.Clean;
        public Value<decimal?> TexasProcessingFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTexasProcessingFee() => !TexasProcessingFee.Clean;
        public Value<decimal?> ThirdPartyFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThirdPartyFee() => !ThirdPartyFee.Clean;
        public Value<decimal?> TotalFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalFee() => !TotalFee.Clean;
        public Value<decimal?> TransferFeeChargedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransferFeeChargedAmount() => !TransferFeeChargedAmount.Clean;
        public Value<bool?> TransferFeeChargedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransferFeeChargedIndicator() => !TransferFeeChargedIndicator.Clean;
        public Value<string> TransferFeePaidBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransferFeePaidBy() => !TransferFeePaidBy.Clean;
        public Value<bool?> TxVeteransLandBoardIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTxVeteransLandBoardIndicator() => !TxVeteransLandBoardIndicator.Clean;
        public Value<string> TypeOfProperty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTypeOfProperty() => !TypeOfProperty.Clean;
        public Value<string> UnderwritingContact { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingContact() => !UnderwritingContact.Clean;
        public Value<decimal?> UnderwritingFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingFee() => !UnderwritingFee.Clean;
        public Value<decimal?> YSPChargedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYSPChargedAmount() => !YSPChargedAmount.Clean;
        public Value<bool?> YSPChargedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYSPChargedIndicator() => !YSPChargedIndicator.Clean;
        public Value<decimal?> YSPDecreasesRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYSPDecreasesRate() => !YSPDecreasesRate.Clean;
        public Value<decimal?> YSPIncreasesRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYSPIncreasesRate() => !YSPIncreasesRate.Clean;
        public Value<string> YSPInterestRateImpactedStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYSPInterestRateImpactedStatus() => !YSPInterestRateImpactedStatus.Clean;
        public Value<string> YSPPaidBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYSPPaidBy() => !YSPPaidBy.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AcceptedByBorrowerIndicator.Clean
                    && AcceptedDate.Clean
                    && ActingOtherDescription1.Clean
                    && ActingOtherDescription2.Clean
                    && ActingOthersIndicator.Clean
                    && AdvFeeAgmtInEfctNumDay.Clean
                    && AdvisoryCondition1.Clean
                    && AdvisoryCondition2.Clean
                    && AdvisoryCondition3.Clean
                    && AdvisoryCondition4.Clean
                    && AmendedAcquisitionCost.Clean
                    && ApplicationDate.Clean
                    && AppraisalContact.Clean
                    && AppraisalDeposit.Clean
                    && Areas.Clean
                    && AsAttorneyIndicator.Clean
                    && AsRealBrokerIndicator.Clean
                    && AttorneyForTheBuyerIndicator.Clean
                    && AttorneyForTheLenderIndicator.Clean
                    && AttorneyForTheSellerIndicator.Clean
                    && AZCmplBlankSpcsDoc1BlankFldDesc1.Clean
                    && AZCmplBlankSpcsDoc1BlankFldDesc2.Clean
                    && AZCmplBlankSpcsDoc1BlankFldDesc3.Clean
                    && AZCmplBlankSpcsDoc1Nm.Clean
                    && AZCmplBlankSpcsDoc2Nm.Clean
                    && AZCmplBlankSpcsDoc3Nm.Clean
                    && BasedOnOthersDescription.Clean
                    && BasedOnOthersIndicator.Clean
                    && BasedOnWholesaleOptionsIndicator.Clean
                    && BorrowerElectsEstablishEscrowAmount.Clean
                    && BorrowerElectsEstablishEscrowIndicator.Clean
                    && BrokerageFeeAddition1.Clean
                    && BrokerageFeeAddition2.Clean
                    && BrokerageFeeAddition3.Clean
                    && BrokerageFeeAmount1.Clean
                    && BrokerageFeeAmount2.Clean
                    && BrokerageFeeAmount3.Clean
                    && BrokerageFeeDays.Clean
                    && BrokerageFeePercent1.Clean
                    && BrokerageFeePercent2.Clean
                    && BrokerageFeePercent3.Clean
                    && BrokerAuthorizedSigningRepName.Clean
                    && BrokerAuthorizedSigningRepTitle.Clean
                    && BrokerForTheSeller.Clean
                    && BrokerLicense.Clean
                    && BrokerName.Clean
                    && BrokerPayAddition.Clean
                    && BrokerPayAmount.Clean
                    && BrokerPayIndicator.Clean
                    && BrokerPayPercent.Clean
                    && CHARMBookletIndicator.Clean
                    && CheckPayableTo.Clean
                    && CommitmentAmount.Clean
                    && CommitmentCondition1.Clean
                    && CommitmentCondition2.Clean
                    && CommitmentFee.Clean
                    && CommitmentPercent.Clean
                    && CompensationAddition.Clean
                    && CompensationPercent.Clean
                    && CreditDeposit.Clean
                    && CreditIsUsedForReason.Clean
                    && CreditReportContact.Clean
                    && DaysBeforeClosing.Clean
                    && DepositReceipt.Clean
                    && DepositRefundableIndicator.Clean
                    && DirectContact.Clean
                    && DirectPayAmount.Clean
                    && DirectPayClosing.Clean
                    && DirectPayCommitment.Clean
                    && DirectPayIndicator.Clean
                    && DirectPayPercent.Clean
                    && DisclosureDeliveredBy.Clean
                    && DisclosureDeliveredByOtherMethod.Clean
                    && DisclosureDeliveredDate.Clean
                    && EstimatedChargeShownOnGFEIndicator.Clean
                    && ExpirationDate.Clean
                    && FederallySubsidizedAmount.Clean
                    && FederallySubsidizedAmountPercentage.Clean
                    && FeeReceived1.Clean
                    && FeeReceived2.Clean
                    && FeeReceivedByLender.Clean
                    && FeesReceiving.Clean
                    && FloridaApplicationFee.Clean
                    && FloridaOtherFee1.Clean
                    && FloridaOtherFee2.Clean
                    && FloridaOtherFeeTo1.Clean
                    && FloridaOtherFeeTo2.Clean
                    && FloridaOtherFeeTo3.Clean
                    && FloridaOtherFeeTo4.Clean
                    && FurtherFeesEarnedByMortgageBroker.Clean
                    && GFEFeeReceived1.Clean
                    && GFEFeeReceived2.Clean
                    && HUDBookletIndicator.Clean
                    && Id.Clean
                    && IndependentContractorIndicator.Clean
                    && IndexUsed.Clean
                    && InformationAboutTheIndexCanBeFound.Clean
                    && InLicensedNo.Clean
                    && InLicensedType.Clean
                    && IsEstimateIndicator.Clean
                    && KsUcccElectionIndicator.Clean
                    && KyHomeSolicationLoanIndicator.Clean
                    && LeaseAgreementDate.Clean
                    && LenderDate.Clean
                    && LenderName.Clean
                    && LenderPaid.Clean
                    && LenderPayAmount.Clean
                    && LenderPayIndicator.Clean
                    && LenderPayMaxPoint.Clean
                    && LenderPayPercent.Clean
                    && LenderPayPoint.Clean
                    && LenderPayUnknownIndicator.Clean
                    && LenderStatus.Clean
                    && LessorName.Clean
                    && LoanTermsFixedThroughDateofLoanClosingIndicator.Clean
                    && LockInFee.Clean
                    && MethodDescription.Clean
                    && MethodDetermine.Clean
                    && MortgageAgreementIndicator.Clean
                    && MtgBrokerLicense.Clean
                    && NameOfLicensee.Clean
                    && NewMoneyAmount.Clean
                    && NewYorkApplicationFee.Clean
                    && NewYorkAppraisalFee.Clean
                    && NewYorkCreditReportFee.Clean
                    && NewYorkFees.Clean
                    && NewYorkPrimaryLenders.Clean
                    && NewYorkProcessingFee.Clean
                    && NotRefundableAmount.Clean
                    && OfferRetailPriceIndicator.Clean
                    && OriginalAcquisitionCost.Clean
                    && OriginationFeeChargedAmount.Clean
                    && OriginationFeeChargedIndicator.Clean
                    && OriginationFeeDecreasesRate.Clean
                    && OriginationFeeIncreasesRate.Clean
                    && OriginationFeeInterestRateImpactedStatus.Clean
                    && OriginationFeePaidBy.Clean
                    && PaidByBorrower.Clean
                    && PaidByLender.Clean
                    && PaidByOther1.Clean
                    && PaidByOther2.Clean
                    && PaidByOtherDescription1.Clean
                    && PaidByOtherDescription2.Clean
                    && PreviousMortgageAmountOne.Clean
                    && PreviousMortgageAmountTwo.Clean
                    && PrintCertificationOfCosts.Clean
                    && PrintInterestRateReductionRider.Clean
                    && PrintMDDeliveryIndicator.Clean
                    && ProvidedBy.Clean
                    && QuestionContact.Clean
                    && QuestionContactPhone.Clean
                    && QuestionContactTollFree.Clean
                    && RateLockHonoredIndicator.Clean
                    && ReceivedBy.Clean
                    && RefinancingFee.Clean
                    && RefundableBy.Clean
                    && RefundableIndicator.Clean
                    && RefundableType.Clean
                    && RefundCondition1.Clean
                    && RefundCondition2.Clean
                    && RefundCondition3.Clean
                    && RefundCondition4.Clean
                    && RefundCondition5.Clean
                    && RefundCondition6.Clean
                    && RegulatorAddress.Clean
                    && RegulatorCity.Clean
                    && RegulatorMailingAddress.Clean
                    && RegulatorMailingCity.Clean
                    && RegulatorMailingState.Clean
                    && RegulatorMailingZipCode.Clean
                    && RegulatorPhone.Clean
                    && RegulatorState.Clean
                    && RegulatorTollFreePhone.Clean
                    && RegulatorWebAddress.Clean
                    && RegulatorZipCode.Clean
                    && ScheduleOfChargesEstimatedFinalIndicator.Clean
                    && ScRegulatoryAgencyType.Clean
                    && SelectDivisionFeesIndicator.Clean
                    && SelectPrimaryLenderIndicator.Clean
                    && SelectPrivateLenderIndicator.Clean
                    && ServicingFeeChargedAmount.Clean
                    && ServicingFeeChargedIndicator.Clean
                    && ServicingFeePaidBy.Clean
                    && ServicingFeePaidFrequence.Clean
                    && SignedByBorrowerIndicator.Clean
                    && SpecificARMIndicator.Clean
                    && SubmitToLenderIndicator.Clean
                    && TaxExemptAcquisitionCostCertificationAssessments.Clean
                    && TaxExemptAcquisitionCostCertificationOther.Clean
                    && TaxExemptAcquisitionCostCertificationOtherAmount.Clean
                    && TaxExemptAcquisitionCostCertificationOwnersTitleInsurance.Clean
                    && TaxExemptAcquisitionCostCertificationRealEstateCommission.Clean
                    && TaxExemptAcquisitionCostCertificationRepairsImprovements.Clean
                    && TaxExemptAcquisitionCostCertificationSurvey.Clean
                    && TaxExemptAcquisitionCostCertificationTotalAdjustments.Clean
                    && TermsChange.Clean
                    && TexasApplicationFee.Clean
                    && TexasAppraisalFee.Clean
                    && TexasCreditReportFee.Clean
                    && TexasOtherFee1.Clean
                    && TexasOtherFee2.Clean
                    && TexasOtherFeeContact1.Clean
                    && TexasOtherFeeContact2.Clean
                    && TexasProcessingFee.Clean
                    && ThirdPartyFee.Clean
                    && TotalFee.Clean
                    && TransferFeeChargedAmount.Clean
                    && TransferFeeChargedIndicator.Clean
                    && TransferFeePaidBy.Clean
                    && TxVeteransLandBoardIndicator.Clean
                    && TypeOfProperty.Clean
                    && UnderwritingContact.Clean
                    && UnderwritingFee.Clean
                    && YSPChargedAmount.Clean
                    && YSPChargedIndicator.Clean
                    && YSPDecreasesRate.Clean
                    && YSPIncreasesRate.Clean
                    && YSPInterestRateImpactedStatus.Clean
                    && YSPPaidBy.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AcceptedByBorrowerIndicator; v0.Clean = value; AcceptedByBorrowerIndicator = v0;
                var v1 = AcceptedDate; v1.Clean = value; AcceptedDate = v1;
                var v2 = ActingOtherDescription1; v2.Clean = value; ActingOtherDescription1 = v2;
                var v3 = ActingOtherDescription2; v3.Clean = value; ActingOtherDescription2 = v3;
                var v4 = ActingOthersIndicator; v4.Clean = value; ActingOthersIndicator = v4;
                var v5 = AdvFeeAgmtInEfctNumDay; v5.Clean = value; AdvFeeAgmtInEfctNumDay = v5;
                var v6 = AdvisoryCondition1; v6.Clean = value; AdvisoryCondition1 = v6;
                var v7 = AdvisoryCondition2; v7.Clean = value; AdvisoryCondition2 = v7;
                var v8 = AdvisoryCondition3; v8.Clean = value; AdvisoryCondition3 = v8;
                var v9 = AdvisoryCondition4; v9.Clean = value; AdvisoryCondition4 = v9;
                var v10 = AmendedAcquisitionCost; v10.Clean = value; AmendedAcquisitionCost = v10;
                var v11 = ApplicationDate; v11.Clean = value; ApplicationDate = v11;
                var v12 = AppraisalContact; v12.Clean = value; AppraisalContact = v12;
                var v13 = AppraisalDeposit; v13.Clean = value; AppraisalDeposit = v13;
                var v14 = Areas; v14.Clean = value; Areas = v14;
                var v15 = AsAttorneyIndicator; v15.Clean = value; AsAttorneyIndicator = v15;
                var v16 = AsRealBrokerIndicator; v16.Clean = value; AsRealBrokerIndicator = v16;
                var v17 = AttorneyForTheBuyerIndicator; v17.Clean = value; AttorneyForTheBuyerIndicator = v17;
                var v18 = AttorneyForTheLenderIndicator; v18.Clean = value; AttorneyForTheLenderIndicator = v18;
                var v19 = AttorneyForTheSellerIndicator; v19.Clean = value; AttorneyForTheSellerIndicator = v19;
                var v20 = AZCmplBlankSpcsDoc1BlankFldDesc1; v20.Clean = value; AZCmplBlankSpcsDoc1BlankFldDesc1 = v20;
                var v21 = AZCmplBlankSpcsDoc1BlankFldDesc2; v21.Clean = value; AZCmplBlankSpcsDoc1BlankFldDesc2 = v21;
                var v22 = AZCmplBlankSpcsDoc1BlankFldDesc3; v22.Clean = value; AZCmplBlankSpcsDoc1BlankFldDesc3 = v22;
                var v23 = AZCmplBlankSpcsDoc1Nm; v23.Clean = value; AZCmplBlankSpcsDoc1Nm = v23;
                var v24 = AZCmplBlankSpcsDoc2Nm; v24.Clean = value; AZCmplBlankSpcsDoc2Nm = v24;
                var v25 = AZCmplBlankSpcsDoc3Nm; v25.Clean = value; AZCmplBlankSpcsDoc3Nm = v25;
                var v26 = BasedOnOthersDescription; v26.Clean = value; BasedOnOthersDescription = v26;
                var v27 = BasedOnOthersIndicator; v27.Clean = value; BasedOnOthersIndicator = v27;
                var v28 = BasedOnWholesaleOptionsIndicator; v28.Clean = value; BasedOnWholesaleOptionsIndicator = v28;
                var v29 = BorrowerElectsEstablishEscrowAmount; v29.Clean = value; BorrowerElectsEstablishEscrowAmount = v29;
                var v30 = BorrowerElectsEstablishEscrowIndicator; v30.Clean = value; BorrowerElectsEstablishEscrowIndicator = v30;
                var v31 = BrokerageFeeAddition1; v31.Clean = value; BrokerageFeeAddition1 = v31;
                var v32 = BrokerageFeeAddition2; v32.Clean = value; BrokerageFeeAddition2 = v32;
                var v33 = BrokerageFeeAddition3; v33.Clean = value; BrokerageFeeAddition3 = v33;
                var v34 = BrokerageFeeAmount1; v34.Clean = value; BrokerageFeeAmount1 = v34;
                var v35 = BrokerageFeeAmount2; v35.Clean = value; BrokerageFeeAmount2 = v35;
                var v36 = BrokerageFeeAmount3; v36.Clean = value; BrokerageFeeAmount3 = v36;
                var v37 = BrokerageFeeDays; v37.Clean = value; BrokerageFeeDays = v37;
                var v38 = BrokerageFeePercent1; v38.Clean = value; BrokerageFeePercent1 = v38;
                var v39 = BrokerageFeePercent2; v39.Clean = value; BrokerageFeePercent2 = v39;
                var v40 = BrokerageFeePercent3; v40.Clean = value; BrokerageFeePercent3 = v40;
                var v41 = BrokerAuthorizedSigningRepName; v41.Clean = value; BrokerAuthorizedSigningRepName = v41;
                var v42 = BrokerAuthorizedSigningRepTitle; v42.Clean = value; BrokerAuthorizedSigningRepTitle = v42;
                var v43 = BrokerForTheSeller; v43.Clean = value; BrokerForTheSeller = v43;
                var v44 = BrokerLicense; v44.Clean = value; BrokerLicense = v44;
                var v45 = BrokerName; v45.Clean = value; BrokerName = v45;
                var v46 = BrokerPayAddition; v46.Clean = value; BrokerPayAddition = v46;
                var v47 = BrokerPayAmount; v47.Clean = value; BrokerPayAmount = v47;
                var v48 = BrokerPayIndicator; v48.Clean = value; BrokerPayIndicator = v48;
                var v49 = BrokerPayPercent; v49.Clean = value; BrokerPayPercent = v49;
                var v50 = CHARMBookletIndicator; v50.Clean = value; CHARMBookletIndicator = v50;
                var v51 = CheckPayableTo; v51.Clean = value; CheckPayableTo = v51;
                var v52 = CommitmentAmount; v52.Clean = value; CommitmentAmount = v52;
                var v53 = CommitmentCondition1; v53.Clean = value; CommitmentCondition1 = v53;
                var v54 = CommitmentCondition2; v54.Clean = value; CommitmentCondition2 = v54;
                var v55 = CommitmentFee; v55.Clean = value; CommitmentFee = v55;
                var v56 = CommitmentPercent; v56.Clean = value; CommitmentPercent = v56;
                var v57 = CompensationAddition; v57.Clean = value; CompensationAddition = v57;
                var v58 = CompensationPercent; v58.Clean = value; CompensationPercent = v58;
                var v59 = CreditDeposit; v59.Clean = value; CreditDeposit = v59;
                var v60 = CreditIsUsedForReason; v60.Clean = value; CreditIsUsedForReason = v60;
                var v61 = CreditReportContact; v61.Clean = value; CreditReportContact = v61;
                var v62 = DaysBeforeClosing; v62.Clean = value; DaysBeforeClosing = v62;
                var v63 = DepositReceipt; v63.Clean = value; DepositReceipt = v63;
                var v64 = DepositRefundableIndicator; v64.Clean = value; DepositRefundableIndicator = v64;
                var v65 = DirectContact; v65.Clean = value; DirectContact = v65;
                var v66 = DirectPayAmount; v66.Clean = value; DirectPayAmount = v66;
                var v67 = DirectPayClosing; v67.Clean = value; DirectPayClosing = v67;
                var v68 = DirectPayCommitment; v68.Clean = value; DirectPayCommitment = v68;
                var v69 = DirectPayIndicator; v69.Clean = value; DirectPayIndicator = v69;
                var v70 = DirectPayPercent; v70.Clean = value; DirectPayPercent = v70;
                var v71 = DisclosureDeliveredBy; v71.Clean = value; DisclosureDeliveredBy = v71;
                var v72 = DisclosureDeliveredByOtherMethod; v72.Clean = value; DisclosureDeliveredByOtherMethod = v72;
                var v73 = DisclosureDeliveredDate; v73.Clean = value; DisclosureDeliveredDate = v73;
                var v74 = EstimatedChargeShownOnGFEIndicator; v74.Clean = value; EstimatedChargeShownOnGFEIndicator = v74;
                var v75 = ExpirationDate; v75.Clean = value; ExpirationDate = v75;
                var v76 = FederallySubsidizedAmount; v76.Clean = value; FederallySubsidizedAmount = v76;
                var v77 = FederallySubsidizedAmountPercentage; v77.Clean = value; FederallySubsidizedAmountPercentage = v77;
                var v78 = FeeReceived1; v78.Clean = value; FeeReceived1 = v78;
                var v79 = FeeReceived2; v79.Clean = value; FeeReceived2 = v79;
                var v80 = FeeReceivedByLender; v80.Clean = value; FeeReceivedByLender = v80;
                var v81 = FeesReceiving; v81.Clean = value; FeesReceiving = v81;
                var v82 = FloridaApplicationFee; v82.Clean = value; FloridaApplicationFee = v82;
                var v83 = FloridaOtherFee1; v83.Clean = value; FloridaOtherFee1 = v83;
                var v84 = FloridaOtherFee2; v84.Clean = value; FloridaOtherFee2 = v84;
                var v85 = FloridaOtherFeeTo1; v85.Clean = value; FloridaOtherFeeTo1 = v85;
                var v86 = FloridaOtherFeeTo2; v86.Clean = value; FloridaOtherFeeTo2 = v86;
                var v87 = FloridaOtherFeeTo3; v87.Clean = value; FloridaOtherFeeTo3 = v87;
                var v88 = FloridaOtherFeeTo4; v88.Clean = value; FloridaOtherFeeTo4 = v88;
                var v89 = FurtherFeesEarnedByMortgageBroker; v89.Clean = value; FurtherFeesEarnedByMortgageBroker = v89;
                var v90 = GFEFeeReceived1; v90.Clean = value; GFEFeeReceived1 = v90;
                var v91 = GFEFeeReceived2; v91.Clean = value; GFEFeeReceived2 = v91;
                var v92 = HUDBookletIndicator; v92.Clean = value; HUDBookletIndicator = v92;
                var v93 = Id; v93.Clean = value; Id = v93;
                var v94 = IndependentContractorIndicator; v94.Clean = value; IndependentContractorIndicator = v94;
                var v95 = IndexUsed; v95.Clean = value; IndexUsed = v95;
                var v96 = InformationAboutTheIndexCanBeFound; v96.Clean = value; InformationAboutTheIndexCanBeFound = v96;
                var v97 = InLicensedNo; v97.Clean = value; InLicensedNo = v97;
                var v98 = InLicensedType; v98.Clean = value; InLicensedType = v98;
                var v99 = IsEstimateIndicator; v99.Clean = value; IsEstimateIndicator = v99;
                var v100 = KsUcccElectionIndicator; v100.Clean = value; KsUcccElectionIndicator = v100;
                var v101 = KyHomeSolicationLoanIndicator; v101.Clean = value; KyHomeSolicationLoanIndicator = v101;
                var v102 = LeaseAgreementDate; v102.Clean = value; LeaseAgreementDate = v102;
                var v103 = LenderDate; v103.Clean = value; LenderDate = v103;
                var v104 = LenderName; v104.Clean = value; LenderName = v104;
                var v105 = LenderPaid; v105.Clean = value; LenderPaid = v105;
                var v106 = LenderPayAmount; v106.Clean = value; LenderPayAmount = v106;
                var v107 = LenderPayIndicator; v107.Clean = value; LenderPayIndicator = v107;
                var v108 = LenderPayMaxPoint; v108.Clean = value; LenderPayMaxPoint = v108;
                var v109 = LenderPayPercent; v109.Clean = value; LenderPayPercent = v109;
                var v110 = LenderPayPoint; v110.Clean = value; LenderPayPoint = v110;
                var v111 = LenderPayUnknownIndicator; v111.Clean = value; LenderPayUnknownIndicator = v111;
                var v112 = LenderStatus; v112.Clean = value; LenderStatus = v112;
                var v113 = LessorName; v113.Clean = value; LessorName = v113;
                var v114 = LoanTermsFixedThroughDateofLoanClosingIndicator; v114.Clean = value; LoanTermsFixedThroughDateofLoanClosingIndicator = v114;
                var v115 = LockInFee; v115.Clean = value; LockInFee = v115;
                var v116 = MethodDescription; v116.Clean = value; MethodDescription = v116;
                var v117 = MethodDetermine; v117.Clean = value; MethodDetermine = v117;
                var v118 = MortgageAgreementIndicator; v118.Clean = value; MortgageAgreementIndicator = v118;
                var v119 = MtgBrokerLicense; v119.Clean = value; MtgBrokerLicense = v119;
                var v120 = NameOfLicensee; v120.Clean = value; NameOfLicensee = v120;
                var v121 = NewMoneyAmount; v121.Clean = value; NewMoneyAmount = v121;
                var v122 = NewYorkApplicationFee; v122.Clean = value; NewYorkApplicationFee = v122;
                var v123 = NewYorkAppraisalFee; v123.Clean = value; NewYorkAppraisalFee = v123;
                var v124 = NewYorkCreditReportFee; v124.Clean = value; NewYorkCreditReportFee = v124;
                var v125 = NewYorkFees; v125.Clean = value; NewYorkFees = v125;
                var v126 = NewYorkPrimaryLenders; v126.Clean = value; NewYorkPrimaryLenders = v126;
                var v127 = NewYorkProcessingFee; v127.Clean = value; NewYorkProcessingFee = v127;
                var v128 = NotRefundableAmount; v128.Clean = value; NotRefundableAmount = v128;
                var v129 = OfferRetailPriceIndicator; v129.Clean = value; OfferRetailPriceIndicator = v129;
                var v130 = OriginalAcquisitionCost; v130.Clean = value; OriginalAcquisitionCost = v130;
                var v131 = OriginationFeeChargedAmount; v131.Clean = value; OriginationFeeChargedAmount = v131;
                var v132 = OriginationFeeChargedIndicator; v132.Clean = value; OriginationFeeChargedIndicator = v132;
                var v133 = OriginationFeeDecreasesRate; v133.Clean = value; OriginationFeeDecreasesRate = v133;
                var v134 = OriginationFeeIncreasesRate; v134.Clean = value; OriginationFeeIncreasesRate = v134;
                var v135 = OriginationFeeInterestRateImpactedStatus; v135.Clean = value; OriginationFeeInterestRateImpactedStatus = v135;
                var v136 = OriginationFeePaidBy; v136.Clean = value; OriginationFeePaidBy = v136;
                var v137 = PaidByBorrower; v137.Clean = value; PaidByBorrower = v137;
                var v138 = PaidByLender; v138.Clean = value; PaidByLender = v138;
                var v139 = PaidByOther1; v139.Clean = value; PaidByOther1 = v139;
                var v140 = PaidByOther2; v140.Clean = value; PaidByOther2 = v140;
                var v141 = PaidByOtherDescription1; v141.Clean = value; PaidByOtherDescription1 = v141;
                var v142 = PaidByOtherDescription2; v142.Clean = value; PaidByOtherDescription2 = v142;
                var v143 = PreviousMortgageAmountOne; v143.Clean = value; PreviousMortgageAmountOne = v143;
                var v144 = PreviousMortgageAmountTwo; v144.Clean = value; PreviousMortgageAmountTwo = v144;
                var v145 = PrintCertificationOfCosts; v145.Clean = value; PrintCertificationOfCosts = v145;
                var v146 = PrintInterestRateReductionRider; v146.Clean = value; PrintInterestRateReductionRider = v146;
                var v147 = PrintMDDeliveryIndicator; v147.Clean = value; PrintMDDeliveryIndicator = v147;
                var v148 = ProvidedBy; v148.Clean = value; ProvidedBy = v148;
                var v149 = QuestionContact; v149.Clean = value; QuestionContact = v149;
                var v150 = QuestionContactPhone; v150.Clean = value; QuestionContactPhone = v150;
                var v151 = QuestionContactTollFree; v151.Clean = value; QuestionContactTollFree = v151;
                var v152 = RateLockHonoredIndicator; v152.Clean = value; RateLockHonoredIndicator = v152;
                var v153 = ReceivedBy; v153.Clean = value; ReceivedBy = v153;
                var v154 = RefinancingFee; v154.Clean = value; RefinancingFee = v154;
                var v155 = RefundableBy; v155.Clean = value; RefundableBy = v155;
                var v156 = RefundableIndicator; v156.Clean = value; RefundableIndicator = v156;
                var v157 = RefundableType; v157.Clean = value; RefundableType = v157;
                var v158 = RefundCondition1; v158.Clean = value; RefundCondition1 = v158;
                var v159 = RefundCondition2; v159.Clean = value; RefundCondition2 = v159;
                var v160 = RefundCondition3; v160.Clean = value; RefundCondition3 = v160;
                var v161 = RefundCondition4; v161.Clean = value; RefundCondition4 = v161;
                var v162 = RefundCondition5; v162.Clean = value; RefundCondition5 = v162;
                var v163 = RefundCondition6; v163.Clean = value; RefundCondition6 = v163;
                var v164 = RegulatorAddress; v164.Clean = value; RegulatorAddress = v164;
                var v165 = RegulatorCity; v165.Clean = value; RegulatorCity = v165;
                var v166 = RegulatorMailingAddress; v166.Clean = value; RegulatorMailingAddress = v166;
                var v167 = RegulatorMailingCity; v167.Clean = value; RegulatorMailingCity = v167;
                var v168 = RegulatorMailingState; v168.Clean = value; RegulatorMailingState = v168;
                var v169 = RegulatorMailingZipCode; v169.Clean = value; RegulatorMailingZipCode = v169;
                var v170 = RegulatorPhone; v170.Clean = value; RegulatorPhone = v170;
                var v171 = RegulatorState; v171.Clean = value; RegulatorState = v171;
                var v172 = RegulatorTollFreePhone; v172.Clean = value; RegulatorTollFreePhone = v172;
                var v173 = RegulatorWebAddress; v173.Clean = value; RegulatorWebAddress = v173;
                var v174 = RegulatorZipCode; v174.Clean = value; RegulatorZipCode = v174;
                var v175 = ScheduleOfChargesEstimatedFinalIndicator; v175.Clean = value; ScheduleOfChargesEstimatedFinalIndicator = v175;
                var v176 = ScRegulatoryAgencyType; v176.Clean = value; ScRegulatoryAgencyType = v176;
                var v177 = SelectDivisionFeesIndicator; v177.Clean = value; SelectDivisionFeesIndicator = v177;
                var v178 = SelectPrimaryLenderIndicator; v178.Clean = value; SelectPrimaryLenderIndicator = v178;
                var v179 = SelectPrivateLenderIndicator; v179.Clean = value; SelectPrivateLenderIndicator = v179;
                var v180 = ServicingFeeChargedAmount; v180.Clean = value; ServicingFeeChargedAmount = v180;
                var v181 = ServicingFeeChargedIndicator; v181.Clean = value; ServicingFeeChargedIndicator = v181;
                var v182 = ServicingFeePaidBy; v182.Clean = value; ServicingFeePaidBy = v182;
                var v183 = ServicingFeePaidFrequence; v183.Clean = value; ServicingFeePaidFrequence = v183;
                var v184 = SignedByBorrowerIndicator; v184.Clean = value; SignedByBorrowerIndicator = v184;
                var v185 = SpecificARMIndicator; v185.Clean = value; SpecificARMIndicator = v185;
                var v186 = SubmitToLenderIndicator; v186.Clean = value; SubmitToLenderIndicator = v186;
                var v187 = TaxExemptAcquisitionCostCertificationAssessments; v187.Clean = value; TaxExemptAcquisitionCostCertificationAssessments = v187;
                var v188 = TaxExemptAcquisitionCostCertificationOther; v188.Clean = value; TaxExemptAcquisitionCostCertificationOther = v188;
                var v189 = TaxExemptAcquisitionCostCertificationOtherAmount; v189.Clean = value; TaxExemptAcquisitionCostCertificationOtherAmount = v189;
                var v190 = TaxExemptAcquisitionCostCertificationOwnersTitleInsurance; v190.Clean = value; TaxExemptAcquisitionCostCertificationOwnersTitleInsurance = v190;
                var v191 = TaxExemptAcquisitionCostCertificationRealEstateCommission; v191.Clean = value; TaxExemptAcquisitionCostCertificationRealEstateCommission = v191;
                var v192 = TaxExemptAcquisitionCostCertificationRepairsImprovements; v192.Clean = value; TaxExemptAcquisitionCostCertificationRepairsImprovements = v192;
                var v193 = TaxExemptAcquisitionCostCertificationSurvey; v193.Clean = value; TaxExemptAcquisitionCostCertificationSurvey = v193;
                var v194 = TaxExemptAcquisitionCostCertificationTotalAdjustments; v194.Clean = value; TaxExemptAcquisitionCostCertificationTotalAdjustments = v194;
                var v195 = TermsChange; v195.Clean = value; TermsChange = v195;
                var v196 = TexasApplicationFee; v196.Clean = value; TexasApplicationFee = v196;
                var v197 = TexasAppraisalFee; v197.Clean = value; TexasAppraisalFee = v197;
                var v198 = TexasCreditReportFee; v198.Clean = value; TexasCreditReportFee = v198;
                var v199 = TexasOtherFee1; v199.Clean = value; TexasOtherFee1 = v199;
                var v200 = TexasOtherFee2; v200.Clean = value; TexasOtherFee2 = v200;
                var v201 = TexasOtherFeeContact1; v201.Clean = value; TexasOtherFeeContact1 = v201;
                var v202 = TexasOtherFeeContact2; v202.Clean = value; TexasOtherFeeContact2 = v202;
                var v203 = TexasProcessingFee; v203.Clean = value; TexasProcessingFee = v203;
                var v204 = ThirdPartyFee; v204.Clean = value; ThirdPartyFee = v204;
                var v205 = TotalFee; v205.Clean = value; TotalFee = v205;
                var v206 = TransferFeeChargedAmount; v206.Clean = value; TransferFeeChargedAmount = v206;
                var v207 = TransferFeeChargedIndicator; v207.Clean = value; TransferFeeChargedIndicator = v207;
                var v208 = TransferFeePaidBy; v208.Clean = value; TransferFeePaidBy = v208;
                var v209 = TxVeteransLandBoardIndicator; v209.Clean = value; TxVeteransLandBoardIndicator = v209;
                var v210 = TypeOfProperty; v210.Clean = value; TypeOfProperty = v210;
                var v211 = UnderwritingContact; v211.Clean = value; UnderwritingContact = v211;
                var v212 = UnderwritingFee; v212.Clean = value; UnderwritingFee = v212;
                var v213 = YSPChargedAmount; v213.Clean = value; YSPChargedAmount = v213;
                var v214 = YSPChargedIndicator; v214.Clean = value; YSPChargedIndicator = v214;
                var v215 = YSPDecreasesRate; v215.Clean = value; YSPDecreasesRate = v215;
                var v216 = YSPIncreasesRate; v216.Clean = value; YSPIncreasesRate = v216;
                var v217 = YSPInterestRateImpactedStatus; v217.Clean = value; YSPInterestRateImpactedStatus = v217;
                var v218 = YSPPaidBy; v218.Clean = value; YSPPaidBy = v218;
                _settingClean = 0;
            }
        }
    }
}