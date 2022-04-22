using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// HomeCounselingProvider
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class HomeCounselingProvider : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Home Counseling Provider - Agency Address [HCNN03]
    /// </summary>
    public string? AgencyAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address City [HCNN04]
    /// </summary>
    public string? AgencyAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address Postal Code [HCNN06]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AgencyAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address State [HCNN05]
    /// </summary>
    public StringEnumValue<State> AgencyAddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Affiliation Description [HCNN15]
    /// </summary>
    public string? AgencyAffiliationDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Affiliation Indicator [HCNN14]
    /// </summary>
    public bool? AgencyAffiliationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Email [HCNN10]
    /// </summary>
    public string? AgencyEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Fax [HCNN09]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AgencyFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency ID [HCNN99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AgencyId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Name [HCNN02]
    /// </summary>
    public string? AgencyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Phone Direct [HCNN07]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AgencyPhoneDirect { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Phone Toll Free Number [HCNN08]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AgencyPhoneTollFree { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Source [HCNN16]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AgencySource { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Web Address [HCNN11]
    /// </summary>
    public string? AgencyWebAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Counseling Services Provided [HCNN13]
    /// </summary>
    public string? CounselingServicesProvided { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Distance Number of Miles [HCNN17]
    /// </summary>
    public decimal? DistanceMiles { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HomeCounselingProvider HomeCounselingProviderId
    /// </summary>
    public string? HomeCounselingProviderId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HomeCounselingProvider HomeCounselingProviderIndex
    /// </summary>
    public int? HomeCounselingProviderIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HomeCounselingProvider Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Languages Supported [HCNN12]
    /// </summary>
    public string? LanguagesSupported { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Selected Indicator [HCNN01]
    /// </summary>
    public bool? SelectedIndicator { get => GetValue<bool?>(); set => SetValue(value); }
}