using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ContactsRights
    /// </summary>
    public sealed class ContactsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// ContactsRights AccessToContactsTab
        /// </summary>
        [AllowNull]
        public AccessToContactsTabRights AccessToContactsTab { get => GetEntity<AccessToContactsTabRights>(); set => SetEntity(value); }
    }
}