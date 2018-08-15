using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// SelfEmployedIncome
    /// </summary>
    public sealed partial class SelfEmployedIncome : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _boolFieldValue;
        /// <summary>
        /// SelfEmployedIncome BoolFieldValue
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Who have 25% or greater interest in a business\"}")]
        public bool? BoolFieldValue { get => _boolFieldValue; set => SetField(ref _boolFieldValue, value); }
        private DirtyValue<string> _businessName;
        /// <summary>
        /// 1084A/1040 Business Information - Business Name [FM1084.X177]
        /// </summary>
        [LoanFieldProperty(Description = "1084A/1040 Business Information - Business Name")]
        public string BusinessName { get => _businessName; set => SetField(ref _businessName, value); }
        private DirtyValue<StringEnumValue<FieldName>> _fieldName;
        /// <summary>
        /// SelfEmployedIncome FieldName [FM1084.X18]
        /// </summary>
        public StringEnumValue<FieldName> FieldName { get => _fieldName; set => SetField(ref _fieldName, value); }
        private DirtyValue<decimal?> _fieldValue;
        /// <summary>
        /// SelfEmployedIncome FieldValue
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? FieldValue { get => _fieldValue; set => SetField(ref _fieldValue, value); }
        private DirtyValue<decimal?> _firstYearAmount;
        /// <summary>
        /// SelfEmployedIncome FirstYearAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FirstYearAmount { get => _firstYearAmount; set => SetField(ref _firstYearAmount, value); }
        private DirtyValue<StringEnumValue<FormType>> _formType;
        /// <summary>
        /// SelfEmployedIncome FormType
        /// </summary>
        public StringEnumValue<FormType> FormType { get => _formType; set => SetField(ref _formType, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// SelfEmployedIncome Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _secondYearAmount;
        /// <summary>
        /// SelfEmployedIncome SecondYearAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SecondYearAmount { get => _secondYearAmount; set => SetField(ref _secondYearAmount, value); }
    }
}