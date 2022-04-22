using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// StateLicense
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(StateLicenseType))]
public sealed partial class StateLicense : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// StateLicense Ak [LIC.AK], [LO.ALLOWED.AK]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ak { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Al [LIC.AL], [LO.ALLOWED.AL]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Al { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Ar [LIC.AR], [LO.ALLOWED.AR]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ar { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Az [LIC.AZ], [LO.ALLOWED.AZ]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Az { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Ca [LIC.CA], [LO.ALLOWED.CA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ca { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Co [LIC.CO], [LO.ALLOWED.CO]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Co { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Ct [LIC.CT], [LO.ALLOWED.CT]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Dc [LIC.DC], [LO.ALLOWED.DC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Dc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense De [LIC.DE], [LO.ALLOWED.DE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? De { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Fl [LIC.FL], [LO.ALLOWED.FL]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Fl { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Ga [LIC.GA], [LO.ALLOWED.GA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ga { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Gu [LIC.GU], [LO.ALLOWED.GU]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Gu { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Hi [LIC.HI], [LO.ALLOWED.HI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Hi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Ia [LIC.IA], [LO.ALLOWED.IA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ia { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Idaho [LIC.ID], [LO.ALLOWED.ID]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Idaho { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Il [LIC.IL], [LO.ALLOWED.IL]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Il { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense In [LIC.IN], [LO.ALLOWED.IN]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? In { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Ks [LIC.KS], [LO.ALLOWED.KS]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ks { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Ky [LIC.KY], [LO.ALLOWED.KY]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ky { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense La [LIC.LA], [LO.ALLOWED.LA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? La { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Ma [LIC.MA], [LO.ALLOWED.MA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ma { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Md [LIC.MD], [LO.ALLOWED.MD]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Md { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Me [LIC.ME], [LO.ALLOWED.ME]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Me { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Mi [LIC.MI], [LO.ALLOWED.MI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Mi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Mn [LIC.MN], [LO.ALLOWED.MN]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Mn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Mo [LIC.MO], [LO.ALLOWED.MO]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Mo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Ms [LIC.MS], [LO.ALLOWED.MS]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ms { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Mt [LIC.MT], [LO.ALLOWED.MT]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Mt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Nc [LIC.NC], [LO.ALLOWED.NC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Nc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Nd [LIC.ND], [LO.ALLOWED.ND]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Nd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Ne [LIC.NE], [LO.ALLOWED.NE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ne { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Nh [LIC.NH], [LO.ALLOWED.NH]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Nh { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Nj [LIC.NJ], [LO.ALLOWED.NJ]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Nj { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Nm [LIC.NM], [LO.ALLOWED.NM]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Nm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Nv [LIC.NV], [LO.ALLOWED.NV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Nv { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Ny [LIC.NY], [LO.ALLOWED.NY]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ny { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Oh [LIC.OH], [LO.ALLOWED.OH]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Oh { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Ok [LIC.OK], [LO.ALLOWED.OK]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ok { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Or [LIC.OR], [LO.ALLOWED.OR]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Or { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Pa [LIC.PA], [LO.ALLOWED.PA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Pa { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Pr [LIC.PR], [LO.ALLOWED.PR]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Pr { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Ri [LIC.RI], [LO.ALLOWED.RI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ri { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Sc [LIC.SC], [LO.ALLOWED.SC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Sc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Sd [LIC.SD], [LO.ALLOWED.SD]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Sd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense StateLicenseType
    /// </summary>
    public StringEnumValue<StateLicenseType> StateLicenseType { get => GetValue<StringEnumValue<StateLicenseType>>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Tn [LIC.TN], [LO.ALLOWED.TN]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Tn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Tx [LIC.TX], [LO.ALLOWED.TX]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Tx { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Ut [LIC.UT], [LO.ALLOWED.UT]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ut { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Va [LIC.VA], [LO.ALLOWED.VA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Va { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Vi [LIC.VI], [LO.ALLOWED.VI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Vi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Vt [LIC.VT], [LO.ALLOWED.VT]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Vt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Wa [LIC.WA], [LO.ALLOWED.WA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Wa { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Wi [LIC.WI], [LO.ALLOWED.WI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Wi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Wv [LIC.WV], [LO.ALLOWED.WV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Wv { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StateLicense Wy [LIC.WY], [LO.ALLOWED.WY]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Wy { get => GetValue<string?>(); set => SetValue(value); }
}