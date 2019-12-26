using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Hud1EsDate
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class Hud1EsDate : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _aggrMthDisb;
        private DirtyValue<decimal?>? _annualFee;
        private DirtyValue<decimal?>? _balance;
        private DirtyValue<string?>? _date;
        private DirtyValue<decimal?>? _floodInsDisb;
        private DirtyValue<decimal?>? _hazInsDisb;
        private DirtyValue<int?>? _hud1EsDateIndex;
        private DirtyValue<string?>? _id;
        private DirtyValue<decimal?>? _mtgInsDisb;
        private DirtyValue<decimal?>? _schoolTaxes;
        private DirtyValue<decimal?>? _taxDisb;
        private DirtyValue<decimal?>? _userDefined1;
        private DirtyValue<decimal?>? _userDefined2;
        private DirtyValue<decimal?>? _userDefined3;

        /// <summary>
        /// Escrow Aggr Mthd Disb [HUDNN10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AggrMthDisb { get => _aggrMthDisb; set => SetField(ref _aggrMthDisb, value); }

        /// <summary>
        /// Escrow Annual Fee [HUDNN60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AnnualFee { get => _annualFee; set => SetField(ref _annualFee, value); }

        /// <summary>
        /// Escrow Date Balance [HUDNN11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Balance { get => _balance; set => SetField(ref _balance, value); }

        /// <summary>
        /// Escrow Payment Date [HUDNN01]
        /// </summary>
        public string? Date { get => _date; set => SetField(ref _date, value); }

        /// <summary>
        /// Escrow Flood Ins Disb [HUDNN05]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FloodInsDisb { get => _floodInsDisb; set => SetField(ref _floodInsDisb, value); }

        /// <summary>
        /// Escrow Haz Ins Disb [HUDNN03]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? HazInsDisb { get => _hazInsDisb; set => SetField(ref _hazInsDisb, value); }

        /// <summary>
        /// Hud1EsDate Hud1EsDateIndex
        /// </summary>
        public int? Hud1EsDateIndex { get => _hud1EsDateIndex; set => SetField(ref _hud1EsDateIndex, value); }

        /// <summary>
        /// Hud1EsDate Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Escrow Mtg Ins Disb [HUDNN04]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MtgInsDisb { get => _mtgInsDisb; set => SetField(ref _mtgInsDisb, value); }

        /// <summary>
        /// Escrow City Taxes [HUDNN06]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? SchoolTaxes { get => _schoolTaxes; set => SetField(ref _schoolTaxes, value); }

        /// <summary>
        /// Escrow Tax Disb [HUDNN02]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TaxDisb { get => _taxDisb; set => SetField(ref _taxDisb, value); }

        /// <summary>
        /// Escrow User Defined 1 [HUDNN07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefined1 { get => _userDefined1; set => SetField(ref _userDefined1, value); }

        /// <summary>
        /// Escrow User Defined 2 [HUDNN08]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefined2 { get => _userDefined2; set => SetField(ref _userDefined2, value); }

        /// <summary>
        /// Escrow User Defined 3 [HUDNN09]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefined3 { get => _userDefined3; set => SetField(ref _userDefined3, value); }
    }
}