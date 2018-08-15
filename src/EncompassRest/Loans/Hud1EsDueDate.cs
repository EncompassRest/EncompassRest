using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Hud1EsDueDate
    /// </summary>
    public sealed partial class Hud1EsDueDate : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _annualFee;
        /// <summary>
        /// Escrow Annual Fee Date [HUDNN49]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Annual Fee Date")]
        public DateTime? AnnualFee { get => _annualFee; set => SetField(ref _annualFee, value); }
        private DirtyValue<DateTime?> _floodInsDisb;
        /// <summary>
        /// Escrow Flood Ins Disb Date [HUDNN44]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Flood Ins Disb Date")]
        public DateTime? FloodInsDisb { get => _floodInsDisb; set => SetField(ref _floodInsDisb, value); }
        private DirtyValue<DateTime?> _hazInsDisb;
        /// <summary>
        /// Escrow Haz Ins Disb Date [HUDNN42]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Haz Ins Disb Date")]
        public DateTime? HazInsDisb { get => _hazInsDisb; set => SetField(ref _hazInsDisb, value); }
        private DirtyValue<int?> _hud1EsDueDateIndex;
        /// <summary>
        /// Hud1EsDueDate Hud1EsDueDateIndex
        /// </summary>
        public int? Hud1EsDueDateIndex { get => _hud1EsDueDateIndex; set => SetField(ref _hud1EsDueDateIndex, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Hud1EsDueDate Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<DateTime?> _mtgInsDisb;
        /// <summary>
        /// Escrow Mtg Ins Disb Date [HUDNN43]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Mtg Ins Disb Date")]
        public DateTime? MtgInsDisb { get => _mtgInsDisb; set => SetField(ref _mtgInsDisb, value); }
        private DirtyValue<DateTime?> _schoolTaxes;
        /// <summary>
        /// Escrow City Taxes Date [HUDNN45]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow City Taxes Date")]
        public DateTime? SchoolTaxes { get => _schoolTaxes; set => SetField(ref _schoolTaxes, value); }
        private DirtyValue<DateTime?> _taxDisb;
        /// <summary>
        /// Escrow Tax Disb Date [HUDNN41]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Tax Disb Date")]
        public DateTime? TaxDisb { get => _taxDisb; set => SetField(ref _taxDisb, value); }
        private DirtyValue<DateTime?> _userDefined1;
        /// <summary>
        /// Escrow User Defined 1 Date [HUDNN46]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow User Defined 1 Date")]
        public DateTime? UserDefined1 { get => _userDefined1; set => SetField(ref _userDefined1, value); }
        private DirtyValue<DateTime?> _userDefined2;
        /// <summary>
        /// Escrow User Defined 2 Date [HUDNN47]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow User Defined 2 Date")]
        public DateTime? UserDefined2 { get => _userDefined2; set => SetField(ref _userDefined2, value); }
        private DirtyValue<DateTime?> _userDefined3;
        /// <summary>
        /// Escrow User Defined 3 Date [HUDNN48]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow User Defined 3 Date")]
        public DateTime? UserDefined3 { get => _userDefined3; set => SetField(ref _userDefined3, value); }
    }
}