using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// Urla2020CitizenshipResidencyType
/// </summary>
public enum Urla2020CitizenshipResidencyType
{
    /// <summary>
    /// US Citizen
    /// </summary>
    [Description("US Citizen")]
    USCitizen = 0,
    /// <summary>
    /// Permanent Resident Alien
    /// </summary>
    [Description("Permanent Resident Alien")]
    PermanentResidentAlien = 1,
    /// <summary>
    /// Non-Permanent Resident Alien
    /// </summary>
    [Description("Non-Permanent Resident Alien")]
    NonPermanentResidentAlien = 2
}