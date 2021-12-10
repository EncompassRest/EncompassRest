using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// AntiSteeringLoanOption
/// </summary>
public sealed partial class AntiSteeringLoanOption : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<int?>? _antiSteeringLoanOptionIndex;
    private DirtyValue<decimal?>? _brokerCompensationFeeAmount;
    private DirtyValue<decimal?>? _brokerCompensationFeeBorPaidAmount;
    private DirtyValue<decimal?>? _brokerCompensationFeePercentage;
    private DirtyValue<decimal?>? _brokerFeeAmount;
    private DirtyValue<decimal?>? _brokerFeeBorPaidAmount;
    private DirtyValue<decimal?>? _brokerFeePercentage;
    private DirtyValue<decimal?>? _brokerFeeSellerPaidAmount;
    private DirtyValue<string?>? _creditorName;
    private DirtyValue<decimal?>? _discountAdditionalAmount;
    private DirtyValue<decimal?>? _discountAmount;
    private DirtyValue<decimal?>? _discountFeeBorPaidAmount;
    private DirtyValue<decimal?>? _discountFeeSellerPaidAmount;
    private DirtyValue<decimal?>? _discountPercentage;
    private DirtyValue<decimal?>? _discountPoints;
    private DirtyValue<int?>? _fixedRatePeriod;
    private DirtyValue<StringEnumValue<YesOrNo>>? _haveDemandFeature;
    private DirtyValue<bool?>? _havePrepaymentPenalty;
    private DirtyValue<decimal?>? _inspectionFeeBorPaidAmount;
    private DirtyValue<decimal?>? _inspectionFeeSellerPaidAmount;
    private DirtyValue<decimal?>? _interestRate;
    private DirtyValue<StringEnumValue<YesOrNo>>? _isBalloonPaymentIn7Years;
    private DirtyValue<StringEnumValue<YesOrNo>>? _isInterestOnlyLoan;
    private DirtyValue<bool?>? _isNegativeAmortization;
    private DirtyValue<int?>? _loanTerm;
    private DirtyValue<StringEnumValue<AmortizationType>>? _loanType;
    private DirtyValue<decimal?>? _originationFeeBorPaidAmount;
    private DirtyValue<decimal?>? _originationFeePercentage;
    private DirtyValue<decimal?>? _originationFeeSellerPaidAmount;
    private DirtyValue<decimal?>? _originationPointsFees;
    private DirtyValue<decimal?>? _originationPointsPercentage;
    private DirtyValue<decimal?>? _processingFeeBorPaidAmount;
    private DirtyValue<decimal?>? _processingFeeSellerPaidAmount;
    private DirtyValue<decimal?>? _totalOriginationDiscountAmount;
    private DirtyValue<decimal?>? _underwritingFeeBorPaidAmount;
    private DirtyValue<decimal?>? _underwritingFeeSellerPaidAmount;
    private DirtyValue<decimal?>? _userDefinedFee1BorPaidAmount;
    private DirtyValue<string?>? _userDefinedFee1Description;
    private DirtyValue<decimal?>? _userDefinedFee1SellerPaidAmount;
    private DirtyValue<decimal?>? _userDefinedFee2BorPaidAmount;
    private DirtyValue<string?>? _userDefinedFee2Description;
    private DirtyValue<decimal?>? _userDefinedFee2SellerPaidAmount;
    private DirtyValue<decimal?>? _userDefinedFee3BorPaidAmount;
    private DirtyValue<string?>? _userDefinedFee3Description;
    private DirtyValue<decimal?>? _userDefinedFee3SellerPaidAmount;
    private DirtyValue<decimal?>? _userDefinedFee4BorPaidAmount;
    private DirtyValue<string?>? _userDefinedFee4Description;
    private DirtyValue<decimal?>? _userDefinedFee4SellerPaidAmount;
    private DirtyValue<decimal?>? _userDefinedFee5BorPaidAmount;
    private DirtyValue<string?>? _userDefinedFee5Description;
    private DirtyValue<decimal?>? _userDefinedFee5SellerPaidAmount;

    /// <summary>
    /// AntiSteeringLoanOptionContract AntiSteeringLoanOptionIndex
    /// </summary>
    public int? AntiSteeringLoanOptionIndex { get => _antiSteeringLoanOptionIndex; set => SetField(ref _antiSteeringLoanOptionIndex, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract BrokerCompensationFeeAmount
    /// </summary>
    public decimal? BrokerCompensationFeeAmount { get => _brokerCompensationFeeAmount; set => SetField(ref _brokerCompensationFeeAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract BrokerCompensationFeeBorPaidAmount
    /// </summary>
    public decimal? BrokerCompensationFeeBorPaidAmount { get => _brokerCompensationFeeBorPaidAmount; set => SetField(ref _brokerCompensationFeeBorPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract BrokerCompensationFeePercentage
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BrokerCompensationFeePercentage { get => _brokerCompensationFeePercentage; set => SetField(ref _brokerCompensationFeePercentage, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract BrokerFeeAmount
    /// </summary>
    public decimal? BrokerFeeAmount { get => _brokerFeeAmount; set => SetField(ref _brokerFeeAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract BrokerFeeBorPaidAmount
    /// </summary>
    public decimal? BrokerFeeBorPaidAmount { get => _brokerFeeBorPaidAmount; set => SetField(ref _brokerFeeBorPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract BrokerFeePercentage
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BrokerFeePercentage { get => _brokerFeePercentage; set => SetField(ref _brokerFeePercentage, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract BrokerFeeSellerPaidAmount
    /// </summary>
    public decimal? BrokerFeeSellerPaidAmount { get => _brokerFeeSellerPaidAmount; set => SetField(ref _brokerFeeSellerPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract CreditorName
    /// </summary>
    public string? CreditorName { get => _creditorName; set => SetField(ref _creditorName, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract DiscountAdditionalAmount
    /// </summary>
    public decimal? DiscountAdditionalAmount { get => _discountAdditionalAmount; set => SetField(ref _discountAdditionalAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract DiscountAmount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DiscountAmount { get => _discountAmount; set => SetField(ref _discountAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract DiscountFeeBorPaidAmount
    /// </summary>
    public decimal? DiscountFeeBorPaidAmount { get => _discountFeeBorPaidAmount; set => SetField(ref _discountFeeBorPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract DiscountFeeSellerPaidAmount
    /// </summary>
    public decimal? DiscountFeeSellerPaidAmount { get => _discountFeeSellerPaidAmount; set => SetField(ref _discountFeeSellerPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract DiscountPercentage
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? DiscountPercentage { get => _discountPercentage; set => SetField(ref _discountPercentage, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract DiscountPoints
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DiscountPoints { get => _discountPoints; set => SetField(ref _discountPoints, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract FixedRatePeriod
    /// </summary>
    public int? FixedRatePeriod { get => _fixedRatePeriod; set => SetField(ref _fixedRatePeriod, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract HaveDemandFeature
    /// </summary>
    public StringEnumValue<YesOrNo> HaveDemandFeature { get => _haveDemandFeature; set => SetField(ref _haveDemandFeature, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract HavePrepaymentPenalty
    /// </summary>
    public bool? HavePrepaymentPenalty { get => _havePrepaymentPenalty; set => SetField(ref _havePrepaymentPenalty, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract InspectionFeeBorPaidAmount
    /// </summary>
    public decimal? InspectionFeeBorPaidAmount { get => _inspectionFeeBorPaidAmount; set => SetField(ref _inspectionFeeBorPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract InspectionFeeSellerPaidAmount
    /// </summary>
    public decimal? InspectionFeeSellerPaidAmount { get => _inspectionFeeSellerPaidAmount; set => SetField(ref _inspectionFeeSellerPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract InterestRate
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? InterestRate { get => _interestRate; set => SetField(ref _interestRate, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract IsBalloonPaymentIn7Years
    /// </summary>
    public StringEnumValue<YesOrNo> IsBalloonPaymentIn7Years { get => _isBalloonPaymentIn7Years; set => SetField(ref _isBalloonPaymentIn7Years, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract IsInterestOnlyLoan
    /// </summary>
    public StringEnumValue<YesOrNo> IsInterestOnlyLoan { get => _isInterestOnlyLoan; set => SetField(ref _isInterestOnlyLoan, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract IsNegativeAmortization
    /// </summary>
    public bool? IsNegativeAmortization { get => _isNegativeAmortization; set => SetField(ref _isNegativeAmortization, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract LoanTerm
    /// </summary>
    public int? LoanTerm { get => _loanTerm; set => SetField(ref _loanTerm, value); }

    /// <summary>
    /// Anti-Steering Disclosure - Loan Option 1 - Loan Type [DISCLOSURE.X689]
    /// </summary>
    public StringEnumValue<AmortizationType> LoanType { get => _loanType; set => SetField(ref _loanType, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract OriginationFeeBorPaidAmount
    /// </summary>
    public decimal? OriginationFeeBorPaidAmount { get => _originationFeeBorPaidAmount; set => SetField(ref _originationFeeBorPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract OriginationFeePercentage
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OriginationFeePercentage { get => _originationFeePercentage; set => SetField(ref _originationFeePercentage, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract OriginationFeeSellerPaidAmount
    /// </summary>
    public decimal? OriginationFeeSellerPaidAmount { get => _originationFeeSellerPaidAmount; set => SetField(ref _originationFeeSellerPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract OriginationPointsFees
    /// </summary>
    public decimal? OriginationPointsFees { get => _originationPointsFees; set => SetField(ref _originationPointsFees, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract OriginationPointsPercentage
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OriginationPointsPercentage { get => _originationPointsPercentage; set => SetField(ref _originationPointsPercentage, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract ProcessingFeeBorPaidAmount
    /// </summary>
    public decimal? ProcessingFeeBorPaidAmount { get => _processingFeeBorPaidAmount; set => SetField(ref _processingFeeBorPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract ProcessingFeeSellerPaidAmount
    /// </summary>
    public decimal? ProcessingFeeSellerPaidAmount { get => _processingFeeSellerPaidAmount; set => SetField(ref _processingFeeSellerPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract TotalOriginationDiscountAmount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOriginationDiscountAmount { get => _totalOriginationDiscountAmount; set => SetField(ref _totalOriginationDiscountAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UnderwritingFeeBorPaidAmount
    /// </summary>
    public decimal? UnderwritingFeeBorPaidAmount { get => _underwritingFeeBorPaidAmount; set => SetField(ref _underwritingFeeBorPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UnderwritingFeeSellerPaidAmount
    /// </summary>
    public decimal? UnderwritingFeeSellerPaidAmount { get => _underwritingFeeSellerPaidAmount; set => SetField(ref _underwritingFeeSellerPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UserDefinedFee1BorPaidAmount
    /// </summary>
    public decimal? UserDefinedFee1BorPaidAmount { get => _userDefinedFee1BorPaidAmount; set => SetField(ref _userDefinedFee1BorPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UserDefinedFee1Description
    /// </summary>
    public string? UserDefinedFee1Description { get => _userDefinedFee1Description; set => SetField(ref _userDefinedFee1Description, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UserDefinedFee1SellerPaidAmount
    /// </summary>
    public decimal? UserDefinedFee1SellerPaidAmount { get => _userDefinedFee1SellerPaidAmount; set => SetField(ref _userDefinedFee1SellerPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UserDefinedFee2BorPaidAmount
    /// </summary>
    public decimal? UserDefinedFee2BorPaidAmount { get => _userDefinedFee2BorPaidAmount; set => SetField(ref _userDefinedFee2BorPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UserDefinedFee2Description
    /// </summary>
    public string? UserDefinedFee2Description { get => _userDefinedFee2Description; set => SetField(ref _userDefinedFee2Description, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UserDefinedFee2SellerPaidAmount
    /// </summary>
    public decimal? UserDefinedFee2SellerPaidAmount { get => _userDefinedFee2SellerPaidAmount; set => SetField(ref _userDefinedFee2SellerPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UserDefinedFee3BorPaidAmount
    /// </summary>
    public decimal? UserDefinedFee3BorPaidAmount { get => _userDefinedFee3BorPaidAmount; set => SetField(ref _userDefinedFee3BorPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UserDefinedFee3Description
    /// </summary>
    public string? UserDefinedFee3Description { get => _userDefinedFee3Description; set => SetField(ref _userDefinedFee3Description, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UserDefinedFee3SellerPaidAmount
    /// </summary>
    public decimal? UserDefinedFee3SellerPaidAmount { get => _userDefinedFee3SellerPaidAmount; set => SetField(ref _userDefinedFee3SellerPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UserDefinedFee4BorPaidAmount
    /// </summary>
    public decimal? UserDefinedFee4BorPaidAmount { get => _userDefinedFee4BorPaidAmount; set => SetField(ref _userDefinedFee4BorPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UserDefinedFee4Description
    /// </summary>
    public string? UserDefinedFee4Description { get => _userDefinedFee4Description; set => SetField(ref _userDefinedFee4Description, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UserDefinedFee4SellerPaidAmount
    /// </summary>
    public decimal? UserDefinedFee4SellerPaidAmount { get => _userDefinedFee4SellerPaidAmount; set => SetField(ref _userDefinedFee4SellerPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UserDefinedFee5BorPaidAmount
    /// </summary>
    public decimal? UserDefinedFee5BorPaidAmount { get => _userDefinedFee5BorPaidAmount; set => SetField(ref _userDefinedFee5BorPaidAmount, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UserDefinedFee5Description
    /// </summary>
    public string? UserDefinedFee5Description { get => _userDefinedFee5Description; set => SetField(ref _userDefinedFee5Description, value); }

    /// <summary>
    /// AntiSteeringLoanOptionContract UserDefinedFee5SellerPaidAmount
    /// </summary>
    public decimal? UserDefinedFee5SellerPaidAmount { get => _userDefinedFee5SellerPaidAmount; set => SetField(ref _userDefinedFee5SellerPaidAmount, value); }
}