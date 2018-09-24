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
    public sealed partial class StateLicense : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _aK;
        private DirtyValue<string> _aL;
        private DirtyValue<string> _aR;
        private DirtyValue<string> _aZ;
        private DirtyValue<string> _cA;
        private DirtyValue<string> _cO;
        private DirtyValue<string> _cT;
        private DirtyValue<string> _dC;
        private DirtyValue<string> _dE;
        private DirtyValue<string> _fL;
        private DirtyValue<string> _gA;
        private DirtyValue<string> _gU;
        private DirtyValue<string> _hI;
        private DirtyValue<string> _iA;
        private DirtyValue<string> _id;
        private DirtyValue<string> _idaho;
        private DirtyValue<string> _iL;
        private DirtyValue<string> _iN;
        private DirtyValue<string> _kS;
        private DirtyValue<string> _kY;
        private DirtyValue<string> _lA;
        private DirtyValue<string> _mA;
        private DirtyValue<string> _mD;
        private DirtyValue<string> _mE;
        private DirtyValue<string> _mI;
        private DirtyValue<string> _mN;
        private DirtyValue<string> _mO;
        private DirtyValue<string> _mS;
        private DirtyValue<string> _mT;
        private DirtyValue<string> _nC;
        private DirtyValue<string> _nD;
        private DirtyValue<string> _nE;
        private DirtyValue<string> _nH;
        private DirtyValue<string> _nJ;
        private DirtyValue<string> _nM;
        private DirtyValue<string> _nV;
        private DirtyValue<string> _nY;
        private DirtyValue<string> _oH;
        private DirtyValue<string> _oK;
        private DirtyValue<string> _oR;
        private DirtyValue<string> _pA;
        private DirtyValue<string> _pR;
        private DirtyValue<string> _rI;
        private DirtyValue<string> _sC;
        private DirtyValue<string> _sD;
        private DirtyValue<StringEnumValue<StateLicenseType>> _stateLicenseType;
        private DirtyValue<string> _tN;
        private DirtyValue<string> _tX;
        private DirtyValue<string> _uT;
        private DirtyValue<string> _vA;
        private DirtyValue<string> _vI;
        private DirtyValue<string> _vT;
        private DirtyValue<string> _wA;
        private DirtyValue<string> _wI;
        private DirtyValue<string> _wV;
        private DirtyValue<string> _wY;

        /// <summary>
        /// StateLicense AK
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AK { get => _aK; set => SetField(ref _aK, value); }

        /// <summary>
        /// StateLicense AL
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AL { get => _aL; set => SetField(ref _aL, value); }

        /// <summary>
        /// StateLicense AR
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AR { get => _aR; set => SetField(ref _aR, value); }

        /// <summary>
        /// StateLicense AZ
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AZ { get => _aZ; set => SetField(ref _aZ, value); }

        /// <summary>
        /// StateLicense CA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CA { get => _cA; set => SetField(ref _cA, value); }

        /// <summary>
        /// StateLicense CO
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CO { get => _cO; set => SetField(ref _cO, value); }

        /// <summary>
        /// StateLicense CT
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CT { get => _cT; set => SetField(ref _cT, value); }

        /// <summary>
        /// StateLicense DC
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DC { get => _dC; set => SetField(ref _dC, value); }

        /// <summary>
        /// StateLicense DE
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DE { get => _dE; set => SetField(ref _dE, value); }

        /// <summary>
        /// StateLicense FL
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string FL { get => _fL; set => SetField(ref _fL, value); }

        /// <summary>
        /// StateLicense GA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string GA { get => _gA; set => SetField(ref _gA, value); }

        /// <summary>
        /// StateLicense GU
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string GU { get => _gU; set => SetField(ref _gU, value); }

        /// <summary>
        /// StateLicense HI
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string HI { get => _hI; set => SetField(ref _hI, value); }

        /// <summary>
        /// StateLicense IA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string IA { get => _iA; set => SetField(ref _iA, value); }

        /// <summary>
        /// StateLicense Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// StateLicense Idaho
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Idaho { get => _idaho; set => SetField(ref _idaho, value); }

        /// <summary>
        /// StateLicense IL
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string IL { get => _iL; set => SetField(ref _iL, value); }

        /// <summary>
        /// StateLicense IN
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string IN { get => _iN; set => SetField(ref _iN, value); }

        /// <summary>
        /// StateLicense KS
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string KS { get => _kS; set => SetField(ref _kS, value); }

        /// <summary>
        /// StateLicense KY
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string KY { get => _kY; set => SetField(ref _kY, value); }

        /// <summary>
        /// StateLicense LA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LA { get => _lA; set => SetField(ref _lA, value); }

        /// <summary>
        /// StateLicense MA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MA { get => _mA; set => SetField(ref _mA, value); }

        /// <summary>
        /// StateLicense MD
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MD { get => _mD; set => SetField(ref _mD, value); }

        /// <summary>
        /// StateLicense ME
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ME { get => _mE; set => SetField(ref _mE, value); }

        /// <summary>
        /// StateLicense MI
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MI { get => _mI; set => SetField(ref _mI, value); }

        /// <summary>
        /// StateLicense MN
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MN { get => _mN; set => SetField(ref _mN, value); }

        /// <summary>
        /// StateLicense MO
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MO { get => _mO; set => SetField(ref _mO, value); }

        /// <summary>
        /// StateLicense MS
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MS { get => _mS; set => SetField(ref _mS, value); }

        /// <summary>
        /// StateLicense MT
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MT { get => _mT; set => SetField(ref _mT, value); }

        /// <summary>
        /// StateLicense NC
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NC { get => _nC; set => SetField(ref _nC, value); }

        /// <summary>
        /// StateLicense ND
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ND { get => _nD; set => SetField(ref _nD, value); }

        /// <summary>
        /// StateLicense NE
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NE { get => _nE; set => SetField(ref _nE, value); }

        /// <summary>
        /// StateLicense NH
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NH { get => _nH; set => SetField(ref _nH, value); }

        /// <summary>
        /// StateLicense NJ
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NJ { get => _nJ; set => SetField(ref _nJ, value); }

        /// <summary>
        /// StateLicense NM
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NM { get => _nM; set => SetField(ref _nM, value); }

        /// <summary>
        /// StateLicense NV
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NV { get => _nV; set => SetField(ref _nV, value); }

        /// <summary>
        /// StateLicense NY
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NY { get => _nY; set => SetField(ref _nY, value); }

        /// <summary>
        /// StateLicense OH
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OH { get => _oH; set => SetField(ref _oH, value); }

        /// <summary>
        /// StateLicense OK
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OK { get => _oK; set => SetField(ref _oK, value); }

        /// <summary>
        /// StateLicense OR
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OR { get => _oR; set => SetField(ref _oR, value); }

        /// <summary>
        /// StateLicense PA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PA { get => _pA; set => SetField(ref _pA, value); }

        /// <summary>
        /// StateLicense PR
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PR { get => _pR; set => SetField(ref _pR, value); }

        /// <summary>
        /// StateLicense RI
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string RI { get => _rI; set => SetField(ref _rI, value); }

        /// <summary>
        /// StateLicense SC
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SC { get => _sC; set => SetField(ref _sC, value); }

        /// <summary>
        /// StateLicense SD
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SD { get => _sD; set => SetField(ref _sD, value); }

        /// <summary>
        /// StateLicense StateLicenseType
        /// </summary>
        public StringEnumValue<StateLicenseType> StateLicenseType { get => _stateLicenseType; set => SetField(ref _stateLicenseType, value); }

        /// <summary>
        /// StateLicense TN
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string TN { get => _tN; set => SetField(ref _tN, value); }

        /// <summary>
        /// StateLicense TX
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string TX { get => _tX; set => SetField(ref _tX, value); }

        /// <summary>
        /// StateLicense UT
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string UT { get => _uT; set => SetField(ref _uT, value); }

        /// <summary>
        /// StateLicense VA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string VA { get => _vA; set => SetField(ref _vA, value); }

        /// <summary>
        /// StateLicense VI
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string VI { get => _vI; set => SetField(ref _vI, value); }

        /// <summary>
        /// StateLicense VT
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string VT { get => _vT; set => SetField(ref _vT, value); }

        /// <summary>
        /// StateLicense WA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string WA { get => _wA; set => SetField(ref _wA, value); }

        /// <summary>
        /// StateLicense WI
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string WI { get => _wI; set => SetField(ref _wI, value); }

        /// <summary>
        /// StateLicense WV
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string WV { get => _wV; set => SetField(ref _wV, value); }

        /// <summary>
        /// StateLicense WY
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string WY { get => _wY; set => SetField(ref _wY, value); }
    }
}