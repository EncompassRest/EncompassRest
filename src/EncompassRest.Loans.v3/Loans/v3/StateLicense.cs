using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// StateLicense
/// </summary>
public sealed partial class StateLicense : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _ak;
    private DirtyValue<string?>? _al;
    private DirtyValue<string?>? _ar;
    private DirtyValue<string?>? _az;
    private DirtyValue<string?>? _ca;
    private DirtyValue<string?>? _co;
    private DirtyValue<string?>? _ct;
    private DirtyValue<string?>? _dc;
    private DirtyValue<string?>? _de;
    private DirtyValue<string?>? _fl;
    private DirtyValue<string?>? _ga;
    private DirtyValue<string?>? _gu;
    private DirtyValue<string?>? _hi;
    private DirtyValue<string?>? _ia;
    private DirtyValue<string?>? _idaho;
    private DirtyValue<string?>? _il;
    private DirtyValue<string?>? _in;
    private DirtyValue<string?>? _ks;
    private DirtyValue<string?>? _ky;
    private DirtyValue<string?>? _la;
    private DirtyValue<string?>? _ma;
    private DirtyValue<string?>? _md;
    private DirtyValue<string?>? _me;
    private DirtyValue<string?>? _mi;
    private DirtyValue<string?>? _mn;
    private DirtyValue<string?>? _mo;
    private DirtyValue<string?>? _ms;
    private DirtyValue<string?>? _mt;
    private DirtyValue<string?>? _nc;
    private DirtyValue<string?>? _nd;
    private DirtyValue<string?>? _ne;
    private DirtyValue<string?>? _nh;
    private DirtyValue<string?>? _nj;
    private DirtyValue<string?>? _nm;
    private DirtyValue<string?>? _nv;
    private DirtyValue<string?>? _ny;
    private DirtyValue<string?>? _oh;
    private DirtyValue<string?>? _ok;
    private DirtyValue<string?>? _or;
    private DirtyValue<string?>? _pa;
    private DirtyValue<string?>? _pr;
    private DirtyValue<string?>? _ri;
    private DirtyValue<string?>? _sc;
    private DirtyValue<string?>? _sd;
    private DirtyValue<StringEnumValue<StateLicenseType>>? _stateLicenseType;
    private DirtyValue<string?>? _tn;
    private DirtyValue<string?>? _tx;
    private DirtyValue<string?>? _ut;
    private DirtyValue<string?>? _va;
    private DirtyValue<string?>? _vi;
    private DirtyValue<string?>? _vt;
    private DirtyValue<string?>? _wa;
    private DirtyValue<string?>? _wi;
    private DirtyValue<string?>? _wv;
    private DirtyValue<string?>? _wy;

    /// <summary>
    /// StateLicenseContract Ak [LIC.AK], [LO.ALLOWED.AK]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ak { get => _ak; set => SetField(ref _ak, value); }

    /// <summary>
    /// StateLicenseContract Al [LIC.AL], [LO.ALLOWED.AL]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Al { get => _al; set => SetField(ref _al, value); }

    /// <summary>
    /// StateLicenseContract Ar [LIC.AR], [LO.ALLOWED.AR]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ar { get => _ar; set => SetField(ref _ar, value); }

    /// <summary>
    /// StateLicenseContract Az [LIC.AZ], [LO.ALLOWED.AZ]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Az { get => _az; set => SetField(ref _az, value); }

    /// <summary>
    /// StateLicenseContract Ca [LIC.CA], [LO.ALLOWED.CA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ca { get => _ca; set => SetField(ref _ca, value); }

    /// <summary>
    /// StateLicenseContract Co [LIC.CO], [LO.ALLOWED.CO]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Co { get => _co; set => SetField(ref _co, value); }

    /// <summary>
    /// StateLicenseContract Ct [LIC.CT], [LO.ALLOWED.CT]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ct { get => _ct; set => SetField(ref _ct, value); }

    /// <summary>
    /// StateLicenseContract Dc [LIC.DC], [LO.ALLOWED.DC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Dc { get => _dc; set => SetField(ref _dc, value); }

    /// <summary>
    /// StateLicenseContract De [LIC.DE], [LO.ALLOWED.DE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? De { get => _de; set => SetField(ref _de, value); }

    /// <summary>
    /// StateLicenseContract Fl [LIC.FL], [LO.ALLOWED.FL]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Fl { get => _fl; set => SetField(ref _fl, value); }

    /// <summary>
    /// StateLicenseContract Ga [LIC.GA], [LO.ALLOWED.GA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ga { get => _ga; set => SetField(ref _ga, value); }

    /// <summary>
    /// StateLicenseContract Gu [LIC.GU], [LO.ALLOWED.GU]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Gu { get => _gu; set => SetField(ref _gu, value); }

    /// <summary>
    /// StateLicenseContract Hi [LIC.HI], [LO.ALLOWED.HI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Hi { get => _hi; set => SetField(ref _hi, value); }

    /// <summary>
    /// StateLicenseContract Ia [LIC.IA], [LO.ALLOWED.IA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ia { get => _ia; set => SetField(ref _ia, value); }

    /// <summary>
    /// StateLicenseContract Idaho [LIC.ID], [LO.ALLOWED.ID]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Idaho { get => _idaho; set => SetField(ref _idaho, value); }

    /// <summary>
    /// StateLicenseContract Il [LIC.IL], [LO.ALLOWED.IL]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Il { get => _il; set => SetField(ref _il, value); }

    /// <summary>
    /// StateLicenseContract In [LIC.IN], [LO.ALLOWED.IN]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? In { get => _in; set => SetField(ref _in, value); }

    /// <summary>
    /// StateLicenseContract Ks [LIC.KS], [LO.ALLOWED.KS]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ks { get => _ks; set => SetField(ref _ks, value); }

    /// <summary>
    /// StateLicenseContract Ky [LIC.KY], [LO.ALLOWED.KY]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ky { get => _ky; set => SetField(ref _ky, value); }

    /// <summary>
    /// StateLicenseContract La [LIC.LA], [LO.ALLOWED.LA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? La { get => _la; set => SetField(ref _la, value); }

    /// <summary>
    /// StateLicenseContract Ma [LIC.MA], [LO.ALLOWED.MA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ma { get => _ma; set => SetField(ref _ma, value); }

    /// <summary>
    /// StateLicenseContract Md [LIC.MD], [LO.ALLOWED.MD]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Md { get => _md; set => SetField(ref _md, value); }

    /// <summary>
    /// StateLicenseContract Me [LIC.ME], [LO.ALLOWED.ME]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Me { get => _me; set => SetField(ref _me, value); }

    /// <summary>
    /// StateLicenseContract Mi [LIC.MI], [LO.ALLOWED.MI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Mi { get => _mi; set => SetField(ref _mi, value); }

    /// <summary>
    /// StateLicenseContract Mn [LIC.MN], [LO.ALLOWED.MN]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Mn { get => _mn; set => SetField(ref _mn, value); }

    /// <summary>
    /// StateLicenseContract Mo [LIC.MO], [LO.ALLOWED.MO]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Mo { get => _mo; set => SetField(ref _mo, value); }

    /// <summary>
    /// StateLicenseContract Ms [LIC.MS], [LO.ALLOWED.MS]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ms { get => _ms; set => SetField(ref _ms, value); }

    /// <summary>
    /// StateLicenseContract Mt [LIC.MT], [LO.ALLOWED.MT]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Mt { get => _mt; set => SetField(ref _mt, value); }

    /// <summary>
    /// StateLicenseContract Nc [LIC.NC], [LO.ALLOWED.NC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Nc { get => _nc; set => SetField(ref _nc, value); }

    /// <summary>
    /// StateLicenseContract Nd [LIC.ND], [LO.ALLOWED.ND]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Nd { get => _nd; set => SetField(ref _nd, value); }

    /// <summary>
    /// StateLicenseContract Ne [LIC.NE], [LO.ALLOWED.NE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ne { get => _ne; set => SetField(ref _ne, value); }

    /// <summary>
    /// StateLicenseContract Nh [LIC.NH], [LO.ALLOWED.NH]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Nh { get => _nh; set => SetField(ref _nh, value); }

    /// <summary>
    /// StateLicenseContract Nj [LIC.NJ], [LO.ALLOWED.NJ]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Nj { get => _nj; set => SetField(ref _nj, value); }

    /// <summary>
    /// StateLicenseContract Nm [LIC.NM], [LO.ALLOWED.NM]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Nm { get => _nm; set => SetField(ref _nm, value); }

    /// <summary>
    /// StateLicenseContract Nv [LIC.NV], [LO.ALLOWED.NV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Nv { get => _nv; set => SetField(ref _nv, value); }

    /// <summary>
    /// StateLicenseContract Ny [LIC.NY], [LO.ALLOWED.NY]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ny { get => _ny; set => SetField(ref _ny, value); }

    /// <summary>
    /// StateLicenseContract Oh [LIC.OH], [LO.ALLOWED.OH]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Oh { get => _oh; set => SetField(ref _oh, value); }

    /// <summary>
    /// StateLicenseContract Ok [LIC.OK], [LO.ALLOWED.OK]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ok { get => _ok; set => SetField(ref _ok, value); }

    /// <summary>
    /// StateLicenseContract Or [LIC.OR], [LO.ALLOWED.OR]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Or { get => _or; set => SetField(ref _or, value); }

    /// <summary>
    /// StateLicenseContract Pa [LIC.PA], [LO.ALLOWED.PA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Pa { get => _pa; set => SetField(ref _pa, value); }

    /// <summary>
    /// StateLicenseContract Pr [LIC.PR], [LO.ALLOWED.PR]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Pr { get => _pr; set => SetField(ref _pr, value); }

    /// <summary>
    /// StateLicenseContract Ri [LIC.RI], [LO.ALLOWED.RI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ri { get => _ri; set => SetField(ref _ri, value); }

    /// <summary>
    /// StateLicenseContract Sc [LIC.SC], [LO.ALLOWED.SC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Sc { get => _sc; set => SetField(ref _sc, value); }

    /// <summary>
    /// StateLicenseContract Sd [LIC.SD], [LO.ALLOWED.SD]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Sd { get => _sd; set => SetField(ref _sd, value); }

    /// <summary>
    /// StateLicenseContract StateLicenseType
    /// </summary>
    public StringEnumValue<StateLicenseType> StateLicenseType { get => _stateLicenseType; set => SetField(ref _stateLicenseType, value); }

    /// <summary>
    /// StateLicenseContract Tn [LIC.TN], [LO.ALLOWED.TN]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Tn { get => _tn; set => SetField(ref _tn, value); }

    /// <summary>
    /// StateLicenseContract Tx [LIC.TX], [LO.ALLOWED.TX]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Tx { get => _tx; set => SetField(ref _tx, value); }

    /// <summary>
    /// StateLicenseContract Ut [LIC.UT], [LO.ALLOWED.UT]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Ut { get => _ut; set => SetField(ref _ut, value); }

    /// <summary>
    /// StateLicenseContract Va [LIC.VA], [LO.ALLOWED.VA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Va { get => _va; set => SetField(ref _va, value); }

    /// <summary>
    /// StateLicenseContract Vi [LIC.VI], [LO.ALLOWED.VI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Vi { get => _vi; set => SetField(ref _vi, value); }

    /// <summary>
    /// StateLicenseContract Vt [LIC.VT], [LO.ALLOWED.VT]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Vt { get => _vt; set => SetField(ref _vt, value); }

    /// <summary>
    /// StateLicenseContract Wa [LIC.WA], [LO.ALLOWED.WA]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Wa { get => _wa; set => SetField(ref _wa, value); }

    /// <summary>
    /// StateLicenseContract Wi [LIC.WI], [LO.ALLOWED.WI]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Wi { get => _wi; set => SetField(ref _wi, value); }

    /// <summary>
    /// StateLicenseContract Wv [LIC.WV], [LO.ALLOWED.WV]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Wv { get => _wv; set => SetField(ref _wv, value); }

    /// <summary>
    /// StateLicenseContract Wy [LIC.WY], [LO.ALLOWED.WY]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Wy { get => _wy; set => SetField(ref _wy, value); }
}