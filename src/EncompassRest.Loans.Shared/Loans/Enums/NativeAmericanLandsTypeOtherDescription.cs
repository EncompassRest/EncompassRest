using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// NativeAmericanLandsTypeOtherDescription
/// </summary>
public enum NativeAmericanLandsTypeOtherDescription
{
    /// <summary>
    /// Alaska Native Corporation Land
    /// </summary>
    [Description("Alaska Native Corporation Land")]
    AlaskaNativeCorporationLand = 0,
    /// <summary>
    /// Tribal Trust Land Off Reservation
    /// </summary>
    [Description("Tribal Trust Land Off Reservation")]
    TribalTrustLandOffReservation = 1,
    /// <summary>
    /// Tribal Trust Land On A Reservation
    /// </summary>
    [Description("Tribal Trust Land On A Reservation")]
    TribalTrustLandOnAReservation = 2
}