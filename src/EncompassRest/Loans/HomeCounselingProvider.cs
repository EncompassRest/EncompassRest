using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class HomeCounselingProvider
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
        public Value<bool?> AgencyAffiliationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyAffiliationIndicator() => !AgencyAffiliationIndicator.Clean;
        public Value<string> AgencyEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyEmail() => !AgencyEmail.Clean;
        public Value<string> AgencyFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyFax() => !AgencyFax.Clean;
        public Value<string> AgencyId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyId() => !AgencyId.Clean;
        public Value<string> AgencyName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyName() => !AgencyName.Clean;
        public Value<string> AgencyPhoneDirect { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyPhoneDirect() => !AgencyPhoneDirect.Clean;
        public Value<string> AgencyPhoneTollFree { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyPhoneTollFree() => !AgencyPhoneTollFree.Clean;
        public Value<string> AgencySource { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencySource() => !AgencySource.Clean;
        public Value<string> AgencyWebAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgencyWebAddress() => !AgencyWebAddress.Clean;
        public Value<string> CounselingServicesProvided { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCounselingServicesProvided() => !CounselingServicesProvided.Clean;
        public Value<decimal?> DistanceMiles { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDistanceMiles() => !DistanceMiles.Clean;
        public Value<string> HomeCounselingProviderId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeCounselingProviderId() => !HomeCounselingProviderId.Clean;
        public Value<int?> HomeCounselingProviderIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeCounselingProviderIndex() => !HomeCounselingProviderIndex.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> LanguagesSupported { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLanguagesSupported() => !LanguagesSupported.Clean;
        public Value<bool?> SelectedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSelectedIndicator() => !SelectedIndicator.Clean;
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
                    && AgencyAffiliationIndicator.Clean
                    && AgencyEmail.Clean
                    && AgencyFax.Clean
                    && AgencyId.Clean
                    && AgencyName.Clean
                    && AgencyPhoneDirect.Clean
                    && AgencyPhoneTollFree.Clean
                    && AgencySource.Clean
                    && AgencyWebAddress.Clean
                    && CounselingServicesProvided.Clean
                    && DistanceMiles.Clean
                    && HomeCounselingProviderId.Clean
                    && HomeCounselingProviderIndex.Clean
                    && Id.Clean
                    && LanguagesSupported.Clean
                    && SelectedIndicator.Clean;
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
                var v5 = AgencyAffiliationIndicator; v5.Clean = value; AgencyAffiliationIndicator = v5;
                var v6 = AgencyEmail; v6.Clean = value; AgencyEmail = v6;
                var v7 = AgencyFax; v7.Clean = value; AgencyFax = v7;
                var v8 = AgencyId; v8.Clean = value; AgencyId = v8;
                var v9 = AgencyName; v9.Clean = value; AgencyName = v9;
                var v10 = AgencyPhoneDirect; v10.Clean = value; AgencyPhoneDirect = v10;
                var v11 = AgencyPhoneTollFree; v11.Clean = value; AgencyPhoneTollFree = v11;
                var v12 = AgencySource; v12.Clean = value; AgencySource = v12;
                var v13 = AgencyWebAddress; v13.Clean = value; AgencyWebAddress = v13;
                var v14 = CounselingServicesProvided; v14.Clean = value; CounselingServicesProvided = v14;
                var v15 = DistanceMiles; v15.Clean = value; DistanceMiles = v15;
                var v16 = HomeCounselingProviderId; v16.Clean = value; HomeCounselingProviderId = v16;
                var v17 = HomeCounselingProviderIndex; v17.Clean = value; HomeCounselingProviderIndex = v17;
                var v18 = Id; v18.Clean = value; Id = v18;
                var v19 = LanguagesSupported; v19.Clean = value; LanguagesSupported = v19;
                var v20 = SelectedIndicator; v20.Clean = value; SelectedIndicator = v20;
                _settingClean = 0;
            }
        }
    }
}