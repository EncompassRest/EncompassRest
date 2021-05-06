namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// GSEServicesRights
    /// </summary>
    public sealed class GSEServicesRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _exportFannieMaeformattedfile;
        private DirtyValue<bool?>? _exportIlad;
        private DirtyValue<bool?>? _exportPDDtoGinnieMae;
        private DirtyValue<bool?>? _exportUCDfile;
        private DirtyValue<bool?>? _exportUladForDu;
        private DirtyValue<bool?>? _exportULDDtoFannieMae;
        private DirtyValue<bool?>? _exportULDDtoFreddieMac;

        /// <summary>
        /// GSEServicesRights ExportFannieMaeformattedfile
        /// </summary>
        public bool? ExportFannieMaeformattedfile { get => _exportFannieMaeformattedfile; set => SetField(ref _exportFannieMaeformattedfile, value); }

        /// <summary>
        /// GSEServicesRights ExportIlad
        /// </summary>
        public bool? ExportIlad { get => _exportIlad; set => SetField(ref _exportIlad, value); }

        /// <summary>
        /// GSEServicesRights ExportPDDtoGinnieMae
        /// </summary>
        public bool? ExportPDDtoGinnieMae { get => _exportPDDtoGinnieMae; set => SetField(ref _exportPDDtoGinnieMae, value); }

        /// <summary>
        /// GSEServicesRights ExportUCDfile
        /// </summary>
        public bool? ExportUCDfile { get => _exportUCDfile; set => SetField(ref _exportUCDfile, value); }

        /// <summary>
        /// GSEServicesRights ExportUladForDu
        /// </summary>
        public bool? ExportUladForDu { get => _exportUladForDu; set => SetField(ref _exportUladForDu, value); }

        /// <summary>
        /// GSEServicesRights ExportULDDtoFannieMae
        /// </summary>
        public bool? ExportULDDtoFannieMae { get => _exportULDDtoFannieMae; set => SetField(ref _exportULDDtoFannieMae, value); }

        /// <summary>
        /// GSEServicesRights ExportULDDtoFreddieMac
        /// </summary>
        public bool? ExportULDDtoFreddieMac { get => _exportULDDtoFreddieMac; set => SetField(ref _exportULDDtoFreddieMac, value); }
    }
}