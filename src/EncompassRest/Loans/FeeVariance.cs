#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class FeeVariance : ExtensibleObject
    {
        private DirtyValue<decimal?> _cD;
        public decimal? CD { get => _cD; set => _cD = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<int?> _feeVarianceChargeIndex;
        public int? FeeVarianceChargeIndex { get => _feeVarianceChargeIndex; set => _feeVarianceChargeIndex = value; }
        private DirtyValue<string> _feeVarianceFeeType;
        public string FeeVarianceFeeType { get => _feeVarianceFeeType; set => _feeVarianceFeeType = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _initialLE;
        public decimal? InitialLE { get => _initialLE; set => _initialLE = value; }
        private DirtyValue<decimal?> _itemization;
        public decimal? Itemization { get => _itemization; set => _itemization = value; }
        private DirtyValue<decimal?> _lE;
        public decimal? LE { get => _lE; set => _lE = value; }
        private DirtyValue<string> _line;
        public string Line { get => _line; set => _line = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _cD.Dirty
                    || _description.Dirty
                    || _feeVarianceChargeIndex.Dirty
                    || _feeVarianceFeeType.Dirty
                    || _id.Dirty
                    || _initialLE.Dirty
                    || _itemization.Dirty
                    || _lE.Dirty
                    || _line.Dirty;
            }
            set
            {
                _cD.Dirty = value;
                _description.Dirty = value;
                _feeVarianceChargeIndex.Dirty = value;
                _feeVarianceFeeType.Dirty = value;
                _id.Dirty = value;
                _initialLE.Dirty = value;
                _itemization.Dirty = value;
                _lE.Dirty = value;
                _line.Dirty = value;
            }
        }
    }
}