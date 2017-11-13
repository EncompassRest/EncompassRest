using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class UsdaHouseholdIncome : IDirty
    {
        private DirtyValue<int?> _age;
        public int? Age { get => _age; set => _age = value; }
        private DirtyValue<string> _analysisDocumenting;
        public string AnalysisDocumenting { get => _analysisDocumenting; set => _analysisDocumenting = value; }
        private DirtyValue<decimal?> _annualNonWageIncome;
        public decimal? AnnualNonWageIncome { get => _annualNonWageIncome; set => _annualNonWageIncome = value; }
        private DirtyValue<decimal?> _annualWageIncome;
        public decimal? AnnualWageIncome { get => _annualWageIncome; set => _annualWageIncome = value; }
        private DirtyValue<bool?> _disabledIndicator;
        public bool? DisabledIndicator { get => _disabledIndicator; set => _disabledIndicator = value; }
        private DirtyValue<bool?> _fullTimeStudentIndicator;
        public bool? FullTimeStudentIndicator { get => _fullTimeStudentIndicator; set => _fullTimeStudentIndicator = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _name;
        public string Name { get => _name; set => _name = value; }
        private StringEnumValue<RecordOwnerType> _recordOwnerType;
        public StringEnumValue<RecordOwnerType> RecordOwnerType { get => _recordOwnerType; set => _recordOwnerType = value; }
        private DirtyValue<string> _sourceofNonWageIncomeDescription;
        public string SourceofNonWageIncomeDescription { get => _sourceofNonWageIncomeDescription; set => _sourceofNonWageIncomeDescription = value; }
        private DirtyValue<string> _sourceofWageIncomeEmployerName;
        public string SourceofWageIncomeEmployerName { get => _sourceofWageIncomeEmployerName; set => _sourceofWageIncomeEmployerName = value; }
        private DirtyValue<int?> _usdaHouseholdIncomeIndex;
        public int? UsdaHouseholdIncomeIndex { get => _usdaHouseholdIncomeIndex; set => _usdaHouseholdIncomeIndex = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
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
                    || _extensionData?.Dirty == true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}