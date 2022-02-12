using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// NonBorrowingOwner
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class NonBorrowingOwner : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _addressCity;
    private DirtyValue<string?>? _addressPostalCode;
    private DirtyValue<StringEnumValue<State>>? _addressState;
    private DirtyValue<string?>? _addressStreet;
    private DirtyValue<StringEnumValue<NonBorrowingOwnerBorrowerType>>? _borrowerType;
    private DirtyValue<string?>? _borrowerVestingRecordID;
    private DirtyValue<string?>? _businessPhoneNumber;
    private DirtyValue<string?>? _cellPhoneNumber;
    private DirtyValue<string?>? _country;
    private DirtyValue<DateTime?>? _dateOfBirth;
    private DirtyValue<string?>? _email;
    private DirtyValue<bool?>? _entityDeleted;
    private DirtyValue<DateTime?>? _eSignConsentNBOCDateAccepted;
    private DirtyValue<DateTime?>? _eSignConsentNBOCDateSent;
    private DirtyValue<string?>? _eSignConsentNBOCIPAddress;
    private DirtyValue<string?>? _eSignConsentNBOCSource;
    private DirtyValue<string?>? _eSignConsentNBOCStatus;
    private DirtyValue<string?>? _faxNumber;
    private DirtyValue<string?>? _firstName;
    private DirtyValue<bool?>? _foreignAddressIndicator;
    private DirtyValue<string?>? _homePhoneNumber;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _lastName;
    private DirtyValue<string?>? _middleName;
    private DirtyValue<string?>? _nBOID;
    private DirtyValue<bool?>? _no3rdPartyEmailIndicator;
    private DirtyValue<string?>? _suffixName;

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address City [NBOCNB06]
    /// </summary>
    public string? AddressCity { get => _addressCity; set => SetField(ref _addressCity, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address Postal Code [NBOCNB08]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AddressPostalCode { get => _addressPostalCode; set => SetField(ref _addressPostalCode, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address State [NBOCNB07]
    /// </summary>
    public StringEnumValue<State> AddressState { get => _addressState; set => SetField(ref _addressState, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address Street [NBOCNB05]
    /// </summary>
    public string? AddressStreet { get => _addressStreet; set => SetField(ref _addressStreet, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Vesting Type [NBOCNB09]
    /// </summary>
    public StringEnumValue<NonBorrowingOwnerBorrowerType> BorrowerType { get => _borrowerType; set => SetField(ref _borrowerType, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Borrower Vesting Record ID [NBOCNB99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BorrowerVestingRecordID { get => _borrowerVestingRecordID; set => SetField(ref _borrowerVestingRecordID, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Business Phone Number [NBOCNB13]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? BusinessPhoneNumber { get => _businessPhoneNumber; set => SetField(ref _businessPhoneNumber, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Cell Phone Number [NBOCNB14]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? CellPhoneNumber { get => _cellPhoneNumber; set => SetField(ref _cellPhoneNumber, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address Country [NBOCNB23]
    /// </summary>
    public string? Country { get => _country; set => SetField(ref _country, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Date of Birth [NBOCNB16]
    /// </summary>
    public DateTime? DateOfBirth { get => _dateOfBirth; set => SetField(ref _dateOfBirth, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Email [NBOCNB11]
    /// </summary>
    public string? Email { get => _email; set => SetField(ref _email, value); }

    /// <summary>
    /// NonBorrowingOwner EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Date Accepted [NBOCNB18]
    /// </summary>
    public DateTime? eSignConsentNBOCDateAccepted { get => _eSignConsentNBOCDateAccepted; set => SetField(ref _eSignConsentNBOCDateAccepted, value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Sent Date [NBOCNB21]
    /// </summary>
    public DateTime? eSignConsentNBOCDateSent { get => _eSignConsentNBOCDateSent; set => SetField(ref _eSignConsentNBOCDateSent, value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent IP Address [NBOCNB19]
    /// </summary>
    public string? eSignConsentNBOCIPAddress { get => _eSignConsentNBOCIPAddress; set => SetField(ref _eSignConsentNBOCIPAddress, value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Source [NBOCNB20]
    /// </summary>
    public string? eSignConsentNBOCSource { get => _eSignConsentNBOCSource; set => SetField(ref _eSignConsentNBOCSource, value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Status [NBOCNB17]
    /// </summary>
    public string? eSignConsentNBOCStatus { get => _eSignConsentNBOCStatus; set => SetField(ref _eSignConsentNBOCStatus, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Fax Number [NBOCNB15]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? FaxNumber { get => _faxNumber; set => SetField(ref _faxNumber, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - First Name [NBOCNB01]
    /// </summary>
    public string? FirstName { get => _firstName; set => SetField(ref _firstName, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Foreign Address Indicator [NBOCNB22]
    /// </summary>
    public bool? ForeignAddressIndicator { get => _foreignAddressIndicator; set => SetField(ref _foreignAddressIndicator, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Home Phone Number [NBOCNB10]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HomePhoneNumber { get => _homePhoneNumber; set => SetField(ref _homePhoneNumber, value); }

    /// <summary>
    /// NonBorrowingOwner Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Last Name [NBOCNB03]
    /// </summary>
    public string? LastName { get => _lastName; set => SetField(ref _lastName, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Middle Name [NBOCNB02]
    /// </summary>
    public string? MiddleName { get => _middleName; set => SetField(ref _middleName, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - NBO Record ID [NBOCNB98]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? NBOID { get => _nBOID; set => SetField(ref _nBOID, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - No Third-Party Email Indicator [NBOCNB12]
    /// </summary>
    public bool? No3rdPartyEmailIndicator { get => _no3rdPartyEmailIndicator; set => SetField(ref _no3rdPartyEmailIndicator, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Suffix Name [NBOCNB04]
    /// </summary>
    public string? SuffixName { get => _suffixName; set => SetField(ref _suffixName, value); }
}