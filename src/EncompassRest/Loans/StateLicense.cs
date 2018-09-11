using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// StateLicense
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(StateLicenseType))]
    public sealed partial class StateLicense : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _aK;
        /// <summary>
        /// StateLicense AK
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AK { get => _aK; set => SetField(ref _aK, value); }
        private DirtyValue<string> _aL;
        /// <summary>
        /// StateLicense AL
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AL { get => _aL; set => SetField(ref _aL, value); }
        private DirtyValue<string> _aR;
        /// <summary>
        /// StateLicense AR
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AR { get => _aR; set => SetField(ref _aR, value); }
        private DirtyValue<string> _aZ;
        /// <summary>
        /// StateLicense AZ
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AZ { get => _aZ; set => SetField(ref _aZ, value); }
        private DirtyValue<string> _cA;
        /// <summary>
        /// StateLicense CA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CA { get => _cA; set => SetField(ref _cA, value); }
        private DirtyValue<string> _cO;
        /// <summary>
        /// StateLicense CO
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CO { get => _cO; set => SetField(ref _cO, value); }
        private DirtyValue<string> _cT;
        /// <summary>
        /// StateLicense CT
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CT { get => _cT; set => SetField(ref _cT, value); }
        private DirtyValue<string> _dC;
        /// <summary>
        /// StateLicense DC
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DC { get => _dC; set => SetField(ref _dC, value); }
        private DirtyValue<string> _dE;
        /// <summary>
        /// StateLicense DE
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DE { get => _dE; set => SetField(ref _dE, value); }
        private DirtyValue<string> _fL;
        /// <summary>
        /// StateLicense FL
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string FL { get => _fL; set => SetField(ref _fL, value); }
        private DirtyValue<string> _gA;
        /// <summary>
        /// StateLicense GA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string GA { get => _gA; set => SetField(ref _gA, value); }
        private DirtyValue<string> _gU;
        /// <summary>
        /// StateLicense GU
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string GU { get => _gU; set => SetField(ref _gU, value); }
        private DirtyValue<string> _hI;
        /// <summary>
        /// StateLicense HI
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string HI { get => _hI; set => SetField(ref _hI, value); }
        private DirtyValue<string> _iA;
        /// <summary>
        /// StateLicense IA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string IA { get => _iA; set => SetField(ref _iA, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// StateLicense Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _idaho;
        /// <summary>
        /// StateLicense Idaho
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Idaho { get => _idaho; set => SetField(ref _idaho, value); }
        private DirtyValue<string> _iL;
        /// <summary>
        /// StateLicense IL
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string IL { get => _iL; set => SetField(ref _iL, value); }
        private DirtyValue<string> _iN;
        /// <summary>
        /// StateLicense IN
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string IN { get => _iN; set => SetField(ref _iN, value); }
        private DirtyValue<string> _kS;
        /// <summary>
        /// StateLicense KS
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string KS { get => _kS; set => SetField(ref _kS, value); }
        private DirtyValue<string> _kY;
        /// <summary>
        /// StateLicense KY
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string KY { get => _kY; set => SetField(ref _kY, value); }
        private DirtyValue<string> _lA;
        /// <summary>
        /// StateLicense LA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LA { get => _lA; set => SetField(ref _lA, value); }
        private DirtyValue<string> _mA;
        /// <summary>
        /// StateLicense MA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MA { get => _mA; set => SetField(ref _mA, value); }
        private DirtyValue<string> _mD;
        /// <summary>
        /// StateLicense MD
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MD { get => _mD; set => SetField(ref _mD, value); }
        private DirtyValue<string> _mE;
        /// <summary>
        /// StateLicense ME
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ME { get => _mE; set => SetField(ref _mE, value); }
        private DirtyValue<string> _mI;
        /// <summary>
        /// StateLicense MI
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MI { get => _mI; set => SetField(ref _mI, value); }
        private DirtyValue<string> _mN;
        /// <summary>
        /// StateLicense MN
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MN { get => _mN; set => SetField(ref _mN, value); }
        private DirtyValue<string> _mO;
        /// <summary>
        /// StateLicense MO
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MO { get => _mO; set => SetField(ref _mO, value); }
        private DirtyValue<string> _mS;
        /// <summary>
        /// StateLicense MS
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MS { get => _mS; set => SetField(ref _mS, value); }
        private DirtyValue<string> _mT;
        /// <summary>
        /// StateLicense MT
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MT { get => _mT; set => SetField(ref _mT, value); }
        private DirtyValue<string> _nC;
        /// <summary>
        /// StateLicense NC
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NC { get => _nC; set => SetField(ref _nC, value); }
        private DirtyValue<string> _nD;
        /// <summary>
        /// StateLicense ND
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ND { get => _nD; set => SetField(ref _nD, value); }
        private DirtyValue<string> _nE;
        /// <summary>
        /// StateLicense NE
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NE { get => _nE; set => SetField(ref _nE, value); }
        private DirtyValue<string> _nH;
        /// <summary>
        /// StateLicense NH
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NH { get => _nH; set => SetField(ref _nH, value); }
        private DirtyValue<string> _nJ;
        /// <summary>
        /// StateLicense NJ
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NJ { get => _nJ; set => SetField(ref _nJ, value); }
        private DirtyValue<string> _nM;
        /// <summary>
        /// StateLicense NM
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NM { get => _nM; set => SetField(ref _nM, value); }
        private DirtyValue<string> _nV;
        /// <summary>
        /// StateLicense NV
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NV { get => _nV; set => SetField(ref _nV, value); }
        private DirtyValue<string> _nY;
        /// <summary>
        /// StateLicense NY
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NY { get => _nY; set => SetField(ref _nY, value); }
        private DirtyValue<string> _oH;
        /// <summary>
        /// StateLicense OH
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OH { get => _oH; set => SetField(ref _oH, value); }
        private DirtyValue<string> _oK;
        /// <summary>
        /// StateLicense OK
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OK { get => _oK; set => SetField(ref _oK, value); }
        private DirtyValue<string> _oR;
        /// <summary>
        /// StateLicense OR
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OR { get => _oR; set => SetField(ref _oR, value); }
        private DirtyValue<string> _pA;
        /// <summary>
        /// StateLicense PA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PA { get => _pA; set => SetField(ref _pA, value); }
        private DirtyValue<string> _pR;
        /// <summary>
        /// StateLicense PR
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PR { get => _pR; set => SetField(ref _pR, value); }
        private DirtyValue<string> _rI;
        /// <summary>
        /// StateLicense RI
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string RI { get => _rI; set => SetField(ref _rI, value); }
        private DirtyValue<string> _sC;
        /// <summary>
        /// StateLicense SC
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SC { get => _sC; set => SetField(ref _sC, value); }
        private DirtyValue<string> _sD;
        /// <summary>
        /// StateLicense SD
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SD { get => _sD; set => SetField(ref _sD, value); }
        private DirtyValue<StringEnumValue<StateLicenseType>> _stateLicenseType;
        /// <summary>
        /// StateLicense StateLicenseType
        /// </summary>
        public StringEnumValue<StateLicenseType> StateLicenseType { get => _stateLicenseType; set => SetField(ref _stateLicenseType, value); }
        private DirtyValue<string> _tN;
        /// <summary>
        /// StateLicense TN
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string TN { get => _tN; set => SetField(ref _tN, value); }
        private DirtyValue<string> _tX;
        /// <summary>
        /// StateLicense TX
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string TX { get => _tX; set => SetField(ref _tX, value); }
        private DirtyValue<string> _uT;
        /// <summary>
        /// StateLicense UT
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string UT { get => _uT; set => SetField(ref _uT, value); }
        private DirtyValue<string> _vA;
        /// <summary>
        /// StateLicense VA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string VA { get => _vA; set => SetField(ref _vA, value); }
        private DirtyValue<string> _vI;
        /// <summary>
        /// StateLicense VI
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string VI { get => _vI; set => SetField(ref _vI, value); }
        private DirtyValue<string> _vT;
        /// <summary>
        /// StateLicense VT
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string VT { get => _vT; set => SetField(ref _vT, value); }
        private DirtyValue<string> _wA;
        /// <summary>
        /// StateLicense WA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string WA { get => _wA; set => SetField(ref _wA, value); }
        private DirtyValue<string> _wI;
        /// <summary>
        /// StateLicense WI
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string WI { get => _wI; set => SetField(ref _wI, value); }
        private DirtyValue<string> _wV;
        /// <summary>
        /// StateLicense WV
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string WV { get => _wV; set => SetField(ref _wV, value); }
        private DirtyValue<string> _wY;
        /// <summary>
        /// StateLicense WY
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string WY { get => _wY; set => SetField(ref _wY, value); }
    }
}