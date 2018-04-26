using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FannieMae
    /// </summary>
    public sealed partial class FannieMae : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _caseIDAssignedByUCDIndicator;
        /// <summary>
        /// Fannie Mae Case File ID # Assigned by UCD [MORNET.X125]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Case File ID # Assigned by UCD")]
        public bool? CaseIDAssignedByUCDIndicator { get => _caseIDAssignedByUCDIndicator; set => _caseIDAssignedByUCDIndicator = value; }
        private DirtyValue<decimal?> _cltv;
        /// <summary>
        /// Fannie Mae MORNETPlus CLTV [MORNET.X76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fannie Mae MORNETPlus CLTV")]
        public decimal? Cltv { get => _cltv; set => _cltv = value; }
        private DirtyValue<string> _collateralUnderwriterScore;
        /// <summary>
        /// Fannie Mae Collateral Underwriter Score [MORNET.X92]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Collateral Underwriter Score")]
        public string CollateralUnderwriterScore { get => _collateralUnderwriterScore; set => _collateralUnderwriterScore = value; }
        private DirtyValue<StringEnumValue<Community2ndRepaymentStructure>> _community2ndRepaymentStructure;
        /// <summary>
        /// Fannie Mae Community Seconds Repayment Structure [MORNET.X73]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Community Seconds Repayment Structure")]
        public StringEnumValue<Community2ndRepaymentStructure> Community2ndRepaymentStructure { get => _community2ndRepaymentStructure; set => _community2ndRepaymentStructure = value; }
        private DirtyValue<bool?> _communityLending;
        /// <summary>
        /// Fannie Mae Community Lending [MORNET.X72]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Community Lending", OptionsJson = "{\"true\":\"Community Lending\"}")]
        public bool? CommunityLending { get => _communityLending; set => _communityLending = value; }
        private DirtyValue<string> _correspondentAssignmentID;
        /// <summary>
        /// Fannie Mae Correspondent Assignment Center ID [MORNET.X126]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Correspondent Assignment Center ID")]
        public string CorrespondentAssignmentID { get => _correspondentAssignmentID; set => _correspondentAssignmentID = value; }
        private DirtyValue<string> _duVersion;
        /// <summary>
        /// Fannie Mae MORNETPlus Version Number [MORNET.X74]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae MORNETPlus Version Number")]
        public string DuVersion { get => _duVersion; set => _duVersion = value; }
        private DirtyValue<string> _eCStatus1003;
        /// <summary>
        /// Fannie Mae 1003 EC Status [MORNET.X94]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae 1003 EC Status")]
        public string ECStatus1003 { get => _eCStatus1003; set => _eCStatus1003 = value; }
        private DirtyValue<decimal?> _hcltv;
        /// <summary>
        /// Fannie Mae MORNETPlus HCLTV and HTLTV [MORNET.X77]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fannie Mae MORNETPlus HCLTV and HTLTV")]
        public decimal? Hcltv { get => _hcltv; set => _hcltv = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// FannieMae Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _interestedPartyContribution;
        /// <summary>
        /// Interested Party Contribution [MORNET.X78]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Interested Party Contribution")]
        public decimal? InterestedPartyContribution { get => _interestedPartyContribution; set => _interestedPartyContribution = value; }
        private DirtyValue<decimal?> _ltv;
        /// <summary>
        /// Fannie Mae MORNETPlus LTV [MORNET.X75]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fannie Mae MORNETPlus LTV")]
        public decimal? Ltv { get => _ltv; set => _ltv = value; }
        private DirtyValue<string> _mornetPlusCaseFileId;
        /// <summary>
        /// Fannie Mae MORNETPlus Case File ID # [MORNET.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae MORNETPlus Case File ID #")]
        public string MornetPlusCaseFileId { get => _mornetPlusCaseFileId; set => _mornetPlusCaseFileId = value; }
        private DirtyValue<string> _propertyInspectionWaiverMessage;
        /// <summary>
        /// Fannie Mae Property Inspection Waiver Message [MORNET.X91]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Property Inspection Waiver Message")]
        public string PropertyInspectionWaiverMessage { get => _propertyInspectionWaiverMessage; set => _propertyInspectionWaiverMessage = value; }
        private DirtyValue<bool?> _startUpMortgage;
        /// <summary>
        /// Fannie Mae Start-Up Mtg [MORNET.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Start-Up Mtg", OptionsJson = "{\"true\":\"Start-up Mortgage\"}")]
        public bool? StartUpMortgage { get => _startUpMortgage; set => _startUpMortgage = value; }
        private DirtyValue<string> _uCDCollectionStatus;
        /// <summary>
        /// Fannie Mae UCD Collection Status [MORNET.X96]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae UCD Collection Status")]
        public string UCDCollectionStatus { get => _uCDCollectionStatus; set => _uCDCollectionStatus = value; }
        private DirtyValue<string> _uCDPStatus;
        /// <summary>
        /// Fannie Mae UCDP Status [MORNET.X93]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae UCDP Status")]
        public string UCDPStatus { get => _uCDPStatus; set => _uCDPStatus = value; }
        private DirtyValue<string> _uLDDECStatus;
        /// <summary>
        /// Fannie Mae ULDD EC Status [MORNET.X95]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae ULDD EC Status")]
        public string ULDDECStatus { get => _uLDDECStatus; set => _uLDDECStatus = value; }
        internal override bool DirtyInternal
        {
            get => _caseIDAssignedByUCDIndicator.Dirty
                || _cltv.Dirty
                || _collateralUnderwriterScore.Dirty
                || _community2ndRepaymentStructure.Dirty
                || _communityLending.Dirty
                || _correspondentAssignmentID.Dirty
                || _duVersion.Dirty
                || _eCStatus1003.Dirty
                || _hcltv.Dirty
                || _id.Dirty
                || _interestedPartyContribution.Dirty
                || _ltv.Dirty
                || _mornetPlusCaseFileId.Dirty
                || _propertyInspectionWaiverMessage.Dirty
                || _startUpMortgage.Dirty
                || _uCDCollectionStatus.Dirty
                || _uCDPStatus.Dirty
                || _uLDDECStatus.Dirty;
            set
            {
                _caseIDAssignedByUCDIndicator.Dirty = value;
                _cltv.Dirty = value;
                _collateralUnderwriterScore.Dirty = value;
                _community2ndRepaymentStructure.Dirty = value;
                _communityLending.Dirty = value;
                _correspondentAssignmentID.Dirty = value;
                _duVersion.Dirty = value;
                _eCStatus1003.Dirty = value;
                _hcltv.Dirty = value;
                _id.Dirty = value;
                _interestedPartyContribution.Dirty = value;
                _ltv.Dirty = value;
                _mornetPlusCaseFileId.Dirty = value;
                _propertyInspectionWaiverMessage.Dirty = value;
                _startUpMortgage.Dirty = value;
                _uCDCollectionStatus.Dirty = value;
                _uCDPStatus.Dirty = value;
                _uLDDECStatus.Dirty = value;
            }
        }
    }
}