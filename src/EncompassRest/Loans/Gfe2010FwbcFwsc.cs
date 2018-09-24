using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Gfe2010FwbcFwsc
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(Gfe2010FwbcFwscIndex) + "," + nameof(LineLetter) + "," + nameof(LineNumber))]
    public sealed partial class Gfe2010FwbcFwsc : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _fwbc;
        private DirtyValue<string> _fwsc;
        private DirtyValue<int?> _gfe2010FwbcFwscIndex;
        private DirtyValue<string> _id;
        private DirtyValue<StringEnumValue<LineLetter>> _lineLetter;
        private DirtyValue<int?> _lineNumber;

        /// <summary>
        /// Gfe2010FwbcFwsc Fwbc
        /// </summary>
        public string Fwbc { get => _fwbc; set => SetField(ref _fwbc, value); }

        /// <summary>
        /// Gfe2010FwbcFwsc Fwsc
        /// </summary>
        public string Fwsc { get => _fwsc; set => SetField(ref _fwsc, value); }

        /// <summary>
        /// Gfe2010FwbcFwsc Gfe2010FwbcFwscIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"0\":\"0\",\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\",\"5\":\"5\",\"6\":\"6\"}")]
        public int? Gfe2010FwbcFwscIndex { get => _gfe2010FwbcFwscIndex; set => SetField(ref _gfe2010FwbcFwscIndex, value); }

        /// <summary>
        /// Gfe2010FwbcFwsc Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Gfe2010FwbcFwsc LineLetter
        /// </summary>
        public StringEnumValue<LineLetter> LineLetter { get => _lineLetter; set => SetField(ref _lineLetter, value); }

        /// <summary>
        /// Gfe2010FwbcFwsc LineNumber
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"802\":\"802\",\"808\":\"808\",\"809\":\"809\",\"810\":\"810\",\"811\":\"811\",\"812\":\"812\",\"813\":\"813\",\"814\":\"814\",\"815\":\"815\",\"816\":\"816\",\"817\":\"817\",\"1001\":\"1001\",\"1101\":\"1101\",\"1103\":\"1103\",\"1104\":\"1104\",\"1110\":\"1110\",\"1203\":\"1203\",\"1301\":\"1301\",\"1302\":\"1302\",\"1310\":\"1310\",\"1311\":\"1311\",\"807\":\"807\",\"904\":\"904\",\"909\":\"909\",\"910\":\"910\",\"1107\":\"1107\",\"1108\":\"1108\",\"1109\":\"1109\",\"801\":\"801\",\"911\":\"911\",\"912\":\"912\",\"1312\":\"1312\",\"1313\":\"1313\",\"1314\":\"1314\",\"1315\":\"1315\",\"701\":\"701\",\"702\":\"702\",\"704\":\"704\",\"803\":\"803\",\"1102\":\"1102\",\"103\":\"103\",\"106\":\"106\",\"107\":\"107\",\"115\":\"115\",\"205\":\"205\",\"206\":\"206\",\"207\":\"207\",\"208\":\"208\",\"209\":\"209\",\"210\":\"210\",\"211\":\"211\",\"306\":\"306\",\"307\":\"307\",\"308\":\"308\",\"316\":\"316\",\"402\":\"402\",\"408\":\"408\",\"411\":\"411\",\"412\":\"412\",\"413\":\"413\",\"501\":\"501\",\"502\":\"502\",\"503\":\"503\",\"504\":\"504\",\"505\":\"505\",\"506\":\"506\",\"507\":\"507\",\"508\":\"508\",\"509\":\"509\",\"510\":\"510\",\"511\":\"511\",\"512\":\"512\",\"513\":\"513\",\"514\":\"514\",\"515\":\"515\",\"1316\":\"1316\",\"1317\":\"1317\",\"1318\":\"1318\",\"1319\":\"1319\",\"1320\":\"1320\"}")]
        public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }
    }
}