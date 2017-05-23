using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Tax4506
    {
        public JsonNullable<bool?> AccountTranscript { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public JsonNullable<decimal?> CostForEachPeriod { get; set; }
        public string CurrentFirst { get; set; }
        public string CurrentLast { get; set; }
        public string First { get; set; }
        public JsonNullable<bool?> FormsSeriesTranscript { get; set; }
        public string HistoryId { get; set; }
        public bool? HistoryIndicator { get; set; }
        public string Id { get; set; }
        public JsonNullable<bool?> IfTaxRecordNotFound { get; set; }
        public string Last { get; set; }
        public JsonNullable<DateTime?> LastUpdatedDate { get; set; }
        public JsonNullable<int?> LastUpdatedHistory { get; set; }
        public string LastUpdatedTime { get; set; }
        public JsonNullable<bool?> NotifiedIrsIdentityTheftIndicator { get; set; }
        public JsonNullable<int?> NumberOfPeriods { get; set; }
        public string Person { get; set; }
        public JsonNullable<bool?> RecordOfAccount { get; set; }
        public string RequestorPhoneNumber { get; set; }
        public string RequestorTitle { get; set; }
        public JsonNullable<DateTime?> RequestYear1 { get; set; }
        public JsonNullable<DateTime?> RequestYear2 { get; set; }
        public JsonNullable<DateTime?> RequestYear3 { get; set; }
        public JsonNullable<DateTime?> RequestYear4 { get; set; }
        public JsonNullable<DateTime?> RequestYear5 { get; set; }
        public JsonNullable<DateTime?> RequestYear6 { get; set; }
        public JsonNullable<DateTime?> RequestYear7 { get; set; }
        public JsonNullable<DateTime?> RequestYear8 { get; set; }
        public string ReturnAddress { get; set; }
        public string ReturnCity { get; set; }
        public string ReturnState { get; set; }
        public JsonNullable<bool?> ReturnTranscript { get; set; }
        public string ReturnZip { get; set; }
        public string SelectedRecordNumber { get; set; }
        public string SendAddress { get; set; }
        public string SendCity { get; set; }
        public string SendFirst { get; set; }
        public string SendLast { get; set; }
        public string SendPhone { get; set; }
        public string SendState { get; set; }
        public string SendZip { get; set; }
        public JsonNullable<bool?> SignatoryAttestation { get; set; }
        public JsonNullable<bool?> SignatoryAttestationT { get; set; }
        public string SpouseFirst { get; set; }
        public string SpouseLast { get; set; }
        public string SpouseSSN { get; set; }
        public JsonNullable<bool?> SpouseUseEIN { get; set; }
        public string SSN { get; set; }
        public string State { get; set; }
        public int? Tax4506Index { get; set; }
        public bool? Tax4506TIndicator { get; set; }
        public string TaxFormNumber { get; set; }
        public JsonNullable<bool?> TheseCopiesMustBeCertified { get; set; }
        public JsonNullable<decimal?> TotalCost { get; set; }
        public JsonNullable<bool?> UseEIN { get; set; }
        public JsonNullable<bool?> UseWellsFargoRules { get; set; }
        public JsonNullable<bool?> VerificationOfNonfiling { get; set; }
        public string Zip { get; set; }
    }
}