using System;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Contacts
{
    [Entity(PropertiesToAlwaysSerialize = nameof(Name) + "," + nameof(Description))]
    public sealed class ContactGroup : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<StringEnumValue<ContactType>> _contactType;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<ContactType> ContactType { get => _contactType; set => SetField(ref _contactType, value); }
        private DirtyValue<StringEnumValue<ContactGroupType>> _groupType;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public StringEnumValue<ContactGroupType> GroupType { get => _groupType; set => SetField(ref _groupType, value); }
        private DirtyValue<string> _name;
        public string Name
        {
            get => _name;
            set
            {
                Preconditions.NotNullOrEmpty(value, nameof(Name));

                _name = value;
            }
        }
        private DirtyValue<string> _description;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get => _description; set => SetField(ref _description, value); }
        private NeverSerializeValue<DateTime?> _createdDate;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedDate { get => _createdDate; private set => _createdDate = value; }

        public ContactGroup(string name)
        {
            Name = name;
        }
    }
}