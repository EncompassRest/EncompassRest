using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EnergyEfficientMortgageItem
    /// </summary>
    public sealed partial class EnergyEfficientMortgageItem : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _actualAmount;
        /// <summary>
        /// EnergyEfficientMortgageItem ActualAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ActualAmount { get => _actualAmount; set => _actualAmount = value; }
        private DirtyValue<decimal?> _allowedAmount;
        /// <summary>
        /// EnergyEfficientMortgageItem AllowedAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AllowedAmount { get => _allowedAmount; set => _allowedAmount = value; }
        private DirtyValue<int?> _energyEfficientMortgageItemIndex;
        /// <summary>
        /// EnergyEfficientMortgageItem EnergyEfficientMortgageItemIndex
        /// </summary>
        public int? EnergyEfficientMortgageItemIndex { get => _energyEfficientMortgageItemIndex; set => _energyEfficientMortgageItemIndex = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// EnergyEfficientMortgageItem Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _item;
        /// <summary>
        /// EnergyEfficientMortgageItem Item
        /// </summary>
        public string Item { get => _item; set => _item = value; }
        private DirtyValue<int?> _lineNumber;
        /// <summary>
        /// EnergyEfficientMortgageItem LineNumber
        /// </summary>
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
    }
}