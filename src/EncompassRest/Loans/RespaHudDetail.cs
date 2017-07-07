using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class RespaHudDetail : IClean
    {
        private Value<string> _creditDebt;
        public string CreditDebt { get { return _creditDebt; } set { _creditDebt = value; } }
        private Value<string> _fWBC;
        public string FWBC { get { return _fWBC; } set { _fWBC = value; } }
        private Value<DateTime?> _hUD1LineItemFromDate;
        public DateTime? HUD1LineItemFromDate { get { return _hUD1LineItemFromDate; } set { _hUD1LineItemFromDate = value; } }
        private Value<DateTime?> _hUD1LineItemToDate;
        public DateTime? HUD1LineItemToDate { get { return _hUD1LineItemToDate; } set { _hUD1LineItemToDate = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _lineItemAmount;
        public decimal? LineItemAmount { get { return _lineItemAmount; } set { _lineItemAmount = value; } }
        private Value<string> _lineItemDescription;
        public string LineItemDescription { get { return _lineItemDescription; } set { _lineItemDescription = value; } }
        private Value<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        private Value<decimal?> _realValue;
        public decimal? RealValue { get { return _realValue; } set { _realValue = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _creditDebt.Clean
                    && _fWBC.Clean
                    && _hUD1LineItemFromDate.Clean
                    && _hUD1LineItemToDate.Clean
                    && _id.Clean
                    && _lineItemAmount.Clean
                    && _lineItemDescription.Clean
                    && _lineNumber.Clean
                    && _realValue.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var creditDebt = _creditDebt; creditDebt.Clean = value; _creditDebt = creditDebt;
                var fWBC = _fWBC; fWBC.Clean = value; _fWBC = fWBC;
                var hUD1LineItemFromDate = _hUD1LineItemFromDate; hUD1LineItemFromDate.Clean = value; _hUD1LineItemFromDate = hUD1LineItemFromDate;
                var hUD1LineItemToDate = _hUD1LineItemToDate; hUD1LineItemToDate.Clean = value; _hUD1LineItemToDate = hUD1LineItemToDate;
                var id = _id; id.Clean = value; _id = id;
                var lineItemAmount = _lineItemAmount; lineItemAmount.Clean = value; _lineItemAmount = lineItemAmount;
                var lineItemDescription = _lineItemDescription; lineItemDescription.Clean = value; _lineItemDescription = lineItemDescription;
                var lineNumber = _lineNumber; lineNumber.Clean = value; _lineNumber = lineNumber;
                var realValue = _realValue; realValue.Clean = value; _realValue = realValue;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public RespaHudDetail()
        {
            Clean = true;
        }
    }
}