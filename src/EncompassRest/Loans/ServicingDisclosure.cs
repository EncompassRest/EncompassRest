using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ServicingDisclosure
    {
        public Value<decimal?> DisclosurePercent1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosurePercent1() => !DisclosurePercent1.Clean;
        public Value<decimal?> DisclosurePercent2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosurePercent2() => !DisclosurePercent2.Clean;
        public Value<decimal?> DisclosurePercent3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosurePercent3() => !DisclosurePercent3.Clean;
        public Value<string> DisclosureYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureYear1() => !DisclosureYear1.Clean;
        public Value<string> DisclosureYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureYear2() => !DisclosureYear2.Clean;
        public Value<string> DisclosureYear3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureYear3() => !DisclosureYear3.Clean;
        public Value<bool?> FiftyOneTo75Indicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFiftyOneTo75Indicator() => !FiftyOneTo75Indicator.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> SeventySixTo100Indicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSeventySixTo100Indicator() => !SeventySixTo100Indicator.Clean;
        public Value<string> ThisEstimateType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThisEstimateType() => !ThisEstimateType.Clean;
        public Value<string> ThisInformationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThisInformationType() => !ThisInformationType.Clean;
        public Value<bool?> ThisIsOurRecordOfTransferingIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThisIsOurRecordOfTransferingIndicator() => !ThisIsOurRecordOfTransferingIndicator.Clean;
        public Value<bool?> TwentySixTo50Indicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTwentySixTo50Indicator() => !TwentySixTo50Indicator.Clean;
        public Value<string> WeAreAbleType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWeAreAbleType() => !WeAreAbleType.Clean;
        public Value<bool?> WeDoNotSellMortgageLoansIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWeDoNotSellMortgageLoansIndicator() => !WeDoNotSellMortgageLoansIndicator.Clean;
        public Value<bool?> WeDoNotServiceMortgageLoansIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWeDoNotServiceMortgageLoansIndicator() => !WeDoNotServiceMortgageLoansIndicator.Clean;
        public Value<bool?> WeHaveNotServicedMortgLoansIn3YrsIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWeHaveNotServicedMortgLoansIn3YrsIndicator() => !WeHaveNotServicedMortgLoansIn3YrsIndicator.Clean;
        public Value<bool?> WeHavePreviouslyAssignedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWeHavePreviouslyAssignedIndicator() => !WeHavePreviouslyAssignedIndicator.Clean;
        public Value<bool?> WeMayAssignIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWeMayAssignIndicator() => !WeMayAssignIndicator.Clean;
        public Value<bool?> ZeroTo25Indicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeZeroTo25Indicator() => !ZeroTo25Indicator.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = DisclosurePercent1.Clean
                    && DisclosurePercent2.Clean
                    && DisclosurePercent3.Clean
                    && DisclosureYear1.Clean
                    && DisclosureYear2.Clean
                    && DisclosureYear3.Clean
                    && FiftyOneTo75Indicator.Clean
                    && Id.Clean
                    && SeventySixTo100Indicator.Clean
                    && ThisEstimateType.Clean
                    && ThisInformationType.Clean
                    && ThisIsOurRecordOfTransferingIndicator.Clean
                    && TwentySixTo50Indicator.Clean
                    && WeAreAbleType.Clean
                    && WeDoNotSellMortgageLoansIndicator.Clean
                    && WeDoNotServiceMortgageLoansIndicator.Clean
                    && WeHaveNotServicedMortgLoansIn3YrsIndicator.Clean
                    && WeHavePreviouslyAssignedIndicator.Clean
                    && WeMayAssignIndicator.Clean
                    && ZeroTo25Indicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = DisclosurePercent1; v0.Clean = value; DisclosurePercent1 = v0;
                var v1 = DisclosurePercent2; v1.Clean = value; DisclosurePercent2 = v1;
                var v2 = DisclosurePercent3; v2.Clean = value; DisclosurePercent3 = v2;
                var v3 = DisclosureYear1; v3.Clean = value; DisclosureYear1 = v3;
                var v4 = DisclosureYear2; v4.Clean = value; DisclosureYear2 = v4;
                var v5 = DisclosureYear3; v5.Clean = value; DisclosureYear3 = v5;
                var v6 = FiftyOneTo75Indicator; v6.Clean = value; FiftyOneTo75Indicator = v6;
                var v7 = Id; v7.Clean = value; Id = v7;
                var v8 = SeventySixTo100Indicator; v8.Clean = value; SeventySixTo100Indicator = v8;
                var v9 = ThisEstimateType; v9.Clean = value; ThisEstimateType = v9;
                var v10 = ThisInformationType; v10.Clean = value; ThisInformationType = v10;
                var v11 = ThisIsOurRecordOfTransferingIndicator; v11.Clean = value; ThisIsOurRecordOfTransferingIndicator = v11;
                var v12 = TwentySixTo50Indicator; v12.Clean = value; TwentySixTo50Indicator = v12;
                var v13 = WeAreAbleType; v13.Clean = value; WeAreAbleType = v13;
                var v14 = WeDoNotSellMortgageLoansIndicator; v14.Clean = value; WeDoNotSellMortgageLoansIndicator = v14;
                var v15 = WeDoNotServiceMortgageLoansIndicator; v15.Clean = value; WeDoNotServiceMortgageLoansIndicator = v15;
                var v16 = WeHaveNotServicedMortgLoansIn3YrsIndicator; v16.Clean = value; WeHaveNotServicedMortgLoansIn3YrsIndicator = v16;
                var v17 = WeHavePreviouslyAssignedIndicator; v17.Clean = value; WeHavePreviouslyAssignedIndicator = v17;
                var v18 = WeMayAssignIndicator; v18.Clean = value; WeMayAssignIndicator = v18;
                var v19 = ZeroTo25Indicator; v19.Clean = value; ZeroTo25Indicator = v19;
                _settingClean = 0;
            }
        }
    }
}