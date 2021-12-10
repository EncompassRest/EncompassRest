using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// UcdDetail
/// </summary>
public sealed partial class UcdDetail : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<StringEnumValue<FeeAccountType>>? _feeAccountType;
    private DirtyValue<decimal?>? _feeAmount;
    private DirtyValue<DateTime?>? _feeDateFrom;
    private DirtyValue<DateTime?>? _feeDateTo;
    private DirtyValue<string?>? _feeDesc;
    private DirtyValue<int?>? _feeIndex;
    private DirtyValue<StringEnumValue<PaidToOrBy>>? _feePaidBy;
    private DirtyValue<string?>? _feePaidTo;
    private DirtyValue<bool?>? _feePoc;
    private DirtyValue<int?>? _lineNumber;
    private DirtyValue<StringEnumValue<Section>>? _section;

    /// <summary>
    /// UcdDetailContract FeeAccountType
    /// </summary>
    public StringEnumValue<FeeAccountType> FeeAccountType { get => _feeAccountType; set => SetField(ref _feeAccountType, value); }

    /// <summary>
    /// UcdDetailContract FeeAmount
    /// </summary>
    public decimal? FeeAmount { get => _feeAmount; set => SetField(ref _feeAmount, value); }

    /// <summary>
    /// UcdDetailContract FeeDateFrom
    /// </summary>
    public DateTime? FeeDateFrom { get => _feeDateFrom; set => SetField(ref _feeDateFrom, value); }

    /// <summary>
    /// UcdDetailContract FeeDateTo
    /// </summary>
    public DateTime? FeeDateTo { get => _feeDateTo; set => SetField(ref _feeDateTo, value); }

    /// <summary>
    /// UcdDetailContract FeeDesc
    /// </summary>
    public string? FeeDesc { get => _feeDesc; set => SetField(ref _feeDesc, value); }

    /// <summary>
    /// UcdDetailContract FeeIndex
    /// </summary>
    public int? FeeIndex { get => _feeIndex; set => SetField(ref _feeIndex, value); }

    /// <summary>
    /// UcdDetailContract FeePaidBy
    /// </summary>
    public StringEnumValue<PaidToOrBy> FeePaidBy { get => _feePaidBy; set => SetField(ref _feePaidBy, value); }

    /// <summary>
    /// UcdDetailContract FeePaidTo
    /// </summary>
    public string? FeePaidTo { get => _feePaidTo; set => SetField(ref _feePaidTo, value); }

    /// <summary>
    /// UcdDetailContract FeePoc
    /// </summary>
    public bool? FeePoc { get => _feePoc; set => SetField(ref _feePoc, value); }

    /// <summary>
    /// UcdDetailContract LineNumber
    /// </summary>
    public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }

    /// <summary>
    /// UcdDetailContract Section
    /// </summary>
    public StringEnumValue<Section> Section { get => _section; set => SetField(ref _section, value); }
}