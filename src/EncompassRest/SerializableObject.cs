using System.IO;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// Base class that supports json serialization.
    /// </summary>
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public abstract class SerializableObject
    {
        /// <summary>
        /// Serializes object to it's json representation without indenting.
        /// </summary>
        /// <returns>Json representation of the object.</returns>
        public override string ToString() => ToString(false);

        /// <summary>
        /// Serializes object to it's json representation with indenting if <paramref name="indent"/> is <c>true</c>.
        /// </summary>
        /// <param name="indent">Specifies if the json should be indented.</param>
        /// <returns>Json representation of the object.</returns>
        public string ToString(bool indent)
        {
            var serializer = indent ? JsonHelper.DefaultIndentedPublicSerializer : JsonHelper.DefaultPublicSerializer;
            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, this);
                return writer.ToString();
            }
        }
    }
}