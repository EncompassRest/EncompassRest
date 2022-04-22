using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ImportBorrowersRights
    /// </summary>
    public sealed class ImportBorrowersRights : ParentAccessRights
    {
        /// <summary>
        /// ImportBorrowersRights FromaFNMA32File
        /// </summary>
        [JsonProperty("fromaFNMA3.2File")]
        public bool? FromaFNMA32File { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ImportBorrowersRights FromAnotherLoan
        /// </summary>
        public bool? FromAnotherLoan { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ImportBorrowersRights FromContacts
        /// </summary>
        public bool? FromContacts { get => GetValue<bool?>(); set => SetValue(value); }
    }
}