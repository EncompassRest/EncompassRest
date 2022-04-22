using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// AntiSteeringLoanOption
/// </summary>
public sealed partial class AntiSteeringLoanOption : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// AntiSteeringLoanOption AntiSteeringLoanOptionIndex
    /// </summary>
    public int? AntiSteeringLoanOptionIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption BrokerCompensationFeeAmount
    /// </summary>
    public decimal? BrokerCompensationFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption BrokerCompensationFeeBorPaidAmount
    /// </summary>
    public decimal? BrokerCompensationFeeBorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption BrokerCompensationFeePercentage
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BrokerCompensationFeePercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption BrokerFeeAmount
    /// </summary>
    public decimal? BrokerFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption BrokerFeeBorPaidAmount
    /// </summary>
    public decimal? BrokerFeeBorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption BrokerFeePercentage
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BrokerFeePercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption BrokerFeeSellerPaidAmount
    /// </summary>
    public decimal? BrokerFeeSellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption CreditorName
    /// </summary>
    public string? CreditorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption DiscountAdditionalAmount
    /// </summary>
    public decimal? DiscountAdditionalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption DiscountAmount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DiscountAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption DiscountFeeBorPaidAmount
    /// </summary>
    public decimal? DiscountFeeBorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption DiscountFeeSellerPaidAmount
    /// </summary>
    public decimal? DiscountFeeSellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption DiscountPercentage
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? DiscountPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption DiscountPoints
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DiscountPoints { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption FixedRatePeriod
    /// </summary>
    public int? FixedRatePeriod { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption HaveDemandFeature
    /// </summary>
    public StringEnumValue<YesOrNo> HaveDemandFeature { get => GetValue<StringEnumValue<YesOrNo>>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption HavePrepaymentPenalty
    /// </summary>
    public bool? HavePrepaymentPenalty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption InspectionFeeBorPaidAmount
    /// </summary>
    public decimal? InspectionFeeBorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption InspectionFeeSellerPaidAmount
    /// </summary>
    public decimal? InspectionFeeSellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption InterestRate
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? InterestRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption IsBalloonPaymentIn7Years
    /// </summary>
    public StringEnumValue<YesOrNo> IsBalloonPaymentIn7Years { get => GetValue<StringEnumValue<YesOrNo>>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption IsInterestOnlyLoan
    /// </summary>
    public StringEnumValue<YesOrNo> IsInterestOnlyLoan { get => GetValue<StringEnumValue<YesOrNo>>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption IsNegativeAmortization
    /// </summary>
    public bool? IsNegativeAmortization { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption LoanTerm
    /// </summary>
    public int? LoanTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Anti-Steering Disclosure - Loan Option 1 - Loan Type [DISCLOSURE.X689]
    /// </summary>
    public StringEnumValue<AmortizationType> LoanType { get => GetValue<StringEnumValue<AmortizationType>>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption OriginationFeeBorPaidAmount
    /// </summary>
    public decimal? OriginationFeeBorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption OriginationFeePercentage
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OriginationFeePercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption OriginationFeeSellerPaidAmount
    /// </summary>
    public decimal? OriginationFeeSellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption OriginationPointsFees
    /// </summary>
    public decimal? OriginationPointsFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption OriginationPointsPercentage
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OriginationPointsPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption ProcessingFeeBorPaidAmount
    /// </summary>
    public decimal? ProcessingFeeBorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption ProcessingFeeSellerPaidAmount
    /// </summary>
    public decimal? ProcessingFeeSellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption TotalOriginationDiscountAmount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOriginationDiscountAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UnderwritingFeeBorPaidAmount
    /// </summary>
    public decimal? UnderwritingFeeBorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UnderwritingFeeSellerPaidAmount
    /// </summary>
    public decimal? UnderwritingFeeSellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UserDefinedFee1BorPaidAmount
    /// </summary>
    public decimal? UserDefinedFee1BorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UserDefinedFee1Description
    /// </summary>
    public string? UserDefinedFee1Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UserDefinedFee1SellerPaidAmount
    /// </summary>
    public decimal? UserDefinedFee1SellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UserDefinedFee2BorPaidAmount
    /// </summary>
    public decimal? UserDefinedFee2BorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UserDefinedFee2Description
    /// </summary>
    public string? UserDefinedFee2Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UserDefinedFee2SellerPaidAmount
    /// </summary>
    public decimal? UserDefinedFee2SellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UserDefinedFee3BorPaidAmount
    /// </summary>
    public decimal? UserDefinedFee3BorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UserDefinedFee3Description
    /// </summary>
    public string? UserDefinedFee3Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UserDefinedFee3SellerPaidAmount
    /// </summary>
    public decimal? UserDefinedFee3SellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UserDefinedFee4BorPaidAmount
    /// </summary>
    public decimal? UserDefinedFee4BorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UserDefinedFee4Description
    /// </summary>
    public string? UserDefinedFee4Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UserDefinedFee4SellerPaidAmount
    /// </summary>
    public decimal? UserDefinedFee4SellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UserDefinedFee5BorPaidAmount
    /// </summary>
    public decimal? UserDefinedFee5BorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UserDefinedFee5Description
    /// </summary>
    public string? UserDefinedFee5Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AntiSteeringLoanOption UserDefinedFee5SellerPaidAmount
    /// </summary>
    public decimal? UserDefinedFee5SellerPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }
}