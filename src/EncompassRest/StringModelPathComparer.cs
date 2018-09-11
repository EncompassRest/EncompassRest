using System.Collections.Generic;
using EncompassRest.Loans;

namespace EncompassRest
{
    internal sealed class StringModelPathComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y) => string.IsNullOrEmpty(x) ? string.IsNullOrEmpty(y) : LoanFieldDescriptors.CreateModelPath(x)?.Equals(LoanFieldDescriptors.CreateModelPath(y)) ?? false;

        public int GetHashCode(string obj) => !string.IsNullOrEmpty(obj) ? LoanFieldDescriptors.CreateModelPath(obj)?.GetHashCode() ?? 0 : 0;
    }
}