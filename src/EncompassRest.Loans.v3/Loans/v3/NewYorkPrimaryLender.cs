using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// NewYorkPrimaryLender
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(NewYorkPrimaryLenderIndex))]
public sealed partial class NewYorkPrimaryLender : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// NewYorkPrimaryLender Address
    /// </summary>
    public string? Address { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NewYorkPrimaryLender City
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NewYorkPrimaryLender Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NewYorkPrimaryLender Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NewYorkPrimaryLender NewYorkPrimaryLenderIndex
    /// </summary>
    public int? NewYorkPrimaryLenderIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// NewYorkPrimaryLender PostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NewYorkPrimaryLender State
    /// </summary>
    public string? State { get => GetValue<string?>(); set => SetValue(value); }
}