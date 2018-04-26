using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Hud1EsDate
    /// </summary>
    public sealed partial class Hud1EsDate : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _aggrMthDisb;
        /// <summary>
        /// Escrow Aggr Mthd Disb [HUDNN10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Aggr Mthd Disb")]
        public decimal? AggrMthDisb { get => _aggrMthDisb; set => _aggrMthDisb = value; }
        private DirtyValue<decimal?> _annualFee;
        /// <summary>
        /// Escrow Annual Fee [HUDNN60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Annual Fee")]
        public decimal? AnnualFee { get => _annualFee; set => _annualFee = value; }
        private DirtyValue<decimal?> _balance;
        /// <summary>
        /// Escrow Date Balance [HUDNN11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Date Balance")]
        public decimal? Balance { get => _balance; set => _balance = value; }
        private DirtyValue<string> _date;
        /// <summary>
        /// Escrow Payment Date [HUDNN01]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Payment Date")]
        public string Date { get => _date; set => _date = value; }
        private DirtyValue<decimal?> _floodInsDisb;
        /// <summary>
        /// Escrow Flood Ins Disb [HUDNN05]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Flood Ins Disb")]
        public decimal? FloodInsDisb { get => _floodInsDisb; set => _floodInsDisb = value; }
        private DirtyValue<decimal?> _hazInsDisb;
        /// <summary>
        /// Escrow Haz Ins Disb [HUDNN03]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Haz Ins Disb")]
        public decimal? HazInsDisb { get => _hazInsDisb; set => _hazInsDisb = value; }
        private DirtyValue<int?> _hud1EsDateIndex;
        /// <summary>
        /// Hud1EsDate Hud1EsDateIndex
        /// </summary>
        public int? Hud1EsDateIndex { get => _hud1EsDateIndex; set => _hud1EsDateIndex = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Hud1EsDate Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _mtgInsDisb;
        /// <summary>
        /// Escrow Mtg Ins Disb [HUDNN04]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Mtg Ins Disb")]
        public decimal? MtgInsDisb { get => _mtgInsDisb; set => _mtgInsDisb = value; }
        private DirtyValue<decimal?> _schoolTaxes;
        /// <summary>
        /// Escrow City Taxes [HUDNN06]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow City Taxes")]
        public decimal? SchoolTaxes { get => _schoolTaxes; set => _schoolTaxes = value; }
        private DirtyValue<decimal?> _taxDisb;
        /// <summary>
        /// Escrow Tax Disb [HUDNN02]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow Tax Disb")]
        public decimal? TaxDisb { get => _taxDisb; set => _taxDisb = value; }
        private DirtyValue<decimal?> _userDefined1;
        /// <summary>
        /// Escrow User Defined 1 [HUDNN07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow User Defined 1")]
        public decimal? UserDefined1 { get => _userDefined1; set => _userDefined1 = value; }
        private DirtyValue<decimal?> _userDefined2;
        /// <summary>
        /// Escrow User Defined 2 [HUDNN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow User Defined 2")]
        public decimal? UserDefined2 { get => _userDefined2; set => _userDefined2 = value; }
        private DirtyValue<decimal?> _userDefined3;
        /// <summary>
        /// Escrow User Defined 3 [HUDNN09]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Escrow User Defined 3")]
        public decimal? UserDefined3 { get => _userDefined3; set => _userDefined3 = value; }
        internal override bool DirtyInternal
        {
            get => _aggrMthDisb.Dirty
                || _annualFee.Dirty
                || _balance.Dirty
                || _date.Dirty
                || _floodInsDisb.Dirty
                || _hazInsDisb.Dirty
                || _hud1EsDateIndex.Dirty
                || _id.Dirty
                || _mtgInsDisb.Dirty
                || _schoolTaxes.Dirty
                || _taxDisb.Dirty
                || _userDefined1.Dirty
                || _userDefined2.Dirty
                || _userDefined3.Dirty;
            set
            {
                _aggrMthDisb.Dirty = value;
                _annualFee.Dirty = value;
                _balance.Dirty = value;
                _date.Dirty = value;
                _floodInsDisb.Dirty = value;
                _hazInsDisb.Dirty = value;
                _hud1EsDateIndex.Dirty = value;
                _id.Dirty = value;
                _mtgInsDisb.Dirty = value;
                _schoolTaxes.Dirty = value;
                _taxDisb.Dirty = value;
                _userDefined1.Dirty = value;
                _userDefined2.Dirty = value;
                _userDefined3.Dirty = value;
            }
        }
    }
}