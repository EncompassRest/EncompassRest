using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FannieMae
    /// </summary>
    public sealed partial class FannieMae : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _caseIDAssignedByUCDIndicator;
        /// <summary>
        /// Fannie Mae Case File ID # Assigned by UCD [MORNET.X125]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Case File ID # Assigned by UCD")]
        public bool? CaseIDAssignedByUCDIndicator { get => _caseIDAssignedByUCDIndicator; set => SetField(ref _caseIDAssignedByUCDIndicator, value); }
        private DirtyValue<decimal?> _cltv;
        /// <summary>
        /// Fannie Mae MORNETPlus CLTV [MORNET.X76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fannie Mae MORNETPlus CLTV")]
        public decimal? Cltv { get => _cltv; set => SetField(ref _cltv, value); }
        private DirtyValue<string> _collateralUnderwriterScore;
        /// <summary>
        /// Fannie Mae Collateral Underwriter Score [MORNET.X92]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Collateral Underwriter Score")]
        public string CollateralUnderwriterScore { get => _collateralUnderwriterScore; set => SetField(ref _collateralUnderwriterScore, value); }
        private DirtyValue<StringEnumValue<Community2ndRepaymentStructure>> _community2ndRepaymentStructure;
        /// <summary>
        /// Fannie Mae Community Seconds Repayment Structure [MORNET.X73]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Community Seconds Repayment Structure")]
        public StringEnumValue<Community2ndRepaymentStructure> Community2ndRepaymentStructure { get => _community2ndRepaymentStructure; set => SetField(ref _community2ndRepaymentStructure, value); }
        private DirtyValue<bool?> _communityLending;
        /// <summary>
        /// Fannie Mae Community Lending [MORNET.X72]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Community Lending", OptionsJson = "{\"true\":\"Community Lending\"}")]
        public bool? CommunityLending { get => _communityLending; set => SetField(ref _communityLending, value); }
        private DirtyValue<string> _correspondentAssignmentID;
        /// <summary>
        /// Fannie Mae Correspondent Assignment Center ID [MORNET.X126]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Correspondent Assignment Center ID")]
        public string CorrespondentAssignmentID { get => _correspondentAssignmentID; set => SetField(ref _correspondentAssignmentID, value); }
        private DirtyValue<string> _duVersion;
        /// <summary>
        /// Fannie Mae MORNETPlus Version Number [MORNET.X74]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae MORNETPlus Version Number")]
        public string DuVersion { get => _duVersion; set => SetField(ref _duVersion, value); }
        private DirtyValue<string> _eCStatus1003;
        /// <summary>
        /// Fannie Mae 1003 EC Status [MORNET.X94]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae 1003 EC Status")]
        public string ECStatus1003 { get => _eCStatus1003; set => SetField(ref _eCStatus1003, value); }
        private DirtyValue<decimal?> _hcltv;
        /// <summary>
        /// Fannie Mae MORNETPlus HCLTV and HTLTV [MORNET.X77]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fannie Mae MORNETPlus HCLTV and HTLTV")]
        public decimal? Hcltv { get => _hcltv; set => SetField(ref _hcltv, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// FannieMae Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _interestedPartyContribution;
        /// <summary>
        /// Interested Party Contribution [MORNET.X78]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Interested Party Contribution")]
        public decimal? InterestedPartyContribution { get => _interestedPartyContribution; set => SetField(ref _interestedPartyContribution, value); }
        private DirtyValue<decimal?> _ltv;
        /// <summary>
        /// Fannie Mae MORNETPlus LTV [MORNET.X75]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fannie Mae MORNETPlus LTV")]
        public decimal? Ltv { get => _ltv; set => SetField(ref _ltv, value); }
        private DirtyValue<string> _mornetPlusCaseFileId;
        /// <summary>
        /// Fannie Mae MORNETPlus Case File ID # [MORNET.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae MORNETPlus Case File ID #")]
        public string MornetPlusCaseFileId { get => _mornetPlusCaseFileId; set => SetField(ref _mornetPlusCaseFileId, value); }
        private DirtyValue<string> _propertyInspectionWaiverMessage;
        /// <summary>
        /// Fannie Mae Property Inspection Waiver Message [MORNET.X91]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Property Inspection Waiver Message")]
        public string PropertyInspectionWaiverMessage { get => _propertyInspectionWaiverMessage; set => SetField(ref _propertyInspectionWaiverMessage, value); }
        private DirtyValue<bool?> _startUpMortgage;
        /// <summary>
        /// Fannie Mae Start-Up Mtg [MORNET.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Start-Up Mtg", OptionsJson = "{\"true\":\"Start-up Mortgage\"}")]
        public bool? StartUpMortgage { get => _startUpMortgage; set => SetField(ref _startUpMortgage, value); }
        private DirtyValue<string> _uCDCollectionStatus;
        /// <summary>
        /// Fannie Mae UCD Collection Status [MORNET.X96]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae UCD Collection Status")]
        public string UCDCollectionStatus { get => _uCDCollectionStatus; set => SetField(ref _uCDCollectionStatus, value); }
        private DirtyValue<string> _uCDPStatus;
        /// <summary>
        /// Fannie Mae UCDP Status [MORNET.X93]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae UCDP Status")]
        public string UCDPStatus { get => _uCDPStatus; set => SetField(ref _uCDPStatus, value); }
        private DirtyValue<string> _uLDDECStatus;
        /// <summary>
        /// Fannie Mae ULDD EC Status [MORNET.X95]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae ULDD EC Status")]
        public string ULDDECStatus { get => _uLDDECStatus; set => SetField(ref _uLDDECStatus, value); }
    }
}