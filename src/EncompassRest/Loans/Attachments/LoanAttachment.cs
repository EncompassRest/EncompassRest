using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Attachments
{
    public sealed class LoanAttachment : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _attachmentId;
        public string AttachmentId { get => _attachmentId; set => SetField(ref _attachmentId, value); }
        private DirtyValue<DateTime?> _dateCreated;
        public DateTime? DateCreated { get => _dateCreated; set => SetField(ref _dateCreated, value); }
        private DirtyValue<string> _createdBy;
        public string CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }
        private DirtyValue<string> _createdByName;
        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }
        private DirtyValue<AttachmentCreateReason?> _createReason;
        [EnumFormat(EnumFormat.DecimalValue)]
        public AttachmentCreateReason? CreateReason { get => _createReason; set => SetField(ref _createReason, value); }
        private DirtyValue<AttachmentType?> _attachmentType;
        [EnumFormat(EnumFormat.DecimalValue)]
        public AttachmentType? AttachmentType { get => _attachmentType; set => SetField(ref _attachmentType, value); }
        private DirtyValue<long?> _fileSize;
        public long? FileSize { get => _fileSize; set => SetField(ref _fileSize, value); }
        private DirtyValue<bool?> _isActive;
        public bool? IsActive { get => _isActive; set => SetField(ref _isActive, value); }
        private DirtyList<PageImage> _pages;
        public IList<PageImage> Pages { get => GetField(ref _pages); set => SetField(ref _pages, value); }
        private DirtyValue<int?> _rotation;
        public int? Rotation { get => _rotation; set => SetField(ref _rotation, value); }
        private DirtyValue<string> _title;
        public string Title { get => _title; set => SetField(ref _title, value); }
        private DirtyValue<string> _fileWithExtension;
        public string FileWithExtension { get => _fileWithExtension; set => SetField(ref _fileWithExtension, value); }
        private EntityReference _document;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public EntityReference Document { get => _document; set => SetField(ref _document, value); }
        private NeverSerializeValue<string> _mediaUrl;
        public string MediaUrl { get => _mediaUrl; set => _mediaUrl = value; }
        [IdPropertyName(nameof(AttachmentId))]
        string IIdentifiable.Id { get => AttachmentId; set => AttachmentId = value; }

        internal LoanAttachments Attachments;

        public async Task<byte[]> DownloadAsync(CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(AttachmentId, nameof(AttachmentId));

            var mediaUrl = MediaUrl;
            if (string.IsNullOrEmpty(mediaUrl))
            {
                mediaUrl = (await Attachments.GetDownloadAttachmentUrlAsync(AttachmentId, cancellationToken).ConfigureAwait(false)).MediaUrl;
                MediaUrl = mediaUrl;
            }
            return await Attachments.DownloadAttachmentFromMediaUrlAsync(mediaUrl, cancellationToken).ConfigureAwait(false);
        }

        public async Task<Stream> DownloadStreamAsync(CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(AttachmentId, nameof(AttachmentId));

            var mediaUrl = MediaUrl;
            if (string.IsNullOrEmpty(mediaUrl))
            {
                mediaUrl = (await Attachments.GetDownloadAttachmentUrlAsync(AttachmentId, cancellationToken).ConfigureAwait(false)).MediaUrl;
                MediaUrl = mediaUrl;
            }
            return await Attachments.DownloadAttachmentStreamFromMediaUrlAsync(mediaUrl, cancellationToken).ConfigureAwait(false);
        }
    }
}