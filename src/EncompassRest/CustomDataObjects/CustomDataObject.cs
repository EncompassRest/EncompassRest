using System;
using System.ComponentModel;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.CustomDataObjects
{
    [Entity(PropertiesToAlwaysSerialize = nameof(DataObject))]
    public sealed class CustomDataObject : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _name;
        public string Name
        {
            get => _name;
            set
            {
                Preconditions.NotNullOrEmpty(value, nameof(Name));

                SetField(ref _name, value);
            }
        }
        private DirtyValue<byte[]> _dataObject;
        public byte[] DataObject
        {
            get => _dataObject;
            set
            {
                Preconditions.NotNull(value, nameof(DataObject));

                SetField(ref _dataObject, value);
            }
        }
        [IdPropertyName(nameof(Name))]
        string IIdentifiable.Id { get => Name; set => Name = value; }

        [JsonConstructor]
        public CustomDataObject(string name, byte[] dataObject)
        {
            Name = name;
            DataObject = dataObject;
        }

        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public CustomDataObject()
        {
        }
    }
}