using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// SelectedHomeCounselingProvider
/// </summary>
public sealed partial class SelectedHomeCounselingProvider : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Home Counseling Provider - Home Counseling Affiliated With Lender Indicator [HOC.X21]
    /// </summary>
    public bool? AffiliatedWithLenderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address [HOC.X3]
    /// </summary>
    public string? AgencyAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address City [HOC.X4]
    /// </summary>
    public string? AgencyAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address Postal Code [HOC.X6]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AgencyAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Address State [HOC.X5]
    /// </summary>
    public string? AgencyAddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Affiliation Description [HOC.X15]
    /// </summary>
    public string? AgencyAffiliationDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Email [HOC.X10]
    /// </summary>
    public string? AgencyEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Fax [HOC.X9]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AgencyFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Name [HOC.X2]
    /// </summary>
    public string? AgencyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Phone Direct [HOC.X7]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AgencyPhoneDirect { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Phone Toll Free Number [HOC.X8]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AgencyPhoneTollFree { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Agency Web Address [HOC.X11]
    /// </summary>
    public string? AgencyWebAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider -  Borrower Select Counselor Indicator [HOC.X22]
    /// </summary>
    public bool? BorrowerSelectCounselorIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Home Counseling Certification Issued Indicator [HOC.X18]
    /// </summary>
    public bool? CertificationIssuedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Counseling Services Provided [HOC.X13]
    /// </summary>
    public string? CounselingServicesProvided { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Distance Number of Miles [HOC.X20]
    /// </summary>
    public decimal? DistanceMiles { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Explanation [HOC.X23]
    /// </summary>
    public string? Explanation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Home Counseling Completion Date [HOC.X17]
    /// </summary>
    public DateTime? HomeCounselingCompletionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Home Counseling Disclosure Date [HOC.X19]
    /// </summary>
    public DateTime? HomeCounselingDisclosureDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Home Counseling Generated Date [HOC.X24]
    /// </summary>
    public DateTime? HomeCounselingGeneratedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Home Counseling Required [HOC.X16]
    /// </summary>
    public bool? HomeCounselingRequiredIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Languages Supported [HOC.X12]
    /// </summary>
    public string? LanguagesSupported { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Home Counseling Provider - Selected Record ID [HOC.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SelectedGuid { get => GetValue<string?>(); set => SetValue(value); }
}