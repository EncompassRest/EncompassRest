using System;

namespace EncompassRest.Loans.v3;

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
    public string? CannotDecreaseCdBaselineGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Decrease - LE Baseline Guid [FV.X360]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotDecreaseLeBaselineGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Increase 10 - CD Baseline Guid [FV.X365]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotIncrease10CdBaselineGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Increase 10 - LE Baseline Guid [FV.X364]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotIncrease10LeBaselineGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Increase - CD Baseline Guid [FV.X363]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotIncreaseCdBaselineGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Increase - LE Baseline Guid [FV.X362]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotIncreaseLeBaselineGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Initial Disclosure Tracking Guid [FV.X398]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdInitialDtGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Initial Guid [FV.X358]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdInitialGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Initial Received Date Disclosure Tracking Guid [FV.X394]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdInitialReceivedDateGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Latest Guid [FV.X359]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdLatestGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Post Consummation GUID [FV.X367]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdPostConGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Post Consummation Disclosure Tracking Guid [FV.X400]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdPostConsummationDtGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Recent Applied Cure Reason [FV.X386]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdRecentAppliedCure { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Revised Disclosure Tracking Guid [FV.X399]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdRevisedDtGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD Revised Received Date Disclosure Tracking Guid [FV.X395]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdRevisedReceivedDateGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Charges Cannot Increase 10 CD 1 [FV.X55]
    /// </summary>
    public DateTime? ChargesCannotIncrease10Cd1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges Cannot Increase 10 Initial LE 1 [FV.X53]
    /// </summary>
    public DateTime? ChargesCannotIncrease10InitialLe1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges Cannot Increase 10 LE 1 [FV.X54]
    /// </summary>
    public DateTime? ChargesCannotIncrease10Le1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges that Can Change CD 1 [FV.X216]
    /// </summary>
    public DateTime? ChargesThatCanChangeCd1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges that Can Change Initial LE 1 [FV.X214]
    /// </summary>
    public DateTime? ChargesThatCanChangeInitialLe1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges that Can Change LE 1 [FV.X215]
    /// </summary>
    public DateTime? ChargesThatCanChangeLe1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges That Cannot Decrease CD 1 [FV.X3]
    /// </summary>
    public DateTime? ChargesThatCannotDecreaseCd1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges That Cannot Decrease Initial LE 1 [FV.X1]
    /// </summary>
    public DateTime? ChargesThatCannotDecreaseInitialLe1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges That Cannot Decrease LE 1 [FV.X2]
    /// </summary>
    public DateTime? ChargesThatCannotDecreaseLe1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges That Cannot Increase CD 1 [FV.X29]
    /// </summary>
    public DateTime? ChargesThatCannotIncreaseCd1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges That Cannot Increase Initial LE 1 [FV.X27]
    /// </summary>
    public DateTime? ChargesThatCannotIncreaseInitialLe1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Charges That Cannot Increase LE 1 [FV.X28]
    /// </summary>
    public DateTime? ChargesThatCannotIncreaseLe1 { get => GetValue<DateTime?>(); set => SetValue(value); }

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
    public string? DisclosureLogGuidForEcd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Log GUID CD Revised Received used For ECD calculation [FV.X389]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosureLogGuidReceivedForEcd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Amount Initial LE 1 [FV.X324]
    /// </summary>
    public DateTime? GoodFaithAmountInitialLe1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Decrease - LE Baseline Used [FV.X374]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? LeBaselineUsedCannotDecrease { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Increase - LE Baseline Used [FV.X375]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? LeBaselineUsedCannotIncrease { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Cannot Increase 10 - LE Baseline Used [FV.X376]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? LeBaselineUsedCannotIncrease10 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LE Initial Disclosure Tracking Guid [FV.X385]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LeInitialDtGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE Initial Guid [FV.X356]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LeInitialGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE Initial Received Date Disclosure Tracking Guid [FV.X392]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LeInitialReceivedDateGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE Latest Guid [FV.X357]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LeLatestGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE Revised Received Date Disclosure Tracking Guid [FV.X393]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LeRevisedReceivedDateGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE Revised Sent Date Disclosure Tracking Guid [FV.X391]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LeRevisedSentDateGuid { get => GetValue<string?>(); set => SetValue(value); }

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
    public string? SsplGuid { get => GetValue<string?>(); set => SetValue(value); }
}