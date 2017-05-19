using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class AntiSteeringLoanOption
    {
        public int? AntiSteeringLoanOptionIndex { get; set; }
        public string CreditorName { get; set; }
        public string LoanType { get; set; }
        public int? LoanTerm { get; set; }
        public decimal? InterestRate { get; set; }
        public int? FixedRatePeriod { get; set; }
        public decimal? OriginationPointsPercetange { get; set; }
        public decimal? OriginationPointsFees { get; set; }
        public decimal? DiscountPoints { get; set; }
        public bool? IsNegativeAmortization { get; set; }
        public bool? HavePrepaymentPenalty { get; set; }
        public string IsInterestOnlyLoan { get; set; }
        public string IsBalloonPaymentIn7Years { get; set; }
        public string HaveDemandFeature { get; set; }
        public decimal? DiscountAdditionalAmount { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? TotalOriginationDiscountAmount { get; set; }
        public decimal? OriginationFeePercentage { get; set; }
        public decimal? OriginationFeeBorPaidAmount { get; set; }
        public decimal? OriginationFeeSellerPaidAmount { get; set; }
        public decimal? InspectionFeeBorPaidAmount { get; set; }
        public decimal? InspectionFeeSellerPaidAmount { get; set; }
        public decimal? ProcessingFeeBorPaidAmount { get; set; }
        public decimal? ProcessingFeeSellerPaidAmount { get; set; }
        public decimal? UnderwritingFeeBorPaidAmount { get; set; }
        public decimal? UnderwritingFeeSellerPaidAmount { get; set; }
        public decimal? BrokerFeePercentage { get; set; }
        public decimal? BrokerFeeAmount { get; set; }
        public decimal? BrokerFeeBorPaidAmount { get; set; }
        public decimal? BrokerFeeSellerPaidAmount { get; set; }
        public decimal? BrokerCompensationFeePercentage { get; set; }
        public decimal? BrokerCompensationFeeAmount { get; set; }
        public decimal? BrokerCompensationFeeBorPaidAmount { get; set; }
        public string UserDefinedFee1Description { get; set; }
        public decimal? UserDefinedFee1BorPaidAmount { get; set; }
        public decimal? UserDefinedFee1SellerPaidAmount { get; set; }
        public string UserDefinedFee2Description { get; set; }
        public decimal? UserDefinedFee2BorPaidAmount { get; set; }
        public decimal? UserDefinedFee2SellerPaidAmount { get; set; }
        public string UserDefinedFee3Description { get; set; }
        public decimal? UserDefinedFee3BorPaidAmount { get; set; }
        public decimal? UserDefinedFee3SellerPaidAmount { get; set; }
        public string UserDefinedFee4Description { get; set; }
        public decimal? UserDefinedFee4BorPaidAmount { get; set; }
        public decimal? UserDefinedFee4SellerPaidAmount { get; set; }
        public string UserDefinedFee5Description { get; set; }
        public decimal? UserDefinedFee5BorPaidAmount { get; set; }
        public decimal? UserDefinedFee5SellerPaidAmount { get; set; }
        public decimal? DiscountFeeBorPaidAmount { get; set; }
        public decimal? DiscountFeeSellerPaidAmount { get; set; }
        public string Id { get; set; }
    }
}