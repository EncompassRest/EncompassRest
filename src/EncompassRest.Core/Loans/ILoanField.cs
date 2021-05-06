using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    public interface ILoanField
    {
        string AttributePath { get; }
        int? BorrowerPairIndex { get; }
        string FieldId { get; }
        LoanFieldFormat? Format { get; }
        string FormattedValue { get; }
        bool IsEmpty { get; }
        bool Locked { get; set; }
        string ModelPath { get; }
        bool ReadOnly { get; }
        string UnformattedValue { get; }
        object? Value { get; set; }

        bool? ToBoolean();
        DateTime? ToDateTime();
        decimal? ToDecimal();
        int? ToInt32();
        string? ToString();
    }
}