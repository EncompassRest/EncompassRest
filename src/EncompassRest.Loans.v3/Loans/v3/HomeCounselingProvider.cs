using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// HomeCounselingProvider
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class HomeCounselingProvider : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _agencyAddress;
    private DirtyValue<string?>? _agencyAddressCity;
    private DirtyValue<string?>? _agencyAddressPostalCode;
    private DirtyValue<string?>? _agencyAddressState;
    private DirtyValue<string?>? _agencyAffiliationDescription;
    private DirtyValue<bool?>? _agencyAffiliationIndicator;
    private DirtyValue<string?>? _agencyEmail;
    private DirtyValue<string?>? _agencyFax;
    private DirtyValue<string?>? _agencyId;
    private DirtyValue<string?>? _agencyName;
    private DirtyValue<string?>? _agencyPhoneDirect;
    private DirtyValue<string?>? _agencyPhoneTollFree;
    private DirtyValue<string?>? _agencySource;
    private DirtyValue<string?>? _agencyWebAddress;
    private DirtyValue<string?>? _altId;
    private DirtyValue<string?>? _counselingServicesProvided;
    private DirtyValue<decimal?>? _distanceMiles;
    private DirtyValue<string?>? _homeCounselingProviderId;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _languagesSupported;
    private DirtyValue<bool?>? _selectedIndicator;

    /// <summary>
    /// Home Counseling Provider - Agency Address [HC0003]
    /// </summary>
    public string? AgencyAddress { get => _agencyAddress; set => SetField(ref _agencyAddress, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address City [HC0004]
    /// </summary>
    public string? AgencyAddressCity { get => _agencyAddressCity; set => SetField(ref _agencyAddressCity, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address Postal Code [HC0006]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AgencyAddressPostalCode { get => _agencyAddressPostalCode; set => SetField(ref _agencyAddressPostalCode, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address State [HC0005]
    /// </summary>
    public string? AgencyAddressState { get => _agencyAddressState; set => SetField(ref _agencyAddressState, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Affiliation Description [HC0015]
    /// </summary>
    public string? AgencyAffiliationDescription { get => _agencyAffiliationDescription; set => SetField(ref _agencyAffiliationDescription, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Affiliation Indicator [HC0014]
    /// </summary>
    public bool? AgencyAffiliationIndicator { get => _agencyAffiliationIndicator; set => SetField(ref _agencyAffiliationIndicator, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Email [HC0010]
    /// </summary>
    public string? AgencyEmail { get => _agencyEmail; set => SetField(ref _agencyEmail, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Fax [HC0009]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AgencyFax { get => _agencyFax; set => SetField(ref _agencyFax, value); }

    /// <summary>
    /// Home Counseling Provider - Agency ID [HC0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AgencyId { get => _agencyId; set => SetField(ref _agencyId, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Name [HC0002]
    /// </summary>
    public string? AgencyName { get => _agencyName; set => SetField(ref _agencyName, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Phone Direct [HC0007]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AgencyPhoneDirect { get => _agencyPhoneDirect; set => SetField(ref _agencyPhoneDirect, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Phone Toll Free Number [HC0008]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AgencyPhoneTollFree { get => _agencyPhoneTollFree; set => SetField(ref _agencyPhoneTollFree, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Source [HC0016]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AgencySource { get => _agencySource; set => SetField(ref _agencySource, value); }

    /// <summary>
    /// Home Counseling Provider - Agency Web Address [HC0011]
    /// </summary>
    public string? AgencyWebAddress { get => _agencyWebAddress; set => SetField(ref _agencyWebAddress, value); }

    /// <summary>
    /// HomeCounselingProviderContract AltId
    /// </summary>
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// Home Counseling Provider - Counseling Services Provided [HC0013]
    /// </summary>
    public string? CounselingServicesProvided { get => _counselingServicesProvided; set => SetField(ref _counselingServicesProvided, value); }

    /// <summary>
    /// Home Counseling Provider - Distance Number of Miles [HC0017]
    /// </summary>
    public decimal? DistanceMiles { get => _distanceMiles; set => SetField(ref _distanceMiles, value); }

    /// <summary>
    /// HomeCounselingProviderContract HomeCounselingProviderId
    /// </summary>
    public string? HomeCounselingProviderId { get => _homeCounselingProviderId; set => SetField(ref _homeCounselingProviderId, value); }

    /// <summary>
    /// HomeCounselingProviderContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Home Counseling Provider - Languages Supported [HC0012]
    /// </summary>
    public string? LanguagesSupported { get => _languagesSupported; set => SetField(ref _languagesSupported, value); }

    /// <summary>
    /// Home Counseling Provider - Selected Indicator [HC0001]
    /// </summary>
    public bool? SelectedIndicator { get => _selectedIndicator; set => SetField(ref _selectedIndicator, value); }
}