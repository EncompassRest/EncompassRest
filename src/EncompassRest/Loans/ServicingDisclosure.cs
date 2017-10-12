using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ServicingDisclosure : IDirty
    {
        private DirtyValue<decimal?> _disclosurePercent1;
        public decimal? DisclosurePercent1 { get { return _disclosurePercent1; } set { _disclosurePercent1 = value; } }
        private DirtyValue<decimal?> _disclosurePercent2;
        public decimal? DisclosurePercent2 { get { return _disclosurePercent2; } set { _disclosurePercent2 = value; } }
        private DirtyValue<decimal?> _disclosurePercent3;
        public decimal? DisclosurePercent3 { get { return _disclosurePercent3; } set { _disclosurePercent3 = value; } }
        private DirtyValue<string> _disclosureYear1;
        public string DisclosureYear1 { get { return _disclosureYear1; } set { _disclosureYear1 = value; } }
        private DirtyValue<string> _disclosureYear2;
        public string DisclosureYear2 { get { return _disclosureYear2; } set { _disclosureYear2 = value; } }
        private DirtyValue<string> _disclosureYear3;
        public string DisclosureYear3 { get { return _disclosureYear3; } set { _disclosureYear3 = value; } }
        private DirtyValue<bool?> _fiftyOneTo75Indicator;
        public bool? FiftyOneTo75Indicator { get { return _fiftyOneTo75Indicator; } set { _fiftyOneTo75Indicator = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _seventySixTo100Indicator;
        public bool? SeventySixTo100Indicator { get { return _seventySixTo100Indicator; } set { _seventySixTo100Indicator = value; } }
        private DirtyValue<string> _thisEstimateType;
        public string ThisEstimateType { get { return _thisEstimateType; } set { _thisEstimateType = value; } }
        private DirtyValue<string> _thisInformationType;
        public string ThisInformationType { get { return _thisInformationType; } set { _thisInformationType = value; } }
        private DirtyValue<bool?> _thisIsOurRecordOfTransferingIndicator;
        public bool? ThisIsOurRecordOfTransferingIndicator { get { return _thisIsOurRecordOfTransferingIndicator; } set { _thisIsOurRecordOfTransferingIndicator = value; } }
        private DirtyValue<bool?> _twentySixTo50Indicator;
        public bool? TwentySixTo50Indicator { get { return _twentySixTo50Indicator; } set { _twentySixTo50Indicator = value; } }
        private DirtyValue<string> _weAreAbleType;
        public string WeAreAbleType { get { return _weAreAbleType; } set { _weAreAbleType = value; } }
        private DirtyValue<bool?> _weDoNotSellMortgageLoansIndicator;
        public bool? WeDoNotSellMortgageLoansIndicator { get { return _weDoNotSellMortgageLoansIndicator; } set { _weDoNotSellMortgageLoansIndicator = value; } }
        private DirtyValue<bool?> _weDoNotServiceMortgageLoansIndicator;
        public bool? WeDoNotServiceMortgageLoansIndicator { get { return _weDoNotServiceMortgageLoansIndicator; } set { _weDoNotServiceMortgageLoansIndicator = value; } }
        private DirtyValue<bool?> _weHaveNotServicedMortgLoansIn3YrsIndicator;
        public bool? WeHaveNotServicedMortgLoansIn3YrsIndicator { get { return _weHaveNotServicedMortgLoansIn3YrsIndicator; } set { _weHaveNotServicedMortgLoansIn3YrsIndicator = value; } }
        private DirtyValue<bool?> _weHavePreviouslyAssignedIndicator;
        public bool? WeHavePreviouslyAssignedIndicator { get { return _weHavePreviouslyAssignedIndicator; } set { _weHavePreviouslyAssignedIndicator = value; } }
        private DirtyValue<bool?> _weMayAssignIndicator;
        public bool? WeMayAssignIndicator { get { return _weMayAssignIndicator; } set { _weMayAssignIndicator = value; } }
        private DirtyValue<bool?> _zeroTo25Indicator;
        public bool? ZeroTo25Indicator { get { return _zeroTo25Indicator; } set { _zeroTo25Indicator = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _disclosurePercent1.Dirty
                    || _disclosurePercent2.Dirty
                    || _disclosurePercent3.Dirty
                    || _disclosureYear1.Dirty
                    || _disclosureYear2.Dirty
                    || _disclosureYear3.Dirty
                    || _fiftyOneTo75Indicator.Dirty
                    || _id.Dirty
                    || _seventySixTo100Indicator.Dirty
                    || _thisEstimateType.Dirty
                    || _thisInformationType.Dirty
                    || _thisIsOurRecordOfTransferingIndicator.Dirty
                    || _twentySixTo50Indicator.Dirty
                    || _weAreAbleType.Dirty
                    || _weDoNotSellMortgageLoansIndicator.Dirty
                    || _weDoNotServiceMortgageLoansIndicator.Dirty
                    || _weHaveNotServicedMortgLoansIn3YrsIndicator.Dirty
                    || _weHavePreviouslyAssignedIndicator.Dirty
                    || _weMayAssignIndicator.Dirty
                    || _zeroTo25Indicator.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _disclosurePercent1.Dirty = value;
                _disclosurePercent2.Dirty = value;
                _disclosurePercent3.Dirty = value;
                _disclosureYear1.Dirty = value;
                _disclosureYear2.Dirty = value;
                _disclosureYear3.Dirty = value;
                _fiftyOneTo75Indicator.Dirty = value;
                _id.Dirty = value;
                _seventySixTo100Indicator.Dirty = value;
                _thisEstimateType.Dirty = value;
                _thisInformationType.Dirty = value;
                _thisIsOurRecordOfTransferingIndicator.Dirty = value;
                _twentySixTo50Indicator.Dirty = value;
                _weAreAbleType.Dirty = value;
                _weDoNotSellMortgageLoansIndicator.Dirty = value;
                _weDoNotServiceMortgageLoansIndicator.Dirty = value;
                _weHaveNotServicedMortgLoansIn3YrsIndicator.Dirty = value;
                _weHavePreviouslyAssignedIndicator.Dirty = value;
                _weMayAssignIndicator.Dirty = value;
                _zeroTo25Indicator.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}