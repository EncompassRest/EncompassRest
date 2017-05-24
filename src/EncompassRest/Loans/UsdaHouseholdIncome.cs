using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class UsdaHouseholdIncome
    {
        public Value<int?> Age { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAge() => !Age.Clean;
        public Value<string> AnalysisDocumenting { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnalysisDocumenting() => !AnalysisDocumenting.Clean;
        public Value<decimal?> AnnualNonWageIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualNonWageIncome() => !AnnualNonWageIncome.Clean;
        public Value<decimal?> AnnualWageIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualWageIncome() => !AnnualWageIncome.Clean;
        public Value<bool?> DisabledIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisabledIndicator() => !DisabledIndicator.Clean;
        public Value<bool?> FullTimeStudentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFullTimeStudentIndicator() => !FullTimeStudentIndicator.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> Name { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeName() => !Name.Clean;
        public Value<string> RecordOwnerType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecordOwnerType() => !RecordOwnerType.Clean;
        public Value<string> SourceofNonWageIncomeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourceofNonWageIncomeDescription() => !SourceofNonWageIncomeDescription.Clean;
        public Value<string> SourceofWageIncomeEmployerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourceofWageIncomeEmployerName() => !SourceofWageIncomeEmployerName.Clean;
        public Value<int?> UsdaHouseholdIncomeIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUsdaHouseholdIncomeIndex() => !UsdaHouseholdIncomeIndex.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Age.Clean
                    && AnalysisDocumenting.Clean
                    && AnnualNonWageIncome.Clean
                    && AnnualWageIncome.Clean
                    && DisabledIndicator.Clean
                    && FullTimeStudentIndicator.Clean
                    && Id.Clean
                    && Name.Clean
                    && RecordOwnerType.Clean
                    && SourceofNonWageIncomeDescription.Clean
                    && SourceofWageIncomeEmployerName.Clean
                    && UsdaHouseholdIncomeIndex.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Age; v0.Clean = value; Age = v0;
                var v1 = AnalysisDocumenting; v1.Clean = value; AnalysisDocumenting = v1;
                var v2 = AnnualNonWageIncome; v2.Clean = value; AnnualNonWageIncome = v2;
                var v3 = AnnualWageIncome; v3.Clean = value; AnnualWageIncome = v3;
                var v4 = DisabledIndicator; v4.Clean = value; DisabledIndicator = v4;
                var v5 = FullTimeStudentIndicator; v5.Clean = value; FullTimeStudentIndicator = v5;
                var v6 = Id; v6.Clean = value; Id = v6;
                var v7 = Name; v7.Clean = value; Name = v7;
                var v8 = RecordOwnerType; v8.Clean = value; RecordOwnerType = v8;
                var v9 = SourceofNonWageIncomeDescription; v9.Clean = value; SourceofNonWageIncomeDescription = v9;
                var v10 = SourceofWageIncomeEmployerName; v10.Clean = value; SourceofWageIncomeEmployerName = v10;
                var v11 = UsdaHouseholdIncomeIndex; v11.Clean = value; UsdaHouseholdIncomeIndex = v11;
                _settingClean = 0;
            }
        }
    }
}