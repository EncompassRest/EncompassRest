using EncompassRest.Loans.Enums;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [Entity(PropertiesToAlwaysSerialize = nameof(ApplicationId))]
    partial class Application
    {
        string IIdentifiable.Id { get => Id ?? ApplicationId; set { Id = value; ApplicationId = value; } }
    }

    partial class CustomField
    {
        [IdPropertyName(nameof(FieldName))]
        string IIdentifiable.Id { get => FieldName; set => FieldName = value; }
    }

    partial class FieldLockData
    {
        internal ModelPath _modelPathInternal;

        [IdPropertyName(nameof(ModelPath))]
        string IIdentifiable.Id { get => ModelPath; set => ModelPath = value; }

        internal override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            switch (propertyName)
            {
                case nameof(ModelPath):
                    _modelPathInternal = LoanFieldDescriptors.CreateModelPath(_modelPath);
                    break;
            }
        }
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(FeeType))]
    partial class Fee
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(RegulationZPaymentIndex))]
    partial class RegulationZPayment
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(RegulationZInterestRatePeriodType))]
    partial class RegulationZInterestRatePeriod
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(LineNumber), SerializeWholeListWhenDirty = true)]
    partial class EnergyEfficientMortgageItem
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(IncomeType) + "," + nameof(OtherIncomeIndex) + "," + nameof(Owner))]
    partial class Income
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(AssetType), SerializeWholeListWhenDirty = true)]
    partial class Asset
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(LiabilityType), SerializeWholeListWhenDirty = true)]
    partial class Liability
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(ApplicantType) + "," + nameof(MailingAddressIndicator) + "," + nameof(ResidencyType), SerializeWholeListWhenDirty = true)]
    partial class Residence
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(Owner) + "," + nameof(CurrentEmploymentIndicator))]
    partial class Employment
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(FormType) + "," + nameof(FieldName))]
    partial class SelfEmployedIncome
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(Tax4506TIndicator) + "," + nameof(HistoryIndicator))]
    partial class Tax4506
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(ContactType), SerializeWholeListWhenDirty = true)]
    partial class Contact
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(LoanSubmissionFeeType))]
    partial class LoanSubmissionFee
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(MilitaryServiceIndex))]
    partial class MilitaryService
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(PreviousVaLoanIndex))]
    partial class PreviousVaLoan
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(GfeFeeType) + "," + nameof(GfeFeeIndex))]
    partial class GfeFee
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(GfePayoffIndex))]
    partial class GfePayoff
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(GfeLienType) + "," + nameof(GfeLienIndex))]
    partial class GfeLien
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(GfePaymentIndex))]
    partial class GfePayment
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(Gfe2010FeeParentType) + "," + nameof(Gfe2010FeeType) + "," + nameof(Gfe2010FeeIndex))]
    partial class Gfe2010Fee
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(LineNumber) + "," + nameof(Gfe2010WholePocIndex))]
    partial class Gfe2010WholePoc
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(ChargeBelow10Indicator) + "," + nameof(Gfe2010GfeChargeIndex))]
    partial class Gfe2010GfeCharge
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(LineNumber) + "," + nameof(Gfe2010FwbcFwscIndex) + "," + nameof(LineLetter))]
    partial class Gfe2010FwbcFwsc
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(Section) + "," + nameof(LineNumber) + "," + nameof(FeeIndex))]
    partial class UCDDetail
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(FeeVarianceFeeType) + "," + nameof(FeeVarianceChargeIndex))]
    partial class FeeVariance
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(ClosingEntityType))]
    partial class ClosingEntity
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(StateCode) + "," + nameof(DisclosureName))]
    partial class AdditionalStateDisclosure
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(LineNumber))]
    partial class RespaHudDetail
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(StateLicenseType))]
    partial class StateLicense
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(AntiSteeringLoanOptionIndex))]
    partial class AntiSteeringLoanOption
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(SecondaryFinancingProviderType))]
    partial class SecondaryFinancingProvider
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(ShippingContactType))]
    partial class ShippingContact
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(NewYorkPrimaryLenderIndex))]
    partial class NewYorkPrimaryLender
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(Hud1EsPayToIndex))]
    partial class Hud1EsPayTo
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(ProfitManagementItemIndex))]
    partial class ProfitManagementItem
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(UsdaHouseholdIncomeIndex))]
    partial class UsdaHouseholdIncome
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(PriceAdjustmentType) + "," + nameof(AdjustmentType), SerializeWholeListWhenDirty = true)]
    partial class PriceAdjustment
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(LineNumber))]
    partial class ExtraPayment
    {
    }

    [Entity(SerializeWholeListWhenDirty = true)]
    partial class ATRQMBorrower
    {
    }

    [Entity(SerializeWholeListWhenDirty = true)]
    partial class AUSTrackingLog
    {
    }

    [Entity(SerializeWholeListWhenDirty = true)]
    partial class Buydown
    {
    }

    [Entity(SerializeWholeListWhenDirty = true)]
    partial class PrepaymentPenalty
    {
    }

    [Entity(SerializeWholeListWhenDirty = true)]
    partial class MilestoneTemplateLog
    {
    }

    [Entity(SerializeWholeListWhenDirty = true)]
    partial class PrequalificationScenario
    {
    }

    [Entity(SerializeWholeListWhenDirty = true)]
    partial class PurchaseCredit
    {
    }

    [Entity(SerializeWholeListWhenDirty = true)]
    partial class LockRequestBorrower
    {
    }

    [Entity(SerializeWholeListWhenDirty = true)]
    partial class PurchaseAdvicePayout
    {
    }

    [Entity(SerializeWholeListWhenDirty = true)]
    partial class SettlementServiceCharge
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(NonVolIndex))]
    partial class NonVol
    {
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(LoanAssociateType))]
    partial class LoanAssociate
    {
        public LoanAssociate(string id, LoanAssociateType loanAssociateType)
            : this(id, loanAssociateType.Validate(nameof(loanAssociateType)).AsString(EnumFormat.EnumMemberValue, EnumFormat.Name))
        {
        }

        public LoanAssociate(string id, string loanAssociateType)
        {
            Preconditions.NotNullOrEmpty(id, nameof(id));
            Preconditions.NotNullOrEmpty(loanAssociateType, nameof(loanAssociateType));

            Id = id;
            LoanAssociateType = loanAssociateType;
        }

        [JsonConstructor]
        public LoanAssociate()
        {
        }
    }
}