using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class AntiSteeringLoanOption
    {
        public Value<int?> AntiSteeringLoanOptionIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAntiSteeringLoanOptionIndex() => !AntiSteeringLoanOptionIndex.Clean;
        public Value<decimal?> BrokerCompensationFeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCompensationFeeAmount() => !BrokerCompensationFeeAmount.Clean;
        public Value<decimal?> BrokerCompensationFeeBorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCompensationFeeBorPaidAmount() => !BrokerCompensationFeeBorPaidAmount.Clean;
        public Value<decimal?> BrokerCompensationFeePercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCompensationFeePercentage() => !BrokerCompensationFeePercentage.Clean;
        public Value<decimal?> BrokerFeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFeeAmount() => !BrokerFeeAmount.Clean;
        public Value<decimal?> BrokerFeeBorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFeeBorPaidAmount() => !BrokerFeeBorPaidAmount.Clean;
        public Value<decimal?> BrokerFeePercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFeePercentage() => !BrokerFeePercentage.Clean;
        public Value<decimal?> BrokerFeeSellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFeeSellerPaidAmount() => !BrokerFeeSellerPaidAmount.Clean;
        public Value<string> CreditorName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditorName() => !CreditorName.Clean;
        public Value<decimal?> DiscountAdditionalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountAdditionalAmount() => !DiscountAdditionalAmount.Clean;
        public Value<decimal?> DiscountAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountAmount() => !DiscountAmount.Clean;
        public Value<decimal?> DiscountFeeBorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountFeeBorPaidAmount() => !DiscountFeeBorPaidAmount.Clean;
        public Value<decimal?> DiscountFeeSellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountFeeSellerPaidAmount() => !DiscountFeeSellerPaidAmount.Clean;
        public Value<decimal?> DiscountPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPercentage() => !DiscountPercentage.Clean;
        public Value<decimal?> DiscountPoints { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPoints() => !DiscountPoints.Clean;
        public Value<int?> FixedRatePeriod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFixedRatePeriod() => !FixedRatePeriod.Clean;
        public Value<string> HaveDemandFeature { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHaveDemandFeature() => !HaveDemandFeature.Clean;
        public Value<bool?> HavePrepaymentPenalty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHavePrepaymentPenalty() => !HavePrepaymentPenalty.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> InspectionFeeBorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInspectionFeeBorPaidAmount() => !InspectionFeeBorPaidAmount.Clean;
        public Value<decimal?> InspectionFeeSellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInspectionFeeSellerPaidAmount() => !InspectionFeeSellerPaidAmount.Clean;
        public Value<decimal?> InterestRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRate() => !InterestRate.Clean;
        public Value<string> IsBalloonPaymentIn7Years { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsBalloonPaymentIn7Years() => !IsBalloonPaymentIn7Years.Clean;
        public Value<string> IsInterestOnlyLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsInterestOnlyLoan() => !IsInterestOnlyLoan.Clean;
        public Value<bool?> IsNegativeAmortization { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsNegativeAmortization() => !IsNegativeAmortization.Clean;
        public Value<int?> LoanTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanTerm() => !LoanTerm.Clean;
        public Value<string> LoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanType() => !LoanType.Clean;
        public Value<decimal?> OriginationFeeBorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationFeeBorPaidAmount() => !OriginationFeeBorPaidAmount.Clean;
        public Value<decimal?> OriginationFeePercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationFeePercentage() => !OriginationFeePercentage.Clean;
        public Value<decimal?> OriginationFeeSellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationFeeSellerPaidAmount() => !OriginationFeeSellerPaidAmount.Clean;
        public Value<decimal?> OriginationPointsFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationPointsFees() => !OriginationPointsFees.Clean;
        public Value<decimal?> OriginationPointsPercetange { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationPointsPercetange() => !OriginationPointsPercetange.Clean;
        public Value<decimal?> ProcessingFeeBorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProcessingFeeBorPaidAmount() => !ProcessingFeeBorPaidAmount.Clean;
        public Value<decimal?> ProcessingFeeSellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProcessingFeeSellerPaidAmount() => !ProcessingFeeSellerPaidAmount.Clean;
        public Value<decimal?> TotalOriginationDiscountAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOriginationDiscountAmount() => !TotalOriginationDiscountAmount.Clean;
        public Value<decimal?> UnderwritingFeeBorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingFeeBorPaidAmount() => !UnderwritingFeeBorPaidAmount.Clean;
        public Value<decimal?> UnderwritingFeeSellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingFeeSellerPaidAmount() => !UnderwritingFeeSellerPaidAmount.Clean;
        public Value<decimal?> UserDefinedFee1BorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee1BorPaidAmount() => !UserDefinedFee1BorPaidAmount.Clean;
        public Value<string> UserDefinedFee1Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee1Description() => !UserDefinedFee1Description.Clean;
        public Value<decimal?> UserDefinedFee1SellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee1SellerPaidAmount() => !UserDefinedFee1SellerPaidAmount.Clean;
        public Value<decimal?> UserDefinedFee2BorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee2BorPaidAmount() => !UserDefinedFee2BorPaidAmount.Clean;
        public Value<string> UserDefinedFee2Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee2Description() => !UserDefinedFee2Description.Clean;
        public Value<decimal?> UserDefinedFee2SellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee2SellerPaidAmount() => !UserDefinedFee2SellerPaidAmount.Clean;
        public Value<decimal?> UserDefinedFee3BorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee3BorPaidAmount() => !UserDefinedFee3BorPaidAmount.Clean;
        public Value<string> UserDefinedFee3Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee3Description() => !UserDefinedFee3Description.Clean;
        public Value<decimal?> UserDefinedFee3SellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee3SellerPaidAmount() => !UserDefinedFee3SellerPaidAmount.Clean;
        public Value<decimal?> UserDefinedFee4BorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee4BorPaidAmount() => !UserDefinedFee4BorPaidAmount.Clean;
        public Value<string> UserDefinedFee4Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee4Description() => !UserDefinedFee4Description.Clean;
        public Value<decimal?> UserDefinedFee4SellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee4SellerPaidAmount() => !UserDefinedFee4SellerPaidAmount.Clean;
        public Value<decimal?> UserDefinedFee5BorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee5BorPaidAmount() => !UserDefinedFee5BorPaidAmount.Clean;
        public Value<string> UserDefinedFee5Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee5Description() => !UserDefinedFee5Description.Clean;
        public Value<decimal?> UserDefinedFee5SellerPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedFee5SellerPaidAmount() => !UserDefinedFee5SellerPaidAmount.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AntiSteeringLoanOptionIndex.Clean
                    && BrokerCompensationFeeAmount.Clean
                    && BrokerCompensationFeeBorPaidAmount.Clean
                    && BrokerCompensationFeePercentage.Clean
                    && BrokerFeeAmount.Clean
                    && BrokerFeeBorPaidAmount.Clean
                    && BrokerFeePercentage.Clean
                    && BrokerFeeSellerPaidAmount.Clean
                    && CreditorName.Clean
                    && DiscountAdditionalAmount.Clean
                    && DiscountAmount.Clean
                    && DiscountFeeBorPaidAmount.Clean
                    && DiscountFeeSellerPaidAmount.Clean
                    && DiscountPercentage.Clean
                    && DiscountPoints.Clean
                    && FixedRatePeriod.Clean
                    && HaveDemandFeature.Clean
                    && HavePrepaymentPenalty.Clean
                    && Id.Clean
                    && InspectionFeeBorPaidAmount.Clean
                    && InspectionFeeSellerPaidAmount.Clean
                    && InterestRate.Clean
                    && IsBalloonPaymentIn7Years.Clean
                    && IsInterestOnlyLoan.Clean
                    && IsNegativeAmortization.Clean
                    && LoanTerm.Clean
                    && LoanType.Clean
                    && OriginationFeeBorPaidAmount.Clean
                    && OriginationFeePercentage.Clean
                    && OriginationFeeSellerPaidAmount.Clean
                    && OriginationPointsFees.Clean
                    && OriginationPointsPercetange.Clean
                    && ProcessingFeeBorPaidAmount.Clean
                    && ProcessingFeeSellerPaidAmount.Clean
                    && TotalOriginationDiscountAmount.Clean
                    && UnderwritingFeeBorPaidAmount.Clean
                    && UnderwritingFeeSellerPaidAmount.Clean
                    && UserDefinedFee1BorPaidAmount.Clean
                    && UserDefinedFee1Description.Clean
                    && UserDefinedFee1SellerPaidAmount.Clean
                    && UserDefinedFee2BorPaidAmount.Clean
                    && UserDefinedFee2Description.Clean
                    && UserDefinedFee2SellerPaidAmount.Clean
                    && UserDefinedFee3BorPaidAmount.Clean
                    && UserDefinedFee3Description.Clean
                    && UserDefinedFee3SellerPaidAmount.Clean
                    && UserDefinedFee4BorPaidAmount.Clean
                    && UserDefinedFee4Description.Clean
                    && UserDefinedFee4SellerPaidAmount.Clean
                    && UserDefinedFee5BorPaidAmount.Clean
                    && UserDefinedFee5Description.Clean
                    && UserDefinedFee5SellerPaidAmount.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AntiSteeringLoanOptionIndex; v0.Clean = value; AntiSteeringLoanOptionIndex = v0;
                var v1 = BrokerCompensationFeeAmount; v1.Clean = value; BrokerCompensationFeeAmount = v1;
                var v2 = BrokerCompensationFeeBorPaidAmount; v2.Clean = value; BrokerCompensationFeeBorPaidAmount = v2;
                var v3 = BrokerCompensationFeePercentage; v3.Clean = value; BrokerCompensationFeePercentage = v3;
                var v4 = BrokerFeeAmount; v4.Clean = value; BrokerFeeAmount = v4;
                var v5 = BrokerFeeBorPaidAmount; v5.Clean = value; BrokerFeeBorPaidAmount = v5;
                var v6 = BrokerFeePercentage; v6.Clean = value; BrokerFeePercentage = v6;
                var v7 = BrokerFeeSellerPaidAmount; v7.Clean = value; BrokerFeeSellerPaidAmount = v7;
                var v8 = CreditorName; v8.Clean = value; CreditorName = v8;
                var v9 = DiscountAdditionalAmount; v9.Clean = value; DiscountAdditionalAmount = v9;
                var v10 = DiscountAmount; v10.Clean = value; DiscountAmount = v10;
                var v11 = DiscountFeeBorPaidAmount; v11.Clean = value; DiscountFeeBorPaidAmount = v11;
                var v12 = DiscountFeeSellerPaidAmount; v12.Clean = value; DiscountFeeSellerPaidAmount = v12;
                var v13 = DiscountPercentage; v13.Clean = value; DiscountPercentage = v13;
                var v14 = DiscountPoints; v14.Clean = value; DiscountPoints = v14;
                var v15 = FixedRatePeriod; v15.Clean = value; FixedRatePeriod = v15;
                var v16 = HaveDemandFeature; v16.Clean = value; HaveDemandFeature = v16;
                var v17 = HavePrepaymentPenalty; v17.Clean = value; HavePrepaymentPenalty = v17;
                var v18 = Id; v18.Clean = value; Id = v18;
                var v19 = InspectionFeeBorPaidAmount; v19.Clean = value; InspectionFeeBorPaidAmount = v19;
                var v20 = InspectionFeeSellerPaidAmount; v20.Clean = value; InspectionFeeSellerPaidAmount = v20;
                var v21 = InterestRate; v21.Clean = value; InterestRate = v21;
                var v22 = IsBalloonPaymentIn7Years; v22.Clean = value; IsBalloonPaymentIn7Years = v22;
                var v23 = IsInterestOnlyLoan; v23.Clean = value; IsInterestOnlyLoan = v23;
                var v24 = IsNegativeAmortization; v24.Clean = value; IsNegativeAmortization = v24;
                var v25 = LoanTerm; v25.Clean = value; LoanTerm = v25;
                var v26 = LoanType; v26.Clean = value; LoanType = v26;
                var v27 = OriginationFeeBorPaidAmount; v27.Clean = value; OriginationFeeBorPaidAmount = v27;
                var v28 = OriginationFeePercentage; v28.Clean = value; OriginationFeePercentage = v28;
                var v29 = OriginationFeeSellerPaidAmount; v29.Clean = value; OriginationFeeSellerPaidAmount = v29;
                var v30 = OriginationPointsFees; v30.Clean = value; OriginationPointsFees = v30;
                var v31 = OriginationPointsPercetange; v31.Clean = value; OriginationPointsPercetange = v31;
                var v32 = ProcessingFeeBorPaidAmount; v32.Clean = value; ProcessingFeeBorPaidAmount = v32;
                var v33 = ProcessingFeeSellerPaidAmount; v33.Clean = value; ProcessingFeeSellerPaidAmount = v33;
                var v34 = TotalOriginationDiscountAmount; v34.Clean = value; TotalOriginationDiscountAmount = v34;
                var v35 = UnderwritingFeeBorPaidAmount; v35.Clean = value; UnderwritingFeeBorPaidAmount = v35;
                var v36 = UnderwritingFeeSellerPaidAmount; v36.Clean = value; UnderwritingFeeSellerPaidAmount = v36;
                var v37 = UserDefinedFee1BorPaidAmount; v37.Clean = value; UserDefinedFee1BorPaidAmount = v37;
                var v38 = UserDefinedFee1Description; v38.Clean = value; UserDefinedFee1Description = v38;
                var v39 = UserDefinedFee1SellerPaidAmount; v39.Clean = value; UserDefinedFee1SellerPaidAmount = v39;
                var v40 = UserDefinedFee2BorPaidAmount; v40.Clean = value; UserDefinedFee2BorPaidAmount = v40;
                var v41 = UserDefinedFee2Description; v41.Clean = value; UserDefinedFee2Description = v41;
                var v42 = UserDefinedFee2SellerPaidAmount; v42.Clean = value; UserDefinedFee2SellerPaidAmount = v42;
                var v43 = UserDefinedFee3BorPaidAmount; v43.Clean = value; UserDefinedFee3BorPaidAmount = v43;
                var v44 = UserDefinedFee3Description; v44.Clean = value; UserDefinedFee3Description = v44;
                var v45 = UserDefinedFee3SellerPaidAmount; v45.Clean = value; UserDefinedFee3SellerPaidAmount = v45;
                var v46 = UserDefinedFee4BorPaidAmount; v46.Clean = value; UserDefinedFee4BorPaidAmount = v46;
                var v47 = UserDefinedFee4Description; v47.Clean = value; UserDefinedFee4Description = v47;
                var v48 = UserDefinedFee4SellerPaidAmount; v48.Clean = value; UserDefinedFee4SellerPaidAmount = v48;
                var v49 = UserDefinedFee5BorPaidAmount; v49.Clean = value; UserDefinedFee5BorPaidAmount = v49;
                var v50 = UserDefinedFee5Description; v50.Clean = value; UserDefinedFee5Description = v50;
                var v51 = UserDefinedFee5SellerPaidAmount; v51.Clean = value; UserDefinedFee5SellerPaidAmount = v51;
                _settingClean = 0;
            }
        }
    }
}