using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// RespaHudDetail
    /// </summary>
    public sealed partial class RespaHudDetail : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<CreditDebt>> _creditDebt;
        /// <summary>
        /// RespaHudDetail CreditDebt
        /// </summary>
        public StringEnumValue<CreditDebt> CreditDebt { get => _creditDebt; set => SetField(ref _creditDebt, value); }
        private DirtyValue<string> _fWBC;
        /// <summary>
        /// RespaHudDetail FWBC
        /// </summary>
        public string FWBC { get => _fWBC; set => SetField(ref _fWBC, value); }
        private DirtyValue<DateTime?> _hUD1LineItemFromDate;
        /// <summary>
        /// RespaHudDetail HUD1LineItemFromDate
        /// </summary>
        public DateTime? HUD1LineItemFromDate { get => _hUD1LineItemFromDate; set => SetField(ref _hUD1LineItemFromDate, value); }
        private DirtyValue<DateTime?> _hUD1LineItemToDate;
        /// <summary>
        /// RespaHudDetail HUD1LineItemToDate
        /// </summary>
        public DateTime? HUD1LineItemToDate { get => _hUD1LineItemToDate; set => SetField(ref _hUD1LineItemToDate, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// RespaHudDetail Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _lineItemAmount;
        /// <summary>
        /// RespaHudDetail LineItemAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LineItemAmount { get => _lineItemAmount; set => SetField(ref _lineItemAmount, value); }
        private DirtyValue<string> _lineItemDescription;
        /// <summary>
        /// RespaHudDetail LineItemDescription
        /// </summary>
        public string LineItemDescription { get => _lineItemDescription; set => SetField(ref _lineItemDescription, value); }
        private DirtyValue<int?> _lineNumber;
        /// <summary>
        /// RespaHudDetail LineNumber
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"107\":\"107\",\"407\":\"407\",\"108\":\"108\",\"408\":\"408\",\"109\":\"109\",\"409\":\"409\",\"110\":\"110\",\"410\":\"410\",\"111\":\"111\",\"411\":\"411\",\"112\":\"112\",\"412\":\"412\",\"120\":\"120\",\"420\":\"420\",\"201\":\"201\",\"501\":\"501\",\"203\":\"203\",\"503\":\"503\",\"204\":\"204\",\"504\":\"504\",\"205\":\"205\",\"505\":\"505\",\"206\":\"206\",\"506\":\"506\",\"207\":\"207\",\"507\":\"507\",\"208\":\"208\",\"508\":\"508\",\"209\":\"209\",\"509\":\"509\",\"210\":\"210\",\"510\":\"510\",\"211\":\"211\",\"511\":\"511\",\"212\":\"212\",\"512\":\"512\",\"213\":\"213\",\"513\":\"513\",\"214\":\"214\",\"514\":\"514\",\"215\":\"215\",\"515\":\"515\",\"216\":\"216\",\"516\":\"516\",\"217\":\"217\",\"517\":\"517\",\"218\":\"218\",\"518\":\"518\",\"219\":\"219\",\"519\":\"519\",\"220\":\"220\",\"520\":\"520\",\"303\":\"303\",\"603\":\"603\",\"103\":\"103\",\"502\":\"502\",\"102\":\"102\",\"402\":\"402\",\"403\":\"403\",\"104\":\"104\",\"404\":\"404\",\"105\":\"105\",\"405\":\"405\",\"106\":\"106\",\"406\":\"406\",\"101\":\"101\",\"202\":\"202\",\"401\":\"401\",\"153\":\"153\",\"156\":\"156\",\"157\":\"157\",\"165\":\"165\",\"255\":\"255\",\"256\":\"256\",\"257\":\"257\",\"258\":\"258\",\"259\":\"259\",\"260\":\"260\",\"261\":\"261\",\"456\":\"456\",\"457\":\"457\",\"458\":\"458\",\"466\":\"466\",\"552\":\"552\",\"558\":\"558\",\"561\":\"561\",\"562\":\"562\",\"563\":\"563\",\"51\":\"51\",\"52\":\"52\",\"53\":\"53\",\"54\":\"54\",\"55\":\"55\",\"56\":\"56\",\"57\":\"57\",\"58\":\"58\",\"59\":\"59\",\"60\":\"60\",\"61\":\"61\",\"62\":\"62\",\"63\":\"63\",\"64\":\"64\",\"65\":\"65\",\"824\":\"824\",\"825\":\"825\"}")]
        public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }
        private DirtyValue<decimal?> _realValue;
        /// <summary>
        /// RespaHudDetail RealValue
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? RealValue { get => _realValue; set => SetField(ref _realValue, value); }
    }
}