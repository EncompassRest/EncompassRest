namespace EncompassRest.Loans.Attachments
{
    public abstract class Image
    {
        public string ImageKey { get; set; }
        public string ZipKey { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public float? HorizontalResolution { get; set; }
        public float? VeriticalResolution { get; set; }
    }
}