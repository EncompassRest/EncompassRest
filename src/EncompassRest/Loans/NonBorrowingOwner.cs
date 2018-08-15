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
        public string AddressCity { get => _addressCity; set => SetField(ref _addressCity, value); }
        private DirtyValue<string> _addressPostalCode;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Address Postal Code [NBOCNB08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Non-Borrowing Owner File Contact - Address Postal Code")]
        public string AddressPostalCode { get => _addressPostalCode; set => SetField(ref _addressPostalCode, value); }
        private DirtyValue<StringEnumValue<State>> _addressState;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Address State [NBOCNB07]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Address State")]
        public StringEnumValue<State> AddressState { get => _addressState; set => SetField(ref _addressState, value); }
        private DirtyValue<string> _addressStreet;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Address Street [NBOCNB05]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Address Street")]
        public string AddressStreet { get => _addressStreet; set => SetField(ref _addressStreet, value); }
        private DirtyValue<StringEnumValue<NonBorrowingOwnerBorrowerType>> _borrowerType;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Vesting Type [NBOCNB09]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Vesting Type")]
        public StringEnumValue<NonBorrowingOwnerBorrowerType> BorrowerType { get => _borrowerType; set => SetField(ref _borrowerType, value); }
        private DirtyValue<string> _businessPhoneNumber;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Business Phone Number [NBOCNB13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Non-Borrowing Owner File Contact - Business Phone Number")]
        public string BusinessPhoneNumber { get => _businessPhoneNumber; set => SetField(ref _businessPhoneNumber, value); }
        private DirtyValue<string> _cellPhoneNumber;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Cell Phone Number [NBOCNB14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Non-Borrowing Owner File Contact - Cell Phone Number")]
        public string CellPhoneNumber { get => _cellPhoneNumber; set => SetField(ref _cellPhoneNumber, value); }
        private DirtyValue<DateTime?> _dateOfBirth;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Date of Birth [NBOCNB16]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Date of Birth")]
        public DateTime? DateOfBirth { get => _dateOfBirth; set => SetField(ref _dateOfBirth, value); }
        private DirtyValue<string> _email;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Email [NBOCNB11]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Email")]
        public string Email { get => _email; set => SetField(ref _email, value); }
        private DirtyValue<string> _faxNumber;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Fax Number [NBOCNB15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Non-Borrowing Owner File Contact - Fax Number")]
        public string FaxNumber { get => _faxNumber; set => SetField(ref _faxNumber, value); }
        private DirtyValue<string> _firstName;
        /// <summary>
        /// Non-Borrowing Owner File Contact - First Name [NBOCNB01]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - First Name")]
        public string FirstName { get => _firstName; set => SetField(ref _firstName, value); }
        private DirtyValue<string> _homePhoneNumber;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Home Phone Number [NBOCNB10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Non-Borrowing Owner File Contact - Home Phone Number")]
        public string HomePhoneNumber { get => _homePhoneNumber; set => SetField(ref _homePhoneNumber, value); }
        private DirtyValue<string> _lastName;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Last Name [NBOCNB03]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Last Name")]
        public string LastName { get => _lastName; set => SetField(ref _lastName, value); }
        private DirtyValue<string> _middleName;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Middle Name [NBOCNB02]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Middle Name")]
        public string MiddleName { get => _middleName; set => SetField(ref _middleName, value); }
        private DirtyValue<bool?> _no3rdPartyEmailIndicator;
        /// <summary>
        /// Non-Borrowing Owner File Contact - No Third-Party Email Indicator [NBOCNB12]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - No Third-Party Email Indicator")]
        public bool? No3rdPartyEmailIndicator { get => _no3rdPartyEmailIndicator; set => SetField(ref _no3rdPartyEmailIndicator, value); }
        private DirtyValue<string> _suffixName;
        /// <summary>
        /// Non-Borrowing Owner File Contact - Suffix Name [NBOCNB04]
        /// </summary>
        [LoanFieldProperty(Description = "Non-Borrowing Owner File Contact - Suffix Name")]
        public string SuffixName { get => _suffixName; set => SetField(ref _suffixName, value); }
    }
}