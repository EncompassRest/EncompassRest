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
    private DirtyValue<string?>? _address;
    private DirtyValue<string?>? _altId;
    private DirtyValue<string?>? _category;
    private DirtyValue<string?>? _city;
    private DirtyValue<string?>? _contactName;
    private DirtyValue<decimal?>? _cost;
    private DirtyValue<string?>? _email;
    private DirtyValue<string?>? _fax;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _lineItemNumber;
    private DirtyValue<string?>? _phone;
    private DirtyValue<string?>? _postalCode;
    private DirtyValue<string?>? _providerName;
    private DirtyValue<string?>? _relationship;
    private DirtyList<ServiceProviderContactFee>? _serviceProviderContactFees;
    private DirtyValue<StringEnumValue<ServiceType>>? _serviceType;
    private DirtyValue<bool?>? _shopFor;
    private DirtyValue<string?>? _state;
    private DirtyValue<string?>? _webUrl;

    /// <summary>
    /// Settlement Service Provider Address [SP0003]
    /// </summary>
    public string? Address { get => _address; set => SetField(ref _address, value); }

    /// <summary>
    /// ServiceProviderContactContract AltId
    /// </summary>
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// Settlement Service Provided [SP0001]
    /// </summary>
    public string? Category { get => _category; set => SetField(ref _category, value); }

    /// <summary>
    /// Settlement Service Provider City [SP0004]
    /// </summary>
    public string? City { get => _city; set => SetField(ref _city, value); }

    /// <summary>
    /// Settlement Service Provider ContactName [SP0014]
    /// </summary>
    public string? ContactName { get => _contactName; set => SetField(ref _contactName, value); }

    /// <summary>
    /// Settlement Service Provider Cost [SP0011]
    /// </summary>
    public decimal? Cost { get => _cost; set => SetField(ref _cost, value); }

    /// <summary>
    /// Settlement Service Provider Email [SP0015]
    /// </summary>
    public string? Email { get => _email; set => SetField(ref _email, value); }

    /// <summary>
    /// Settlement Service Provider Fax [SP0016]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Fax { get => _fax; set => SetField(ref _fax, value); }

    /// <summary>
    /// ServiceProviderContactContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Settlement Service Provider Line Item Number [SP0009]
    /// </summary>
    public string? LineItemNumber { get => _lineItemNumber; set => SetField(ref _lineItemNumber, value); }

    /// <summary>
    /// Settlement Service Provider Phone [SP0007]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? Phone { get => _phone; set => SetField(ref _phone, value); }

    /// <summary>
    /// Settlement Service Provider Postal Code [SP0006]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

    /// <summary>
    /// Settlement Service Provider Name [SP0002]
    /// </summary>
    public string? ProviderName { get => _providerName; set => SetField(ref _providerName, value); }

    /// <summary>
    /// Settlement Service Provider Relationship [SP0008]
    /// </summary>
    public string? Relationship { get => _relationship; set => SetField(ref _relationship, value); }

    /// <summary>
    /// ServiceProviderContactContract ServiceProviderContactFees
    /// </summary>
    [AllowNull]
    public IList<ServiceProviderContactFee> ServiceProviderContactFees { get => GetField(ref _serviceProviderContactFees); set => SetField(ref _serviceProviderContactFees, value); }

    /// <summary>
    /// Settlement Service Provider Service Type [SP0010]
    /// </summary>
    public StringEnumValue<ServiceType> ServiceType { get => _serviceType; set => SetField(ref _serviceType, value); }

    /// <summary>
    /// Settlement Service Provider Cannot Shop For [SP0013]
    /// </summary>
    public bool? ShopFor { get => _shopFor; set => SetField(ref _shopFor, value); }

    /// <summary>
    /// Settlement Service Provider State [SP0005]
    /// </summary>
    public string? State { get => _state; set => SetField(ref _state, value); }

    /// <summary>
    /// Settlement Service Provider Web Url [SP0012]
    /// </summary>
    public string? WebUrl { get => _webUrl; set => SetField(ref _webUrl, value); }
}