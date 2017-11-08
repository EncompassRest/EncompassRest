using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum MfgHomeCertificateOfTitleType
    {
        [EnumMember(Value = "Home shall be covered by Certificate of Title")]
        HomeShallBeCoveredByCertificateOfTitle = 0,
        [EnumMember(Value = "Title Certificate shall be eliminated")]
        TitleCertificateShallBeEliminated = 1,
        [EnumMember(Value = "Title Certificate has been eliminated")]
        TitleCertificateHasBeenEliminated = 2,
        [EnumMember(Value = "Manufacturer's Certificate shall be eliminated")]
        ManufacturersCertificateShallBeEliminated = 3,
        [EnumMember(Value = "Manufacturer's Certificate has been eliminated")]
        ManufacturersCertificateHasBeenEliminated = 4,
        [EnumMember(Value = "Home is not covered/Cert is attached")]
        HomeIsNotCoveredCertIsAttached = 5,
        [EnumMember(Value = "Home is not covered/Not Able to produce Cert")]
        HomeIsNotCoveredNotAbleToProduceCert = 6
    }
}