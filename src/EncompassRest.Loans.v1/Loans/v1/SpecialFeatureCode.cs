using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// SpecialFeatureCode
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class SpecialFeatureCode : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Special Feature Code - Code [SFCNN01]
    /// </summary>
    public string? Code { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Special Feature Code - Comments [SFCNN03]
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Special Feature Code - Description [SFCNN02]
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SpecialFeatureCode EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// SpecialFeatureCode Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Special Feature Code - Source [SFCNN04]
    /// </summary>
    public StringEnumValue<SpecialFeatureCodeSource> Source { get => GetValue<StringEnumValue<SpecialFeatureCodeSource>>(); set => SetValue(value); }

    /// <summary>
    /// Special Feature Code - Source Other [SFCNN05]
    /// </summary>
    public string? SourceOther { get => GetValue<string?>(); set => SetValue(value); }
}