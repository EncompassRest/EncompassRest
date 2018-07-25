using System;
using System.ComponentModel;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.CustomDataObjects
{
    public sealed class CustomDataObject : ExtensibleObject, IIdentifiable
    {
        private string _name;
        private byte[] _dataObject;

        public string Name
        {
            get => _name;
            set
            {
                Preconditions.NotNullOrEmpty(value, nameof(Name));

                _name = value;
            }
        }

        public byte[] DataObject
        {
            get => _dataObject;
            set
            {
                Preconditions.NotNull(value, nameof(DataObject));

                _dataObject = value;
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

        [Obsolete("Use a different constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public CustomDataObject()
        {
        }
    }
}