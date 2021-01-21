using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    /// <summary>
    /// RespaHudDetail
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(LineNumber))]
    public sealed partial class RespaHudDetail : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<CreditDebt>>? _creditDebt;
        private DirtyValue<string?>? _fWBC;
        private DirtyValue<DateTime?>? _hUD1LineItemFromDate;
        private DirtyValue<DateTime?>? _hUD1LineItemToDate;
        private DirtyValue<string?>? _id;
        private DirtyValue<decimal?>? _lineItemAmount;
        private DirtyValue<string?>? _lineItemDescription;
        private DirtyValue<int?>? _lineNumber;
        private DirtyValue<decimal?>? _realValue;

        /// <summary>
        /// RespaHudDetail CreditDebt
        /// </summary>
        public StringEnumValue<CreditDebt> CreditDebt { get => _creditDebt; set => SetField(ref _creditDebt, value); }

        /// <summary>
        /// RespaHudDetail FWBC
        /// </summary>
        public string? FWBC { get => _fWBC; set => SetField(ref _fWBC, value); }

        /// <summary>
        /// RespaHudDetail HUD1LineItemFromDate
        /// </summary>
        public DateTime? HUD1LineItemFromDate { get => _hUD1LineItemFromDate; set => SetField(ref _hUD1LineItemFromDate, value); }

        /// <summary>
        /// RespaHudDetail HUD1LineItemToDate
        /// </summary>
        public DateTime? HUD1LineItemToDate { get => _hUD1LineItemToDate; set => SetField(ref _hUD1LineItemToDate, value); }

        /// <summary>
        /// RespaHudDetail Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// RespaHudDetail LineItemAmount
        /// </summary>
        public decimal? LineItemAmount { get => _lineItemAmount; set => SetField(ref _lineItemAmount, value); }

        /// <summary>
        /// RespaHudDetail LineItemDescription
        /// </summary>
        public string? LineItemDescription { get => _lineItemDescription; set => SetField(ref _lineItemDescription, value); }

        /// <summary>
        /// RespaHudDetail LineNumber
        /// </summary>
        public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }

        /// <summary>
        /// RespaHudDetail RealValue [L206R], [L207R]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? RealValue { get => _realValue; set => SetField(ref _realValue, value); }
    }
}