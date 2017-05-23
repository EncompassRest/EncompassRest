using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class UsdaHouseholdIncome
    {
        public JsonNullable<int?> Age { get; set; }
        public string AnalysisDocumenting { get; set; }
        public JsonNullable<decimal?> AnnualNonWageIncome { get; set; }
        public JsonNullable<decimal?> AnnualWageIncome { get; set; }
        public JsonNullable<bool?> DisabledIndicator { get; set; }
        public JsonNullable<bool?> FullTimeStudentIndicator { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string RecordOwnerType { get; set; }
        public string SourceofNonWageIncomeDescription { get; set; }
        public string SourceofWageIncomeEmployerName { get; set; }
        public int? UsdaHouseholdIncomeIndex { get; set; }
    }
}