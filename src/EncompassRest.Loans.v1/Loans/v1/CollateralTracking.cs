using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// CollateralTracking
/// </summary>
public sealed partial class CollateralTracking : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _ctComAllComments;
    private DirtyValue<string?>? _ctComTransactionComment;
    private DirtyValue<string?>? _ctDotInitBookNumber;
    private DirtyValue<string?>? _ctDotInitContact;
    private DirtyValue<string?>? _ctDotInitDaysOutstanding;
    private DirtyValue<string?>? _ctDotInitDocumentNumber;
    private DirtyValue<string?>? _ctDotInitEmail;
    private DirtyValue<string?>? _ctDotInitLastRequested;
    private DirtyValue<DateTime?>? _ctDotInitNextFollowupDate;
    private DirtyValue<string?>? _ctDotInitOrganization;
    private DirtyValue<string?>? _ctDotInitPageNumber;
    private DirtyValue<string?>? _ctDotInitPhone;
    private DirtyValue<DateTime?>? _ctDotInitPurchaseDate;
    private DirtyValue<string?>? _ctDotInitReceived;
    private DirtyValue<string?>? _ctDotInitRequestedBy;
    private DirtyValue<string?>? _ctDotInitRiderReceived;
    private DirtyValue<string?>? _ctDotRetContact;
    private DirtyValue<string?>? _ctDotRetEmail;
    private DirtyValue<DateTime?>? _ctDotRetLastRequested;
    private DirtyValue<DateTime?>? _ctDotRetNextFollowUpDate;
    private DirtyValue<string?>? _ctDotRetOrganization;
    private DirtyValue<string?>? _ctDotRetPhone;
    private DirtyValue<DateTime?>? _ctDotRetReceived;
    private DirtyValue<string?>? _ctDotRetRequestedBy;
    private DirtyValue<string?>? _ctDotShipAddress;
    private DirtyValue<string?>? _ctDotShipCarrier;
    private DirtyValue<string?>? _ctDotShipContact;
    private DirtyValue<string?>? _ctDotShipEmail;
    private DirtyValue<string?>? _ctDotShipOrganization;
    private DirtyValue<string?>? _ctDotShipPhone;
    private DirtyValue<string?>? _ctDotShipShippedBy;
    private DirtyValue<DateTime?>? _ctDotShipShippingDate;
    private DirtyValue<string?>? _ctDotShipTrackingNumber;
    private DirtyValue<string?>? _ctEnShipAddress;
    private DirtyValue<string?>? _ctEnShipCarrier;
    private DirtyValue<string?>? _ctEnShipContact;
    private DirtyValue<string?>? _ctEnShipEmail;
    private DirtyValue<string?>? _ctEnShipOrganization;
    private DirtyValue<string?>? _ctEnShipPhone;
    private DirtyValue<string?>? _ctEnShipShippedBy;
    private DirtyValue<DateTime?>? _ctEnShipShippingDate;
    private DirtyValue<string?>? _ctEnShipTrackingNumber;
    private DirtyValue<string?>? _ctFtpInitContact;
    private DirtyValue<string?>? _ctFtpInitDaysOutstanding;
    private DirtyValue<string?>? _ctFtpInitEmail;
    private DirtyValue<string?>? _ctFtpInitLastRequested;
    private DirtyValue<DateTime?>? _ctFtpInitNextFollowupDate;
    private DirtyValue<string?>? _ctFtpInitOrganization;
    private DirtyValue<string?>? _ctFtpInitPhone;
    private DirtyValue<string?>? _ctFtpInitReceived;
    private DirtyValue<string?>? _ctFtpInitRequestedBy;
    private DirtyValue<string?>? _ctFtpRetContact;
    private DirtyValue<string?>? _ctFtpRetEmail;
    private DirtyValue<DateTime?>? _ctFtpRetLastRequested;
    private DirtyValue<DateTime?>? _ctFtpRetNextFollowUpDate;
    private DirtyValue<string?>? _ctFtpRetOrganization;
    private DirtyValue<string?>? _ctFtpRetPhone;
    private DirtyValue<DateTime?>? _ctFtpRetReceived;
    private DirtyValue<string?>? _ctFtpRetRequestedBy;
    private DirtyValue<string?>? _ctFtpShipAddress;
    private DirtyValue<string?>? _ctFtpShipCarrier;
    private DirtyValue<string?>? _ctFtpShipContact;
    private DirtyValue<string?>? _ctFtpShipEmail;
    private DirtyValue<string?>? _ctFtpShipOrganization;
    private DirtyValue<string?>? _ctFtpShipPhone;
    private DirtyValue<string?>? _ctFtpShipShippedBy;
    private DirtyValue<DateTime?>? _ctFtpShipShippingDate;
    private DirtyValue<string?>? _ctFtpShipTrackingNumber;
    private DirtyValue<string?>? _id;

    /// <summary>
    /// All Comments [CT.Comment.AllComments]
    /// </summary>
    public string? CtComAllComments { get => _ctComAllComments; set => SetField(ref _ctComAllComments, value); }

    /// <summary>
    /// Transaction Comment [CT.Comment.TransactionComment]
    /// </summary>
    public string? CtComTransactionComment { get => _ctComTransactionComment; set => SetField(ref _ctComTransactionComment, value); }

    /// <summary>
    /// DOT Mort Book# [CT.DOT.InitialRequest.BookNumber]
    /// </summary>
    public string? CtDotInitBookNumber { get => _ctDotInitBookNumber; set => SetField(ref _ctDotInitBookNumber, value); }

    /// <summary>
    /// DOT Mort Contact [CT.DOT.InitialRequest.Contact]
    /// </summary>
    public string? CtDotInitContact { get => _ctDotInitContact; set => SetField(ref _ctDotInitContact, value); }

    /// <summary>
    /// DOT Mort Days Outstanding [CT.DOT.InitialRequest.DaysOutstanding]
    /// </summary>
    public string? CtDotInitDaysOutstanding { get => _ctDotInitDaysOutstanding; set => SetField(ref _ctDotInitDaysOutstanding, value); }

    /// <summary>
    /// DOT Mort Doc# [CT.DOT.InitialRequest.DocumentNumber]
    /// </summary>
    public string? CtDotInitDocumentNumber { get => _ctDotInitDocumentNumber; set => SetField(ref _ctDotInitDocumentNumber, value); }

    /// <summary>
    /// DOT Mort Email [CT.DOT.InitialRequest.Email]
    /// </summary>
    public string? CtDotInitEmail { get => _ctDotInitEmail; set => SetField(ref _ctDotInitEmail, value); }

    /// <summary>
    /// DOT Mort Last Req [CT.DOT.InitialRequest.LastRequested]
    /// </summary>
    public string? CtDotInitLastRequested { get => _ctDotInitLastRequested; set => SetField(ref _ctDotInitLastRequested, value); }

    /// <summary>
    /// DOT Mort Next Follow-up Date [CT.DOT.InitialRequest.NextFollowupDate]
    /// </summary>
    public DateTime? CtDotInitNextFollowupDate { get => _ctDotInitNextFollowupDate; set => SetField(ref _ctDotInitNextFollowupDate, value); }

    /// <summary>
    /// DOT Mort Org [CT.DOT.InitialRequest.Organization]
    /// </summary>
    public string? CtDotInitOrganization { get => _ctDotInitOrganization; set => SetField(ref _ctDotInitOrganization, value); }

    /// <summary>
    /// DOT Mort Page# [CT.DOT.InitialRequest.PageNumber]
    /// </summary>
    public string? CtDotInitPageNumber { get => _ctDotInitPageNumber; set => SetField(ref _ctDotInitPageNumber, value); }

    /// <summary>
    /// DOT Mort Phone [CT.DOT.InitialRequest.Phone]
    /// </summary>
    public string? CtDotInitPhone { get => _ctDotInitPhone; set => SetField(ref _ctDotInitPhone, value); }

    /// <summary>
    /// DOT Mort Note or Purchase Date [CT.DOT.InitialRequest.PurchaseDate]
    /// </summary>
    public DateTime? CtDotInitPurchaseDate { get => _ctDotInitPurchaseDate; set => SetField(ref _ctDotInitPurchaseDate, value); }

    /// <summary>
    /// DOT Mort Received [CT.DOT.InitialRequest.Received]
    /// </summary>
    public string? CtDotInitReceived { get => _ctDotInitReceived; set => SetField(ref _ctDotInitReceived, value); }

    /// <summary>
    /// DOT Mort Req By [CT.DOT.InitialRequest.RequestedBy]
    /// </summary>
    public string? CtDotInitRequestedBy { get => _ctDotInitRequestedBy; set => SetField(ref _ctDotInitRequestedBy, value); }

    /// <summary>
    /// DOT Mort Riders Received [CT.DOT.InitialRequest.RiderReceived]
    /// </summary>
    public string? CtDotInitRiderReceived { get => _ctDotInitRiderReceived; set => SetField(ref _ctDotInitRiderReceived, value); }

    /// <summary>
    /// DOT Mort Ret Req Contact [CT.DOT.ReturnRequest.Contact]
    /// </summary>
    public string? CtDotRetContact { get => _ctDotRetContact; set => SetField(ref _ctDotRetContact, value); }

    /// <summary>
    /// DOT Mort Ret Req Email [CT.DOT.ReturnRequest.Email]
    /// </summary>
    public string? CtDotRetEmail { get => _ctDotRetEmail; set => SetField(ref _ctDotRetEmail, value); }

    /// <summary>
    /// DOT Mort Ret Req Last Req [CT.DOT.ReturnRequest.LastRequested]
    /// </summary>
    public DateTime? CtDotRetLastRequested { get => _ctDotRetLastRequested; set => SetField(ref _ctDotRetLastRequested, value); }

    /// <summary>
    /// DOT Mort Ret Req Next Follow-up Date [CT.DOT.ReturnRequest.NextFollowUpDate]
    /// </summary>
    public DateTime? CtDotRetNextFollowUpDate { get => _ctDotRetNextFollowUpDate; set => SetField(ref _ctDotRetNextFollowUpDate, value); }

    /// <summary>
    /// DOT Mort Ret Req Org [CT.DOT.ReturnRequest.Organization]
    /// </summary>
    public string? CtDotRetOrganization { get => _ctDotRetOrganization; set => SetField(ref _ctDotRetOrganization, value); }

    /// <summary>
    /// DOT Mort Ret Req Phone [CT.DOT.ReturnRequest.Phone]
    /// </summary>
    public string? CtDotRetPhone { get => _ctDotRetPhone; set => SetField(ref _ctDotRetPhone, value); }

    /// <summary>
    /// DOT Mort Ret Req Received [CT.DOT.ReturnRequest.Received]
    /// </summary>
    public DateTime? CtDotRetReceived { get => _ctDotRetReceived; set => SetField(ref _ctDotRetReceived, value); }

    /// <summary>
    /// DOT Mort Ret Req Req By [CT.DOT.ReturnRequest.RequestedBy]
    /// </summary>
    public string? CtDotRetRequestedBy { get => _ctDotRetRequestedBy; set => SetField(ref _ctDotRetRequestedBy, value); }

    /// <summary>
    /// DOT Mort Ship Address [CT.DOT.ShippingStatus.Address]
    /// </summary>
    public string? CtDotShipAddress { get => _ctDotShipAddress; set => SetField(ref _ctDotShipAddress, value); }

    /// <summary>
    /// DOT Mort Ship Carrier [CT.DOT.ShippingStatus.Carrier]
    /// </summary>
    public string? CtDotShipCarrier { get => _ctDotShipCarrier; set => SetField(ref _ctDotShipCarrier, value); }

    /// <summary>
    /// DOT Mort Ship Contact [CT.DOT.ShippingStatus.Contact]
    /// </summary>
    public string? CtDotShipContact { get => _ctDotShipContact; set => SetField(ref _ctDotShipContact, value); }

    /// <summary>
    /// DOT Mort Ship Email [CT.DOT.ShippingStatus.Email]
    /// </summary>
    public string? CtDotShipEmail { get => _ctDotShipEmail; set => SetField(ref _ctDotShipEmail, value); }

    /// <summary>
    /// DOT Mort Ship Org [CT.DOT.ShippingStatus.Organization]
    /// </summary>
    public string? CtDotShipOrganization { get => _ctDotShipOrganization; set => SetField(ref _ctDotShipOrganization, value); }

    /// <summary>
    /// DOT Mort Ship Phone [CT.DOT.ShippingStatus.Phone]
    /// </summary>
    public string? CtDotShipPhone { get => _ctDotShipPhone; set => SetField(ref _ctDotShipPhone, value); }

    /// <summary>
    /// DOT Mort Shipped By [CT.DOT.ShippingStatus.ShippedBy]
    /// </summary>
    public string? CtDotShipShippedBy { get => _ctDotShipShippedBy; set => SetField(ref _ctDotShipShippedBy, value); }

    /// <summary>
    /// DOT Mort Shipped Date [CT.DOT.ShippingStatus.ShippingDate]
    /// </summary>
    public DateTime? CtDotShipShippingDate { get => _ctDotShipShippingDate; set => SetField(ref _ctDotShipShippingDate, value); }

    /// <summary>
    /// DOT Mort Ship Track# [CT.DOT.ShippingStatus.TrackingNumber]
    /// </summary>
    public string? CtDotShipTrackingNumber { get => _ctDotShipTrackingNumber; set => SetField(ref _ctDotShipTrackingNumber, value); }

    /// <summary>
    /// Recipient Address(Investor Address) [CT.EN.ShippingStatus.Address]
    /// </summary>
    public string? CtEnShipAddress { get => _ctEnShipAddress; set => SetField(ref _ctEnShipAddress, value); }

    /// <summary>
    /// WHL or Doc Custodian Carrier(Fedex,UPS,USPS,etc) [CT.EN.ShippingStatus.Carrier]
    /// </summary>
    public string? CtEnShipCarrier { get => _ctEnShipCarrier; set => SetField(ref _ctEnShipCarrier, value); }

    /// <summary>
    /// Recipient Contact(Investor Contact Name) [CT.EN.ShippingStatus.Contact]
    /// </summary>
    public string? CtEnShipContact { get => _ctEnShipContact; set => SetField(ref _ctEnShipContact, value); }

    /// <summary>
    /// Recipient Email(Investor Email Address) [CT.EN.ShippingStatus.Email]
    /// </summary>
    public string? CtEnShipEmail { get => _ctEnShipEmail; set => SetField(ref _ctEnShipEmail, value); }

    /// <summary>
    /// Recipient Type(Investor Purchasing Loan) [CT.EN.ShippingStatus.Organization]
    /// </summary>
    public string? CtEnShipOrganization { get => _ctEnShipOrganization; set => SetField(ref _ctEnShipOrganization, value); }

    /// <summary>
    /// Recipient Phone(Investor Phone Number) [CT.EN.ShippingStatus.Phone]
    /// </summary>
    public string? CtEnShipPhone { get => _ctEnShipPhone; set => SetField(ref _ctEnShipPhone, value); }

    /// <summary>
    /// Name of WHL or Doc Custodian [CT.EN.ShippingStatus.ShippedBy]
    /// </summary>
    public string? CtEnShipShippedBy { get => _ctEnShipShippedBy; set => SetField(ref _ctEnShipShippedBy, value); }

    /// <summary>
    /// WHL or Doc Custodian Ship Date [CT.EN.ShippingStatus.ShippingDate]
    /// </summary>
    public DateTime? CtEnShipShippingDate { get => _ctEnShipShippingDate; set => SetField(ref _ctEnShipShippingDate, value); }

    /// <summary>
    /// Carrier Tracking # [CT.EN.ShippingStatus.TrackingNumber]
    /// </summary>
    public string? CtEnShipTrackingNumber { get => _ctEnShipTrackingNumber; set => SetField(ref _ctEnShipTrackingNumber, value); }

    /// <summary>
    /// FTP Contact [CT.FTP.InitialRequest.Contact]
    /// </summary>
    public string? CtFtpInitContact { get => _ctFtpInitContact; set => SetField(ref _ctFtpInitContact, value); }

    /// <summary>
    /// FTP Days Outstanding [CT.FTP.InitialRequest.DaysOutstanding]
    /// </summary>
    public string? CtFtpInitDaysOutstanding { get => _ctFtpInitDaysOutstanding; set => SetField(ref _ctFtpInitDaysOutstanding, value); }

    /// <summary>
    /// FTP Email [CT.FTP.InitialRequest.Email]
    /// </summary>
    public string? CtFtpInitEmail { get => _ctFtpInitEmail; set => SetField(ref _ctFtpInitEmail, value); }

    /// <summary>
    /// FTP Last Req [CT.FTP.InitialRequest.LastRequested]
    /// </summary>
    public string? CtFtpInitLastRequested { get => _ctFtpInitLastRequested; set => SetField(ref _ctFtpInitLastRequested, value); }

    /// <summary>
    /// FTP Next Follow-up Date [CT.FTP.InitialRequest.NextFollowupDate]
    /// </summary>
    public DateTime? CtFtpInitNextFollowupDate { get => _ctFtpInitNextFollowupDate; set => SetField(ref _ctFtpInitNextFollowupDate, value); }

    /// <summary>
    /// FTP Org [CT.FTP.InitialRequest.Organization]
    /// </summary>
    public string? CtFtpInitOrganization { get => _ctFtpInitOrganization; set => SetField(ref _ctFtpInitOrganization, value); }

    /// <summary>
    /// FTP Phone [CT.FTP.InitialRequest.Phone]
    /// </summary>
    public string? CtFtpInitPhone { get => _ctFtpInitPhone; set => SetField(ref _ctFtpInitPhone, value); }

    /// <summary>
    /// FTP Received [CT.FTP.InitialRequest.Received]
    /// </summary>
    public string? CtFtpInitReceived { get => _ctFtpInitReceived; set => SetField(ref _ctFtpInitReceived, value); }

    /// <summary>
    /// FTP Req By [CT.FTP.InitialRequest.RequestedBy]
    /// </summary>
    public string? CtFtpInitRequestedBy { get => _ctFtpInitRequestedBy; set => SetField(ref _ctFtpInitRequestedBy, value); }

    /// <summary>
    /// FTP Ret Req Contact [CT.FTP.ReturnRequest.Contact]
    /// </summary>
    public string? CtFtpRetContact { get => _ctFtpRetContact; set => SetField(ref _ctFtpRetContact, value); }

    /// <summary>
    /// FTP Ret Req Email [CT.FTP.ReturnRequest.Email]
    /// </summary>
    public string? CtFtpRetEmail { get => _ctFtpRetEmail; set => SetField(ref _ctFtpRetEmail, value); }

    /// <summary>
    /// FTP Ret Req Last Req [CT.FTP.ReturnRequest.LastRequested]
    /// </summary>
    public DateTime? CtFtpRetLastRequested { get => _ctFtpRetLastRequested; set => SetField(ref _ctFtpRetLastRequested, value); }

    /// <summary>
    /// FTP Ret Req Next Follow-up Date [CT.FTP.ReturnRequest.NextFollowUpDate]
    /// </summary>
    public DateTime? CtFtpRetNextFollowUpDate { get => _ctFtpRetNextFollowUpDate; set => SetField(ref _ctFtpRetNextFollowUpDate, value); }

    /// <summary>
    /// FTP Ret Req Org [CT.FTP.ReturnRequest.Organization]
    /// </summary>
    public string? CtFtpRetOrganization { get => _ctFtpRetOrganization; set => SetField(ref _ctFtpRetOrganization, value); }

    /// <summary>
    /// FTP Ret Req Phone [CT.FTP.ReturnRequest.Phone]
    /// </summary>
    public string? CtFtpRetPhone { get => _ctFtpRetPhone; set => SetField(ref _ctFtpRetPhone, value); }

    /// <summary>
    /// FTP Ret Req Received [CT.FTP.ReturnRequest.Received]
    /// </summary>
    public DateTime? CtFtpRetReceived { get => _ctFtpRetReceived; set => SetField(ref _ctFtpRetReceived, value); }

    /// <summary>
    /// FTP Ret Req Req By [CT.FTP.ReturnRequest.RequestedBy]
    /// </summary>
    public string? CtFtpRetRequestedBy { get => _ctFtpRetRequestedBy; set => SetField(ref _ctFtpRetRequestedBy, value); }

    /// <summary>
    /// FTP Ship Address [CT.FTP.ShippingStatus.Address]
    /// </summary>
    public string? CtFtpShipAddress { get => _ctFtpShipAddress; set => SetField(ref _ctFtpShipAddress, value); }

    /// <summary>
    /// FTP Ship Carrier [CT.FTP.ShippingStatus.Carrier]
    /// </summary>
    public string? CtFtpShipCarrier { get => _ctFtpShipCarrier; set => SetField(ref _ctFtpShipCarrier, value); }

    /// <summary>
    /// FTP Ship Contact [CT.FTP.ShippingStatus.Contact]
    /// </summary>
    public string? CtFtpShipContact { get => _ctFtpShipContact; set => SetField(ref _ctFtpShipContact, value); }

    /// <summary>
    /// FTP Ship Email [CT.FTP.ShippingStatus.Email]
    /// </summary>
    public string? CtFtpShipEmail { get => _ctFtpShipEmail; set => SetField(ref _ctFtpShipEmail, value); }

    /// <summary>
    /// FTP Ship Org [CT.FTP.ShippingStatus.Organization]
    /// </summary>
    public string? CtFtpShipOrganization { get => _ctFtpShipOrganization; set => SetField(ref _ctFtpShipOrganization, value); }

    /// <summary>
    /// FTP Ship Phone [CT.FTP.ShippingStatus.Phone]
    /// </summary>
    public string? CtFtpShipPhone { get => _ctFtpShipPhone; set => SetField(ref _ctFtpShipPhone, value); }

    /// <summary>
    /// FTP Shipped By [CT.FTP.ShippingStatus.ShippedBy]
    /// </summary>
    public string? CtFtpShipShippedBy { get => _ctFtpShipShippedBy; set => SetField(ref _ctFtpShipShippedBy, value); }

    /// <summary>
    /// FTP Ship Date [CT.FTP.ShippingStatus.ShippingDate]
    /// </summary>
    public DateTime? CtFtpShipShippingDate { get => _ctFtpShipShippingDate; set => SetField(ref _ctFtpShipShippingDate, value); }

    /// <summary>
    /// FTP Ship Track# [CT.FTP.ShippingStatus.TrackingNumber]
    /// </summary>
    public string? CtFtpShipTrackingNumber { get => _ctFtpShipTrackingNumber; set => SetField(ref _ctFtpShipTrackingNumber, value); }

    /// <summary>
    /// CollateralTracking Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }
}