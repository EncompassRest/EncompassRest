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
    /// <summary>
    /// Non-Borrowing Owner File Contact - Address City [NBOC0006]
    /// </summary>
    public string? AddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address Postal Code [NBOC0008]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address State [NBOC0007]
    /// </summary>
    public string? AddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address Street [NBOC0005]
    /// </summary>
    public string? AddressStreet { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Vesting Type [NBOC0009]
    /// </summary>
    public StringEnumValue<NonBorrowingOwnerBorrowerType> BorrowerType { get => GetValue<StringEnumValue<NonBorrowingOwnerBorrowerType>>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Borrower Vesting Record ID [NBOC0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BorrowerVestingRecordId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Business Phone Number [NBOC0013]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? BusinessPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Cell Phone Number [NBOC0014]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? CellPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Address Country [NBOC0023]
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Date of Birth [NBOC0016]
    /// </summary>
    public DateTime? DateOfBirth { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Email [NBOC0011]
    /// </summary>
    public string? Email { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Date Accepted [NBOC0018]
    /// </summary>
    public DateTime? ESignConsentNbocDateAccepted { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Sent Date [NBOC0021]
    /// </summary>
    public DateTime? ESignConsentNbocDateSent { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent IP Address [NBOC0019]
    /// </summary>
    public string? ESignConsentNbocIpAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Source [NBOC0020]
    /// </summary>
    public string? ESignConsentNbocSource { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner eConsent Status [NBOC0017]
    /// </summary>
    public string? ESignConsentNbocStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Fax Number [NBOC0015]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? FaxNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - First Name [NBOC0001]
    /// </summary>
    public string? FirstName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Foreign Address Indicator [NBOC0022]
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Home Phone Number [NBOC0010]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HomePhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NonBorrowingOwner Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Last Name [NBOC0003]
    /// </summary>
    public string? LastName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - NBO Record ID [NBOC0098]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LegacyId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Middle Name [NBOC0002]
    /// </summary>
    public string? MiddleName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - No Third-Party Email Indicator [NBOC0012]
    /// </summary>
    public bool? No3rdPartyEmailIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// NonBorrowingOwner NonBorrowingOwnerIndex
    /// </summary>
    public int? NonBorrowingOwnerIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Non-Borrowing Owner File Contact - Suffix Name [NBOC0004]
    /// </summary>
    public string? SuffixName { get => GetValue<string?>(); set => SetValue(value); }
}