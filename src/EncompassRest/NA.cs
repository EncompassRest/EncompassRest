using System;
using Newtonsoft.Json;
using EncompassRest.Utilities;

namespace EncompassRest
{
    [JsonConverter(typeof(NAConverter<>))]
    public struct NA<T>
    {
        public static explicit operator T(NA<T> value) => value.Value;

        public static implicit operator NA<T>(T value) => new NA<T>(value);

        public static implicit operator NA<T>(string na) => new NA<T>();

        private T _value;
        private bool _hasValue;

        public T Value
        {
            get
            {
                if (IsNA)
                {
                    throw new InvalidOperationException("The IsNA property is true");
                }

                return _value;
            }
        }

        public bool IsNA => !_hasValue;

        public NA(T value)
        {
            _value = value;
            _hasValue = true;
        }

        public T GetValueOrDefault() => _value;

        public T GetValueOrDefault(T defaultValue) => _hasValue ? _value : defaultValue;

        public override int GetHashCode() => _hasValue ? _value.GetHashCode() : "NA".GetHashCode();

        public override string ToString() => _hasValue ? _value.ToString() : "NA";
    }
    
    internal sealed class NAConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == TypeData<NA<T>>.Type;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                var str = reader.Value.ToString();
                if (string.Equals(str, "NA", StringComparison.OrdinalIgnoreCase))
                {
                    return new NA<T>();
                }
            }
            return new NA<T>(serializer.Deserialize<T>(reader));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var na = (NA<T>)value;
            if (na.IsNA)
            {
                writer.WriteValue("NA");
            }
            else
            {
                serializer.Serialize(writer, na.GetValueOrDefault(), TypeData<T>.Type);
            }
        }
    }
}
