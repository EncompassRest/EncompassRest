using EnumsNET;

namespace EncompassRest.Filters
{
    public enum CanonicalField
    {
        LoanAmount = 0,
        DateCompleted = 100,
        DateCreated = 101,
        LastModified = 102,
        Address1 = 200,
        Address2 = 201,
        BorrowerName = 202,
        City = 203,
        CurrentMilestoneId = 204,
        Guid = 205,
        LoanFolder = 206,
        LoanName = 207,
        LoanNumber = 208,
        LoanOfficerId = 209,
        LoanProcessorId = 210,
        LoanType = 211,
        NextMilestoneId = 212,
        State = 213,
        TPOLOID = 214,
        TPOLPID = 215,
        Zip = 216
    }

    public static class CanonicalFieldExtensions
    {
        public static string GetCanonicalName(this CanonicalField value) => $"Loan.{value.AsString()}";

        public static bool IsNumeric(this CanonicalField value) => (int)value >= 0 && (int)value < 100;

        public static bool IsDateValued(this CanonicalField value) => (int)value >= 100 && (int)value < 200;

        public static bool IsStringValued(this CanonicalField value) => (int)value >= 200;
    }
}