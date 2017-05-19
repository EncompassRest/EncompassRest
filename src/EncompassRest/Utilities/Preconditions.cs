using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EncompassRest.Utilities
{
    internal static class Preconditions
    {
        public static void NotNull<T>(T value, string paramName)
            where T : class
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        public static void Null<T>(T value, string paramName)
            where T : class
        {
            if (value != null)
            {
                throw new ArgumentException("must be null", paramName);
            }
        }

        public static T ValidateNotNull<T>(this T value, string paramName)
             where T : class
        {
            NotNull(value, paramName);

            return value;
        }

        public static T Validate<T>(this T value, Action<T> validator)
        {
            NotNull(validator, nameof(validator));
            validator(value);
            return value;
        }

        public static void NotNullOrEmpty<T>(ICollection<T> value, string paramName)
        {
            NotNull(value, paramName);
            if (value.Count <= 0)
            {
                throw new ArgumentException("cannot be empty", paramName);
            }
        }

        public static void NotNullOrEmpty(ICollection value, string paramName)
        {
            NotNull(value, paramName);
            if (value.Count <= 0)
            {
                throw new ArgumentException("cannot be empty", paramName);
            }
        }

        public static void NotNullOrEmpty<T>(T[] value, string paramName)
        {
            NotNull(value, paramName);
            if (value.Length <= 0)
            {
                throw new ArgumentException("cannot be empty", paramName);
            }
        }

        public static void NotNullOrEmpty<T>(IEnumerable<T> value, string paramName)
        {
            NotNull(value, paramName);
            if (!value.Any())
            {
                throw new ArgumentException("cannot be empty", paramName);
            }
        }

        public static void NotNullOrEmpty(string value, string paramName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("cannot be null or empty", paramName);
            }
        }

        public static void NotNullOrWhiteSpace(string value, string paramName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("cannot be null or white space", paramName);
            }
        }

        public static void NotAnyNull<T>(IEnumerable<T> collection, string collectionName)
            where T : class
        {
            NotNull(collection, collectionName);
            if (collection.Any(value => value == null))
            {
                throw new ArgumentException("must not contain any null items", collectionName);
            }
        }

        public static void NotNullIfNullable<T>(T value, string paramName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        public static void NotNullIfNotNullable<T>(object value, string paramName)
        {
            if (value == null && default(T) != null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        public static void NotNullIfNotNullable(object value, string paramName, Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type), "the type argument shouldn't be null");
            }
            if (value == null && type.GetTypeInfo().IsValueType)
            {
                throw new ArgumentNullException(paramName);
            }
        }
    }
}