namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TablesAndFeesRights
    /// </summary>
    public sealed class TablesAndFeesRights : ParentAccessRights
    {
        /// <summary>
        /// TablesAndFeesRights CityTax
        /// </summary>
        public bool? CityTax { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TablesAndFeesRights Escrow
        /// </summary>
        public bool? Escrow { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TablesAndFeesRights FHACountyLimits
        /// </summary>
        public bool? FHACountyLimits { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TablesAndFeesRights HELOCTable
        /// </summary>
        public bool? HELOCTable { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TablesAndFeesRights ItemizationFeeManagement
        /// </summary>
        public bool? ItemizationFeeManagement { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TablesAndFeesRights LOCompensation
        /// </summary>
        public bool? LOCompensation { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TablesAndFeesRights MITables
        /// </summary>
        public bool? MITables { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TablesAndFeesRights SpecialFeatureCodes
        /// </summary>
        public bool? SpecialFeatureCodes { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TablesAndFeesRights StateTax
        /// </summary>
        public bool? StateTax { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TablesAndFeesRights TemporaryBuydown
        /// </summary>
        public bool? TemporaryBuydown { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TablesAndFeesRights Title
        /// </summary>
        public bool? Title { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TablesAndFeesRights UserDefinedFee
        /// </summary>
        public bool? UserDefinedFee { get => GetValue<bool?>(); set => SetValue(value); }
    }
}