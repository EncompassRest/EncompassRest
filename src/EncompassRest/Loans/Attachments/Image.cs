namespace EncompassRest.Loans.Attachments
{
    public abstract class Image : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _imageKey;
        private DirtyValue<string> _zipKey;
        private DirtyValue<int?> _width;
        private DirtyValue<int?> _height;
        private DirtyValue<float?> _horizontalResolution;
        private DirtyValue<float?> _verticalResolution;

        public string ImageKey { get => _imageKey; set => SetField(ref _imageKey, value); }

        public string ZipKey { get => _zipKey; set => SetField(ref _zipKey, value); }

        public int? Width { get => _width; set => SetField(ref _width, value); }

        public int? Height { get => _height; set => SetField(ref _height, value); }

        public float? HorizontalResolution { get => _horizontalResolution; set => SetField(ref _horizontalResolution, value); }

        public float? VeriticalResolution { get => _verticalResolution; set => SetField(ref _verticalResolution, value); }

        [IdPropertyName(nameof(ImageKey))]
        string IIdentifiable.Id { get => ImageKey; set => ImageKey = value; }
    }
}