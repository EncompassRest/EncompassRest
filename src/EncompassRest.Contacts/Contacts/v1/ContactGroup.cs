using System;
using System.ComponentModel;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// ContactGroup
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(Name) + "," + nameof(Description))]
    public sealed class ContactGroup : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _id;
        private StringEnumValue<ContactType> _contactType;
        private StringEnumValue<ContactGroupType> _groupType;
        private string? _name;
        private DirtyValue<string?>? _description;
        private NeverSerializeValue<DateTime?>? _createdDate;

        /// <summary>
        /// The unique identifier of the group.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// The contact type.
        /// </summary>
        [JsonRequired]
        public StringEnumValue<ContactType> ContactType { get => _contactType; set => SetField(ref _contactType, value); }

        /// <summary>
        /// The contact group type.
        /// </summary>
        [JsonRequired]
        public StringEnumValue<ContactGroupType> GroupType { get => _groupType; set => SetField(ref _groupType, value); }

        /// <summary>
        /// The name of the group.
        /// </summary>
        [JsonRequired]
        public string? Name { get => _name; set => SetField(ref _name, value); }

        /// <summary>
        /// Detailed explanation of a group.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// System-generated date and time when the group was created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedDate { get => _createdDate; private set => SetField(ref _createdDate, value); }

        /// <summary>
        /// Contact group creation constructor
        /// </summary>
        /// <param name="name">The name of the group.</param>
        /// <param name="contactType">The contact type.</param>
        /// <param name="groupType">The contact group type.</param>
        public ContactGroup(string name, ContactType contactType, ContactGroupType groupType)
            : this(name, contactType.Validate(nameof(contactType)).GetValue(), groupType.Validate(nameof(groupType)).GetValue())
        {
        }

        /// <summary>
        /// Contact group creation constructor
        /// </summary>
        /// <param name="name">The name of the group.</param>
        /// <param name="contactType">The contact type.</param>
        /// <param name="groupType">The contact group type.</param>
        public ContactGroup(string name, string contactType, string groupType)
        {
            Preconditions.NotNullOrEmpty(name, nameof(name));
            Preconditions.NotNullOrEmpty(contactType, nameof(contactType));
            Preconditions.NotNullOrEmpty(groupType, nameof(groupType));

            Name = name;
            ContactType = contactType;
            GroupType = groupType;
        }

        /// <summary>
        /// Contact group update constructor
        /// </summary>
        /// <param name="id">The unique identifier of the group.</param>
        /// <param name="name">The name of the group.</param>
        /// <param name="contactType">The contact type.</param>
        /// <param name="groupType">The contact group type.</param>
        public ContactGroup(string id, string name, ContactType contactType, ContactGroupType groupType)
            : this(id, name, contactType.Validate(nameof(contactType)).GetValue(), groupType.Validate(nameof(groupType)).GetValue())
        {
        }

        /// <summary>
        /// Contact group update constructor
        /// </summary>
        /// <param name="id">The unique identifier of the group.</param>
        /// <param name="name">The name of the group.</param>
        /// <param name="contactType">The contact type.</param>
        /// <param name="groupType">The contact group type.</param>
        public ContactGroup(string id, string name, string contactType, string groupType)
        {
            Preconditions.NotNullOrEmpty(id, nameof(id));
            Preconditions.NotNullOrEmpty(name, nameof(name));
            Preconditions.NotNullOrEmpty(contactType, nameof(contactType));
            Preconditions.NotNullOrEmpty(groupType, nameof(groupType));

            Id = id;
            Name = name;
            ContactType = contactType;
            GroupType = groupType;
        }

        /// <summary>
        /// Contact group deserialization constructor
        /// </summary>
        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public ContactGroup()
        {
        }
    }
}