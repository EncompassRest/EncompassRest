using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// Occupancy
    /// </summary>
    public enum Occupancy
    {
        /// <summary>
        /// I now actually occupy the above property as my home
        /// </summary>
        [Description("I now actually occupy the above property as my home")]
        ActuallyOccupyPropertyAsMyHome = 0,
        /// <summary>
        /// I, the Borrower or Co-Borrower will occupy the property within 60 days of signing the security instrument, and intend to continue occupancy for at least one year
        /// </summary>
        [Description("I, the Borrower or Co-Borrower will occupy the property within 60 days of signing the security instrument, and intend to continue occupancy for at least one year")]
        ActuallyOccupyPropertyWithin60DaysContinueAtLeast1Year = 1,
        /// <summary>
        /// I do not intend to occupy the property as my primary residence
        /// </summary>
        [Description("I do not intend to occupy the property as my primary residence")]
        DoNotIntendToOccupyPropertyAsMyHome = 2,
        /// <summary>
        /// My spouse is on active military duty and I occupy
        /// </summary>
        [Description("My spouse is on active military duty and I occupy")]
        SpouseOnActiveMilitaryDuty = 3,
        /// <summary>
        /// I am active duty and my dependent child occupies home
        /// </summary>
        [Description("I am active duty and my dependent child occupies home")]
        VeteranOnActiveMilitaryDuty = 4,
        /// <summary>
        /// I previously occupied the property as my home
        /// </summary>
        [Description("I previously occupied the property as my home")]
        PreviouslyOccupiedTheProperty = 5,
        /// <summary>
        /// While my spouse was on active military duty...I previously
        /// </summary>
        [Description("While my spouse was on active military duty...I previously")]
        PreviouslyOccupiedWhileSpouseOnActiveMilitaryDuty = 6,
        /// <summary>
        /// I was on active military duty...my dependent child occupied home
        /// </summary>
        [Description("I was on active military duty...my dependent child occupied home")]
        PreviouslyDependentOccupiedWhileVeteranOnActiveMilitaryDuty = 7
    }
}