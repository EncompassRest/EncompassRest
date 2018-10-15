using System;
using System.ComponentModel;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    [Entity(PropertiesToAlwaysSerialize = nameof(Name) + "," + nameof(Description))]
    public sealed class ContactGroup : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        private StringEnumValue<ContactType> _contactType;
        private StringEnumValue<ContactGroupType> _groupType;
        private string _name;
        private DirtyValue<string> _description;
        private NeverSerializeValue<DateTime?> _createdDate;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get => _id; set => SetField(ref _id, value); }

        [JsonRequired]
        public StringEnumValue<ContactType> ContactType { get => _contactType; set => SetField(ref _contactType, value); }

        [JsonRequired]
        public StringEnumValue<ContactGroupType> GroupType { get => _groupType; set => SetField(ref _groupType, value); }

        [JsonRequired]
        public string Name { get => _name; set => SetField(ref _name, value); }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get => _description; set => SetField(ref _description, value); }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedDate { get => _createdDate; private set => SetField(ref _createdDate, value); }

        /// <summary>
        /// Contact group creation constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="contactType"></param>
        /// <param name="groupType"></param>
        public ContactGroup(string name, ContactType contactType, ContactGroupType groupType)
            : this(name, contactType.Validate(nameof(contactType)).GetValue(), groupType.Validate(nameof(groupType)).GetValue())
        {
        }

        /// <summary>
        /// Contact group creation constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="contactType"></param>
        /// <param name="groupType"></param>
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
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="contactType"></param>
        /// <param name="groupType"></param>
        public ContactGroup(string id, string name, ContactType contactType, ContactGroupType groupType)
            : this(id, name, contactType.Validate(nameof(contactType)).GetValue(), groupType.Validate(nameof(groupType)).GetValue())
        {
        }

        /// <summary>
        /// Contact group update constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="contactType"></param>
        /// <param name="groupType"></param>
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

        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ContactGroup(string name)
        {
            Preconditions.NotNullOrEmpty(name, nameof(name));

            Name = name;
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