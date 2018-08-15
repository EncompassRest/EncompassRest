using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ProfitManagementItem
    /// </summary>
    public sealed partial class ProfitManagementItem : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _atPercent;
        /// <summary>
        /// ProfitManagementItem AtPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? AtPercent { get => _atPercent; set => SetField(ref _atPercent, value); }
        private DirtyValue<string> _description;
        /// <summary>
        /// Profit Mgt Other Descr [PM27]
        /// </summary>
        [LoanFieldProperty(Description = "Profit Mgt Other Descr")]
        public string Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// ProfitManagementItem Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _plusAmount;
        /// <summary>
        /// ProfitManagementItem PlusAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PlusAmount { get => _plusAmount; set => SetField(ref _plusAmount, value); }
        private DirtyValue<int?> _profitManagementItemIndex;
        /// <summary>
        /// ProfitManagementItem ProfitManagementItemIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\"}")]
        public int? ProfitManagementItemIndex { get => _profitManagementItemIndex; set => SetField(ref _profitManagementItemIndex, value); }
        private DirtyValue<decimal?> _total;
        /// <summary>
        /// ProfitManagementItem Total
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? Total { get => _total; set => SetField(ref _total, value); }
        private DirtyValue<StringEnumValue<ProfitManagementItemType>> _type;
        /// <summary>
        /// ProfitManagementItem Type
        /// </summary>
        public StringEnumValue<ProfitManagementItemType> Type { get => _type; set => SetField(ref _type, value); }
    }
}