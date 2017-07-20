using System;
using System.Collections.Generic;
using System.Linq;

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

        public static void NullOrEmpty(string value, string paramName)
        {
            if (!string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("must be null or empty", paramName);
            }
        }
        
        public static void GreaterThan(int value, string paramName, int comparisonValue) => GreaterThan(value, paramName, comparisonValue, comparisonValue.ToString());
        
        public static void GreaterThan(int value, string paramName, int comparisonValue, string comparisonValueParamName)
        {
            if (value <= comparisonValue)
            {
                throw new ArgumentOutOfRangeException(paramName, $"must be greater than {comparisonValueParamName}");
            }
        }
    }
}