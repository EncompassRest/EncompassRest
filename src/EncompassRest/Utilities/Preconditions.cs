using System;
using System.Collections.Generic;
using System.Linq;

namespace EncompassRest.Utilities
{
    internal static class Preconditions
    {
        public static void NotNull(object value, string paramName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(paramName);
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

        public static void NotAnyNull<T>(IEnumerable<T> value, string paramName)
            where T : class
        {
            NotNull(value, paramName);
            if (value.Any(v => v == null))
            {
                throw new ArgumentNullException(paramName);
            }
        }

        public static void NotNullOrEmpty(string value, string paramName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("cannot be null or empty", paramName);
            }
        }

        public static void NullOrEmpty(string value, string paramName)
        {
            if (!string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("must be null or empty", paramName);
            }
        }

        public static void LessThan(int value, string paramName, int comparisonValue) => LessThan(value, paramName, comparisonValue, null);

        public static void LessThan(int value, string paramName, int comparisonValue, string comparisonValueParamName)
        {
            if (value >= comparisonValue)
            {
                throw new ArgumentOutOfRangeException(paramName, $"must be less than {comparisonValueParamName ?? comparisonValue.ToString()}");
            }
        }

        public static void LessThanOrEquals(int value, string paramName, int comparisonValue) => LessThanOrEquals(value, paramName, comparisonValue, null);

        public static void LessThanOrEquals(int value, string paramName, int comparisonValue, string comparisonValueParamName)
        {
            if (value > comparisonValue)
            {
                throw new ArgumentOutOfRangeException(paramName, $"must be less than or equal to {comparisonValueParamName ?? comparisonValue.ToString()}");
            }
        }

        public static void GreaterThan(int value, string paramName, int comparisonValue) => GreaterThan(value, paramName, comparisonValue, null);
        
        public static void GreaterThan(int value, string paramName, int comparisonValue, string comparisonValueParamName)
        {
            if (value <= comparisonValue)
            {
                throw new ArgumentOutOfRangeException(paramName, $"must be greater than {comparisonValueParamName ?? comparisonValue.ToString()}");
            }
        }

        public static void GreaterThanOrEquals(int value, string paramName, int comparisonValue) => GreaterThanOrEquals(value, paramName, comparisonValue, null);

        public static void GreaterThanOrEquals(int value, string paramName, int comparisonValue, string comparisonValueParamName)
        {
            if (value < comparisonValue)
            {
                throw new ArgumentOutOfRangeException(paramName, $"must be greater than or equal to {comparisonValueParamName ?? comparisonValue.ToString()}");
            }
        }
    }
}