using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// NonBorrowingOwner
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class NonBorrowingOwner : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _addressCity;
    private DirtyValue<string?>? _addressPostalCode;
    private DirtyValue<string?>? _addressState;
    private DirtyValue<string?>? _addressStreet;
    private DirtyValue<StringEnumValue<NonBorrowingOwnerBorrowerType>>? _borrowerType;
    private DirtyValue<string?>? _borrowerVestingRecordId;
    private DirtyValue<string?>? _businessPhoneNumber;
    private DirtyValue<string?>? _cellPhoneNumber;
    private DirtyValue<string?>? _country;
    private DirtyValue<DateTime?>? _dateOfBirth;
    private DirtyValue<string?>? _email;
    private DirtyValue<DateTime?>? _eSignConsentNbocDateAccepted;
    private DirtyValue<DateTime?>? _eSignConsentNbocDateSent;
    private DirtyValue<string?>? _eSignConsentNbocIpAddress;
    private DirtyValue<string?>? _eSignConsentNbocSource;
    private DirtyValue<string?>? _eSignConsentNbocStatus;
    private DirtyValue<string?>? _faxNumber;
    private DirtyValue<string?>? _firstName;
    private DirtyValue<bool?>? _foreignAddressIndicator;
    private DirtyValue<string?>? _homePhoneNumber;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _lastName;
    private DirtyValue<string?>? _legacyId;
    private DirtyValue<string?>? _middleName;
    private DirtyValue<bool?>? _no3rdPartyEmailIndicator;
    private DirtyValue<int?>? _nonBorrowingOwnerIndex;
    private DirtyValue<string?>? _suffixName;

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address City [NBOC0006]
    /// </summary>
    public string? AddressCity { get => _addressCity; set => SetField(ref _addressCity, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address Postal Code [NBOC0008]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AddressPostalCode { get => _addressPostalCode; set => SetField(ref _addressPostalCode, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address State [NBOC0007]
    /// </summary>
    public string? AddressState { get => _addressState; set => SetField(ref _addressState, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address Street [NBOC0005]
    /// </summary>
    public string? AddressStreet { get => _addressStreet; set => SetField(ref _addressStreet, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Vesting Type [NBOC0009]
    /// </summary>
    public StringEnumValue<NonBorrowingOwnerBorrowerType> BorrowerType { get => _borrowerType; set => SetField(ref _borrowerType, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Borrower Vesting Record ID [NBOC0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BorrowerVestingRecordId { get => _borrowerVestingRecordId; set => SetField(ref _borrowerVestingRecordId, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Business Phone Number [NBOC0013]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? BusinessPhoneNumber { get => _businessPhoneNumber; set => SetField(ref _businessPhoneNumber, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Cell Phone Number [NBOC0014]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? CellPhoneNumber { get => _cellPhoneNumber; set => SetField(ref _cellPhoneNumber, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address Country [NBOC0023]
    /// </summary>
    public string? Country { get => _country; set => SetField(ref _country, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Date of Birth [NBOC0016]
    /// </summary>
    public DateTime? DateOfBirth { get => _dateOfBirth; set => SetField(ref _dateOfBirth, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Email [NBOC0011]
    /// </summary>
    public string? Email { get => _email; set => SetField(ref _email, value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Date Accepted [NBOC0018]
    /// </summary>
    public DateTime? ESignConsentNbocDateAccepted { get => _eSignConsentNbocDateAccepted; set => SetField(ref _eSignConsentNbocDateAccepted, value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Sent Date [NBOC0021]
    /// </summary>
    public DateTime? ESignConsentNbocDateSent { get => _eSignConsentNbocDateSent; set => SetField(ref _eSignConsentNbocDateSent, value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent IP Address [NBOC0019]
    /// </summary>
    public string? ESignConsentNbocIpAddress { get => _eSignConsentNbocIpAddress; set => SetField(ref _eSignConsentNbocIpAddress, value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Source [NBOC0020]
    /// </summary>
    public string? ESignConsentNbocSource { get => _eSignConsentNbocSource; set => SetField(ref _eSignConsentNbocSource, value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Status [NBOC0017]
    /// </summary>
    public string? ESignConsentNbocStatus { get => _eSignConsentNbocStatus; set => SetField(ref _eSignConsentNbocStatus, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Fax Number [NBOC0015]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? FaxNumber { get => _faxNumber; set => SetField(ref _faxNumber, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - First Name [NBOC0001]
    /// </summary>
    public string? FirstName { get => _firstName; set => SetField(ref _firstName, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Foreign Address Indicator [NBOC0022]
    /// </summary>
    public bool? ForeignAddressIndicator { get => _foreignAddressIndicator; set => SetField(ref _foreignAddressIndicator, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Home Phone Number [NBOC0010]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HomePhoneNumber { get => _homePhoneNumber; set => SetField(ref _homePhoneNumber, value); }

    /// <summary>
    /// NonBorrowingOwnerContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Last Name [NBOC0003]
    /// </summary>
    public string? LastName { get => _lastName; set => SetField(ref _lastName, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - NBO Record ID [NBOC0098]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LegacyId { get => _legacyId; set => SetField(ref _legacyId, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Middle Name [NBOC0002]
    /// </summary>
    public string? MiddleName { get => _middleName; set => SetField(ref _middleName, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - No Third-Party Email Indicator [NBOC0012]
    /// </summary>
    public bool? No3rdPartyEmailIndicator { get => _no3rdPartyEmailIndicator; set => SetField(ref _no3rdPartyEmailIndicator, value); }

    /// <summary>
    /// NonBorrowingOwnerContract NonBorrowingOwnerIndex
    /// </summary>
    public int? NonBorrowingOwnerIndex { get => _nonBorrowingOwnerIndex; set => SetField(ref _nonBorrowingOwnerIndex, value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Suffix Name [NBOC0004]
    /// </summary>
    public string? SuffixName { get => _suffixName; set => SetField(ref _suffixName, value); }
}