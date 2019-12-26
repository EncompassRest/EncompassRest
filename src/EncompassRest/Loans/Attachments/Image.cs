namespace EncompassRest.Loans.Attachments
{
    /// <summary>
    /// Base Image class. 
    /// </summary>
    public abstract class Image : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _imageKey;
        private DirtyValue<string?>? _zipKey;
        private DirtyValue<int?>? _width;
        private DirtyValue<int?>? _height;
        private DirtyValue<float?>? _horizontalResolution;
        private DirtyValue<float?>? _verticalResolution;
        private DirtyValue<string?>? _mediaUrl;

        /// <summary>
        /// The identifier of the image or thumbnail file.
        /// </summary>
        public string? ImageKey { get => _imageKey; set => SetField(ref _imageKey, value); }

        /// <summary>
        /// The identifier of the zip file that contains the image or thumbnail.
        /// </summary>
        public string? ZipKey { get => _zipKey; set => SetField(ref _zipKey, value); }

        /// <summary>
        /// The width of the annotation.
        /// </summary>
        public int? Width { get => _width; set => SetField(ref _width, value); }

        /// <summary>
        /// The height of the annotation.
        /// </summary>
        public int? Height { get => _height; set => SetField(ref _height, value); }

        /// <summary>
        /// The horizontal resolution of the image or thumbnail.
        /// </summary>
        public float? HorizontalResolution { get => _horizontalResolution; set => SetField(ref _horizontalResolution, value); }

        /// <summary>
        /// The vertical resolution of the image or thumbnail.
        /// </summary>
        public float? VeriticalResolution { get => _verticalResolution; set => SetField(ref _verticalResolution, value); }

        /// <summary>
        /// The location or path where the media attachment is located.
        /// </summary>
        public string? MediaUrl { get => _mediaUrl; set => SetField(ref _mediaUrl, value); }

        [IdPropertyName(nameof(ImageKey))]
        string? IIdentifiable.Id { get => ImageKey; set => ImageKey = value; }
    }
}