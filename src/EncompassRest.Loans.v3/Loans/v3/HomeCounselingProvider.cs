using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// HomeCounselingProvider
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class HomeCounselingProvider : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Home Counseling Provider - Agency Address [HC0003]
    /// </summary>
    public string? AgencyAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address City [HC0004]
    /// </summary>
    public string? AgencyAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address Postal Code [HC0006]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AgencyAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address State [HC0005]
    /// </summary>
    public string? AgencyAddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Affiliation Description [HC0015]
    /// </summary>
    public string? AgencyAffiliationDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Affiliation Indicator [HC0014]
    /// </summary>
    public bool? AgencyAffiliationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Email [HC0010]
    /// </summary>
    public string? AgencyEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Fax [HC0009]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AgencyFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency ID [HC0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AgencyId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Name [HC0002]
    /// </summary>
    public string? AgencyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Phone Direct [HC0007]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AgencyPhoneDirect { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Phone Toll Free Number [HC0008]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AgencyPhoneTollFree { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Source [HC0016]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AgencySource { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Web Address [HC0011]
    /// </summary>
    public string? AgencyWebAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HomeCounselingProvider AltId
    /// </summary>
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Counseling Services Provided [HC0013]
    /// </summary>
    public string? CounselingServicesProvided { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Distance Number of Miles [HC0017]
    /// </summary>
    public decimal? DistanceMiles { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HomeCounselingProvider HomeCounselingProviderId
    /// </summary>
    public string? HomeCounselingProviderId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HomeCounselingProvider Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Languages Supported [HC0012]
    /// </summary>
    public string? LanguagesSupported { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Selected Indicator [HC0001]
    /// </summary>
    public bool? SelectedIndicator { get => GetValue<bool?>(); set => SetValue(value); }
}