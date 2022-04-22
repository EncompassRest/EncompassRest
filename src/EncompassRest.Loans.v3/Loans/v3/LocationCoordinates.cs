namespace EncompassRest.Loans.v3;

/// <summary>
/// LocationCoordinates
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(Left) + "," + nameof(Top))]
public sealed partial class LocationCoordinates : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LocationCoordinates Bottom
    /// </summary>
    public int? Bottom { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LocationCoordinates Left
    /// </summary>
    public int? Left { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LocationCoordinates Right
    /// </summary>
    public int? Right { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LocationCoordinates Top
    /// </summary>
    public int? Top { get => GetValue<int?>(); set => SetValue(value); }
}