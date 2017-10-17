using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class UsdaHouseholdIncome : IDirty
    {
        private DirtyValue<int?> _age;
        public int? Age { get { return _age; } set { _age = value; } }
        private DirtyValue<string> _analysisDocumenting;
        public string AnalysisDocumenting { get { return _analysisDocumenting; } set { _analysisDocumenting = value; } }
        private DirtyValue<decimal?> _annualNonWageIncome;
        public decimal? AnnualNonWageIncome { get { return _annualNonWageIncome; } set { _annualNonWageIncome = value; } }
        private DirtyValue<decimal?> _annualWageIncome;
        public decimal? AnnualWageIncome { get { return _annualWageIncome; } set { _annualWageIncome = value; } }
        private DirtyValue<bool?> _disabledIndicator;
        public bool? DisabledIndicator { get { return _disabledIndicator; } set { _disabledIndicator = value; } }
        private DirtyValue<bool?> _fullTimeStudentIndicator;
        public bool? FullTimeStudentIndicator { get { return _fullTimeStudentIndicator; } set { _fullTimeStudentIndicator = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private DirtyValue<string> _recordOwnerType;
        public string RecordOwnerType { get { return _recordOwnerType; } set { _recordOwnerType = value; } }
        private DirtyValue<string> _sourceofNonWageIncomeDescription;
        public string SourceofNonWageIncomeDescription { get { return _sourceofNonWageIncomeDescription; } set { _sourceofNonWageIncomeDescription = value; } }
        private DirtyValue<string> _sourceofWageIncomeEmployerName;
        public string SourceofWageIncomeEmployerName { get { return _sourceofWageIncomeEmployerName; } set { _sourceofWageIncomeEmployerName = value; } }
        private DirtyValue<int?> _usdaHouseholdIncomeIndex;
        public int? UsdaHouseholdIncomeIndex { get { return _usdaHouseholdIncomeIndex; } set { _usdaHouseholdIncomeIndex = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _age.Dirty
                    || _analysisDocumenting.Dirty
                    || _annualNonWageIncome.Dirty
                    || _annualWageIncome.Dirty
                    || _disabledIndicator.Dirty
                    || _fullTimeStudentIndicator.Dirty
                    || _id.Dirty
                    || _name.Dirty
                    || _recordOwnerType.Dirty
                    || _sourceofNonWageIncomeDescription.Dirty
                    || _sourceofWageIncomeEmployerName.Dirty
                    || _usdaHouseholdIncomeIndex.Dirty
                  || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _age.Dirty = value;
                _analysisDocumenting.Dirty = value;
                _annualNonWageIncome.Dirty = value;
                _annualWageIncome.Dirty = value;
                _disabledIndicator.Dirty = value;
                _fullTimeStudentIndicator.Dirty = value;
                _id.Dirty = value;
                _name.Dirty = value;
                _recordOwnerType.Dirty = value;
                _sourceofNonWageIncomeDescription.Dirty = value;
                _sourceofWageIncomeEmployerName.Dirty = value;
                _usdaHouseholdIncomeIndex.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}