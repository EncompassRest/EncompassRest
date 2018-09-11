using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PreviousVaLoan
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(PreviousVaLoanIndex))]
    public sealed partial class PreviousVaLoan : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _dateOfLoan;
        /// <summary>
        /// PreviousVaLoan DateOfLoan
        /// </summary>
        public DateTime? DateOfLoan { get => _dateOfLoan; set => SetField(ref _dateOfLoan, value); }
        private DirtyValue<DateTime?> _dateSold;
        /// <summary>
        /// PreviousVaLoan DateSold
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? DateSold { get => _dateSold; set => SetField(ref _dateSold, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// PreviousVaLoan Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<StringEnumValue<PreviousVaLoanLoanType>> _loanType;
        /// <summary>
        /// PreviousVaLoan LoanType
        /// </summary>
        public StringEnumValue<PreviousVaLoanLoanType> LoanType { get => _loanType; set => SetField(ref _loanType, value); }
        private DirtyValue<int?> _previousVaLoanIndex;
        /// <summary>
        /// PreviousVaLoan PreviousVaLoanIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\",\"5\":\"5\",\"6\":\"6\"}")]
        public int? PreviousVaLoanIndex { get => _previousVaLoanIndex; set => SetField(ref _previousVaLoanIndex, value); }
        private DirtyValue<string> _propertyAddress;
        /// <summary>
        /// PreviousVaLoan PropertyAddress
        /// </summary>
        public string PropertyAddress { get => _propertyAddress; set => SetField(ref _propertyAddress, value); }
        private DirtyValue<string> _propertyCity;
        /// <summary>
        /// PreviousVaLoan PropertyCity
        /// </summary>
        public string PropertyCity { get => _propertyCity; set => SetField(ref _propertyCity, value); }
        private DirtyValue<bool?> _propertyOwned;
        /// <summary>
        /// PreviousVaLoan PropertyOwned
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, OptionsJson = "{\"true\":\"Property Owned\"}")]
        public bool? PropertyOwned { get => _propertyOwned; set => SetField(ref _propertyOwned, value); }
        private DirtyValue<string> _propertyPostalCode;
        /// <summary>
        /// PreviousVaLoan PropertyPostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string PropertyPostalCode { get => _propertyPostalCode; set => SetField(ref _propertyPostalCode, value); }
        private DirtyValue<StringEnumValue<State>> _propertyState;
        /// <summary>
        /// PreviousVaLoan PropertyState
        /// </summary>
        public StringEnumValue<State> PropertyState { get => _propertyState; set => SetField(ref _propertyState, value); }
        private DirtyValue<string> _vALoanNumber;
        /// <summary>
        /// PreviousVaLoan VALoanNumber
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string VALoanNumber { get => _vALoanNumber; set => SetField(ref _vALoanNumber, value); }
    }
}