using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v0 = _aK; v0.Clean = value; _aK = v0;
                var v1 = _aL; v1.Clean = value; _aL = v1;
                var v2 = _aR; v2.Clean = value; _aR = v2;
                var v3 = _aZ; v3.Clean = value; _aZ = v3;
                var v4 = _cA; v4.Clean = value; _cA = v4;
                var v5 = _cO; v5.Clean = value; _cO = v5;
                var v6 = _cT; v6.Clean = value; _cT = v6;
                var v7 = _dC; v7.Clean = value; _dC = v7;
                var v8 = _dE; v8.Clean = value; _dE = v8;
                var v9 = _fL; v9.Clean = value; _fL = v9;
                var v10 = _gA; v10.Clean = value; _gA = v10;
                var v11 = _gU; v11.Clean = value; _gU = v11;
                var v12 = _hI; v12.Clean = value; _hI = v12;
                var v13 = _iA; v13.Clean = value; _iA = v13;
                var v14 = _id; v14.Clean = value; _id = v14;
                var v15 = _idaho; v15.Clean = value; _idaho = v15;
                var v16 = _iL; v16.Clean = value; _iL = v16;
                var v17 = _iN; v17.Clean = value; _iN = v17;
                var v18 = _kS; v18.Clean = value; _kS = v18;
                var v19 = _kY; v19.Clean = value; _kY = v19;
                var v20 = _lA; v20.Clean = value; _lA = v20;
                var v21 = _mA; v21.Clean = value; _mA = v21;
                var v22 = _mD; v22.Clean = value; _mD = v22;
                var v23 = _mE; v23.Clean = value; _mE = v23;
                var v24 = _mI; v24.Clean = value; _mI = v24;
                var v25 = _mN; v25.Clean = value; _mN = v25;
                var v26 = _mO; v26.Clean = value; _mO = v26;
                var v27 = _mS; v27.Clean = value; _mS = v27;
                var v28 = _mT; v28.Clean = value; _mT = v28;
                var v29 = _nC; v29.Clean = value; _nC = v29;
                var v30 = _nD; v30.Clean = value; _nD = v30;
                var v31 = _nE; v31.Clean = value; _nE = v31;
                var v32 = _nH; v32.Clean = value; _nH = v32;
                var v33 = _nJ; v33.Clean = value; _nJ = v33;
                var v34 = _nM; v34.Clean = value; _nM = v34;
                var v35 = _nV; v35.Clean = value; _nV = v35;
                var v36 = _nY; v36.Clean = value; _nY = v36;
                var v37 = _oH; v37.Clean = value; _oH = v37;
                var v38 = _oK; v38.Clean = value; _oK = v38;
                var v39 = _oR; v39.Clean = value; _oR = v39;
                var v40 = _pA; v40.Clean = value; _pA = v40;
                var v41 = _pR; v41.Clean = value; _pR = v41;
                var v42 = _rI; v42.Clean = value; _rI = v42;
                var v43 = _sC; v43.Clean = value; _sC = v43;
                var v44 = _sD; v44.Clean = value; _sD = v44;
                var v45 = _stateLicenseType; v45.Clean = value; _stateLicenseType = v45;
                var v46 = _tN; v46.Clean = value; _tN = v46;
                var v47 = _tX; v47.Clean = value; _tX = v47;
                var v48 = _uT; v48.Clean = value; _uT = v48;
                var v49 = _vA; v49.Clean = value; _vA = v49;
                var v50 = _vI; v50.Clean = value; _vI = v50;
                var v51 = _vT; v51.Clean = value; _vT = v51;
                var v52 = _wA; v52.Clean = value; _wA = v52;
                var v53 = _wI; v53.Clean = value; _wI = v53;
                var v54 = _wV; v54.Clean = value; _wV = v54;
                var v55 = _wY; v55.Clean = value; _wY = v55;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}