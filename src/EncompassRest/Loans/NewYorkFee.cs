using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// NewYorkFee
    /// </summary>
    public sealed partial class NewYorkFee : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        /// <summary>
        /// NY Fees Company Address [NYFEESNN02]
        /// </summary>
        [LoanFieldProperty(Description = "NY Fees Company Address")]
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<decimal?> _amount;
        /// <summary>
        /// NY Fees Amount [NYFEESNN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "NY Fees Amount")]
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<string> _city;
        /// <summary>
        /// NY Fees Company City [NYFEESNN03]
        /// </summary>
        [LoanFieldProperty(Description = "NY Fees Company City")]
        public string City { get => _city; set => _city = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// NY Fees Comments [NYFEESNN06]
        /// </summary>
        [LoanFieldProperty(Description = "NY Fees Comments")]
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _date;
        /// <summary>
        /// NY Fees Date [NYFEESNN07]
        /// </summary>
        [LoanFieldProperty(Description = "NY Fees Date")]
        public DateTime? Date { get => _date; set => _date = value; }
        private DirtyValue<string> _feeType;
        /// <summary>
        /// NY Fees Descr [NYFEESNN09]
        /// </summary>
        [LoanFieldProperty(Description = "NY Fees Descr")]
        public string FeeType { get => _feeType; set => _feeType = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// NewYorkFee Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _name;
        /// <summary>
        /// NY Fees Company Name [NYFEESNN01]
        /// </summary>
        [LoanFieldProperty(Description = "NY Fees Company Name")]
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<int?> _newYorkFeeIndex;
        /// <summary>
        /// NewYorkFee NewYorkFeeIndex
        /// </summary>
        public int? NewYorkFeeIndex { get => _newYorkFeeIndex; set => _newYorkFeeIndex = value; }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// NY Fees Company Zip [NYFEESNN05]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "NY Fees Company Zip")]
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<StringEnumValue<State>> _state;
        /// <summary>
        /// NY Fees Company State [NYFEESNN04]
        /// </summary>
        [LoanFieldProperty(Description = "NY Fees Company State")]
        public StringEnumValue<State> State { get => _state; set => _state = value; }
        internal override bool DirtyInternal
        {
            get => _address.Dirty
                || _amount.Dirty
                || _city.Dirty
                || _comments.Dirty
                || _date.Dirty
                || _feeType.Dirty
                || _id.Dirty
                || _name.Dirty
                || _newYorkFeeIndex.Dirty
                || _postalCode.Dirty
                || _state.Dirty;
            set
            {
                _address.Dirty = value;
                _amount.Dirty = value;
                _city.Dirty = value;
                _comments.Dirty = value;
                _date.Dirty = value;
                _feeType.Dirty = value;
                _id.Dirty = value;
                _name.Dirty = value;
                _newYorkFeeIndex.Dirty = value;
                _postalCode.Dirty = value;
                _state.Dirty = value;
            }
        }
    }
}