using Newtonsoft.Json;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// PrintRights
    /// </summary>
    public sealed class PrintRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _customFormsTab;
        private DirtyValue<bool?>? _preview;
        private DirtyValue<bool?>? _printButton;
        private DirtyValue<bool?>? _printToFile;
        private DirtyValue<bool?>? _standardFormsTab;

        /// <summary>
        /// PrintRights CustomFormsTab
        /// </summary>
        [JsonProperty("customFormsTab*")]
        public bool? CustomFormsTab { get => _customFormsTab; set => SetField(ref _customFormsTab, value); }

        /// <summary>
        /// PrintRights Preview
        /// </summary>
        public bool? Preview { get => _preview; set => SetField(ref _preview, value); }

        /// <summary>
        /// PrintRights PrintButton
        /// </summary>
        public bool? PrintButton { get => _printButton; set => SetField(ref _printButton, value); }

        /// <summary>
        /// PrintRights PrintToFile
        /// </summary>
        public bool? PrintToFile { get => _printToFile; set => SetField(ref _printToFile, value); }

        /// <summary>
        /// PrintRights StandardFormsTab
        /// </summary>
        [JsonProperty("standardFormsTab*")]
        public bool? StandardFormsTab { get => _standardFormsTab; set => SetField(ref _standardFormsTab, value); }
    }
}