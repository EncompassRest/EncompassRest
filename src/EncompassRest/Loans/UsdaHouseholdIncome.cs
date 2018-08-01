using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// UsdaHouseholdIncome
    /// </summary>
    public sealed partial class UsdaHouseholdIncome : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _age;
        /// <summary>
        /// UsdaHouseholdIncome Age
        /// </summary>
        public int? Age { get => _age; set => _age = value; }
        private DirtyValue<string> _analysisDocumenting;
        /// <summary>
        /// USDA - House Income - Written Analysis Documenting Annual and Repayment Income [USDA.X193]
        /// </summary>
        [LoanFieldProperty(Description = "USDA - House Income - Written Analysis Documenting Annual and Repayment Income")]
        public string AnalysisDocumenting { get => _analysisDocumenting; set => _analysisDocumenting = value; }
        private DirtyValue<decimal?> _annualNonWageIncome;
        /// <summary>
        /// UsdaHouseholdIncome AnnualNonWageIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AnnualNonWageIncome { get => _annualNonWageIncome; set => _annualNonWageIncome = value; }
        private DirtyValue<decimal?> _annualWageIncome;
        /// <summary>
        /// UsdaHouseholdIncome AnnualWageIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AnnualWageIncome { get => _annualWageIncome; set => _annualWageIncome = value; }
        private DirtyValue<bool?> _disabledIndicator;
        /// <summary>
        /// UsdaHouseholdIncome DisabledIndicator
        /// </summary>
        public bool? DisabledIndicator { get => _disabledIndicator; set => _disabledIndicator = value; }
        private DirtyValue<bool?> _fullTimeStudentIndicator;
        /// <summary>
        /// UsdaHouseholdIncome FullTimeStudentIndicator
        /// </summary>
        public bool? FullTimeStudentIndicator { get => _fullTimeStudentIndicator; set => _fullTimeStudentIndicator = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// UsdaHouseholdIncome Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _name;
        /// <summary>
        /// UsdaHouseholdIncome Name
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<StringEnumValue<RecordOwnerType>> _recordOwnerType;
        /// <summary>
        /// UsdaHouseholdIncome RecordOwnerType
        /// </summary>
        public StringEnumValue<RecordOwnerType> RecordOwnerType { get => _recordOwnerType; set => _recordOwnerType = value; }
        private DirtyValue<string> _sourceofNonWageIncomeDescription;
        /// <summary>
        /// UsdaHouseholdIncome SourceofNonWageIncomeDescription
        /// </summary>
        public string SourceofNonWageIncomeDescription { get => _sourceofNonWageIncomeDescription; set => _sourceofNonWageIncomeDescription = value; }
        private DirtyValue<string> _sourceofWageIncomeEmployerName;
        /// <summary>
        /// UsdaHouseholdIncome SourceofWageIncomeEmployerName
        /// </summary>
        public string SourceofWageIncomeEmployerName { get => _sourceofWageIncomeEmployerName; set => _sourceofWageIncomeEmployerName = value; }
        private DirtyValue<int?> _usdaHouseholdIncomeIndex;
        /// <summary>
        /// UsdaHouseholdIncome UsdaHouseholdIncomeIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\",\"5\":\"5\",\"6\":\"6\"}")]
        public int? UsdaHouseholdIncomeIndex { get => _usdaHouseholdIncomeIndex; set => _usdaHouseholdIncomeIndex = value; }
        internal override bool DirtyInternal
        {
            get => _age.Dirty
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
            set
            {
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
            }
        }
    }
}