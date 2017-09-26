using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class UsdaHouseholdIncome : IDirty
    {
        private Value<int?> _age;
        public int? Age { get { return _age; } set { _age = value; } }
        private Value<string> _analysisDocumenting;
        public string AnalysisDocumenting { get { return _analysisDocumenting; } set { _analysisDocumenting = value; } }
        private Value<decimal?> _annualNonWageIncome;
        public decimal? AnnualNonWageIncome { get { return _annualNonWageIncome; } set { _annualNonWageIncome = value; } }
        private Value<decimal?> _annualWageIncome;
        public decimal? AnnualWageIncome { get { return _annualWageIncome; } set { _annualWageIncome = value; } }
        private Value<bool?> _disabledIndicator;
        public bool? DisabledIndicator { get { return _disabledIndicator; } set { _disabledIndicator = value; } }
        private Value<bool?> _fullTimeStudentIndicator;
        public bool? FullTimeStudentIndicator { get { return _fullTimeStudentIndicator; } set { _fullTimeStudentIndicator = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private Value<string> _recordOwnerType;
        public string RecordOwnerType { get { return _recordOwnerType; } set { _recordOwnerType = value; } }
        private Value<string> _sourceofNonWageIncomeDescription;
        public string SourceofNonWageIncomeDescription { get { return _sourceofNonWageIncomeDescription; } set { _sourceofNonWageIncomeDescription = value; } }
        private Value<string> _sourceofWageIncomeEmployerName;
        public string SourceofWageIncomeEmployerName { get { return _sourceofWageIncomeEmployerName; } set { _sourceofWageIncomeEmployerName = value; } }
        private Value<int?> _usdaHouseholdIncomeIndex;
        public int? UsdaHouseholdIncomeIndex { get { return _usdaHouseholdIncomeIndex; } set { _usdaHouseholdIncomeIndex = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
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
                    || _usdaHouseholdIncomeIndex.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}