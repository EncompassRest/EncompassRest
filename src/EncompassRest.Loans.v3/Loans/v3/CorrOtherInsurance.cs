using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// CorrOtherInsurance
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class CorrOtherInsurance : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Correspondent - Other Insurance - Additional Coverage Amount [CORROI0016]
    /// </summary>
    public decimal? AddlCoverageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CorrOtherInsurance AltId
    /// </summary>
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company City [CORROI0004]
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Comments [CORROI0026]
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company Name [CORROI0002]
    /// </summary>
    public string? CompanyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company Contact Name [CORROI0007]
    /// </summary>
    public string? ContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Coverage Amount [CORROI0025]
    /// </summary>
    public decimal? CoverageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Insurance Effective Date [CORROI0023]
    /// </summary>
    public DateTime? EffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Insurance Escrowed? [CORROI0015]
    /// </summary>
    public bool? EscrowedFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Insurance Expiration Date [CORROI0024]
    /// </summary>
    public DateTime? ExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company Fax Number [CORROI0009]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Fax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Guaranteed Replacement Cost? [CORROI0018]
    /// </summary>
    public bool? GuaranteedReplacementCostFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// CorrOtherInsurance Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Included in Master Policy? [CORROI0001]
    /// </summary>
    public bool? IncludedInMasterPolicyFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Insurance Estimator? [CORROI0019]
    /// </summary>
    public bool? InsuranceEstimatorFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Maximum Deductible Amount [CORROI0021]
    /// </summary>
    public decimal? MaxDeductibleAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Maximum Deductible Percentage [CORROI0020]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaxDeductiblePerc { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company Phone Number [CORROI0008]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Phone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Policy # [CORROI0022]
    /// </summary>
    public string? PolicyNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Policy Type [CORROI0010]
    /// </summary>
    public StringEnumValue<PolicyType> PolicyType { get => GetValue<StringEnumValue<PolicyType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Policy Type Other Description [CORROI0011]
    /// </summary>
    public string? PolicyTypeOtherDesc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Premium Amount [CORROI0012]
    /// </summary>
    public decimal? PremiumAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Premium Due Date [CORROI0013]
    /// </summary>
    public DateTime? PremiumDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Property Value Used for Insurance [CORROI0017]
    /// </summary>
    public decimal? PropertyValueUsed { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Replacement Value [CORROI0014]
    /// </summary>
    public decimal? ReplacementValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company State [CORROI0005]
    /// </summary>
    public string? State { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company Street Address [CORROI0003]
    /// </summary>
    public string? StreetAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company Zip Code [CORROI0006]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ZipCode { get => GetValue<string?>(); set => SetValue(value); }
}