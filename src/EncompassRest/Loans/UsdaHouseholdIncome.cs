using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v0 = _age; v0.Clean = value; _age = v0;
                var v1 = _analysisDocumenting; v1.Clean = value; _analysisDocumenting = v1;
                var v2 = _annualNonWageIncome; v2.Clean = value; _annualNonWageIncome = v2;
                var v3 = _annualWageIncome; v3.Clean = value; _annualWageIncome = v3;
                var v4 = _disabledIndicator; v4.Clean = value; _disabledIndicator = v4;
                var v5 = _fullTimeStudentIndicator; v5.Clean = value; _fullTimeStudentIndicator = v5;
                var v6 = _id; v6.Clean = value; _id = v6;
                var v7 = _name; v7.Clean = value; _name = v7;
                var v8 = _recordOwnerType; v8.Clean = value; _recordOwnerType = v8;
                var v9 = _sourceofNonWageIncomeDescription; v9.Clean = value; _sourceofNonWageIncomeDescription = v9;
                var v10 = _sourceofWageIncomeEmployerName; v10.Clean = value; _sourceofWageIncomeEmployerName = v10;
                var v11 = _usdaHouseholdIncomeIndex; v11.Clean = value; _usdaHouseholdIncomeIndex = v11;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}