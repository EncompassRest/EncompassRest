using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class StateLicense
    {
        public Value<string> AK { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAK() => !AK.Clean;
        public Value<string> AL { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAL() => !AL.Clean;
        public Value<string> AR { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAR() => !AR.Clean;
        public Value<string> AZ { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAZ() => !AZ.Clean;
        public Value<string> CA { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCA() => !CA.Clean;
        public Value<string> CO { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCO() => !CO.Clean;
        public Value<string> CT { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCT() => !CT.Clean;
        public Value<string> DC { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDC() => !DC.Clean;
        public Value<string> DE { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDE() => !DE.Clean;
        public Value<string> FL { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFL() => !FL.Clean;
        public Value<string> GA { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGA() => !GA.Clean;
        public Value<string> GU { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGU() => !GU.Clean;
        public Value<string> HI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHI() => !HI.Clean;
        public Value<string> IA { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIA() => !IA.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> Idaho { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIdaho() => !Idaho.Clean;
        public Value<string> IL { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIL() => !IL.Clean;
        public Value<string> IN { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIN() => !IN.Clean;
        public Value<string> KS { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeKS() => !KS.Clean;
        public Value<string> KY { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeKY() => !KY.Clean;
        public Value<string> LA { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLA() => !LA.Clean;
        public Value<string> MA { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMA() => !MA.Clean;
        public Value<string> MD { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMD() => !MD.Clean;
        public Value<string> ME { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeME() => !ME.Clean;
        public Value<string> MI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMI() => !MI.Clean;
        public Value<string> MN { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMN() => !MN.Clean;
        public Value<string> MO { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMO() => !MO.Clean;
        public Value<string> MS { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMS() => !MS.Clean;
        public Value<string> MT { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMT() => !MT.Clean;
        public Value<string> NC { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNC() => !NC.Clean;
        public Value<string> ND { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeND() => !ND.Clean;
        public Value<string> NE { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNE() => !NE.Clean;
        public Value<string> NH { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNH() => !NH.Clean;
        public Value<string> NJ { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNJ() => !NJ.Clean;
        public Value<string> NM { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNM() => !NM.Clean;
        public Value<string> NV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNV() => !NV.Clean;
        public Value<string> NY { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNY() => !NY.Clean;
        public Value<string> OH { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOH() => !OH.Clean;
        public Value<string> OK { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOK() => !OK.Clean;
        public Value<string> OR { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOR() => !OR.Clean;
        public Value<string> PA { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePA() => !PA.Clean;
        public Value<string> PR { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePR() => !PR.Clean;
        public Value<string> RI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRI() => !RI.Clean;
        public Value<string> SC { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSC() => !SC.Clean;
        public Value<string> SD { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSD() => !SD.Clean;
        public Value<string> StateLicenseType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStateLicenseType() => !StateLicenseType.Clean;
        public Value<string> TN { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTN() => !TN.Clean;
        public Value<string> TX { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTX() => !TX.Clean;
        public Value<string> UT { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUT() => !UT.Clean;
        public Value<string> VA { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVA() => !VA.Clean;
        public Value<string> VI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVI() => !VI.Clean;
        public Value<string> VT { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVT() => !VT.Clean;
        public Value<string> WA { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWA() => !WA.Clean;
        public Value<string> WI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWI() => !WI.Clean;
        public Value<string> WV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWV() => !WV.Clean;
        public Value<string> WY { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWY() => !WY.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AK.Clean
                    && AL.Clean
                    && AR.Clean
                    && AZ.Clean
                    && CA.Clean
                    && CO.Clean
                    && CT.Clean
                    && DC.Clean
                    && DE.Clean
                    && FL.Clean
                    && GA.Clean
                    && GU.Clean
                    && HI.Clean
                    && IA.Clean
                    && Id.Clean
                    && Idaho.Clean
                    && IL.Clean
                    && IN.Clean
                    && KS.Clean
                    && KY.Clean
                    && LA.Clean
                    && MA.Clean
                    && MD.Clean
                    && ME.Clean
                    && MI.Clean
                    && MN.Clean
                    && MO.Clean
                    && MS.Clean
                    && MT.Clean
                    && NC.Clean
                    && ND.Clean
                    && NE.Clean
                    && NH.Clean
                    && NJ.Clean
                    && NM.Clean
                    && NV.Clean
                    && NY.Clean
                    && OH.Clean
                    && OK.Clean
                    && OR.Clean
                    && PA.Clean
                    && PR.Clean
                    && RI.Clean
                    && SC.Clean
                    && SD.Clean
                    && StateLicenseType.Clean
                    && TN.Clean
                    && TX.Clean
                    && UT.Clean
                    && VA.Clean
                    && VI.Clean
                    && VT.Clean
                    && WA.Clean
                    && WI.Clean
                    && WV.Clean
                    && WY.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AK; v0.Clean = value; AK = v0;
                var v1 = AL; v1.Clean = value; AL = v1;
                var v2 = AR; v2.Clean = value; AR = v2;
                var v3 = AZ; v3.Clean = value; AZ = v3;
                var v4 = CA; v4.Clean = value; CA = v4;
                var v5 = CO; v5.Clean = value; CO = v5;
                var v6 = CT; v6.Clean = value; CT = v6;
                var v7 = DC; v7.Clean = value; DC = v7;
                var v8 = DE; v8.Clean = value; DE = v8;
                var v9 = FL; v9.Clean = value; FL = v9;
                var v10 = GA; v10.Clean = value; GA = v10;
                var v11 = GU; v11.Clean = value; GU = v11;
                var v12 = HI; v12.Clean = value; HI = v12;
                var v13 = IA; v13.Clean = value; IA = v13;
                var v14 = Id; v14.Clean = value; Id = v14;
                var v15 = Idaho; v15.Clean = value; Idaho = v15;
                var v16 = IL; v16.Clean = value; IL = v16;
                var v17 = IN; v17.Clean = value; IN = v17;
                var v18 = KS; v18.Clean = value; KS = v18;
                var v19 = KY; v19.Clean = value; KY = v19;
                var v20 = LA; v20.Clean = value; LA = v20;
                var v21 = MA; v21.Clean = value; MA = v21;
                var v22 = MD; v22.Clean = value; MD = v22;
                var v23 = ME; v23.Clean = value; ME = v23;
                var v24 = MI; v24.Clean = value; MI = v24;
                var v25 = MN; v25.Clean = value; MN = v25;
                var v26 = MO; v26.Clean = value; MO = v26;
                var v27 = MS; v27.Clean = value; MS = v27;
                var v28 = MT; v28.Clean = value; MT = v28;
                var v29 = NC; v29.Clean = value; NC = v29;
                var v30 = ND; v30.Clean = value; ND = v30;
                var v31 = NE; v31.Clean = value; NE = v31;
                var v32 = NH; v32.Clean = value; NH = v32;
                var v33 = NJ; v33.Clean = value; NJ = v33;
                var v34 = NM; v34.Clean = value; NM = v34;
                var v35 = NV; v35.Clean = value; NV = v35;
                var v36 = NY; v36.Clean = value; NY = v36;
                var v37 = OH; v37.Clean = value; OH = v37;
                var v38 = OK; v38.Clean = value; OK = v38;
                var v39 = OR; v39.Clean = value; OR = v39;
                var v40 = PA; v40.Clean = value; PA = v40;
                var v41 = PR; v41.Clean = value; PR = v41;
                var v42 = RI; v42.Clean = value; RI = v42;
                var v43 = SC; v43.Clean = value; SC = v43;
                var v44 = SD; v44.Clean = value; SD = v44;
                var v45 = StateLicenseType; v45.Clean = value; StateLicenseType = v45;
                var v46 = TN; v46.Clean = value; TN = v46;
                var v47 = TX; v47.Clean = value; TX = v47;
                var v48 = UT; v48.Clean = value; UT = v48;
                var v49 = VA; v49.Clean = value; VA = v49;
                var v50 = VI; v50.Clean = value; VI = v50;
                var v51 = VT; v51.Clean = value; VT = v51;
                var v52 = WA; v52.Clean = value; WA = v52;
                var v53 = WI; v53.Clean = value; WI = v53;
                var v54 = WV; v54.Clean = value; WV = v54;
                var v55 = WY; v55.Clean = value; WY = v55;
                _settingClean = 0;
            }
        }
    }
}