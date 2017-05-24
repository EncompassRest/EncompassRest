using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class TQLReportInformation
    {
        public Value<string> AltId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAltId() => !AltId.Clean;
        public Value<string> BorrowerID1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerID1() => !BorrowerID1.Clean;
        public Value<string> BorrowerID2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerID2() => !BorrowerID2.Clean;
        public Value<string> BorrowerID3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerID3() => !BorrowerID3.Clean;
        public Value<string> BorrowerID4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerID4() => !BorrowerID4.Clean;
        public Value<DateTime?> CompletedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompletedDate() => !CompletedDate.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> Investor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestor() => !Investor.Clean;
        public Value<DateTime?> OrderDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrderDate() => !OrderDate.Clean;
        public Value<string> OrderNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrderNumber() => !OrderNumber.Clean;
        public Value<string> OrderStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOrderStatus() => !OrderStatus.Clean;
        public Value<decimal?> PercentVariance1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentVariance1() => !PercentVariance1.Clean;
        public Value<decimal?> PercentVariance2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentVariance2() => !PercentVariance2.Clean;
        public Value<decimal?> PercentVariance3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentVariance3() => !PercentVariance3.Clean;
        public Value<decimal?> PercentVariance4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentVariance4() => !PercentVariance4.Clean;
        public Value<string> ProductsOrdered { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProductsOrdered() => !ProductsOrdered.Clean;
        public Value<string> ReportYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReportYear1() => !ReportYear1.Clean;
        public Value<string> ReportYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReportYear2() => !ReportYear2.Clean;
        public Value<string> ReportYear3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReportYear3() => !ReportYear3.Clean;
        public Value<string> ReportYear4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReportYear4() => !ReportYear4.Clean;
        public Value<decimal?> TotalIncome1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalIncome1() => !TotalIncome1.Clean;
        public Value<decimal?> TotalIncome2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalIncome2() => !TotalIncome2.Clean;
        public Value<decimal?> TotalIncome3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalIncome3() => !TotalIncome3.Clean;
        public Value<decimal?> TotalIncome4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalIncome4() => !TotalIncome4.Clean;
        public Value<string> TranscriptType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTranscriptType() => !TranscriptType.Clean;
        public Value<string> UserID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserID() => !UserID.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AltId.Clean
                    && BorrowerID1.Clean
                    && BorrowerID2.Clean
                    && BorrowerID3.Clean
                    && BorrowerID4.Clean
                    && CompletedDate.Clean
                    && Id.Clean
                    && Investor.Clean
                    && OrderDate.Clean
                    && OrderNumber.Clean
                    && OrderStatus.Clean
                    && PercentVariance1.Clean
                    && PercentVariance2.Clean
                    && PercentVariance3.Clean
                    && PercentVariance4.Clean
                    && ProductsOrdered.Clean
                    && ReportYear1.Clean
                    && ReportYear2.Clean
                    && ReportYear3.Clean
                    && ReportYear4.Clean
                    && TotalIncome1.Clean
                    && TotalIncome2.Clean
                    && TotalIncome3.Clean
                    && TotalIncome4.Clean
                    && TranscriptType.Clean
                    && UserID.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AltId; v0.Clean = value; AltId = v0;
                var v1 = BorrowerID1; v1.Clean = value; BorrowerID1 = v1;
                var v2 = BorrowerID2; v2.Clean = value; BorrowerID2 = v2;
                var v3 = BorrowerID3; v3.Clean = value; BorrowerID3 = v3;
                var v4 = BorrowerID4; v4.Clean = value; BorrowerID4 = v4;
                var v5 = CompletedDate; v5.Clean = value; CompletedDate = v5;
                var v6 = Id; v6.Clean = value; Id = v6;
                var v7 = Investor; v7.Clean = value; Investor = v7;
                var v8 = OrderDate; v8.Clean = value; OrderDate = v8;
                var v9 = OrderNumber; v9.Clean = value; OrderNumber = v9;
                var v10 = OrderStatus; v10.Clean = value; OrderStatus = v10;
                var v11 = PercentVariance1; v11.Clean = value; PercentVariance1 = v11;
                var v12 = PercentVariance2; v12.Clean = value; PercentVariance2 = v12;
                var v13 = PercentVariance3; v13.Clean = value; PercentVariance3 = v13;
                var v14 = PercentVariance4; v14.Clean = value; PercentVariance4 = v14;
                var v15 = ProductsOrdered; v15.Clean = value; ProductsOrdered = v15;
                var v16 = ReportYear1; v16.Clean = value; ReportYear1 = v16;
                var v17 = ReportYear2; v17.Clean = value; ReportYear2 = v17;
                var v18 = ReportYear3; v18.Clean = value; ReportYear3 = v18;
                var v19 = ReportYear4; v19.Clean = value; ReportYear4 = v19;
                var v20 = TotalIncome1; v20.Clean = value; TotalIncome1 = v20;
                var v21 = TotalIncome2; v21.Clean = value; TotalIncome2 = v21;
                var v22 = TotalIncome3; v22.Clean = value; TotalIncome3 = v22;
                var v23 = TotalIncome4; v23.Clean = value; TotalIncome4 = v23;
                var v24 = TranscriptType; v24.Clean = value; TranscriptType = v24;
                var v25 = UserID; v25.Clean = value; UserID = v25;
                _settingClean = 0;
            }
        }
    }
}