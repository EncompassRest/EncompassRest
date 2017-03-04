
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class UsdaHouseholdIncome
{
public int? usdaHouseholdIncomeIndex { get; set; }
public string name { get; set; }
public int? age { get; set; }
public bool? fullTimeStudentIndicator { get; set; }
public bool? disabledIndicator { get; set; }
public decimal? annualWageIncome { get; set; }
public string sourceofWageIncomeEmployerName { get; set; }
public decimal? annualNonWageIncome { get; set; }
public string sourceofNonWageIncomeDescription { get; set; }
public string recordOwnerType { get; set; }
public string analysisDocumenting { get; set; }
public string id { get; set; }

    }
}