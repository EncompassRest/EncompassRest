using System;

namespace EncompassRest.Loans
{
    /// <summary>
    /// The loan metadata.
    /// </summary>
    public sealed class LoanMetadata : ExtensibleObject
    {
        /// <summary>
        /// The unique identifier assigned to the loan. Also known as GUID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Date when the loan was last modified in UTC.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Date the loan was created in UTC.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// File size of the loan.
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Folder in which the loan currently resides.
        /// </summary>
        public string LoanFolder { get; set; }

        /// <summary>
        /// Name of the loan.
        /// </summary>
        public string LoanName { get; set; }
    }
}