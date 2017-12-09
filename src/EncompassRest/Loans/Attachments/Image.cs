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
        internal override bool DirtyInternal
        {
            get
            {
                return _imageKey.Dirty
                    || _zipKey.Dirty
                    || _width.Dirty
                    || _height.Dirty
                    || _horizontalResolution.Dirty
                    || _verticalResolution.Dirty;
            }
            set
            {
                _imageKey.Dirty = value;
                _zipKey.Dirty = value;
                _width.Dirty = value;
                _height.Dirty = value;
                _horizontalResolution.Dirty = value;
                _verticalResolution.Dirty = value;
            }
        }
    }
}