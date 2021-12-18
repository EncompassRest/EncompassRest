using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// CorrespondentOptionDesc
    /// </summary>
    public enum CorrespondentOptionDesc
    {
        /// <summary>
        /// Hail &amp; Wind Insurance
        /// </summary>
        [Description("Hail & Wind Insurance")]
        HailAndWindInsurance = 0,
        /// <summary>
        /// Lava Insurance
        /// </summary>
        [Description("Lava Insurance")]
        LavaInsurance = 1,
        /// <summary>
        /// Earthquake Insurance
        /// </summary>
        [Description("Earthquake Insurance")]
        EarthquakeInsurance = 2,
        /// <summary>
        /// School Taxes
        /// </summary>
        [Description("School Taxes")]
        SchoolTaxes = 3,
        /// <summary>
        /// Other Taxes
        /// </summary>
        [Description("Other Taxes")]
        OtherTaxes = 4
    }
}