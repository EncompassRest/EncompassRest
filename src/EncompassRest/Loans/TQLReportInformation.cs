using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class TQLReportInformation : IDirty
    {
        private DirtyValue<string> _altId;
        public string AltId { get { return _altId; } set { _altId = value; } }
        private DirtyValue<string> _borrowerID1;
        public string BorrowerID1 { get { return _borrowerID1; } set { _borrowerID1 = value; } }
        private DirtyValue<string> _borrowerID2;
        public string BorrowerID2 { get { return _borrowerID2; } set { _borrowerID2 = value; } }
        private DirtyValue<string> _borrowerID3;
        public string BorrowerID3 { get { return _borrowerID3; } set { _borrowerID3 = value; } }
        private DirtyValue<string> _borrowerID4;
        public string BorrowerID4 { get { return _borrowerID4; } set { _borrowerID4 = value; } }
        private DirtyValue<DateTime?> _completedDate;
        public DateTime? CompletedDate { get { return _completedDate; } set { _completedDate = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _investor;
        public string Investor { get { return _investor; } set { _investor = value; } }
        private DirtyValue<DateTime?> _orderDate;
        public DateTime? OrderDate { get { return _orderDate; } set { _orderDate = value; } }
        private DirtyValue<string> _orderNumber;
        public string OrderNumber { get { return _orderNumber; } set { _orderNumber = value; } }
        private DirtyValue<string> _orderStatus;
        public string OrderStatus { get { return _orderStatus; } set { _orderStatus = value; } }
        private DirtyValue<decimal?> _percentVariance1;
        public decimal? PercentVariance1 { get { return _percentVariance1; } set { _percentVariance1 = value; } }
        private DirtyValue<decimal?> _percentVariance2;
        public decimal? PercentVariance2 { get { return _percentVariance2; } set { _percentVariance2 = value; } }
        private DirtyValue<decimal?> _percentVariance3;
        public decimal? PercentVariance3 { get { return _percentVariance3; } set { _percentVariance3 = value; } }
        private DirtyValue<decimal?> _percentVariance4;
        public decimal? PercentVariance4 { get { return _percentVariance4; } set { _percentVariance4 = value; } }
        private DirtyValue<string> _productsOrdered;
        public string ProductsOrdered { get { return _productsOrdered; } set { _productsOrdered = value; } }
        private DirtyValue<string> _reportYear1;
        public string ReportYear1 { get { return _reportYear1; } set { _reportYear1 = value; } }
        private DirtyValue<string> _reportYear2;
        public string ReportYear2 { get { return _reportYear2; } set { _reportYear2 = value; } }
        private DirtyValue<string> _reportYear3;
        public string ReportYear3 { get { return _reportYear3; } set { _reportYear3 = value; } }
        private DirtyValue<string> _reportYear4;
        public string ReportYear4 { get { return _reportYear4; } set { _reportYear4 = value; } }
        private DirtyValue<decimal?> _totalIncome1;
        public decimal? TotalIncome1 { get { return _totalIncome1; } set { _totalIncome1 = value; } }
        private DirtyValue<decimal?> _totalIncome2;
        public decimal? TotalIncome2 { get { return _totalIncome2; } set { _totalIncome2 = value; } }
        private DirtyValue<decimal?> _totalIncome3;
        public decimal? TotalIncome3 { get { return _totalIncome3; } set { _totalIncome3 = value; } }
        private DirtyValue<decimal?> _totalIncome4;
        public decimal? TotalIncome4 { get { return _totalIncome4; } set { _totalIncome4 = value; } }
        private DirtyValue<string> _transcriptType;
        public string TranscriptType { get { return _transcriptType; } set { _transcriptType = value; } }
        private DirtyValue<string> _userID;
        public string UserID { get { return _userID; } set { _userID = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _altId.Dirty
                    || _borrowerID1.Dirty
                    || _borrowerID2.Dirty
                    || _borrowerID3.Dirty
                    || _borrowerID4.Dirty
                    || _completedDate.Dirty
                    || _id.Dirty
                    || _investor.Dirty
                    || _orderDate.Dirty
                    || _orderNumber.Dirty
                    || _orderStatus.Dirty
                    || _percentVariance1.Dirty
                    || _percentVariance2.Dirty
                    || _percentVariance3.Dirty
                    || _percentVariance4.Dirty
                    || _productsOrdered.Dirty
                    || _reportYear1.Dirty
                    || _reportYear2.Dirty
                    || _reportYear3.Dirty
                    || _reportYear4.Dirty
                    || _totalIncome1.Dirty
                    || _totalIncome2.Dirty
                    || _totalIncome3.Dirty
                    || _totalIncome4.Dirty
                    || _transcriptType.Dirty
                    || _userID.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _altId.Dirty = value;
                _borrowerID1.Dirty = value;
                _borrowerID2.Dirty = value;
                _borrowerID3.Dirty = value;
                _borrowerID4.Dirty = value;
                _completedDate.Dirty = value;
                _id.Dirty = value;
                _investor.Dirty = value;
                _orderDate.Dirty = value;
                _orderNumber.Dirty = value;
                _orderStatus.Dirty = value;
                _percentVariance1.Dirty = value;
                _percentVariance2.Dirty = value;
                _percentVariance3.Dirty = value;
                _percentVariance4.Dirty = value;
                _productsOrdered.Dirty = value;
                _reportYear1.Dirty = value;
                _reportYear2.Dirty = value;
                _reportYear3.Dirty = value;
                _reportYear4.Dirty = value;
                _totalIncome1.Dirty = value;
                _totalIncome2.Dirty = value;
                _totalIncome3.Dirty = value;
                _totalIncome4.Dirty = value;
                _transcriptType.Dirty = value;
                _userID.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}