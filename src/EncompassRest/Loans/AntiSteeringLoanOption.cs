using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class AntiSteeringLoanOption
    {
        public int? AntiSteeringLoanOptionIndex { get; set; }
        public JsonNullable<decimal?> BrokerCompensationFeeAmount { get; set; }
        public JsonNullable<decimal?> BrokerCompensationFeeBorPaidAmount { get; set; }
        public JsonNullable<decimal?> BrokerCompensationFeePercentage { get; set; }
        public JsonNullable<decimal?> BrokerFeeAmount { get; set; }
        public JsonNullable<decimal?> BrokerFeeBorPaidAmount { get; set; }
        public JsonNullable<decimal?> BrokerFeePercentage { get; set; }
        public JsonNullable<decimal?> BrokerFeeSellerPaidAmount { get; set; }
        public string CreditorName { get; set; }
        public JsonNullable<decimal?> DiscountAdditionalAmount { get; set; }
        public JsonNullable<decimal?> DiscountAmount { get; set; }
        public JsonNullable<decimal?> DiscountFeeBorPaidAmount { get; set; }
        public JsonNullable<decimal?> DiscountFeeSellerPaidAmount { get; set; }
        public JsonNullable<decimal?> DiscountPercentage { get; set; }
        public JsonNullable<decimal?> DiscountPoints { get; set; }
        public JsonNullable<int?> FixedRatePeriod { get; set; }
        public string HaveDemandFeature { get; set; }
        public JsonNullable<bool?> HavePrepaymentPenalty { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> InspectionFeeBorPaidAmount { get; set; }
        public JsonNullable<decimal?> InspectionFeeSellerPaidAmount { get; set; }
        public JsonNullable<decimal?> InterestRate { get; set; }
        public string IsBalloonPaymentIn7Years { get; set; }
        public string IsInterestOnlyLoan { get; set; }
        public JsonNullable<bool?> IsNegativeAmortization { get; set; }
        public JsonNullable<int?> LoanTerm { get; set; }
        public string LoanType { get; set; }
        public JsonNullable<decimal?> OriginationFeeBorPaidAmount { get; set; }
        public JsonNullable<decimal?> OriginationFeePercentage { get; set; }
        public JsonNullable<decimal?> OriginationFeeSellerPaidAmount { get; set; }
        public JsonNullable<decimal?> OriginationPointsFees { get; set; }
        public JsonNullable<decimal?> OriginationPointsPercetange { get; set; }
        public JsonNullable<decimal?> ProcessingFeeBorPaidAmount { get; set; }
        public JsonNullable<decimal?> ProcessingFeeSellerPaidAmount { get; set; }
        public JsonNullable<decimal?> TotalOriginationDiscountAmount { get; set; }
        public JsonNullable<decimal?> UnderwritingFeeBorPaidAmount { get; set; }
        public JsonNullable<decimal?> UnderwritingFeeSellerPaidAmount { get; set; }
        public JsonNullable<decimal?> UserDefinedFee1BorPaidAmount { get; set; }
        public string UserDefinedFee1Description { get; set; }
        public JsonNullable<decimal?> UserDefinedFee1SellerPaidAmount { get; set; }
        public JsonNullable<decimal?> UserDefinedFee2BorPaidAmount { get; set; }
        public string UserDefinedFee2Description { get; set; }
        public JsonNullable<decimal?> UserDefinedFee2SellerPaidAmount { get; set; }
        public JsonNullable<decimal?> UserDefinedFee3BorPaidAmount { get; set; }
        public string UserDefinedFee3Description { get; set; }
        public JsonNullable<decimal?> UserDefinedFee3SellerPaidAmount { get; set; }
        public JsonNullable<decimal?> UserDefinedFee4BorPaidAmount { get; set; }
        public string UserDefinedFee4Description { get; set; }
        public JsonNullable<decimal?> UserDefinedFee4SellerPaidAmount { get; set; }
        public JsonNullable<decimal?> UserDefinedFee5BorPaidAmount { get; set; }
        public string UserDefinedFee5Description { get; set; }
        public JsonNullable<decimal?> UserDefinedFee5SellerPaidAmount { get; set; }
    }
}