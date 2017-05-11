using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class UsdaHouseholdIncome
    {
        public int? UsdaHouseholdIncomeIndex { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public bool? FullTimeStudentIndicator { get; set; }
        public bool? DisabledIndicator { get; set; }
        public decimal? AnnualWageIncome { get; set; }
        public string SourceofWageIncomeEmployerName { get; set; }
        public decimal? AnnualNonWageIncome { get; set; }
        public string SourceofNonWageIncomeDescription { get; set; }
        public string RecordOwnerType { get; set; }
        public string AnalysisDocumenting { get; set; }
        public string Id { get; set; }
    }
}