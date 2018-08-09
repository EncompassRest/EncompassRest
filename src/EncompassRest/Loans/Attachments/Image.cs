namespace EncompassRest.Loans.Attachments
{
    public abstract class Image : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _imageKey;
        public string ImageKey { get => _imageKey; set => _imageKey = value; }
        private DirtyValue<string> _zipKey;
        public string ZipKey { get => _zipKey; set => _zipKey = value; }
        private DirtyValue<int?> _width;
        public int? Width { get => _width; set => _width = value; }
        private DirtyValue<int?> _height;
        public int? Height { get => _height; set => _height = value; }
        private DirtyValue<float?> _horizontalResolution;
        public float? HorizontalResolution { get => _horizontalResolution; set => _horizontalResolution = value; }
        private DirtyValue<float?> _verticalResolution;
        public float? VeriticalResolution { get => _verticalResolution; set => _verticalResolution = value; }
        [IdPropertyName(nameof(ImageKey))]
        string IIdentifiable.Id { get => ImageKey; set => ImageKey = value; }
    }
}