using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PreviousVaLoan
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(PreviousVaLoanIndex))]
    public sealed partial class PreviousVaLoan : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _dateOfLoan;
        private DirtyValue<DateTime?> _dateSold;
        private DirtyValue<string> _id;
        private DirtyValue<StringEnumValue<PreviousVaLoanLoanType>> _loanType;
        private DirtyValue<int?> _previousVaLoanIndex;
        private DirtyValue<string> _propertyAddress;
        private DirtyValue<string> _propertyCity;
        private DirtyValue<bool?> _propertyOwned;
        private DirtyValue<string> _propertyPostalCode;
        private DirtyValue<StringEnumValue<State>> _propertyState;
        private DirtyValue<string> _vALoanNumber;

        /// <summary>
        /// PreviousVaLoan DateOfLoan
        /// </summary>
        public DateTime? DateOfLoan { get => _dateOfLoan; set => SetField(ref _dateOfLoan, value); }

        /// <summary>
        /// PreviousVaLoan DateSold
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? DateSold { get => _dateSold; set => SetField(ref _dateSold, value); }

        /// <summary>
        /// PreviousVaLoan Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// PreviousVaLoan LoanType
        /// </summary>
        public StringEnumValue<PreviousVaLoanLoanType> LoanType { get => _loanType; set => SetField(ref _loanType, value); }

        /// <summary>
        /// PreviousVaLoan PreviousVaLoanIndex
        /// </summary>
        public int? PreviousVaLoanIndex { get => _previousVaLoanIndex; set => SetField(ref _previousVaLoanIndex, value); }

        /// <summary>
        /// PreviousVaLoan PropertyAddress
        /// </summary>
        public string PropertyAddress { get => _propertyAddress; set => SetField(ref _propertyAddress, value); }

        /// <summary>
        /// PreviousVaLoan PropertyCity
        /// </summary>
        public string PropertyCity { get => _propertyCity; set => SetField(ref _propertyCity, value); }

        /// <summary>
        /// PreviousVaLoan PropertyOwned
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, OptionsJson = "{\"Y\":\"Property Owned\"}")]
        public bool? PropertyOwned { get => _propertyOwned; set => SetField(ref _propertyOwned, value); }

        /// <summary>
        /// PreviousVaLoan PropertyPostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string PropertyPostalCode { get => _propertyPostalCode; set => SetField(ref _propertyPostalCode, value); }

        /// <summary>
        /// PreviousVaLoan PropertyState
        /// </summary>
        public StringEnumValue<State> PropertyState { get => _propertyState; set => SetField(ref _propertyState, value); }

        /// <summary>
        /// PreviousVaLoan VALoanNumber
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string VALoanNumber { get => _vALoanNumber; set => SetField(ref _vALoanNumber, value); }
    }
}