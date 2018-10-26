using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// ImportBorrowersRights
    /// </summary>
    public sealed class ImportBorrowersRights : ParentAccessRights
    {
        private DirtyValue<bool?> _fromaFNMA32File;
        private DirtyValue<bool?> _fromAnotherLoan;
        private DirtyValue<bool?> _fromContacts;

        /// <summary>
        /// ImportBorrowersRights FromaFNMA32File
        /// </summary>
        [JsonProperty("fromaFNMA3.2File")]
        public bool? FromaFNMA32File { get => _fromaFNMA32File; set => SetField(ref _fromaFNMA32File, value); }

        /// <summary>
        /// ImportBorrowersRights FromAnotherLoan
        /// </summary>
        public bool? FromAnotherLoan { get => _fromAnotherLoan; set => SetField(ref _fromAnotherLoan, value); }

        /// <summary>
        /// ImportBorrowersRights FromContacts
        /// </summary>
        public bool? FromContacts { get => _fromContacts; set => SetField(ref _fromContacts, value); }
    }
}