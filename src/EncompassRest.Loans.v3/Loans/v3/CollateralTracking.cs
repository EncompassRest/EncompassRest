using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// CollateralTracking
/// </summary>
public sealed partial class CollateralTracking : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// All Comments [CT.Comment.AllComments]
    /// </summary>
    public string? CtComAllComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Transaction Comment [CT.Comment.TransactionComment]
    /// </summary>
    public string? CtComTransactionComment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Book# [CT.DOT.InitialRequest.BookNumber]
    /// </summary>
    public string? CtDotInitBookNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Contact [CT.DOT.InitialRequest.Contact]
    /// </summary>
    public string? CtDotInitContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Days Outstanding [CT.DOT.InitialRequest.DaysOutstanding]
    /// </summary>
    public string? CtDotInitDaysOutstanding { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Doc# [CT.DOT.InitialRequest.DocumentNumber]
    /// </summary>
    public string? CtDotInitDocumentNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Email [CT.DOT.InitialRequest.Email]
    /// </summary>
    public string? CtDotInitEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Last Req [CT.DOT.InitialRequest.LastRequested]
    /// </summary>
    public string? CtDotInitLastRequested { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Next Follow-up Date [CT.DOT.InitialRequest.NextFollowupDate]
    /// </summary>
    public DateTime? CtDotInitNextFollowupDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Org [CT.DOT.InitialRequest.Organization]
    /// </summary>
    public string? CtDotInitOrganization { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Page# [CT.DOT.InitialRequest.PageNumber]
    /// </summary>
    public string? CtDotInitPageNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Phone [CT.DOT.InitialRequest.Phone]
    /// </summary>
    public string? CtDotInitPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Note or Purchase Date [CT.DOT.InitialRequest.PurchaseDate]
    /// </summary>
    public DateTime? CtDotInitPurchaseDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Received [CT.DOT.InitialRequest.Received]
    /// </summary>
    public string? CtDotInitReceived { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Req By [CT.DOT.InitialRequest.RequestedBy]
    /// </summary>
    public string? CtDotInitRequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Riders Received [CT.DOT.InitialRequest.RiderReceived]
    /// </summary>
    public string? CtDotInitRiderReceived { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Ret Req Contact [CT.DOT.ReturnRequest.Contact]
    /// </summary>
    public string? CtDotRetContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Ret Req Email [CT.DOT.ReturnRequest.Email]
    /// </summary>
    public string? CtDotRetEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Ret Req Last Req [CT.DOT.ReturnRequest.LastRequested]
    /// </summary>
    public DateTime? CtDotRetLastRequested { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Ret Req Next Follow-up Date [CT.DOT.ReturnRequest.NextFollowUpDate]
    /// </summary>
    public DateTime? CtDotRetNextFollowUpDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Ret Req Org [CT.DOT.ReturnRequest.Organization]
    /// </summary>
    public string? CtDotRetOrganization { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Ret Req Phone [CT.DOT.ReturnRequest.Phone]
    /// </summary>
    public string? CtDotRetPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Ret Req Received [CT.DOT.ReturnRequest.Received]
    /// </summary>
    public DateTime? CtDotRetReceived { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Ret Req Req By [CT.DOT.ReturnRequest.RequestedBy]
    /// </summary>
    public string? CtDotRetRequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Ship Address [CT.DOT.ShippingStatus.Address]
    /// </summary>
    public string? CtDotShipAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Ship Carrier [CT.DOT.ShippingStatus.Carrier]
    /// </summary>
    public string? CtDotShipCarrier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Ship Contact [CT.DOT.ShippingStatus.Contact]
    /// </summary>
    public string? CtDotShipContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Ship Email [CT.DOT.ShippingStatus.Email]
    /// </summary>
    public string? CtDotShipEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Ship Org [CT.DOT.ShippingStatus.Organization]
    /// </summary>
    public string? CtDotShipOrganization { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Ship Phone [CT.DOT.ShippingStatus.Phone]
    /// </summary>
    public string? CtDotShipPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Shipped By [CT.DOT.ShippingStatus.ShippedBy]
    /// </summary>
    public string? CtDotShipShippedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Shipped Date [CT.DOT.ShippingStatus.ShippingDate]
    /// </summary>
    public DateTime? CtDotShipShippingDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DOT Mort Ship Track# [CT.DOT.ShippingStatus.TrackingNumber]
    /// </summary>
    public string? CtDotShipTrackingNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Recipient Address(Investor Address) [CT.EN.ShippingStatus.Address]
    /// </summary>
    public string? CtEnShipAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// WHL or Doc Custodian Carrier(Fedex,UPS,USPS,etc) [CT.EN.ShippingStatus.Carrier]
    /// </summary>
    public string? CtEnShipCarrier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Recipient Contact(Investor Contact Name) [CT.EN.ShippingStatus.Contact]
    /// </summary>
    public string? CtEnShipContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Recipient Email(Investor Email Address) [CT.EN.ShippingStatus.Email]
    /// </summary>
    public string? CtEnShipEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Recipient Type(Investor Purchasing Loan) [CT.EN.ShippingStatus.Organization]
    /// </summary>
    public string? CtEnShipOrganization { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Recipient Phone(Investor Phone Number) [CT.EN.ShippingStatus.Phone]
    /// </summary>
    public string? CtEnShipPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Name of WHL or Doc Custodian [CT.EN.ShippingStatus.ShippedBy]
    /// </summary>
    public string? CtEnShipShippedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// WHL or Doc Custodian Ship Date [CT.EN.ShippingStatus.ShippingDate]
    /// </summary>
    public DateTime? CtEnShipShippingDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Carrier Tracking # [CT.EN.ShippingStatus.TrackingNumber]
    /// </summary>
    public string? CtEnShipTrackingNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Contact [CT.FTP.InitialRequest.Contact]
    /// </summary>
    public string? CtFtpInitContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Days Outstanding [CT.FTP.InitialRequest.DaysOutstanding]
    /// </summary>
    public string? CtFtpInitDaysOutstanding { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Email [CT.FTP.InitialRequest.Email]
    /// </summary>
    public string? CtFtpInitEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Last Req [CT.FTP.InitialRequest.LastRequested]
    /// </summary>
    public string? CtFtpInitLastRequested { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Next Follow-up Date [CT.FTP.InitialRequest.NextFollowupDate]
    /// </summary>
    public DateTime? CtFtpInitNextFollowupDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Org [CT.FTP.InitialRequest.Organization]
    /// </summary>
    public string? CtFtpInitOrganization { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Phone [CT.FTP.InitialRequest.Phone]
    /// </summary>
    public string? CtFtpInitPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Received [CT.FTP.InitialRequest.Received]
    /// </summary>
    public string? CtFtpInitReceived { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Req By [CT.FTP.InitialRequest.RequestedBy]
    /// </summary>
    public string? CtFtpInitRequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ret Req Contact [CT.FTP.ReturnRequest.Contact]
    /// </summary>
    public string? CtFtpRetContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ret Req Email [CT.FTP.ReturnRequest.Email]
    /// </summary>
    public string? CtFtpRetEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ret Req Last Req [CT.FTP.ReturnRequest.LastRequested]
    /// </summary>
    public DateTime? CtFtpRetLastRequested { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ret Req Next Follow-up Date [CT.FTP.ReturnRequest.NextFollowUpDate]
    /// </summary>
    public DateTime? CtFtpRetNextFollowUpDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ret Req Org [CT.FTP.ReturnRequest.Organization]
    /// </summary>
    public string? CtFtpRetOrganization { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ret Req Phone [CT.FTP.ReturnRequest.Phone]
    /// </summary>
    public string? CtFtpRetPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ret Req Received [CT.FTP.ReturnRequest.Received]
    /// </summary>
    public DateTime? CtFtpRetReceived { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ret Req Req By [CT.FTP.ReturnRequest.RequestedBy]
    /// </summary>
    public string? CtFtpRetRequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ship Address [CT.FTP.ShippingStatus.Address]
    /// </summary>
    public string? CtFtpShipAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ship Carrier [CT.FTP.ShippingStatus.Carrier]
    /// </summary>
    public string? CtFtpShipCarrier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ship Contact [CT.FTP.ShippingStatus.Contact]
    /// </summary>
    public string? CtFtpShipContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ship Email [CT.FTP.ShippingStatus.Email]
    /// </summary>
    public string? CtFtpShipEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ship Org [CT.FTP.ShippingStatus.Organization]
    /// </summary>
    public string? CtFtpShipOrganization { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ship Phone [CT.FTP.ShippingStatus.Phone]
    /// </summary>
    public string? CtFtpShipPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Shipped By [CT.FTP.ShippingStatus.ShippedBy]
    /// </summary>
    public string? CtFtpShipShippedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ship Date [CT.FTP.ShippingStatus.ShippingDate]
    /// </summary>
    public DateTime? CtFtpShipShippingDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FTP Ship Track# [CT.FTP.ShippingStatus.TrackingNumber]
    /// </summary>
    public string? CtFtpShipTrackingNumber { get => GetValue<string?>(); set => SetValue(value); }
}