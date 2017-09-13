using System;
using System.Collections.Concurrent;
using System.Reflection;

namespace EncompassRest.Utilities
{
    internal class TypeData
    {
        private static ConcurrentDictionary<Type, TypeData> s_typeDatas = new ConcurrentDictionary<Type, TypeData>();

        public static Type OpenNullableType { get; } = typeof(Nullable<>);

        public static TypeData Get(Type type) => s_typeDatas.GetOrAdd(type, t => new TypeData(t));

        private bool? _isNullable;
        private bool? _isValueType;
        private bool? _isEnum;
        private TypeInfo _typeInfo;
        private TypeData _nonNullableTypeData;

        public Type Type { get; }

        public TypeInfo TypeInfo => _typeInfo ?? (_typeInfo = Type.GetTypeInfo());

        public bool IsNullable => _isNullable ?? (_isNullable = !IsValueType || (TypeInfo.IsGenericType && !TypeInfo.IsGenericTypeDefinition && Type.GetGenericTypeDefinition() == OpenNullableType)).GetValueOrDefault();

        public bool IsValueType => _isValueType ?? (_isValueType = TypeInfo.IsValueType).GetValueOrDefault();

        public bool IsNullableValueType => IsValueType && IsNullable;

        public bool IsEnum => _isEnum ?? (_isEnum = TypeInfo.IsEnum).GetValueOrDefault();

        public TypeData NonNullableValueTypeData => IsNullableValueType ? _nonNullableTypeData ?? (_nonNullableTypeData = Get(Type.GenericTypeArguments[0])) : null;

        public TypeData(Type type)
        {
            Type = type;
        }
    }
}