namespace EncompassRest.Loans.Attachments.v1
{
    /// <summary>
    /// Base Image class. 
    /// </summary>
    public abstract class Image : DirtyExtensibleObject, IIdentifiable
    {
        /// <summary>
        /// The identifier of the image or thumbnail file.
        /// </summary>
        public string? ImageKey { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The identifier of the zip file that contains the image or thumbnail.
        /// </summary>
        public string? ZipKey { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The width of the annotation.
        /// </summary>
        public int? Width { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// The height of the annotation.
        /// </summary>
        public int? Height { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// The horizontal resolution of the image or thumbnail.
        /// </summary>
        public float? HorizontalResolution { get => GetValue<float?>(); set => SetValue(value); }

        /// <summary>
        /// The vertical resolution of the image or thumbnail.
        /// </summary>
        public float? VeriticalResolution { get => GetValue<float?>(); set => SetValue(value); }

        /// <summary>
        /// The location or path where the media attachment is located.
        /// </summary>
        public string? MediaUrl { get => GetValue<string?>(); set => SetValue(value); }

        [IdPropertyName(nameof(ImageKey))]
        string? IIdentifiable.Id { get => ImageKey; set => ImageKey = value; }
    }
}