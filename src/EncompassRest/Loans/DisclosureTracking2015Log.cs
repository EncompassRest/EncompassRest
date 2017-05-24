using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureTracking2015Log
    {
        private Value<List<LogAlert>> _alerts;
        public List<LogAlert> Alerts { get { return _alerts; } set { _alerts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlerts() => !_alerts.Clean;
        private Value<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlertsXml() => !_alertsXml.Clean;
        private Value<DateTime?> _applicationDate;
        public DateTime? ApplicationDate { get { return _applicationDate; } set { _applicationDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicationDate() => !_applicationDate.Clean;
        private Value<string> _appliedCureAmount;
        public string AppliedCureAmount { get { return _appliedCureAmount; } set { _appliedCureAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppliedCureAmount() => !_appliedCureAmount.Clean;
        private Value<DateTime?> _borrowerActualReceivedDate;
        public DateTime? BorrowerActualReceivedDate { get { return _borrowerActualReceivedDate; } set { _borrowerActualReceivedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerActualReceivedDate() => !_borrowerActualReceivedDate.Clean;
        private Value<string> _borrowerDisclosedMethod;
        public string BorrowerDisclosedMethod { get { return _borrowerDisclosedMethod; } set { _borrowerDisclosedMethod = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerDisclosedMethod() => !_borrowerDisclosedMethod.Clean;
        private Value<string> _borrowerDisclosedMethodOther;
        public string BorrowerDisclosedMethodOther { get { return _borrowerDisclosedMethodOther; } set { _borrowerDisclosedMethodOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerDisclosedMethodOther() => !_borrowerDisclosedMethodOther.Clean;
        private Value<string> _borrowerName;
        public string BorrowerName { get { return _borrowerName; } set { _borrowerName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerName() => !_borrowerName.Clean;
        private Value<string> _borrowerPairId;
        public string BorrowerPairId { get { return _borrowerPairId; } set { _borrowerPairId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPairId() => !_borrowerPairId.Clean;
        private Value<DateTime?> _borrowerPresumedReceivedDate;
        public DateTime? BorrowerPresumedReceivedDate { get { return _borrowerPresumedReceivedDate; } set { _borrowerPresumedReceivedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPresumedReceivedDate() => !_borrowerPresumedReceivedDate.Clean;
        private Value<string> _borrowerType;
        public string BorrowerType { get { return _borrowerType; } set { _borrowerType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerType() => !_borrowerType.Clean;
        private Value<bool?> _cDReasonIs24HourAdvancePreview;
        public bool? CDReasonIs24HourAdvancePreview { get { return _cDReasonIs24HourAdvancePreview; } set { _cDReasonIs24HourAdvancePreview = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIs24HourAdvancePreview() => !_cDReasonIs24HourAdvancePreview.Clean;
        private Value<bool?> _cDReasonIsChangeInAPR;
        public bool? CDReasonIsChangeInAPR { get { return _cDReasonIsChangeInAPR; } set { _cDReasonIsChangeInAPR = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIsChangeInAPR() => !_cDReasonIsChangeInAPR.Clean;
        private Value<bool?> _cDReasonIsChangeInLoanProduct;
        public bool? CDReasonIsChangeInLoanProduct { get { return _cDReasonIsChangeInLoanProduct; } set { _cDReasonIsChangeInLoanProduct = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIsChangeInLoanProduct() => !_cDReasonIsChangeInLoanProduct.Clean;
        private Value<bool?> _cDReasonIsChangeInSettlementCharges;
        public bool? CDReasonIsChangeInSettlementCharges { get { return _cDReasonIsChangeInSettlementCharges; } set { _cDReasonIsChangeInSettlementCharges = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIsChangeInSettlementCharges() => !_cDReasonIsChangeInSettlementCharges.Clean;
        private Value<bool?> _cDReasonIsClericalErrorCorrection;
        public bool? CDReasonIsClericalErrorCorrection { get { return _cDReasonIsClericalErrorCorrection; } set { _cDReasonIsClericalErrorCorrection = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIsClericalErrorCorrection() => !_cDReasonIsClericalErrorCorrection.Clean;
        private Value<bool?> _cDReasonIsOther;
        public bool? CDReasonIsOther { get { return _cDReasonIsOther; } set { _cDReasonIsOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIsOther() => !_cDReasonIsOther.Clean;
        private Value<bool?> _cDReasonIsPrepaymentPenaltyAdded;
        public bool? CDReasonIsPrepaymentPenaltyAdded { get { return _cDReasonIsPrepaymentPenaltyAdded; } set { _cDReasonIsPrepaymentPenaltyAdded = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIsPrepaymentPenaltyAdded() => !_cDReasonIsPrepaymentPenaltyAdded.Clean;
        private Value<bool?> _cDReasonIsToleranceCure;
        public bool? CDReasonIsToleranceCure { get { return _cDReasonIsToleranceCure; } set { _cDReasonIsToleranceCure = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonIsToleranceCure() => !_cDReasonIsToleranceCure.Clean;
        private Value<string> _cDReasonOther;
        public string CDReasonOther { get { return _cDReasonOther; } set { _cDReasonOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCDReasonOther() => !_cDReasonOther.Clean;
        private Value<string> _changeInCircumstance;
        public string ChangeInCircumstance { get { return _changeInCircumstance; } set { _changeInCircumstance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChangeInCircumstance() => !_changeInCircumstance.Clean;
        private Value<string> _changeInCircumstanceComments;
        public string ChangeInCircumstanceComments { get { return _changeInCircumstanceComments; } set { _changeInCircumstanceComments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChangeInCircumstanceComments() => !_changeInCircumstanceComments.Clean;
        private Value<string> _chargesCannotIncrease10Itemization34;
        public string ChargesCannotIncrease10Itemization34 { get { return _chargesCannotIncrease10Itemization34; } set { _chargesCannotIncrease10Itemization34 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesCannotIncrease10Itemization34() => !_chargesCannotIncrease10Itemization34.Clean;
        private Value<string> _chargesCannotIncrease10LE32;
        public string ChargesCannotIncrease10LE32 { get { return _chargesCannotIncrease10LE32; } set { _chargesCannotIncrease10LE32 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesCannotIncrease10LE32() => !_chargesCannotIncrease10LE32.Clean;
        private Value<string> _chargesThatCannotDecreaseItemization9;
        public string ChargesThatCannotDecreaseItemization9 { get { return _chargesThatCannotDecreaseItemization9; } set { _chargesThatCannotDecreaseItemization9 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCannotDecreaseItemization9() => !_chargesThatCannotDecreaseItemization9.Clean;
        private Value<string> _chargesThatCannotDecreaseLE7;
        public string ChargesThatCannotDecreaseLE7 { get { return _chargesThatCannotDecreaseLE7; } set { _chargesThatCannotDecreaseLE7 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCannotDecreaseLE7() => !_chargesThatCannotDecreaseLE7.Clean;
        private Value<string> _chargesThatCannotIncreaseItemization13;
        public string ChargesThatCannotIncreaseItemization13 { get { return _chargesThatCannotIncreaseItemization13; } set { _chargesThatCannotIncreaseItemization13 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCannotIncreaseItemization13() => !_chargesThatCannotIncreaseItemization13.Clean;
        private Value<string> _chargesThatCannotIncreaseLE11;
        public string ChargesThatCannotIncreaseLE11 { get { return _chargesThatCannotIncreaseLE11; } set { _chargesThatCannotIncreaseLE11 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargesThatCannotIncreaseLE11() => !_chargesThatCannotIncreaseLE11.Clean;
        private Value<DateTime?> _coBorrowerActualReceivedDate;
        public DateTime? CoBorrowerActualReceivedDate { get { return _coBorrowerActualReceivedDate; } set { _coBorrowerActualReceivedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerActualReceivedDate() => !_coBorrowerActualReceivedDate.Clean;
        private Value<string> _coBorrowerDisclosedMethod;
        public string CoBorrowerDisclosedMethod { get { return _coBorrowerDisclosedMethod; } set { _coBorrowerDisclosedMethod = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerDisclosedMethod() => !_coBorrowerDisclosedMethod.Clean;
        private Value<string> _coBorrowerDisclosedMethodOther;
        public string CoBorrowerDisclosedMethodOther { get { return _coBorrowerDisclosedMethodOther; } set { _coBorrowerDisclosedMethodOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerDisclosedMethodOther() => !_coBorrowerDisclosedMethodOther.Clean;
        private Value<string> _coBorrowerName;
        public string CoBorrowerName { get { return _coBorrowerName; } set { _coBorrowerName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerName() => !_coBorrowerName.Clean;
        private Value<DateTime?> _coBorrowerPresumedReceivedDate;
        public DateTime? CoBorrowerPresumedReceivedDate { get { return _coBorrowerPresumedReceivedDate; } set { _coBorrowerPresumedReceivedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerPresumedReceivedDate() => !_coBorrowerPresumedReceivedDate.Clean;
        private Value<string> _coBorrowerType;
        public string CoBorrowerType { get { return _coBorrowerType; } set { _coBorrowerType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoBorrowerType() => !_coBorrowerType.Clean;
        private Value<List<LogComment>> _commentList;
        public List<LogComment> CommentList { get { return _commentList; } set { _commentList = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentList() => !_commentList.Clean;
        private Value<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentListXml() => !_commentListXml.Clean;
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !_comments.Clean;
        private Value<bool?> _containCD;
        public bool? ContainCD { get { return _containCD; } set { _containCD = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContainCD() => !_containCD.Clean;
        private Value<bool?> _containLE;
        public bool? ContainLE { get { return _containLE; } set { _containLE = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContainLE() => !_containLE.Clean;
        private Value<bool?> _containSafeHarbor;
        public bool? ContainSafeHarbor { get { return _containSafeHarbor; } set { _containSafeHarbor = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContainSafeHarbor() => !_containSafeHarbor.Clean;
        private Value<DateTime?> _dateAdded;
        public DateTime? DateAdded { get { return _dateAdded; } set { _dateAdded = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateAdded() => !_dateAdded.Clean;
        private Value<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateUtc() => !_dateUtc.Clean;
        private Value<string> _disclosedAPR;
        public string DisclosedAPR { get { return _disclosedAPR; } set { _disclosedAPR = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedAPR() => !_disclosedAPR.Clean;
        private Value<string> _disclosedBy;
        public string DisclosedBy { get { return _disclosedBy; } set { _disclosedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedBy() => !_disclosedBy.Clean;
        private Value<string> _disclosedByFullName;
        public string DisclosedByFullName { get { return _disclosedByFullName; } set { _disclosedByFullName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedByFullName() => !_disclosedByFullName.Clean;
        private Value<string> _disclosedDailyInterest;
        public string DisclosedDailyInterest { get { return _disclosedDailyInterest; } set { _disclosedDailyInterest = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedDailyInterest() => !_disclosedDailyInterest.Clean;
        private Value<DateTime?> _disclosedDate;
        public DateTime? DisclosedDate { get { return _disclosedDate; } set { _disclosedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedDate() => !_disclosedDate.Clean;
        private Value<bool?> _disclosedForCD;
        public bool? DisclosedForCD { get { return _disclosedForCD; } set { _disclosedForCD = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedForCD() => !_disclosedForCD.Clean;
        private Value<string> _disclosedMethod;
        public string DisclosedMethod { get { return _disclosedMethod; } set { _disclosedMethod = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedMethod() => !_disclosedMethod.Clean;
        private Value<string> _disclosedMethodName;
        public string DisclosedMethodName { get { return _disclosedMethodName; } set { _disclosedMethodName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedMethodName() => !_disclosedMethodName.Clean;
        private Value<string> _disclosedMethodOther;
        public string DisclosedMethodOther { get { return _disclosedMethodOther; } set { _disclosedMethodOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosedMethodOther() => !_disclosedMethodOther.Clean;
        private Value<DateTime?> _disclosureCreatedDttmUtc;
        public DateTime? DisclosureCreatedDttmUtc { get { return _disclosureCreatedDttmUtc; } set { _disclosureCreatedDttmUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureCreatedDttmUtc() => !_disclosureCreatedDttmUtc.Clean;
        private Value<string> _disclosureMethod;
        public string DisclosureMethod { get { return _disclosureMethod; } set { _disclosureMethod = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureMethod() => !_disclosureMethod.Clean;
        private Value<string> _disclosureType;
        public string DisclosureType { get { return _disclosureType; } set { _disclosureType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureType() => !_disclosureType.Clean;
        private Value<bool?> _eDisclosureApplicationPackageIndicator;
        public bool? EDisclosureApplicationPackageIndicator { get { return _eDisclosureApplicationPackageIndicator; } set { _eDisclosureApplicationPackageIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureApplicationPackageIndicator() => !_eDisclosureApplicationPackageIndicator.Clean;
        private Value<bool?> _eDisclosureApprovalPackageIndicator;
        public bool? EDisclosureApprovalPackageIndicator { get { return _eDisclosureApprovalPackageIndicator; } set { _eDisclosureApprovalPackageIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureApprovalPackageIndicator() => !_eDisclosureApprovalPackageIndicator.Clean;
        private Value<DateTime?> _eDisclosureBorrowerAcceptConsentDate;
        public DateTime? EDisclosureBorrowerAcceptConsentDate { get { return _eDisclosureBorrowerAcceptConsentDate; } set { _eDisclosureBorrowerAcceptConsentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureBorrowerAcceptConsentDate() => !_eDisclosureBorrowerAcceptConsentDate.Clean;
        private Value<DateTime?> _eDisclosureBorrowereSignedDate;
        public DateTime? EDisclosureBorrowereSignedDate { get { return _eDisclosureBorrowereSignedDate; } set { _eDisclosureBorrowereSignedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureBorrowereSignedDate() => !_eDisclosureBorrowereSignedDate.Clean;
        private Value<DateTime?> _eDisclosureBorrowerRejectConsentDate;
        public DateTime? EDisclosureBorrowerRejectConsentDate { get { return _eDisclosureBorrowerRejectConsentDate; } set { _eDisclosureBorrowerRejectConsentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureBorrowerRejectConsentDate() => !_eDisclosureBorrowerRejectConsentDate.Clean;
        private Value<DateTime?> _eDisclosureBorrowerViewConsentDate;
        public DateTime? EDisclosureBorrowerViewConsentDate { get { return _eDisclosureBorrowerViewConsentDate; } set { _eDisclosureBorrowerViewConsentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureBorrowerViewConsentDate() => !_eDisclosureBorrowerViewConsentDate.Clean;
        private Value<DateTime?> _eDisclosureBorrowerViewMessageDate;
        public DateTime? EDisclosureBorrowerViewMessageDate { get { return _eDisclosureBorrowerViewMessageDate; } set { _eDisclosureBorrowerViewMessageDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureBorrowerViewMessageDate() => !_eDisclosureBorrowerViewMessageDate.Clean;
        private Value<DateTime?> _eDisclosureBorrowerWetSignedDate;
        public DateTime? EDisclosureBorrowerWetSignedDate { get { return _eDisclosureBorrowerWetSignedDate; } set { _eDisclosureBorrowerWetSignedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureBorrowerWetSignedDate() => !_eDisclosureBorrowerWetSignedDate.Clean;
        private Value<DateTime?> _eDisclosureCoBorrowerAcceptConsentDate;
        public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get { return _eDisclosureCoBorrowerAcceptConsentDate; } set { _eDisclosureCoBorrowerAcceptConsentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureCoBorrowerAcceptConsentDate() => !_eDisclosureCoBorrowerAcceptConsentDate.Clean;
        private Value<DateTime?> _eDisclosureCoBorrowereSignedDate;
        public DateTime? EDisclosureCoBorrowereSignedDate { get { return _eDisclosureCoBorrowereSignedDate; } set { _eDisclosureCoBorrowereSignedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureCoBorrowereSignedDate() => !_eDisclosureCoBorrowereSignedDate.Clean;
        private Value<DateTime?> _eDisclosureCoBorrowerRejectConsentDate;
        public DateTime? EDisclosureCoBorrowerRejectConsentDate { get { return _eDisclosureCoBorrowerRejectConsentDate; } set { _eDisclosureCoBorrowerRejectConsentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureCoBorrowerRejectConsentDate() => !_eDisclosureCoBorrowerRejectConsentDate.Clean;
        private Value<DateTime?> _eDisclosureCoBorrowerViewConsentDate;
        public DateTime? EDisclosureCoBorrowerViewConsentDate { get { return _eDisclosureCoBorrowerViewConsentDate; } set { _eDisclosureCoBorrowerViewConsentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureCoBorrowerViewConsentDate() => !_eDisclosureCoBorrowerViewConsentDate.Clean;
        private Value<DateTime?> _eDisclosureCoBorrowerViewMessageDate;
        public DateTime? EDisclosureCoBorrowerViewMessageDate { get { return _eDisclosureCoBorrowerViewMessageDate; } set { _eDisclosureCoBorrowerViewMessageDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureCoBorrowerViewMessageDate() => !_eDisclosureCoBorrowerViewMessageDate.Clean;
        private Value<DateTime?> _eDisclosureCoBorrowerWebSignedDate;
        public DateTime? EDisclosureCoBorrowerWebSignedDate { get { return _eDisclosureCoBorrowerWebSignedDate; } set { _eDisclosureCoBorrowerWebSignedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureCoBorrowerWebSignedDate() => !_eDisclosureCoBorrowerWebSignedDate.Clean;
        private Value<string> _eDisclosureConsentPdf;
        public string EDisclosureConsentPdf { get { return _eDisclosureConsentPdf; } set { _eDisclosureConsentPdf = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureConsentPdf() => !_eDisclosureConsentPdf.Clean;
        private Value<string> _eDisclosureDisclosedMessage;
        public string EDisclosureDisclosedMessage { get { return _eDisclosureDisclosedMessage; } set { _eDisclosureDisclosedMessage = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureDisclosedMessage() => !_eDisclosureDisclosedMessage.Clean;
        private Value<bool?> _eDisclosureLockPackageIndicator;
        public bool? EDisclosureLockPackageIndicator { get { return _eDisclosureLockPackageIndicator; } set { _eDisclosureLockPackageIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureLockPackageIndicator() => !_eDisclosureLockPackageIndicator.Clean;
        private Value<string> _eDisclosureManualFulfillmentComment;
        public string EDisclosureManualFulfillmentComment { get { return _eDisclosureManualFulfillmentComment; } set { _eDisclosureManualFulfillmentComment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureManualFulfillmentComment() => !_eDisclosureManualFulfillmentComment.Clean;
        private Value<DateTime?> _eDisclosureManualFulfillmentDate;
        public DateTime? EDisclosureManualFulfillmentDate { get { return _eDisclosureManualFulfillmentDate; } set { _eDisclosureManualFulfillmentDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureManualFulfillmentDate() => !_eDisclosureManualFulfillmentDate.Clean;
        private Value<string> _eDisclosureManualFulfillmentMethod;
        public string EDisclosureManualFulfillmentMethod { get { return _eDisclosureManualFulfillmentMethod; } set { _eDisclosureManualFulfillmentMethod = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureManualFulfillmentMethod() => !_eDisclosureManualFulfillmentMethod.Clean;
        private Value<string> _eDisclosureManuallyFulfilledBy;
        public string EDisclosureManuallyFulfilledBy { get { return _eDisclosureManuallyFulfilledBy; } set { _eDisclosureManuallyFulfilledBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureManuallyFulfilledBy() => !_eDisclosureManuallyFulfilledBy.Clean;
        private Value<DateTime?> _eDisclosurePackageCreatedDate;
        public DateTime? EDisclosurePackageCreatedDate { get { return _eDisclosurePackageCreatedDate; } set { _eDisclosurePackageCreatedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosurePackageCreatedDate() => !_eDisclosurePackageCreatedDate.Clean;
        private Value<string> _eDisclosurePackageId;
        public string EDisclosurePackageId { get { return _eDisclosurePackageId; } set { _eDisclosurePackageId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosurePackageId() => !_eDisclosurePackageId.Clean;
        private Value<string> _eDisclosurePackageViewableFile;
        public string EDisclosurePackageViewableFile { get { return _eDisclosurePackageViewableFile; } set { _eDisclosurePackageViewableFile = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosurePackageViewableFile() => !_eDisclosurePackageViewableFile.Clean;
        private Value<bool?> _eDisclosureThreeDayPackageIndicator;
        public bool? EDisclosureThreeDayPackageIndicator { get { return _eDisclosureThreeDayPackageIndicator; } set { _eDisclosureThreeDayPackageIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEDisclosureThreeDayPackageIndicator() => !_eDisclosureThreeDayPackageIndicator.Clean;
        private Value<string> _estimatedTotalPayoffsAndPaymentsAmount;
        public string EstimatedTotalPayoffsAndPaymentsAmount { get { return _estimatedTotalPayoffsAndPaymentsAmount; } set { _estimatedTotalPayoffsAndPaymentsAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedTotalPayoffsAndPaymentsAmount() => !_estimatedTotalPayoffsAndPaymentsAmount.Clean;
        private Value<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFileAttachmentsMigrated() => !_fileAttachmentsMigrated.Clean;
        private Value<string> _financeCharge;
        public string FinanceCharge { get { return _financeCharge; } set { _financeCharge = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinanceCharge() => !_financeCharge.Clean;
        private Value<List<DisclosureForm>> _forms;
        public List<DisclosureForm> Forms { get { return _forms; } set { _forms = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeForms() => !_forms.Clean;
        private Value<string> _formsXml;
        public string FormsXml { get { return _formsXml; } set { _formsXml = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFormsXml() => !_formsXml.Clean;
        private Value<string> _fulfillmentOrderedBy;
        public string FulfillmentOrderedBy { get { return _fulfillmentOrderedBy; } set { _fulfillmentOrderedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFulfillmentOrderedBy() => !_fulfillmentOrderedBy.Clean;
        private Value<string> _fullfillmentProcessedDate;
        public string FullfillmentProcessedDate { get { return _fullfillmentProcessedDate; } set { _fullfillmentProcessedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFullfillmentProcessedDate() => !_fullfillmentProcessedDate.Clean;
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGuid() => !_guid.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<bool?> _intentToProceed;
        public bool? IntentToProceed { get { return _intentToProceed; } set { _intentToProceed = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIntentToProceed() => !_intentToProceed.Clean;
        private Value<string> _intentToProceedComments;
        public string IntentToProceedComments { get { return _intentToProceedComments; } set { _intentToProceedComments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIntentToProceedComments() => !_intentToProceedComments.Clean;
        private Value<DateTime?> _intentToProceedDate;
        public DateTime? IntentToProceedDate { get { return _intentToProceedDate; } set { _intentToProceedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIntentToProceedDate() => !_intentToProceedDate.Clean;
        private Value<string> _intentToProceedReceivedBy;
        public string IntentToProceedReceivedBy { get { return _intentToProceedReceivedBy; } set { _intentToProceedReceivedBy = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIntentToProceedReceivedBy() => !_intentToProceedReceivedBy.Clean;
        private Value<string> _intentToProceedReceivedMethod;
        public string IntentToProceedReceivedMethod { get { return _intentToProceedReceivedMethod; } set { _intentToProceedReceivedMethod = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIntentToProceedReceivedMethod() => !_intentToProceedReceivedMethod.Clean;
        private Value<string> _intentToProceedReceivedMethodOther;
        public string IntentToProceedReceivedMethodOther { get { return _intentToProceedReceivedMethodOther; } set { _intentToProceedReceivedMethodOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIntentToProceedReceivedMethodOther() => !_intentToProceedReceivedMethodOther.Clean;
        private Value<bool?> _isBorrowerPresumedDateLocked;
        public bool? IsBorrowerPresumedDateLocked { get { return _isBorrowerPresumedDateLocked; } set { _isBorrowerPresumedDateLocked = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsBorrowerPresumedDateLocked() => !_isBorrowerPresumedDateLocked.Clean;
        private Value<bool?> _isCoBorrowerPresumedDateLocked;
        public bool? IsCoBorrowerPresumedDateLocked { get { return _isCoBorrowerPresumedDateLocked; } set { _isCoBorrowerPresumedDateLocked = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsCoBorrowerPresumedDateLocked() => !_isCoBorrowerPresumedDateLocked.Clean;
        private Value<string> _isDisclosed;
        public string IsDisclosed { get { return _isDisclosed; } set { _isDisclosed = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsDisclosed() => !_isDisclosed.Clean;
        private Value<string> _isDisclosedAprLocked;
        public string IsDisclosedAprLocked { get { return _isDisclosedAprLocked; } set { _isDisclosedAprLocked = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsDisclosedAprLocked() => !_isDisclosedAprLocked.Clean;
        private Value<string> _isDisclosedByLocked;
        public string IsDisclosedByLocked { get { return _isDisclosedByLocked; } set { _isDisclosedByLocked = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsDisclosedByLocked() => !_isDisclosedByLocked.Clean;
        private Value<string> _isDisclosedFinanceChargeLocked;
        public string IsDisclosedFinanceChargeLocked { get { return _isDisclosedFinanceChargeLocked; } set { _isDisclosedFinanceChargeLocked = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsDisclosedFinanceChargeLocked() => !_isDisclosedFinanceChargeLocked.Clean;
        private Value<string> _isDisclosedReceivedDateLocked;
        public string IsDisclosedReceivedDateLocked { get { return _isDisclosedReceivedDateLocked; } set { _isDisclosedReceivedDateLocked = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsDisclosedReceivedDateLocked() => !_isDisclosedReceivedDateLocked.Clean;
        private Value<string> _isLocked;
        public string IsLocked { get { return _isLocked; } set { _isLocked = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsLocked() => !_isLocked.Clean;
        private Value<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSystemSpecificIndicator() => !_isSystemSpecificIndicator.Clean;
        private Value<bool?> _isWetSignedIndicator;
        public bool? IsWetSignedIndicator { get { return _isWetSignedIndicator; } set { _isWetSignedIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsWetSignedIndicator() => !_isWetSignedIndicator.Clean;
        private Value<string> _lenderCompensationCreditAmount2;
        public string LenderCompensationCreditAmount2 { get { return _lenderCompensationCreditAmount2; } set { _lenderCompensationCreditAmount2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderCompensationCreditAmount2() => !_lenderCompensationCreditAmount2.Clean;
        private Value<string> _lenderTotalPaidOriginatorAmount;
        public string LenderTotalPaidOriginatorAmount { get { return _lenderTotalPaidOriginatorAmount; } set { _lenderTotalPaidOriginatorAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderTotalPaidOriginatorAmount() => !_lenderTotalPaidOriginatorAmount.Clean;
        private Value<bool?> _lEReasonIsChangedCircumstanceEligibility;
        public bool? LEReasonIsChangedCircumstanceEligibility { get { return _lEReasonIsChangedCircumstanceEligibility; } set { _lEReasonIsChangedCircumstanceEligibility = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonIsChangedCircumstanceEligibility() => !_lEReasonIsChangedCircumstanceEligibility.Clean;
        private Value<bool?> _lEReasonIsChangedCircumstanceSettlementCharges;
        public bool? LEReasonIsChangedCircumstanceSettlementCharges { get { return _lEReasonIsChangedCircumstanceSettlementCharges; } set { _lEReasonIsChangedCircumstanceSettlementCharges = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonIsChangedCircumstanceSettlementCharges() => !_lEReasonIsChangedCircumstanceSettlementCharges.Clean;
        private Value<bool?> _lEReasonIsDelayedSettlementOnConstructionLoans;
        public bool? LEReasonIsDelayedSettlementOnConstructionLoans { get { return _lEReasonIsDelayedSettlementOnConstructionLoans; } set { _lEReasonIsDelayedSettlementOnConstructionLoans = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonIsDelayedSettlementOnConstructionLoans() => !_lEReasonIsDelayedSettlementOnConstructionLoans.Clean;
        private Value<bool?> _lEReasonIsExpiration;
        public bool? LEReasonIsExpiration { get { return _lEReasonIsExpiration; } set { _lEReasonIsExpiration = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonIsExpiration() => !_lEReasonIsExpiration.Clean;
        private Value<bool?> _lEReasonIsInterestRateDependentCharges;
        public bool? LEReasonIsInterestRateDependentCharges { get { return _lEReasonIsInterestRateDependentCharges; } set { _lEReasonIsInterestRateDependentCharges = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonIsInterestRateDependentCharges() => !_lEReasonIsInterestRateDependentCharges.Clean;
        private Value<bool?> _lEReasonIsOther;
        public bool? LEReasonIsOther { get { return _lEReasonIsOther; } set { _lEReasonIsOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonIsOther() => !_lEReasonIsOther.Clean;
        private Value<bool?> _lEReasonIsRevisionsRequestedByConsumer;
        public bool? LEReasonIsRevisionsRequestedByConsumer { get { return _lEReasonIsRevisionsRequestedByConsumer; } set { _lEReasonIsRevisionsRequestedByConsumer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonIsRevisionsRequestedByConsumer() => !_lEReasonIsRevisionsRequestedByConsumer.Clean;
        private Value<string> _lEReasonOther;
        public string LEReasonOther { get { return _lEReasonOther; } set { _lEReasonOther = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLEReasonOther() => !_lEReasonOther.Clean;
        private Value<string> _line802LOCompAdditionalAmount1;
        public string Line802LOCompAdditionalAmount1 { get { return _line802LOCompAdditionalAmount1; } set { _line802LOCompAdditionalAmount1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine802LOCompAdditionalAmount1() => !_line802LOCompAdditionalAmount1.Clean;
        private Value<string> _line802LOCompAdditionalAmount2;
        public string Line802LOCompAdditionalAmount2 { get { return _line802LOCompAdditionalAmount2; } set { _line802LOCompAdditionalAmount2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine802LOCompAdditionalAmount2() => !_line802LOCompAdditionalAmount2.Clean;
        private Value<string> _line907InsuranceIndicator2015;
        public string Line907InsuranceIndicator2015 { get { return _line907InsuranceIndicator2015; } set { _line907InsuranceIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine907InsuranceIndicator2015() => !_line907InsuranceIndicator2015.Clean;
        private Value<string> _line907PropertyIndicator2015;
        public string Line907PropertyIndicator2015 { get { return _line907PropertyIndicator2015; } set { _line907PropertyIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine907PropertyIndicator2015() => !_line907PropertyIndicator2015.Clean;
        private Value<string> _line907TaxesIndicator2015;
        public string Line907TaxesIndicator2015 { get { return _line907TaxesIndicator2015; } set { _line907TaxesIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine907TaxesIndicator2015() => !_line907TaxesIndicator2015.Clean;
        private Value<string> _line908InsuranceIndicator2015;
        public string Line908InsuranceIndicator2015 { get { return _line908InsuranceIndicator2015; } set { _line908InsuranceIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine908InsuranceIndicator2015() => !_line908InsuranceIndicator2015.Clean;
        private Value<string> _line908PropertyIndicator2015;
        public string Line908PropertyIndicator2015 { get { return _line908PropertyIndicator2015; } set { _line908PropertyIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine908PropertyIndicator2015() => !_line908PropertyIndicator2015.Clean;
        private Value<string> _line908TaxesIndicator2015;
        public string Line908TaxesIndicator2015 { get { return _line908TaxesIndicator2015; } set { _line908TaxesIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine908TaxesIndicator2015() => !_line908TaxesIndicator2015.Clean;
        private Value<string> _line909InsuranceIndicator2015;
        public string Line909InsuranceIndicator2015 { get { return _line909InsuranceIndicator2015; } set { _line909InsuranceIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine909InsuranceIndicator2015() => !_line909InsuranceIndicator2015.Clean;
        private Value<string> _line909PropertyIndicator2015;
        public string Line909PropertyIndicator2015 { get { return _line909PropertyIndicator2015; } set { _line909PropertyIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine909PropertyIndicator2015() => !_line909PropertyIndicator2015.Clean;
        private Value<string> _line909TaxesIndicator2015;
        public string Line909TaxesIndicator2015 { get { return _line909TaxesIndicator2015; } set { _line909TaxesIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine909TaxesIndicator2015() => !_line909TaxesIndicator2015.Clean;
        private Value<string> _line910InsuranceIndicator2015;
        public string Line910InsuranceIndicator2015 { get { return _line910InsuranceIndicator2015; } set { _line910InsuranceIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine910InsuranceIndicator2015() => !_line910InsuranceIndicator2015.Clean;
        private Value<string> _line910PropertyIndicator2015;
        public string Line910PropertyIndicator2015 { get { return _line910PropertyIndicator2015; } set { _line910PropertyIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine910PropertyIndicator2015() => !_line910PropertyIndicator2015.Clean;
        private Value<string> _line910TaxesIndicator2015;
        public string Line910TaxesIndicator2015 { get { return _line910TaxesIndicator2015; } set { _line910TaxesIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine910TaxesIndicator2015() => !_line910TaxesIndicator2015.Clean;
        private Value<string> _line911InsuranceIndicator2015;
        public string Line911InsuranceIndicator2015 { get { return _line911InsuranceIndicator2015; } set { _line911InsuranceIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine911InsuranceIndicator2015() => !_line911InsuranceIndicator2015.Clean;
        private Value<string> _line911PropertyIndicator2015;
        public string Line911PropertyIndicator2015 { get { return _line911PropertyIndicator2015; } set { _line911PropertyIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine911PropertyIndicator2015() => !_line911PropertyIndicator2015.Clean;
        private Value<string> _line911TaxesIndicator2015;
        public string Line911TaxesIndicator2015 { get { return _line911TaxesIndicator2015; } set { _line911TaxesIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine911TaxesIndicator2015() => !_line911TaxesIndicator2015.Clean;
        private Value<string> _line912InsuranceIndicator2015;
        public string Line912InsuranceIndicator2015 { get { return _line912InsuranceIndicator2015; } set { _line912InsuranceIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine912InsuranceIndicator2015() => !_line912InsuranceIndicator2015.Clean;
        private Value<string> _line912PropertyIndicator2015;
        public string Line912PropertyIndicator2015 { get { return _line912PropertyIndicator2015; } set { _line912PropertyIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine912PropertyIndicator2015() => !_line912PropertyIndicator2015.Clean;
        private Value<string> _line912TaxesIndicator2015;
        public string Line912TaxesIndicator2015 { get { return _line912TaxesIndicator2015; } set { _line912TaxesIndicator2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine912TaxesIndicator2015() => !_line912TaxesIndicator2015.Clean;
        private Value<string> _loanAdjustmentsOtherCredits;
        public string LoanAdjustmentsOtherCredits { get { return _loanAdjustmentsOtherCredits; } set { _loanAdjustmentsOtherCredits = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAdjustmentsOtherCredits() => !_loanAdjustmentsOtherCredits.Clean;
        private Value<string> _loanAmount;
        public string LoanAmount { get { return _loanAmount; } set { _loanAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmount() => !_loanAmount.Clean;
        private Value<string> _loanClosingCost2BorrowerClosingCostAtClosing;
        public string LoanClosingCost2BorrowerClosingCostAtClosing { get { return _loanClosingCost2BorrowerClosingCostAtClosing; } set { _loanClosingCost2BorrowerClosingCostAtClosing = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCost2BorrowerClosingCostAtClosing() => !_loanClosingCost2BorrowerClosingCostAtClosing.Clean;
        private Value<string> _loanClosingCost2LenderCredits;
        public string LoanClosingCost2LenderCredits { get { return _loanClosingCost2LenderCredits; } set { _loanClosingCost2LenderCredits = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCost2LenderCredits() => !_loanClosingCost2LenderCredits.Clean;
        private Value<string> _loanClosingCost2TotalLoanCost;
        public string LoanClosingCost2TotalLoanCost { get { return _loanClosingCost2TotalLoanCost; } set { _loanClosingCost2TotalLoanCost = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCost2TotalLoanCost() => !_loanClosingCost2TotalLoanCost.Clean;
        private Value<string> _loanClosingCost2TotalOtherCost;
        public string LoanClosingCost2TotalOtherCost { get { return _loanClosingCost2TotalOtherCost; } set { _loanClosingCost2TotalOtherCost = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCost2TotalOtherCost() => !_loanClosingCost2TotalOtherCost.Clean;
        private Value<string> _loanClosingCost3StdLegalLimit;
        public string LoanClosingCost3StdLegalLimit { get { return _loanClosingCost3StdLegalLimit; } set { _loanClosingCost3StdLegalLimit = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCost3StdLegalLimit() => !_loanClosingCost3StdLegalLimit.Clean;
        private Value<string> _loanClosingCostGfe1200BorPaidAmount;
        public string LoanClosingCostGfe1200BorPaidAmount { get { return _loanClosingCostGfe1200BorPaidAmount; } set { _loanClosingCostGfe1200BorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCostGfe1200BorPaidAmount() => !_loanClosingCostGfe1200BorPaidAmount.Clean;
        private Value<string> _loanClosingCostGfe800BorPaidAmount;
        public string LoanClosingCostGfe800BorPaidAmount { get { return _loanClosingCostGfe800BorPaidAmount; } set { _loanClosingCostGfe800BorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCostGfe800BorPaidAmount() => !_loanClosingCostGfe800BorPaidAmount.Clean;
        private Value<string> _loanClosingCostLenderCredits;
        public string LoanClosingCostLenderCredits { get { return _loanClosingCostLenderCredits; } set { _loanClosingCostLenderCredits = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCostLenderCredits() => !_loanClosingCostLenderCredits.Clean;
        private Value<string> _loanClosingCostSection1000BorrowerTotalPaidAmount;
        public string LoanClosingCostSection1000BorrowerTotalPaidAmount { get { return _loanClosingCostSection1000BorrowerTotalPaidAmount; } set { _loanClosingCostSection1000BorrowerTotalPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCostSection1000BorrowerTotalPaidAmount() => !_loanClosingCostSection1000BorrowerTotalPaidAmount.Clean;
        private Value<string> _loanClosingCostsFinanced;
        public string LoanClosingCostsFinanced { get { return _loanClosingCostsFinanced; } set { _loanClosingCostsFinanced = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCostsFinanced() => !_loanClosingCostsFinanced.Clean;
        private Value<string> _loanClosingCostTotalFeeAmount2015;
        public string LoanClosingCostTotalFeeAmount2015 { get { return _loanClosingCostTotalFeeAmount2015; } set { _loanClosingCostTotalFeeAmount2015 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanClosingCostTotalFeeAmount2015() => !_loanClosingCostTotalFeeAmount2015.Clean;
        private Value<string> _loanDownPayment;
        public string LoanDownPayment { get { return _loanDownPayment; } set { _loanDownPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanDownPayment() => !_loanDownPayment.Clean;
        private Value<string> _loanEstimate2TotalLoanAndOtherCosts;
        public string LoanEstimate2TotalLoanAndOtherCosts { get { return _loanEstimate2TotalLoanAndOtherCosts; } set { _loanEstimate2TotalLoanAndOtherCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanEstimate2TotalLoanAndOtherCosts() => !_loanEstimate2TotalLoanAndOtherCosts.Clean;
        private Value<string> _loanEstimate2TotalLoanCosts;
        public string LoanEstimate2TotalLoanCosts { get { return _loanEstimate2TotalLoanCosts; } set { _loanEstimate2TotalLoanCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanEstimate2TotalLoanCosts() => !_loanEstimate2TotalLoanCosts.Clean;
        private Value<string> _loanEstimate2TotalOtherCosts;
        public string LoanEstimate2TotalOtherCosts { get { return _loanEstimate2TotalOtherCosts; } set { _loanEstimate2TotalOtherCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanEstimate2TotalOtherCosts() => !_loanEstimate2TotalOtherCosts.Clean;
        private Value<string> _loanEstimate2UnroundedTotalLoanCosts;
        public string LoanEstimate2UnroundedTotalLoanCosts { get { return _loanEstimate2UnroundedTotalLoanCosts; } set { _loanEstimate2UnroundedTotalLoanCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanEstimate2UnroundedTotalLoanCosts() => !_loanEstimate2UnroundedTotalLoanCosts.Clean;
        private Value<string> _loanEstimate2UnroundedTotalOtherCosts;
        public string LoanEstimate2UnroundedTotalOtherCosts { get { return _loanEstimate2UnroundedTotalOtherCosts; } set { _loanEstimate2UnroundedTotalOtherCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanEstimate2UnroundedTotalOtherCosts() => !_loanEstimate2UnroundedTotalOtherCosts.Clean;
        private Value<string> _loanEstimateLoanProduct;
        public string LoanEstimateLoanProduct { get { return _loanEstimateLoanProduct; } set { _loanEstimateLoanProduct = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanEstimateLoanProduct() => !_loanEstimateLoanProduct.Clean;
        private Value<string> _loanFeesCityTaxBorPaidAmount;
        public string LoanFeesCityTaxBorPaidAmount { get { return _loanFeesCityTaxBorPaidAmount; } set { _loanFeesCityTaxBorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanFeesCityTaxBorPaidAmount() => !_loanFeesCityTaxBorPaidAmount.Clean;
        private Value<string> _loanFeesStateTaxBorPaidAmount;
        public string LoanFeesStateTaxBorPaidAmount { get { return _loanFeesStateTaxBorPaidAmount; } set { _loanFeesStateTaxBorPaidAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanFeesStateTaxBorPaidAmount() => !_loanFeesStateTaxBorPaidAmount.Clean;
        private Value<string> _loanFundsForBorrower;
        public string LoanFundsForBorrower { get { return _loanFundsForBorrower; } set { _loanFundsForBorrower = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanFundsForBorrower() => !_loanFundsForBorrower.Clean;
        private Value<string> _loanGfeAgregateAdjustment;
        public string LoanGfeAgregateAdjustment { get { return _loanGfeAgregateAdjustment; } set { _loanGfeAgregateAdjustment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanGfeAgregateAdjustment() => !_loanGfeAgregateAdjustment.Clean;
        private Value<string> _loanGfeGovermentRecordingCharges;
        public string LoanGfeGovermentRecordingCharges { get { return _loanGfeGovermentRecordingCharges; } set { _loanGfeGovermentRecordingCharges = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanGfeGovermentRecordingCharges() => !_loanGfeGovermentRecordingCharges.Clean;
        private Value<string> _loanLineItemAmount;
        public string LoanLineItemAmount { get { return _loanLineItemAmount; } set { _loanLineItemAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanLineItemAmount() => !_loanLineItemAmount.Clean;
        private Value<string> _loanProgram;
        public string LoanProgram { get { return _loanProgram; } set { _loanProgram = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProgram() => !_loanProgram.Clean;
        private Value<string> _loanPurchaseCreditAmount1;
        public string LoanPurchaseCreditAmount1 { get { return _loanPurchaseCreditAmount1; } set { _loanPurchaseCreditAmount1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditAmount1() => !_loanPurchaseCreditAmount1.Clean;
        private Value<string> _loanPurchaseCreditAmount2;
        public string LoanPurchaseCreditAmount2 { get { return _loanPurchaseCreditAmount2; } set { _loanPurchaseCreditAmount2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditAmount2() => !_loanPurchaseCreditAmount2.Clean;
        private Value<string> _loanPurchaseCreditAmount3;
        public string LoanPurchaseCreditAmount3 { get { return _loanPurchaseCreditAmount3; } set { _loanPurchaseCreditAmount3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditAmount3() => !_loanPurchaseCreditAmount3.Clean;
        private Value<string> _loanPurchaseCreditAmount4;
        public string LoanPurchaseCreditAmount4 { get { return _loanPurchaseCreditAmount4; } set { _loanPurchaseCreditAmount4 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditAmount4() => !_loanPurchaseCreditAmount4.Clean;
        private Value<string> _loanPurchaseCreditType1;
        public string LoanPurchaseCreditType1 { get { return _loanPurchaseCreditType1; } set { _loanPurchaseCreditType1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditType1() => !_loanPurchaseCreditType1.Clean;
        private Value<string> _loanPurchaseCreditType2;
        public string LoanPurchaseCreditType2 { get { return _loanPurchaseCreditType2; } set { _loanPurchaseCreditType2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditType2() => !_loanPurchaseCreditType2.Clean;
        private Value<string> _loanPurchaseCreditType3;
        public string LoanPurchaseCreditType3 { get { return _loanPurchaseCreditType3; } set { _loanPurchaseCreditType3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditType3() => !_loanPurchaseCreditType3.Clean;
        private Value<string> _loanPurchaseCreditType4;
        public string LoanPurchaseCreditType4 { get { return _loanPurchaseCreditType4; } set { _loanPurchaseCreditType4 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurchaseCreditType4() => !_loanPurchaseCreditType4.Clean;
        private Value<string> _loanRefinanceIncludingDebtsToBePaidOffAmount;
        public string LoanRefinanceIncludingDebtsToBePaidOffAmount { get { return _loanRefinanceIncludingDebtsToBePaidOffAmount; } set { _loanRefinanceIncludingDebtsToBePaidOffAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanRefinanceIncludingDebtsToBePaidOffAmount() => !_loanRefinanceIncludingDebtsToBePaidOffAmount.Clean;
        private Value<string> _loanSection1000SellerPaidTotalAmount;
        public string LoanSection1000SellerPaidTotalAmount { get { return _loanSection1000SellerPaidTotalAmount; } set { _loanSection1000SellerPaidTotalAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSection1000SellerPaidTotalAmount() => !_loanSection1000SellerPaidTotalAmount.Clean;
        private Value<string> _loanSellerCreditAmount;
        public string LoanSellerCreditAmount { get { return _loanSellerCreditAmount; } set { _loanSellerCreditAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSellerCreditAmount() => !_loanSellerCreditAmount.Clean;
        private Value<string> _loanTotalClosingCosts;
        public string LoanTotalClosingCosts { get { return _loanTotalClosingCosts; } set { _loanTotalClosingCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanTotalClosingCosts() => !_loanTotalClosingCosts.Clean;
        private Value<DateTime?> _lockedBorrowerPresumedReceivedDate;
        public DateTime? LockedBorrowerPresumedReceivedDate { get { return _lockedBorrowerPresumedReceivedDate; } set { _lockedBorrowerPresumedReceivedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockedBorrowerPresumedReceivedDate() => !_lockedBorrowerPresumedReceivedDate.Clean;
        private Value<DateTime?> _lockedCoBorrowerPresumedReceivedDate;
        public DateTime? LockedCoBorrowerPresumedReceivedDate { get { return _lockedCoBorrowerPresumedReceivedDate; } set { _lockedCoBorrowerPresumedReceivedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockedCoBorrowerPresumedReceivedDate() => !_lockedCoBorrowerPresumedReceivedDate.Clean;
        private Value<string> _lockedDisclosedAprField;
        public string LockedDisclosedAprField { get { return _lockedDisclosedAprField; } set { _lockedDisclosedAprField = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockedDisclosedAprField() => !_lockedDisclosedAprField.Clean;
        private Value<string> _lockedDisclosedByField;
        public string LockedDisclosedByField { get { return _lockedDisclosedByField; } set { _lockedDisclosedByField = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockedDisclosedByField() => !_lockedDisclosedByField.Clean;
        private Value<string> _lockedDisclosedFinanceChargeField;
        public string LockedDisclosedFinanceChargeField { get { return _lockedDisclosedFinanceChargeField; } set { _lockedDisclosedFinanceChargeField = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockedDisclosedFinanceChargeField() => !_lockedDisclosedFinanceChargeField.Clean;
        private Value<DateTime?> _lockedDisclosedReceivedDate;
        public DateTime? LockedDisclosedReceivedDate { get { return _lockedDisclosedReceivedDate; } set { _lockedDisclosedReceivedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockedDisclosedReceivedDate() => !_lockedDisclosedReceivedDate.Clean;
        private Value<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLogRecordIndex() => !_logRecordIndex.Clean;
        private Value<string> _manuallyCreated;
        public string ManuallyCreated { get { return _manuallyCreated; } set { _manuallyCreated = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeManuallyCreated() => !_manuallyCreated.Clean;
        private Value<string> _prepaymentPenaltyIndicator;
        public string PrepaymentPenaltyIndicator { get { return _prepaymentPenaltyIndicator; } set { _prepaymentPenaltyIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyIndicator() => !_prepaymentPenaltyIndicator.Clean;
        private Value<string> _propertyAddress;
        public string PropertyAddress { get { return _propertyAddress; } set { _propertyAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyAddress() => !_propertyAddress.Clean;
        private Value<string> _propertyCity;
        public string PropertyCity { get { return _propertyCity; } set { _propertyCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyCity() => !_propertyCity.Clean;
        private Value<string> _propertyState;
        public string PropertyState { get { return _propertyState; } set { _propertyState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyState() => !_propertyState.Clean;
        private Value<string> _propertyZip;
        public string PropertyZip { get { return _propertyZip; } set { _propertyZip = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyZip() => !_propertyZip.Clean;
        private Value<bool?> _providerListSent;
        public bool? ProviderListSent { get { return _providerListSent; } set { _providerListSent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProviderListSent() => !_providerListSent.Clean;
        private Value<string> _purchasePriceAmount;
        public string PurchasePriceAmount { get { return _purchasePriceAmount; } set { _purchasePriceAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchasePriceAmount() => !_purchasePriceAmount.Clean;
        private Value<DateTime?> _receivedDate;
        public DateTime? ReceivedDate { get { return _receivedDate; } set { _receivedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceivedDate() => !_receivedDate.Clean;
        private Value<List<LogSnapshotField>> _snapshotFields;
        public List<LogSnapshotField> SnapshotFields { get { return _snapshotFields; } set { _snapshotFields = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSnapshotFields() => !_snapshotFields.Clean;
        private Value<string> _snapshotXml;
        public string SnapshotXml { get { return _snapshotXml; } set { _snapshotXml = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSnapshotXml() => !_snapshotXml.Clean;
        private Value<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSystemId() => !_systemId.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _alerts.Clean
                    && _alertsXml.Clean
                    && _applicationDate.Clean
                    && _appliedCureAmount.Clean
                    && _borrowerActualReceivedDate.Clean
                    && _borrowerDisclosedMethod.Clean
                    && _borrowerDisclosedMethodOther.Clean
                    && _borrowerName.Clean
                    && _borrowerPairId.Clean
                    && _borrowerPresumedReceivedDate.Clean
                    && _borrowerType.Clean
                    && _cDReasonIs24HourAdvancePreview.Clean
                    && _cDReasonIsChangeInAPR.Clean
                    && _cDReasonIsChangeInLoanProduct.Clean
                    && _cDReasonIsChangeInSettlementCharges.Clean
                    && _cDReasonIsClericalErrorCorrection.Clean
                    && _cDReasonIsOther.Clean
                    && _cDReasonIsPrepaymentPenaltyAdded.Clean
                    && _cDReasonIsToleranceCure.Clean
                    && _cDReasonOther.Clean
                    && _changeInCircumstance.Clean
                    && _changeInCircumstanceComments.Clean
                    && _chargesCannotIncrease10Itemization34.Clean
                    && _chargesCannotIncrease10LE32.Clean
                    && _chargesThatCannotDecreaseItemization9.Clean
                    && _chargesThatCannotDecreaseLE7.Clean
                    && _chargesThatCannotIncreaseItemization13.Clean
                    && _chargesThatCannotIncreaseLE11.Clean
                    && _coBorrowerActualReceivedDate.Clean
                    && _coBorrowerDisclosedMethod.Clean
                    && _coBorrowerDisclosedMethodOther.Clean
                    && _coBorrowerName.Clean
                    && _coBorrowerPresumedReceivedDate.Clean
                    && _coBorrowerType.Clean
                    && _commentList.Clean
                    && _commentListXml.Clean
                    && _comments.Clean
                    && _containCD.Clean
                    && _containLE.Clean
                    && _containSafeHarbor.Clean
                    && _dateAdded.Clean
                    && _dateUtc.Clean
                    && _disclosedAPR.Clean
                    && _disclosedBy.Clean
                    && _disclosedByFullName.Clean
                    && _disclosedDailyInterest.Clean
                    && _disclosedDate.Clean
                    && _disclosedForCD.Clean
                    && _disclosedMethod.Clean
                    && _disclosedMethodName.Clean
                    && _disclosedMethodOther.Clean
                    && _disclosureCreatedDttmUtc.Clean
                    && _disclosureMethod.Clean
                    && _disclosureType.Clean
                    && _eDisclosureApplicationPackageIndicator.Clean
                    && _eDisclosureApprovalPackageIndicator.Clean
                    && _eDisclosureBorrowerAcceptConsentDate.Clean
                    && _eDisclosureBorrowereSignedDate.Clean
                    && _eDisclosureBorrowerRejectConsentDate.Clean
                    && _eDisclosureBorrowerViewConsentDate.Clean
                    && _eDisclosureBorrowerViewMessageDate.Clean
                    && _eDisclosureBorrowerWetSignedDate.Clean
                    && _eDisclosureCoBorrowerAcceptConsentDate.Clean
                    && _eDisclosureCoBorrowereSignedDate.Clean
                    && _eDisclosureCoBorrowerRejectConsentDate.Clean
                    && _eDisclosureCoBorrowerViewConsentDate.Clean
                    && _eDisclosureCoBorrowerViewMessageDate.Clean
                    && _eDisclosureCoBorrowerWebSignedDate.Clean
                    && _eDisclosureConsentPdf.Clean
                    && _eDisclosureDisclosedMessage.Clean
                    && _eDisclosureLockPackageIndicator.Clean
                    && _eDisclosureManualFulfillmentComment.Clean
                    && _eDisclosureManualFulfillmentDate.Clean
                    && _eDisclosureManualFulfillmentMethod.Clean
                    && _eDisclosureManuallyFulfilledBy.Clean
                    && _eDisclosurePackageCreatedDate.Clean
                    && _eDisclosurePackageId.Clean
                    && _eDisclosurePackageViewableFile.Clean
                    && _eDisclosureThreeDayPackageIndicator.Clean
                    && _estimatedTotalPayoffsAndPaymentsAmount.Clean
                    && _fileAttachmentsMigrated.Clean
                    && _financeCharge.Clean
                    && _forms.Clean
                    && _formsXml.Clean
                    && _fulfillmentOrderedBy.Clean
                    && _fullfillmentProcessedDate.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _intentToProceed.Clean
                    && _intentToProceedComments.Clean
                    && _intentToProceedDate.Clean
                    && _intentToProceedReceivedBy.Clean
                    && _intentToProceedReceivedMethod.Clean
                    && _intentToProceedReceivedMethodOther.Clean
                    && _isBorrowerPresumedDateLocked.Clean
                    && _isCoBorrowerPresumedDateLocked.Clean
                    && _isDisclosed.Clean
                    && _isDisclosedAprLocked.Clean
                    && _isDisclosedByLocked.Clean
                    && _isDisclosedFinanceChargeLocked.Clean
                    && _isDisclosedReceivedDateLocked.Clean
                    && _isLocked.Clean
                    && _isSystemSpecificIndicator.Clean
                    && _isWetSignedIndicator.Clean
                    && _lenderCompensationCreditAmount2.Clean
                    && _lenderTotalPaidOriginatorAmount.Clean
                    && _lEReasonIsChangedCircumstanceEligibility.Clean
                    && _lEReasonIsChangedCircumstanceSettlementCharges.Clean
                    && _lEReasonIsDelayedSettlementOnConstructionLoans.Clean
                    && _lEReasonIsExpiration.Clean
                    && _lEReasonIsInterestRateDependentCharges.Clean
                    && _lEReasonIsOther.Clean
                    && _lEReasonIsRevisionsRequestedByConsumer.Clean
                    && _lEReasonOther.Clean
                    && _line802LOCompAdditionalAmount1.Clean
                    && _line802LOCompAdditionalAmount2.Clean
                    && _line907InsuranceIndicator2015.Clean
                    && _line907PropertyIndicator2015.Clean
                    && _line907TaxesIndicator2015.Clean
                    && _line908InsuranceIndicator2015.Clean
                    && _line908PropertyIndicator2015.Clean
                    && _line908TaxesIndicator2015.Clean
                    && _line909InsuranceIndicator2015.Clean
                    && _line909PropertyIndicator2015.Clean
                    && _line909TaxesIndicator2015.Clean
                    && _line910InsuranceIndicator2015.Clean
                    && _line910PropertyIndicator2015.Clean
                    && _line910TaxesIndicator2015.Clean
                    && _line911InsuranceIndicator2015.Clean
                    && _line911PropertyIndicator2015.Clean
                    && _line911TaxesIndicator2015.Clean
                    && _line912InsuranceIndicator2015.Clean
                    && _line912PropertyIndicator2015.Clean
                    && _line912TaxesIndicator2015.Clean
                    && _loanAdjustmentsOtherCredits.Clean
                    && _loanAmount.Clean
                    && _loanClosingCost2BorrowerClosingCostAtClosing.Clean
                    && _loanClosingCost2LenderCredits.Clean
                    && _loanClosingCost2TotalLoanCost.Clean
                    && _loanClosingCost2TotalOtherCost.Clean
                    && _loanClosingCost3StdLegalLimit.Clean
                    && _loanClosingCostGfe1200BorPaidAmount.Clean
                    && _loanClosingCostGfe800BorPaidAmount.Clean
                    && _loanClosingCostLenderCredits.Clean
                    && _loanClosingCostSection1000BorrowerTotalPaidAmount.Clean
                    && _loanClosingCostsFinanced.Clean
                    && _loanClosingCostTotalFeeAmount2015.Clean
                    && _loanDownPayment.Clean
                    && _loanEstimate2TotalLoanAndOtherCosts.Clean
                    && _loanEstimate2TotalLoanCosts.Clean
                    && _loanEstimate2TotalOtherCosts.Clean
                    && _loanEstimate2UnroundedTotalLoanCosts.Clean
                    && _loanEstimate2UnroundedTotalOtherCosts.Clean
                    && _loanEstimateLoanProduct.Clean
                    && _loanFeesCityTaxBorPaidAmount.Clean
                    && _loanFeesStateTaxBorPaidAmount.Clean
                    && _loanFundsForBorrower.Clean
                    && _loanGfeAgregateAdjustment.Clean
                    && _loanGfeGovermentRecordingCharges.Clean
                    && _loanLineItemAmount.Clean
                    && _loanProgram.Clean
                    && _loanPurchaseCreditAmount1.Clean
                    && _loanPurchaseCreditAmount2.Clean
                    && _loanPurchaseCreditAmount3.Clean
                    && _loanPurchaseCreditAmount4.Clean
                    && _loanPurchaseCreditType1.Clean
                    && _loanPurchaseCreditType2.Clean
                    && _loanPurchaseCreditType3.Clean
                    && _loanPurchaseCreditType4.Clean
                    && _loanRefinanceIncludingDebtsToBePaidOffAmount.Clean
                    && _loanSection1000SellerPaidTotalAmount.Clean
                    && _loanSellerCreditAmount.Clean
                    && _loanTotalClosingCosts.Clean
                    && _lockedBorrowerPresumedReceivedDate.Clean
                    && _lockedCoBorrowerPresumedReceivedDate.Clean
                    && _lockedDisclosedAprField.Clean
                    && _lockedDisclosedByField.Clean
                    && _lockedDisclosedFinanceChargeField.Clean
                    && _lockedDisclosedReceivedDate.Clean
                    && _logRecordIndex.Clean
                    && _manuallyCreated.Clean
                    && _prepaymentPenaltyIndicator.Clean
                    && _propertyAddress.Clean
                    && _propertyCity.Clean
                    && _propertyState.Clean
                    && _propertyZip.Clean
                    && _providerListSent.Clean
                    && _purchasePriceAmount.Clean
                    && _receivedDate.Clean
                    && _snapshotFields.Clean
                    && _snapshotXml.Clean
                    && _systemId.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _alerts; v0.Clean = value; _alerts = v0;
                var v1 = _alertsXml; v1.Clean = value; _alertsXml = v1;
                var v2 = _applicationDate; v2.Clean = value; _applicationDate = v2;
                var v3 = _appliedCureAmount; v3.Clean = value; _appliedCureAmount = v3;
                var v4 = _borrowerActualReceivedDate; v4.Clean = value; _borrowerActualReceivedDate = v4;
                var v5 = _borrowerDisclosedMethod; v5.Clean = value; _borrowerDisclosedMethod = v5;
                var v6 = _borrowerDisclosedMethodOther; v6.Clean = value; _borrowerDisclosedMethodOther = v6;
                var v7 = _borrowerName; v7.Clean = value; _borrowerName = v7;
                var v8 = _borrowerPairId; v8.Clean = value; _borrowerPairId = v8;
                var v9 = _borrowerPresumedReceivedDate; v9.Clean = value; _borrowerPresumedReceivedDate = v9;
                var v10 = _borrowerType; v10.Clean = value; _borrowerType = v10;
                var v11 = _cDReasonIs24HourAdvancePreview; v11.Clean = value; _cDReasonIs24HourAdvancePreview = v11;
                var v12 = _cDReasonIsChangeInAPR; v12.Clean = value; _cDReasonIsChangeInAPR = v12;
                var v13 = _cDReasonIsChangeInLoanProduct; v13.Clean = value; _cDReasonIsChangeInLoanProduct = v13;
                var v14 = _cDReasonIsChangeInSettlementCharges; v14.Clean = value; _cDReasonIsChangeInSettlementCharges = v14;
                var v15 = _cDReasonIsClericalErrorCorrection; v15.Clean = value; _cDReasonIsClericalErrorCorrection = v15;
                var v16 = _cDReasonIsOther; v16.Clean = value; _cDReasonIsOther = v16;
                var v17 = _cDReasonIsPrepaymentPenaltyAdded; v17.Clean = value; _cDReasonIsPrepaymentPenaltyAdded = v17;
                var v18 = _cDReasonIsToleranceCure; v18.Clean = value; _cDReasonIsToleranceCure = v18;
                var v19 = _cDReasonOther; v19.Clean = value; _cDReasonOther = v19;
                var v20 = _changeInCircumstance; v20.Clean = value; _changeInCircumstance = v20;
                var v21 = _changeInCircumstanceComments; v21.Clean = value; _changeInCircumstanceComments = v21;
                var v22 = _chargesCannotIncrease10Itemization34; v22.Clean = value; _chargesCannotIncrease10Itemization34 = v22;
                var v23 = _chargesCannotIncrease10LE32; v23.Clean = value; _chargesCannotIncrease10LE32 = v23;
                var v24 = _chargesThatCannotDecreaseItemization9; v24.Clean = value; _chargesThatCannotDecreaseItemization9 = v24;
                var v25 = _chargesThatCannotDecreaseLE7; v25.Clean = value; _chargesThatCannotDecreaseLE7 = v25;
                var v26 = _chargesThatCannotIncreaseItemization13; v26.Clean = value; _chargesThatCannotIncreaseItemization13 = v26;
                var v27 = _chargesThatCannotIncreaseLE11; v27.Clean = value; _chargesThatCannotIncreaseLE11 = v27;
                var v28 = _coBorrowerActualReceivedDate; v28.Clean = value; _coBorrowerActualReceivedDate = v28;
                var v29 = _coBorrowerDisclosedMethod; v29.Clean = value; _coBorrowerDisclosedMethod = v29;
                var v30 = _coBorrowerDisclosedMethodOther; v30.Clean = value; _coBorrowerDisclosedMethodOther = v30;
                var v31 = _coBorrowerName; v31.Clean = value; _coBorrowerName = v31;
                var v32 = _coBorrowerPresumedReceivedDate; v32.Clean = value; _coBorrowerPresumedReceivedDate = v32;
                var v33 = _coBorrowerType; v33.Clean = value; _coBorrowerType = v33;
                var v34 = _commentList; v34.Clean = value; _commentList = v34;
                var v35 = _commentListXml; v35.Clean = value; _commentListXml = v35;
                var v36 = _comments; v36.Clean = value; _comments = v36;
                var v37 = _containCD; v37.Clean = value; _containCD = v37;
                var v38 = _containLE; v38.Clean = value; _containLE = v38;
                var v39 = _containSafeHarbor; v39.Clean = value; _containSafeHarbor = v39;
                var v40 = _dateAdded; v40.Clean = value; _dateAdded = v40;
                var v41 = _dateUtc; v41.Clean = value; _dateUtc = v41;
                var v42 = _disclosedAPR; v42.Clean = value; _disclosedAPR = v42;
                var v43 = _disclosedBy; v43.Clean = value; _disclosedBy = v43;
                var v44 = _disclosedByFullName; v44.Clean = value; _disclosedByFullName = v44;
                var v45 = _disclosedDailyInterest; v45.Clean = value; _disclosedDailyInterest = v45;
                var v46 = _disclosedDate; v46.Clean = value; _disclosedDate = v46;
                var v47 = _disclosedForCD; v47.Clean = value; _disclosedForCD = v47;
                var v48 = _disclosedMethod; v48.Clean = value; _disclosedMethod = v48;
                var v49 = _disclosedMethodName; v49.Clean = value; _disclosedMethodName = v49;
                var v50 = _disclosedMethodOther; v50.Clean = value; _disclosedMethodOther = v50;
                var v51 = _disclosureCreatedDttmUtc; v51.Clean = value; _disclosureCreatedDttmUtc = v51;
                var v52 = _disclosureMethod; v52.Clean = value; _disclosureMethod = v52;
                var v53 = _disclosureType; v53.Clean = value; _disclosureType = v53;
                var v54 = _eDisclosureApplicationPackageIndicator; v54.Clean = value; _eDisclosureApplicationPackageIndicator = v54;
                var v55 = _eDisclosureApprovalPackageIndicator; v55.Clean = value; _eDisclosureApprovalPackageIndicator = v55;
                var v56 = _eDisclosureBorrowerAcceptConsentDate; v56.Clean = value; _eDisclosureBorrowerAcceptConsentDate = v56;
                var v57 = _eDisclosureBorrowereSignedDate; v57.Clean = value; _eDisclosureBorrowereSignedDate = v57;
                var v58 = _eDisclosureBorrowerRejectConsentDate; v58.Clean = value; _eDisclosureBorrowerRejectConsentDate = v58;
                var v59 = _eDisclosureBorrowerViewConsentDate; v59.Clean = value; _eDisclosureBorrowerViewConsentDate = v59;
                var v60 = _eDisclosureBorrowerViewMessageDate; v60.Clean = value; _eDisclosureBorrowerViewMessageDate = v60;
                var v61 = _eDisclosureBorrowerWetSignedDate; v61.Clean = value; _eDisclosureBorrowerWetSignedDate = v61;
                var v62 = _eDisclosureCoBorrowerAcceptConsentDate; v62.Clean = value; _eDisclosureCoBorrowerAcceptConsentDate = v62;
                var v63 = _eDisclosureCoBorrowereSignedDate; v63.Clean = value; _eDisclosureCoBorrowereSignedDate = v63;
                var v64 = _eDisclosureCoBorrowerRejectConsentDate; v64.Clean = value; _eDisclosureCoBorrowerRejectConsentDate = v64;
                var v65 = _eDisclosureCoBorrowerViewConsentDate; v65.Clean = value; _eDisclosureCoBorrowerViewConsentDate = v65;
                var v66 = _eDisclosureCoBorrowerViewMessageDate; v66.Clean = value; _eDisclosureCoBorrowerViewMessageDate = v66;
                var v67 = _eDisclosureCoBorrowerWebSignedDate; v67.Clean = value; _eDisclosureCoBorrowerWebSignedDate = v67;
                var v68 = _eDisclosureConsentPdf; v68.Clean = value; _eDisclosureConsentPdf = v68;
                var v69 = _eDisclosureDisclosedMessage; v69.Clean = value; _eDisclosureDisclosedMessage = v69;
                var v70 = _eDisclosureLockPackageIndicator; v70.Clean = value; _eDisclosureLockPackageIndicator = v70;
                var v71 = _eDisclosureManualFulfillmentComment; v71.Clean = value; _eDisclosureManualFulfillmentComment = v71;
                var v72 = _eDisclosureManualFulfillmentDate; v72.Clean = value; _eDisclosureManualFulfillmentDate = v72;
                var v73 = _eDisclosureManualFulfillmentMethod; v73.Clean = value; _eDisclosureManualFulfillmentMethod = v73;
                var v74 = _eDisclosureManuallyFulfilledBy; v74.Clean = value; _eDisclosureManuallyFulfilledBy = v74;
                var v75 = _eDisclosurePackageCreatedDate; v75.Clean = value; _eDisclosurePackageCreatedDate = v75;
                var v76 = _eDisclosurePackageId; v76.Clean = value; _eDisclosurePackageId = v76;
                var v77 = _eDisclosurePackageViewableFile; v77.Clean = value; _eDisclosurePackageViewableFile = v77;
                var v78 = _eDisclosureThreeDayPackageIndicator; v78.Clean = value; _eDisclosureThreeDayPackageIndicator = v78;
                var v79 = _estimatedTotalPayoffsAndPaymentsAmount; v79.Clean = value; _estimatedTotalPayoffsAndPaymentsAmount = v79;
                var v80 = _fileAttachmentsMigrated; v80.Clean = value; _fileAttachmentsMigrated = v80;
                var v81 = _financeCharge; v81.Clean = value; _financeCharge = v81;
                var v82 = _forms; v82.Clean = value; _forms = v82;
                var v83 = _formsXml; v83.Clean = value; _formsXml = v83;
                var v84 = _fulfillmentOrderedBy; v84.Clean = value; _fulfillmentOrderedBy = v84;
                var v85 = _fullfillmentProcessedDate; v85.Clean = value; _fullfillmentProcessedDate = v85;
                var v86 = _guid; v86.Clean = value; _guid = v86;
                var v87 = _id; v87.Clean = value; _id = v87;
                var v88 = _intentToProceed; v88.Clean = value; _intentToProceed = v88;
                var v89 = _intentToProceedComments; v89.Clean = value; _intentToProceedComments = v89;
                var v90 = _intentToProceedDate; v90.Clean = value; _intentToProceedDate = v90;
                var v91 = _intentToProceedReceivedBy; v91.Clean = value; _intentToProceedReceivedBy = v91;
                var v92 = _intentToProceedReceivedMethod; v92.Clean = value; _intentToProceedReceivedMethod = v92;
                var v93 = _intentToProceedReceivedMethodOther; v93.Clean = value; _intentToProceedReceivedMethodOther = v93;
                var v94 = _isBorrowerPresumedDateLocked; v94.Clean = value; _isBorrowerPresumedDateLocked = v94;
                var v95 = _isCoBorrowerPresumedDateLocked; v95.Clean = value; _isCoBorrowerPresumedDateLocked = v95;
                var v96 = _isDisclosed; v96.Clean = value; _isDisclosed = v96;
                var v97 = _isDisclosedAprLocked; v97.Clean = value; _isDisclosedAprLocked = v97;
                var v98 = _isDisclosedByLocked; v98.Clean = value; _isDisclosedByLocked = v98;
                var v99 = _isDisclosedFinanceChargeLocked; v99.Clean = value; _isDisclosedFinanceChargeLocked = v99;
                var v100 = _isDisclosedReceivedDateLocked; v100.Clean = value; _isDisclosedReceivedDateLocked = v100;
                var v101 = _isLocked; v101.Clean = value; _isLocked = v101;
                var v102 = _isSystemSpecificIndicator; v102.Clean = value; _isSystemSpecificIndicator = v102;
                var v103 = _isWetSignedIndicator; v103.Clean = value; _isWetSignedIndicator = v103;
                var v104 = _lenderCompensationCreditAmount2; v104.Clean = value; _lenderCompensationCreditAmount2 = v104;
                var v105 = _lenderTotalPaidOriginatorAmount; v105.Clean = value; _lenderTotalPaidOriginatorAmount = v105;
                var v106 = _lEReasonIsChangedCircumstanceEligibility; v106.Clean = value; _lEReasonIsChangedCircumstanceEligibility = v106;
                var v107 = _lEReasonIsChangedCircumstanceSettlementCharges; v107.Clean = value; _lEReasonIsChangedCircumstanceSettlementCharges = v107;
                var v108 = _lEReasonIsDelayedSettlementOnConstructionLoans; v108.Clean = value; _lEReasonIsDelayedSettlementOnConstructionLoans = v108;
                var v109 = _lEReasonIsExpiration; v109.Clean = value; _lEReasonIsExpiration = v109;
                var v110 = _lEReasonIsInterestRateDependentCharges; v110.Clean = value; _lEReasonIsInterestRateDependentCharges = v110;
                var v111 = _lEReasonIsOther; v111.Clean = value; _lEReasonIsOther = v111;
                var v112 = _lEReasonIsRevisionsRequestedByConsumer; v112.Clean = value; _lEReasonIsRevisionsRequestedByConsumer = v112;
                var v113 = _lEReasonOther; v113.Clean = value; _lEReasonOther = v113;
                var v114 = _line802LOCompAdditionalAmount1; v114.Clean = value; _line802LOCompAdditionalAmount1 = v114;
                var v115 = _line802LOCompAdditionalAmount2; v115.Clean = value; _line802LOCompAdditionalAmount2 = v115;
                var v116 = _line907InsuranceIndicator2015; v116.Clean = value; _line907InsuranceIndicator2015 = v116;
                var v117 = _line907PropertyIndicator2015; v117.Clean = value; _line907PropertyIndicator2015 = v117;
                var v118 = _line907TaxesIndicator2015; v118.Clean = value; _line907TaxesIndicator2015 = v118;
                var v119 = _line908InsuranceIndicator2015; v119.Clean = value; _line908InsuranceIndicator2015 = v119;
                var v120 = _line908PropertyIndicator2015; v120.Clean = value; _line908PropertyIndicator2015 = v120;
                var v121 = _line908TaxesIndicator2015; v121.Clean = value; _line908TaxesIndicator2015 = v121;
                var v122 = _line909InsuranceIndicator2015; v122.Clean = value; _line909InsuranceIndicator2015 = v122;
                var v123 = _line909PropertyIndicator2015; v123.Clean = value; _line909PropertyIndicator2015 = v123;
                var v124 = _line909TaxesIndicator2015; v124.Clean = value; _line909TaxesIndicator2015 = v124;
                var v125 = _line910InsuranceIndicator2015; v125.Clean = value; _line910InsuranceIndicator2015 = v125;
                var v126 = _line910PropertyIndicator2015; v126.Clean = value; _line910PropertyIndicator2015 = v126;
                var v127 = _line910TaxesIndicator2015; v127.Clean = value; _line910TaxesIndicator2015 = v127;
                var v128 = _line911InsuranceIndicator2015; v128.Clean = value; _line911InsuranceIndicator2015 = v128;
                var v129 = _line911PropertyIndicator2015; v129.Clean = value; _line911PropertyIndicator2015 = v129;
                var v130 = _line911TaxesIndicator2015; v130.Clean = value; _line911TaxesIndicator2015 = v130;
                var v131 = _line912InsuranceIndicator2015; v131.Clean = value; _line912InsuranceIndicator2015 = v131;
                var v132 = _line912PropertyIndicator2015; v132.Clean = value; _line912PropertyIndicator2015 = v132;
                var v133 = _line912TaxesIndicator2015; v133.Clean = value; _line912TaxesIndicator2015 = v133;
                var v134 = _loanAdjustmentsOtherCredits; v134.Clean = value; _loanAdjustmentsOtherCredits = v134;
                var v135 = _loanAmount; v135.Clean = value; _loanAmount = v135;
                var v136 = _loanClosingCost2BorrowerClosingCostAtClosing; v136.Clean = value; _loanClosingCost2BorrowerClosingCostAtClosing = v136;
                var v137 = _loanClosingCost2LenderCredits; v137.Clean = value; _loanClosingCost2LenderCredits = v137;
                var v138 = _loanClosingCost2TotalLoanCost; v138.Clean = value; _loanClosingCost2TotalLoanCost = v138;
                var v139 = _loanClosingCost2TotalOtherCost; v139.Clean = value; _loanClosingCost2TotalOtherCost = v139;
                var v140 = _loanClosingCost3StdLegalLimit; v140.Clean = value; _loanClosingCost3StdLegalLimit = v140;
                var v141 = _loanClosingCostGfe1200BorPaidAmount; v141.Clean = value; _loanClosingCostGfe1200BorPaidAmount = v141;
                var v142 = _loanClosingCostGfe800BorPaidAmount; v142.Clean = value; _loanClosingCostGfe800BorPaidAmount = v142;
                var v143 = _loanClosingCostLenderCredits; v143.Clean = value; _loanClosingCostLenderCredits = v143;
                var v144 = _loanClosingCostSection1000BorrowerTotalPaidAmount; v144.Clean = value; _loanClosingCostSection1000BorrowerTotalPaidAmount = v144;
                var v145 = _loanClosingCostsFinanced; v145.Clean = value; _loanClosingCostsFinanced = v145;
                var v146 = _loanClosingCostTotalFeeAmount2015; v146.Clean = value; _loanClosingCostTotalFeeAmount2015 = v146;
                var v147 = _loanDownPayment; v147.Clean = value; _loanDownPayment = v147;
                var v148 = _loanEstimate2TotalLoanAndOtherCosts; v148.Clean = value; _loanEstimate2TotalLoanAndOtherCosts = v148;
                var v149 = _loanEstimate2TotalLoanCosts; v149.Clean = value; _loanEstimate2TotalLoanCosts = v149;
                var v150 = _loanEstimate2TotalOtherCosts; v150.Clean = value; _loanEstimate2TotalOtherCosts = v150;
                var v151 = _loanEstimate2UnroundedTotalLoanCosts; v151.Clean = value; _loanEstimate2UnroundedTotalLoanCosts = v151;
                var v152 = _loanEstimate2UnroundedTotalOtherCosts; v152.Clean = value; _loanEstimate2UnroundedTotalOtherCosts = v152;
                var v153 = _loanEstimateLoanProduct; v153.Clean = value; _loanEstimateLoanProduct = v153;
                var v154 = _loanFeesCityTaxBorPaidAmount; v154.Clean = value; _loanFeesCityTaxBorPaidAmount = v154;
                var v155 = _loanFeesStateTaxBorPaidAmount; v155.Clean = value; _loanFeesStateTaxBorPaidAmount = v155;
                var v156 = _loanFundsForBorrower; v156.Clean = value; _loanFundsForBorrower = v156;
                var v157 = _loanGfeAgregateAdjustment; v157.Clean = value; _loanGfeAgregateAdjustment = v157;
                var v158 = _loanGfeGovermentRecordingCharges; v158.Clean = value; _loanGfeGovermentRecordingCharges = v158;
                var v159 = _loanLineItemAmount; v159.Clean = value; _loanLineItemAmount = v159;
                var v160 = _loanProgram; v160.Clean = value; _loanProgram = v160;
                var v161 = _loanPurchaseCreditAmount1; v161.Clean = value; _loanPurchaseCreditAmount1 = v161;
                var v162 = _loanPurchaseCreditAmount2; v162.Clean = value; _loanPurchaseCreditAmount2 = v162;
                var v163 = _loanPurchaseCreditAmount3; v163.Clean = value; _loanPurchaseCreditAmount3 = v163;
                var v164 = _loanPurchaseCreditAmount4; v164.Clean = value; _loanPurchaseCreditAmount4 = v164;
                var v165 = _loanPurchaseCreditType1; v165.Clean = value; _loanPurchaseCreditType1 = v165;
                var v166 = _loanPurchaseCreditType2; v166.Clean = value; _loanPurchaseCreditType2 = v166;
                var v167 = _loanPurchaseCreditType3; v167.Clean = value; _loanPurchaseCreditType3 = v167;
                var v168 = _loanPurchaseCreditType4; v168.Clean = value; _loanPurchaseCreditType4 = v168;
                var v169 = _loanRefinanceIncludingDebtsToBePaidOffAmount; v169.Clean = value; _loanRefinanceIncludingDebtsToBePaidOffAmount = v169;
                var v170 = _loanSection1000SellerPaidTotalAmount; v170.Clean = value; _loanSection1000SellerPaidTotalAmount = v170;
                var v171 = _loanSellerCreditAmount; v171.Clean = value; _loanSellerCreditAmount = v171;
                var v172 = _loanTotalClosingCosts; v172.Clean = value; _loanTotalClosingCosts = v172;
                var v173 = _lockedBorrowerPresumedReceivedDate; v173.Clean = value; _lockedBorrowerPresumedReceivedDate = v173;
                var v174 = _lockedCoBorrowerPresumedReceivedDate; v174.Clean = value; _lockedCoBorrowerPresumedReceivedDate = v174;
                var v175 = _lockedDisclosedAprField; v175.Clean = value; _lockedDisclosedAprField = v175;
                var v176 = _lockedDisclosedByField; v176.Clean = value; _lockedDisclosedByField = v176;
                var v177 = _lockedDisclosedFinanceChargeField; v177.Clean = value; _lockedDisclosedFinanceChargeField = v177;
                var v178 = _lockedDisclosedReceivedDate; v178.Clean = value; _lockedDisclosedReceivedDate = v178;
                var v179 = _logRecordIndex; v179.Clean = value; _logRecordIndex = v179;
                var v180 = _manuallyCreated; v180.Clean = value; _manuallyCreated = v180;
                var v181 = _prepaymentPenaltyIndicator; v181.Clean = value; _prepaymentPenaltyIndicator = v181;
                var v182 = _propertyAddress; v182.Clean = value; _propertyAddress = v182;
                var v183 = _propertyCity; v183.Clean = value; _propertyCity = v183;
                var v184 = _propertyState; v184.Clean = value; _propertyState = v184;
                var v185 = _propertyZip; v185.Clean = value; _propertyZip = v185;
                var v186 = _providerListSent; v186.Clean = value; _providerListSent = v186;
                var v187 = _purchasePriceAmount; v187.Clean = value; _purchasePriceAmount = v187;
                var v188 = _receivedDate; v188.Clean = value; _receivedDate = v188;
                var v189 = _snapshotFields; v189.Clean = value; _snapshotFields = v189;
                var v190 = _snapshotXml; v190.Clean = value; _snapshotXml = v190;
                var v191 = _systemId; v191.Clean = value; _systemId = v191;
                _settingClean = 0;
            }
        }
    }
}