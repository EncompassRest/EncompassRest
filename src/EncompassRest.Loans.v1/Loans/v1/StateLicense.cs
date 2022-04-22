using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// StateLicense
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(StateLicenseType))]
public sealed partial class StateLicense : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// StateLicense AK [LIC.AK], [LO.ALLOWED.AK]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AK { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense AL [LIC.AL], [LO.ALLOWED.AL]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AL { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense AR [LIC.AR], [LO.ALLOWED.AR]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AR { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense AZ [LIC.AZ], [LO.ALLOWED.AZ]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AZ { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense CA [LIC.CA], [LO.ALLOWED.CA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CA { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense CO [LIC.CO], [LO.ALLOWED.CO]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CO { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense CT [LIC.CT], [LO.ALLOWED.CT]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CT { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense DC [LIC.DC], [LO.ALLOWED.DC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DC { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense DE [LIC.DE], [LO.ALLOWED.DE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DE { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense FL [LIC.FL], [LO.ALLOWED.FL]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FL { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense GA [LIC.GA], [LO.ALLOWED.GA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? GA { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense GU [LIC.GU], [LO.ALLOWED.GU]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? GU { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense HI [LIC.HI], [LO.ALLOWED.HI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HI { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense IA [LIC.IA], [LO.ALLOWED.IA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? IA { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Idaho [LIC.ID], [LO.ALLOWED.ID]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Idaho { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense IL [LIC.IL], [LO.ALLOWED.IL]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? IL { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense IN [LIC.IN], [LO.ALLOWED.IN]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? IN { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense KS [LIC.KS], [LO.ALLOWED.KS]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? KS { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense KY [LIC.KY], [LO.ALLOWED.KY]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? KY { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense LA [LIC.LA], [LO.ALLOWED.LA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LA { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense MA [LIC.MA], [LO.ALLOWED.MA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MA { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense MD [LIC.MD], [LO.ALLOWED.MD]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MD { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense ME [LIC.ME], [LO.ALLOWED.ME]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ME { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense MI [LIC.MI], [LO.ALLOWED.MI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MI { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense MN [LIC.MN], [LO.ALLOWED.MN]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MN { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense MO [LIC.MO], [LO.ALLOWED.MO]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MO { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense MS [LIC.MS], [LO.ALLOWED.MS]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MS { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense MT [LIC.MT], [LO.ALLOWED.MT]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MT { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense NC [LIC.NC], [LO.ALLOWED.NC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? NC { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense ND [LIC.ND], [LO.ALLOWED.ND]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ND { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense NE [LIC.NE], [LO.ALLOWED.NE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? NE { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense NH [LIC.NH], [LO.ALLOWED.NH]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? NH { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense NJ [LIC.NJ], [LO.ALLOWED.NJ]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? NJ { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense NM [LIC.NM], [LO.ALLOWED.NM]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? NM { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense NV [LIC.NV], [LO.ALLOWED.NV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? NV { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense NY [LIC.NY], [LO.ALLOWED.NY]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? NY { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense OH [LIC.OH], [LO.ALLOWED.OH]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OH { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense OK [LIC.OK], [LO.ALLOWED.OK]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OK { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense OR [LIC.OR], [LO.ALLOWED.OR]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OR { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense PA [LIC.PA], [LO.ALLOWED.PA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PA { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense PR [LIC.PR], [LO.ALLOWED.PR]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PR { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense RI [LIC.RI], [LO.ALLOWED.RI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RI { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense SC [LIC.SC], [LO.ALLOWED.SC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SC { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense SD [LIC.SD], [LO.ALLOWED.SD]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SD { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense StateLicenseType
    /// </summary>
    public StringEnumValue<StateLicenseType> StateLicenseType { get => GetValue<StringEnumValue<StateLicenseType>>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense TN [LIC.TN], [LO.ALLOWED.TN]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TN { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense TX [LIC.TX], [LO.ALLOWED.TX]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TX { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense UT [LIC.UT], [LO.ALLOWED.UT]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? UT { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense VA [LIC.VA], [LO.ALLOWED.VA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? VA { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense VI [LIC.VI], [LO.ALLOWED.VI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? VI { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense VT [LIC.VT], [LO.ALLOWED.VT]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? VT { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense WA [LIC.WA], [LO.ALLOWED.WA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WA { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense WI [LIC.WI], [LO.ALLOWED.WI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WI { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense WV [LIC.WV], [LO.ALLOWED.WV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WV { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense WY [LIC.WY], [LO.ALLOWED.WY]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? WY { get => GetValue<string?>(); set => SetValue(value); }
}