using EncompassApi.Loans.Enums;

namespace EncompassApi.Loans
{
    /// <summary>
    /// StateLicense
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(StateLicenseType))]
    public sealed partial class StateLicense : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _aK;
        private DirtyValue<string?>? _aL;
        private DirtyValue<string?>? _aR;
        private DirtyValue<string?>? _aZ;
        private DirtyValue<string?>? _cA;
        private DirtyValue<string?>? _cO;
        private DirtyValue<string?>? _cT;
        private DirtyValue<string?>? _dC;
        private DirtyValue<string?>? _dE;
        private DirtyValue<string?>? _fL;
        private DirtyValue<string?>? _gA;
        private DirtyValue<string?>? _gU;
        private DirtyValue<string?>? _hI;
        private DirtyValue<string?>? _iA;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _idaho;
        private DirtyValue<string?>? _iL;
        private DirtyValue<string?>? _iN;
        private DirtyValue<string?>? _kS;
        private DirtyValue<string?>? _kY;
        private DirtyValue<string?>? _lA;
        private DirtyValue<string?>? _mA;
        private DirtyValue<string?>? _mD;
        private DirtyValue<string?>? _mE;
        private DirtyValue<string?>? _mI;
        private DirtyValue<string?>? _mN;
        private DirtyValue<string?>? _mO;
        private DirtyValue<string?>? _mS;
        private DirtyValue<string?>? _mT;
        private DirtyValue<string?>? _nC;
        private DirtyValue<string?>? _nD;
        private DirtyValue<string?>? _nE;
        private DirtyValue<string?>? _nH;
        private DirtyValue<string?>? _nJ;
        private DirtyValue<string?>? _nM;
        private DirtyValue<string?>? _nV;
        private DirtyValue<string?>? _nY;
        private DirtyValue<string?>? _oH;
        private DirtyValue<string?>? _oK;
        private DirtyValue<string?>? _oR;
        private DirtyValue<string?>? _pA;
        private DirtyValue<string?>? _pR;
        private DirtyValue<string?>? _rI;
        private DirtyValue<string?>? _sC;
        private DirtyValue<string?>? _sD;
        private DirtyValue<StringEnumValue<StateLicenseType>>? _stateLicenseType;
        private DirtyValue<string?>? _tN;
        private DirtyValue<string?>? _tX;
        private DirtyValue<string?>? _uT;
        private DirtyValue<string?>? _vA;
        private DirtyValue<string?>? _vI;
        private DirtyValue<string?>? _vT;
        private DirtyValue<string?>? _wA;
        private DirtyValue<string?>? _wI;
        private DirtyValue<string?>? _wV;
        private DirtyValue<string?>? _wY;

        /// <summary>
        /// StateLicense AK [LIC.AK], [LO.ALLOWED.AK]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? AK { get => _aK; set => SetField(ref _aK, value); }

        /// <summary>
        /// StateLicense AL [LIC.AL], [LO.ALLOWED.AL]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? AL { get => _aL; set => SetField(ref _aL, value); }

        /// <summary>
        /// StateLicense AR [LIC.AR], [LO.ALLOWED.AR]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? AR { get => _aR; set => SetField(ref _aR, value); }

        /// <summary>
        /// StateLicense AZ [LIC.AZ], [LO.ALLOWED.AZ]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? AZ { get => _aZ; set => SetField(ref _aZ, value); }

        /// <summary>
        /// StateLicense CA [LIC.CA], [LO.ALLOWED.CA]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? CA { get => _cA; set => SetField(ref _cA, value); }

        /// <summary>
        /// StateLicense CO [LIC.CO], [LO.ALLOWED.CO]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? CO { get => _cO; set => SetField(ref _cO, value); }

        /// <summary>
        /// StateLicense CT [LIC.CT], [LO.ALLOWED.CT]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? CT { get => _cT; set => SetField(ref _cT, value); }

        /// <summary>
        /// StateLicense DC [LIC.DC], [LO.ALLOWED.DC]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? DC { get => _dC; set => SetField(ref _dC, value); }

        /// <summary>
        /// StateLicense DE [LIC.DE], [LO.ALLOWED.DE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? DE { get => _dE; set => SetField(ref _dE, value); }

        /// <summary>
        /// StateLicense FL [LIC.FL], [LO.ALLOWED.FL]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? FL { get => _fL; set => SetField(ref _fL, value); }

        /// <summary>
        /// StateLicense GA [LIC.GA], [LO.ALLOWED.GA]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? GA { get => _gA; set => SetField(ref _gA, value); }

        /// <summary>
        /// StateLicense GU [LIC.GU], [LO.ALLOWED.GU]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? GU { get => _gU; set => SetField(ref _gU, value); }

        /// <summary>
        /// StateLicense HI [LIC.HI], [LO.ALLOWED.HI]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? HI { get => _hI; set => SetField(ref _hI, value); }

        /// <summary>
        /// StateLicense IA [LIC.IA], [LO.ALLOWED.IA]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? IA { get => _iA; set => SetField(ref _iA, value); }

        /// <summary>
        /// StateLicense Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// StateLicense Idaho [LIC.ID], [LO.ALLOWED.ID]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? Idaho { get => _idaho; set => SetField(ref _idaho, value); }

        /// <summary>
        /// StateLicense IL [LIC.IL], [LO.ALLOWED.IL]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? IL { get => _iL; set => SetField(ref _iL, value); }

        /// <summary>
        /// StateLicense IN [LIC.IN], [LO.ALLOWED.IN]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? IN { get => _iN; set => SetField(ref _iN, value); }

        /// <summary>
        /// StateLicense KS [LIC.KS], [LO.ALLOWED.KS]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? KS { get => _kS; set => SetField(ref _kS, value); }

        /// <summary>
        /// StateLicense KY [LIC.KY], [LO.ALLOWED.KY]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? KY { get => _kY; set => SetField(ref _kY, value); }

        /// <summary>
        /// StateLicense LA [LIC.LA], [LO.ALLOWED.LA]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? LA { get => _lA; set => SetField(ref _lA, value); }

        /// <summary>
        /// StateLicense MA [LIC.MA], [LO.ALLOWED.MA]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? MA { get => _mA; set => SetField(ref _mA, value); }

        /// <summary>
        /// StateLicense MD [LIC.MD], [LO.ALLOWED.MD]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? MD { get => _mD; set => SetField(ref _mD, value); }

        /// <summary>
        /// StateLicense ME [LIC.ME], [LO.ALLOWED.ME]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? ME { get => _mE; set => SetField(ref _mE, value); }

        /// <summary>
        /// StateLicense MI [LIC.MI], [LO.ALLOWED.MI]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? MI { get => _mI; set => SetField(ref _mI, value); }

        /// <summary>
        /// StateLicense MN [LIC.MN], [LO.ALLOWED.MN]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? MN { get => _mN; set => SetField(ref _mN, value); }

        /// <summary>
        /// StateLicense MO [LIC.MO], [LO.ALLOWED.MO]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? MO { get => _mO; set => SetField(ref _mO, value); }

        /// <summary>
        /// StateLicense MS [LIC.MS], [LO.ALLOWED.MS]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? MS { get => _mS; set => SetField(ref _mS, value); }

        /// <summary>
        /// StateLicense MT [LIC.MT], [LO.ALLOWED.MT]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? MT { get => _mT; set => SetField(ref _mT, value); }

        /// <summary>
        /// StateLicense NC [LIC.NC], [LO.ALLOWED.NC]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? NC { get => _nC; set => SetField(ref _nC, value); }

        /// <summary>
        /// StateLicense ND [LIC.ND], [LO.ALLOWED.ND]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? ND { get => _nD; set => SetField(ref _nD, value); }

        /// <summary>
        /// StateLicense NE [LIC.NE], [LO.ALLOWED.NE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? NE { get => _nE; set => SetField(ref _nE, value); }

        /// <summary>
        /// StateLicense NH [LIC.NH], [LO.ALLOWED.NH]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? NH { get => _nH; set => SetField(ref _nH, value); }

        /// <summary>
        /// StateLicense NJ [LIC.NJ], [LO.ALLOWED.NJ]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? NJ { get => _nJ; set => SetField(ref _nJ, value); }

        /// <summary>
        /// StateLicense NM [LIC.NM], [LO.ALLOWED.NM]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? NM { get => _nM; set => SetField(ref _nM, value); }

        /// <summary>
        /// StateLicense NV [LIC.NV], [LO.ALLOWED.NV]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? NV { get => _nV; set => SetField(ref _nV, value); }

        /// <summary>
        /// StateLicense NY [LIC.NY], [LO.ALLOWED.NY]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? NY { get => _nY; set => SetField(ref _nY, value); }

        /// <summary>
        /// StateLicense OH [LIC.OH], [LO.ALLOWED.OH]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? OH { get => _oH; set => SetField(ref _oH, value); }

        /// <summary>
        /// StateLicense OK [LIC.OK], [LO.ALLOWED.OK]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? OK { get => _oK; set => SetField(ref _oK, value); }

        /// <summary>
        /// StateLicense OR [LIC.OR], [LO.ALLOWED.OR]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? OR { get => _oR; set => SetField(ref _oR, value); }

        /// <summary>
        /// StateLicense PA [LIC.PA], [LO.ALLOWED.PA]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PA { get => _pA; set => SetField(ref _pA, value); }

        /// <summary>
        /// StateLicense PR [LIC.PR], [LO.ALLOWED.PR]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PR { get => _pR; set => SetField(ref _pR, value); }

        /// <summary>
        /// StateLicense RI [LIC.RI], [LO.ALLOWED.RI]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? RI { get => _rI; set => SetField(ref _rI, value); }

        /// <summary>
        /// StateLicense SC [LIC.SC], [LO.ALLOWED.SC]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? SC { get => _sC; set => SetField(ref _sC, value); }

        /// <summary>
        /// StateLicense SD [LIC.SD], [LO.ALLOWED.SD]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? SD { get => _sD; set => SetField(ref _sD, value); }

        /// <summary>
        /// StateLicense StateLicenseType
        /// </summary>
        public StringEnumValue<StateLicenseType> StateLicenseType { get => _stateLicenseType; set => SetField(ref _stateLicenseType, value); }

        /// <summary>
        /// StateLicense TN [LIC.TN], [LO.ALLOWED.TN]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? TN { get => _tN; set => SetField(ref _tN, value); }

        /// <summary>
        /// StateLicense TX [LIC.TX], [LO.ALLOWED.TX]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? TX { get => _tX; set => SetField(ref _tX, value); }

        /// <summary>
        /// StateLicense UT [LIC.UT], [LO.ALLOWED.UT]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? UT { get => _uT; set => SetField(ref _uT, value); }

        /// <summary>
        /// StateLicense VA [LIC.VA], [LO.ALLOWED.VA]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? VA { get => _vA; set => SetField(ref _vA, value); }

        /// <summary>
        /// StateLicense VI [LIC.VI], [LO.ALLOWED.VI]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? VI { get => _vI; set => SetField(ref _vI, value); }

        /// <summary>
        /// StateLicense VT [LIC.VT], [LO.ALLOWED.VT]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? VT { get => _vT; set => SetField(ref _vT, value); }

        /// <summary>
        /// StateLicense WA [LIC.WA], [LO.ALLOWED.WA]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? WA { get => _wA; set => SetField(ref _wA, value); }

        /// <summary>
        /// StateLicense WI [LIC.WI], [LO.ALLOWED.WI]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? WI { get => _wI; set => SetField(ref _wI, value); }

        /// <summary>
        /// StateLicense WV [LIC.WV], [LO.ALLOWED.WV]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? WV { get => _wV; set => SetField(ref _wV, value); }

        /// <summary>
        /// StateLicense WY [LIC.WY], [LO.ALLOWED.WY]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? WY { get => _wY; set => SetField(ref _wY, value); }
    }
}