using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// SelectedHomeCounselingProvider
/// </summary>
public sealed partial class SelectedHomeCounselingProvider : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<bool?>? _affiliatedWithLenderIndicator;
    private DirtyValue<string?>? _agencyAddress;
    private DirtyValue<string?>? _agencyAddressCity;
    private DirtyValue<string?>? _agencyAddressPostalCode;
    private DirtyValue<StringEnumValue<State>>? _agencyAddressState;
    private DirtyValue<string?>? _agencyAffiliationDescription;
    private DirtyValue<string?>? _agencyEmail;
    private DirtyValue<string?>? _agencyFax;
    private DirtyValue<string?>? _agencyName;
    private DirtyValue<string?>? _agencyPhoneDirect;
    private DirtyValue<string?>? _agencyPhoneTollFree;
    private DirtyValue<string?>? _agencyWebAddress;
    private DirtyValue<bool?>? _brrowerSelectCounselorIndicator;
    private DirtyValue<bool?>? _certificationIssuedIndicator;
    private DirtyValue<string?>? _counselingServicesProvided;
    private DirtyValue<decimal?>? _distanceMiles;
    private DirtyValue<string?>? _explanation;
    private DirtyValue<DateTime?>? _homeCounselingCompletionDate;
    private DirtyValue<DateTime?>? _homeCounselingDisclosureDate;
    private DirtyValue<DateTime?>? _homeCounselingGeneratedDate;
    private DirtyValue<bool?>? _homeCounselingRequiredIndicator;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _languagesSupported;
    private DirtyValue<string?>? _selectedGUID;

    /// <summary>
    /// Home Counseling Provider - Home Counseling Affiliated With Lender Indicator [HOC.X21]
    /// </summary>
    public bool? AffiliatedWithLenderIndicator { get => _affiliatedWithLenderIndicator; set => SetField(ref _affiliatedWithLenderIndicator, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address [HOC.X3]
    /// </summary>
    public string? AgencyAddress { get => _agencyAddress; set => SetField(ref _agencyAddress, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address City [HOC.X4]
    /// </summary>
    public string? AgencyAddressCity { get => _agencyAddressCity; set => SetField(ref _agencyAddressCity, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address Postal Code [HOC.X6]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AgencyAddressPostalCode { get => _agencyAddressPostalCode; set => SetField(ref _agencyAddressPostalCode, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address State [HOC.X5]
    /// </summary>
    public StringEnumValue<State> AgencyAddressState { get => _agencyAddressState; set => SetField(ref _agencyAddressState, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Affiliation Description [HOC.X15]
    /// </summary>
    public string? AgencyAffiliationDescription { get => _agencyAffiliationDescription; set => SetField(ref _agencyAffiliationDescription, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Email [HOC.X10]
    /// </summary>
    public string? AgencyEmail { get => _agencyEmail; set => SetField(ref _agencyEmail, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Fax [HOC.X9]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AgencyFax { get => _agencyFax; set => SetField(ref _agencyFax, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Name [HOC.X2]
    /// </summary>
    public string? AgencyName { get => _agencyName; set => SetField(ref _agencyName, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Phone Direct [HOC.X7]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AgencyPhoneDirect { get => _agencyPhoneDirect; set => SetField(ref _agencyPhoneDirect, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Phone Toll Free Number [HOC.X8]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AgencyPhoneTollFree { get => _agencyPhoneTollFree; set => SetField(ref _agencyPhoneTollFree, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Web Address [HOC.X11]
    /// </summary>
    public string? AgencyWebAddress { get => _agencyWebAddress; set => SetField(ref _agencyWebAddress, value); }

    /// <summary>
    /// Home Counseling Provider -  Borrower Select Counselor Indicator [HOC.X22]
    /// </summary>
    public bool? BrrowerSelectCounselorIndicator { get => _brrowerSelectCounselorIndicator; set => SetField(ref _brrowerSelectCounselorIndicator, value); }

    /// <summary>
    /// Home Counseling Provider - Home Counseling Certification Issued Indicator [HOC.X18]
    /// </summary>
    public bool? CertificationIssuedIndicator { get => _certificationIssuedIndicator; set => SetField(ref _certificationIssuedIndicator, value); }

    /// <summary>
    /// Home Counseling Provider - Counseling Services Provided [HOC.X13]
    /// </summary>
    public string? CounselingServicesProvided { get => _counselingServicesProvided; set => SetField(ref _counselingServicesProvided, value); }

    /// <summary>
    /// Home Counseling Provider - Distance Number of Miles [HOC.X20]
    /// </summary>
    public decimal? DistanceMiles { get => _distanceMiles; set => SetField(ref _distanceMiles, value); }

    /// <summary>
    /// Home Counseling Provider - Explanation [HOC.X23]
    /// </summary>
    public string? Explanation { get => _explanation; set => SetField(ref _explanation, value); }

    /// <summary>
    /// Home Counseling Provider - Home Counseling Completion Date [HOC.X17]
    /// </summary>
    public DateTime? HomeCounselingCompletionDate { get => _homeCounselingCompletionDate; set => SetField(ref _homeCounselingCompletionDate, value); }

    /// <summary>
    /// Home Counseling Provider - Home Counseling Disclosure Date [HOC.X19]
    /// </summary>
    public DateTime? HomeCounselingDisclosureDate { get => _homeCounselingDisclosureDate; set => SetField(ref _homeCounselingDisclosureDate, value); }

    /// <summary>
    /// Home Counseling Provider - Home Counseling Generated Date [HOC.X24]
    /// </summary>
    public DateTime? HomeCounselingGeneratedDate { get => _homeCounselingGeneratedDate; set => SetField(ref _homeCounselingGeneratedDate, value); }

    /// <summary>
    /// Home Counseling Provider - Home Counseling Required [HOC.X16]
    /// </summary>
    public bool? HomeCounselingRequiredIndicator { get => _homeCounselingRequiredIndicator; set => SetField(ref _homeCounselingRequiredIndicator, value); }

    /// <summary>
    /// SelectedHomeCounselingProvider Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Home Counseling Provider - Languages Supported [HOC.X12]
    /// </summary>
    public string? LanguagesSupported { get => _languagesSupported; set => SetField(ref _languagesSupported, value); }

    /// <summary>
    /// Home Counseling Provider - Selected Record ID [HOC.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SelectedGUID { get => _selectedGUID; set => SetField(ref _selectedGUID, value); }
}