using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureNotices
    {
        public Value<bool?> AntiCoercionStatementIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAntiCoercionStatementIndicator() => !AntiCoercionStatementIndicator.Clean;
        public Value<string> CommitmentIssuedByAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentIssuedByAddress() => !CommitmentIssuedByAddress.Clean;
        public Value<string> CommitmentIssuedByCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentIssuedByCity() => !CommitmentIssuedByCity.Clean;
        public Value<string> CommitmentIssuedByContactName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentIssuedByContactName() => !CommitmentIssuedByContactName.Clean;
        public Value<string> CommitmentIssuedByName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentIssuedByName() => !CommitmentIssuedByName.Clean;
        public Value<string> CommitmentIssuedByPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentIssuedByPhone() => !CommitmentIssuedByPhone.Clean;
        public Value<string> CommitmentIssuedByPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentIssuedByPostalCode() => !CommitmentIssuedByPostalCode.Clean;
        public Value<string> CommitmentIssuedByState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentIssuedByState() => !CommitmentIssuedByState.Clean;
        public Value<string> ConsumerHandbookOnAdjustableRateMortgages { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConsumerHandbookOnAdjustableRateMortgages() => !ConsumerHandbookOnAdjustableRateMortgages.Clean;
        public Value<string> DaysToReceiveWrittenRequest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDaysToReceiveWrittenRequest() => !DaysToReceiveWrittenRequest.Clean;
        public Value<int?> DaysToReturnToLender { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDaysToReturnToLender() => !DaysToReturnToLender.Clean;
        public Value<string> DiscloseNonPublicPersonalInformation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscloseNonPublicPersonalInformation() => !DiscloseNonPublicPersonalInformation.Clean;
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
        public Value<string> FairLendingNoticeDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFairLendingNoticeDescription1() => !FairLendingNoticeDescription1.Clean;
        public Value<string> FairLendingNoticeDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFairLendingNoticeDescription2() => !FairLendingNoticeDescription2.Clean;
        public Value<string> FairLendingNoticeDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFairLendingNoticeDescription3() => !FairLendingNoticeDescription3.Clean;
        public Value<string> FairLendingNoticeDescription4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFairLendingNoticeDescription4() => !FairLendingNoticeDescription4.Clean;
        public Value<string> FairLendingNoticeDescription5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFairLendingNoticeDescription5() => !FairLendingNoticeDescription5.Clean;
        public Value<string> FairLendingNoticeDescription6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFairLendingNoticeDescription6() => !FairLendingNoticeDescription6.Clean;
        public Value<string> FairLendingNoticeDescription7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFairLendingNoticeDescription7() => !FairLendingNoticeDescription7.Clean;
        public Value<string> FairLendingNoticeDescription8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFairLendingNoticeDescription8() => !FairLendingNoticeDescription8.Clean;
        public Value<string> FemaCommunityName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFemaCommunityName() => !FemaCommunityName.Clean;
        public Value<bool?> FloodInsuranceNotificationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodInsuranceNotificationIndicator() => !FloodInsuranceNotificationIndicator.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> InformationDisclosureAuthorizationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationDisclosureAuthorizationIndicator() => !InformationDisclosureAuthorizationIndicator.Clean;
        public Value<string> LicensedMortgageBrokerUnder { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLicensedMortgageBrokerUnder() => !LicensedMortgageBrokerUnder.Clean;
        public Value<bool?> LocatedInNfipIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLocatedInNfipIndicator() => !LocatedInNfipIndicator.Clean;
        public Value<string> LossPayeeClause { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLossPayeeClause() => !LossPayeeClause.Clean;
        public Value<string> MapPanelNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMapPanelNumber() => !MapPanelNumber.Clean;
        public Value<string> NFIPCommunityNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNFIPCommunityNumber() => !NFIPCommunityNumber.Clean;
        public Value<DateTime?> NFIPMapEffectiveRevisedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNFIPMapEffectiveRevisedDate() => !NFIPMapEffectiveRevisedDate.Clean;
        public Value<string> NonFinancialCompaniesDescription1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonFinancialCompaniesDescription1() => !NonFinancialCompaniesDescription1.Clean;
        public Value<string> NonFinancialCompaniesDescription2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonFinancialCompaniesDescription2() => !NonFinancialCompaniesDescription2.Clean;
        public Value<string> NonFinancialCompaniesDescription3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonFinancialCompaniesDescription3() => !NonFinancialCompaniesDescription3.Clean;
        public Value<string> NonFinancialCompaniesDescription4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonFinancialCompaniesDescription4() => !NonFinancialCompaniesDescription4.Clean;
        public Value<bool?> NotLocatedInNfipIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotLocatedInNfipIndicator() => !NotLocatedInNfipIndicator.Clean;
        public Value<bool?> OccupancyStatementIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOccupancyStatementIndicator() => !OccupancyStatementIndicator.Clean;
        public Value<string> OptOut { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOptOut() => !OptOut.Clean;
        public Value<string> OptOutPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOptOutPhone() => !OptOutPhone.Clean;
        public Value<bool?> ReleaseBankingInformationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReleaseBankingInformationIndicator() => !ReleaseBankingInformationIndicator.Clean;
        public Value<bool?> ReleaseEmploymentInformationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReleaseEmploymentInformationIndicator() => !ReleaseEmploymentInformationIndicator.Clean;
        public Value<bool?> ReleaseInformationInConnectionWithCreditReportIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReleaseInformationInConnectionWithCreditReportIndicator() => !ReleaseInformationInConnectionWithCreditReportIndicator.Clean;
        public Value<bool?> ReleaseMortgageInformationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReleaseMortgageInformationIndicator() => !ReleaseMortgageInformationIndicator.Clean;
        public Value<bool?> RightToFinancialPrivacyActIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRightToFinancialPrivacyActIndicator() => !RightToFinancialPrivacyActIndicator.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AntiCoercionStatementIndicator.Clean
                    && CommitmentIssuedByAddress.Clean
                    && CommitmentIssuedByCity.Clean
                    && CommitmentIssuedByContactName.Clean
                    && CommitmentIssuedByName.Clean
                    && CommitmentIssuedByPhone.Clean
                    && CommitmentIssuedByPostalCode.Clean
                    && CommitmentIssuedByState.Clean
                    && ConsumerHandbookOnAdjustableRateMortgages.Clean
                    && DaysToReceiveWrittenRequest.Clean
                    && DaysToReturnToLender.Clean
                    && DiscloseNonPublicPersonalInformation.Clean
                    && EcoaAddress.Clean
                    && EcoaAddress2.Clean
                    && EcoaCity.Clean
                    && EcoaName.Clean
                    && EcoaPhone.Clean
                    && EcoaPostalCode.Clean
                    && EcoaState.Clean
                    && FairLendingNoticeDescription1.Clean
                    && FairLendingNoticeDescription2.Clean
                    && FairLendingNoticeDescription3.Clean
                    && FairLendingNoticeDescription4.Clean
                    && FairLendingNoticeDescription5.Clean
                    && FairLendingNoticeDescription6.Clean
                    && FairLendingNoticeDescription7.Clean
                    && FairLendingNoticeDescription8.Clean
                    && FemaCommunityName.Clean
                    && FloodInsuranceNotificationIndicator.Clean
                    && Id.Clean
                    && InformationDisclosureAuthorizationIndicator.Clean
                    && LicensedMortgageBrokerUnder.Clean
                    && LocatedInNfipIndicator.Clean
                    && LossPayeeClause.Clean
                    && MapPanelNumber.Clean
                    && NFIPCommunityNumber.Clean
                    && NFIPMapEffectiveRevisedDate.Clean
                    && NonFinancialCompaniesDescription1.Clean
                    && NonFinancialCompaniesDescription2.Clean
                    && NonFinancialCompaniesDescription3.Clean
                    && NonFinancialCompaniesDescription4.Clean
                    && NotLocatedInNfipIndicator.Clean
                    && OccupancyStatementIndicator.Clean
                    && OptOut.Clean
                    && OptOutPhone.Clean
                    && ReleaseBankingInformationIndicator.Clean
                    && ReleaseEmploymentInformationIndicator.Clean
                    && ReleaseInformationInConnectionWithCreditReportIndicator.Clean
                    && ReleaseMortgageInformationIndicator.Clean
                    && RightToFinancialPrivacyActIndicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AntiCoercionStatementIndicator; v0.Clean = value; AntiCoercionStatementIndicator = v0;
                var v1 = CommitmentIssuedByAddress; v1.Clean = value; CommitmentIssuedByAddress = v1;
                var v2 = CommitmentIssuedByCity; v2.Clean = value; CommitmentIssuedByCity = v2;
                var v3 = CommitmentIssuedByContactName; v3.Clean = value; CommitmentIssuedByContactName = v3;
                var v4 = CommitmentIssuedByName; v4.Clean = value; CommitmentIssuedByName = v4;
                var v5 = CommitmentIssuedByPhone; v5.Clean = value; CommitmentIssuedByPhone = v5;
                var v6 = CommitmentIssuedByPostalCode; v6.Clean = value; CommitmentIssuedByPostalCode = v6;
                var v7 = CommitmentIssuedByState; v7.Clean = value; CommitmentIssuedByState = v7;
                var v8 = ConsumerHandbookOnAdjustableRateMortgages; v8.Clean = value; ConsumerHandbookOnAdjustableRateMortgages = v8;
                var v9 = DaysToReceiveWrittenRequest; v9.Clean = value; DaysToReceiveWrittenRequest = v9;
                var v10 = DaysToReturnToLender; v10.Clean = value; DaysToReturnToLender = v10;
                var v11 = DiscloseNonPublicPersonalInformation; v11.Clean = value; DiscloseNonPublicPersonalInformation = v11;
                var v12 = EcoaAddress; v12.Clean = value; EcoaAddress = v12;
                var v13 = EcoaAddress2; v13.Clean = value; EcoaAddress2 = v13;
                var v14 = EcoaCity; v14.Clean = value; EcoaCity = v14;
                var v15 = EcoaName; v15.Clean = value; EcoaName = v15;
                var v16 = EcoaPhone; v16.Clean = value; EcoaPhone = v16;
                var v17 = EcoaPostalCode; v17.Clean = value; EcoaPostalCode = v17;
                var v18 = EcoaState; v18.Clean = value; EcoaState = v18;
                var v19 = FairLendingNoticeDescription1; v19.Clean = value; FairLendingNoticeDescription1 = v19;
                var v20 = FairLendingNoticeDescription2; v20.Clean = value; FairLendingNoticeDescription2 = v20;
                var v21 = FairLendingNoticeDescription3; v21.Clean = value; FairLendingNoticeDescription3 = v21;
                var v22 = FairLendingNoticeDescription4; v22.Clean = value; FairLendingNoticeDescription4 = v22;
                var v23 = FairLendingNoticeDescription5; v23.Clean = value; FairLendingNoticeDescription5 = v23;
                var v24 = FairLendingNoticeDescription6; v24.Clean = value; FairLendingNoticeDescription6 = v24;
                var v25 = FairLendingNoticeDescription7; v25.Clean = value; FairLendingNoticeDescription7 = v25;
                var v26 = FairLendingNoticeDescription8; v26.Clean = value; FairLendingNoticeDescription8 = v26;
                var v27 = FemaCommunityName; v27.Clean = value; FemaCommunityName = v27;
                var v28 = FloodInsuranceNotificationIndicator; v28.Clean = value; FloodInsuranceNotificationIndicator = v28;
                var v29 = Id; v29.Clean = value; Id = v29;
                var v30 = InformationDisclosureAuthorizationIndicator; v30.Clean = value; InformationDisclosureAuthorizationIndicator = v30;
                var v31 = LicensedMortgageBrokerUnder; v31.Clean = value; LicensedMortgageBrokerUnder = v31;
                var v32 = LocatedInNfipIndicator; v32.Clean = value; LocatedInNfipIndicator = v32;
                var v33 = LossPayeeClause; v33.Clean = value; LossPayeeClause = v33;
                var v34 = MapPanelNumber; v34.Clean = value; MapPanelNumber = v34;
                var v35 = NFIPCommunityNumber; v35.Clean = value; NFIPCommunityNumber = v35;
                var v36 = NFIPMapEffectiveRevisedDate; v36.Clean = value; NFIPMapEffectiveRevisedDate = v36;
                var v37 = NonFinancialCompaniesDescription1; v37.Clean = value; NonFinancialCompaniesDescription1 = v37;
                var v38 = NonFinancialCompaniesDescription2; v38.Clean = value; NonFinancialCompaniesDescription2 = v38;
                var v39 = NonFinancialCompaniesDescription3; v39.Clean = value; NonFinancialCompaniesDescription3 = v39;
                var v40 = NonFinancialCompaniesDescription4; v40.Clean = value; NonFinancialCompaniesDescription4 = v40;
                var v41 = NotLocatedInNfipIndicator; v41.Clean = value; NotLocatedInNfipIndicator = v41;
                var v42 = OccupancyStatementIndicator; v42.Clean = value; OccupancyStatementIndicator = v42;
                var v43 = OptOut; v43.Clean = value; OptOut = v43;
                var v44 = OptOutPhone; v44.Clean = value; OptOutPhone = v44;
                var v45 = ReleaseBankingInformationIndicator; v45.Clean = value; ReleaseBankingInformationIndicator = v45;
                var v46 = ReleaseEmploymentInformationIndicator; v46.Clean = value; ReleaseEmploymentInformationIndicator = v46;
                var v47 = ReleaseInformationInConnectionWithCreditReportIndicator; v47.Clean = value; ReleaseInformationInConnectionWithCreditReportIndicator = v47;
                var v48 = ReleaseMortgageInformationIndicator; v48.Clean = value; ReleaseMortgageInformationIndicator = v48;
                var v49 = RightToFinancialPrivacyActIndicator; v49.Clean = value; RightToFinancialPrivacyActIndicator = v49;
                _settingClean = 0;
            }
        }
    }
}