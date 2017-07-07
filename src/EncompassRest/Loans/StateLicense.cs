using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class StateLicense : IClean
    {
        private Value<string> _aK;
        public string AK { get { return _aK; } set { _aK = value; } }
        private Value<string> _aL;
        public string AL { get { return _aL; } set { _aL = value; } }
        private Value<string> _aR;
        public string AR { get { return _aR; } set { _aR = value; } }
        private Value<string> _aZ;
        public string AZ { get { return _aZ; } set { _aZ = value; } }
        private Value<string> _cA;
        public string CA { get { return _cA; } set { _cA = value; } }
        private Value<string> _cO;
        public string CO { get { return _cO; } set { _cO = value; } }
        private Value<string> _cT;
        public string CT { get { return _cT; } set { _cT = value; } }
        private Value<string> _dC;
        public string DC { get { return _dC; } set { _dC = value; } }
        private Value<string> _dE;
        public string DE { get { return _dE; } set { _dE = value; } }
        private Value<string> _fL;
        public string FL { get { return _fL; } set { _fL = value; } }
        private Value<string> _gA;
        public string GA { get { return _gA; } set { _gA = value; } }
        private Value<string> _gU;
        public string GU { get { return _gU; } set { _gU = value; } }
        private Value<string> _hI;
        public string HI { get { return _hI; } set { _hI = value; } }
        private Value<string> _iA;
        public string IA { get { return _iA; } set { _iA = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _idaho;
        public string Idaho { get { return _idaho; } set { _idaho = value; } }
        private Value<string> _iL;
        public string IL { get { return _iL; } set { _iL = value; } }
        private Value<string> _iN;
        public string IN { get { return _iN; } set { _iN = value; } }
        private Value<string> _kS;
        public string KS { get { return _kS; } set { _kS = value; } }
        private Value<string> _kY;
        public string KY { get { return _kY; } set { _kY = value; } }
        private Value<string> _lA;
        public string LA { get { return _lA; } set { _lA = value; } }
        private Value<string> _mA;
        public string MA { get { return _mA; } set { _mA = value; } }
        private Value<string> _mD;
        public string MD { get { return _mD; } set { _mD = value; } }
        private Value<string> _mE;
        public string ME { get { return _mE; } set { _mE = value; } }
        private Value<string> _mI;
        public string MI { get { return _mI; } set { _mI = value; } }
        private Value<string> _mN;
        public string MN { get { return _mN; } set { _mN = value; } }
        private Value<string> _mO;
        public string MO { get { return _mO; } set { _mO = value; } }
        private Value<string> _mS;
        public string MS { get { return _mS; } set { _mS = value; } }
        private Value<string> _mT;
        public string MT { get { return _mT; } set { _mT = value; } }
        private Value<string> _nC;
        public string NC { get { return _nC; } set { _nC = value; } }
        private Value<string> _nD;
        public string ND { get { return _nD; } set { _nD = value; } }
        private Value<string> _nE;
        public string NE { get { return _nE; } set { _nE = value; } }
        private Value<string> _nH;
        public string NH { get { return _nH; } set { _nH = value; } }
        private Value<string> _nJ;
        public string NJ { get { return _nJ; } set { _nJ = value; } }
        private Value<string> _nM;
        public string NM { get { return _nM; } set { _nM = value; } }
        private Value<string> _nV;
        public string NV { get { return _nV; } set { _nV = value; } }
        private Value<string> _nY;
        public string NY { get { return _nY; } set { _nY = value; } }
        private Value<string> _oH;
        public string OH { get { return _oH; } set { _oH = value; } }
        private Value<string> _oK;
        public string OK { get { return _oK; } set { _oK = value; } }
        private Value<string> _oR;
        public string OR { get { return _oR; } set { _oR = value; } }
        private Value<string> _pA;
        public string PA { get { return _pA; } set { _pA = value; } }
        private Value<string> _pR;
        public string PR { get { return _pR; } set { _pR = value; } }
        private Value<string> _rI;
        public string RI { get { return _rI; } set { _rI = value; } }
        private Value<string> _sC;
        public string SC { get { return _sC; } set { _sC = value; } }
        private Value<string> _sD;
        public string SD { get { return _sD; } set { _sD = value; } }
        private Value<string> _stateLicenseType;
        public string StateLicenseType { get { return _stateLicenseType; } set { _stateLicenseType = value; } }
        private Value<string> _tN;
        public string TN { get { return _tN; } set { _tN = value; } }
        private Value<string> _tX;
        public string TX { get { return _tX; } set { _tX = value; } }
        private Value<string> _uT;
        public string UT { get { return _uT; } set { _uT = value; } }
        private Value<string> _vA;
        public string VA { get { return _vA; } set { _vA = value; } }
        private Value<string> _vI;
        public string VI { get { return _vI; } set { _vI = value; } }
        private Value<string> _vT;
        public string VT { get { return _vT; } set { _vT = value; } }
        private Value<string> _wA;
        public string WA { get { return _wA; } set { _wA = value; } }
        private Value<string> _wI;
        public string WI { get { return _wI; } set { _wI = value; } }
        private Value<string> _wV;
        public string WV { get { return _wV; } set { _wV = value; } }
        private Value<string> _wY;
        public string WY { get { return _wY; } set { _wY = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _aK.Clean
                    && _aL.Clean
                    && _aR.Clean
                    && _aZ.Clean
                    && _cA.Clean
                    && _cO.Clean
                    && _cT.Clean
                    && _dC.Clean
                    && _dE.Clean
                    && _fL.Clean
                    && _gA.Clean
                    && _gU.Clean
                    && _hI.Clean
                    && _iA.Clean
                    && _id.Clean
                    && _idaho.Clean
                    && _iL.Clean
                    && _iN.Clean
                    && _kS.Clean
                    && _kY.Clean
                    && _lA.Clean
                    && _mA.Clean
                    && _mD.Clean
                    && _mE.Clean
                    && _mI.Clean
                    && _mN.Clean
                    && _mO.Clean
                    && _mS.Clean
                    && _mT.Clean
                    && _nC.Clean
                    && _nD.Clean
                    && _nE.Clean
                    && _nH.Clean
                    && _nJ.Clean
                    && _nM.Clean
                    && _nV.Clean
                    && _nY.Clean
                    && _oH.Clean
                    && _oK.Clean
                    && _oR.Clean
                    && _pA.Clean
                    && _pR.Clean
                    && _rI.Clean
                    && _sC.Clean
                    && _sD.Clean
                    && _stateLicenseType.Clean
                    && _tN.Clean
                    && _tX.Clean
                    && _uT.Clean
                    && _vA.Clean
                    && _vI.Clean
                    && _vT.Clean
                    && _wA.Clean
                    && _wI.Clean
                    && _wV.Clean
                    && _wY.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var aK = _aK; aK.Clean = value; _aK = aK;
                var aL = _aL; aL.Clean = value; _aL = aL;
                var aR = _aR; aR.Clean = value; _aR = aR;
                var aZ = _aZ; aZ.Clean = value; _aZ = aZ;
                var cA = _cA; cA.Clean = value; _cA = cA;
                var cO = _cO; cO.Clean = value; _cO = cO;
                var cT = _cT; cT.Clean = value; _cT = cT;
                var dC = _dC; dC.Clean = value; _dC = dC;
                var dE = _dE; dE.Clean = value; _dE = dE;
                var fL = _fL; fL.Clean = value; _fL = fL;
                var gA = _gA; gA.Clean = value; _gA = gA;
                var gU = _gU; gU.Clean = value; _gU = gU;
                var hI = _hI; hI.Clean = value; _hI = hI;
                var iA = _iA; iA.Clean = value; _iA = iA;
                var id = _id; id.Clean = value; _id = id;
                var idaho = _idaho; idaho.Clean = value; _idaho = idaho;
                var iL = _iL; iL.Clean = value; _iL = iL;
                var iN = _iN; iN.Clean = value; _iN = iN;
                var kS = _kS; kS.Clean = value; _kS = kS;
                var kY = _kY; kY.Clean = value; _kY = kY;
                var lA = _lA; lA.Clean = value; _lA = lA;
                var mA = _mA; mA.Clean = value; _mA = mA;
                var mD = _mD; mD.Clean = value; _mD = mD;
                var mE = _mE; mE.Clean = value; _mE = mE;
                var mI = _mI; mI.Clean = value; _mI = mI;
                var mN = _mN; mN.Clean = value; _mN = mN;
                var mO = _mO; mO.Clean = value; _mO = mO;
                var mS = _mS; mS.Clean = value; _mS = mS;
                var mT = _mT; mT.Clean = value; _mT = mT;
                var nC = _nC; nC.Clean = value; _nC = nC;
                var nD = _nD; nD.Clean = value; _nD = nD;
                var nE = _nE; nE.Clean = value; _nE = nE;
                var nH = _nH; nH.Clean = value; _nH = nH;
                var nJ = _nJ; nJ.Clean = value; _nJ = nJ;
                var nM = _nM; nM.Clean = value; _nM = nM;
                var nV = _nV; nV.Clean = value; _nV = nV;
                var nY = _nY; nY.Clean = value; _nY = nY;
                var oH = _oH; oH.Clean = value; _oH = oH;
                var oK = _oK; oK.Clean = value; _oK = oK;
                var oR = _oR; oR.Clean = value; _oR = oR;
                var pA = _pA; pA.Clean = value; _pA = pA;
                var pR = _pR; pR.Clean = value; _pR = pR;
                var rI = _rI; rI.Clean = value; _rI = rI;
                var sC = _sC; sC.Clean = value; _sC = sC;
                var sD = _sD; sD.Clean = value; _sD = sD;
                var stateLicenseType = _stateLicenseType; stateLicenseType.Clean = value; _stateLicenseType = stateLicenseType;
                var tN = _tN; tN.Clean = value; _tN = tN;
                var tX = _tX; tX.Clean = value; _tX = tX;
                var uT = _uT; uT.Clean = value; _uT = uT;
                var vA = _vA; vA.Clean = value; _vA = vA;
                var vI = _vI; vI.Clean = value; _vI = vI;
                var vT = _vT; vT.Clean = value; _vT = vT;
                var wA = _wA; wA.Clean = value; _wA = wA;
                var wI = _wI; wI.Clean = value; _wI = wI;
                var wV = _wV; wV.Clean = value; _wV = wV;
                var wY = _wY; wY.Clean = value; _wY = wY;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public StateLicense()
        {
            Clean = true;
        }
    }
}