using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// CorrOtherInsurance
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class CorrOtherInsurance : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Correspondent - Other Insurance - Additional Coverage Amount [CORROINN16]
    /// </summary>
    public decimal? AddlCoverageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company City [CORROINN04]
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Comments [CORROINN26]
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company Name [CORROINN02]
    /// </summary>
    public string? CompanyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company Contact Name [CORROINN07]
    /// </summary>
    public string? ContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Coverage Amount [CORROINN25]
    /// </summary>
    public decimal? CoverageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Insurance Effective Date [CORROINN23]
    /// </summary>
    public DateTime? EffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// CorrOtherInsurance EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Insurance Escrowed? [CORROINN15]
    /// </summary>
    public bool? EscrowedFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Insurance Expiration Date [CORROINN24]
    /// </summary>
    public DateTime? ExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company Fax Number [CORROINN09]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Fax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Guaranteed Replacement Cost? [CORROINN18]
    /// </summary>
    public bool? GuaranteedReplacementCostFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// CorrOtherInsurance Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Included in Master Policy? [CORROINN01]
    /// </summary>
    public bool? IncludedInMasterPolicyFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Insurance Estimator? [CORROINN19]
    /// </summary>
    public bool? InsuranceEstimatorFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Maximum Deductible Amount [CORROINN21]
    /// </summary>
    public decimal? MaxDeductibleAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Maximum Deductible Percentage [CORROINN20]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaxDeductiblePerc { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company Phone Number [CORROINN08]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Phone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Policy # [CORROINN22]
    /// </summary>
    public string? PolicyNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Policy Type [CORROINN10]
    /// </summary>
    public StringEnumValue<PolicyType> PolicyType { get => GetValue<StringEnumValue<PolicyType>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Policy Type Other Description [CORROINN11]
    /// </summary>
    public string? PolicyTypeOtherDesc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Premium Amount [CORROINN12]
    /// </summary>
    public decimal? PremiumAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Premium Due Date [CORROINN13]
    /// </summary>
    public DateTime? PremiumDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Property Value Used for Insurance [CORROINN17]
    /// </summary>
    public decimal? PropertyValueUsed { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Replacement Value [CORROINN14]
    /// </summary>
    public decimal? ReplacementValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company State [CORROINN05]
    /// </summary>
    public StringEnumValue<State> State { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company Street Address [CORROINN03]
    /// </summary>
    public string? StreetAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Correspondent - Other Insurance - Company Zip Code [CORROINN06]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ZipCode { get => GetValue<string?>(); set => SetValue(value); }
}