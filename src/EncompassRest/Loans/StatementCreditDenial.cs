using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class StatementCreditDenial
    {
        public Value<bool?> AdditionalStatement { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalStatement() => !AdditionalStatement.Clean;
        public Value<bool?> Bankruptcy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBankruptcy() => !Bankruptcy.Clean;
        public Value<bool?> CollateralNotSufficient { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCollateralNotSufficient() => !CollateralNotSufficient.Clean;
        public Value<bool?> CreditApplicationIncomplete { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditApplicationIncomplete() => !CreditApplicationIncomplete.Clean;
        public Value<bool?> CreditReportObtainedFromConsumerReportingAgency { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditReportObtainedFromConsumerReportingAgency() => !CreditReportObtainedFromConsumerReportingAgency.Clean;
        public Value<bool?> DelinquentCreditObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDelinquentCreditObligations() => !DelinquentCreditObligations.Clean;
        public Value<DateTime?> DenialDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDenialDate() => !DenialDate.Clean;
        public Value<string> DenialDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDenialDescription() => !DenialDescription.Clean;
        public Value<DateTime?> DenialMailedOn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDenialMailedOn() => !DenialMailedOn.Clean;
        public Value<bool?> DenialOther1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDenialOther1() => !DenialOther1.Clean;
        public Value<bool?> DenialOther2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDenialOther2() => !DenialOther2.Clean;
        public Value<string> DenialOtherDesc1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDenialOtherDesc1() => !DenialOtherDesc1.Clean;
        public Value<string> DenialOtherDesc2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDenialOtherDesc2() => !DenialOtherDesc2.Clean;
        public Value<string> DeniedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeniedBy() => !DeniedBy.Clean;
        public Value<bool?> DeniedByFhlmc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeniedByFhlmc() => !DeniedByFhlmc.Clean;
        public Value<bool?> DeniedByFnma { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeniedByFnma() => !DeniedByFnma.Clean;
        public Value<bool?> DeniedByHud { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeniedByHud() => !DeniedByHud.Clean;
        public Value<bool?> DeniedByOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeniedByOther() => !DeniedByOther.Clean;
        public Value<bool?> DeniedByVa { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeniedByVa() => !DeniedByVa.Clean;
        public Value<string> DescriptionofAccount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescriptionofAccount1() => !DescriptionofAccount1.Clean;
        public Value<string> DescriptionofAccount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescriptionofAccount2() => !DescriptionofAccount2.Clean;
        public Value<string> DescriptionofAccount3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescriptionofAccount3() => !DescriptionofAccount3.Clean;
        public Value<string> DescriptionofActionTaken1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescriptionofActionTaken1() => !DescriptionofActionTaken1.Clean;
        public Value<string> DescriptionofActionTaken2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescriptionofActionTaken2() => !DescriptionofActionTaken2.Clean;
        public Value<string> EcoaAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEcoaAddress() => !EcoaAddress.Clean;
        public Value<string> EcoaAddress2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEcoaAddress2() => !EcoaAddress2.Clean;
        public Value<string> EcoaCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEcoaCity() => !EcoaCity.Clean;
        public Value<string> EcoaName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEcoaName() => !EcoaName.Clean;
        public Value<string> EcoaPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEcoaPhone() => !EcoaPhone.Clean;
        public Value<string> EcoaPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEcoaPostalCode() => !EcoaPostalCode.Clean;
        public Value<string> EcoaState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEcoaState() => !EcoaState.Clean;
        public Value<bool?> ExcessiveObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExcessiveObligations() => !ExcessiveObligations.Clean;
        public Value<bool?> Garnishment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGarnishment() => !Garnishment.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> InadequateCollateral { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInadequateCollateral() => !InadequateCollateral.Clean;
        public Value<bool?> InformationFromAConsumerReportingAgency { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationFromAConsumerReportingAgency() => !InformationFromAConsumerReportingAgency.Clean;
        public Value<bool?> InformationObtainedFromOutsideSource { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationObtainedFromOutsideSource() => !InformationObtainedFromOutsideSource.Clean;
        public Value<bool?> InformationObtainedInReportFromCra { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationObtainedInReportFromCra() => !InformationObtainedInReportFromCra.Clean;
        public Value<bool?> InsufficientCreditFile { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsufficientCreditFile() => !InsufficientCreditFile.Clean;
        public Value<bool?> InsufficientCreditReference { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsufficientCreditReference() => !InsufficientCreditReference.Clean;
        public Value<bool?> InsufficientData { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsufficientData() => !InsufficientData.Clean;
        public Value<bool?> InsufficientFundsToCloseLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsufficientFundsToCloseLoan() => !InsufficientFundsToCloseLoan.Clean;
        public Value<bool?> InsufficientIncomeForTotalObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsufficientIncomeForTotalObligations() => !InsufficientIncomeForTotalObligations.Clean;
        public Value<bool?> InsufficientStabilityOfIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsufficientStabilityOfIncome() => !InsufficientStabilityOfIncome.Clean;
        public Value<bool?> LackOfCashReserves { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLackOfCashReserves() => !LackOfCashReserves.Clean;
        public Value<string> LenderInvestorAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderInvestorAddress() => !LenderInvestorAddress.Clean;
        public Value<string> LenderInvestorCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderInvestorCity() => !LenderInvestorCity.Clean;
        public Value<string> LenderInvestorName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderInvestorName() => !LenderInvestorName.Clean;
        public Value<string> LenderInvestorPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderInvestorPhone() => !LenderInvestorPhone.Clean;
        public Value<string> LenderInvestorPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderInvestorPostalCode() => !LenderInvestorPostalCode.Clean;
        public Value<string> LenderInvestorState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderInvestorState() => !LenderInvestorState.Clean;
        public Value<bool?> LengthOfEmployment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLengthOfEmployment() => !LengthOfEmployment.Clean;
        public Value<bool?> NoCreditFile { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoCreditFile() => !NoCreditFile.Clean;
        public Value<bool?> NumberRecentInquiriesCredit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberRecentInquiriesCredit() => !NumberRecentInquiriesCredit.Clean;
        public Value<string> OtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherDescription() => !OtherDescription.Clean;
        public Value<bool?> PoorCreditPerformance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoorCreditPerformance() => !PoorCreditPerformance.Clean;
        public Value<bool?> TemporaryOrIrregularEmployment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTemporaryOrIrregularEmployment() => !TemporaryOrIrregularEmployment.Clean;
        public Value<bool?> TemporaryResidence { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTemporaryResidence() => !TemporaryResidence.Clean;
        public Value<bool?> ToShortPeriodOfResidence { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeToShortPeriodOfResidence() => !ToShortPeriodOfResidence.Clean;
        public Value<bool?> UnableToVerifyCreditReferences { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnableToVerifyCreditReferences() => !UnableToVerifyCreditReferences.Clean;
        public Value<bool?> UnableToVerifyEmployment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnableToVerifyEmployment() => !UnableToVerifyEmployment.Clean;
        public Value<bool?> UnableToVerifyIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnableToVerifyIncome() => !UnableToVerifyIncome.Clean;
        public Value<bool?> UnableToVerifyResidence { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnableToVerifyResidence() => !UnableToVerifyResidence.Clean;
        public Value<bool?> UnacceptableAppraisal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnacceptableAppraisal() => !UnacceptableAppraisal.Clean;
        public Value<bool?> UnacceptableCreditReferencesProvided { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnacceptableCreditReferencesProvided() => !UnacceptableCreditReferencesProvided.Clean;
        public Value<bool?> UnacceptableLeaseholdEstate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnacceptableLeaseholdEstate() => !UnacceptableLeaseholdEstate.Clean;
        public Value<bool?> UnacceptablePaymentRecordOnPreviousMtg { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnacceptablePaymentRecordOnPreviousMtg() => !UnacceptablePaymentRecordOnPreviousMtg.Clean;
        public Value<bool?> UnacceptableProperty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnacceptableProperty() => !UnacceptableProperty.Clean;
        public Value<bool?> WeDoNotGrantCredit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWeDoNotGrantCredit() => !WeDoNotGrantCredit.Clean;
        public Value<bool?> WithdrawnByApplicant { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWithdrawnByApplicant() => !WithdrawnByApplicant.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdditionalStatement.Clean
                    && Bankruptcy.Clean
                    && CollateralNotSufficient.Clean
                    && CreditApplicationIncomplete.Clean
                    && CreditReportObtainedFromConsumerReportingAgency.Clean
                    && DelinquentCreditObligations.Clean
                    && DenialDate.Clean
                    && DenialDescription.Clean
                    && DenialMailedOn.Clean
                    && DenialOther1.Clean
                    && DenialOther2.Clean
                    && DenialOtherDesc1.Clean
                    && DenialOtherDesc2.Clean
                    && DeniedBy.Clean
                    && DeniedByFhlmc.Clean
                    && DeniedByFnma.Clean
                    && DeniedByHud.Clean
                    && DeniedByOther.Clean
                    && DeniedByVa.Clean
                    && DescriptionofAccount1.Clean
                    && DescriptionofAccount2.Clean
                    && DescriptionofAccount3.Clean
                    && DescriptionofActionTaken1.Clean
                    && DescriptionofActionTaken2.Clean
                    && EcoaAddress.Clean
                    && EcoaAddress2.Clean
                    && EcoaCity.Clean
                    && EcoaName.Clean
                    && EcoaPhone.Clean
                    && EcoaPostalCode.Clean
                    && EcoaState.Clean
                    && ExcessiveObligations.Clean
                    && Garnishment.Clean
                    && Id.Clean
                    && InadequateCollateral.Clean
                    && InformationFromAConsumerReportingAgency.Clean
                    && InformationObtainedFromOutsideSource.Clean
                    && InformationObtainedInReportFromCra.Clean
                    && InsufficientCreditFile.Clean
                    && InsufficientCreditReference.Clean
                    && InsufficientData.Clean
                    && InsufficientFundsToCloseLoan.Clean
                    && InsufficientIncomeForTotalObligations.Clean
                    && InsufficientStabilityOfIncome.Clean
                    && LackOfCashReserves.Clean
                    && LenderInvestorAddress.Clean
                    && LenderInvestorCity.Clean
                    && LenderInvestorName.Clean
                    && LenderInvestorPhone.Clean
                    && LenderInvestorPostalCode.Clean
                    && LenderInvestorState.Clean
                    && LengthOfEmployment.Clean
                    && NoCreditFile.Clean
                    && NumberRecentInquiriesCredit.Clean
                    && OtherDescription.Clean
                    && PoorCreditPerformance.Clean
                    && TemporaryOrIrregularEmployment.Clean
                    && TemporaryResidence.Clean
                    && ToShortPeriodOfResidence.Clean
                    && UnableToVerifyCreditReferences.Clean
                    && UnableToVerifyEmployment.Clean
                    && UnableToVerifyIncome.Clean
                    && UnableToVerifyResidence.Clean
                    && UnacceptableAppraisal.Clean
                    && UnacceptableCreditReferencesProvided.Clean
                    && UnacceptableLeaseholdEstate.Clean
                    && UnacceptablePaymentRecordOnPreviousMtg.Clean
                    && UnacceptableProperty.Clean
                    && WeDoNotGrantCredit.Clean
                    && WithdrawnByApplicant.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AdditionalStatement; v0.Clean = value; AdditionalStatement = v0;
                var v1 = Bankruptcy; v1.Clean = value; Bankruptcy = v1;
                var v2 = CollateralNotSufficient; v2.Clean = value; CollateralNotSufficient = v2;
                var v3 = CreditApplicationIncomplete; v3.Clean = value; CreditApplicationIncomplete = v3;
                var v4 = CreditReportObtainedFromConsumerReportingAgency; v4.Clean = value; CreditReportObtainedFromConsumerReportingAgency = v4;
                var v5 = DelinquentCreditObligations; v5.Clean = value; DelinquentCreditObligations = v5;
                var v6 = DenialDate; v6.Clean = value; DenialDate = v6;
                var v7 = DenialDescription; v7.Clean = value; DenialDescription = v7;
                var v8 = DenialMailedOn; v8.Clean = value; DenialMailedOn = v8;
                var v9 = DenialOther1; v9.Clean = value; DenialOther1 = v9;
                var v10 = DenialOther2; v10.Clean = value; DenialOther2 = v10;
                var v11 = DenialOtherDesc1; v11.Clean = value; DenialOtherDesc1 = v11;
                var v12 = DenialOtherDesc2; v12.Clean = value; DenialOtherDesc2 = v12;
                var v13 = DeniedBy; v13.Clean = value; DeniedBy = v13;
                var v14 = DeniedByFhlmc; v14.Clean = value; DeniedByFhlmc = v14;
                var v15 = DeniedByFnma; v15.Clean = value; DeniedByFnma = v15;
                var v16 = DeniedByHud; v16.Clean = value; DeniedByHud = v16;
                var v17 = DeniedByOther; v17.Clean = value; DeniedByOther = v17;
                var v18 = DeniedByVa; v18.Clean = value; DeniedByVa = v18;
                var v19 = DescriptionofAccount1; v19.Clean = value; DescriptionofAccount1 = v19;
                var v20 = DescriptionofAccount2; v20.Clean = value; DescriptionofAccount2 = v20;
                var v21 = DescriptionofAccount3; v21.Clean = value; DescriptionofAccount3 = v21;
                var v22 = DescriptionofActionTaken1; v22.Clean = value; DescriptionofActionTaken1 = v22;
                var v23 = DescriptionofActionTaken2; v23.Clean = value; DescriptionofActionTaken2 = v23;
                var v24 = EcoaAddress; v24.Clean = value; EcoaAddress = v24;
                var v25 = EcoaAddress2; v25.Clean = value; EcoaAddress2 = v25;
                var v26 = EcoaCity; v26.Clean = value; EcoaCity = v26;
                var v27 = EcoaName; v27.Clean = value; EcoaName = v27;
                var v28 = EcoaPhone; v28.Clean = value; EcoaPhone = v28;
                var v29 = EcoaPostalCode; v29.Clean = value; EcoaPostalCode = v29;
                var v30 = EcoaState; v30.Clean = value; EcoaState = v30;
                var v31 = ExcessiveObligations; v31.Clean = value; ExcessiveObligations = v31;
                var v32 = Garnishment; v32.Clean = value; Garnishment = v32;
                var v33 = Id; v33.Clean = value; Id = v33;
                var v34 = InadequateCollateral; v34.Clean = value; InadequateCollateral = v34;
                var v35 = InformationFromAConsumerReportingAgency; v35.Clean = value; InformationFromAConsumerReportingAgency = v35;
                var v36 = InformationObtainedFromOutsideSource; v36.Clean = value; InformationObtainedFromOutsideSource = v36;
                var v37 = InformationObtainedInReportFromCra; v37.Clean = value; InformationObtainedInReportFromCra = v37;
                var v38 = InsufficientCreditFile; v38.Clean = value; InsufficientCreditFile = v38;
                var v39 = InsufficientCreditReference; v39.Clean = value; InsufficientCreditReference = v39;
                var v40 = InsufficientData; v40.Clean = value; InsufficientData = v40;
                var v41 = InsufficientFundsToCloseLoan; v41.Clean = value; InsufficientFundsToCloseLoan = v41;
                var v42 = InsufficientIncomeForTotalObligations; v42.Clean = value; InsufficientIncomeForTotalObligations = v42;
                var v43 = InsufficientStabilityOfIncome; v43.Clean = value; InsufficientStabilityOfIncome = v43;
                var v44 = LackOfCashReserves; v44.Clean = value; LackOfCashReserves = v44;
                var v45 = LenderInvestorAddress; v45.Clean = value; LenderInvestorAddress = v45;
                var v46 = LenderInvestorCity; v46.Clean = value; LenderInvestorCity = v46;
                var v47 = LenderInvestorName; v47.Clean = value; LenderInvestorName = v47;
                var v48 = LenderInvestorPhone; v48.Clean = value; LenderInvestorPhone = v48;
                var v49 = LenderInvestorPostalCode; v49.Clean = value; LenderInvestorPostalCode = v49;
                var v50 = LenderInvestorState; v50.Clean = value; LenderInvestorState = v50;
                var v51 = LengthOfEmployment; v51.Clean = value; LengthOfEmployment = v51;
                var v52 = NoCreditFile; v52.Clean = value; NoCreditFile = v52;
                var v53 = NumberRecentInquiriesCredit; v53.Clean = value; NumberRecentInquiriesCredit = v53;
                var v54 = OtherDescription; v54.Clean = value; OtherDescription = v54;
                var v55 = PoorCreditPerformance; v55.Clean = value; PoorCreditPerformance = v55;
                var v56 = TemporaryOrIrregularEmployment; v56.Clean = value; TemporaryOrIrregularEmployment = v56;
                var v57 = TemporaryResidence; v57.Clean = value; TemporaryResidence = v57;
                var v58 = ToShortPeriodOfResidence; v58.Clean = value; ToShortPeriodOfResidence = v58;
                var v59 = UnableToVerifyCreditReferences; v59.Clean = value; UnableToVerifyCreditReferences = v59;
                var v60 = UnableToVerifyEmployment; v60.Clean = value; UnableToVerifyEmployment = v60;
                var v61 = UnableToVerifyIncome; v61.Clean = value; UnableToVerifyIncome = v61;
                var v62 = UnableToVerifyResidence; v62.Clean = value; UnableToVerifyResidence = v62;
                var v63 = UnacceptableAppraisal; v63.Clean = value; UnacceptableAppraisal = v63;
                var v64 = UnacceptableCreditReferencesProvided; v64.Clean = value; UnacceptableCreditReferencesProvided = v64;
                var v65 = UnacceptableLeaseholdEstate; v65.Clean = value; UnacceptableLeaseholdEstate = v65;
                var v66 = UnacceptablePaymentRecordOnPreviousMtg; v66.Clean = value; UnacceptablePaymentRecordOnPreviousMtg = v66;
                var v67 = UnacceptableProperty; v67.Clean = value; UnacceptableProperty = v67;
                var v68 = WeDoNotGrantCredit; v68.Clean = value; WeDoNotGrantCredit = v68;
                var v69 = WithdrawnByApplicant; v69.Clean = value; WithdrawnByApplicant = v69;
                _settingClean = 0;
            }
        }
    }
}