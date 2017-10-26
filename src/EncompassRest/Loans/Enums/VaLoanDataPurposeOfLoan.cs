using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum VaLoanDataPurposeOfLoan
    {
        Home = 0,
        ManufacturedHome = 1,
        Condominium = 2,
        [EnumMember(Value = "Alterations/Improvements")]
        AlterationsImprovements = 3,
        Refinance = 4
    }
}