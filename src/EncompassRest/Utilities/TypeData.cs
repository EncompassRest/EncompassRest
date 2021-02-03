using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;

namespace EncompassRest.Utilities
{
    internal sealed class TypeData
    {
        private static ConcurrentDictionary<Type, TypeData> s_typeDatas = new ConcurrentDictionary<Type, TypeData>();

        public static Type OpenNullableType { get; } = typeof(Nullable<>);

        public static Type OpenIEnumerableType { get; } = typeof(IEnumerable<>);

        public static Type OpenStringEnumValueType = typeof(StringEnumValue<>);

        public static Type OpenNaType = typeof(NA<>);

        public static Type OpenDirtyListType = typeof(DirtyList<>);

        public static Type OpenDirtyDictionaryType = typeof(DirtyDictionary<,>);

        public static Type OpenNeverSerializeValueType = typeof(NeverSerializeValue<>);

        public static TypeData Get(Type type) => s_typeDatas.GetOrAdd(type, t => new TypeData(t));

        private bool? _isNullable;
        private bool? _isValueType;
        private bool? _isEnum;
        private TypeInfo? _typeInfo;
        private TypeData? _nonNullableTypeData;

        public Type Type { get; }

        public TypeInfo TypeInfo => _typeInfo ??= Type.GetTypeInfo();

        public bool IsNullable => _isNullable ?? (_isNullable = !IsValueType || (TypeInfo.IsGenericType && !TypeInfo.IsGenericTypeDefinition && Type.GetGenericTypeDefinition() == OpenNullableType)).GetValueOrDefault();

        public bool IsValueType => _isValueType ?? (_isValueType = TypeInfo.IsValueType).GetValueOrDefault();

        public bool IsNullableValueType => IsValueType && IsNullable;

        public bool IsEnum => _isEnum ?? (_isEnum = TypeInfo.IsEnum).GetValueOrDefault();

        public TypeData? NonNullableValueTypeData => IsNullableValueType ? (_nonNullableTypeData ??= Get(Type.GenericTypeArguments[0])) : null;

        public TypeData(Type type)
        {
            Type = type;
        }
    }

    internal static class TypeData<T>
    {
        public static TypeData Data { get; } = TypeData.Get(typeof(T));

        public static Type Type => Data.Type;

        public static TypeInfo TypeInfo => Data.TypeInfo;
    }
}