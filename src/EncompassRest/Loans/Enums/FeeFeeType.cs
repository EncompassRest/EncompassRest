using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FeeFeeType
    /// </summary>
    public enum FeeFeeType
    {
        /// <summary>
        /// Undefined
        /// </summary>
        Undefined = 0,
        /// <summary>
        /// AppraisalFee
        /// </summary>
        AppraisalFee = 1,
        /// <summary>
        /// AssumptionFee
        /// </summary>
        AssumptionFee = 2,
        /// <summary>
        /// AttorneyFee
        /// </summary>
        AttorneyFee = 3,
        /// <summary>
        /// City_CountyTax_Stamps
        /// </summary>
        [EnumMember(Value = "City_CountyTax_Stamps")]
        CityCountyTaxStamps = 4,
        /// <summary>
        /// ClosingFee
        /// </summary>
        ClosingFee = 5,
        /// <summary>
        /// CommissionPaid
        /// </summary>
        CommissionPaid = 6,
        /// <summary>
        /// CountyPropertyTaxes
        /// </summary>
        CountyPropertyTaxes = 7,
        /// <summary>
        /// CreditReportFee
        /// </summary>
        CreditReportFee = 8,
        /// <summary>
        /// DocPrepFee
        /// </summary>
        DocPrepFee = 9,
        /// <summary>
        /// FloodInsurance
        /// </summary>
        FloodInsurance = 10,
        /// <summary>
        /// FloodInsuranceReserv
        /// </summary>
        FloodInsuranceReserv = 11,
        /// <summary>
        /// GuaranteeFee
        /// </summary>
        GuaranteeFee = 12,
        /// <summary>
        /// HazardInsurance
        /// </summary>
        HazardInsurance = 13,
        /// <summary>
        /// HazardInsurancePremium
        /// </summary>
        HazardInsurancePremium = 14,
        /// <summary>
        /// LendersInspectionFee
        /// </summary>
        LendersInspectionFee = 15,
        /// <summary>
        /// LoanDiscountFee
        /// </summary>
        LoanDiscountFee = 16,
        /// <summary>
        /// LoanOriginationFee
        /// </summary>
        LoanOriginationFee = 17,
        /// <summary>
        /// MortgageBrokerFee
        /// </summary>
        MortgageBrokerFee = 18,
        /// <summary>
        /// MortgageInspectionFee
        /// </summary>
        MortgageInspectionFee = 19,
        /// <summary>
        /// MortgageInsurance
        /// </summary>
        MortgageInsurance = 20,
        /// <summary>
        /// MortgageInsurancePremium
        /// </summary>
        MortgageInsurancePremium = 21,
        /// <summary>
        /// NotaryFee
        /// </summary>
        NotaryFee = 22,
        /// <summary>
        /// PestInspection
        /// </summary>
        PestInspection = 23,
        /// <summary>
        /// PrepaidInterest
        /// </summary>
        PrepaidInterest = 24,
        /// <summary>
        /// ProcessingFee
        /// </summary>
        ProcessingFee = 25,
        /// <summary>
        /// PropertyTaxes
        /// </summary>
        PropertyTaxes = 26,
        /// <summary>
        /// RecordingFee
        /// </summary>
        RecordingFee = 27,
        /// <summary>
        /// SchoolTaxes
        /// </summary>
        SchoolTaxes = 28,
        /// <summary>
        /// StateTax_Stamps
        /// </summary>
        [EnumMember(Value = "StateTax_Stamps")]
        StateTaxStamps = 29,
        /// <summary>
        /// SurveyFee
        /// </summary>
        SurveyFee = 30,
        /// <summary>
        /// TaxServiceFee
        /// </summary>
        TaxServiceFee = 31,
        /// <summary>
        /// TitleBinder
        /// </summary>
        TitleBinder = 32,
        /// <summary>
        /// TitleExamination
        /// </summary>
        TitleExamination = 33,
        /// <summary>
        /// TitleInsurance
        /// </summary>
        TitleInsurance = 34,
        /// <summary>
        /// TitleSearch
        /// </summary>
        TitleSearch = 35,
        /// <summary>
        /// UnderwritingFee
        /// </summary>
        UnderwritingFee = 36,
        /// <summary>
        /// UserDefined_1006
        /// </summary>
        [EnumMember(Value = "UserDefined_1006")]
        UserDefined1006 = 37,
        /// <summary>
        /// UserDefined_1007
        /// </summary>
        [EnumMember(Value = "UserDefined_1007")]
        UserDefined1007 = 38,
        /// <summary>
        /// UserDefined_1008
        /// </summary>
        [EnumMember(Value = "UserDefined_1008")]
        UserDefined1008 = 39,
        /// <summary>
        /// UserDefined_1010
        /// </summary>
        [EnumMember(Value = "UserDefined_1010")]
        UserDefined1010 = 40,
        /// <summary>
        /// UserDefined_1109
        /// </summary>
        [EnumMember(Value = "UserDefined_1109")]
        UserDefined1109 = 41,
        /// <summary>
        /// UserDefined_1110
        /// </summary>
        [EnumMember(Value = "UserDefined_1110")]
        UserDefined1110 = 42,
        /// <summary>
        /// UserDefined_1111
        /// </summary>
        [EnumMember(Value = "UserDefined_1111")]
        UserDefined1111 = 43,
        /// <summary>
        /// UserDefined_1112
        /// </summary>
        [EnumMember(Value = "UserDefined_1112")]
        UserDefined1112 = 44,
        /// <summary>
        /// UserDefined_1113
        /// </summary>
        [EnumMember(Value = "UserDefined_1113")]
        UserDefined1113 = 45,
        /// <summary>
        /// UserDefined_1114
        /// </summary>
        [EnumMember(Value = "UserDefined_1114")]
        UserDefined1114 = 46,
        /// <summary>
        /// UserDefined_1115
        /// </summary>
        [EnumMember(Value = "UserDefined_1115")]
        UserDefined1115 = 47,
        /// <summary>
        /// UserDefined_1116
        /// </summary>
        [EnumMember(Value = "UserDefined_1116")]
        UserDefined1116 = 48,
        /// <summary>
        /// UserDefined_1204
        /// </summary>
        [EnumMember(Value = "UserDefined_1204")]
        UserDefined1204 = 49,
        /// <summary>
        /// UserDefined_1205
        /// </summary>
        [EnumMember(Value = "UserDefined_1205")]
        UserDefined1205 = 50,
        /// <summary>
        /// UserDefined_1206
        /// </summary>
        [EnumMember(Value = "UserDefined_1206")]
        UserDefined1206 = 51,
        /// <summary>
        /// UserDefined_1209
        /// </summary>
        [EnumMember(Value = "UserDefined_1209")]
        UserDefined1209 = 52,
        /// <summary>
        /// UserDefined_1210
        /// </summary>
        [EnumMember(Value = "UserDefined_1210")]
        UserDefined1210 = 53,
        /// <summary>
        /// UserDefined_1303
        /// </summary>
        [EnumMember(Value = "UserDefined_1303")]
        UserDefined1303 = 54,
        /// <summary>
        /// UserDefined_1304
        /// </summary>
        [EnumMember(Value = "UserDefined_1304")]
        UserDefined1304 = 55,
        /// <summary>
        /// UserDefined_1305
        /// </summary>
        [EnumMember(Value = "UserDefined_1305")]
        UserDefined1305 = 56,
        /// <summary>
        /// UserDefined_1306
        /// </summary>
        [EnumMember(Value = "UserDefined_1306")]
        UserDefined1306 = 57,
        /// <summary>
        /// UserDefined_1307
        /// </summary>
        [EnumMember(Value = "UserDefined_1307")]
        UserDefined1307 = 58,
        /// <summary>
        /// UserDefined_1308
        /// </summary>
        [EnumMember(Value = "UserDefined_1308")]
        UserDefined1308 = 59,
        /// <summary>
        /// UserDefined_1309
        /// </summary>
        [EnumMember(Value = "UserDefined_1309")]
        UserDefined1309 = 60,
        /// <summary>
        /// UserDefined_906
        /// </summary>
        [EnumMember(Value = "UserDefined_906")]
        UserDefined906 = 61,
        /// <summary>
        /// UserDefined_907
        /// </summary>
        [EnumMember(Value = "UserDefined_907")]
        UserDefined907 = 62,
        /// <summary>
        /// UserDefinedFee_701
        /// </summary>
        [EnumMember(Value = "UserDefinedFee_701")]
        UserDefinedFee701 = 63,
        /// <summary>
        /// UserDefinedFee_702
        /// </summary>
        [EnumMember(Value = "UserDefinedFee_702")]
        UserDefinedFee702 = 64,
        /// <summary>
        /// UserDefinedFee_704
        /// </summary>
        [EnumMember(Value = "UserDefinedFee_704")]
        UserDefinedFee704 = 65,
        /// <summary>
        /// UserDefinedFee_813
        /// </summary>
        [EnumMember(Value = "UserDefinedFee_813")]
        UserDefinedFee813 = 66,
        /// <summary>
        /// UserDefinedFee_814
        /// </summary>
        [EnumMember(Value = "UserDefinedFee_814")]
        UserDefinedFee814 = 67,
        /// <summary>
        /// UserDefinedFee_815
        /// </summary>
        [EnumMember(Value = "UserDefinedFee_815")]
        UserDefinedFee815 = 68,
        /// <summary>
        /// UserDefinedFee_816
        /// </summary>
        [EnumMember(Value = "UserDefinedFee_816")]
        UserDefinedFee816 = 69,
        /// <summary>
        /// UserDefinedFee_817
        /// </summary>
        [EnumMember(Value = "UserDefinedFee_817")]
        UserDefinedFee817 = 70,
        /// <summary>
        /// UserDefinedFee_818
        /// </summary>
        [EnumMember(Value = "UserDefinedFee_818")]
        UserDefinedFee818 = 71,
        /// <summary>
        /// UserDefinedFee_819
        /// </summary>
        [EnumMember(Value = "UserDefinedFee_819")]
        UserDefinedFee819 = 72,
        /// <summary>
        /// UserDefinedFee_820
        /// </summary>
        [EnumMember(Value = "UserDefinedFee_820")]
        UserDefinedFee820 = 73,
        /// <summary>
        /// UserDefinedFee_821
        /// </summary>
        [EnumMember(Value = "UserDefinedFee_821")]
        UserDefinedFee821 = 74,
        /// <summary>
        /// UserDefinedFee_822
        /// </summary>
        [EnumMember(Value = "UserDefinedFee_822")]
        UserDefinedFee822 = 75,
        /// <summary>
        /// UserDefinedFee_823
        /// </summary>
        [EnumMember(Value = "UserDefinedFee_823")]
        UserDefinedFee823 = 76,
        /// <summary>
        /// VAFundingFee
        /// </summary>
        VAFundingFee = 77,
        /// <summary>
        /// WireTransfer
        /// </summary>
        WireTransfer = 78
    }
}