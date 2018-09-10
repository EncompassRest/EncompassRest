namespace EncompassRest.Loans.Attachments
{
    public abstract class Image : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _imageKey;
        public string ImageKey { get => _imageKey; set => SetField(ref _imageKey, value); }
        private DirtyValue<string> _zipKey;
        public string ZipKey { get => _zipKey; set => SetField(ref _zipKey, value); }
        private DirtyValue<int?> _width;
        public int? Width { get => _width; set => SetField(ref _width, value); }
        private DirtyValue<int?> _height;
        public int? Height { get => _height; set => SetField(ref _height, value); }
        private DirtyValue<float?> _horizontalResolution;
        public float? HorizontalResolution { get => _horizontalResolution; set => SetField(ref _horizontalResolution, value); }
        private DirtyValue<float?> _verticalResolution;
        public float? VeriticalResolution { get => _verticalResolution; set => SetField(ref _verticalResolution, value); }
        [IdPropertyName(nameof(ImageKey))]
        string IIdentifiable.Id { get => ImageKey; set => ImageKey = value; }
    }
}