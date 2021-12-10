using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// SpecialFeatureCode
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class SpecialFeatureCode : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _code;
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _description;
    private DirtyValue<string?>? _id;
    private DirtyValue<StringEnumValue<SpecialFeatureCodeSource>>? _source;
    private DirtyValue<string?>? _sourceOther;

    /// <summary>
    /// Special Feature Code - Code [SFC0001]
    /// </summary>
    public string? Code { get => _code; set => SetField(ref _code, value); }

    /// <summary>
    /// Special Feature Code - Comments [SFC0003]
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// Special Feature Code - Description [SFC0002]
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// SpecialFeatureCodeContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Special Feature Code - Source [SFC0004]
    /// </summary>
    public StringEnumValue<SpecialFeatureCodeSource> Source { get => _source; set => SetField(ref _source, value); }

    /// <summary>
    /// Special Feature Code - Source Other [SFC0005]
    /// </summary>
    public string? SourceOther { get => _sourceOther; set => SetField(ref _sourceOther, value); }
}