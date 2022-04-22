using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Shipping
/// </summary>
public sealed partial class Shipping : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Shipping Actual Shipping Date [2014]
    /// </summary>
    public DateTime? ActualShipDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Shipping Carrier Name [2017]
    /// </summary>
    public string? CarrierName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Shipping DownPaymentAmount
    /// </summary>
    public decimal? DownPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Shipping Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Investor Code [4664]
    /// </summary>
    public string? InvestorCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Investor Connect Delivered To Category [INVESTORCONN.X4]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? InvestorConnectDeliveredToCategory { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Investor Connect Delivered To Company [INVESTORCONN.X3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? InvestorConnectDeliveredToCompany { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Investor Connect Delivery Status [INVESTORCONN.X1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? InvestorConnectDeliveryStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Investor Connect Delivery Status Date Time [INVESTORCONN.X2]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, ReadOnly = true)]
    public DateTime? InvestorConnectDeliveryStatusDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Shipping Investor Delivery Date [2012]
    /// </summary>
    public DateTime? InvestorDeliveryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Location Code [4663]
    /// </summary>
    public string? LocationCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Shipping Pkg Tracking Number [2018]
    /// </summary>
    public string? PackageTrackingNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Shipping File Storage Comments [2022]
    /// </summary>
    public string? PhysicalFileStorageComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Shipping File Storage ID [2021]
    /// </summary>
    public string? PhysicalFileStorageId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Shipping File Storage Location [2020]
    /// </summary>
    public string? PhysicalFileStorageLocation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Shipping Pool ID [4020]
    /// </summary>
    public string? PoolID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Shipping Pool Number [4021]
    /// </summary>
    public string? PoolNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Shipping Recording Number [2015]
    /// </summary>
    public string? RecordingNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Shipping Shipment Method [2016]
    /// </summary>
    public string? ShipmentMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Shipping Shipper Name [2019]
    /// </summary>
    public string? ShipperName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Shipping ShippingContacts
    /// </summary>
    [AllowNull]
    public IList<ShippingContact> ShippingContacts { get => GetList<ShippingContact>(); set => SetList(value); }

    /// <summary>
    /// Shipping Target Delivery Date [2013]
    /// </summary>
    public DateTime? TargetDeliveryDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}