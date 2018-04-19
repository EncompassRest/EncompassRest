using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DownPayment
    /// </summary>
    public sealed partial class DownPayment : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amount;
        /// <summary>
        /// Trans Details Down Pymt Amt [1335]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Down Pymt Amt")]
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<StringEnumValue<DownPaymentType>> _downPaymentType;
        /// <summary>
        /// Borr Funds to Close - Down Pymt Source [34]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Funds to Close - Down Pymt Source")]
        public StringEnumValue<DownPaymentType> DownPaymentType { get => _downPaymentType; set => _downPaymentType = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// DownPayment Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _sourceDescription;
        /// <summary>
        /// Borr Funds to Close - Down Pymt Source Descr [191]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Funds to Close - Down Pymt Source Descr")]
        public string SourceDescription { get => _sourceDescription; set => _sourceDescription = value; }
        internal override bool DirtyInternal
        {
            get => _amount.Dirty
                || _downPaymentType.Dirty
                || _id.Dirty
                || _sourceDescription.Dirty;
            set
            {
                _amount.Dirty = value;
                _downPaymentType.Dirty = value;
                _id.Dirty = value;
                _sourceDescription.Dirty = value;
            }
        }
    }
}