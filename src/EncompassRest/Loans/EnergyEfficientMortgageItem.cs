using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EnergyEfficientMortgageItem
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class EnergyEfficientMortgageItem : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _actualAmount;
        /// <summary>
        /// EnergyEfficientMortgageItem ActualAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ActualAmount { get => _actualAmount; set => SetField(ref _actualAmount, value); }
        private DirtyValue<decimal?> _allowedAmount;
        /// <summary>
        /// EnergyEfficientMortgageItem AllowedAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AllowedAmount { get => _allowedAmount; set => SetField(ref _allowedAmount, value); }
        private DirtyValue<int?> _energyEfficientMortgageItemIndex;
        /// <summary>
        /// EnergyEfficientMortgageItem EnergyEfficientMortgageItemIndex
        /// </summary>
        public int? EnergyEfficientMortgageItemIndex { get => _energyEfficientMortgageItemIndex; set => SetField(ref _energyEfficientMortgageItemIndex, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// EnergyEfficientMortgageItem Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _item;
        /// <summary>
        /// EnergyEfficientMortgageItem Item
        /// </summary>
        public string Item { get => _item; set => SetField(ref _item, value); }
        private DirtyValue<int?> _lineNumber;
        /// <summary>
        /// EnergyEfficientMortgageItem LineNumber
        /// </summary>
        public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }
    }
}