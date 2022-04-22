namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ContactsClassRights
    /// </summary>
    public abstract class ContactsClassRights : ParentAccessRights
    {
        /// <summary>
        /// ContactsClassRights AccessToLoanstab
        /// </summary>
        public bool? AccessToLoanstab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ContactsClassRights CreateNewContacts
        /// </summary>
        public bool? CreateNewContacts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ContactsClassRights DeleteContacts
        /// </summary>
        public bool? DeleteContacts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ContactsClassRights DuplicateContacts
        /// </summary>
        public bool? DuplicateContacts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ContactsClassRights ExportContacts
        /// </summary>
        public bool? ExportContacts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ContactsClassRights ImportContacts
        /// </summary>
        public bool? ImportContacts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ContactsClassRights MailMerge
        /// </summary>
        public bool? MailMerge { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ContactsClassRights ManagePersonalCustomLetter
        /// </summary>
        public bool? ManagePersonalCustomLetter { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ContactsClassRights Print
        /// </summary>
        public bool? Print { get => GetValue<bool?>(); set => SetValue(value); }

        internal ContactsClassRights()
        {
        }
    }
}