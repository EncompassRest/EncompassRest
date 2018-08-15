using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Gfe2010WholePoc
    /// </summary>
    public sealed partial class Gfe2010WholePoc : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _gfe2010WholePocIndex;
        /// <summary>
        /// Gfe2010WholePoc Gfe2010WholePocIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\",\"5\":\"5\",\"6\":\"6\",\"7\":\"7\",\"8\":\"8\",\"9\":\"9\",\"10\":\"10\",\"0\":\"0\",\"11\":\"11\",\"12\":\"12\",\"13\":\"13\",\"14\":\"14\",\"15\":\"15\",\"16\":\"16\",\"17\":\"17\"}")]
        public int? Gfe2010WholePocIndex { get => _gfe2010WholePocIndex; set => SetField(ref _gfe2010WholePocIndex, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Gfe2010WholePoc Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<int?> _lineNumber;
        /// <summary>
        /// Gfe2010WholePoc LineNumber
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"801\":\"801\",\"802\":\"802\",\"804\":\"804\",\"805\":\"805\",\"806\":\"806\",\"807\":\"807\",\"808\":\"808\",\"809\":\"809\",\"810\":\"810\",\"811\":\"811\",\"812\":\"812\",\"813\":\"813\",\"814\":\"814\",\"815\":\"815\",\"816\":\"816\",\"817\":\"817\",\"818\":\"818\",\"819\":\"819\",\"901\":\"901\",\"902\":\"902\",\"903\":\"903\",\"904\":\"904\",\"905\":\"905\",\"906\":\"906\",\"907\":\"907\",\"908\":\"908\",\"909\":\"909\",\"910\":\"910\",\"1102\":\"1102\",\"1103\":\"1103\",\"1104\":\"1104\",\"1109\":\"1109\",\"1110\":\"1110\",\"1111\":\"1111\",\"1112\":\"1112\",\"1113\":\"1113\",\"1114\":\"1114\",\"1202\":\"1202\",\"1203\":\"1203\",\"1204\":\"1204\",\"1205\":\"1205\",\"1206\":\"1206\",\"1207\":\"1207\",\"1208\":\"1208\",\"1302\":\"1302\",\"1303\":\"1303\",\"1304\":\"1304\",\"1305\":\"1305\",\"1306\":\"1306\",\"1307\":\"1307\",\"1308\":\"1308\",\"1309\":\"1309\",\"1310\":\"1310\",\"1311\":\"1311\",\"820\":\"820\",\"821\":\"821\",\"822\":\"822\",\"823\":\"823\",\"824\":\"824\",\"825\":\"825\",\"826\":\"826\",\"827\":\"827\",\"828\":\"828\",\"829\":\"829\",\"830\":\"830\",\"831\":\"831\",\"832\":\"832\",\"833\":\"833\",\"834\":\"834\",\"835\":\"835\",\"911\":\"911\",\"912\":\"912\",\"1115\":\"1115\",\"1116\":\"1116\",\"1209\":\"1209\",\"1210\":\"1210\",\"1312\":\"1312\",\"1313\":\"1313\",\"1314\":\"1314\",\"1315\":\"1315\"}")]
        public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }
        private DirtyValue<decimal?> _wholePoc;
        /// <summary>
        /// Gfe2010WholePoc WholePoc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? WholePoc { get => _wholePoc; set => SetField(ref _wholePoc, value); }
        private DirtyValue<StringEnumValue<WholePocPaidByType>> _wholePocPaidByType;
        /// <summary>
        /// Gfe2010WholePoc WholePocPaidByType
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Other\":\"O\"}")]
        public StringEnumValue<WholePocPaidByType> WholePocPaidByType { get => _wholePocPaidByType; set => SetField(ref _wholePocPaidByType, value); }
    }
}