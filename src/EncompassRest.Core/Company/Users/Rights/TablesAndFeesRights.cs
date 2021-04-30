namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// TablesAndFeesRights
    /// </summary>
    public sealed class TablesAndFeesRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _cityTax;
        private DirtyValue<bool?>? _escrow;
        private DirtyValue<bool?>? _fHACountyLimits;
        private DirtyValue<bool?>? _hELOCTable;
        private DirtyValue<bool?>? _itemizationFeeManagement;
        private DirtyValue<bool?>? _lOCompensation;
        private DirtyValue<bool?>? _mITables;
        private DirtyValue<bool?>? _specialFeatureCodes;
        private DirtyValue<bool?>? _stateTax;
        private DirtyValue<bool?>? _temporaryBuydown;
        private DirtyValue<bool?>? _title;
        private DirtyValue<bool?>? _userDefinedFee;

        /// <summary>
        /// TablesAndFeesRights CityTax
        /// </summary>
        public bool? CityTax { get => _cityTax; set => SetField(ref _cityTax, value); }

        /// <summary>
        /// TablesAndFeesRights Escrow
        /// </summary>
        public bool? Escrow { get => _escrow; set => SetField(ref _escrow, value); }

        /// <summary>
        /// TablesAndFeesRights FHACountyLimits
        /// </summary>
        public bool? FHACountyLimits { get => _fHACountyLimits; set => SetField(ref _fHACountyLimits, value); }

        /// <summary>
        /// TablesAndFeesRights HELOCTable
        /// </summary>
        public bool? HELOCTable { get => _hELOCTable; set => SetField(ref _hELOCTable, value); }

        /// <summary>
        /// TablesAndFeesRights ItemizationFeeManagement
        /// </summary>
        public bool? ItemizationFeeManagement { get => _itemizationFeeManagement; set => SetField(ref _itemizationFeeManagement, value); }

        /// <summary>
        /// TablesAndFeesRights LOCompensation
        /// </summary>
        public bool? LOCompensation { get => _lOCompensation; set => SetField(ref _lOCompensation, value); }

        /// <summary>
        /// TablesAndFeesRights MITables
        /// </summary>
        public bool? MITables { get => _mITables; set => SetField(ref _mITables, value); }

        /// <summary>
        /// TablesAndFeesRights SpecialFeatureCodes
        /// </summary>
        public bool? SpecialFeatureCodes { get => _specialFeatureCodes; set => SetField(ref _specialFeatureCodes, value); }

        /// <summary>
        /// TablesAndFeesRights StateTax
        /// </summary>
        public bool? StateTax { get => _stateTax; set => SetField(ref _stateTax, value); }

        /// <summary>
        /// TablesAndFeesRights TemporaryBuydown
        /// </summary>
        public bool? TemporaryBuydown { get => _temporaryBuydown; set => SetField(ref _temporaryBuydown, value); }

        /// <summary>
        /// TablesAndFeesRights Title
        /// </summary>
        public bool? Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// TablesAndFeesRights UserDefinedFee
        /// </summary>
        public bool? UserDefinedFee { get => _userDefinedFee; set => SetField(ref _userDefinedFee, value); }
    }
}