using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum GfeFeeType
    {
        Undefined = 0,
        CompensationToBroker = 1,
        SubtotalOfInitialFeesPaid = 2,
        AppraisalFee = 3,
        BeneficiaryFee = 4,
        CreditInvestigationFee = 5,
        CreditLifeInsurance = 6,
        DischargeExistingLiens = 7,
        EscrowFee = 8,
        HazardInsurance = 9,
        NotaryFee = 10,
        OtherCost = 11,
        OtherCostsExpenses = 12,
        OtherDischarge = 13,
        ReconveyanceFee = 14,
        RecordingFee = 15,
        TitleInsurance = 16,
        SettlementClosingFee = 17,
        UserDefined1 = 18
    }
}