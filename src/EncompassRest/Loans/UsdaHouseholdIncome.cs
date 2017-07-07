using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class UsdaHouseholdIncome : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _age.Clean
                    && _analysisDocumenting.Clean
                    && _annualNonWageIncome.Clean
                    && _annualWageIncome.Clean
                    && _disabledIndicator.Clean
                    && _fullTimeStudentIndicator.Clean
                    && _id.Clean
                    && _name.Clean
                    && _recordOwnerType.Clean
                    && _sourceofNonWageIncomeDescription.Clean
                    && _sourceofWageIncomeEmployerName.Clean
                    && _usdaHouseholdIncomeIndex.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var age = _age; age.Clean = value; _age = age;
                var analysisDocumenting = _analysisDocumenting; analysisDocumenting.Clean = value; _analysisDocumenting = analysisDocumenting;
                var annualNonWageIncome = _annualNonWageIncome; annualNonWageIncome.Clean = value; _annualNonWageIncome = annualNonWageIncome;
                var annualWageIncome = _annualWageIncome; annualWageIncome.Clean = value; _annualWageIncome = annualWageIncome;
                var disabledIndicator = _disabledIndicator; disabledIndicator.Clean = value; _disabledIndicator = disabledIndicator;
                var fullTimeStudentIndicator = _fullTimeStudentIndicator; fullTimeStudentIndicator.Clean = value; _fullTimeStudentIndicator = fullTimeStudentIndicator;
                var id = _id; id.Clean = value; _id = id;
                var name = _name; name.Clean = value; _name = name;
                var recordOwnerType = _recordOwnerType; recordOwnerType.Clean = value; _recordOwnerType = recordOwnerType;
                var sourceofNonWageIncomeDescription = _sourceofNonWageIncomeDescription; sourceofNonWageIncomeDescription.Clean = value; _sourceofNonWageIncomeDescription = sourceofNonWageIncomeDescription;
                var sourceofWageIncomeEmployerName = _sourceofWageIncomeEmployerName; sourceofWageIncomeEmployerName.Clean = value; _sourceofWageIncomeEmployerName = sourceofWageIncomeEmployerName;
                var usdaHouseholdIncomeIndex = _usdaHouseholdIncomeIndex; usdaHouseholdIncomeIndex.Clean = value; _usdaHouseholdIncomeIndex = usdaHouseholdIncomeIndex;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public UsdaHouseholdIncome()
        {
            Clean = true;
        }
    }
}