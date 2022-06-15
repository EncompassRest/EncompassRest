using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// AdditionalRequests
/// </summary>
public sealed partial class AdditionalRequests : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Request Appraisal Access Information Contact Cell Phone [REQUEST.X32]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AppraisalContactCellPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Appraisal Access Information Contact Email [REQUEST.X33]
    /// </summary>
    public string? AppraisalContactEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Appraisal Contact for Entry [REQUEST.X25]
    /// </summary>
    public StringEnumValue<AppraisalContactForEntry> AppraisalContactForEntry { get => GetValue<StringEnumValue<AppraisalContactForEntry>>(); set => SetValue(value); }

    /// <summary>
    /// Request Appraisal Access Information Contact Home Phone [REQUEST.X30]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AppraisalContactHomePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Appraisal Access Information Contact Name [REQUEST.X29]
    /// </summary>
    public string? AppraisalContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Appraisal Access Information Contact Business Phone [REQUEST.X31]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? AppraisalContactWorkPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Appraisal Date Ordered [REQUEST.X21]
    /// </summary>
    public DateTime? AppraisalDateOrdered { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Request Appraisal Comments 1 [REQUEST.X26]
    /// </summary>
    public string? AppraisalDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Appraisal Comments 2 [REQUEST.X27]
    /// </summary>
    public string? AppraisalDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Appraisal Comments 3 [REQUEST.X28]
    /// </summary>
    public string? AppraisalDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Appraisal Prprty Access Key Pick Up [REQUEST.X24]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Key Pick Up\"}")]
    public bool? AppraisalKeyPickUp { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Request Appraisal Prprty Access Lockbox [REQUEST.X23]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Lock Box\"}")]
    public bool? AppraisalLockBox { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Request Appraisal Prprty Access Vacant [REQUEST.X22]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Vacant\"}")]
    public bool? AppraisalVacant { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Request Flood Ins Comments 1 [REQUEST.X8]
    /// </summary>
    public string? FloodDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Flood Ins Comments 2 [REQUEST.X9]
    /// </summary>
    public string? FloodDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Flood Ins Comments 3 [REQUEST.X10]
    /// </summary>
    public string? FloodDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Flood Ins Escrowed Yes/No [REQUEST.X7]
    /// </summary>
    public bool? FloodInsuranceEscrowed { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Request Flood Ins Replacement Value [REQUEST.X6]
    /// </summary>
    public string? FloodReplacementValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Hazard Ins Comments 1 [REQUEST.X3]
    /// </summary>
    public string? HazardDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Hazard Ins Comments 2 [REQUEST.X4]
    /// </summary>
    public string? HazardDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Hazard Ins Comments 3 [REQUEST.X5]
    /// </summary>
    public string? HazardDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Hazard Ins Escrowed Yes/No [REQUEST.X2]
    /// </summary>
    public bool? HazardInsuranceEscrowed { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Request Hazard Ins Replacement Value [REQUEST.X1]
    /// </summary>
    public string? HazardReplacementValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Maximum Deductible Flood Amount [REQUEST.X37]
    /// </summary>
    public decimal? MaximumDeductibleFloodAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Maximum Deductible Flood Percentage [REQUEST.X36]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaximumDeductibleFloodPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Maximum Deductible Hazard Amount [REQUEST.X35]
    /// </summary>
    public decimal? MaximumDeductibleHazardAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Maximum Deductible Hazard Percentage [REQUEST.X34]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MaximumDeductibleHazardPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Request Title Commit Attach Contract [REQUEST.X13]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Contract\"}")]
    public bool? TitleContract { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Request Title Commit Comments 1 [REQUEST.X18]
    /// </summary>
    public string? TitleDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Title Commit Comments 2 [REQUEST.X19]
    /// </summary>
    public string? TitleDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Title Commit Comments 3 [REQUEST.X20]
    /// </summary>
    public string? TitleDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Title Commit Attach Title Ins Req [REQUEST.X12]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Title Insurance Requirements\"}")]
    public bool? TitleInsRequirements { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Request Title Commit Mail Yes/No [REQUEST.X17]
    /// </summary>
    public bool? TitleMailAway { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Request Title Commit Attach Prior Title Policy [REQUEST.X11]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Prior Title Policy\"}")]
    public bool? TitlePriorTitlePolicy { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Request Title Commit Attach Survey [REQUEST.X15]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Survey\"}")]
    public bool? TitleSurvey { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Request Title Commit Policy Type [REQUEST.X16]
    /// </summary>
    public string? TitleTypeOfProperty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Request Title Commit Attach Warranty Deed [REQUEST.X14]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Warranty Deed\"}")]
    public bool? TitleWarrantyDeed { get => GetValue<bool?>(); set => SetValue(value); }
}