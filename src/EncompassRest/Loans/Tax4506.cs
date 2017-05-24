using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Tax4506
    {
        public Value<bool?> AccountTranscript { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAccountTranscript() => !AccountTranscript.Clean;
        public Value<string> Address { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress() => !Address.Clean;
        public Value<string> City { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !City.Clean;
        public Value<decimal?> CostForEachPeriod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCostForEachPeriod() => !CostForEachPeriod.Clean;
        public Value<string> CurrentFirst { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentFirst() => !CurrentFirst.Clean;
        public Value<string> CurrentLast { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentLast() => !CurrentLast.Clean;
        public Value<string> First { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirst() => !First.Clean;
        public Value<bool?> FormsSeriesTranscript { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFormsSeriesTranscript() => !FormsSeriesTranscript.Clean;
        public Value<string> HistoryId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHistoryId() => !HistoryId.Clean;
        public Value<bool?> HistoryIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHistoryIndicator() => !HistoryIndicator.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IfTaxRecordNotFound { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIfTaxRecordNotFound() => !IfTaxRecordNotFound.Clean;
        public Value<string> Last { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLast() => !Last.Clean;
        public Value<DateTime?> LastUpdatedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastUpdatedDate() => !LastUpdatedDate.Clean;
        public Value<int?> LastUpdatedHistory { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastUpdatedHistory() => !LastUpdatedHistory.Clean;
        public Value<string> LastUpdatedTime { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastUpdatedTime() => !LastUpdatedTime.Clean;
        public Value<bool?> NotifiedIrsIdentityTheftIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotifiedIrsIdentityTheftIndicator() => !NotifiedIrsIdentityTheftIndicator.Clean;
        public Value<int?> NumberOfPeriods { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfPeriods() => !NumberOfPeriods.Clean;
        public Value<string> Person { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePerson() => !Person.Clean;
        public Value<bool?> RecordOfAccount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecordOfAccount() => !RecordOfAccount.Clean;
        public Value<string> RequestorPhoneNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestorPhoneNumber() => !RequestorPhoneNumber.Clean;
        public Value<string> RequestorTitle { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestorTitle() => !RequestorTitle.Clean;
        public Value<DateTime?> RequestYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestYear1() => !RequestYear1.Clean;
        public Value<DateTime?> RequestYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestYear2() => !RequestYear2.Clean;
        public Value<DateTime?> RequestYear3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestYear3() => !RequestYear3.Clean;
        public Value<DateTime?> RequestYear4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestYear4() => !RequestYear4.Clean;
        public Value<DateTime?> RequestYear5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestYear5() => !RequestYear5.Clean;
        public Value<DateTime?> RequestYear6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestYear6() => !RequestYear6.Clean;
        public Value<DateTime?> RequestYear7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestYear7() => !RequestYear7.Clean;
        public Value<DateTime?> RequestYear8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestYear8() => !RequestYear8.Clean;
        public Value<string> ReturnAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReturnAddress() => !ReturnAddress.Clean;
        public Value<string> ReturnCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReturnCity() => !ReturnCity.Clean;
        public Value<string> ReturnState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReturnState() => !ReturnState.Clean;
        public Value<bool?> ReturnTranscript { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReturnTranscript() => !ReturnTranscript.Clean;
        public Value<string> ReturnZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReturnZip() => !ReturnZip.Clean;
        public Value<string> SelectedRecordNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSelectedRecordNumber() => !SelectedRecordNumber.Clean;
        public Value<string> SendAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSendAddress() => !SendAddress.Clean;
        public Value<string> SendCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSendCity() => !SendCity.Clean;
        public Value<string> SendFirst { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSendFirst() => !SendFirst.Clean;
        public Value<string> SendLast { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSendLast() => !SendLast.Clean;
        public Value<string> SendPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSendPhone() => !SendPhone.Clean;
        public Value<string> SendState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSendState() => !SendState.Clean;
        public Value<string> SendZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSendZip() => !SendZip.Clean;
        public Value<bool?> SignatoryAttestation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSignatoryAttestation() => !SignatoryAttestation.Clean;
        public Value<bool?> SignatoryAttestationT { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSignatoryAttestationT() => !SignatoryAttestationT.Clean;
        public Value<string> SpouseFirst { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpouseFirst() => !SpouseFirst.Clean;
        public Value<string> SpouseLast { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpouseLast() => !SpouseLast.Clean;
        public Value<string> SpouseSSN { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpouseSSN() => !SpouseSSN.Clean;
        public Value<bool?> SpouseUseEIN { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpouseUseEIN() => !SpouseUseEIN.Clean;
        public Value<string> SSN { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSSN() => !SSN.Clean;
        public Value<string> State { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !State.Clean;
        public Value<int?> Tax4506Index { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506Index() => !Tax4506Index.Clean;
        public Value<bool?> Tax4506TIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TIndicator() => !Tax4506TIndicator.Clean;
        public Value<string> TaxFormNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxFormNumber() => !TaxFormNumber.Clean;
        public Value<bool?> TheseCopiesMustBeCertified { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTheseCopiesMustBeCertified() => !TheseCopiesMustBeCertified.Clean;
        public Value<decimal?> TotalCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalCost() => !TotalCost.Clean;
        public Value<bool?> UseEIN { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUseEIN() => !UseEIN.Clean;
        public Value<bool?> UseWellsFargoRules { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUseWellsFargoRules() => !UseWellsFargoRules.Clean;
        public Value<bool?> VerificationOfNonfiling { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVerificationOfNonfiling() => !VerificationOfNonfiling.Clean;
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
                var clean = AccountTranscript.Clean
                    && Address.Clean
                    && City.Clean
                    && CostForEachPeriod.Clean
                    && CurrentFirst.Clean
                    && CurrentLast.Clean
                    && First.Clean
                    && FormsSeriesTranscript.Clean
                    && HistoryId.Clean
                    && HistoryIndicator.Clean
                    && Id.Clean
                    && IfTaxRecordNotFound.Clean
                    && Last.Clean
                    && LastUpdatedDate.Clean
                    && LastUpdatedHistory.Clean
                    && LastUpdatedTime.Clean
                    && NotifiedIrsIdentityTheftIndicator.Clean
                    && NumberOfPeriods.Clean
                    && Person.Clean
                    && RecordOfAccount.Clean
                    && RequestorPhoneNumber.Clean
                    && RequestorTitle.Clean
                    && RequestYear1.Clean
                    && RequestYear2.Clean
                    && RequestYear3.Clean
                    && RequestYear4.Clean
                    && RequestYear5.Clean
                    && RequestYear6.Clean
                    && RequestYear7.Clean
                    && RequestYear8.Clean
                    && ReturnAddress.Clean
                    && ReturnCity.Clean
                    && ReturnState.Clean
                    && ReturnTranscript.Clean
                    && ReturnZip.Clean
                    && SelectedRecordNumber.Clean
                    && SendAddress.Clean
                    && SendCity.Clean
                    && SendFirst.Clean
                    && SendLast.Clean
                    && SendPhone.Clean
                    && SendState.Clean
                    && SendZip.Clean
                    && SignatoryAttestation.Clean
                    && SignatoryAttestationT.Clean
                    && SpouseFirst.Clean
                    && SpouseLast.Clean
                    && SpouseSSN.Clean
                    && SpouseUseEIN.Clean
                    && SSN.Clean
                    && State.Clean
                    && Tax4506Index.Clean
                    && Tax4506TIndicator.Clean
                    && TaxFormNumber.Clean
                    && TheseCopiesMustBeCertified.Clean
                    && TotalCost.Clean
                    && UseEIN.Clean
                    && UseWellsFargoRules.Clean
                    && VerificationOfNonfiling.Clean
                    && Zip.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AccountTranscript; v0.Clean = value; AccountTranscript = v0;
                var v1 = Address; v1.Clean = value; Address = v1;
                var v2 = City; v2.Clean = value; City = v2;
                var v3 = CostForEachPeriod; v3.Clean = value; CostForEachPeriod = v3;
                var v4 = CurrentFirst; v4.Clean = value; CurrentFirst = v4;
                var v5 = CurrentLast; v5.Clean = value; CurrentLast = v5;
                var v6 = First; v6.Clean = value; First = v6;
                var v7 = FormsSeriesTranscript; v7.Clean = value; FormsSeriesTranscript = v7;
                var v8 = HistoryId; v8.Clean = value; HistoryId = v8;
                var v9 = HistoryIndicator; v9.Clean = value; HistoryIndicator = v9;
                var v10 = Id; v10.Clean = value; Id = v10;
                var v11 = IfTaxRecordNotFound; v11.Clean = value; IfTaxRecordNotFound = v11;
                var v12 = Last; v12.Clean = value; Last = v12;
                var v13 = LastUpdatedDate; v13.Clean = value; LastUpdatedDate = v13;
                var v14 = LastUpdatedHistory; v14.Clean = value; LastUpdatedHistory = v14;
                var v15 = LastUpdatedTime; v15.Clean = value; LastUpdatedTime = v15;
                var v16 = NotifiedIrsIdentityTheftIndicator; v16.Clean = value; NotifiedIrsIdentityTheftIndicator = v16;
                var v17 = NumberOfPeriods; v17.Clean = value; NumberOfPeriods = v17;
                var v18 = Person; v18.Clean = value; Person = v18;
                var v19 = RecordOfAccount; v19.Clean = value; RecordOfAccount = v19;
                var v20 = RequestorPhoneNumber; v20.Clean = value; RequestorPhoneNumber = v20;
                var v21 = RequestorTitle; v21.Clean = value; RequestorTitle = v21;
                var v22 = RequestYear1; v22.Clean = value; RequestYear1 = v22;
                var v23 = RequestYear2; v23.Clean = value; RequestYear2 = v23;
                var v24 = RequestYear3; v24.Clean = value; RequestYear3 = v24;
                var v25 = RequestYear4; v25.Clean = value; RequestYear4 = v25;
                var v26 = RequestYear5; v26.Clean = value; RequestYear5 = v26;
                var v27 = RequestYear6; v27.Clean = value; RequestYear6 = v27;
                var v28 = RequestYear7; v28.Clean = value; RequestYear7 = v28;
                var v29 = RequestYear8; v29.Clean = value; RequestYear8 = v29;
                var v30 = ReturnAddress; v30.Clean = value; ReturnAddress = v30;
                var v31 = ReturnCity; v31.Clean = value; ReturnCity = v31;
                var v32 = ReturnState; v32.Clean = value; ReturnState = v32;
                var v33 = ReturnTranscript; v33.Clean = value; ReturnTranscript = v33;
                var v34 = ReturnZip; v34.Clean = value; ReturnZip = v34;
                var v35 = SelectedRecordNumber; v35.Clean = value; SelectedRecordNumber = v35;
                var v36 = SendAddress; v36.Clean = value; SendAddress = v36;
                var v37 = SendCity; v37.Clean = value; SendCity = v37;
                var v38 = SendFirst; v38.Clean = value; SendFirst = v38;
                var v39 = SendLast; v39.Clean = value; SendLast = v39;
                var v40 = SendPhone; v40.Clean = value; SendPhone = v40;
                var v41 = SendState; v41.Clean = value; SendState = v41;
                var v42 = SendZip; v42.Clean = value; SendZip = v42;
                var v43 = SignatoryAttestation; v43.Clean = value; SignatoryAttestation = v43;
                var v44 = SignatoryAttestationT; v44.Clean = value; SignatoryAttestationT = v44;
                var v45 = SpouseFirst; v45.Clean = value; SpouseFirst = v45;
                var v46 = SpouseLast; v46.Clean = value; SpouseLast = v46;
                var v47 = SpouseSSN; v47.Clean = value; SpouseSSN = v47;
                var v48 = SpouseUseEIN; v48.Clean = value; SpouseUseEIN = v48;
                var v49 = SSN; v49.Clean = value; SSN = v49;
                var v50 = State; v50.Clean = value; State = v50;
                var v51 = Tax4506Index; v51.Clean = value; Tax4506Index = v51;
                var v52 = Tax4506TIndicator; v52.Clean = value; Tax4506TIndicator = v52;
                var v53 = TaxFormNumber; v53.Clean = value; TaxFormNumber = v53;
                var v54 = TheseCopiesMustBeCertified; v54.Clean = value; TheseCopiesMustBeCertified = v54;
                var v55 = TotalCost; v55.Clean = value; TotalCost = v55;
                var v56 = UseEIN; v56.Clean = value; UseEIN = v56;
                var v57 = UseWellsFargoRules; v57.Clean = value; UseWellsFargoRules = v57;
                var v58 = VerificationOfNonfiling; v58.Clean = value; VerificationOfNonfiling = v58;
                var v59 = Zip; v59.Clean = value; Zip = v59;
                _settingClean = 0;
            }
        }
    }
}