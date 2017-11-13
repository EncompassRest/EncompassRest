using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed class BusinessContact : Contact, IDirty
    {
        internal override string ApiPath => "encompass/v1/businessContacts";

        private DirtyValue<BusinessContactCategory?> _categoryId;
        [EnumOutput(EnumOutput.Integer)]
        public BusinessContactCategory? CategoryId { get => _categoryId; set => _categoryId = value; }
        private DirtyValue<string> _companyName;
        public string CompanyName { get => _companyName; set => _companyName = value; }
        private BusinessContactLicense _personalContactLicense;
        public BusinessContactLicense PersonalContactLicense { get => _personalContactLicense ?? (_personalContactLicense = new BusinessContactLicense()); set => _personalContactLicense = value; }
        private BusinessContactLicense _businessContactLicense;
        public BusinessContactLicense BusinessContactLicense { get => _businessContactLicense ?? (_businessContactLicense = new BusinessContactLicense()); set => _businessContactLicense = value; }
        private DirtyValue<bool?> _noSpam;
        public bool? NoSpam { get => _noSpam; set => _noSpam = value; }
        private DirtyValue<int?> _fees;
        public int? Fees { get => Fees; set => _fees = value; }
        private bool _gettingDirty;
        private bool _settingDirty;
        internal new bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = base.Dirty
                    || _categoryId.Dirty
                    || _companyName.Dirty
                    || _personalContactLicense?.Dirty == true
                    || _businessContactLicense?.Dirty == true
                    || _noSpam.Dirty
                    || _fees.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                base.Dirty = value;
                _categoryId.Dirty = value;
                _companyName.Dirty = value;
                if (_personalContactLicense!= null) _personalContactLicense.Dirty = value;
                if (_businessContactLicense!= null) _businessContactLicense.Dirty = value;
                _noSpam.Dirty = value;
                _fees.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}
