
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class AntiSteeringLoanOption
{
public int? antiSteeringLoanOptionIndex { get; set; }
public string creditorName { get; set; }
public string loanType { get; set; }
public int? loanTerm { get; set; }
public decimal? interestRate { get; set; }
public int? fixedRatePeriod { get; set; }
public decimal? originationPointsPercetange { get; set; }
public decimal? originationPointsFees { get; set; }
public decimal? discountPoints { get; set; }
public bool? isNegativeAmortization { get; set; }
public bool? havePrepaymentPenalty { get; set; }
public string isInterestOnlyLoan { get; set; }
public string isBalloonPaymentIn7Years { get; set; }
public string haveDemandFeature { get; set; }
public decimal? discountAdditionalAmount { get; set; }
public decimal? discountPercentage { get; set; }
public decimal? discountAmount { get; set; }
public decimal? totalOriginationDiscountAmount { get; set; }
public decimal? originationFeePercentage { get; set; }
public decimal? originationFeeBorPaidAmount { get; set; }
public decimal? originationFeeSellerPaidAmount { get; set; }
public decimal? inspectionFeeBorPaidAmount { get; set; }
public decimal? inspectionFeeSellerPaidAmount { get; set; }
public decimal? processingFeeBorPaidAmount { get; set; }
public decimal? processingFeeSellerPaidAmount { get; set; }
public decimal? underwritingFeeBorPaidAmount { get; set; }
public decimal? underwritingFeeSellerPaidAmount { get; set; }
public decimal? brokerFeePercentage { get; set; }
public decimal? brokerFeeAmount { get; set; }
public decimal? brokerFeeBorPaidAmount { get; set; }
public decimal? brokerFeeSellerPaidAmount { get; set; }
public decimal? brokerCompensationFeePercentage { get; set; }
public decimal? brokerCompensationFeeAmount { get; set; }
public decimal? brokerCompensationFeeBorPaidAmount { get; set; }
public string userDefinedFee1Description { get; set; }
public decimal? userDefinedFee1BorPaidAmount { get; set; }
public decimal? userDefinedFee1SellerPaidAmount { get; set; }
public string userDefinedFee2Description { get; set; }
public decimal? userDefinedFee2BorPaidAmount { get; set; }
public decimal? userDefinedFee2SellerPaidAmount { get; set; }
public string userDefinedFee3Description { get; set; }
public decimal? userDefinedFee3BorPaidAmount { get; set; }
public decimal? userDefinedFee3SellerPaidAmount { get; set; }
public string userDefinedFee4Description { get; set; }
public decimal? userDefinedFee4BorPaidAmount { get; set; }
public decimal? userDefinedFee4SellerPaidAmount { get; set; }
public string userDefinedFee5Description { get; set; }
public decimal? userDefinedFee5BorPaidAmount { get; set; }
public decimal? userDefinedFee5SellerPaidAmount { get; set; }
public decimal? discountFeeBorPaidAmount { get; set; }
public decimal? discountFeeSellerPaidAmount { get; set; }
public string id { get; set; }

    }
}