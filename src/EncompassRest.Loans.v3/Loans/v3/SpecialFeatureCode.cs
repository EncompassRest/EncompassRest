using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// SpecialFeatureCode
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class SpecialFeatureCode : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Special Feature Code - Code [SFC0001]
    /// </summary>
    public string? Code { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Special Feature Code - Comments [SFC0003]
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Special Feature Code - Description [SFC0002]
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SpecialFeatureCode Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Special Feature Code - Source [SFC0004]
    /// </summary>
    public StringEnumValue<SpecialFeatureCodeSource> Source { get => GetValue<StringEnumValue<SpecialFeatureCodeSource>>(); set => SetValue(value); }

    /// <summary>
    /// Special Feature Code - Source Other [SFC0005]
    /// </summary>
    public string? SourceOther { get => GetValue<string?>(); set => SetValue(value); }
}