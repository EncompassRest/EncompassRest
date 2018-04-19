using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// VaLoanData
    /// </summary>
    public sealed partial class VaLoanData : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _acres;
        /// <summary>
        /// Subject Property Legal DescAcres [600]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Subject Property Legal DescAcres")]
        public decimal? Acres { get => _acres; set => _acres = value; }
        private DirtyValue<string> _additionalSecurityDescription;
        /// <summary>
        /// VA Loan Disbursement - Describe additional security taken and list of others (including spouse) [VASUMM.X62]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Describe additional security taken and list of others (including spouse)")]
        public string AdditionalSecurityDescription { get => _additionalSecurityDescription; set => _additionalSecurityDescription = value; }
        private DirtyValue<string> _administratorAddress;
        /// <summary>
        /// VA To Admin of Benefits Street [VAVOB.X3]
        /// </summary>
        [LoanFieldProperty(Description = "VA To Admin of Benefits Street")]
        public string AdministratorAddress { get => _administratorAddress; set => _administratorAddress = value; }
        private DirtyValue<string> _administratorCity;
        /// <summary>
        /// VA To Admin of Benefits City [VAVOB.X4]
        /// </summary>
        [LoanFieldProperty(Description = "VA To Admin of Benefits City")]
        public string AdministratorCity { get => _administratorCity; set => _administratorCity = value; }
        private DirtyValue<string> _administratorContact;
        /// <summary>
        /// VA To Admin of Benefits Attn [VAVOB.X2]
        /// </summary>
        [LoanFieldProperty(Description = "VA To Admin of Benefits Attn")]
        public string AdministratorContact { get => _administratorContact; set => _administratorContact = value; }
        private DirtyValue<string> _administratorName;
        /// <summary>
        /// VA To Admin of Benefits Name [VAVOB.X1]
        /// </summary>
        [LoanFieldProperty(Description = "VA To Admin of Benefits Name")]
        public string AdministratorName { get => _administratorName; set => _administratorName = value; }
        private DirtyValue<string> _administratorPostalCode;
        /// <summary>
        /// VA To Admin of Benefits Zip [VAVOB.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "VA To Admin of Benefits Zip")]
        public string AdministratorPostalCode { get => _administratorPostalCode; set => _administratorPostalCode = value; }
        private DirtyValue<string> _administratorState;
        /// <summary>
        /// VA To Admin of Benefits State [VAVOB.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "VA To Admin of Benefits State")]
        public string AdministratorState { get => _administratorState; set => _administratorState = value; }
        private DirtyValue<int?> _ageOfProperty;
        /// <summary>
        /// VA Loan Summ Property Age [VASUMM.X8]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Property Age")]
        public int? AgeOfProperty { get => _ageOfProperty; set => _ageOfProperty = value; }
        private DirtyValue<decimal?> _amountSpentOnEnergyImprovements;
        /// <summary>
        /// Subject Property Energy Improve Amt [961]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Subject Property Energy Improve Amt")]
        public decimal? AmountSpentOnEnergyImprovements { get => _amountSpentOnEnergyImprovements; set => _amountSpentOnEnergyImprovements = value; }
        private DirtyValue<StringEnumValue<AmountTypeWithheld>> _amountTypeWithheld;
        /// <summary>
        /// VA Loan Disbursement - Account Type Withheld from Loan Proceeds and Deposited in [VASUMM.X65]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Account Type Withheld from Loan Proceeds and Deposited in")]
        public StringEnumValue<AmountTypeWithheld> AmountTypeWithheld { get => _amountTypeWithheld; set => _amountTypeWithheld = value; }
        private DirtyValue<decimal?> _amountWithheld;
        /// <summary>
        /// VA Loan Disbursement - Amount Withheld from Loan Proceeds and Deposited in [VASUMM.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Disbursement - Amount Withheld from Loan Proceeds and Deposited in")]
        public decimal? AmountWithheld { get => _amountWithheld; set => _amountWithheld = value; }
        private DirtyValue<decimal?> _annualGroundRent;
        /// <summary>
        /// VA Annual Ground Rent Amt [1035]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Annual Ground Rent Amt")]
        public decimal? AnnualGroundRent { get => _annualGroundRent; set => _annualGroundRent = value; }
        private DirtyValue<decimal?> _annualMaintenanceAssessment;
        /// <summary>
        /// Annual Maintenance Assessment [3643]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Annual Maintenance Assessment")]
        public decimal? AnnualMaintenanceAssessment { get => _annualMaintenanceAssessment; set => _annualMaintenanceAssessment = value; }
        private DirtyValue<decimal?> _annualRealEstateTaxes;
        /// <summary>
        /// VA Annual RE Taxes [1031]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Annual RE Taxes")]
        public decimal? AnnualRealEstateTaxes { get => _annualRealEstateTaxes; set => _annualRealEstateTaxes = value; }
        private DirtyValue<decimal?> _annualSpecialAssessment;
        /// <summary>
        /// VA Loan Disbursement - Annual Special Assessment [VASUMM.X59]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Disbursement - Annual Special Assessment")]
        public decimal? AnnualSpecialAssessment { get => _annualSpecialAssessment; set => _annualSpecialAssessment = value; }
        private DirtyValue<string> _applicantAddressCity;
        /// <summary>
        /// VaLoanData ApplicantAddressCity [VAELIG.X76]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ApplicantAddressCity { get => _applicantAddressCity; set => _applicantAddressCity = value; }
        private DirtyValue<string> _applicantAddressPostalCode;
        /// <summary>
        /// VaLoanData ApplicantAddressPostalCode [VAELIG.X78]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, ReadOnly = true)]
        public string ApplicantAddressPostalCode { get => _applicantAddressPostalCode; set => _applicantAddressPostalCode = value; }
        private DirtyValue<string> _applicantAddressState;
        /// <summary>
        /// VaLoanData ApplicantAddressState [VAELIG.X77]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, ReadOnly = true)]
        public string ApplicantAddressState { get => _applicantAddressState; set => _applicantAddressState = value; }
        private DirtyValue<string> _applicantAddressStreetLine1;
        /// <summary>
        /// VaLoanData ApplicantAddressStreetLine1 [VAELIG.X75]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ApplicantAddressStreetLine1 { get => _applicantAddressStreetLine1; set => _applicantAddressStreetLine1 = value; }
        private DirtyValue<DateTime?> _applicantBirthDate;
        /// <summary>
        /// VaLoanData ApplicantBirthDate [VAELIG.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? ApplicantBirthDate { get => _applicantBirthDate; set => _applicantBirthDate = value; }
        private DirtyValue<string> _applicantEmailAddressText;
        /// <summary>
        /// VA Veteran Email Address [VAELIG.X97]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Veteran Email Address")]
        public string ApplicantEmailAddressText { get => _applicantEmailAddressText; set => _applicantEmailAddressText = value; }
        private DirtyValue<string> _applicantFirstNameWithMiddleName;
        /// <summary>
        /// VaLoanData ApplicantFirstNameWithMiddleName [VAELIG.X71]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ApplicantFirstNameWithMiddleName { get => _applicantFirstNameWithMiddleName; set => _applicantFirstNameWithMiddleName = value; }
        private DirtyValue<string> _applicantHmdaGenderType;
        /// <summary>
        /// VA Loan Summ Veteran Sex [VASUMM.X35]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Loan Summ Veteran Sex")]
        public string ApplicantHmdaGenderType { get => _applicantHmdaGenderType; set => _applicantHmdaGenderType = value; }
        private DirtyValue<string> _applicantHomePhoneNumber;
        /// <summary>
        /// VaLoanData ApplicantHomePhoneNumber
        /// </summary>
        public string ApplicantHomePhoneNumber { get => _applicantHomePhoneNumber; set => _applicantHomePhoneNumber = value; }
        private DirtyValue<string> _applicantLastNameWithSuffix;
        /// <summary>
        /// VaLoanData ApplicantLastNameWithSuffix [VAELIG.X72]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ApplicantLastNameWithSuffix { get => _applicantLastNameWithSuffix; set => _applicantLastNameWithSuffix = value; }
        private DirtyValue<string> _applicantTaxIdentificationIdentifier;
        /// <summary>
        /// VaLoanData ApplicantTaxIdentificationIdentifier [VAELIG.X73]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.SSN, ReadOnly = true)]
        public string ApplicantTaxIdentificationIdentifier { get => _applicantTaxIdentificationIdentifier; set => _applicantTaxIdentificationIdentifier = value; }
        private DirtyValue<StringEnumValue<VaLoanDataAppraisalType>> _appraisalType;
        /// <summary>
        /// Subject Property Appraisal Type [962]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Appraisal Type")]
        public StringEnumValue<VaLoanDataAppraisalType> AppraisalType { get => _appraisalType; set => _appraisalType = value; }
        private DirtyValue<bool?> _automaticProcedure;
        /// <summary>
        /// VA Loan Disbursement - Automatic Procedure [VASUMM.X51]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Automatic Procedure")]
        public bool? AutomaticProcedure { get => _automaticProcedure; set => _automaticProcedure = value; }
        private DirtyValue<bool?> _availableForInspectionAMIndicator;
        /// <summary>
        /// Subject Property Time Avail AM [686]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Subject Property Time Avail AM")]
        public bool? AvailableForInspectionAMIndicator { get => _availableForInspectionAMIndicator; set => _availableForInspectionAMIndicator = value; }
        private DirtyValue<string> _availableForInspectionDateAndTime;
        /// <summary>
        /// Subject Property Date/Time Avail for Inspec [681]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Subject Property Date/Time Avail for Inspec")]
        public string AvailableForInspectionDateAndTime { get => _availableForInspectionDateAndTime; set => _availableForInspectionDateAndTime = value; }
        private DirtyValue<decimal?> _borrowerPaidDiscountPointsTotalAmount;
        /// <summary>
        /// VA Loan Summ Disc Points Paid by Veteran Amt [VASUMM.X46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Summ Disc Points Paid by Veteran Amt")]
        public decimal? BorrowerPaidDiscountPointsTotalAmount { get => _borrowerPaidDiscountPointsTotalAmount; set => _borrowerPaidDiscountPointsTotalAmount = value; }
        private DirtyValue<StringEnumValue<BuildingType>> _buildingType;
        /// <summary>
        /// Subject Property Building Type [602]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Building Type")]
        public StringEnumValue<BuildingType> BuildingType { get => _buildingType; set => _buildingType = value; }
        private DirtyValue<bool?> _buyerPurchasingLotSeparately;
        /// <summary>
        /// VA Buyer Purch Lot Separately [1344]
        /// </summary>
        [LoanFieldProperty(Description = "VA Buyer Purch Lot Separately", OptionsJson = "{\"true\":\"Buyer is purchasing lot separately\"}")]
        public bool? BuyerPurchasingLotSeparately { get => _buyerPurchasingLotSeparately; set => _buyerPurchasingLotSeparately = value; }
        private DirtyValue<decimal?> _cashPaymentFromVeteran;
        /// <summary>
        /// VA Subtract Any Cash Payment from Veteran [VARRRWS.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Subtract Any Cash Payment from Veteran")]
        public decimal? CashPaymentFromVeteran { get => _cashPaymentFromVeteran; set => _cashPaymentFromVeteran = value; }
        private DirtyValue<StringEnumValue<ClaimDisabilityBenefits>> _claimDisabilityBenefits;
        /// <summary>
        /// VA Certifcation Filed Claim Prior to Discharge [VAVOB.X71]
        /// </summary>
        [LoanFieldProperty(Description = "VA Certifcation Filed Claim Prior to Discharge")]
        public StringEnumValue<ClaimDisabilityBenefits> ClaimDisabilityBenefits { get => _claimDisabilityBenefits; set => _claimDisabilityBenefits = value; }
        private DirtyValue<bool?> _clothesWasherIndicator;
        /// <summary>
        /// VA Equipment Clothes Washer [302]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Clothes Washer", OptionsJson = "{\"true\":\"Clothes / Washer\"}")]
        public bool? ClothesWasherIndicator { get => _clothesWasherIndicator; set => _clothesWasherIndicator = value; }
        private DirtyValue<DateTime?> _constructionCompletedDate;
        /// <summary>
        /// Subject Property Constr Completed [726]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Constr Completed")]
        public DateTime? ConstructionCompletedDate { get => _constructionCompletedDate; set => _constructionCompletedDate = value; }
        private DirtyValue<StringEnumValue<ConstructionPlan>> _constructionPlan;
        /// <summary>
        /// VA New/Prop Constr Plan [1021]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA New/Prop Constr Plan")]
        public StringEnumValue<ConstructionPlan> ConstructionPlan { get => _constructionPlan; set => _constructionPlan = value; }
        private DirtyValue<bool?> _constructionWarrantyIncluded;
        /// <summary>
        /// Subject Property Constr Warranty Incl [722]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Constr Warranty Incl", OptionsJson = "{\"true\":\"Construction Warranty Included\"}")]
        public bool? ConstructionWarrantyIncluded { get => _constructionWarrantyIncluded; set => _constructionWarrantyIncluded = value; }
        private DirtyValue<string> _contractNoApprovedByVA;
        /// <summary>
        /// VA Contract # Approved By VA [1037]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Contract # Approved By VA")]
        public string ContractNoApprovedByVA { get => _contractNoApprovedByVA; set => _contractNoApprovedByVA = value; }
        private DirtyValue<int?> _creditScore;
        /// <summary>
        /// VA Loan Summ Credit Score [VASUMM.X23]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Credit Score")]
        public int? CreditScore { get => _creditScore; set => _creditScore = value; }
        private DirtyValue<bool?> _currentlyOnMilitaryDuty;
        /// <summary>
        /// VA Currently on Military Duty [VAVOB.X68]
        /// </summary>
        [LoanFieldProperty(Description = "VA Currently on Military Duty", OptionsJson = "{\"true\":\"Currently on military duty\"}")]
        public bool? CurrentlyOnMilitaryDuty { get => _currentlyOnMilitaryDuty; set => _currentlyOnMilitaryDuty = value; }
        private DirtyValue<DateTime?> _dateAquiredLand;
        /// <summary>
        /// VA Loan Disbursement - Date Aquired - If land aquired by separate transaction [VASUMM.X63]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Date Aquired - If land aquired by separate transaction")]
        public DateTime? DateAquiredLand { get => _dateAquiredLand; set => _dateAquiredLand = value; }
        private DirtyValue<DateTime?> _dateOfAssignment;
        /// <summary>
        /// VA Date of Assignment [415]
        /// </summary>
        [LoanFieldProperty(Description = "VA Date of Assignment")]
        public DateTime? DateOfAssignment { get => _dateOfAssignment; set => _dateOfAssignment = value; }
        private DirtyValue<DateTime?> _dateSAR;
        /// <summary>
        /// VA Loan Summ Date SAR Issued Value [VASUMM.X9]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Date SAR Issued Value")]
        public DateTime? DateSAR { get => _dateSAR; set => _dateSAR = value; }
        private DirtyValue<decimal?> _disabilityAmountCollected;
        /// <summary>
        /// VA Management Tool - Disability Amount Collected [VASUMM.X68]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Management Tool - Disability Amount Collected")]
        public decimal? DisabilityAmountCollected { get => _disabilityAmountCollected; set => _disabilityAmountCollected = value; }
        private DirtyValue<decimal?> _discountPercentage;
        /// <summary>
        /// VA Loan Discount Fee % [VARRRWS.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "VA Loan Discount Fee %")]
        public decimal? DiscountPercentage { get => _discountPercentage; set => _discountPercentage = value; }
        private DirtyValue<decimal?> _discountPoint;
        /// <summary>
        /// VA Loan Summ Disc Points Paid by Veteran % [VASUMM.X48]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "VA Loan Summ Disc Points Paid by Veteran %")]
        public decimal? DiscountPoint { get => _discountPoint; set => _discountPoint = value; }
        private DirtyValue<bool?> _dishwasherIndicator;
        /// <summary>
        /// VA Equipment Dishwasher [301]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Dishwasher", OptionsJson = "{\"true\":\"Dish Washer\"}")]
        public bool? DishwasherIndicator { get => _dishwasherIndicator; set => _dishwasherIndicator = value; }
        private DirtyValue<bool?> _dryerIndicator;
        /// <summary>
        /// VA Equipment Dryer [308]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Dryer", OptionsJson = "{\"true\":\"Dryer\"}")]
        public bool? DryerIndicator { get => _dryerIndicator; set => _dryerIndicator = value; }
        private DirtyValue<string> _emailToBeNotifiedWhenUploaded;
        /// <summary>
        /// VA 261805 E-Mail Address (to be Notified When Appraisal Uploaded) [3347]
        /// </summary>
        [LoanFieldProperty(Description = "VA 261805 E-Mail Address (to be Notified When Appraisal Uploaded)")]
        public string EmailToBeNotifiedWhenUploaded { get => _emailToBeNotifiedWhenUploaded; set => _emailToBeNotifiedWhenUploaded = value; }
        private DirtyValue<bool?> _energyImprovementsAdditionOfFeature;
        /// <summary>
        /// VA Energy Improvements Addition of Feature [379]
        /// </summary>
        [LoanFieldProperty(Description = "VA Energy Improvements Addition of Feature", OptionsJson = "{\"true\":\"Addition of Feature\"}")]
        public bool? EnergyImprovementsAdditionOfFeature { get => _energyImprovementsAdditionOfFeature; set => _energyImprovementsAdditionOfFeature = value; }
        private DirtyValue<string> _entitlementCode;
        /// <summary>
        /// VA Loan Summ Entitlement Code [VASUMM.X2]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Entitlement Code")]
        public string EntitlementCode { get => _entitlementCode; set => _entitlementCode = value; }
        private DirtyValue<string> _equipmentOtherDescription;
        /// <summary>
        /// VA Equipment Other [320]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Other")]
        public string EquipmentOtherDescription { get => _equipmentOtherDescription; set => _equipmentOtherDescription = value; }
        private DirtyValue<bool?> _excludeTaxesInsuranceIndicator;
        /// <summary>
        /// VA Management Tool - Exclude Taxes and Insurance [VASUMM.X100]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Exclude Taxes and Insurance")]
        public bool? ExcludeTaxesInsuranceIndicator { get => _excludeTaxesInsuranceIndicator; set => _excludeTaxesInsuranceIndicator = value; }
        private DirtyValue<decimal?> _finalDiscountAmount;
        /// <summary>
        /// VA Discount (Based from line 9) [VARRRWS.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Discount (Based from line 9)")]
        public decimal? FinalDiscountAmount { get => _finalDiscountAmount; set => _finalDiscountAmount = value; }
        private DirtyValue<decimal?> _finalFundingFeeAmount;
        /// <summary>
        /// VA Funding Fee (Round to Nearest Dollar) [VARRRWS.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Funding Fee (Round to Nearest Dollar)")]
        public decimal? FinalFundingFeeAmount { get => _finalFundingFeeAmount; set => _finalFundingFeeAmount = value; }
        private DirtyValue<bool?> _firstChattelLoanType;
        /// <summary>
        /// VA Loan Disbursement - Type of Loan - First Chattel  [VASUMM.X53]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Type of Loan - First Chattel ")]
        public bool? FirstChattelLoanType { get => _firstChattelLoanType; set => _firstChattelLoanType = value; }
        private DirtyValue<bool?> _firstTimeUse;
        /// <summary>
        /// VA Loan Summ 1st Time Use VA Loan Program [VASUMM.X49]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ 1st Time Use VA Loan Program")]
        public bool? FirstTimeUse { get => _firstTimeUse; set => _firstTimeUse = value; }
        private DirtyValue<bool?> _fundingFeeExempt;
        /// <summary>
        /// VA Loan Summ Discount Info [990]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Discount Info", OptionsJson = "{\"true\":\"Exempt\",\"false\":\"Not Exempt\"}")]
        public bool? FundingFeeExempt { get => _fundingFeeExempt; set => _fundingFeeExempt = value; }
        private DirtyValue<bool?> _garbageDisposalIndicator;
        /// <summary>
        /// VA Equipment Garbage Disposal [309]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Garbage Disposal", OptionsJson = "{\"true\":\"Garbage Disposal\"}")]
        public bool? GarbageDisposalIndicator { get => _garbageDisposalIndicator; set => _garbageDisposalIndicator = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// VaLoanData Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _initialTotal;
        /// <summary>
        /// VA Initial Computation Total [VARRRWS.X2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Initial Computation Total")]
        public decimal? InitialTotal { get => _initialTotal; set => _initialTotal = value; }
        private DirtyValue<StringEnumValue<InspectionWillBeMadeBy>> _inspectionWillBeMadeBy;
        /// <summary>
        /// VA New/Prop Constr Inspec By [1020]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA New/Prop Constr Inspec By")]
        public StringEnumValue<InspectionWillBeMadeBy> InspectionWillBeMadeBy { get => _inspectionWillBeMadeBy; set => _inspectionWillBeMadeBy = value; }
        private DirtyValue<bool?> _insulation;
        /// <summary>
        /// VA Energy Improvements Insulation [380]
        /// </summary>
        [LoanFieldProperty(Description = "VA Energy Improvements Insulation", OptionsJson = "{\"true\":\"Insulation, Caulking\"}")]
        public bool? Insulation { get => _insulation; set => _insulation = value; }
        private DirtyValue<StringEnumValue<InsuranceType>> _insuranceType;
        /// <summary>
        /// Insurance Type [3642]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance Type")]
        public StringEnumValue<InsuranceType> InsuranceType { get => _insuranceType; set => _insuranceType = value; }
        private DirtyValue<int?> _irregularLotSizeInSquareFeet;
        /// <summary>
        /// Subject Property Irreg Sq Ft [1043]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Irreg Sq Ft")]
        public int? IrregularLotSizeInSquareFeet { get => _irregularLotSizeInSquareFeet; set => _irregularLotSizeInSquareFeet = value; }
        private DirtyValue<bool?> _isDelinquent30Days;
        /// <summary>
        /// VaLoanData IsDelinquent30Days
        /// </summary>
        public bool? IsDelinquent30Days { get => _isDelinquent30Days; set => _isDelinquent30Days = value; }
        private DirtyValue<string> _keysAtAddress;
        /// <summary>
        /// Subject Property Keys At [683]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Keys At")]
        public string KeysAtAddress { get => _keysAtAddress; set => _keysAtAddress = value; }
        private DirtyValue<decimal?> _landPurchasePrice;
        /// <summary>
        /// VA Loan Disbursement - Land Purchase Price [VASUMM.X64]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Disbursement - Land Purchase Price")]
        public decimal? LandPurchasePrice { get => _landPurchasePrice; set => _landPurchasePrice = value; }
        private DirtyValue<StringEnumValue<LeaseholdType>> _leaseholdType;
        /// <summary>
        /// VA Lease Is [1033]
        /// </summary>
        [LoanFieldProperty(Description = "VA Lease Is")]
        public StringEnumValue<LeaseholdType> LeaseholdType { get => _leaseholdType; set => _leaseholdType = value; }
        private DirtyValue<string> _lenderSAR;
        /// <summary>
        /// VA Loan Summ Lender SAR ID [VASUMM.X6]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Lender SAR ID")]
        public string LenderSAR { get => _lenderSAR; set => _lenderSAR = value; }
        private DirtyValue<string> _loanAnalysisRemarks1;
        /// <summary>
        /// VA Loan Analysis Remarks 1 [VALA.X10]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 1")]
        public string LoanAnalysisRemarks1 { get => _loanAnalysisRemarks1; set => _loanAnalysisRemarks1 = value; }
        private DirtyValue<string> _loanAnalysisRemarks2;
        /// <summary>
        /// VA Loan Analysis Remarks 2 [VALA.X11]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 2")]
        public string LoanAnalysisRemarks2 { get => _loanAnalysisRemarks2; set => _loanAnalysisRemarks2 = value; }
        private DirtyValue<string> _loanAnalysisRemarks3;
        /// <summary>
        /// VA Loan Analysis Remarks 3 [VALA.X12]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 3")]
        public string LoanAnalysisRemarks3 { get => _loanAnalysisRemarks3; set => _loanAnalysisRemarks3 = value; }
        private DirtyValue<string> _loanAnalysisRemarks4;
        /// <summary>
        /// VA Loan Analysis Remarks 4 [VALA.X13]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 4")]
        public string LoanAnalysisRemarks4 { get => _loanAnalysisRemarks4; set => _loanAnalysisRemarks4 = value; }
        private DirtyValue<string> _loanAnalysisRemarks5;
        /// <summary>
        /// VA Loan Analysis Remarks 5 [VALA.X14]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 5")]
        public string LoanAnalysisRemarks5 { get => _loanAnalysisRemarks5; set => _loanAnalysisRemarks5 = value; }
        private DirtyValue<string> _loanAnalysisRemarks6;
        /// <summary>
        /// VA Loan Analysis Remarks 6 [VALA.X15]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 6")]
        public string LoanAnalysisRemarks6 { get => _loanAnalysisRemarks6; set => _loanAnalysisRemarks6 = value; }
        private DirtyValue<string> _loanAnalysisRemarks7;
        /// <summary>
        /// VA Loan Analysis Remarks 7 [VALA.X16]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 7")]
        public string LoanAnalysisRemarks7 { get => _loanAnalysisRemarks7; set => _loanAnalysisRemarks7 = value; }
        private DirtyValue<string> _loanAnalysisRemarks8;
        /// <summary>
        /// VA Loan Analysis Remarks 8 [VALA.X17]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 8")]
        public string LoanAnalysisRemarks8 { get => _loanAnalysisRemarks8; set => _loanAnalysisRemarks8 = value; }
        private DirtyValue<string> _loanAnalysisRemarks9;
        /// <summary>
        /// VA Loan Analysis Remarks 9 [VALA.X18]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Remarks 9")]
        public string LoanAnalysisRemarks9 { get => _loanAnalysisRemarks9; set => _loanAnalysisRemarks9 = value; }
        private DirtyValue<StringEnumValue<LoanCode>> _loanCode;
        /// <summary>
        /// VA Veteran Loan Code [958]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Loan Code")]
        public StringEnumValue<LoanCode> LoanCode { get => _loanCode; set => _loanCode = value; }
        private DirtyValue<StringEnumValue<LoanProcedure>> _loanProcedure;
        /// <summary>
        /// VA Veteran Loan Procedure [953]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Loan Procedure")]
        public StringEnumValue<LoanProcedure> LoanProcedure { get => _loanProcedure; set => _loanProcedure = value; }
        private DirtyValue<bool?> _loanProcessedUnderAU;
        /// <summary>
        /// VA Loan Summ VA Recognized Auto Underwriting Sys [VASUMM.X4]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ VA Recognized Auto Underwriting Sys")]
        public bool? LoanProcessedUnderAU { get => _loanProcessedUnderAU; set => _loanProcessedUnderAU = value; }
        private DirtyValue<string> _loanSummaryRemarks1;
        /// <summary>
        /// VA Loan Summ Remarks 1 [VASUMM.X37]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Remarks 1")]
        public string LoanSummaryRemarks1 { get => _loanSummaryRemarks1; set => _loanSummaryRemarks1 = value; }
        private DirtyValue<string> _loanSummaryRemarks2;
        /// <summary>
        /// VA Loan Summ Remarks 2 [VASUMM.X38]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Remarks 2")]
        public string LoanSummaryRemarks2 { get => _loanSummaryRemarks2; set => _loanSummaryRemarks2 = value; }
        private DirtyValue<string> _loanSummaryRemarks3;
        /// <summary>
        /// VA Loan Summ Remarks 3 [VASUMM.X39]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Remarks 3")]
        public string LoanSummaryRemarks3 { get => _loanSummaryRemarks3; set => _loanSummaryRemarks3 = value; }
        private DirtyValue<string> _loanSummaryRemarks4;
        /// <summary>
        /// VA Loan Summ Remarks 4 [VASUMM.X40]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Remarks 4")]
        public string LoanSummaryRemarks4 { get => _loanSummaryRemarks4; set => _loanSummaryRemarks4 = value; }
        private DirtyValue<string> _loanSummaryRemarks5;
        /// <summary>
        /// VA Loan Summ Remarks 5 [VASUMM.X41]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Remarks 5")]
        public string LoanSummaryRemarks5 { get => _loanSummaryRemarks5; set => _loanSummaryRemarks5 = value; }
        private DirtyValue<string> _loanSummaryRemarks6;
        /// <summary>
        /// VA Loan Summ Remarks 6 [VASUMM.X42]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Remarks 6")]
        public string LoanSummaryRemarks6 { get => _loanSummaryRemarks6; set => _loanSummaryRemarks6 = value; }
        private DirtyValue<string> _loanSummaryRemarks7;
        /// <summary>
        /// VA Loan Summ Remarks 7 [VASUMM.X43]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Remarks 7")]
        public string LoanSummaryRemarks7 { get => _loanSummaryRemarks7; set => _loanSummaryRemarks7 = value; }
        private DirtyValue<string> _loanSummaryRemarks8;
        /// <summary>
        /// VA Loan Summ Remarks 8 [VASUMM.X44]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Loan Summ Remarks 8")]
        public string LoanSummaryRemarks8 { get => _loanSummaryRemarks8; set => _loanSummaryRemarks8 = value; }
        private DirtyValue<string> _lotDimensions;
        /// <summary>
        /// Subject Property Lot Dimensions [1042]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Lot Dimensions")]
        public string LotDimensions { get => _lotDimensions; set => _lotDimensions = value; }
        private DirtyValue<string> _mailingAddress;
        /// <summary>
        /// VA Veteran Mailing Addr Street [VAELIG.X51]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Mailing Addr Street")]
        public string MailingAddress { get => _mailingAddress; set => _mailingAddress = value; }
        private DirtyValue<string> _mailingCity;
        /// <summary>
        /// VA Veteran Mailing Addr City [VAELIG.X54]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Mailing Addr City")]
        public string MailingCity { get => _mailingCity; set => _mailingCity = value; }
        private DirtyValue<string> _mailingPostalCode;
        /// <summary>
        /// VA Veteran Mailing Addr Zip [VAELIG.X56]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "VA Veteran Mailing Addr Zip")]
        public string MailingPostalCode { get => _mailingPostalCode; set => _mailingPostalCode = value; }
        private DirtyValue<string> _mailingState;
        /// <summary>
        /// VA Veteran Mailing Addr State [VAELIG.X55]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "VA Veteran Mailing Addr State")]
        public string MailingState { get => _mailingState; set => _mailingState = value; }
        private DirtyValue<StringEnumValue<ManufacturedHome>> _manufacturedHome;
        /// <summary>
        /// Subject Property Manufactured Home [963]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Manufactured Home")]
        public StringEnumValue<ManufacturedHome> ManufacturedHome { get => _manufacturedHome; set => _manufacturedHome = value; }
        private DirtyValue<string> _mCRVNumber;
        /// <summary>
        /// Subject Property Energy Improve MCRV # [989]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Energy Improve MCRV #")]
        public string MCRVNumber { get => _mCRVNumber; set => _mCRVNumber = value; }
        private DirtyValue<StringEnumValue<MilitaryBranchOfService>> _militaryBranchOfService;
        /// <summary>
        /// VA Veteran Branch of Service [954]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Branch of Service")]
        public StringEnumValue<MilitaryBranchOfService> MilitaryBranchOfService { get => _militaryBranchOfService; set => _militaryBranchOfService = value; }
        private DirtyList<MilitaryService> _militaryServices;
        /// <summary>
        /// VaLoanData MilitaryServices
        /// </summary>
        public IList<MilitaryService> MilitaryServices { get => _militaryServices ?? (_militaryServices = new DirtyList<MilitaryService>()); set => _militaryServices = new DirtyList<MilitaryService>(value); }
        private DirtyValue<string> _mineralRightsReserved;
        /// <summary>
        /// VA Mineral Rights Reserved [1032]
        /// </summary>
        [LoanFieldProperty(Description = "VA Mineral Rights Reserved")]
        public string MineralRightsReserved { get => _mineralRightsReserved; set => _mineralRightsReserved = value; }
        private DirtyValue<string> _nameOfOccupant;
        /// <summary>
        /// Subject Property Occupant Name [730]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Occupant Name")]
        public string NameOfOccupant { get => _nameOfOccupant; set => _nameOfOccupant = value; }
        private DirtyValue<string> _nameOfOwner;
        /// <summary>
        /// Subject Property Owner Name [727]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Owner Name")]
        public string NameOfOwner { get => _nameOfOwner; set => _nameOfOwner = value; }
        private DirtyValue<string> _nameOfWarrantyProgram;
        /// <summary>
        /// Subject Property Warranty Program Name [724]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Warranty Program Name")]
        public string NameOfWarrantyProgram { get => _nameOfWarrantyProgram; set => _nameOfWarrantyProgram = value; }
        private DirtyValue<decimal?> _negativeRents;
        /// <summary>
        /// VA Loan Analysis Negative Rents [VALA.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Analysis Negative Rents")]
        public decimal? NegativeRents { get => _negativeRents; set => _negativeRents = value; }
        private DirtyValue<bool?> _noEnergyImprovements;
        /// <summary>
        /// VA Energy Improvements None [376]
        /// </summary>
        [LoanFieldProperty(Description = "VA Energy Improvements None", OptionsJson = "{\"true\":\"None\"}")]
        public bool? NoEnergyImprovements { get => _noEnergyImprovements; set => _noEnergyImprovements = value; }
        private DirtyValue<string> _nonrealtyDescription;
        /// <summary>
        /// VA Loan Disbursement - Describe nonrealty, if any, acquired with proceeds of loan [VASUMM.X61]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Describe nonrealty, if any, acquired with proceeds of loan")]
        public string NonrealtyDescription { get => _nonrealtyDescription; set => _nonrealtyDescription = value; }
        private DirtyValue<string> _numberOfBuildings;
        /// <summary>
        /// Subject Property # Buildings [604]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property # Buildings")]
        public string NumberOfBuildings { get => _numberOfBuildings; set => _numberOfBuildings = value; }
        private DirtyValue<string> _occupantTelephone;
        /// <summary>
        /// Subject Property Occupant Phone [731]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Subject Property Occupant Phone")]
        public string OccupantTelephone { get => _occupantTelephone; set => _occupantTelephone = value; }
        private DirtyValue<bool?> _onMilitaryDutyFollowingSeparation;
        /// <summary>
        /// VA On Military Duty Day Following Separation [VAVOB.X69]
        /// </summary>
        [LoanFieldProperty(Description = "VA On Military Duty Day Following Separation", OptionsJson = "{\"true\":\"On military duty on the day following separation\"}")]
        public bool? OnMilitaryDutyFollowingSeparation { get => _onMilitaryDutyFollowingSeparation; set => _onMilitaryDutyFollowingSeparation = value; }
        private DirtyValue<decimal?> _originalInterestRate;
        /// <summary>
        /// VA Loan Summ Orig Int Rate [VASUMM.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "VA Loan Summ Orig Int Rate")]
        public decimal? OriginalInterestRate { get => _originalInterestRate; set => _originalInterestRate = value; }
        private DirtyValue<decimal?> _originalLoanAmount;
        /// <summary>
        /// VA Loan Summ Orig Loan Amt [VASUMM.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Summ Orig Loan Amt")]
        public decimal? OriginalLoanAmount { get => _originalLoanAmount; set => _originalLoanAmount = value; }
        private DirtyValue<int?> _originalTerm;
        /// <summary>
        /// VA Loan Summ Orig Term [VASUMM.X18]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Orig Term")]
        public int? OriginalTerm { get => _originalTerm; set => _originalTerm = value; }
        private DirtyValue<bool?> _originalValueEstimateChanged;
        /// <summary>
        /// VA Loan Summ Y/N Appraisers Orig Value Est Changed [VASUMM.X13]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Y/N Appraisers Orig Value Est Changed")]
        public bool? OriginalValueEstimateChanged { get => _originalValueEstimateChanged; set => _originalValueEstimateChanged = value; }
        private DirtyValue<decimal?> _originationFeeAmount;
        /// <summary>
        /// VA Origination Fee [VARRRWS.X4]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Origination Fee")]
        public decimal? OriginationFeeAmount { get => _originationFeeAmount; set => _originationFeeAmount = value; }
        private DirtyValue<decimal?> _otherClosingCosts;
        /// <summary>
        /// VA Add Other Allowable Closing Costs/Prepaids [VARRRWS.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Add Other Allowable Closing Costs/Prepaids")]
        public decimal? OtherClosingCosts { get => _otherClosingCosts; set => _otherClosingCosts = value; }
        private DirtyValue<string> _otherDescriptionEstateProperty;
        /// <summary>
        /// VA Loan Disbursement - Estate in Property - Other Description [VASUMM.X58]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Estate in Property - Other Description")]
        public string OtherDescriptionEstateProperty { get => _otherDescriptionEstateProperty; set => _otherDescriptionEstateProperty = value; }
        private DirtyValue<string> _otherDescriptionLoanType;
        /// <summary>
        /// VA Loan Disbursement - Type of Loan - Other Description [VASUMM.X56]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Type of Loan - Other Description")]
        public string OtherDescriptionLoanType { get => _otherDescriptionLoanType; set => _otherDescriptionLoanType = value; }
        private DirtyValue<bool?> _otherEstateProperty;
        /// <summary>
        /// VA Loan Disbursement - Estate in Property - Other [VASUMM.X57]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Estate in Property - Other")]
        public bool? OtherEstateProperty { get => _otherEstateProperty; set => _otherEstateProperty = value; }
        private DirtyValue<bool?> _otherImprovements;
        /// <summary>
        /// VA Other Improvements [381]
        /// </summary>
        [LoanFieldProperty(Description = "VA Other Improvements", OptionsJson = "{\"true\":\"Other Improvements\"}")]
        public bool? OtherImprovements { get => _otherImprovements; set => _otherImprovements = value; }
        private DirtyValue<bool?> _otherLoanType;
        /// <summary>
        /// VA Loan Disbursement - Type of Loan - Other [VASUMM.X55]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Type of Loan - Other")]
        public bool? OtherLoanType { get => _otherLoanType; set => _otherLoanType = value; }
        private DirtyValue<string> _paidInFullVALoanNumber;
        /// <summary>
        /// VA Loan Summ Paid In Full Loan # [VASUMM.X14]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Paid In Full Loan #")]
        public string PaidInFullVALoanNumber { get => _paidInFullVALoanNumber; set => _paidInFullVALoanNumber = value; }
        private DirtyValue<bool?> _payoffIndicator1;
        /// <summary>
        /// VA Loan Analysis Liability 1 Incl on Line 41 [VALA.X20]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Liability 1 Incl on Line 41")]
        public bool? PayoffIndicator1 { get => _payoffIndicator1; set => _payoffIndicator1 = value; }
        private DirtyValue<bool?> _payoffIndicator2;
        /// <summary>
        /// VA Loan Analysis Liability 2 Incl on Line 41 [VALA.X21]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Liability 2 Incl on Line 41")]
        public bool? PayoffIndicator2 { get => _payoffIndicator2; set => _payoffIndicator2 = value; }
        private DirtyValue<bool?> _payoffIndicator3;
        /// <summary>
        /// VA Loan Analysis Liability 3 Incl on Line 41 [VALA.X22]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Liability 3 Incl on Line 41")]
        public bool? PayoffIndicator3 { get => _payoffIndicator3; set => _payoffIndicator3 = value; }
        private DirtyValue<bool?> _payoffIndicator4;
        /// <summary>
        /// VA Loan Analysis Liability 4 Incl on Line 41 [VALA.X23]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Liability 4 Incl on Line 41")]
        public bool? PayoffIndicator4 { get => _payoffIndicator4; set => _payoffIndicator4 = value; }
        private DirtyValue<bool?> _payoffIndicator5;
        /// <summary>
        /// VA Loan Analysis Liability 5 Incl on Line 41 [VALA.X24]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Liability 5 Incl on Line 41")]
        public bool? PayoffIndicator5 { get => _payoffIndicator5; set => _payoffIndicator5 = value; }
        private DirtyValue<bool?> _payoffIndicator6;
        /// <summary>
        /// VA Loan Analysis Liability 6 Incl on Line 41 [VALA.X25]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Liability 6 Incl on Line 41")]
        public bool? PayoffIndicator6 { get => _payoffIndicator6; set => _payoffIndicator6 = value; }
        private DirtyValue<bool?> _payoffIndicator7;
        /// <summary>
        /// VA Loan Analysis Liability 7 Incl on Line 41 [VALA.X26]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Liability 7 Incl on Line 41")]
        public bool? PayoffIndicator7 { get => _payoffIndicator7; set => _payoffIndicator7 = value; }
        private DirtyValue<bool?> _payoffIndicator8;
        /// <summary>
        /// VA Loan Analysis Alimony/Child Supp Incl on Line 41 [VALA.X27]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Alimony/Child Supp Incl on Line 41")]
        public bool? PayoffIndicator8 { get => _payoffIndicator8; set => _payoffIndicator8 = value; }
        private DirtyValue<bool?> _payoffIndicator9;
        /// <summary>
        /// VA Loan Analysis Other Liabilities Incl on Line 41 [VALA.X28]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Analysis Other Liabilities Incl on Line 41")]
        public bool? PayoffIndicator9 { get => _payoffIndicator9; set => _payoffIndicator9 = value; }
        private DirtyValue<decimal?> _pestReportFee;
        /// <summary>
        /// VA Management Tool - Pest Report Fee [VASUMM.X69]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Management Tool - Pest Report Fee")]
        public decimal? PestReportFee { get => _pestReportFee; set => _pestReportFee = value; }
        private DirtyValue<string> _plansSubmitted;
        /// <summary>
        /// VA New/Prop Constr Plan Prev Case # [1022]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA New/Prop Constr Plan Prev Case #")]
        public string PlansSubmitted { get => _plansSubmitted; set => _plansSubmitted = value; }
        private DirtyValue<string> _pOCAddress;
        /// <summary>
        /// VA 261805 Applicable Point of Contact (POC) Information Address [3350]
        /// </summary>
        [LoanFieldProperty(Description = "VA 261805 Applicable Point of Contact (POC) Information Address")]
        public string POCAddress { get => _pOCAddress; set => _pOCAddress = value; }
        private DirtyValue<string> _pOCCity;
        /// <summary>
        /// VA 261805 Applicable Point of Contact (POC) Information City [3351]
        /// </summary>
        [LoanFieldProperty(Description = "VA 261805 Applicable Point of Contact (POC) Information City")]
        public string POCCity { get => _pOCCity; set => _pOCCity = value; }
        private DirtyValue<string> _pOCName;
        /// <summary>
        /// VA 261805 Applicable Point of Contact (POC) Information Name [3349]
        /// </summary>
        [LoanFieldProperty(Description = "VA 261805 Applicable Point of Contact (POC) Information Name")]
        public string POCName { get => _pOCName; set => _pOCName = value; }
        private DirtyValue<string> _pOCPhone;
        /// <summary>
        /// VA 261805 Applicable Point of Contact (POC) Information Phone [3354]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "VA 261805 Applicable Point of Contact (POC) Information Phone")]
        public string POCPhone { get => _pOCPhone; set => _pOCPhone = value; }
        private DirtyValue<string> _pOCState;
        /// <summary>
        /// VA 261805 Applicable Point of Contact (POC) Information State [3352]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "VA 261805 Applicable Point of Contact (POC) Information State")]
        public string POCState { get => _pOCState; set => _pOCState = value; }
        private DirtyValue<string> _pOCZipCode;
        /// <summary>
        /// VA 261805 Applicable Point of Contact (POC) Information Zipcode [3353]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "VA 261805 Applicable Point of Contact (POC) Information Zipcode")]
        public string POCZipCode { get => _pOCZipCode; set => _pOCZipCode = value; }
        private DirtyValue<decimal?> _preliminaryDiscountAmount;
        /// <summary>
        /// VA Discount Amt [VARRRWS.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Discount Amt")]
        public decimal? PreliminaryDiscountAmount { get => _preliminaryDiscountAmount; set => _preliminaryDiscountAmount = value; }
        private DirtyValue<decimal?> _preliminaryFundingFeeAmount;
        /// <summary>
        /// VA Funding Fee [VARRRWS.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Funding Fee")]
        public decimal? PreliminaryFundingFeeAmount { get => _preliminaryFundingFeeAmount; set => _preliminaryFundingFeeAmount = value; }
        private DirtyValue<decimal?> _preliminaryTotal;
        /// <summary>
        /// VA Preliminary Loan Amt Total [VARRRWS.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Preliminary Loan Amt Total")]
        public decimal? PreliminaryTotal { get => _preliminaryTotal; set => _preliminaryTotal = value; }
        private DirtyValue<bool?> _previousVALoanIndicator;
        /// <summary>
        /// VA Military Previous VA Loan Not Applicable (NA) [VAELIG.X113]
        /// </summary>
        [LoanFieldProperty(Description = "VA Military Previous VA Loan Not Applicable (NA)")]
        public bool? PreviousVALoanIndicator { get => _previousVALoanIndicator; set => _previousVALoanIndicator = value; }
        private DirtyList<PreviousVaLoan> _previousVaLoans;
        /// <summary>
        /// VaLoanData PreviousVaLoans
        /// </summary>
        public IList<PreviousVaLoan> PreviousVaLoans { get => _previousVaLoans ?? (_previousVaLoans = new DirtyList<PreviousVaLoan>()); set => _previousVaLoans = new DirtyList<PreviousVaLoan>(value); }
        private DirtyValue<bool?> _priorApprovalProcedure;
        /// <summary>
        /// VA Loan Disbursement - Prior Approval Procedure [VASUMM.X52]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Prior Approval Procedure")]
        public bool? PriorApprovalProcedure { get => _priorApprovalProcedure; set => _priorApprovalProcedure = value; }
        private DirtyValue<StringEnumValue<PriorLoanType>> _priorLoanType;
        /// <summary>
        /// VA Loan Summ Prior Loan Type [VASUMM.X50]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Prior Loan Type")]
        public StringEnumValue<PriorLoanType> PriorLoanType { get => _priorLoanType; set => _priorLoanType = value; }
        private DirtyValue<StringEnumValue<PropertyDesignation>> _propertyDesignation;
        /// <summary>
        /// Subject Property Energy Improve Property Desig [988]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Energy Improve Property Desig")]
        public StringEnumValue<PropertyDesignation> PropertyDesignation { get => _propertyDesignation; set => _propertyDesignation = value; }
        private DirtyValue<int?> _propertyGrossLivingArea;
        /// <summary>
        /// VA Loan Summ Property Gross Living Area [VASUMM.X7]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Property Gross Living Area")]
        public int? PropertyGrossLivingArea { get => _propertyGrossLivingArea; set => _propertyGrossLivingArea = value; }
        private DirtyValue<string> _propertyLegalDescription1;
        /// <summary>
        /// Subject Property Legal Descr 1 [765]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr 1")]
        public string PropertyLegalDescription1 { get => _propertyLegalDescription1; set => _propertyLegalDescription1 = value; }
        private DirtyValue<string> _propertyLegalDescription2;
        /// <summary>
        /// Subject Property Legal Descr 2 [766]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr 2")]
        public string PropertyLegalDescription2 { get => _propertyLegalDescription2; set => _propertyLegalDescription2 = value; }
        private DirtyValue<string> _propertyLegalDescription3;
        /// <summary>
        /// Subject Property Legal Descr 3 [797]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr 3")]
        public string PropertyLegalDescription3 { get => _propertyLegalDescription3; set => _propertyLegalDescription3 = value; }
        private DirtyValue<string> _propertyLegalDescription4;
        /// <summary>
        /// Subject Property Legal Descr 4 [798]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr 4")]
        public string PropertyLegalDescription4 { get => _propertyLegalDescription4; set => _propertyLegalDescription4 = value; }
        private DirtyValue<StringEnumValue<PropertyOccupancyType>> _propertyOccupancyType;
        /// <summary>
        /// Subject Property Type [728]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Type")]
        public StringEnumValue<PropertyOccupancyType> PropertyOccupancyType { get => _propertyOccupancyType; set => _propertyOccupancyType = value; }
        private DirtyValue<bool?> _proposedSaleContractAttached;
        /// <summary>
        /// VA Proposed Sale Contract Attached [1036]
        /// </summary>
        [LoanFieldProperty(Description = "VA Proposed Sale Contract Attached", OptionsJson = "{\"true\":\"Proposed sale contract attached\"}")]
        public bool? ProposedSaleContractAttached { get => _proposedSaleContractAttached; set => _proposedSaleContractAttached = value; }
        private DirtyValue<StringEnumValue<VaLoanDataPurposeOfLoan>> _purposeOfLoan;
        /// <summary>
        /// VA Veteran Loan Purpose [956]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Loan Purpose")]
        public StringEnumValue<VaLoanDataPurposeOfLoan> PurposeOfLoan { get => _purposeOfLoan; set => _purposeOfLoan = value; }
        private DirtyValue<bool?> _rangeOvenIndicator;
        /// <summary>
        /// VA Equipment Range Oven [204]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Range Oven", OptionsJson = "{\"true\":\"Range / Oven\"}")]
        public bool? RangeOvenIndicator { get => _rangeOvenIndicator; set => _rangeOvenIndicator = value; }
        private DirtyValue<bool?> _reasonableValueCompleted;
        /// <summary>
        /// VA Loan Disbursement - Complete Where Authorized by Certificate of Reasonable Value [VASUMM.X67]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Complete Where Authorized by Certificate of Reasonable Value")]
        public bool? ReasonableValueCompleted { get => _reasonableValueCompleted; set => _reasonableValueCompleted = value; }
        private DirtyValue<bool?> _refrigeratorIndicator;
        /// <summary>
        /// VA Equipment Refrigerator [209]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Refrigerator", OptionsJson = "{\"true\":\"Refrigerator\"}")]
        public bool? RefrigeratorIndicator { get => _refrigeratorIndicator; set => _refrigeratorIndicator = value; }
        private DirtyValue<string> _rent;
        /// <summary>
        /// Subject Property Rent [729]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Rent")]
        public string Rent { get => _rent; set => _rent = value; }
        private DirtyValue<bool?> _replacementOfSystem;
        /// <summary>
        /// VA Energy Improvements Replacement of System [378]
        /// </summary>
        [LoanFieldProperty(Description = "VA Energy Improvements Replacement of System", OptionsJson = "{\"true\":\"Replacement of System\"}")]
        public bool? ReplacementOfSystem { get => _replacementOfSystem; set => _replacementOfSystem = value; }
        private DirtyValue<StringEnumValue<RiskClassification>> _riskClasification;
        /// <summary>
        /// VA Loan Summ Risk Classification [VASUMM.X21]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Risk Classification")]
        public StringEnumValue<RiskClassification> RiskClasification { get => _riskClasification; set => _riskClasification = value; }
        private DirtyValue<string> _serviceNumber;
        /// <summary>
        /// VA Svc # [VAVOB.X67]
        /// </summary>
        [LoanFieldProperty(Description = "VA Svc #")]
        public string ServiceNumber { get => _serviceNumber; set => _serviceNumber = value; }
        private DirtyValue<bool?> _solarHeatingOrCooling;
        /// <summary>
        /// Fees Survey to Seller [377]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Survey to Seller", OptionsJson = "{\"true\":\"Solar Heating / Cooling\"}")]
        public bool? SolarHeatingOrCooling { get => _solarHeatingOrCooling; set => _solarHeatingOrCooling = value; }
        private DirtyValue<string> _specialAssessmentComments1;
        /// <summary>
        /// VA Special Assess/HOA Charges Comments 1 [1028]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Special Assess/HOA Charges Comments 1")]
        public string SpecialAssessmentComments1 { get => _specialAssessmentComments1; set => _specialAssessmentComments1 = value; }
        private DirtyValue<string> _specialAssessmentComments2;
        /// <summary>
        /// VA Special Assess/HOA Charges Comments 2 [1029]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Special Assess/HOA Charges Comments 2")]
        public string SpecialAssessmentComments2 { get => _specialAssessmentComments2; set => _specialAssessmentComments2 = value; }
        private DirtyValue<string> _specialAssessmentComments3;
        /// <summary>
        /// VA Special Assess/HOA Charges Comments 3 [1030]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Special Assess/HOA Charges Comments 3")]
        public string SpecialAssessmentComments3 { get => _specialAssessmentComments3; set => _specialAssessmentComments3 = value; }
        private DirtyValue<StringEnumValue<StreetAccess>> _streetAccess;
        /// <summary>
        /// Subject Property Street Access [720]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Street Access")]
        public StringEnumValue<StreetAccess> StreetAccess { get => _streetAccess; set => _streetAccess = value; }
        private DirtyValue<StringEnumValue<StreetMaintenance>> _streetMaintenance;
        /// <summary>
        /// Subject Property Street Maint [721]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Street Maint")]
        public StringEnumValue<StreetMaintenance> StreetMaintenance { get => _streetMaintenance; set => _streetMaintenance = value; }
        private DirtyValue<StringEnumValue<SystemUsed>> _systemUsed;
        /// <summary>
        /// VA Loan Summ Underwriting System Used [VASUMM.X17]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Underwriting System Used")]
        public StringEnumValue<SystemUsed> SystemUsed { get => _systemUsed; set => _systemUsed = value; }
        private DirtyValue<string> _title;
        /// <summary>
        /// VA New/Prop Constr Title [GAPPR.X5]
        /// </summary>
        [LoanFieldProperty(Description = "VA New/Prop Constr Title")]
        public string Title { get => _title; set => _title = value; }
        private DirtyValue<string> _titleLimitations1;
        /// <summary>
        /// Subject Property Title Limitations 1 [926]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Title Limitations 1")]
        public string TitleLimitations1 { get => _titleLimitations1; set => _titleLimitations1 = value; }
        private DirtyValue<string> _titleLimitations2;
        /// <summary>
        /// Subject Property Title Limitations 2 [927]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Title Limitations 2")]
        public string TitleLimitations2 { get => _titleLimitations2; set => _titleLimitations2 = value; }
        private DirtyValue<string> _titleLimitations3;
        /// <summary>
        /// Subject Property Title Limitations 3 [928]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Title Limitations 3")]
        public string TitleLimitations3 { get => _titleLimitations3; set => _titleLimitations3 = value; }
        private DirtyValue<decimal?> _totalBaths;
        /// <summary>
        /// VA Loan Summ Baths [VASUMM.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Summ Baths")]
        public decimal? TotalBaths { get => _totalBaths; set => _totalBaths = value; }
        private DirtyValue<int?> _totalBedrooms;
        /// <summary>
        /// VA Loan Summ Bedrooms [VASUMM.X12]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Bedrooms")]
        public int? TotalBedrooms { get => _totalBedrooms; set => _totalBedrooms = value; }
        private DirtyValue<decimal?> _totalDebtMonthlyPayment;
        /// <summary>
        /// VA Loan Analysis Total Debt Mo Pymt [VALA.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Loan Analysis Total Debt Mo Pymt")]
        public decimal? TotalDebtMonthlyPayment { get => _totalDebtMonthlyPayment; set => _totalDebtMonthlyPayment = value; }
        private DirtyValue<decimal?> _totalDiscountPointCharged;
        /// <summary>
        /// VA Loan Summ Total Disc Points Chrgd Amt [VASUMM.X45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Summ Total Disc Points Chrgd Amt")]
        public decimal? TotalDiscountPointCharged { get => _totalDiscountPointCharged; set => _totalDiscountPointCharged = value; }
        private DirtyValue<decimal?> _totalDiscountPointsCharged;
        /// <summary>
        /// VA Loan Summ Total Disc Points Chrgd % [VASUMM.X47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "VA Loan Summ Total Disc Points Chrgd %")]
        public decimal? TotalDiscountPointsCharged { get => _totalDiscountPointsCharged; set => _totalDiscountPointsCharged = value; }
        private DirtyValue<decimal?> _totalForMaxLoanAmount;
        /// <summary>
        /// VA Total - Max Loan Amt [VARRRWS.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Total - Max Loan Amt")]
        public decimal? TotalForMaxLoanAmount { get => _totalForMaxLoanAmount; set => _totalForMaxLoanAmount = value; }
        private DirtyValue<decimal?> _totalMonthlyPayment;
        /// <summary>
        /// VA Management Tool - Total Monthly Payment [VASUMM.X98]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Management Tool - Total Monthly Payment")]
        public decimal? TotalMonthlyPayment { get => _totalMonthlyPayment; set => _totalMonthlyPayment = value; }
        private DirtyValue<decimal?> _totalProposedMonthlyPayment;
        /// <summary>
        /// VA Management Tool - Total Proposed Monthly Payment [VASUMM.X99]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Management Tool - Total Proposed Monthly Payment")]
        public decimal? TotalProposedMonthlyPayment { get => _totalProposedMonthlyPayment; set => _totalProposedMonthlyPayment = value; }
        private DirtyValue<int?> _totalRooms;
        /// <summary>
        /// VA Loan Summ Total Rooms [VASUMM.X10]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ Total Rooms")]
        public int? TotalRooms { get => _totalRooms; set => _totalRooms = value; }
        private DirtyValue<decimal?> _totalUnpaidSpecialAssessments;
        /// <summary>
        /// VA Loan Disbursement - Total Unpaid Special Assessments [VASUMM.X60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Loan Disbursement - Total Unpaid Special Assessments")]
        public decimal? TotalUnpaidSpecialAssessments { get => _totalUnpaidSpecialAssessments; set => _totalUnpaidSpecialAssessments = value; }
        private DirtyValue<StringEnumValue<TypeOfHybridARM>> _typeOfHybridARM;
        /// <summary>
        /// VA Loan Summ HYBRID-ARM Type [VASUMM.X24]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Summ HYBRID-ARM Type")]
        public StringEnumValue<TypeOfHybridARM> TypeOfHybridARM { get => _typeOfHybridARM; set => _typeOfHybridARM = value; }
        private DirtyValue<StringEnumValue<TypeOfMortgage>> _typeOfMortgage;
        /// <summary>
        /// VA Veteran Mtg Type [959]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Mtg Type")]
        public StringEnumValue<TypeOfMortgage> TypeOfMortgage { get => _typeOfMortgage; set => _typeOfMortgage = value; }
        private DirtyValue<StringEnumValue<TypeOfOwnsership>> _typeOfOwnsership;
        /// <summary>
        /// VA Veteran Ownership Type [957]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Ownership Type")]
        public StringEnumValue<TypeOfOwnsership> TypeOfOwnsership { get => _typeOfOwnsership; set => _typeOfOwnsership = value; }
        private DirtyValue<StringEnumValue<TypeOfStructure>> _typeOfStructure;
        /// <summary>
        /// Subject Property Energy Improve Structure Type [986]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Energy Improve Structure Type")]
        public StringEnumValue<TypeOfStructure> TypeOfStructure { get => _typeOfStructure; set => _typeOfStructure = value; }
        private DirtyValue<StringEnumValue<TypeOfVeteran>> _typeOfVeteran;
        /// <summary>
        /// VA Veteran Type [VAVOB.X72]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Type")]
        public StringEnumValue<TypeOfVeteran> TypeOfVeteran { get => _typeOfVeteran; set => _typeOfVeteran = value; }
        private DirtyValue<bool?> _unsecuredLoanType;
        /// <summary>
        /// VA Loan Disbursement - Type of Loan - Unsecured  [VASUMM.X54]
        /// </summary>
        [LoanFieldProperty(Description = "VA Loan Disbursement - Type of Loan - Unsecured ")]
        public bool? UnsecuredLoanType { get => _unsecuredLoanType; set => _unsecuredLoanType = value; }
        private DirtyValue<StringEnumValue<UtilitiesDescription>> _utilitiesElectricDescription;
        /// <summary>
        /// Subject Property Legal Descr Utilities Elec [1096]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr Utilities Elec")]
        public StringEnumValue<UtilitiesDescription> UtilitiesElectricDescription { get => _utilitiesElectricDescription; set => _utilitiesElectricDescription = value; }
        private DirtyValue<StringEnumValue<UtilitiesDescription>> _utilitiesGasDescription;
        /// <summary>
        /// Subject Property Legal Descr Utilities Gas [1097]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr Utilities Gas")]
        public StringEnumValue<UtilitiesDescription> UtilitiesGasDescription { get => _utilitiesGasDescription; set => _utilitiesGasDescription = value; }
        private DirtyValue<StringEnumValue<UtilitiesDescription>> _utilitiesSewerDescription;
        /// <summary>
        /// Subject Property Legal Descr Utilities Sewer [1099]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr Utilities Sewer")]
        public StringEnumValue<UtilitiesDescription> UtilitiesSewerDescription { get => _utilitiesSewerDescription; set => _utilitiesSewerDescription = value; }
        private DirtyValue<StringEnumValue<UtilitiesDescription>> _utilitiesWaterDescription;
        /// <summary>
        /// Subject Property Legal Descr Utilities Water [1098]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Legal Descr Utilities Water")]
        public StringEnumValue<UtilitiesDescription> UtilitiesWaterDescription { get => _utilitiesWaterDescription; set => _utilitiesWaterDescription = value; }
        private DirtyValue<DateTime?> _vAAppraisalSentDate;
        /// <summary>
        /// VA Management Tool - Appraisal Sent Date [VASUMM.X73]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Appraisal Sent Date")]
        public DateTime? VAAppraisalSentDate { get => _vAAppraisalSentDate; set => _vAAppraisalSentDate = value; }
        private DirtyValue<StringEnumValue<VABenefitRelatedIndebtedness>> _vABenefitRelatedIndebtedness;
        /// <summary>
        /// VA Do/Do Not Have VA Benefit-Related Indebtedness [VAVOB.X70]
        /// </summary>
        [LoanFieldProperty(Description = "VA Do/Do Not Have VA Benefit-Related Indebtedness")]
        public StringEnumValue<VABenefitRelatedIndebtedness> VABenefitRelatedIndebtedness { get => _vABenefitRelatedIndebtedness; set => _vABenefitRelatedIndebtedness = value; }
        private DirtyValue<string> _vABuilderDescription;
        /// <summary>
        /// VA Management Builder Description [3851]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Builder Description")]
        public string VABuilderDescription { get => _vABuilderDescription; set => _vABuilderDescription = value; }
        private DirtyValue<string> _vABuilderIDNo;
        /// <summary>
        /// VA 261805 Builder ID Number [3348]
        /// </summary>
        [LoanFieldProperty(Description = "VA 261805 Builder ID Number")]
        public string VABuilderIDNo { get => _vABuilderIDNo; set => _vABuilderIDNo = value; }
        private DirtyValue<string> _vAClaimFolderNumber;
        /// <summary>
        /// VA Claim Folder # [VAVOB.X66]
        /// </summary>
        [LoanFieldProperty(Description = "VA Claim Folder #")]
        public string VAClaimFolderNumber { get => _vAClaimFolderNumber; set => _vAClaimFolderNumber = value; }
        private DirtyValue<string> _vAClaimNumber;
        /// <summary>
        /// VA Claim # [VAELIG.X23]
        /// </summary>
        [LoanFieldProperty(Description = "VA Claim #")]
        public string VAClaimNumber { get => _vAClaimNumber; set => _vAClaimNumber = value; }
        private DirtyValue<DateTime?> _vADateNOVAppraisalMailedToBorrower;
        /// <summary>
        /// VA Management Tool - Date NOV and Appraisal Mailed to Borrower [VASUMM.X77]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Date NOV and Appraisal Mailed to Borrower")]
        public DateTime? VADateNOVAppraisalMailedToBorrower { get => _vADateNOVAppraisalMailedToBorrower; set => _vADateNOVAppraisalMailedToBorrower = value; }
        private DirtyValue<bool?> _vAIsDelinquent30Days;
        /// <summary>
        /// VA Management - Is the Veteran currently delinquent 30 days or more on the existing loan? [VASUMM.X36]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management - Is the Veteran currently delinquent 30 days or more on the existing loan?")]
        public bool? VAIsDelinquent30Days { get => _vAIsDelinquent30Days; set => _vAIsDelinquent30Days = value; }
        private DirtyValue<bool?> _vALatePaymentIn6Months;
        /// <summary>
        /// VA Management - Has the Veteran been more than 30 days late on a payment in the last 6 months? [VASUMM.X30]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management - Has the Veteran been more than 30 days late on a payment in the last 6 months?")]
        public bool? VALatePaymentIn6Months { get => _vALatePaymentIn6Months; set => _vALatePaymentIn6Months = value; }
        private DirtyValue<StringEnumValue<VaLoanSummaryApplicantType>> _vaLoanSummaryApplicantType;
        /// <summary>
        /// VaLoanData VaLoanSummaryApplicantType [VAELIG.X66]
        /// </summary>
        public StringEnumValue<VaLoanSummaryApplicantType> VaLoanSummaryApplicantType { get => _vaLoanSummaryApplicantType; set => _vaLoanSummaryApplicantType = value; }
        private DirtyValue<DateTime?> _vANOVDateReceived;
        /// <summary>
        /// VA Management Tool - NOV Date Received [VASUMM.X74]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - NOV Date Received")]
        public DateTime? VANOVDateReceived { get => _vANOVDateReceived; set => _vANOVDateReceived = value; }
        private DirtyValue<DateTime?> _vANOVDateReviewed;
        /// <summary>
        /// VA Management Tool - NOV Date Reviewed [VASUMM.X75]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - NOV Date Reviewed")]
        public DateTime? VANOVDateReviewed { get => _vANOVDateReviewed; set => _vANOVDateReviewed = value; }
        private DirtyValue<DateTime?> _vANOVIssuedDate;
        /// <summary>
        /// VA Management Tool - NOV Issued Date [VASUMM.X76]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - NOV Issued Date")]
        public DateTime? VANOVIssuedDate { get => _vANOVIssuedDate; set => _vANOVIssuedDate = value; }
        private DirtyValue<StringEnumValue<AmortizationType>> _vAOriginalAmortizationType;
        /// <summary>
        /// VA Management - Qualification - Original Amortization Type [VASUMM.X20]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management - Qualification - Original Amortization Type")]
        public StringEnumValue<AmortizationType> VAOriginalAmortizationType { get => _vAOriginalAmortizationType; set => _vAOriginalAmortizationType = value; }
        private DirtyValue<decimal?> _vAOriginalMonthlyPayment;
        /// <summary>
        /// VA Management - Qualification - Original Monthly Payment [VASUMM.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Management - Qualification - Original Monthly Payment")]
        public decimal? VAOriginalMonthlyPayment { get => _vAOriginalMonthlyPayment; set => _vAOriginalMonthlyPayment = value; }
        private DirtyValue<string> _vAQualification2ndTierEntitlement;
        /// <summary>
        /// VA Management Tool - 2nd Tier Entitlement [VASUMM.X96]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - 2nd Tier Entitlement")]
        public string VAQualification2ndTierEntitlement { get => _vAQualification2ndTierEntitlement; set => _vAQualification2ndTierEntitlement = value; }
        private DirtyValue<StringEnumValue<VAQualificationCountryRegion>> _vAQualificationCountryRegion;
        /// <summary>
        /// VA Management Tool - Country Region [VASUMM.X95]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Country Region")]
        public StringEnumValue<VAQualificationCountryRegion> VAQualificationCountryRegion { get => _vAQualificationCountryRegion; set => _vAQualificationCountryRegion = value; }
        private DirtyValue<decimal?> _vAQualificationCountyLimits;
        /// <summary>
        /// VA Management Tool - VA County Limits [VASUMM.X97]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Management Tool - VA County Limits")]
        public decimal? VAQualificationCountyLimits { get => _vAQualificationCountyLimits; set => _vAQualificationCountyLimits = value; }
        private DirtyValue<int?> _vARecoupmentClosingCosts;
        /// <summary>
        /// VA Management - Qualification - Recoup Closing Costs [VASUMM.X27]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Management - Qualification - Recoup Closing Costs")]
        public int? VARecoupmentClosingCosts { get => _vARecoupmentClosingCosts; set => _vARecoupmentClosingCosts = value; }
        private DirtyValue<bool?> _vARecoupmentExcludePrepaids;
        /// <summary>
        /// VA Management - Qualification - Closing Cost Recoupment - Exclude Prepaids [VASUMM.X26]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management - Qualification - Closing Cost Recoupment - Exclude Prepaids")]
        public bool? VARecoupmentExcludePrepaids { get => _vARecoupmentExcludePrepaids; set => _vARecoupmentExcludePrepaids = value; }
        private DirtyValue<decimal?> _vARecoupmentMonthlyDecreaseInPayment;
        /// <summary>
        /// VA Management - Qualification - Closing Cost Recoupment - Monthly Decrease in Payment [VASUMM.X22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "VA Management - Qualification - Closing Cost Recoupment - Monthly Decrease in Payment")]
        public decimal? VARecoupmentMonthlyDecreaseInPayment { get => _vARecoupmentMonthlyDecreaseInPayment; set => _vARecoupmentMonthlyDecreaseInPayment = value; }
        private DirtyValue<int?> _vARecoupmentMonths;
        /// <summary>
        /// VA Management - Qualification - Closing Cost Recoupment - Months [VASUMM.X29]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Management - Qualification - Closing Cost Recoupment - Months")]
        public int? VARecoupmentMonths { get => _vARecoupmentMonths; set => _vARecoupmentMonths = value; }
        private DirtyValue<decimal?> _vARecoupmentTotalClosingCosts;
        /// <summary>
        /// VA Management - Qualification - Closing Cost Recoupment - Total Closing Costs [VASUMM.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Management - Qualification - Closing Cost Recoupment - Total Closing Costs")]
        public decimal? VARecoupmentTotalClosingCosts { get => _vARecoupmentTotalClosingCosts; set => _vARecoupmentTotalClosingCosts = value; }
        private DirtyValue<int?> _vARecoupmentYears;
        /// <summary>
        /// VA Management - Qualification - Closing Cost Recoupment - Years [VASUMM.X28]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "VA Management - Qualification - Closing Cost Recoupment - Years")]
        public int? VARecoupmentYears { get => _vARecoupmentYears; set => _vARecoupmentYears = value; }
        private DirtyValue<DateTime?> _vATrackingCertOfCommitmentIssued;
        /// <summary>
        /// VA Management Tool - Cert. of Commitment Issued by VA [VASUMM.X86]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Cert. of Commitment Issued by VA")]
        public DateTime? VATrackingCertOfCommitmentIssued { get => _vATrackingCertOfCommitmentIssued; set => _vATrackingCertOfCommitmentIssued = value; }
        private DirtyValue<DateTime?> _vATrackingCOEIssueDate;
        /// <summary>
        /// VA Management Tool - COE Issue Date [VASUMM.X80]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - COE Issue Date")]
        public DateTime? VATrackingCOEIssueDate { get => _vATrackingCOEIssueDate; set => _vATrackingCOEIssueDate = value; }
        private DirtyValue<string> _vATrackingCOEIssueHistory;
        /// <summary>
        /// VA Management Tool - COE Issue History [VASUMM.X81]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - COE Issue History")]
        public string VATrackingCOEIssueHistory { get => _vATrackingCOEIssueHistory; set => _vATrackingCOEIssueHistory = value; }
        private DirtyValue<DateTime?> _vATrackingFinalApprovalCommitmentDate;
        /// <summary>
        /// VA Management Tool - Final Approval Commitment Date [VASUMM.X88]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Final Approval Commitment Date")]
        public DateTime? VATrackingFinalApprovalCommitmentDate { get => _vATrackingFinalApprovalCommitmentDate; set => _vATrackingFinalApprovalCommitmentDate = value; }
        private DirtyValue<bool?> _vATrackingGSAExclusionaryListChecked;
        /// <summary>
        /// VA Management Tool - GSA Exclusionary List Checked [VASUMM.X85]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - GSA Exclusionary List Checked")]
        public bool? VATrackingGSAExclusionaryListChecked { get => _vATrackingGSAExclusionaryListChecked; set => _vATrackingGSAExclusionaryListChecked = value; }
        private DirtyValue<bool?> _vATrackingInuranceFloodPolicy;
        /// <summary>
        /// VA Management Tool - Flood Policy [VASUMM.X91]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Flood Policy")]
        public bool? VATrackingInuranceFloodPolicy { get => _vATrackingInuranceFloodPolicy; set => _vATrackingInuranceFloodPolicy = value; }
        private DirtyValue<bool?> _vATrackingInuranceHazardPolicy;
        /// <summary>
        /// VA Management Tool - Hazard Policy [VASUMM.X92]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Hazard Policy")]
        public bool? VATrackingInuranceHazardPolicy { get => _vATrackingInuranceHazardPolicy; set => _vATrackingInuranceHazardPolicy = value; }
        private DirtyValue<bool?> _vATrackingInuranceWindOrHailPolicy;
        /// <summary>
        /// VA Management Tool - Wind/Hail Policy [VASUMM.X94]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Wind/Hail Policy")]
        public bool? VATrackingInuranceWindOrHailPolicy { get => _vATrackingInuranceWindOrHailPolicy; set => _vATrackingInuranceWindOrHailPolicy = value; }
        private DirtyValue<bool?> _vATrackingInuranceWoodDestroyingPolicy;
        /// <summary>
        /// VA Management Tool - Wood Destroying Policy [VASUMM.X93]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Wood Destroying Policy")]
        public bool? VATrackingInuranceWoodDestroyingPolicy { get => _vATrackingInuranceWoodDestroyingPolicy; set => _vATrackingInuranceWoodDestroyingPolicy = value; }
        private DirtyValue<bool?> _vATrackingIsSARLAPPCertified;
        /// <summary>
        /// VA Management Tool - Is SAR LAPP Certified [VASUMM.X72]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Is SAR LAPP Certified")]
        public bool? VATrackingIsSARLAPPCertified { get => _vATrackingIsSARLAPPCertified; set => _vATrackingIsSARLAPPCertified = value; }
        private DirtyValue<DateTime?> _vATrackingLoanGuaranteeCertReceipt;
        /// <summary>
        /// VA Management Tool - Loan Guarantee Cert. (LGC) Receipt [VASUMM.X84]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Loan Guarantee Cert. (LGC) Receipt")]
        public DateTime? VATrackingLoanGuaranteeCertReceipt { get => _vATrackingLoanGuaranteeCertReceipt; set => _vATrackingLoanGuaranteeCertReceipt = value; }
        private DirtyValue<DateTime?> _vATrackingMasterCommitmentLockExpired;
        /// <summary>
        /// VA Management Tool - VA Master Commitment Lock Expired [VASUMM.X87]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - VA Master Commitment Lock Expired")]
        public DateTime? VATrackingMasterCommitmentLockExpired { get => _vATrackingMasterCommitmentLockExpired; set => _vATrackingMasterCommitmentLockExpired = value; }
        private DirtyValue<DateTime?> _vATrackingOrderedDate;
        /// <summary>
        /// VA Management Tool - Ordered Date [VASUMM.X79]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Ordered Date")]
        public DateTime? VATrackingOrderedDate { get => _vATrackingOrderedDate; set => _vATrackingOrderedDate = value; }
        private DirtyValue<DateTime?> _vATrackingPaidDate;
        /// <summary>
        /// VA Management Tool - Paid Date [VASUMM.X82]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Paid Date")]
        public DateTime? VATrackingPaidDate { get => _vATrackingPaidDate; set => _vATrackingPaidDate = value; }
        private DirtyValue<DateTime?> _vATrackingPurchaseContractDate;
        /// <summary>
        /// VA Management Tool - Purchase Contract Date [VASUMM.X89]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Purchase Contract Date")]
        public DateTime? VATrackingPurchaseContractDate { get => _vATrackingPurchaseContractDate; set => _vATrackingPurchaseContractDate = value; }
        private DirtyValue<bool?> _vATrackingReceiptReceived;
        /// <summary>
        /// VA Management Tool - Receipt Received [VASUMM.X83]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - Receipt Received")]
        public bool? VATrackingReceiptReceived { get => _vATrackingReceiptReceived; set => _vATrackingReceiptReceived = value; }
        private DirtyValue<string> _vATrackingSARID;
        /// <summary>
        /// VA Management Tool - SAR ID [VASUMM.X71]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - SAR ID")]
        public string VATrackingSARID { get => _vATrackingSARID; set => _vATrackingSARID = value; }
        private DirtyValue<string> _vATrackingSARName;
        /// <summary>
        /// VA Management Tool - SAR Name [VASUMM.X70]
        /// </summary>
        [LoanFieldProperty(Description = "VA Management Tool - SAR Name")]
        public string VATrackingSARName { get => _vATrackingSARName; set => _vATrackingSARName = value; }
        private DirtyValue<bool?> _ventFanIndicator;
        /// <summary>
        /// VA Equipment Vent Fan [316]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment Vent Fan", OptionsJson = "{\"true\":\"Vent / Fan\"}")]
        public bool? VentFanIndicator { get => _ventFanIndicator; set => _ventFanIndicator = value; }
        private DirtyValue<bool?> _veteranDischargedIndicator;
        /// <summary>
        /// VA Discharged/Have Svc-Connected Disabilities [VAELIG.X22]
        /// </summary>
        [LoanFieldProperty(Description = "VA Discharged/Have Svc-Connected Disabilities", OptionsJson = "{\"true\":\"Discharged / have any service-connected disabilities\"}")]
        public bool? VeteranDischargedIndicator { get => _veteranDischargedIndicator; set => _veteranDischargedIndicator = value; }
        private DirtyValue<StringEnumValue<VeteranServiceType>> _veteranServiceType;
        /// <summary>
        /// VA Veteran Service Status [955]
        /// </summary>
        [LoanFieldProperty(Description = "VA Veteran Service Status")]
        public StringEnumValue<VeteranServiceType> VeteranServiceType { get => _veteranServiceType; set => _veteranServiceType = value; }
        private DirtyValue<string> _warrantorAddress;
        /// <summary>
        /// VA New/Prop Constr Warrantor Addr [1026]
        /// </summary>
        [LoanFieldProperty(Description = "VA New/Prop Constr Warrantor Addr")]
        public string WarrantorAddress { get => _warrantorAddress; set => _warrantorAddress = value; }
        private DirtyValue<string> _warrantorCity;
        /// <summary>
        /// VA New/Prop Constr Warrantor City [GAPPR.X11]
        /// </summary>
        [LoanFieldProperty(Description = "VA New/Prop Constr Warrantor City")]
        public string WarrantorCity { get => _warrantorCity; set => _warrantorCity = value; }
        private DirtyValue<string> _warrantorName;
        /// <summary>
        /// VA New/Prop Constr Warrantor Name [1025]
        /// </summary>
        [LoanFieldProperty(Description = "VA New/Prop Constr Warrantor Name")]
        public string WarrantorName { get => _warrantorName; set => _warrantorName = value; }
        private DirtyValue<string> _warrantorPhone;
        /// <summary>
        /// VA New/Prop Constr Warrantor Phone [1027]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "VA New/Prop Constr Warrantor Phone")]
        public string WarrantorPhone { get => _warrantorPhone; set => _warrantorPhone = value; }
        private DirtyValue<string> _warrantorPostalCode;
        /// <summary>
        /// VA New/Prop Constr Warrantor Zip [GAPPR.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "VA New/Prop Constr Warrantor Zip")]
        public string WarrantorPostalCode { get => _warrantorPostalCode; set => _warrantorPostalCode = value; }
        private DirtyValue<string> _warrantorState;
        /// <summary>
        /// VA New/Prop Constr Warrantor State [GAPPR.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "VA New/Prop Constr Warrantor State")]
        public string WarrantorState { get => _warrantorState; set => _warrantorState = value; }
        private DirtyValue<DateTime?> _warrantyProgramExpirationDate;
        /// <summary>
        /// Subject Property Warranty Program Expiration Date [725]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Warranty Program Expiration Date")]
        public DateTime? WarrantyProgramExpirationDate { get => _warrantyProgramExpirationDate; set => _warrantyProgramExpirationDate = value; }
        private DirtyValue<bool?> _wWCarpetIndicator;
        /// <summary>
        /// VA Equipment W/W Carpet [318]
        /// </summary>
        [LoanFieldProperty(Description = "VA Equipment W/W Carpet", OptionsJson = "{\"true\":\"W / W Carpet\"}")]
        public bool? WWCarpetIndicator { get => _wWCarpetIndicator; set => _wWCarpetIndicator = value; }
        internal override bool DirtyInternal
        {
            get => _acres.Dirty
                || _additionalSecurityDescription.Dirty
                || _administratorAddress.Dirty
                || _administratorCity.Dirty
                || _administratorContact.Dirty
                || _administratorName.Dirty
                || _administratorPostalCode.Dirty
                || _administratorState.Dirty
                || _ageOfProperty.Dirty
                || _amountSpentOnEnergyImprovements.Dirty
                || _amountTypeWithheld.Dirty
                || _amountWithheld.Dirty
                || _annualGroundRent.Dirty
                || _annualMaintenanceAssessment.Dirty
                || _annualRealEstateTaxes.Dirty
                || _annualSpecialAssessment.Dirty
                || _applicantAddressCity.Dirty
                || _applicantAddressPostalCode.Dirty
                || _applicantAddressState.Dirty
                || _applicantAddressStreetLine1.Dirty
                || _applicantBirthDate.Dirty
                || _applicantEmailAddressText.Dirty
                || _applicantFirstNameWithMiddleName.Dirty
                || _applicantHmdaGenderType.Dirty
                || _applicantHomePhoneNumber.Dirty
                || _applicantLastNameWithSuffix.Dirty
                || _applicantTaxIdentificationIdentifier.Dirty
                || _appraisalType.Dirty
                || _automaticProcedure.Dirty
                || _availableForInspectionAMIndicator.Dirty
                || _availableForInspectionDateAndTime.Dirty
                || _borrowerPaidDiscountPointsTotalAmount.Dirty
                || _buildingType.Dirty
                || _buyerPurchasingLotSeparately.Dirty
                || _cashPaymentFromVeteran.Dirty
                || _claimDisabilityBenefits.Dirty
                || _clothesWasherIndicator.Dirty
                || _constructionCompletedDate.Dirty
                || _constructionPlan.Dirty
                || _constructionWarrantyIncluded.Dirty
                || _contractNoApprovedByVA.Dirty
                || _creditScore.Dirty
                || _currentlyOnMilitaryDuty.Dirty
                || _dateAquiredLand.Dirty
                || _dateOfAssignment.Dirty
                || _dateSAR.Dirty
                || _disabilityAmountCollected.Dirty
                || _discountPercentage.Dirty
                || _discountPoint.Dirty
                || _dishwasherIndicator.Dirty
                || _dryerIndicator.Dirty
                || _emailToBeNotifiedWhenUploaded.Dirty
                || _energyImprovementsAdditionOfFeature.Dirty
                || _entitlementCode.Dirty
                || _equipmentOtherDescription.Dirty
                || _excludeTaxesInsuranceIndicator.Dirty
                || _finalDiscountAmount.Dirty
                || _finalFundingFeeAmount.Dirty
                || _firstChattelLoanType.Dirty
                || _firstTimeUse.Dirty
                || _fundingFeeExempt.Dirty
                || _garbageDisposalIndicator.Dirty
                || _id.Dirty
                || _initialTotal.Dirty
                || _inspectionWillBeMadeBy.Dirty
                || _insulation.Dirty
                || _insuranceType.Dirty
                || _irregularLotSizeInSquareFeet.Dirty
                || _isDelinquent30Days.Dirty
                || _keysAtAddress.Dirty
                || _landPurchasePrice.Dirty
                || _leaseholdType.Dirty
                || _lenderSAR.Dirty
                || _loanAnalysisRemarks1.Dirty
                || _loanAnalysisRemarks2.Dirty
                || _loanAnalysisRemarks3.Dirty
                || _loanAnalysisRemarks4.Dirty
                || _loanAnalysisRemarks5.Dirty
                || _loanAnalysisRemarks6.Dirty
                || _loanAnalysisRemarks7.Dirty
                || _loanAnalysisRemarks8.Dirty
                || _loanAnalysisRemarks9.Dirty
                || _loanCode.Dirty
                || _loanProcedure.Dirty
                || _loanProcessedUnderAU.Dirty
                || _loanSummaryRemarks1.Dirty
                || _loanSummaryRemarks2.Dirty
                || _loanSummaryRemarks3.Dirty
                || _loanSummaryRemarks4.Dirty
                || _loanSummaryRemarks5.Dirty
                || _loanSummaryRemarks6.Dirty
                || _loanSummaryRemarks7.Dirty
                || _loanSummaryRemarks8.Dirty
                || _lotDimensions.Dirty
                || _mailingAddress.Dirty
                || _mailingCity.Dirty
                || _mailingPostalCode.Dirty
                || _mailingState.Dirty
                || _manufacturedHome.Dirty
                || _mCRVNumber.Dirty
                || _militaryBranchOfService.Dirty
                || _mineralRightsReserved.Dirty
                || _nameOfOccupant.Dirty
                || _nameOfOwner.Dirty
                || _nameOfWarrantyProgram.Dirty
                || _negativeRents.Dirty
                || _noEnergyImprovements.Dirty
                || _nonrealtyDescription.Dirty
                || _numberOfBuildings.Dirty
                || _occupantTelephone.Dirty
                || _onMilitaryDutyFollowingSeparation.Dirty
                || _originalInterestRate.Dirty
                || _originalLoanAmount.Dirty
                || _originalTerm.Dirty
                || _originalValueEstimateChanged.Dirty
                || _originationFeeAmount.Dirty
                || _otherClosingCosts.Dirty
                || _otherDescriptionEstateProperty.Dirty
                || _otherDescriptionLoanType.Dirty
                || _otherEstateProperty.Dirty
                || _otherImprovements.Dirty
                || _otherLoanType.Dirty
                || _paidInFullVALoanNumber.Dirty
                || _payoffIndicator1.Dirty
                || _payoffIndicator2.Dirty
                || _payoffIndicator3.Dirty
                || _payoffIndicator4.Dirty
                || _payoffIndicator5.Dirty
                || _payoffIndicator6.Dirty
                || _payoffIndicator7.Dirty
                || _payoffIndicator8.Dirty
                || _payoffIndicator9.Dirty
                || _pestReportFee.Dirty
                || _plansSubmitted.Dirty
                || _pOCAddress.Dirty
                || _pOCCity.Dirty
                || _pOCName.Dirty
                || _pOCPhone.Dirty
                || _pOCState.Dirty
                || _pOCZipCode.Dirty
                || _preliminaryDiscountAmount.Dirty
                || _preliminaryFundingFeeAmount.Dirty
                || _preliminaryTotal.Dirty
                || _previousVALoanIndicator.Dirty
                || _priorApprovalProcedure.Dirty
                || _priorLoanType.Dirty
                || _propertyDesignation.Dirty
                || _propertyGrossLivingArea.Dirty
                || _propertyLegalDescription1.Dirty
                || _propertyLegalDescription2.Dirty
                || _propertyLegalDescription3.Dirty
                || _propertyLegalDescription4.Dirty
                || _propertyOccupancyType.Dirty
                || _proposedSaleContractAttached.Dirty
                || _purposeOfLoan.Dirty
                || _rangeOvenIndicator.Dirty
                || _reasonableValueCompleted.Dirty
                || _refrigeratorIndicator.Dirty
                || _rent.Dirty
                || _replacementOfSystem.Dirty
                || _riskClasification.Dirty
                || _serviceNumber.Dirty
                || _solarHeatingOrCooling.Dirty
                || _specialAssessmentComments1.Dirty
                || _specialAssessmentComments2.Dirty
                || _specialAssessmentComments3.Dirty
                || _streetAccess.Dirty
                || _streetMaintenance.Dirty
                || _systemUsed.Dirty
                || _title.Dirty
                || _titleLimitations1.Dirty
                || _titleLimitations2.Dirty
                || _titleLimitations3.Dirty
                || _totalBaths.Dirty
                || _totalBedrooms.Dirty
                || _totalDebtMonthlyPayment.Dirty
                || _totalDiscountPointCharged.Dirty
                || _totalDiscountPointsCharged.Dirty
                || _totalForMaxLoanAmount.Dirty
                || _totalMonthlyPayment.Dirty
                || _totalProposedMonthlyPayment.Dirty
                || _totalRooms.Dirty
                || _totalUnpaidSpecialAssessments.Dirty
                || _typeOfHybridARM.Dirty
                || _typeOfMortgage.Dirty
                || _typeOfOwnsership.Dirty
                || _typeOfStructure.Dirty
                || _typeOfVeteran.Dirty
                || _unsecuredLoanType.Dirty
                || _utilitiesElectricDescription.Dirty
                || _utilitiesGasDescription.Dirty
                || _utilitiesSewerDescription.Dirty
                || _utilitiesWaterDescription.Dirty
                || _vAAppraisalSentDate.Dirty
                || _vABenefitRelatedIndebtedness.Dirty
                || _vABuilderDescription.Dirty
                || _vABuilderIDNo.Dirty
                || _vAClaimFolderNumber.Dirty
                || _vAClaimNumber.Dirty
                || _vADateNOVAppraisalMailedToBorrower.Dirty
                || _vAIsDelinquent30Days.Dirty
                || _vALatePaymentIn6Months.Dirty
                || _vaLoanSummaryApplicantType.Dirty
                || _vANOVDateReceived.Dirty
                || _vANOVDateReviewed.Dirty
                || _vANOVIssuedDate.Dirty
                || _vAOriginalAmortizationType.Dirty
                || _vAOriginalMonthlyPayment.Dirty
                || _vAQualification2ndTierEntitlement.Dirty
                || _vAQualificationCountryRegion.Dirty
                || _vAQualificationCountyLimits.Dirty
                || _vARecoupmentClosingCosts.Dirty
                || _vARecoupmentExcludePrepaids.Dirty
                || _vARecoupmentMonthlyDecreaseInPayment.Dirty
                || _vARecoupmentMonths.Dirty
                || _vARecoupmentTotalClosingCosts.Dirty
                || _vARecoupmentYears.Dirty
                || _vATrackingCertOfCommitmentIssued.Dirty
                || _vATrackingCOEIssueDate.Dirty
                || _vATrackingCOEIssueHistory.Dirty
                || _vATrackingFinalApprovalCommitmentDate.Dirty
                || _vATrackingGSAExclusionaryListChecked.Dirty
                || _vATrackingInuranceFloodPolicy.Dirty
                || _vATrackingInuranceHazardPolicy.Dirty
                || _vATrackingInuranceWindOrHailPolicy.Dirty
                || _vATrackingInuranceWoodDestroyingPolicy.Dirty
                || _vATrackingIsSARLAPPCertified.Dirty
                || _vATrackingLoanGuaranteeCertReceipt.Dirty
                || _vATrackingMasterCommitmentLockExpired.Dirty
                || _vATrackingOrderedDate.Dirty
                || _vATrackingPaidDate.Dirty
                || _vATrackingPurchaseContractDate.Dirty
                || _vATrackingReceiptReceived.Dirty
                || _vATrackingSARID.Dirty
                || _vATrackingSARName.Dirty
                || _ventFanIndicator.Dirty
                || _veteranDischargedIndicator.Dirty
                || _veteranServiceType.Dirty
                || _warrantorAddress.Dirty
                || _warrantorCity.Dirty
                || _warrantorName.Dirty
                || _warrantorPhone.Dirty
                || _warrantorPostalCode.Dirty
                || _warrantorState.Dirty
                || _warrantyProgramExpirationDate.Dirty
                || _wWCarpetIndicator.Dirty
                || _militaryServices?.Dirty == true
                || _previousVaLoans?.Dirty == true;
            set
            {
                _acres.Dirty = value;
                _additionalSecurityDescription.Dirty = value;
                _administratorAddress.Dirty = value;
                _administratorCity.Dirty = value;
                _administratorContact.Dirty = value;
                _administratorName.Dirty = value;
                _administratorPostalCode.Dirty = value;
                _administratorState.Dirty = value;
                _ageOfProperty.Dirty = value;
                _amountSpentOnEnergyImprovements.Dirty = value;
                _amountTypeWithheld.Dirty = value;
                _amountWithheld.Dirty = value;
                _annualGroundRent.Dirty = value;
                _annualMaintenanceAssessment.Dirty = value;
                _annualRealEstateTaxes.Dirty = value;
                _annualSpecialAssessment.Dirty = value;
                _applicantAddressCity.Dirty = value;
                _applicantAddressPostalCode.Dirty = value;
                _applicantAddressState.Dirty = value;
                _applicantAddressStreetLine1.Dirty = value;
                _applicantBirthDate.Dirty = value;
                _applicantEmailAddressText.Dirty = value;
                _applicantFirstNameWithMiddleName.Dirty = value;
                _applicantHmdaGenderType.Dirty = value;
                _applicantHomePhoneNumber.Dirty = value;
                _applicantLastNameWithSuffix.Dirty = value;
                _applicantTaxIdentificationIdentifier.Dirty = value;
                _appraisalType.Dirty = value;
                _automaticProcedure.Dirty = value;
                _availableForInspectionAMIndicator.Dirty = value;
                _availableForInspectionDateAndTime.Dirty = value;
                _borrowerPaidDiscountPointsTotalAmount.Dirty = value;
                _buildingType.Dirty = value;
                _buyerPurchasingLotSeparately.Dirty = value;
                _cashPaymentFromVeteran.Dirty = value;
                _claimDisabilityBenefits.Dirty = value;
                _clothesWasherIndicator.Dirty = value;
                _constructionCompletedDate.Dirty = value;
                _constructionPlan.Dirty = value;
                _constructionWarrantyIncluded.Dirty = value;
                _contractNoApprovedByVA.Dirty = value;
                _creditScore.Dirty = value;
                _currentlyOnMilitaryDuty.Dirty = value;
                _dateAquiredLand.Dirty = value;
                _dateOfAssignment.Dirty = value;
                _dateSAR.Dirty = value;
                _disabilityAmountCollected.Dirty = value;
                _discountPercentage.Dirty = value;
                _discountPoint.Dirty = value;
                _dishwasherIndicator.Dirty = value;
                _dryerIndicator.Dirty = value;
                _emailToBeNotifiedWhenUploaded.Dirty = value;
                _energyImprovementsAdditionOfFeature.Dirty = value;
                _entitlementCode.Dirty = value;
                _equipmentOtherDescription.Dirty = value;
                _excludeTaxesInsuranceIndicator.Dirty = value;
                _finalDiscountAmount.Dirty = value;
                _finalFundingFeeAmount.Dirty = value;
                _firstChattelLoanType.Dirty = value;
                _firstTimeUse.Dirty = value;
                _fundingFeeExempt.Dirty = value;
                _garbageDisposalIndicator.Dirty = value;
                _id.Dirty = value;
                _initialTotal.Dirty = value;
                _inspectionWillBeMadeBy.Dirty = value;
                _insulation.Dirty = value;
                _insuranceType.Dirty = value;
                _irregularLotSizeInSquareFeet.Dirty = value;
                _isDelinquent30Days.Dirty = value;
                _keysAtAddress.Dirty = value;
                _landPurchasePrice.Dirty = value;
                _leaseholdType.Dirty = value;
                _lenderSAR.Dirty = value;
                _loanAnalysisRemarks1.Dirty = value;
                _loanAnalysisRemarks2.Dirty = value;
                _loanAnalysisRemarks3.Dirty = value;
                _loanAnalysisRemarks4.Dirty = value;
                _loanAnalysisRemarks5.Dirty = value;
                _loanAnalysisRemarks6.Dirty = value;
                _loanAnalysisRemarks7.Dirty = value;
                _loanAnalysisRemarks8.Dirty = value;
                _loanAnalysisRemarks9.Dirty = value;
                _loanCode.Dirty = value;
                _loanProcedure.Dirty = value;
                _loanProcessedUnderAU.Dirty = value;
                _loanSummaryRemarks1.Dirty = value;
                _loanSummaryRemarks2.Dirty = value;
                _loanSummaryRemarks3.Dirty = value;
                _loanSummaryRemarks4.Dirty = value;
                _loanSummaryRemarks5.Dirty = value;
                _loanSummaryRemarks6.Dirty = value;
                _loanSummaryRemarks7.Dirty = value;
                _loanSummaryRemarks8.Dirty = value;
                _lotDimensions.Dirty = value;
                _mailingAddress.Dirty = value;
                _mailingCity.Dirty = value;
                _mailingPostalCode.Dirty = value;
                _mailingState.Dirty = value;
                _manufacturedHome.Dirty = value;
                _mCRVNumber.Dirty = value;
                _militaryBranchOfService.Dirty = value;
                _mineralRightsReserved.Dirty = value;
                _nameOfOccupant.Dirty = value;
                _nameOfOwner.Dirty = value;
                _nameOfWarrantyProgram.Dirty = value;
                _negativeRents.Dirty = value;
                _noEnergyImprovements.Dirty = value;
                _nonrealtyDescription.Dirty = value;
                _numberOfBuildings.Dirty = value;
                _occupantTelephone.Dirty = value;
                _onMilitaryDutyFollowingSeparation.Dirty = value;
                _originalInterestRate.Dirty = value;
                _originalLoanAmount.Dirty = value;
                _originalTerm.Dirty = value;
                _originalValueEstimateChanged.Dirty = value;
                _originationFeeAmount.Dirty = value;
                _otherClosingCosts.Dirty = value;
                _otherDescriptionEstateProperty.Dirty = value;
                _otherDescriptionLoanType.Dirty = value;
                _otherEstateProperty.Dirty = value;
                _otherImprovements.Dirty = value;
                _otherLoanType.Dirty = value;
                _paidInFullVALoanNumber.Dirty = value;
                _payoffIndicator1.Dirty = value;
                _payoffIndicator2.Dirty = value;
                _payoffIndicator3.Dirty = value;
                _payoffIndicator4.Dirty = value;
                _payoffIndicator5.Dirty = value;
                _payoffIndicator6.Dirty = value;
                _payoffIndicator7.Dirty = value;
                _payoffIndicator8.Dirty = value;
                _payoffIndicator9.Dirty = value;
                _pestReportFee.Dirty = value;
                _plansSubmitted.Dirty = value;
                _pOCAddress.Dirty = value;
                _pOCCity.Dirty = value;
                _pOCName.Dirty = value;
                _pOCPhone.Dirty = value;
                _pOCState.Dirty = value;
                _pOCZipCode.Dirty = value;
                _preliminaryDiscountAmount.Dirty = value;
                _preliminaryFundingFeeAmount.Dirty = value;
                _preliminaryTotal.Dirty = value;
                _previousVALoanIndicator.Dirty = value;
                _priorApprovalProcedure.Dirty = value;
                _priorLoanType.Dirty = value;
                _propertyDesignation.Dirty = value;
                _propertyGrossLivingArea.Dirty = value;
                _propertyLegalDescription1.Dirty = value;
                _propertyLegalDescription2.Dirty = value;
                _propertyLegalDescription3.Dirty = value;
                _propertyLegalDescription4.Dirty = value;
                _propertyOccupancyType.Dirty = value;
                _proposedSaleContractAttached.Dirty = value;
                _purposeOfLoan.Dirty = value;
                _rangeOvenIndicator.Dirty = value;
                _reasonableValueCompleted.Dirty = value;
                _refrigeratorIndicator.Dirty = value;
                _rent.Dirty = value;
                _replacementOfSystem.Dirty = value;
                _riskClasification.Dirty = value;
                _serviceNumber.Dirty = value;
                _solarHeatingOrCooling.Dirty = value;
                _specialAssessmentComments1.Dirty = value;
                _specialAssessmentComments2.Dirty = value;
                _specialAssessmentComments3.Dirty = value;
                _streetAccess.Dirty = value;
                _streetMaintenance.Dirty = value;
                _systemUsed.Dirty = value;
                _title.Dirty = value;
                _titleLimitations1.Dirty = value;
                _titleLimitations2.Dirty = value;
                _titleLimitations3.Dirty = value;
                _totalBaths.Dirty = value;
                _totalBedrooms.Dirty = value;
                _totalDebtMonthlyPayment.Dirty = value;
                _totalDiscountPointCharged.Dirty = value;
                _totalDiscountPointsCharged.Dirty = value;
                _totalForMaxLoanAmount.Dirty = value;
                _totalMonthlyPayment.Dirty = value;
                _totalProposedMonthlyPayment.Dirty = value;
                _totalRooms.Dirty = value;
                _totalUnpaidSpecialAssessments.Dirty = value;
                _typeOfHybridARM.Dirty = value;
                _typeOfMortgage.Dirty = value;
                _typeOfOwnsership.Dirty = value;
                _typeOfStructure.Dirty = value;
                _typeOfVeteran.Dirty = value;
                _unsecuredLoanType.Dirty = value;
                _utilitiesElectricDescription.Dirty = value;
                _utilitiesGasDescription.Dirty = value;
                _utilitiesSewerDescription.Dirty = value;
                _utilitiesWaterDescription.Dirty = value;
                _vAAppraisalSentDate.Dirty = value;
                _vABenefitRelatedIndebtedness.Dirty = value;
                _vABuilderDescription.Dirty = value;
                _vABuilderIDNo.Dirty = value;
                _vAClaimFolderNumber.Dirty = value;
                _vAClaimNumber.Dirty = value;
                _vADateNOVAppraisalMailedToBorrower.Dirty = value;
                _vAIsDelinquent30Days.Dirty = value;
                _vALatePaymentIn6Months.Dirty = value;
                _vaLoanSummaryApplicantType.Dirty = value;
                _vANOVDateReceived.Dirty = value;
                _vANOVDateReviewed.Dirty = value;
                _vANOVIssuedDate.Dirty = value;
                _vAOriginalAmortizationType.Dirty = value;
                _vAOriginalMonthlyPayment.Dirty = value;
                _vAQualification2ndTierEntitlement.Dirty = value;
                _vAQualificationCountryRegion.Dirty = value;
                _vAQualificationCountyLimits.Dirty = value;
                _vARecoupmentClosingCosts.Dirty = value;
                _vARecoupmentExcludePrepaids.Dirty = value;
                _vARecoupmentMonthlyDecreaseInPayment.Dirty = value;
                _vARecoupmentMonths.Dirty = value;
                _vARecoupmentTotalClosingCosts.Dirty = value;
                _vARecoupmentYears.Dirty = value;
                _vATrackingCertOfCommitmentIssued.Dirty = value;
                _vATrackingCOEIssueDate.Dirty = value;
                _vATrackingCOEIssueHistory.Dirty = value;
                _vATrackingFinalApprovalCommitmentDate.Dirty = value;
                _vATrackingGSAExclusionaryListChecked.Dirty = value;
                _vATrackingInuranceFloodPolicy.Dirty = value;
                _vATrackingInuranceHazardPolicy.Dirty = value;
                _vATrackingInuranceWindOrHailPolicy.Dirty = value;
                _vATrackingInuranceWoodDestroyingPolicy.Dirty = value;
                _vATrackingIsSARLAPPCertified.Dirty = value;
                _vATrackingLoanGuaranteeCertReceipt.Dirty = value;
                _vATrackingMasterCommitmentLockExpired.Dirty = value;
                _vATrackingOrderedDate.Dirty = value;
                _vATrackingPaidDate.Dirty = value;
                _vATrackingPurchaseContractDate.Dirty = value;
                _vATrackingReceiptReceived.Dirty = value;
                _vATrackingSARID.Dirty = value;
                _vATrackingSARName.Dirty = value;
                _ventFanIndicator.Dirty = value;
                _veteranDischargedIndicator.Dirty = value;
                _veteranServiceType.Dirty = value;
                _warrantorAddress.Dirty = value;
                _warrantorCity.Dirty = value;
                _warrantorName.Dirty = value;
                _warrantorPhone.Dirty = value;
                _warrantorPostalCode.Dirty = value;
                _warrantorState.Dirty = value;
                _warrantyProgramExpirationDate.Dirty = value;
                _wWCarpetIndicator.Dirty = value;
                if (_militaryServices != null) _militaryServices.Dirty = value;
                if (_previousVaLoans != null) _previousVaLoans.Dirty = value;
            }
        }
    }
}