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

        public static implicit operator NA<T>(string na) => new NA<T>(na);

        private T _value;
        private bool _isNotNull;

        public T Value
        {
            get
            {
                if (IsNull)
                {
                    throw new InvalidOperationException("The IsNull property is true");
                }
                if (IsNA)
                {
                    throw new InvalidOperationException("The IsNA property is true");
                }

                return _value;
            }
        }

        public bool HasValue => _isNotNull && !IsNA;

        public bool IsNull => !_isNotNull;

        public bool IsNA { get; }

        public NA(string na)
        {
            _value = default;
            _isNotNull = na != null;
            IsNA = _isNotNull;
        }

        public NA(T value)
        {
            _value = value;
            _isNotNull = true;
            IsNA = false;
        }

        public T GetValueOrDefault() => _value;

        public T GetValueOrDefault(T defaultValue) => HasValue ? _value : defaultValue;

        public override int GetHashCode() => _isNotNull ? (IsNA ? "NA".GetHashCode() : _value.GetHashCode()) : 0;

        public override string ToString() => _isNotNull ? (IsNA ? "NA" : _value.ToString()) : null;
    }
    
    internal sealed class NAConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == TypeData<NA<T>>.Type || objectType == TypeData<NA<T>?>.Type;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    return new NA<T>();
                case JsonToken.String when string.Equals(reader.Value.ToString(), "NA", StringComparison.OrdinalIgnoreCase):
                    return new NA<T>("NA");
                default:
                    return new NA<T>(serializer.Deserialize<T>(reader));
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => writer.WriteValue(value?.ToString());
    }
}
