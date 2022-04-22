using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PrintRights
    /// </summary>
    public sealed class PrintRights : DirtyExtensibleObject
    {
        /// <summary>
        /// PrintRights CustomFormsTab
        /// </summary>
        [JsonProperty("customFormsTab*")]
        public bool? CustomFormsTab { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PrintRights Preview
        /// </summary>
        public bool? Preview { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PrintRights PrintButton
        /// </summary>
        public bool? PrintButton { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PrintRights PrintToFile
        /// </summary>
        public bool? PrintToFile { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// PrintRights StandardFormsTab
        /// </summary>
        [JsonProperty("standardFormsTab*")]
        public bool? StandardFormsTab { get => GetValue<bool?>(); set => SetValue(value); }
    }
}