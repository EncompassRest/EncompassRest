using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// FeeVarianceOther
/// </summary>
public sealed partial class FeeVarianceOther : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _appliedCureAmount;
    private DirtyValue<string?>? _cannotDecreaseCdBaselineGuid;
    private DirtyValue<string?>? _cannotDecreaseLeBaselineGuid;
    private DirtyValue<string?>? _cannotIncrease10CdBaselineGuid;
    private DirtyValue<string?>? _cannotIncrease10LeBaselineGuid;
    private DirtyValue<string?>? _cannotIncreaseCdBaselineGuid;
    private DirtyValue<string?>? _cannotIncreaseLeBaselineGuid;
    private DirtyValue<string?>? _cdInitialDtGuid;
    private DirtyValue<string?>? _cdInitialGuid;
    private DirtyValue<string?>? _cdInitialReceivedDateGuid;
    private DirtyValue<string?>? _cdLatestGuid;
    private DirtyValue<string?>? _cdPostConGuid;
    private DirtyValue<string?>? _cdPostConsummationDtGuid;
    private DirtyValue<string?>? _cdRecentAppliedCure;
    private DirtyValue<string?>? _cdRevisedDtGuid;
    private DirtyValue<string?>? _cdRevisedReceivedDateGuid;
    private DirtyValue<DateTime?>? _chargesCannotIncrease10Cd1;
    private DirtyValue<DateTime?>? _chargesCannotIncrease10InitialLe1;
    private DirtyValue<DateTime?>? _chargesCannotIncrease10Le1;
    private DirtyValue<DateTime?>? _chargesThatCanChangeCd1;
    private DirtyValue<DateTime?>? _chargesThatCanChangeInitialLe1;
    private DirtyValue<DateTime?>? _chargesThatCanChangeLe1;
    private DirtyValue<DateTime?>? _chargesThatCannotDecreaseCd1;
    private DirtyValue<DateTime?>? _chargesThatCannotDecreaseInitialLe1;
    private DirtyValue<DateTime?>? _chargesThatCannotDecreaseLe1;
    private DirtyValue<DateTime?>? _chargesThatCannotIncreaseCd1;
    private DirtyValue<DateTime?>? _chargesThatCannotIncreaseInitialLe1;
    private DirtyValue<DateTime?>? _chargesThatCannotIncreaseLe1;
    private DirtyValue<decimal?>? _cureAppliedToLenderCredit;
    private DirtyValue<decimal?>? _cureAppliedToPrincipalReduction;
    private DirtyValue<string?>? _disclosureLogGuidForEcd;
    private DirtyValue<string?>? _disclosureLogGuidReceivedForEcd;
    private DirtyValue<DateTime?>? _goodFaithAmountInitialLe1;
    private DirtyValue<bool?>? _leBaselineUsedCannotDecrease;
    private DirtyValue<bool?>? _leBaselineUsedCannotIncrease;
    private DirtyValue<bool?>? _leBaselineUsedCannotIncrease10;
    private DirtyValue<string?>? _leInitialDtGuid;
    private DirtyValue<string?>? _leInitialGuid;
    private DirtyValue<string?>? _leInitialReceivedDateGuid;
    private DirtyValue<string?>? _leLatestGuid;
    private DirtyValue<string?>? _leRevisedReceivedDateGuid;
    private DirtyValue<string?>? _leRevisedSentDateGuid;
    private DirtyValue<decimal?>? _requiredCureAmount;
    private DirtyValue<string?>? _safeHarborGuid;
    private DirtyValue<string?>? _ssplGuid;

    /// <summary>
    /// Tolerance Cure Applied Cure Amount [FV.X366]
    /// </summary>
    public decimal? AppliedCureAmount { get => _appliedCureAmount; set => SetField(ref _appliedCureAmount, value); }

    /// <summary>
    /// Cannot Decrease - CD Baseline Guid [FV.X361]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotDecreaseCdBaselineGuid { get => _cannotDecreaseCdBaselineGuid; set => SetField(ref _cannotDecreaseCdBaselineGuid, value); }

    /// <summary>
    /// Cannot Decrease - LE Baseline Guid [FV.X360]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotDecreaseLeBaselineGuid { get => _cannotDecreaseLeBaselineGuid; set => SetField(ref _cannotDecreaseLeBaselineGuid, value); }

    /// <summary>
    /// Cannot Increase 10 - CD Baseline Guid [FV.X365]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotIncrease10CdBaselineGuid { get => _cannotIncrease10CdBaselineGuid; set => SetField(ref _cannotIncrease10CdBaselineGuid, value); }

    /// <summary>
    /// Cannot Increase 10 - LE Baseline Guid [FV.X364]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotIncrease10LeBaselineGuid { get => _cannotIncrease10LeBaselineGuid; set => SetField(ref _cannotIncrease10LeBaselineGuid, value); }

    /// <summary>
    /// Cannot Increase - CD Baseline Guid [FV.X363]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotIncreaseCdBaselineGuid { get => _cannotIncreaseCdBaselineGuid; set => SetField(ref _cannotIncreaseCdBaselineGuid, value); }

    /// <summary>
    /// Cannot Increase - LE Baseline Guid [FV.X362]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CannotIncreaseLeBaselineGuid { get => _cannotIncreaseLeBaselineGuid; set => SetField(ref _cannotIncreaseLeBaselineGuid, value); }

    /// <summary>
    /// CD Initial Disclosure Tracking Guid [FV.X398]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdInitialDtGuid { get => _cdInitialDtGuid; set => SetField(ref _cdInitialDtGuid, value); }

    /// <summary>
    /// CD Initial Guid [FV.X358]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdInitialGuid { get => _cdInitialGuid; set => SetField(ref _cdInitialGuid, value); }

    /// <summary>
    /// CD Initial Received Date Disclosure Tracking Guid [FV.X394]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdInitialReceivedDateGuid { get => _cdInitialReceivedDateGuid; set => SetField(ref _cdInitialReceivedDateGuid, value); }

    /// <summary>
    /// CD Latest Guid [FV.X359]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdLatestGuid { get => _cdLatestGuid; set => SetField(ref _cdLatestGuid, value); }

    /// <summary>
    /// CD Post Consummation GUID [FV.X367]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdPostConGuid { get => _cdPostConGuid; set => SetField(ref _cdPostConGuid, value); }

    /// <summary>
    /// Post Consummation Disclosure Tracking Guid [FV.X400]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdPostConsummationDtGuid { get => _cdPostConsummationDtGuid; set => SetField(ref _cdPostConsummationDtGuid, value); }

    /// <summary>
    /// CD Recent Applied Cure Reason [FV.X386]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdRecentAppliedCure { get => _cdRecentAppliedCure; set => SetField(ref _cdRecentAppliedCure, value); }

    /// <summary>
    /// CD Revised Disclosure Tracking Guid [FV.X399]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdRevisedDtGuid { get => _cdRevisedDtGuid; set => SetField(ref _cdRevisedDtGuid, value); }

    /// <summary>
    /// CD Revised Received Date Disclosure Tracking Guid [FV.X395]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CdRevisedReceivedDateGuid { get => _cdRevisedReceivedDateGuid; set => SetField(ref _cdRevisedReceivedDateGuid, value); }

    /// <summary>
    /// Charges Cannot Increase 10 CD 1 [FV.X55]
    /// </summary>
    public DateTime? ChargesCannotIncrease10Cd1 { get => _chargesCannotIncrease10Cd1; set => SetField(ref _chargesCannotIncrease10Cd1, value); }

    /// <summary>
    /// Charges Cannot Increase 10 Initial LE 1 [FV.X53]
    /// </summary>
    public DateTime? ChargesCannotIncrease10InitialLe1 { get => _chargesCannotIncrease10InitialLe1; set => SetField(ref _chargesCannotIncrease10InitialLe1, value); }

    /// <summary>
    /// Charges Cannot Increase 10 LE 1 [FV.X54]
    /// </summary>
    public DateTime? ChargesCannotIncrease10Le1 { get => _chargesCannotIncrease10Le1; set => SetField(ref _chargesCannotIncrease10Le1, value); }

    /// <summary>
    /// Charges that Can Change CD 1 [FV.X216]
    /// </summary>
    public DateTime? ChargesThatCanChangeCd1 { get => _chargesThatCanChangeCd1; set => SetField(ref _chargesThatCanChangeCd1, value); }

    /// <summary>
    /// Charges that Can Change Initial LE 1 [FV.X214]
    /// </summary>
    public DateTime? ChargesThatCanChangeInitialLe1 { get => _chargesThatCanChangeInitialLe1; set => SetField(ref _chargesThatCanChangeInitialLe1, value); }

    /// <summary>
    /// Charges that Can Change LE 1 [FV.X215]
    /// </summary>
    public DateTime? ChargesThatCanChangeLe1 { get => _chargesThatCanChangeLe1; set => SetField(ref _chargesThatCanChangeLe1, value); }

    /// <summary>
    /// Charges That Cannot Decrease CD 1 [FV.X3]
    /// </summary>
    public DateTime? ChargesThatCannotDecreaseCd1 { get => _chargesThatCannotDecreaseCd1; set => SetField(ref _chargesThatCannotDecreaseCd1, value); }

    /// <summary>
    /// Charges That Cannot Decrease Initial LE 1 [FV.X1]
    /// </summary>
    public DateTime? ChargesThatCannotDecreaseInitialLe1 { get => _chargesThatCannotDecreaseInitialLe1; set => SetField(ref _chargesThatCannotDecreaseInitialLe1, value); }

    /// <summary>
    /// Charges That Cannot Decrease LE 1 [FV.X2]
    /// </summary>
    public DateTime? ChargesThatCannotDecreaseLe1 { get => _chargesThatCannotDecreaseLe1; set => SetField(ref _chargesThatCannotDecreaseLe1, value); }

    /// <summary>
    /// Charges That Cannot Increase CD 1 [FV.X29]
    /// </summary>
    public DateTime? ChargesThatCannotIncreaseCd1 { get => _chargesThatCannotIncreaseCd1; set => SetField(ref _chargesThatCannotIncreaseCd1, value); }

    /// <summary>
    /// Charges That Cannot Increase Initial LE 1 [FV.X27]
    /// </summary>
    public DateTime? ChargesThatCannotIncreaseInitialLe1 { get => _chargesThatCannotIncreaseInitialLe1; set => SetField(ref _chargesThatCannotIncreaseInitialLe1, value); }

    /// <summary>
    /// Charges That Cannot Increase LE 1 [FV.X28]
    /// </summary>
    public DateTime? ChargesThatCannotIncreaseLe1 { get => _chargesThatCannotIncreaseLe1; set => SetField(ref _chargesThatCannotIncreaseLe1, value); }

    /// <summary>
    /// Cure Applied to Lender Credit [FV.X396]
    /// </summary>
    public decimal? CureAppliedToLenderCredit { get => _cureAppliedToLenderCredit; set => SetField(ref _cureAppliedToLenderCredit, value); }

    /// <summary>
    /// Cure Applied to Principal Reduction (POC) [FV.X397]
    /// </summary>
    public decimal? CureAppliedToPrincipalReduction { get => _cureAppliedToPrincipalReduction; set => SetField(ref _cureAppliedToPrincipalReduction, value); }

    /// <summary>
    /// Disclosure Log GUID used For ECD calculation [FV.X387]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosureLogGuidForEcd { get => _disclosureLogGuidForEcd; set => SetField(ref _disclosureLogGuidForEcd, value); }

    /// <summary>
    /// Disclosure Log GUID CD Revised Received used For ECD calculation [FV.X389]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosureLogGuidReceivedForEcd { get => _disclosureLogGuidReceivedForEcd; set => SetField(ref _disclosureLogGuidReceivedForEcd, value); }

    /// <summary>
    /// Good Faith Amount Initial LE 1 [FV.X324]
    /// </summary>
    public DateTime? GoodFaithAmountInitialLe1 { get => _goodFaithAmountInitialLe1; set => SetField(ref _goodFaithAmountInitialLe1, value); }

    /// <summary>
    /// Cannot Decrease - LE Baseline Used [FV.X374]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? LeBaselineUsedCannotDecrease { get => _leBaselineUsedCannotDecrease; set => SetField(ref _leBaselineUsedCannotDecrease, value); }

    /// <summary>
    /// Cannot Increase - LE Baseline Used [FV.X375]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? LeBaselineUsedCannotIncrease { get => _leBaselineUsedCannotIncrease; set => SetField(ref _leBaselineUsedCannotIncrease, value); }

    /// <summary>
    /// Cannot Increase 10 - LE Baseline Used [FV.X376]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? LeBaselineUsedCannotIncrease10 { get => _leBaselineUsedCannotIncrease10; set => SetField(ref _leBaselineUsedCannotIncrease10, value); }

    /// <summary>
    /// LE Initial Disclosure Tracking Guid [FV.X385]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LeInitialDtGuid { get => _leInitialDtGuid; set => SetField(ref _leInitialDtGuid, value); }

    /// <summary>
    /// LE Initial Guid [FV.X356]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LeInitialGuid { get => _leInitialGuid; set => SetField(ref _leInitialGuid, value); }

    /// <summary>
    /// LE Initial Received Date Disclosure Tracking Guid [FV.X392]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LeInitialReceivedDateGuid { get => _leInitialReceivedDateGuid; set => SetField(ref _leInitialReceivedDateGuid, value); }

    /// <summary>
    /// LE Latest Guid [FV.X357]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LeLatestGuid { get => _leLatestGuid; set => SetField(ref _leLatestGuid, value); }

    /// <summary>
    /// LE Revised Received Date Disclosure Tracking Guid [FV.X393]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LeRevisedReceivedDateGuid { get => _leRevisedReceivedDateGuid; set => SetField(ref _leRevisedReceivedDateGuid, value); }

    /// <summary>
    /// LE Revised Sent Date Disclosure Tracking Guid [FV.X391]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LeRevisedSentDateGuid { get => _leRevisedSentDateGuid; set => SetField(ref _leRevisedSentDateGuid, value); }

    /// <summary>
    /// Tolerance Cure Required Cure Amount [FV.X348]
    /// </summary>
    public decimal? RequiredCureAmount { get => _requiredCureAmount; set => SetField(ref _requiredCureAmount, value); }

    /// <summary>
    /// Safe Harbor GUID [FV.X368]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SafeHarborGuid { get => _safeHarborGuid; set => SetField(ref _safeHarborGuid, value); }

    /// <summary>
    /// Settlement Services Provider List GUID [FV.X369]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SsplGuid { get => _ssplGuid; set => SetField(ref _ssplGuid, value); }
}