using System.Globalization;
using System.IO;
using System.Text;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// Base class that supports json serialization.
    /// </summary>
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public abstract class SerializableObject
    {
        internal SerializableObject()
        {
        }

        /// <summary>
        /// Serializes object to it's json representation without indenting.
        /// </summary>
        /// <returns>Json representation of the object.</returns>
        public override string ToString() => ToString(SerializationOptions.None);

        /// <summary>
        /// Serializes object to it's json representation using the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The serialization options.</param>
        /// <returns>Json representation of the object.</returns>
        public string ToString(SerializationOptions options)
        {
            options.Validate(nameof(options));

            JsonSerializer serializer;
            var indented = options.HasAnyFlags(SerializationOptions.Indent);
            if (options.HasAnyFlags(SerializationOptions.Dirty))
            {
                serializer = indented ? JsonHelper.DefaultIndentedDirtySerializer : JsonHelper.DefaultDirtySerializer;
            }
            else
            {
                serializer = indented ? JsonHelper.DefaultIndentedPublicSerializer : JsonHelper.DefaultPublicSerializer;
            }
            using (var writer = new StringWriter(new StringBuilder(256), CultureInfo.InvariantCulture))
            {
                serializer.Serialize(writer, this);
                return writer.ToString();
            }
        }
    }
}