using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ServicingDisclosure
    /// </summary>
    public sealed partial class ServicingDisclosure : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _disclosurePercent1;
        /// <summary>
        /// Disclosure 3B % 1 [RESPA.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Disclosure 3B % 1")]
        public decimal? DisclosurePercent1 { get => _disclosurePercent1; set => SetField(ref _disclosurePercent1, value); }
        private DirtyValue<decimal?> _disclosurePercent2;
        /// <summary>
        /// Disclosure 3B % 2 [RESPA.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Disclosure 3B % 2")]
        public decimal? DisclosurePercent2 { get => _disclosurePercent2; set => SetField(ref _disclosurePercent2, value); }
        private DirtyValue<decimal?> _disclosurePercent3;
        /// <summary>
        /// Disclosure 3B % 3 [RESPA.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Disclosure 3B % 3")]
        public decimal? DisclosurePercent3 { get => _disclosurePercent3; set => SetField(ref _disclosurePercent3, value); }
        private DirtyValue<string> _disclosureYear1;
        /// <summary>
        /// Disclosure 3B Yr 1 [RESPA.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure 3B Yr 1")]
        public string DisclosureYear1 { get => _disclosureYear1; set => SetField(ref _disclosureYear1, value); }
        private DirtyValue<string> _disclosureYear2;
        /// <summary>
        /// Disclosure 3B Yr 2 [RESPA.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure 3B Yr 2")]
        public string DisclosureYear2 { get => _disclosureYear2; set => SetField(ref _disclosureYear2, value); }
        private DirtyValue<string> _disclosureYear3;
        /// <summary>
        /// Disclosure 3B Yr 3 [RESPA.X26]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure 3B Yr 3")]
        public string DisclosureYear3 { get => _disclosureYear3; set => SetField(ref _disclosureYear3, value); }
        private DirtyValue<bool?> _fiftyOneTo75Indicator;
        /// <summary>
        /// Disclosure 2 51-75% [RESPA.X16]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure 2 51-75%", OptionsJson = "{\"true\":\"51 to 75%\"}")]
        public bool? FiftyOneTo75Indicator { get => _fiftyOneTo75Indicator; set => SetField(ref _fiftyOneTo75Indicator, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// ServicingDisclosure Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _seventySixTo100Indicator;
        /// <summary>
        /// Disclosure 2 76-100% [RESPA.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure 2 76-100%", OptionsJson = "{\"true\":\"76 to 100%\"}")]
        public bool? SeventySixTo100Indicator { get => _seventySixTo100Indicator; set => SetField(ref _seventySixTo100Indicator, value); }
        private DirtyValue<StringEnumValue<DoesOrDoesNot2>> _thisEstimateType;
        /// <summary>
        /// Disclosure 2 This Estimate Does/Does Not [RESPA.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure 2 This Estimate Does/Does Not")]
        public StringEnumValue<DoesOrDoesNot2> ThisEstimateType { get => _thisEstimateType; set => SetField(ref _thisEstimateType, value); }
        private DirtyValue<StringEnumValue<DoesOrDoesNot2>> _thisInformationType;
        /// <summary>
        /// Disclosure This Information Does/Does Not Include [RESPA.X18]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure This Information Does/Does Not Include")]
        public StringEnumValue<DoesOrDoesNot2> ThisInformationType { get => _thisInformationType; set => SetField(ref _thisInformationType, value); }
        private DirtyValue<bool?> _thisIsOurRecordOfTransferingIndicator;
        /// <summary>
        /// Disclosure 3B This Is Our Record [RESPA.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure 3B This Is Our Record", OptionsJson = "{\"true\":\"This is our record of transferring the servicing of the first lien mortgage loans\"}")]
        public bool? ThisIsOurRecordOfTransferingIndicator { get => _thisIsOurRecordOfTransferingIndicator; set => SetField(ref _thisIsOurRecordOfTransferingIndicator, value); }
        private DirtyValue<bool?> _twentySixTo50Indicator;
        /// <summary>
        /// Disclosure 2 26-50% [RESPA.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure 2 26-50%", OptionsJson = "{\"true\":\"26 to 50%\"}")]
        public bool? TwentySixTo50Indicator { get => _twentySixTo50Indicator; set => SetField(ref _twentySixTo50Indicator, value); }
        private DirtyValue<StringEnumValue<WeAreAbleType>> _weAreAbleType;
        /// <summary>
        /// Disclosure 1A Will/Will Not/Haven't Decided [RESPA.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure 1A Will/Will Not/Haven't Decided")]
        public StringEnumValue<WeAreAbleType> WeAreAbleType { get => _weAreAbleType; set => SetField(ref _weAreAbleType, value); }
        private DirtyValue<bool?> _weDoNotSellMortgageLoansIndicator;
        /// <summary>
        /// Disclosure We Do Not Intend to Sell The Servicing of The Loan [RESPA.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure We Do Not Intend to Sell The Servicing of The Loan", OptionsJson = "{\"true\":\"We do not sell mortgage loans\"}")]
        public bool? WeDoNotSellMortgageLoansIndicator { get => _weDoNotSellMortgageLoansIndicator; set => SetField(ref _weDoNotSellMortgageLoansIndicator, value); }
        private DirtyValue<bool?> _weDoNotServiceMortgageLoansIndicator;
        /// <summary>
        /// Disclosure 1B We Do Not Service [RESPA.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure 1B We Do Not Service", OptionsJson = "{\"true\":\"We do not service mortgage loans\"}")]
        public bool? WeDoNotServiceMortgageLoansIndicator { get => _weDoNotServiceMortgageLoansIndicator; set => SetField(ref _weDoNotServiceMortgageLoansIndicator, value); }
        private DirtyValue<bool?> _weHaveNotServicedMortgLoansIn3YrsIndicator;
        /// <summary>
        /// Disclosure 1B And We Have Not Serviced [RESPA.X7]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure 1B And We Have Not Serviced", OptionsJson = "{\"true\":\"and we have not serviced mortgage loans in 3 yrs\"}")]
        public bool? WeHaveNotServicedMortgLoansIn3YrsIndicator { get => _weHaveNotServicedMortgLoansIn3YrsIndicator; set => SetField(ref _weHaveNotServicedMortgLoansIn3YrsIndicator, value); }
        private DirtyValue<bool?> _weHavePreviouslyAssignedIndicator;
        /// <summary>
        /// Disclosure 3A We Have Previously [RESPA.X20]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure 3A We Have Previously", OptionsJson = "{\"true\":\"We have previously assigned, sold, or transferred the servicing\"}")]
        public bool? WeHavePreviouslyAssignedIndicator { get => _weHavePreviouslyAssignedIndicator; set => SetField(ref _weHavePreviouslyAssignedIndicator, value); }
        private DirtyValue<bool?> _weMayAssignIndicator;
        /// <summary>
        /// Disclosure 1A We May Assign [RESPA.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure 1A We May Assign", OptionsJson = "{\"true\":\"We May assign, sell or transfer the servicing while loan is outstanding\"}")]
        public bool? WeMayAssignIndicator { get => _weMayAssignIndicator; set => SetField(ref _weMayAssignIndicator, value); }
        private DirtyValue<bool?> _zeroTo25Indicator;
        /// <summary>
        /// Disclosure 2 0-25% [RESPA.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure 2 0-25%", OptionsJson = "{\"true\":\"0 to 25%\"}")]
        public bool? ZeroTo25Indicator { get => _zeroTo25Indicator; set => SetField(ref _zeroTo25Indicator, value); }
    }
}