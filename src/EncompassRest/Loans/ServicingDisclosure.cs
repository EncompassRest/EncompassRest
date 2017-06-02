using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ServicingDisclosure : IClean
    {
        private Value<decimal?> _disclosurePercent1;
        public decimal? DisclosurePercent1 { get { return _disclosurePercent1; } set { _disclosurePercent1 = value; } }
        private Value<decimal?> _disclosurePercent2;
        public decimal? DisclosurePercent2 { get { return _disclosurePercent2; } set { _disclosurePercent2 = value; } }
        private Value<decimal?> _disclosurePercent3;
        public decimal? DisclosurePercent3 { get { return _disclosurePercent3; } set { _disclosurePercent3 = value; } }
        private Value<string> _disclosureYear1;
        public string DisclosureYear1 { get { return _disclosureYear1; } set { _disclosureYear1 = value; } }
        private Value<string> _disclosureYear2;
        public string DisclosureYear2 { get { return _disclosureYear2; } set { _disclosureYear2 = value; } }
        private Value<string> _disclosureYear3;
        public string DisclosureYear3 { get { return _disclosureYear3; } set { _disclosureYear3 = value; } }
        private Value<bool?> _fiftyOneTo75Indicator;
        public bool? FiftyOneTo75Indicator { get { return _fiftyOneTo75Indicator; } set { _fiftyOneTo75Indicator = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _seventySixTo100Indicator;
        public bool? SeventySixTo100Indicator { get { return _seventySixTo100Indicator; } set { _seventySixTo100Indicator = value; } }
        private Value<string> _thisEstimateType;
        public string ThisEstimateType { get { return _thisEstimateType; } set { _thisEstimateType = value; } }
        private Value<string> _thisInformationType;
        public string ThisInformationType { get { return _thisInformationType; } set { _thisInformationType = value; } }
        private Value<bool?> _thisIsOurRecordOfTransferingIndicator;
        public bool? ThisIsOurRecordOfTransferingIndicator { get { return _thisIsOurRecordOfTransferingIndicator; } set { _thisIsOurRecordOfTransferingIndicator = value; } }
        private Value<bool?> _twentySixTo50Indicator;
        public bool? TwentySixTo50Indicator { get { return _twentySixTo50Indicator; } set { _twentySixTo50Indicator = value; } }
        private Value<string> _weAreAbleType;
        public string WeAreAbleType { get { return _weAreAbleType; } set { _weAreAbleType = value; } }
        private Value<bool?> _weDoNotSellMortgageLoansIndicator;
        public bool? WeDoNotSellMortgageLoansIndicator { get { return _weDoNotSellMortgageLoansIndicator; } set { _weDoNotSellMortgageLoansIndicator = value; } }
        private Value<bool?> _weDoNotServiceMortgageLoansIndicator;
        public bool? WeDoNotServiceMortgageLoansIndicator { get { return _weDoNotServiceMortgageLoansIndicator; } set { _weDoNotServiceMortgageLoansIndicator = value; } }
        private Value<bool?> _weHaveNotServicedMortgLoansIn3YrsIndicator;
        public bool? WeHaveNotServicedMortgLoansIn3YrsIndicator { get { return _weHaveNotServicedMortgLoansIn3YrsIndicator; } set { _weHaveNotServicedMortgLoansIn3YrsIndicator = value; } }
        private Value<bool?> _weHavePreviouslyAssignedIndicator;
        public bool? WeHavePreviouslyAssignedIndicator { get { return _weHavePreviouslyAssignedIndicator; } set { _weHavePreviouslyAssignedIndicator = value; } }
        private Value<bool?> _weMayAssignIndicator;
        public bool? WeMayAssignIndicator { get { return _weMayAssignIndicator; } set { _weMayAssignIndicator = value; } }
        private Value<bool?> _zeroTo25Indicator;
        public bool? ZeroTo25Indicator { get { return _zeroTo25Indicator; } set { _zeroTo25Indicator = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _disclosurePercent1.Clean
                    && _disclosurePercent2.Clean
                    && _disclosurePercent3.Clean
                    && _disclosureYear1.Clean
                    && _disclosureYear2.Clean
                    && _disclosureYear3.Clean
                    && _fiftyOneTo75Indicator.Clean
                    && _id.Clean
                    && _seventySixTo100Indicator.Clean
                    && _thisEstimateType.Clean
                    && _thisInformationType.Clean
                    && _thisIsOurRecordOfTransferingIndicator.Clean
                    && _twentySixTo50Indicator.Clean
                    && _weAreAbleType.Clean
                    && _weDoNotSellMortgageLoansIndicator.Clean
                    && _weDoNotServiceMortgageLoansIndicator.Clean
                    && _weHaveNotServicedMortgLoansIn3YrsIndicator.Clean
                    && _weHavePreviouslyAssignedIndicator.Clean
                    && _weMayAssignIndicator.Clean
                    && _zeroTo25Indicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _disclosurePercent1; v0.Clean = value; _disclosurePercent1 = v0;
                var v1 = _disclosurePercent2; v1.Clean = value; _disclosurePercent2 = v1;
                var v2 = _disclosurePercent3; v2.Clean = value; _disclosurePercent3 = v2;
                var v3 = _disclosureYear1; v3.Clean = value; _disclosureYear1 = v3;
                var v4 = _disclosureYear2; v4.Clean = value; _disclosureYear2 = v4;
                var v5 = _disclosureYear3; v5.Clean = value; _disclosureYear3 = v5;
                var v6 = _fiftyOneTo75Indicator; v6.Clean = value; _fiftyOneTo75Indicator = v6;
                var v7 = _id; v7.Clean = value; _id = v7;
                var v8 = _seventySixTo100Indicator; v8.Clean = value; _seventySixTo100Indicator = v8;
                var v9 = _thisEstimateType; v9.Clean = value; _thisEstimateType = v9;
                var v10 = _thisInformationType; v10.Clean = value; _thisInformationType = v10;
                var v11 = _thisIsOurRecordOfTransferingIndicator; v11.Clean = value; _thisIsOurRecordOfTransferingIndicator = v11;
                var v12 = _twentySixTo50Indicator; v12.Clean = value; _twentySixTo50Indicator = v12;
                var v13 = _weAreAbleType; v13.Clean = value; _weAreAbleType = v13;
                var v14 = _weDoNotSellMortgageLoansIndicator; v14.Clean = value; _weDoNotSellMortgageLoansIndicator = v14;
                var v15 = _weDoNotServiceMortgageLoansIndicator; v15.Clean = value; _weDoNotServiceMortgageLoansIndicator = v15;
                var v16 = _weHaveNotServicedMortgLoansIn3YrsIndicator; v16.Clean = value; _weHaveNotServicedMortgLoansIn3YrsIndicator = v16;
                var v17 = _weHavePreviouslyAssignedIndicator; v17.Clean = value; _weHavePreviouslyAssignedIndicator = v17;
                var v18 = _weMayAssignIndicator; v18.Clean = value; _weMayAssignIndicator = v18;
                var v19 = _zeroTo25Indicator; v19.Clean = value; _zeroTo25Indicator = v19;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ServicingDisclosure()
        {
            Clean = true;
        }
    }
}