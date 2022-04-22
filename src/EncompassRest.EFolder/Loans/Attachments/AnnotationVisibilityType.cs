namespace EncompassRest.Loans.Attachments
{
    /// <summary>
    /// AnnotationVisibilityType
    /// </summary>
    public enum AnnotationVisibilityType
    {
        /// <summary>
        /// Public (Default. Viewable by everyone and is sent as part of documents.)
        /// </summary>
        Public = 0,
        /// <summary>
        /// Internal (Viewable by any person with Encompass permissions to view annotations.)
        /// </summary>
        Internal = 1,
        /// <summary>
        /// Personal (Viewable by the user who added it.)
        /// </summary>
        Personal = 2
    }
}