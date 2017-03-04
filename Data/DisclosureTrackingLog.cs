
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class DisclosureTrackingLog
{
public string id { get; set; }
public List<LogAlert> alerts { get; set; }
public string borrowerPairId { get; set; }
public List<LogComment> commentList { get; set; }
public string comments { get; set; }
public bool? containGfe { get; set; }
public bool? containSafeHarbor { get; set; }
public bool? containTil { get; set; }
public DateTime? dateUtc { get; set; }
public string disclosedBy { get; set; }
public string disclosedByFullName { get; set; }
public string disclosedMethod { get; set; }
public DateTime? disclosureCreatedDttmUtc { get; set; }
public bool? eDisclosureApplicationPackageIndicator { get; set; }
public bool? eDisclosureApprovalPackageIndicator { get; set; }
public DateTime? eDisclosureBorrowerAcceptConsentDate { get; set; }
public DateTime? eDisclosureBorrowereSignedDate { get; set; }
public DateTime? eDisclosureBorrowerRejectConsentDate { get; set; }
public DateTime? eDisclosureBorrowerViewConsentDate { get; set; }
public DateTime? eDisclosureBorrowerViewMessageDate { get; set; }
public DateTime? eDisclosureBorrowerWetSignedDate { get; set; }
public DateTime? eDisclosureCoBorrowerAcceptConsentDate { get; set; }
public DateTime? eDisclosureCoBorrowereSignedDate { get; set; }
public DateTime? eDisclosureCoBorrowerRejectConsentDate { get; set; }
public DateTime? eDisclosureCoBorrowerViewConsentDate { get; set; }
public DateTime? eDisclosureCoBorrowerViewMessageDate { get; set; }
public DateTime? eDisclosureCoBorrowerWebSignedDate { get; set; }
public string eDisclosureConsentPdf { get; set; }
public string eDisclosureDisclosedMessage { get; set; }
public bool? eDisclosureLockPackageIndicator { get; set; }
public string eDisclosureManualFulfillmentComment { get; set; }
public DateTime? eDisclosureManualFulfillmentDate { get; set; }
public string eDisclosureManualFulfillmentMethod { get; set; }
public string eDisclosureManuallyFulfilledBy { get; set; }
public DateTime? eDisclosurePackageCreatedDate { get; set; }
public string eDisclosurePackageId { get; set; }
public string eDisclosurePackageViewableFile { get; set; }
public bool? eDisclosureThreeDayPackageIndicator { get; set; }
public bool? fileAttachmentsMigrated { get; set; }
public List<DisclosureForm> forms { get; set; }
public string fulfillmentOrderedBy { get; set; }
public string fullfillmentProcessedDate { get; set; }
public string guid { get; set; }
public string isDisclosed { get; set; }
public string isDisclosedAprLocked { get; set; }
public string isDisclosedByLocked { get; set; }
public string isDisclosedFinanceChargeLocked { get; set; }
public string isDisclosedReceivedDateLocked { get; set; }
public string isLocked { get; set; }
public bool? isSystemSpecificIndicator { get; set; }
public bool? isWetSignedIndicator { get; set; }
public string lockedDisclosedAprField { get; set; }
public string lockedDisclosedByField { get; set; }
public string lockedDisclosedFinanceChargeField { get; set; }
public DateTime? lockedDisclosedReceivedDate { get; set; }
public int? logRecordIndex { get; set; }
public string manuallyCreated { get; set; }
public DateTime? receivedDate { get; set; }
public List<LogSnapshotField> snapshotFields { get; set; }
public string systemId { get; set; }
public string formsXml { get; set; }
public string snapshotXml { get; set; }
public DateTime? applicationDate { get; set; }
public string borrowerName { get; set; }
public string coBorrowerName { get; set; }
public string disclosedAPR { get; set; }
public string financeCharge { get; set; }
public string loanProgram { get; set; }
public string loanAmount { get; set; }
public string propertyAddress { get; set; }
public string propertyCity { get; set; }
public string propertyState { get; set; }
public string propertyZip { get; set; }
public string alertsXml { get; set; }
public string commentListXml { get; set; }

    }
}