using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ServiceProviderContact
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class ServiceProviderContact : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Settlement Service Provider Address [SPNN03]
    /// </summary>
    public string? Address { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider City [SPNN04]
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider ContactName [SPNN14]
    /// </summary>
    public string? ContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Cost [SPNN11]
    /// </summary>
    public decimal? Cost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Email [SPNN15]
    /// </summary>
    public string? Email { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ServiceProviderContact EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fax [SPNN16]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Fax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Amount 1 [SPNN18]
    /// </summary>
    public decimal? FeeAmt1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Amount 10 [SPNN36]
    /// </summary>
    public decimal? FeeAmt10 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Amount 2 [SPNN20]
    /// </summary>
    public decimal? FeeAmt2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Amount 3 [SPNN22]
    /// </summary>
    public decimal? FeeAmt3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Amount 4 [SPNN24]
    /// </summary>
    public decimal? FeeAmt4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Amount 5 [SPNN26]
    /// </summary>
    public decimal? FeeAmt5 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Amount 6 [SPNN28]
    /// </summary>
    public decimal? FeeAmt6 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Amount 7 [SPNN30]
    /// </summary>
    public decimal? FeeAmt7 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Amount 8 [SPNN32]
    /// </summary>
    public decimal? FeeAmt8 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Amount 9 [SPNN34]
    /// </summary>
    public decimal? FeeAmt9 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Description 1 [SPNN17]
    /// </summary>
    public string? FeeDesc1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Description 10 [SPNN35]
    /// </summary>
    public string? FeeDesc10 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Description 2 [SPNN19]
    /// </summary>
    public string? FeeDesc2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Description 3 [SPNN21]
    /// </summary>
    public string? FeeDesc3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Description 4 [SPNN23]
    /// </summary>
    public string? FeeDesc4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Description 5 [SPNN25]
    /// </summary>
    public string? FeeDesc5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Description 6 [SPNN27]
    /// </summary>
    public string? FeeDesc6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Description 7 [SPNN29]
    /// </summary>
    public string? FeeDesc7 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Description 8 [SPNN31]
    /// </summary>
    public string? FeeDesc8 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fee Description 9 [SPNN33]
    /// </summary>
    public string? FeeDesc9 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ServiceProviderContact Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Line Item Number [SPNN09]
    /// </summary>
    public string? LineItemNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Phone [SPNN07]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Phone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Postal Code [SPNN06]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ServiceProviderContact ProviderIndex
    /// </summary>
    public int? ProviderIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Name [SPNN02]
    /// </summary>
    public string? ProviderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Relationship [SPNN08]
    /// </summary>
    public string? Relationship { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provided [SPNN01]
    /// </summary>
    public string? ServiceProvided { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ServiceProviderContact ServiceProviderId
    /// </summary>
    public string? ServiceProviderId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Service Type [SPNN10]
    /// </summary>
    public StringEnumValue<ServiceType> ServiceType { get => GetValue<StringEnumValue<ServiceType>>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Cannot Shop For [SPNN13]
    /// </summary>
    public bool? ShopFor { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider State [SPNN05]
    /// </summary>
    public StringEnumValue<State> State { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Web Url [SPNN12]
    /// </summary>
    public string? WebUrl { get => GetValue<string?>(); set => SetValue(value); }
}