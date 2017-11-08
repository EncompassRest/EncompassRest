using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PoolStructureType
    {
        InvestorDefinedMultipleLender = 0,
        LenderInitiatedMultipleLender = 1,
        SingleLender = 2
    }
}