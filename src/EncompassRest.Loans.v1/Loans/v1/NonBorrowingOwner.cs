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
    /// <summary>
    /// Non-Borrowing Owner File Contact - Address City [NBOCNB06]
    /// </summary>
    public string? AddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address Postal Code [NBOCNB08]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address State [NBOCNB07]
    /// </summary>
    public StringEnumValue<State> AddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address Street [NBOCNB05]
    /// </summary>
    public string? AddressStreet { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Vesting Type [NBOCNB09]
    /// </summary>
    public StringEnumValue<NonBorrowingOwnerBorrowerType> BorrowerType { get => GetValue<StringEnumValue<NonBorrowingOwnerBorrowerType>>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Borrower Vesting Record ID [NBOCNB99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BorrowerVestingRecordID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Business Phone Number [NBOCNB13]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? BusinessPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Cell Phone Number [NBOCNB14]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? CellPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address Country [NBOCNB23]
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Date of Birth [NBOCNB16]
    /// </summary>
    public DateTime? DateOfBirth { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Email [NBOCNB11]
    /// </summary>
    public string? Email { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NonBorrowingOwner EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Date Accepted [NBOCNB18]
    /// </summary>
    public DateTime? eSignConsentNBOCDateAccepted { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Sent Date [NBOCNB21]
    /// </summary>
    public DateTime? eSignConsentNBOCDateSent { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent IP Address [NBOCNB19]
    /// </summary>
    public string? eSignConsentNBOCIPAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Source [NBOCNB20]
    /// </summary>
    public string? eSignConsentNBOCSource { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Status [NBOCNB17]
    /// </summary>
    public string? eSignConsentNBOCStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Fax Number [NBOCNB15]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? FaxNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - First Name [NBOCNB01]
    /// </summary>
    public string? FirstName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Foreign Address Indicator [NBOCNB22]
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Home Phone Number [NBOCNB10]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HomePhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NonBorrowingOwner Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Last Name [NBOCNB03]
    /// </summary>
    public string? LastName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Middle Name [NBOCNB02]
    /// </summary>
    public string? MiddleName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - NBO Record ID [NBOCNB98]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? NBOID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - No Third-Party Email Indicator [NBOCNB12]
    /// </summary>
    public bool? No3rdPartyEmailIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Suffix Name [NBOCNB04]
    /// </summary>
    public string? SuffixName { get => GetValue<string?>(); set => SetValue(value); }
}