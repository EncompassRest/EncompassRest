using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// ManufacturedHome
    /// </summary>
    public enum ManufacturedHome
    {
        /// <summary>
        /// M/H on Permanent Foundation
        /// </summary>
        [Description("M/H on Permanent Foundation")]
        PermanentFoundation = 0,
        /// <summary>
        /// M/H Only (Veteran Owned Lot)
        /// </summary>
        [Description("M/H Only (Veteran Owned Lot)")]
        VeteranOwnedLot = 1,
        /// <summary>
        /// M/H Only (Rented Space)
        /// </summary>
        [Description("M/H Only (Rented Space)")]
        RentedSpace = 2,
        /// <summary>
        /// Other - Not M/H
        /// </summary>
        [Description("Other - Not M/H")]
        Other = 3
    }
}