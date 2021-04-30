using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// MfgHomeCertificateOfTitleType
    /// </summary>
    public enum MfgHomeCertificateOfTitleType
    {
        /// <summary>
        /// Home shall be covered by Certificate of Title
        /// </summary>
        [EnumMember(Value = "Home shall be covered by Certificate of Title")]
        HomeShallBeCoveredByCertificateOfTitle = 0,
        /// <summary>
        /// Title Certificate shall be eliminated
        /// </summary>
        [EnumMember(Value = "Title Certificate shall be eliminated")]
        TitleCertificateShallBeEliminated = 1,
        /// <summary>
        /// Title Certificate has been eliminated
        /// </summary>
        [EnumMember(Value = "Title Certificate has been eliminated")]
        TitleCertificateHasBeenEliminated = 2,
        /// <summary>
        /// Manufacturer's Certificate shall be eliminated
        /// </summary>
        [EnumMember(Value = "Manufacturer's Certificate shall be eliminated")]
        ManufacturersCertificateShallBeEliminated = 3,
        /// <summary>
        /// Manufacturer's Certificate has been eliminated
        /// </summary>
        [EnumMember(Value = "Manufacturer's Certificate has been eliminated")]
        ManufacturersCertificateHasBeenEliminated = 4,
        /// <summary>
        /// Home is not covered/Cert is attached
        /// </summary>
        [EnumMember(Value = "Home is not covered/Cert is attached")]
        HomeIsNotCoveredCertIsAttached = 5,
        /// <summary>
        /// Home is not covered/Not Able to produce Cert
        /// </summary>
        [EnumMember(Value = "Home is not covered/Not Able to produce Cert")]
        HomeIsNotCoveredNotAbleToProduceCert = 6
    }
}