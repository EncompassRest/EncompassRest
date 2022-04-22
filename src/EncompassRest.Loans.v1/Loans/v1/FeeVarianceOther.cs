using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// FeeVarianceOther
/// </summary>
public sealed partial class FeeVarianceOther : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Tolerance Cure Applied Cure Amount [FV.X366]
    /// </summary>
    public decimal? AppliedCureAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Decrease - CD Baseline Guid [FV.X361]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotDecreaseCDBaselineGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Decrease - LE Baseline Guid [FV.X360]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotDecreaseLEBaselineGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Increase 10 - CD Baseline Guid [FV.X365]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotIncrease10CDBaselineGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Increase 10 - LE Baseline Guid [FV.X364]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotIncrease10LEBaselineGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Increase - CD Baseline Guid [FV.X363]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotIncreaseCDBaselineGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Increase - LE Baseline Guid [FV.X362]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotIncreaseLEBaselineGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Initial Disclosure Tracking Guid [FV.X398]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdInitialDtGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Initial Guid [FV.X358]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CDInitialGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Initial Received Date Disclosure Tracking Guid [FV.X394]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CDInitialReceivedDateGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Latest Guid [FV.X359]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CDLatestGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Post Consummation GUID [FV.X367]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CDPostConGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Post Consummation Disclosure Tracking Guid [FV.X400]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdPostConsummationDtGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Recent Applied Cure Reason [FV.X386]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CDRecentAppliedCure { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Revised Disclosure Tracking Guid [FV.X399]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdRevisedDtGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Revised Received Date Disclosure Tracking Guid [FV.X395]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CDRevisedReceivedDateGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Charges Cannot Increase 10 CD 1 [FV.X55]
    /// </summary>
    public DateTime? ChargesCannotIncrease10CD1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges Cannot Increase 10 Initial LE 1 [FV.X53]
    /// </summary>
    public DateTime? ChargesCannotIncrease10InitialLE1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges Cannot Increase 10 LE 1 [FV.X54]
    /// </summary>
    public DateTime? ChargesCannotIncrease10LE1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges that Can Change CD 1 [FV.X216]
    /// </summary>
    public DateTime? ChargesThatCanChangeCD1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges that Can Change Initial LE 1 [FV.X214]
    /// </summary>
    public DateTime? ChargesThatCanChangeInitialLE1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges that Can Change LE 1 [FV.X215]
    /// </summary>
    public DateTime? ChargesThatCanChangeLE1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges That Cannot Decrease CD 1 [FV.X3]
    /// </summary>
    public DateTime? ChargesThatCannotDecreaseCD1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges That Cannot Decrease Initial LE 1 [FV.X1]
    /// </summary>
    public DateTime? ChargesThatCannotDecreaseInitialLE1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges That Cannot Decrease LE 1 [FV.X2]
    /// </summary>
    public DateTime? ChargesThatCannotDecreaseLE1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges That Cannot Increase CD 1 [FV.X29]
    /// </summary>
    public DateTime? ChargesThatCannotIncreaseCD1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges That Cannot Increase Initial LE 1 [FV.X27]
    /// </summary>
    public DateTime? ChargesThatCannotIncreaseInitialLE1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges That Cannot Increase LE 1 [FV.X28]
    /// </summary>
    public DateTime? ChargesThatCannotIncreaseLE1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Cure Applied to Lender Credit [FV.X396]
    /// </summary>
    public decimal? CureAppliedToLenderCredit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cure Applied to Principal Reduction (POC) [FV.X397]
    /// </summary>
    public decimal? CureAppliedToPrincipalReduction { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Log GUID used For ECD calculation [FV.X387]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosureLogGUIDForECD { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Log GUID CD Revised Received used For ECD calculation [FV.X389]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosureLogGUIDReceivedForECD { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Amount Initial LE 1 [FV.X324]
    /// </summary>
    public DateTime? GoodFaithAmountInitialLE1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FeeVarianceOther Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Decrease - LE Baseline Used [FV.X374]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? LEBaselineUsedCannotDecrease { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Increase - LE Baseline Used [FV.X375]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? LEBaselineUsedCannotIncrease { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Increase 10 - LE Baseline Used [FV.X376]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? LEBaselineUsedCannotIncrease10 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LE Initial Disclosure Tracking Guid [FV.X385]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LEInitialDTGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE Initial Guid [FV.X356]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LEInitialGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE Initial Received Date Disclosure Tracking Guid [FV.X392]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LEInitialReceivedDateGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE Latest Guid [FV.X357]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LELatestGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE Revised Received Date Disclosure Tracking Guid [FV.X393]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LERevisedReceivedDateGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE Revised Sent Date Disclosure Tracking Guid [FV.X391]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LERevisedSentDateGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Tolerance Cure Required Cure Amount [FV.X348]
    /// </summary>
    public decimal? RequiredCureAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Safe Harbor GUID [FV.X368]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SafeHarborGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Services Provider List GUID [FV.X369]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SSPLGuid { get => GetValue<string?>(); set => SetValue(value); }
}