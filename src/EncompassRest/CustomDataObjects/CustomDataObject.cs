using System;
using System.ComponentModel;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.CustomDataObjects
{
    /// <summary>
    /// CustomDataObject
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(DataObject))]
    public sealed class CustomDataObject : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _name;
        private DirtyValue<byte[]> _dataObject;

        /// <summary>
        /// The name of the custom data object to retrieve. It is also known as the objectName.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                Preconditions.NotNullOrEmpty(value, nameof(Name));

                SetField(ref _name, value);
            }
        }

        /// <summary>
        /// The Base64 encoded content of the file.
        /// </summary>
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

        /// <summary>
        /// CustomDataObject constructor.
        /// </summary>
        /// <param name="name">The name of the custom data object to retrieve. It is also known as the objectName.</param>
        /// <param name="dataObject">The Base64 encoded content of the file.</param>
        [JsonConstructor]
        public CustomDataObject(string name, byte[] dataObject)
        {
            Name = name;
            DataObject = dataObject;
        }

        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public CustomDataObject()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
        }
    }
}