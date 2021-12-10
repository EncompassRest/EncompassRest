namespace EncompassRest.Loans.v3;

/// <summary>
/// LocationCoordinates
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(Left) + "," + nameof(Top))]
public sealed partial class LocationCoordinates : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<int?>? _bottom;
    private DirtyValue<int?>? _left;
    private DirtyValue<int?>? _right;
    private DirtyValue<int?>? _top;

    /// <summary>
    /// LocationCoordinatesContract Bottom
    /// </summary>
    public int? Bottom { get => _bottom; set => SetField(ref _bottom, value); }

    /// <summary>
    /// LocationCoordinatesContract Left
    /// </summary>
    public int? Left { get => _left; set => SetField(ref _left, value); }

    /// <summary>
    /// LocationCoordinatesContract Right
    /// </summary>
    public int? Right { get => _right; set => SetField(ref _right, value); }

    /// <summary>
    /// LocationCoordinatesContract Top
    /// </summary>
    public int? Top { get => _top; set => SetField(ref _top, value); }
}