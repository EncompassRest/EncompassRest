namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// ContactsClassRights
    /// </summary>
    public abstract class ContactsClassRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _accessToLoanstab;
        private DirtyValue<bool?>? _createNewContacts;
        private DirtyValue<bool?>? _deleteContacts;
        private DirtyValue<bool?>? _duplicateContacts;
        private DirtyValue<bool?>? _exportContacts;
        private DirtyValue<bool?>? _importContacts;
        private DirtyValue<bool?>? _mailMerge;
        private DirtyValue<bool?>? _managePersonalCustomLetter;
        private DirtyValue<bool?>? _print;

        /// <summary>
        /// ContactsClassRights AccessToLoanstab
        /// </summary>
        public bool? AccessToLoanstab { get => _accessToLoanstab; set => SetField(ref _accessToLoanstab, value); }

        /// <summary>
        /// ContactsClassRights CreateNewContacts
        /// </summary>
        public bool? CreateNewContacts { get => _createNewContacts; set => SetField(ref _createNewContacts, value); }

        /// <summary>
        /// ContactsClassRights DeleteContacts
        /// </summary>
        public bool? DeleteContacts { get => _deleteContacts; set => SetField(ref _deleteContacts, value); }

        /// <summary>
        /// ContactsClassRights DuplicateContacts
        /// </summary>
        public bool? DuplicateContacts { get => _duplicateContacts; set => SetField(ref _duplicateContacts, value); }

        /// <summary>
        /// ContactsClassRights ExportContacts
        /// </summary>
        public bool? ExportContacts { get => _exportContacts; set => SetField(ref _exportContacts, value); }

        /// <summary>
        /// ContactsClassRights ImportContacts
        /// </summary>
        public bool? ImportContacts { get => _importContacts; set => SetField(ref _importContacts, value); }

        /// <summary>
        /// ContactsClassRights MailMerge
        /// </summary>
        public bool? MailMerge { get => _mailMerge; set => SetField(ref _mailMerge, value); }

        /// <summary>
        /// ContactsClassRights ManagePersonalCustomLetter
        /// </summary>
        public bool? ManagePersonalCustomLetter { get => _managePersonalCustomLetter; set => SetField(ref _managePersonalCustomLetter, value); }

        /// <summary>
        /// ContactsClassRights Print
        /// </summary>
        public bool? Print { get => _print; set => SetField(ref _print, value); }

        internal ContactsClassRights()
        {
        }
    }
}