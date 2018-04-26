using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// StateLicense
    /// </summary>
    public sealed partial class StateLicense : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _aK;
        /// <summary>
        /// StateLicense AK
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AK { get => _aK; set => _aK = value; }
        private DirtyValue<string> _aL;
        /// <summary>
        /// StateLicense AL
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AL { get => _aL; set => _aL = value; }
        private DirtyValue<string> _aR;
        /// <summary>
        /// StateLicense AR
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AR { get => _aR; set => _aR = value; }
        private DirtyValue<string> _aZ;
        /// <summary>
        /// StateLicense AZ
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AZ { get => _aZ; set => _aZ = value; }
        private DirtyValue<string> _cA;
        /// <summary>
        /// StateLicense CA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CA { get => _cA; set => _cA = value; }
        private DirtyValue<string> _cO;
        /// <summary>
        /// StateLicense CO
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CO { get => _cO; set => _cO = value; }
        private DirtyValue<string> _cT;
        /// <summary>
        /// StateLicense CT
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CT { get => _cT; set => _cT = value; }
        private DirtyValue<string> _dC;
        /// <summary>
        /// StateLicense DC
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DC { get => _dC; set => _dC = value; }
        private DirtyValue<string> _dE;
        /// <summary>
        /// StateLicense DE
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string DE { get => _dE; set => _dE = value; }
        private DirtyValue<string> _fL;
        /// <summary>
        /// StateLicense FL
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string FL { get => _fL; set => _fL = value; }
        private DirtyValue<string> _gA;
        /// <summary>
        /// StateLicense GA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string GA { get => _gA; set => _gA = value; }
        private DirtyValue<string> _gU;
        /// <summary>
        /// StateLicense GU
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string GU { get => _gU; set => _gU = value; }
        private DirtyValue<string> _hI;
        /// <summary>
        /// StateLicense HI
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string HI { get => _hI; set => _hI = value; }
        private DirtyValue<string> _iA;
        /// <summary>
        /// StateLicense IA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string IA { get => _iA; set => _iA = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// StateLicense Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _idaho;
        /// <summary>
        /// StateLicense Idaho
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string Idaho { get => _idaho; set => _idaho = value; }
        private DirtyValue<string> _iL;
        /// <summary>
        /// StateLicense IL
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string IL { get => _iL; set => _iL = value; }
        private DirtyValue<string> _iN;
        /// <summary>
        /// StateLicense IN
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string IN { get => _iN; set => _iN = value; }
        private DirtyValue<string> _kS;
        /// <summary>
        /// StateLicense KS
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string KS { get => _kS; set => _kS = value; }
        private DirtyValue<string> _kY;
        /// <summary>
        /// StateLicense KY
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string KY { get => _kY; set => _kY = value; }
        private DirtyValue<string> _lA;
        /// <summary>
        /// StateLicense LA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string LA { get => _lA; set => _lA = value; }
        private DirtyValue<string> _mA;
        /// <summary>
        /// StateLicense MA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MA { get => _mA; set => _mA = value; }
        private DirtyValue<string> _mD;
        /// <summary>
        /// StateLicense MD
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MD { get => _mD; set => _mD = value; }
        private DirtyValue<string> _mE;
        /// <summary>
        /// StateLicense ME
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ME { get => _mE; set => _mE = value; }
        private DirtyValue<string> _mI;
        /// <summary>
        /// StateLicense MI
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MI { get => _mI; set => _mI = value; }
        private DirtyValue<string> _mN;
        /// <summary>
        /// StateLicense MN
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MN { get => _mN; set => _mN = value; }
        private DirtyValue<string> _mO;
        /// <summary>
        /// StateLicense MO
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MO { get => _mO; set => _mO = value; }
        private DirtyValue<string> _mS;
        /// <summary>
        /// StateLicense MS
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MS { get => _mS; set => _mS = value; }
        private DirtyValue<string> _mT;
        /// <summary>
        /// StateLicense MT
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MT { get => _mT; set => _mT = value; }
        private DirtyValue<string> _nC;
        /// <summary>
        /// StateLicense NC
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NC { get => _nC; set => _nC = value; }
        private DirtyValue<string> _nD;
        /// <summary>
        /// StateLicense ND
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ND { get => _nD; set => _nD = value; }
        private DirtyValue<string> _nE;
        /// <summary>
        /// StateLicense NE
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NE { get => _nE; set => _nE = value; }
        private DirtyValue<string> _nH;
        /// <summary>
        /// StateLicense NH
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NH { get => _nH; set => _nH = value; }
        private DirtyValue<string> _nJ;
        /// <summary>
        /// StateLicense NJ
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NJ { get => _nJ; set => _nJ = value; }
        private DirtyValue<string> _nM;
        /// <summary>
        /// StateLicense NM
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NM { get => _nM; set => _nM = value; }
        private DirtyValue<string> _nV;
        /// <summary>
        /// StateLicense NV
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NV { get => _nV; set => _nV = value; }
        private DirtyValue<string> _nY;
        /// <summary>
        /// StateLicense NY
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string NY { get => _nY; set => _nY = value; }
        private DirtyValue<string> _oH;
        /// <summary>
        /// StateLicense OH
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OH { get => _oH; set => _oH = value; }
        private DirtyValue<string> _oK;
        /// <summary>
        /// StateLicense OK
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OK { get => _oK; set => _oK = value; }
        private DirtyValue<string> _oR;
        /// <summary>
        /// StateLicense OR
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string OR { get => _oR; set => _oR = value; }
        private DirtyValue<string> _pA;
        /// <summary>
        /// StateLicense PA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PA { get => _pA; set => _pA = value; }
        private DirtyValue<string> _pR;
        /// <summary>
        /// StateLicense PR
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PR { get => _pR; set => _pR = value; }
        private DirtyValue<string> _rI;
        /// <summary>
        /// StateLicense RI
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string RI { get => _rI; set => _rI = value; }
        private DirtyValue<string> _sC;
        /// <summary>
        /// StateLicense SC
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SC { get => _sC; set => _sC = value; }
        private DirtyValue<string> _sD;
        /// <summary>
        /// StateLicense SD
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SD { get => _sD; set => _sD = value; }
        private DirtyValue<StringEnumValue<StateLicenseType>> _stateLicenseType;
        /// <summary>
        /// StateLicense StateLicenseType
        /// </summary>
        public StringEnumValue<StateLicenseType> StateLicenseType { get => _stateLicenseType; set => _stateLicenseType = value; }
        private DirtyValue<string> _tN;
        /// <summary>
        /// StateLicense TN
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string TN { get => _tN; set => _tN = value; }
        private DirtyValue<string> _tX;
        /// <summary>
        /// StateLicense TX
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string TX { get => _tX; set => _tX = value; }
        private DirtyValue<string> _uT;
        /// <summary>
        /// StateLicense UT
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string UT { get => _uT; set => _uT = value; }
        private DirtyValue<string> _vA;
        /// <summary>
        /// StateLicense VA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string VA { get => _vA; set => _vA = value; }
        private DirtyValue<string> _vI;
        /// <summary>
        /// StateLicense VI
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string VI { get => _vI; set => _vI = value; }
        private DirtyValue<string> _vT;
        /// <summary>
        /// StateLicense VT
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string VT { get => _vT; set => _vT = value; }
        private DirtyValue<string> _wA;
        /// <summary>
        /// StateLicense WA
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string WA { get => _wA; set => _wA = value; }
        private DirtyValue<string> _wI;
        /// <summary>
        /// StateLicense WI
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string WI { get => _wI; set => _wI = value; }
        private DirtyValue<string> _wV;
        /// <summary>
        /// StateLicense WV
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string WV { get => _wV; set => _wV = value; }
        private DirtyValue<string> _wY;
        /// <summary>
        /// StateLicense WY
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string WY { get => _wY; set => _wY = value; }
        internal override bool DirtyInternal
        {
            get => _aK.Dirty
                || _aL.Dirty
                || _aR.Dirty
                || _aZ.Dirty
                || _cA.Dirty
                || _cO.Dirty
                || _cT.Dirty
                || _dC.Dirty
                || _dE.Dirty
                || _fL.Dirty
                || _gA.Dirty
                || _gU.Dirty
                || _hI.Dirty
                || _iA.Dirty
                || _id.Dirty
                || _idaho.Dirty
                || _iL.Dirty
                || _iN.Dirty
                || _kS.Dirty
                || _kY.Dirty
                || _lA.Dirty
                || _mA.Dirty
                || _mD.Dirty
                || _mE.Dirty
                || _mI.Dirty
                || _mN.Dirty
                || _mO.Dirty
                || _mS.Dirty
                || _mT.Dirty
                || _nC.Dirty
                || _nD.Dirty
                || _nE.Dirty
                || _nH.Dirty
                || _nJ.Dirty
                || _nM.Dirty
                || _nV.Dirty
                || _nY.Dirty
                || _oH.Dirty
                || _oK.Dirty
                || _oR.Dirty
                || _pA.Dirty
                || _pR.Dirty
                || _rI.Dirty
                || _sC.Dirty
                || _sD.Dirty
                || _stateLicenseType.Dirty
                || _tN.Dirty
                || _tX.Dirty
                || _uT.Dirty
                || _vA.Dirty
                || _vI.Dirty
                || _vT.Dirty
                || _wA.Dirty
                || _wI.Dirty
                || _wV.Dirty
                || _wY.Dirty;
            set
            {
                _aK.Dirty = value;
                _aL.Dirty = value;
                _aR.Dirty = value;
                _aZ.Dirty = value;
                _cA.Dirty = value;
                _cO.Dirty = value;
                _cT.Dirty = value;
                _dC.Dirty = value;
                _dE.Dirty = value;
                _fL.Dirty = value;
                _gA.Dirty = value;
                _gU.Dirty = value;
                _hI.Dirty = value;
                _iA.Dirty = value;
                _id.Dirty = value;
                _idaho.Dirty = value;
                _iL.Dirty = value;
                _iN.Dirty = value;
                _kS.Dirty = value;
                _kY.Dirty = value;
                _lA.Dirty = value;
                _mA.Dirty = value;
                _mD.Dirty = value;
                _mE.Dirty = value;
                _mI.Dirty = value;
                _mN.Dirty = value;
                _mO.Dirty = value;
                _mS.Dirty = value;
                _mT.Dirty = value;
                _nC.Dirty = value;
                _nD.Dirty = value;
                _nE.Dirty = value;
                _nH.Dirty = value;
                _nJ.Dirty = value;
                _nM.Dirty = value;
                _nV.Dirty = value;
                _nY.Dirty = value;
                _oH.Dirty = value;
                _oK.Dirty = value;
                _oR.Dirty = value;
                _pA.Dirty = value;
                _pR.Dirty = value;
                _rI.Dirty = value;
                _sC.Dirty = value;
                _sD.Dirty = value;
                _stateLicenseType.Dirty = value;
                _tN.Dirty = value;
                _tX.Dirty = value;
                _uT.Dirty = value;
                _vA.Dirty = value;
                _vI.Dirty = value;
                _vT.Dirty = value;
                _wA.Dirty = value;
                _wI.Dirty = value;
                _wV.Dirty = value;
                _wY.Dirty = value;
            }
        }
    }
}