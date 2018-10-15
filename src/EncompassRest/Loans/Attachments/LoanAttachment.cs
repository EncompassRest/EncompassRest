using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Attachments
{
    public sealed class LoanAttachment : DirtyExtensibleObject, IIdentifiable
    {
        private NeverSerializeValue<string> _attachmentId;
        private DirtyValue<DateTime?> _dateCreated;
        private DirtyValue<string> _createdBy;
        private DirtyValue<string> _createdByName;
        private DirtyValue<AttachmentCreateReason?> _createReason;
        private DirtyValue<AttachmentType?> _attachmentType;
        private DirtyValue<long?> _fileSize;
        private DirtyValue<bool?> _isActive;
        private DirtyList<PageImage> _pages;
        private DirtyValue<int?> _rotation;
        private DirtyValue<string> _title;
        private DirtyValue<string> _fileWithExtension;
        private EntityReference _document;
        private NeverSerializeValue<string> _mediaUrl;

        public string AttachmentId { get => _attachmentId; set => SetField(ref _attachmentId, value); }

        public DateTime? DateCreated { get => _dateCreated; set => SetField(ref _dateCreated, value); }

        public string CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }

        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

        [EnumFormat(EnumFormat.DecimalValue)]
        public AttachmentCreateReason? CreateReason { get => _createReason; set => SetField(ref _createReason, value); }

        [EnumFormat(EnumFormat.DecimalValue)]
        public AttachmentType? AttachmentType { get => _attachmentType; set => SetField(ref _attachmentType, value); }

        public long? FileSize { get => _fileSize; set => SetField(ref _fileSize, value); }

        public bool? IsActive { get => _isActive; set => SetField(ref _isActive, value); }

        public IList<PageImage> Pages { get => GetField(ref _pages); set => SetField(ref _pages, value); }

        public int? Rotation { get => _rotation; set => SetField(ref _rotation, value); }

        public string Title { get => _title; set => SetField(ref _title, value); }

        public string FileWithExtension { get => _fileWithExtension; set => SetField(ref _fileWithExtension, value); }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public EntityReference Document { get => _document; set => SetField(ref _document, value); }

        public string MediaUrl { get => _mediaUrl; set => SetField(ref _mediaUrl, value); }

        [IdPropertyName(nameof(AttachmentId))]
        string IIdentifiable.Id { get => AttachmentId; set => AttachmentId = value; }

        internal LoanAttachments Attachments;

        /// <summary>
        /// Loan attachment creation constructor
        /// </summary>
        /// <param name="title"></param>
        /// <param name="fileWithExtension"></param>
        /// <param name="createReason"></param>
        public LoanAttachment(string title, string fileWithExtension, AttachmentCreateReason createReason)
        {
            Preconditions.NotNullOrEmpty(title, nameof(title));
            Preconditions.NotNullOrEmpty(fileWithExtension, nameof(fileWithExtension));

            Title = title;
            FileWithExtension = fileWithExtension;
            CreateReason = createReason;
        }

        /// <summary>
        /// Loan attachment update constructor
        /// </summary>
        /// <param name="attachmentId"></param>
        public LoanAttachment(string attachmentId)
        {
            Preconditions.NotNullOrEmpty(attachmentId, nameof(attachmentId));

            AttachmentId = attachmentId;
        }

        /// <summary>
        /// Loan attachment deserialization constructor
        /// </summary>
        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public LoanAttachment()
        {
        }

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