using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// SelfEmployedIncome
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(FieldName) + "," + nameof(FormType))]
    public sealed partial class SelfEmployedIncome : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _boolFieldValue;
        private DirtyValue<string> _businessName;
        private DirtyValue<StringEnumValue<FieldName>> _fieldName;
        private DirtyValue<string> _fieldValue;
        private DirtyValue<decimal?> _firstYearAmount;
        private DirtyValue<StringEnumValue<FormType>> _formType;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _secondYearAmount;

        /// <summary>
        /// SelfEmployedIncome BoolFieldValue
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Who have 25% or greater interest in a business\"}")]
        public bool? BoolFieldValue { get => _boolFieldValue; set => SetField(ref _boolFieldValue, value); }

        /// <summary>
        /// 1084A/1040 Business Information - Business Name [FM1084.X177]
        /// </summary>
        public string BusinessName { get => _businessName; set => SetField(ref _businessName, value); }

        /// <summary>
        /// SelfEmployedIncome FieldName [FM1084.X18]
        /// </summary>
        public StringEnumValue<FieldName> FieldName { get => _fieldName; set => SetField(ref _fieldName, value); }

        /// <summary>
        /// SelfEmployedIncome FieldValue
        /// </summary>
        public string FieldValue { get => _fieldValue; set => SetField(ref _fieldValue, value); }

        /// <summary>
        /// SelfEmployedIncome FirstYearAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FirstYearAmount { get => _firstYearAmount; set => SetField(ref _firstYearAmount, value); }

        /// <summary>
        /// SelfEmployedIncome FormType
        /// </summary>
        public StringEnumValue<FormType> FormType { get => _formType; set => SetField(ref _formType, value); }

        /// <summary>
        /// SelfEmployedIncome Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// SelfEmployedIncome SecondYearAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SecondYearAmount { get => _secondYearAmount; set => SetField(ref _secondYearAmount, value); }
    }
}