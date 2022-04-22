using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TPOContactsRights
    /// </summary>
    public sealed class TPOContactsRights : ParentAccessRights
    {
        /// <summary>
        /// TPOContactsRights AuthorizedTrader
        /// </summary>
        public bool? AuthorizedTrader { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOContactsRights CreateEditContacts
        /// </summary>
        [JsonProperty("create/EditContacts")]
        public bool? CreateEditContacts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOContactsRights DeleteContacts
        /// </summary>
        public bool? DeleteContacts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOContactsRights ExportContacts
        /// </summary>
        public bool? ExportContacts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOContactsRights ResetPassword
        /// </summary>
        public bool? ResetPassword { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOContactsRights SalesRep
        /// </summary>
        public bool? SalesRep { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOContactsRights SendWelcomeEmail
        /// </summary>
        public bool? SendWelcomeEmail { get => GetValue<bool?>(); set => SetValue(value); }
    }
}