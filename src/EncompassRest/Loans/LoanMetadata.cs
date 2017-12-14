using System;

namespace EncompassRest.Loans
{
    public sealed class LoanMetadata : ExtensibleObject
    {
        public string Id { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Size { get; set; }
        public string LoanFolder { get; set; }
        public string LoanName { get; set; }
    }
}