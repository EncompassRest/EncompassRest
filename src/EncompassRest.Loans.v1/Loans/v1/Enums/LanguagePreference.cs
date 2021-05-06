using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// LanguagePreference
    /// </summary>
    public enum LanguagePreference
    {
        /// <summary>
        /// English Indicator
        /// </summary>
        [Description("English Indicator")]
        EnglishIndicator = 0,
        /// <summary>
        /// Chinese Indicator
        /// </summary>
        [Description("Chinese Indicator")]
        ChineseIndicator = 1,
        /// <summary>
        /// Korean Indicator
        /// </summary>
        [Description("Korean Indicator")]
        KoreanIndicator = 2,
        /// <summary>
        /// Spanish Indicator
        /// </summary>
        [Description("Spanish Indicator")]
        SpanishIndicator = 3,
        /// <summary>
        /// Tagalog Indicator
        /// </summary>
        [Description("Tagalog Indicator")]
        TagalogIndicator = 4,
        /// <summary>
        /// Vietnamese Indicator
        /// </summary>
        [Description("Vietnamese Indicator")]
        VietnameseIndicator = 5,
        /// <summary>
        /// Other Indicator
        /// </summary>
        [Description("Other Indicator")]
        OtherIndicator = 6,
        /// <summary>
        /// Language Refusal Indicator
        /// </summary>
        [Description("Language Refusal Indicator")]
        LanguageRefusalIndicator = 7
    }
}