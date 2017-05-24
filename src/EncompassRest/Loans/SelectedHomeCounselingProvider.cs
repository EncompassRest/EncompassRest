using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class SelectedHomeCounselingProvider
    {
        public Value<string> AgencyAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyAddress() => !AgencyAddress.Clean;
        public Value<string> AgencyAddressCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyAddressCity() => !AgencyAddressCity.Clean;
        public Value<string> AgencyAddressPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyAddressPostalCode() => !AgencyAddressPostalCode.Clean;
        public Value<string> AgencyAddressState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyAddressState() => !AgencyAddressState.Clean;
        public Value<string> AgencyAffiliationDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyAffiliationDescription() => !AgencyAffiliationDescription.Clean;
        public Value<string> AgencyEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyEmail() => !AgencyEmail.Clean;
        public Value<string> AgencyFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyFax() => !AgencyFax.Clean;
        public Value<string> AgencyName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyName() => !AgencyName.Clean;
        public Value<string> AgencyPhoneDirect { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyPhoneDirect() => !AgencyPhoneDirect.Clean;
        public Value<string> AgencyPhoneTollFree { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyPhoneTollFree() => !AgencyPhoneTollFree.Clean;
        public Value<string> AgencyWebAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyWebAddress() => !AgencyWebAddress.Clean;
        public Value<bool?> CertificationIssuedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertificationIssuedIndicator() => !CertificationIssuedIndicator.Clean;
        public Value<string> CounselingServicesProvided { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounselingServicesProvided() => !CounselingServicesProvided.Clean;
        public Value<decimal?> DistanceMiles { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDistanceMiles() => !DistanceMiles.Clean;
        public Value<DateTime?> HomeCounselingCompletionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeCounselingCompletionDate() => !HomeCounselingCompletionDate.Clean;
        public Value<DateTime?> HomeCounselingDisclosureDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeCounselingDisclosureDate() => !HomeCounselingDisclosureDate.Clean;
        public Value<bool?> HomeCounselingRequiredIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeCounselingRequiredIndicator() => !HomeCounselingRequiredIndicator.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> LanguagesSupported { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLanguagesSupported() => !LanguagesSupported.Clean;
        public Value<string> SelectedGUID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSelectedGUID() => !SelectedGUID.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AgencyAddress.Clean
                    && AgencyAddressCity.Clean
                    && AgencyAddressPostalCode.Clean
                    && AgencyAddressState.Clean
                    && AgencyAffiliationDescription.Clean
                    && AgencyEmail.Clean
                    && AgencyFax.Clean
                    && AgencyName.Clean
                    && AgencyPhoneDirect.Clean
                    && AgencyPhoneTollFree.Clean
                    && AgencyWebAddress.Clean
                    && CertificationIssuedIndicator.Clean
                    && CounselingServicesProvided.Clean
                    && DistanceMiles.Clean
                    && HomeCounselingCompletionDate.Clean
                    && HomeCounselingDisclosureDate.Clean
                    && HomeCounselingRequiredIndicator.Clean
                    && Id.Clean
                    && LanguagesSupported.Clean
                    && SelectedGUID.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AgencyAddress; v0.Clean = value; AgencyAddress = v0;
                var v1 = AgencyAddressCity; v1.Clean = value; AgencyAddressCity = v1;
                var v2 = AgencyAddressPostalCode; v2.Clean = value; AgencyAddressPostalCode = v2;
                var v3 = AgencyAddressState; v3.Clean = value; AgencyAddressState = v3;
                var v4 = AgencyAffiliationDescription; v4.Clean = value; AgencyAffiliationDescription = v4;
                var v5 = AgencyEmail; v5.Clean = value; AgencyEmail = v5;
                var v6 = AgencyFax; v6.Clean = value; AgencyFax = v6;
                var v7 = AgencyName; v7.Clean = value; AgencyName = v7;
                var v8 = AgencyPhoneDirect; v8.Clean = value; AgencyPhoneDirect = v8;
                var v9 = AgencyPhoneTollFree; v9.Clean = value; AgencyPhoneTollFree = v9;
                var v10 = AgencyWebAddress; v10.Clean = value; AgencyWebAddress = v10;
                var v11 = CertificationIssuedIndicator; v11.Clean = value; CertificationIssuedIndicator = v11;
                var v12 = CounselingServicesProvided; v12.Clean = value; CounselingServicesProvided = v12;
                var v13 = DistanceMiles; v13.Clean = value; DistanceMiles = v13;
                var v14 = HomeCounselingCompletionDate; v14.Clean = value; HomeCounselingCompletionDate = v14;
                var v15 = HomeCounselingDisclosureDate; v15.Clean = value; HomeCounselingDisclosureDate = v15;
                var v16 = HomeCounselingRequiredIndicator; v16.Clean = value; HomeCounselingRequiredIndicator = v16;
                var v17 = Id; v17.Clean = value; Id = v17;
                var v18 = LanguagesSupported; v18.Clean = value; LanguagesSupported = v18;
                var v19 = SelectedGUID; v19.Clean = value; SelectedGUID = v19;
                _settingClean = 0;
            }
        }
    }
}