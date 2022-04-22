using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ServiceProviderContact
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class ServiceProviderContact : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Settlement Service Provider Address [SP0003]
    /// </summary>
    public string? Address { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ServiceProviderContact AltId
    /// </summary>
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provided [SP0001]
    /// </summary>
    public string? Category { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider City [SP0004]
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider ContactName [SP0014]
    /// </summary>
    public string? ContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Cost [SP0011]
    /// </summary>
    public decimal? Cost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Email [SP0015]
    /// </summary>
    public string? Email { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Fax [SP0016]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Fax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ServiceProviderContact Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Line Item Number [SP0009]
    /// </summary>
    public string? LineItemNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Phone [SP0007]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Phone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Postal Code [SP0006]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Name [SP0002]
    /// </summary>
    public string? ProviderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Relationship [SP0008]
    /// </summary>
    public string? Relationship { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ServiceProviderContact ServiceProviderContactFees
    /// </summary>
    [AllowNull]
    public IList<ServiceProviderContactFee> ServiceProviderContactFees { get => GetList<ServiceProviderContactFee>(); set => SetList(value); }

    /// <summary>
    /// Settlement Service Provider Service Type [SP0010]
    /// </summary>
    public StringEnumValue<ServiceType> ServiceType { get => GetValue<StringEnumValue<ServiceType>>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Cannot Shop For [SP0013]
    /// </summary>
    public bool? ShopFor { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider State [SP0005]
    /// </summary>
    public string? State { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Service Provider Web Url [SP0012]
    /// </summary>
    public string? WebUrl { get => GetValue<string?>(); set => SetValue(value); }
}