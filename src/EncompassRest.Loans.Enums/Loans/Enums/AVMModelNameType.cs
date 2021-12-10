using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// AVMModelNameType
    /// </summary>
    public enum AVMModelNameType
    {
        /// <summary>
        /// Automated Property Service
        /// </summary>
        [Description("Automated Property Service")]
        AutomatedPropertyService = 0,
        /// <summary>
        /// Casa
        /// </summary>
        Casa = 1,
        /// <summary>
        /// Fidelity Hansen
        /// </summary>
        [Description("Fidelity Hansen")]
        FidelityHansen = 2,
        /// <summary>
        /// Home Price Analyzer
        /// </summary>
        [Description("Home Price Analyzer")]
        HomePriceAnalyzer = 3,
        /// <summary>
        /// Home Price Index
        /// </summary>
        [Description("Home Price Index")]
        HomePriceIndex = 4,
        /// <summary>
        /// Home Value Explorer
        /// </summary>
        [Description("Home Value Explorer")]
        HomeValueExplorer = 5,
        /// <summary>
        /// Indicator
        /// </summary>
        Indicator = 6,
        /// <summary>
        /// Net Value
        /// </summary>
        [Description("Net Value")]
        NetValue = 7,
        /// <summary>
        /// Other
        /// </summary>
        Other = 8,
        /// <summary>
        /// Pass
        /// </summary>
        Pass = 9,
        /// <summary>
        /// Property Survey Analysis Report
        /// </summary>
        [Description("Property Survey Analysis Report")]
        PropertySurveyAnalysisReport = 10,
        /// <summary>
        /// Value Finder
        /// </summary>
        [Description("Value Finder")]
        ValueFinder = 11,
        /// <summary>
        /// Value Point
        /// </summary>
        [Description("Value Point")]
        ValuePoint = 12,
        /// <summary>
        /// Value Point4
        /// </summary>
        [Description("Value Point4")]
        ValuePoint4 = 13,
        /// <summary>
        /// Value Point Plus
        /// </summary>
        [Description("Value Point Plus")]
        ValuePointPlus = 14,
        /// <summary>
        /// Value Sure
        /// </summary>
        [Description("Value Sure")]
        ValueSure = 15,
        /// <summary>
        /// Value Wizard
        /// </summary>
        [Description("Value Wizard")]
        ValueWizard = 16,
        /// <summary>
        /// Value Wizard Plus
        /// </summary>
        [Description("Value Wizard Plus")]
        ValueWizardPlus = 17,
        /// <summary>
        /// Vero Index Plus
        /// </summary>
        [Description("Vero Index Plus")]
        VeroIndexPlus = 18,
        /// <summary>
        /// Vero Value
        /// </summary>
        [Description("Vero Value")]
        VeroValue = 19
    }
}