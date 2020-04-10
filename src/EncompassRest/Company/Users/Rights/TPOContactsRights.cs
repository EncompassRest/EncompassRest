using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// TPOContactsRights
    /// </summary>
    public sealed class TPOContactsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _authorizedTrader;
        private DirtyValue<bool?>? _createEditContacts;
        private DirtyValue<bool?>? _deleteContacts;
        private DirtyValue<bool?>? _exportContacts;
        private DirtyValue<bool?>? _resetPassword;
        private DirtyValue<bool?>? _salesRep;
        private DirtyValue<bool?>? _sendWelcomeEmail;

        /// <summary>
        /// TPOContactsRights AuthorizedTrader
        /// </summary>
        public bool? AuthorizedTrader { get => _authorizedTrader; set => SetField(ref _authorizedTrader, value); }

        /// <summary>
        /// TPOContactsRights CreateEditContacts
        /// </summary>
        [JsonProperty("create/EditContacts")]
        public bool? CreateEditContacts { get => _createEditContacts; set => SetField(ref _createEditContacts, value); }

        /// <summary>
        /// TPOContactsRights DeleteContacts
        /// </summary>
        public bool? DeleteContacts { get => _deleteContacts; set => SetField(ref _deleteContacts, value); }

        /// <summary>
        /// TPOContactsRights ExportContacts
        /// </summary>
        public bool? ExportContacts { get => _exportContacts; set => SetField(ref _exportContacts, value); }

        /// <summary>
        /// TPOContactsRights ResetPassword
        /// </summary>
        public bool? ResetPassword { get => _resetPassword; set => SetField(ref _resetPassword, value); }

        /// <summary>
        /// TPOContactsRights SalesRep
        /// </summary>
        public bool? SalesRep { get => _salesRep; set => SetField(ref _salesRep, value); }

        /// <summary>
        /// TPOContactsRights SendWelcomeEmail
        /// </summary>
        public bool? SendWelcomeEmail { get => _sendWelcomeEmail; set => SetField(ref _sendWelcomeEmail, value); }
    }
}