using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// NonBorrowingOwner
    /// </summary>
    public sealed partial class NonBorrowingOwner : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _addressCity;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Address City [NBOCNB06]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Address City")]
        public string AddressCity { get => _addressCity; set => _addressCity = value; }
        private DirtyValue<string> _addressPostalCode;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Address Postal Code [NBOCNB08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Non-Borrowing Owner File Contact - Address Postal Code")]
        public string AddressPostalCode { get => _addressPostalCode; set => _addressPostalCode = value; }
        private DirtyValue<StringEnumValue<State>> _addressState;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Address State [NBOCNB07]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Address State")]
        public StringEnumValue<State> AddressState { get => _addressState; set => _addressState = value; }
        private DirtyValue<string> _addressStreet;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Address Street [NBOCNB05]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Address Street")]
        public string AddressStreet { get => _addressStreet; set => _addressStreet = value; }
        private DirtyValue<StringEnumValue<NonBorrowingOwnerBorrowerType>> _borrowerType;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Vesting Type [NBOCNB09]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Vesting Type")]
        public StringEnumValue<NonBorrowingOwnerBorrowerType> BorrowerType { get => _borrowerType; set => _borrowerType = value; }
        private DirtyValue<string> _businessPhoneNumber;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Business Phone Number [NBOCNB13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Non-Borrowing Owner File Contact - Business Phone Number")]
        public string BusinessPhoneNumber { get => _businessPhoneNumber; set => _businessPhoneNumber = value; }
        private DirtyValue<string> _cellPhoneNumber;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Cell Phone Number [NBOCNB14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Non-Borrowing Owner File Contact - Cell Phone Number")]
        public string CellPhoneNumber { get => _cellPhoneNumber; set => _cellPhoneNumber = value; }
        private DirtyValue<DateTime?> _dateOfBirth;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Date of Birth [NBOCNB16]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Date of Birth")]
        public DateTime? DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        private DirtyValue<string> _email;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Email [NBOCNB11]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Email")]
        public string Email { get => _email; set => _email = value; }
        private DirtyValue<string> _faxNumber;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Fax Number [NBOCNB15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Non-Borrowing Owner File Contact - Fax Number")]
        public string FaxNumber { get => _faxNumber; set => _faxNumber = value; }
        private DirtyValue<string> _firstName;
        /// <summary>
        /// Non-Borrowing Owner File Contact - First Name [NBOCNB01]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - First Name")]
        public string FirstName { get => _firstName; set => _firstName = value; }
        private DirtyValue<string> _homePhoneNumber;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Home Phone Number [NBOCNB10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Non-Borrowing Owner File Contact - Home Phone Number")]
        public string HomePhoneNumber { get => _homePhoneNumber; set => _homePhoneNumber = value; }
        private DirtyValue<string> _lastName;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Last Name [NBOCNB03]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Last Name")]
        public string LastName { get => _lastName; set => _lastName = value; }
        private DirtyValue<string> _middleName;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Middle Name [NBOCNB02]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Middle Name")]
        public string MiddleName { get => _middleName; set => _middleName = value; }
        private DirtyValue<bool?> _no3rdPartyEmailIndicator;
        /// <summary>
        /// Non-Borrowing Owner File Contact - No Third-Party Email Indicator [NBOCNB12]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - No Third-Party Email Indicator")]
        public bool? No3rdPartyEmailIndicator { get => _no3rdPartyEmailIndicator; set => _no3rdPartyEmailIndicator = value; }
        private DirtyValue<string> _suffixName;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Suffix Name [NBOCNB04]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Suffix Name")]
        public string SuffixName { get => _suffixName; set => _suffixName = value; }
        internal override bool DirtyInternal
        {
            get => _addressCity.Dirty
                || _addressPostalCode.Dirty
                || _addressState.Dirty
                || _addressStreet.Dirty
                || _borrowerType.Dirty
                || _businessPhoneNumber.Dirty
                || _cellPhoneNumber.Dirty
                || _dateOfBirth.Dirty
                || _email.Dirty
                || _faxNumber.Dirty
                || _firstName.Dirty
                || _homePhoneNumber.Dirty
                || _lastName.Dirty
                || _middleName.Dirty
                || _no3rdPartyEmailIndicator.Dirty
                || _suffixName.Dirty;
            set
            {
                _addressCity.Dirty = value;
                _addressPostalCode.Dirty = value;
                _addressState.Dirty = value;
                _addressStreet.Dirty = value;
                _borrowerType.Dirty = value;
                _businessPhoneNumber.Dirty = value;
                _cellPhoneNumber.Dirty = value;
                _dateOfBirth.Dirty = value;
                _email.Dirty = value;
                _faxNumber.Dirty = value;
                _firstName.Dirty = value;
                _homePhoneNumber.Dirty = value;
                _lastName.Dirty = value;
                _middleName.Dirty = value;
                _no3rdPartyEmailIndicator.Dirty = value;
                _suffixName.Dirty = value;
            }
        }
    }
}