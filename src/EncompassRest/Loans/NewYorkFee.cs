using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// NewYorkFee
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class NewYorkFee : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        /// <summary>
        /// NY Fees Company Address [NYFEESNN02]
        /// </summary>
        [LoanFieldProperty(Description = "NY Fees Company Address")]
        public string Address { get => _address; set => SetField(ref _address, value); }
        private DirtyValue<decimal?> _amount;
        /// <summary>
        /// NY Fees Amount [NYFEESNN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "NY Fees Amount")]
        public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }
        private DirtyValue<string> _city;
        /// <summary>
        /// NY Fees Company City [NYFEESNN03]
        /// </summary>
        [LoanFieldProperty(Description = "NY Fees Company City")]
        public string City { get => _city; set => SetField(ref _city, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// NY Fees Comments [NYFEESNN06]
        /// </summary>
        [LoanFieldProperty(Description = "NY Fees Comments")]
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<DateTime?> _date;
        /// <summary>
        /// NY Fees Date [NYFEESNN07]
        /// </summary>
        [LoanFieldProperty(Description = "NY Fees Date")]
        public DateTime? Date { get => _date; set => SetField(ref _date, value); }
        private DirtyValue<string> _feeType;
        /// <summary>
        /// NY Fees Descr [NYFEESNN09]
        /// </summary>
        [LoanFieldProperty(Description = "NY Fees Descr")]
        public string FeeType { get => _feeType; set => SetField(ref _feeType, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// NewYorkFee Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _name;
        /// <summary>
        /// NY Fees Company Name [NYFEESNN01]
        /// </summary>
        [LoanFieldProperty(Description = "NY Fees Company Name")]
        public string Name { get => _name; set => SetField(ref _name, value); }
        private DirtyValue<int?> _newYorkFeeIndex;
        /// <summary>
        /// NewYorkFee NewYorkFeeIndex
        /// </summary>
        public int? NewYorkFeeIndex { get => _newYorkFeeIndex; set => SetField(ref _newYorkFeeIndex, value); }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// NY Fees Company Zip [NYFEESNN05]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "NY Fees Company Zip")]
        public string PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }
        private DirtyValue<StringEnumValue<State>> _state;
        /// <summary>
        /// NY Fees Company State [NYFEESNN04]
        /// </summary>
        [LoanFieldProperty(Description = "NY Fees Company State")]
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }
    }
}