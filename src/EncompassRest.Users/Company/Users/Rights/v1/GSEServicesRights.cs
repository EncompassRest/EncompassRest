namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// GSEServicesRights
    /// </summary>
    public sealed class GSEServicesRights : ParentAccessRights
    {
        /// <summary>
        /// GSEServicesRights ExportFannieMaeformattedfile
        /// </summary>
        public bool? ExportFannieMaeformattedfile { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// GSEServicesRights ExportIlad
        /// </summary>
        public bool? ExportIlad { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// GSEServicesRights ExportPDDtoGinnieMae
        /// </summary>
        public bool? ExportPDDtoGinnieMae { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// GSEServicesRights ExportUCDfile
        /// </summary>
        public bool? ExportUCDfile { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// GSEServicesRights ExportUladForDu
        /// </summary>
        public bool? ExportUladForDu { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// GSEServicesRights ExportULDDtoFannieMae
        /// </summary>
        public bool? ExportULDDtoFannieMae { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// GSEServicesRights ExportULDDtoFreddieMac
        /// </summary>
        public bool? ExportULDDtoFreddieMac { get => GetValue<bool?>(); set => SetValue(value); }
    }
}